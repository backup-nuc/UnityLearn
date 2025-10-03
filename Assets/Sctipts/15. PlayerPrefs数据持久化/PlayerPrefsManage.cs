using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class PlayerPrefsManage
{
    private static PlayerPrefsManage _instance = new PlayerPrefsManage();

    public static PlayerPrefsManage instance
    {
        get
        {
            return _instance;
        }
    }

    // 私有化构造函数
    private PlayerPrefsManage() { }


    private void _SaveValue(object value, string key)
    {
        // 根据值的类型存储不同的数据, PlayerPrefs支持三种数据类型 int float string
        Type valueType = value.GetType();
        if (valueType == typeof(int))
        {
            PlayerPrefs.SetInt(key, (int)value);
        }
        else if (valueType == typeof(float))
        {
            PlayerPrefs.SetFloat(key, (float)value);
        }
        else if (valueType == typeof(string))
        {
            PlayerPrefs.SetString(key, (string)value);
        }
        else if (valueType == typeof(bool))
        {
            // bool类型转换为int存储
            int boolValue = (bool)value ? 1 : 0;
            PlayerPrefs.SetInt(key, boolValue);
        }
        else if (typeof(IList).IsAssignableFrom(valueType))
        {
            //List类型 因为有泛型无法确定类型,所以这里判断是不是IList接口的子类
            IList list = (IList)value;
            // 存储List的长度
            PlayerPrefs.SetInt($"{key}_Count", list.Count);
            Debug.Log($"存储List长度: {key}_Count = {list.Count}");
            for (int i = 0; i < list.Count; i++)
            {
                object item = list[i];
                string itemKey = $"{key}_{i}";
                this._SaveValue(item, itemKey);
            }
        }
        else if (typeof(IDictionary).IsAssignableFrom(valueType))
        {
            // Dictionary类型
            IDictionary dict = (IDictionary)value;
            // 存储Dictionary的长度
            PlayerPrefs.SetInt($"{key}_Count", dict.Count);
            Debug.Log($"存储Dictionary长度: {key}_Count = {dict.Count}");
            int index = 0;
            foreach (DictionaryEntry entry in dict)
            {
                object dictKey = entry.Key;
                object dictValue = entry.Value;
                string itemKey = $"{key}_Key_{index}";
                string itemValue = $"{key}_Value_{index}";
                this._SaveValue(dictKey, itemKey);
                this._SaveValue(dictValue, itemValue);
                index++;
            }
        }
        else
        {
            Debug.LogError($"不支持存储该类型的数据: {valueType}");
        }
        Debug.Log($"存储数据: {key} = {value}");
    }
    /// <summary>
    /// 存储数据
    /// </summary>
    /// <param name="data">数据对象</param>
    /// <param name="key">数据对象的唯一key</param>
    public void SaveData(object data, string key)
    {
        // 1. 获取对象的所有字段
        Type type = data.GetType();
        FieldInfo[] fields = type.GetFields();

        // 2. 将字段存储到PlayerPrefs中
        // 自定义key保证唯一性: key_数据类型_字段类型_字段名称
        for (int i = 0; i < fields.Length; i++)
        {
            FieldInfo field = fields[i];
            string customKey = $"{key}_{type.Name}_{field.FieldType.Name}_{field.Name}";
            object fieldValue = field.GetValue(data);
            this._SaveValue(fieldValue, customKey);
        }
    }

    /// <summary>
    /// 加载数据
    /// </summary>
    /// <param name="objectType">读取数据的类型</param>
    /// <param name="key">数据对象的唯一key</param>
    /// <returns></returns>
    public object LoadData(Type objectType, string key)
    {
        return null;
    }
}
