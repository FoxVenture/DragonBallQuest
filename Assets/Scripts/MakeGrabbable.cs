using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeGrabbable : MonoBehaviour
{
    [SerializeField] GameObject box;

    public void enablGrab()
    {
            box.layer = LayerMask.NameToLayer("Grabbable");
     
    }

}
