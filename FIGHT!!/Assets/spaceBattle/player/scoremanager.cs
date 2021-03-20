using UnityEngine;
using System.Collections;

public class scoremanager : MonoBehaviour {

    public int currentLevel = 1;
    public int[] levelScoreThreshhold;
    public int score = 0;

    public delegate void LevelChangedEvent(int newLevel);
    public event LevelChangedEvent LevelChanged;

void OnGUI()
    {
        GUILayout.Label("Score: " + score);
    }

    void Update()
    {
        if (score > levelScoreThreshhold[currentLevel])
        {
            currentLevel += 1;
            LevelChanged(currentLevel);
        }
    }

    #region SingletonAndAwake
    private static scoremanager instance = null;
    public static scoremanager Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
        gameObject.name = "$scoremanager";
    }
    #endregion
}