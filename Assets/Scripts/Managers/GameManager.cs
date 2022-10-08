using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : Singleton<GameManager>
{
    public TextMeshProUGUI text;

    public PlayerButton left, right;


    protected override void Awake()
    {
        base.Awake();
        if (text == null)
            text = GameObject.Find("TextBox").GetComponent<TextMeshProUGUI>();
    }

    public void ChangeText()
    {
        TextManager.Instance.ChangeText();
    }

    public void ShowButton()
    {
        left.gameObject.SetActive(true);
        right.gameObject.SetActive(true);
    }

    public void ChangeScene(int _index)
    {
        SceneManager.LoadScene(_index);
    }
}
