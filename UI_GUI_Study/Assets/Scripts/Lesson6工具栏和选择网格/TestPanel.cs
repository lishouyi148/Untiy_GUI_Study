using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPanel : MonoBehaviour
{
    //工具栏
    public Rect toolbarRect;
    public Rect selectGirdRect;

    public string[] toolbarInfos = new string[] { "强化", "解梦", "幻化" };

    public int toolbarIndex = 0;

    public int selectGirdCount = 1;
    //展示信息
    public Rect labelRect;

    public string labelText1;
    public string labelText2;
    public string labelText3;

    public void OnGUI()
    {
        toolbarIndex = GUI.Toolbar(toolbarRect, toolbarIndex, toolbarInfos);
        toolbarIndex = GUI.SelectionGrid(selectGirdRect, toolbarIndex, toolbarInfos, selectGirdCount);
        switch (toolbarIndex)
        {
            case 0:
                GUI.Label(labelRect, labelText1);
                break;
            case 1:
                GUI.Label(labelRect, labelText2);
                break;
            case 2:
                GUI.Label(labelRect, labelText3);
                break;
        }
    }
}
