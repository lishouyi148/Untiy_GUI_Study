using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingPanel : MonoBehaviour
{
    private static SettingPanel instance;
    public static void ShowMe()
    {
        if(instance != null)
        {
            instance.gameObject.SetActive(true);
        }
    }

    public static void HideMe()
    {
        if(instance != null)
        {
            instance.gameObject.SetActive(false);
        }
    }

    //Rect
    public Rect titleLabelRect;
    public Rect musicToggleRect;
    public Rect soundEffectsToggleRect;
    public Rect confirmButtonRect;

    //Content
    public GUIContent titleContent;

    //��ѡ��ѡ��״̬
    public bool isSel_music;
    public bool isSel_soundEffects;

    //style
    public GUIStyle titleStyle;
    public GUIStyle confirmButtonStyle;

    public void Awake()
    {
        instance = this;
        HideMe();
    }
    private void OnGUI()
    {
        GUI.Label(titleLabelRect, titleContent, titleStyle);

        isSel_music = GUI.Toggle(musicToggleRect, isSel_music, "���ֿ���");
        isSel_soundEffects = GUI.Toggle(soundEffectsToggleRect, isSel_soundEffects, "��Ч����");

        if(GUI.Button(confirmButtonRect, "", confirmButtonStyle))
        {
            print("��ť�����");
            SettingPanel.HideMe();
            BeginPanel.ShowMe();
        }
    }
}
