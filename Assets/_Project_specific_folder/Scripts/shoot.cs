using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class shoot : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject Smoke;

    public Button exit;
    private void Start()
    {
        exit.onClick.AddListener(goManu);
    }

    private void goManu()
    {
        SceneManager.LoadScene(0);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = arCamera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                //if (hit.collider != null)
                //{
                //    Debug.Log("Hit Object Name" + hit.collider.gameObject.name);
                //}
                if (hit.collider.CompareTag("Balloon"))
                {
                    Destroy(hit.transform.gameObject);
                    Instantiate(Smoke, hit.point, Quaternion.LookRotation(hit.normal));
                }
            }
        }
    }
    private void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward * 5, out hit))
        {
            Debug.Log(hit.collider.gameObject.name + " IS Object");
            if (hit.collider.CompareTag("Balloon"))
            {
                Debug.Log("Balloon Finded");
                Destroy(hit.transform.gameObject);
                Instantiate(Smoke, hit.point, Quaternion.LookRotation(hit.normal));
            }
        }
    }
}
