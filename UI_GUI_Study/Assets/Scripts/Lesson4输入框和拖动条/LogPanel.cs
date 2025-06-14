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

    //title
    public Rect titleLabelRect;
    public GUIStyle titleStyle;

    //InputField
    public Rect usernameInputFieldRect;
    public Rect passwordInputFieldRect;

    public string usernameStr;
    public string passwordStr;

    //Button
    public Rect confirmButtonRect;
    public Rect backButtonRect;

    public GUIStyle confirmButtonStyle;

    //Texture
    public Rect backGroundTextureRect;

    public Texture backGroundTexture;


    public void Awake()
    {
        instance = this;
        HideMe();
    }
    private void OnGUI()
    {
        GUI.DrawTexture(backGroundTextureRect, backGroundTexture);

        GUI.Label(titleLabelRect, "ÇëµÇÂ¼", titleStyle);

        usernameStr = GUI.TextField(usernameInputFieldRect, usernameStr);
        passwordStr = GUI.TextField(passwordInputFieldRect, passwordStr);

        if (GUI.Button(backButtonRect, "·µ»Ø", confirmButtonStyle))
        {
            LogPanel.HideMe();
            BeginPanel.ShowMe();
        }


        if (GUI.Button(confirmButtonRect, "È·ÈÏµÇÂ¼", confirmButtonStyle))
        {
            if (usernameStr == "admin")
            {
                if (passwordStr == "8888")
                {
                    SceneManager.LoadScene("GameScene");
                }
                else if(passwordStr == null ||  passwordStr != "8888")
                {
                    Debug.Log("ÃÜÂë´íÎó");
                }
            }
            else if(usernameStr == null || usernameStr != "admin")
            {
                Debug.Log("ÓÃ»§Ãû´íÎó");
            }
        }
    }
}
