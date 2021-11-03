using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPodController : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    public void OpenDoor()
    { 
        anim.SetTrigger("Active");
    }
}
