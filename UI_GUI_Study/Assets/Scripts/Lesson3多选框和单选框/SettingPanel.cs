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

    //title
    public Rect titleLabelRect;

    public GUIContent titleContent;

    public GUIStyle titleStyle;

    //Toogle
    public Rect musicToggleRect;
    public Rect soundEffectsToggleRect;
    public Rect musicVolumeRect;
    public Rect soundVolumeRect;

    public bool isSel_music = true;
    public bool isSel_soundEffects = true;

    public float nowMusicVolumeValue = 0.5f;
    public float nowSoundVolumeValue = 0.5f;

    //Button
    public Rect confirmButtonRect;

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
