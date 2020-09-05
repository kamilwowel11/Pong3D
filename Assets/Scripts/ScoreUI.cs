using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public float scorePlayer;
    public float scoreEnemy;
    public GUIStyle style;

    

    private void OnGUI()
    {
        float x = Screen.width / 2f;
        float y = 250f;
        float widht = 300f;
        float height = 20f;
        string text = scorePlayer + "/" + scoreEnemy;

        GUI.Label(new Rect(x - (widht / 2f), y, widht, height), text, style);
    }
}
