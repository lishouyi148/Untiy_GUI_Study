using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollViewTestPanel : MonoBehaviour
{
    public Rect scRect;
    public Rect showRect;

    private Vector2 nowRect;

    public string[] strs;
    
    private void OnGUI()
    {
        showRect.height = strs.Length * 30;
        nowRect = GUI.BeginScrollView(scRect, nowRect, showRect);
        for(int i = 0; i < strs.Length; i++)
        {
            GUI.Label(new Rect(0, i * 30, 100, 30), strs[i]);
        };

        GUI.EndScrollView();
    }
}
