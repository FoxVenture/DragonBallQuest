using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blackout : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [SerializeField] Camera blackOutCamera;

    bool mainCameraActive = true;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "MainCamera" && mainCameraActive)
        {
            mainCamera.enabled = false;
            mainCameraActive = false;
            blackOutCamera.enabled = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "MainCamera" && !mainCameraActive)
        {
            mainCamera.enabled = true;
            mainCameraActive = true;
            blackOutCamera.enabled = false;
        }
    }
}
