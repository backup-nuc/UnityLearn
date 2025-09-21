using System.Collections.Generic;
using UnityEngine;

public static class Tool
{
    // Transfor拓展方法,将子对象按照名字长短排序
    public static void Sort(this Transform obj)
    {
        List<Transform> list = new List<Transform>();
        for (int i = 0; i < obj.childCount; i++)
        {
            list.Add(obj.GetChild(i));
        }
        list.Sort((left, right) =>
        {
            if (left.name.Length < right.name.Length)
            {
                //左小与右,不变
                return -1;
            }
            else
            {
                return 1;
            }
        });

        for (int i = 0; i < list.Count; i++)
        {
            list[i].SetSiblingIndex(i);
        }
    }
}
