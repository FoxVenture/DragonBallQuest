using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    // Animation
    [SerializeField] private float animationSpeed;
    Animator animator;
    private float gripTarget;
    private float triggerTarget;
    private float gripCurrent;
    private float triggerCurrent;
    private string animatorGripParam = "Grip";
    private string animatorTriggerParam = "Trigger";

    /* Physics Movement
    [SerializeField] private GameObject followObject;
    [SerializeField] private float followSpeed = 30f;
    [SerializeField] private float rotateSpeed = 100f;
    private Transform followTarget;
    private Rigidbody body; */


    void Start()
    {
        // Animation
        animator = GetComponent<Animator>();

        // Physics Movement
       // followTarget = followObject.transform;
       // body = GetComponent<Rigidbody>();
       // body.collisionDetectionMode = CollisionDetectionMode.Continuous;
       // body.interpolation = RigidbodyInterpolation.Interpolate;
       // body.mass = 20f;

        // Teleport hands
       // body.position = followTarget.position;
       // body.rotation = followTarget.rotation;

    }

    void Update()
    {
        AnimateHand();

        //PhysicsMove();
    }

    private void PhysicsMove()
    {
        /* Position
        var distance = Vector3.Distance(followTarget.position, transform.position);
        body.velocity = (followTarget.position - transform.position).normalized * (followSpeed * distance);

        // Rotation
        var q = followTarget.rotation * Quaternion.Inverse(body.rotation);
        q.ToAngleAxis(out float angle, out Vector3 axis);
        body.angularVelocity = axis * (angle * Mathf.Deg2Rad * rotateSpeed); 
        */
    }

    internal void SetGrip(float v)
    {
        gripTarget = v;
    }

    internal void SetTrigger(float v)
    {
        triggerTarget = v;
    }


    void AnimateHand()
    {
        if(gripCurrent != gripTarget)
        {
            gripCurrent = Mathf.MoveTowards(gripCurrent, gripTarget, Time.deltaTime * animationSpeed);
            animator.SetFloat(animatorGripParam, gripCurrent);
        }

        if (triggerCurrent != triggerTarget)
        {
            triggerCurrent = Mathf.MoveTowards(triggerCurrent, triggerTarget, Time.deltaTime * animationSpeed);
            animator.SetFloat(animatorTriggerParam, triggerCurrent);
        }
    }
}
