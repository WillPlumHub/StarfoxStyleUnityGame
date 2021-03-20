using UnityEngine;
using System.Collections;

public class exit : MonoBehaviour
{

    public Texture btnTexture;

    void OnGUI()
    {
        if (!btnTexture)
        {
            Debug.LogError("Please assign a texture on the inspector");
            return;
        }
        if (GUI.Button(new Rect(1500, 70, 50, 30), btnTexture))
            Application.Quit();
    }
}
