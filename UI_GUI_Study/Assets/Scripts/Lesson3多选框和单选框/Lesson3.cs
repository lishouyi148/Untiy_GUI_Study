using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{

    private int nowSelIndex = 1;
    public GUIStyle style;
    private void OnGUI()
    {
       
        //��ѡ��
        if(GUI.Toggle(new Rect(0, 100, 100, 40), nowSelIndex == 1, "ѡ��1"))
        {
            nowSelIndex = 1;
            print($"ѡ��1��{nowSelIndex}");
        }
        if( GUI.Toggle( new Rect(0, 140, 100, 40), nowSelIndex == 2, "ѡ��2"))
        {
            nowSelIndex = 2;
            print($"ѡ��2��{nowSelIndex}");
        }
        if( GUI.Toggle(new Rect(0, 180, 100, 40), nowSelIndex == 3, "ѡ��3"))
        {
            nowSelIndex = 3;
            print($"ѡ��3��{nowSelIndex}");
        }
    }
}
