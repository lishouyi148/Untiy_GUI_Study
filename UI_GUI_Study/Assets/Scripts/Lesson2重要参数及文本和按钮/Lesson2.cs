using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour
{
    public Rect rect;
    public GUIStyle style;

    public GUIContent butContent;
    public GUIStyle butStyle;
    void OnGUI()
    {
        //GUI.Label(rect, "»¶Ó­Äã", style);

        GUI.Button(rect, butContent);
    }
}
