using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7 : MonoBehaviour
{
    public Rect groupPos;

    public Rect scPos;
    public Vector2 nowPos;
    public Rect showPos;

    private string[] strs = new string[] { "123", " 234", "223", "444" };
    private void OnGUI()
    {
        GUI.BeginGroup(groupPos);
        GUI.Button(new Rect(0, 0, 100, 50), "≤‚ ‘∞¥≈•");
        GUI.Label(new Rect(0, 50, 100, 50), "≤‚ ‘Œƒ∞∏");
        GUI.EndGroup();

        nowPos = GUI.BeginScrollView(scPos, nowPos, showPos);
        GUI.Toolbar(new Rect(0, 0, 300, 50), 0, strs);
        GUI.Toolbar(new Rect(0, 60, 300, 50), 0, strs);
        GUI.Toolbar(new Rect(0, 120, 300, 50), 0, strs);
        GUI.Toolbar(new Rect(0, 180, 300, 50), 0, strs);
        GUI.EndScrollView();
    }
}
