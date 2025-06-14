using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginPanel : MonoBehaviour
{
    private static BeginPanel instance;
    public static void ShowMe()
    {
        if (instance != null)
        {
            instance.gameObject.SetActive(true);
        }
    }

    public static void HideMe()
    {
        if (instance != null)
        {
            instance.gameObject.SetActive(false);
        }
    }

    //title
    public Rect labRect;
    public GUIContent labContent;
    public GUIStyle labStyle;

    //button
    public Rect buttonRect_GameBegin;
    public Rect buttonRect_GameEnd;
    public Rect buttonRect_Exc;

    public GUIStyle buttonstyle;

    //Texture
    public Rect backGroundTextureRect;

    public Texture backGroundTexture;

   

    public void Awake()
    {
        instance = this;
        ShowMe();
    }

    private void OnGUI()
    {
        GUI.DrawTexture(backGroundTextureRect, backGroundTexture);

        GUI.Label(labRect, labContent, labStyle);

        //点击开始游戏切换场景
        if (GUI.Button(buttonRect_GameBegin, "开始游戏", buttonstyle))
        {
            BeginPanel.HideMe();
            LogPanel.ShowMe();
        }
         
        if (GUI.Button(buttonRect_GameEnd, "退出游戏", buttonstyle))
        {
            QuitTipPanel.ShowMe();
            BeginPanel.HideMe();
        }

        if (GUI.Button(buttonRect_Exc, "设置", buttonstyle))
        {
            HideMe();
            BeginPanel.HideMe();
            SettingPanel.ShowMe();
        }
    }
}
