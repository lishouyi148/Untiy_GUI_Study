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
    public Rect labRect;
    public GUIContent labContent;
    public GUIStyle labStyle;

    public Rect butRect_GameBegin;
    public Rect butRect_GameEnd;
    public Rect butRect_Exc;

    public GUIStyle butstyle;

    public void Awake()
    {
        instance = this;
        ShowMe();
    }

    private void OnGUI()
    {
        GUI.Label(labRect, labContent, labStyle);

        //�����ʼ��Ϸ�л�����
        if (GUI.Button(butRect_GameBegin, "��Ϸ��ʼ", butstyle))
        {
            BeginPanel.HideMe();
            LogPanel.ShowMe();
        }
         
        if (GUI.Button(butRect_GameEnd, "�˳���Ϸ", butstyle))
        {

        }

        if (GUI.Button(butRect_Exc, "����", butstyle))
        {
            HideMe();
            BeginPanel.HideMe();
            SettingPanel.ShowMe();
        }
    }
}
