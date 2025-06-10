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

    //�������������
    public string usernameStr;
    public string passwordStr;

    public void Awake()
    {
        instance = this;
        HideMe();
    }
    private void OnGUI()
    {
        GUI.Label(titleLabelRect, "���¼", titleStyle);

        usernameStr = GUI.TextField(usernameInputFieldRect, usernameStr);
        passwordStr = GUI.TextField(passwordInputFieldRect, passwordStr);

        if (GUI.Button(backButtonRect, "����", confirmButtonStyle))
        {
            LogPanel.HideMe();
            BeginPanel.ShowMe();
        }


        if (GUI.Button(confirmButtonRect, "ȷ�ϵ�¼", confirmButtonStyle))
        {
            if (usernameStr == "admin")
            {
                if (passwordStr == "8888")
                {
                    SceneManager.LoadScene("GameScene");
                }
                else if(passwordStr == null ||  passwordStr != "8888")
                {
                    Debug.Log("�������");
                }
            }
            else if(usernameStr == null || usernameStr != "admin")
            {
                Debug.Log("�û�������");
            }
        }
    }
}
