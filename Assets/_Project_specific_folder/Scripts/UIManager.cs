using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Button m_openBallonGame;
    public Button m_opendance;
    private void Awake()
    {
        instance = this;
        if (instance != null)
        {
            instance = this;
        }
        else
        {
            DontDestroyOnLoad(instance);
        }
    }
    void Start()
    {
        m_opendance.onClick.AddListener(dance);
        m_openBallonGame.onClick.AddListener(ballon);
    }
    private void ballon()
    {
        SceneManager.LoadScene(2);
    }
    private void dance()
    {
        SceneManager.LoadScene(1);
    }
}