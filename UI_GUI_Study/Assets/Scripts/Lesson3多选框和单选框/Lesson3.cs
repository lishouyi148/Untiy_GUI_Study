using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{

    private int nowSelIndex = 1;
    public GUIStyle style;
    private void OnGUI()
    {
       
        //单选框
        if(GUI.Toggle(new Rect(0, 100, 100, 40), nowSelIndex == 1, "选择1"))
        {
            nowSelIndex = 1;
            print($"选择1：{nowSelIndex}");
        }
        if( GUI.Toggle( new Rect(0, 140, 100, 40), nowSelIndex == 2, "选择2"))
        {
            nowSelIndex = 2;
            print($"选择2：{nowSelIndex}");
        }
        if( GUI.Toggle(new Rect(0, 180, 100, 40), nowSelIndex == 3, "选择3"))
        {
            nowSelIndex = 3;
            print($"选择3：{nowSelIndex}");
        }
    }
}
