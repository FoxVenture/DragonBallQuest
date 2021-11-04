using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineCheck : MonoBehaviour
{
    bool unlocked = false;
    [SerializeField] GameObject box;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enableOutline()
    {
        if(unlocked)
        {
            gameObject.GetComponent<Outline>().enabled = true;
            box.layer = LayerMask.NameToLayer("Grabbable");
        }
    }

    public void unlockOutline()
    {
        unlocked = true;
    }

    public void grabIgnore()
    {
        box.layer = LayerMask.NameToLayer("Grab Ignore");
    }
}
