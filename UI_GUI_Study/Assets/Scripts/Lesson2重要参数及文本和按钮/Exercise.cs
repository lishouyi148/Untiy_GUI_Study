using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exercise : MonoBehaviour
{
    public Rect labRect;
    public GUIContent labContent;
    public GUIStyle labStyle;

    public Rect butRect_GameBegin;
    public Rect butRect_GameEnd;
    public Rect butRect_Exc;

    public GUIStyle butstyle;

    private void OnGUI()
    {
        GUI.Label(labRect, labContent, labStyle);

        //点击开始游戏切换场景
        if (GUI.Button(butRect_GameBegin, "游戏开始", butstyle))
        {
            SceneManager.LoadScene("GameScene");
        }
         
        if (GUI.Button(butRect_GameEnd, "退出游戏", butstyle))
        {

        }

        if (GUI.Button(butRect_Exc, "设置", butstyle))
        {

        }
    }
}
