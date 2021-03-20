var timer : float = 10.0;

function Update ()
{
    timer -= Time.deltaTime;

    if (timer <= 0)
    {
        Application.LoadLevel("characterSelect");
    }
}

function OnGUI ()
{
    GUI.Box(Rect(10, 10, 50, 20), "" + timer.ToString("0"));
}