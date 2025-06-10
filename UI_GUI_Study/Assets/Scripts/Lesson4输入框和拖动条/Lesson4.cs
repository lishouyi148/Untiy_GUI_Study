using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    public string inputStr;
    public string inputPW;

    public float nowValue;
    private void OnGUI()
    {
        inputStr = GUI.TextField(new Rect(0, 0, 100, 40), inputStr);

        inputPW = GUI.PasswordField(new Rect(0, 40, 100, 40), inputPW, '*');

        nowValue = GUI.HorizontalSlider(new Rect(0, 80, 100, 30), nowValue, 0, 1);

        nowValue = GUI.VerticalSlider(new Rect(0, 120, 30, 100), nowValue, 0, 1);
    }
}
