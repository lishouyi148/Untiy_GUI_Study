using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6 : MonoBehaviour
{
    public int toolbarIndex = 0;
    public string[] toolbarInfos = new string[] { "选择一", "选择二", "选择三" };

    private int selectIndex = 1;
    private int selectCount = 3;
    private void OnGUI()
    {
        toolbarIndex =  GUI.Toolbar(new Rect(0, 0, 300, 40), toolbarIndex, toolbarInfos);
        switch (toolbarIndex)
        {
            case 0:
                break;
            case 1:
                break;
            case 3:
                break;
                 
        }

        selectIndex =  GUI.SelectionGrid(new Rect(0, 40, 300, 80), selectIndex, toolbarInfos, selectCount);
    }
}
