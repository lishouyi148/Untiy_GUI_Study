using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogPanel : MonoBehaviour
{
    private static LogPanel instance;
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

    //Rect
    public Rect titleLabelRect;
    public Rect usernameInputFieldRect;
    public Rect passwordInputFieldRect;
    public Rect confirmButtonRect;
    public Rect backButtonRect;

    //Content

    //Style
    public GUIStyle titleStyle;
    public GUIStyle confirmButtonStyle;

    //输入框输入内容
    public string usernameStr;
    public string passwordStr;

    public void Awake()
    {
        instance = this;
        HideMe();
    }
    private void OnGUI()
    {
        GUI.Label(titleLabelRect, "请登录", titleStyle);

        usernameStr = GUI.TextField(usernameInputFieldRect, usernameStr);
        passwordStr = GUI.TextField(passwordInputFieldRect, passwordStr);

        if (GUI.Button(backButtonRect, "返回", confirmButtonStyle))
        {
            LogPanel.HideMe();
            BeginPanel.ShowMe();
        }


        if (GUI.Button(confirmButtonRect, "确认登录", confirmButtonStyle))
        {
            if (usernameStr == "admin")
            {
                if (passwordStr == "8888")
                {
                    SceneManager.LoadScene("GameScene");
                }
                else if(passwordStr == null ||  passwordStr != "8888")
                {
                    Debug.Log("密码错误");
                }
            }
            else if(usernameStr == null || usernameStr != "admin")
            {
                Debug.Log("用户名错误");
            }
        }
    }
}
