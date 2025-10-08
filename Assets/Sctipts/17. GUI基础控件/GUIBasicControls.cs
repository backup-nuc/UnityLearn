﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIBasicControls : MonoBehaviour
{
    public Texture img;

    public GUIStyle myStyle;

    // 1. GUI控件绘制的共同点:
    //   - 他们都是GUI公共类中提供的静态函数直接调用即可
    // 2. 他们的参数都大同小异
    //  - 位置参数: Rect参数 x y位置 w h尺寸
    //  - 显示文本: string参数
    //  - 图片信息: Texture参数
    //  - 综合信息: GUIContent参数
    //  - 自定义样式: GUIStyle参数
    // 3. 每一种控件都有多种重载，都是各个参数的排列组合
    //  - 必备的参数内容是位置信息和显示信息

    private void OnGUI()
    {
        // 1. 标签控件: 用于显示文本或图片信息
        GUI.Label(new Rect(10, 10, 200, 50), "标签控件");
        GUI.Label(new Rect(10, 70, 200, 50), new GUIContent("标签控件", "鼠标悬停提示"));
        GUI.Label(new Rect(220, 10, 100, 100), img); // 尽可能保证图片显示原始的宽高比
        GUI.Label(new Rect(220, 120, 100, 100), new GUIContent("图片标签", img, "鼠标悬停提示"));
        //  - tooltip: 鼠标悬停提示信息
        Debug.Log(GUI.tooltip); // 实时打印鼠标悬停位置组件的提示信息
        //  - 自定义样式: GUIStyle参数
        GUI.Label(new Rect(220, 200, 200, 50), "自定义样式标签", myStyle);

        // 2. 按钮控件: 用于触发某个事件
        if (GUI.Button(new Rect(10, 130, 200, 50), "按钮控件"))
        {
            Debug.Log("点击了按钮");
        }
        if (GUI.Button(new Rect(10, 190, 200, 50), new GUIContent("按钮控件", "鼠标悬停提示")))
        {
            Debug.Log("点击了按钮");
        }
        if (GUI.RepeatButton(new Rect(220, 300, 200, 50), "持续按压按钮"))
        {
            Debug.Log("持续按压按钮");
        }
    }

}
