using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OutlineCheck : MonoBehaviour
{
    [SerializeField] LockKey locks;
    // remove this?
    bool unlocked = false;
    [SerializeField] GameObject box;
    XRGrabInteractable grabScript;

    void Start()
    {
        grabScript = box.GetComponent<XRGrabInteractable>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enableOutline()
    {
        if(!locks.CheckIsLockedBoth())
        {
            gameObject.GetComponent<Outline>().enabled = true;
            box.layer = LayerMask.NameToLayer("Grabbable");
            grabScript.interactionLayerMask = LayerMask.NameToLayer("Grabbable");
        }
    }

    public void unlockOutline()
    {
        locks.UnlockLockOne();
    }

    public void grabIgnore()
    {
        box.layer = LayerMask.NameToLayer("Grab Ignore");
    }
}
