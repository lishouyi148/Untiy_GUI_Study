using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson8 : MonoBehaviour
{
    private void OnGUI()
    {
        GUI.Window(1, new Rect(0, 0, 100, 100), DrawWindow, "���Դ���"); 
    }

    private void DrawWindow(int id)
    {

    }
}
