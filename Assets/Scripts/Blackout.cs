using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blackout : MonoBehaviour
{
    [SerializeField] GameObject mainCamera;
    [SerializeField] GameObject blackOutCamera;

    bool mainCameraActive = true;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Blackout")
        {
            Debug.Log("COLLIDE MET DESK");
            mainCamera.SetActive(false);
            mainCameraActive = false;
            blackOutCamera.SetActive(true);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Blackout" && !mainCameraActive)
        {
           // mainCamera.enabled = true;
            mainCameraActive = true;
           // blackOutCamera.enabled = false;
        }
    }
}
