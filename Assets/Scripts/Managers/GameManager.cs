using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : Singleton<GameManager>
{
    public TextMeshProUGUI text;


    protected override void Awake()
    {
        base.Awake();
        text = GameObject.Find("TextBox").GetComponent<TextMeshProUGUI>();
    }

    public void ChangeText()
    {
        TextManager.Instance.ChangeText();
    }
}
