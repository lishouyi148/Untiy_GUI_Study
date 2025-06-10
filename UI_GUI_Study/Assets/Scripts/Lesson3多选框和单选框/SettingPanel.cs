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
    public Rect musicVolumeRect;
    public Rect soundVolumeRect;

    //Content
    public GUIContent titleContent;

    //多选框选中状态
    public bool isSel_music = true;
    public bool isSel_soundEffects = true;

    //style
    public GUIStyle titleStyle;
    public GUIStyle confirmButtonStyle;

    //音乐大小
    public float nowMusicVolumeValue = 0.5f;
    public float nowSoundVolumeValue = 0.5f;

    public void Awake()
    {
        instance = this;
        HideMe();
    }
    private void OnGUI()
    {
        GUI.Label(titleLabelRect, titleContent, titleStyle);

        isSel_music = GUI.Toggle(musicToggleRect, isSel_music, "音乐开关");
        isSel_soundEffects = GUI.Toggle(soundEffectsToggleRect, isSel_soundEffects, "音效开关");

        nowMusicVolumeValue = GUI.HorizontalSlider(musicVolumeRect, nowMusicVolumeValue, 0, 1);
        nowSoundVolumeValue = GUI.HorizontalSlider(soundVolumeRect, nowSoundVolumeValue, 0, 1);


        if(GUI.Button(confirmButtonRect, "", confirmButtonStyle))
        {
            print("按钮点击了");
            SettingPanel.HideMe();
            BeginPanel.ShowMe();
        }
    }
}
