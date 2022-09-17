using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class objectManager : MonoBehaviour
{
    public Slider m_zoomSlider;
    public void Update()
    {
        //var rotate = m_RotateSlider.value;
        var zoom = m_zoomSlider.value;
        transform.localScale = Vector3.one * 0.05f * zoom;
    }
    void Awake()
    {
        m_zoomSlider = GameObject.Find("ZoomSlider").GetComponent<Slider>();
    }
}