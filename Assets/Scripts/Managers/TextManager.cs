using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManager : Singleton<TextManager>
{
    public Dictionary<int, string[]> textDic = new Dictionary<int, string[]>();
    public Dictionary<int, GameObject[]>[] imageDic;

    public int CurIndex { get; set; }

    public int CurKey { get; set; }

    protected override void Awake()
    {
        base.Awake();
        CurIndex = 0; CurKey = 0;
        textDic.Add(0, new string[] { "평화로운 어느 기숙사", "???: 아... 오늘 뭐먹지?" });
    }

    private void Start()
    {
        GameManager.Instance.text.text = GetText(CurKey, CurIndex);
    }

    public string GetText(int _key, int _index)
    {
        return textDic[_key][_index];
    }

    public void ChangeText()
    {
        if (textDic[CurKey].Length - 1 > CurIndex)
            GameManager.Instance.text.text = GetText(CurKey, ++CurIndex);
        else
        {
            GameManager.Instance.text.text = null;
            GameManager.Instance.ShowButton();
        }
    }

}
