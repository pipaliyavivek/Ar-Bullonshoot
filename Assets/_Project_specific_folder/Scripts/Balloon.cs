using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    float flyspeed=0.2f; 
    private void Start()
    {
        flyspeed = Random.Range(0.1f, 0.5f);
    }
    private void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * flyspeed);
        if(transform.position.y > 4f)
        {
            Destroy(gameObject);
        }
    }
}
