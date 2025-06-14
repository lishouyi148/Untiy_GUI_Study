using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitTipPanel : MonoBehaviour
{
    private static QuitTipPanel instance;

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

    //Window
    public Rect clientRect;
    public Rect cliButton_Exit;
    public Rect cliButton_Cancel;
    public Rect cliLabel;

    public void Awake()
    {
        instance = this;
        HideMe();
    }

    private void OnGUI()
    {
        clientRect = GUI.ModalWindow(1, clientRect, DrawWindow, "提示");
    }

    //窗口回调函数
    public void DrawWindow(int id)
    {
        GUI.Label(cliLabel, "是否取消");
        //生成按钮
        if (GUI.Button(cliButton_Exit, "退出"))
        {
            Application.Quit();
        }
        if (GUI.Button(cliButton_Cancel, "取消"))
        {
            HideMe();
            BeginPanel.ShowMe();
        }
        GUI.DragWindow();
    }
}
