using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Slider m_volume;
    public AudioSource m_audioSource;
    public Button gomainmenu;
    private void Start()
    {
        m_volume.value = m_audioSource.volume;
        gomainmenu.onClick.AddListener(OpenMenuScene);
    }
    private void FixedUpdate()
    {
        m_audioSource.volume = m_volume.value;
    }
    public void OpenMenuScene() 
    {
        SceneManager.LoadScene(0);
    }

}
