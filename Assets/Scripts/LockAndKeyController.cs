using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockAndKeyController : MonoBehaviour
{
   /* [SerializeField]
    GameObject key, cube;

    bool locked { get; set; }
    string locktext;
    int nr = 1;

    void Start()
    {
        locked = true;
        locktext = "still locked";
        Debug.Log(nr);
        nr++;
        gameObject.GetComponent<Renderer>().material.color = Color.green;

    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == key)
        {
            locked = false;
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            Debug.Log("Jeej unlocked!");
        }
    }

    public bool getLocked()
    {
        return locked;
    }

    public void UnlockObject()
    {
        locked = false;
        gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    public void LockObject()
    {
        locked = true;
        gameObject.GetComponent<Renderer>().material.color = Color.red;
    } */
}
