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

        //�����ʼ��Ϸ�л�����
        if (GUI.Button(butRect_GameBegin, "��Ϸ��ʼ", butstyle))
        {
            SceneManager.LoadScene("GameScene");
        }
         
        if (GUI.Button(butRect_GameEnd, "�˳���Ϸ", butstyle))
        {

        }

        if (GUI.Button(butRect_Exc, "����", butstyle))
        {

        }
    }
}
