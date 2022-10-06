using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    public static T Instance;

    [SerializeField] private bool dontDestroyOnLoad;

    protected virtual void Awake()
    {
        if (FindObjectsOfType<T>().Length > 1)
            Destroy(gameObject);

        if (dontDestroyOnLoad)
            DontDestroyOnLoad(gameObject);

        if (Instance == null)
            Instance = GetComponent<T>();
    }

}
