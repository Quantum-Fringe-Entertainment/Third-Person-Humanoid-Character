using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Animator))]
public class Movement : MonoBehaviour
{
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        //move
        Move();
        //turn
        Turn();
        //jump
    }

    private void Turn()
    {
        anim.SetFloat(ACParams.Turn, Input.GetAxis(Axis.Horizontal));
    }
    private void Move()
    {
        anim.SetFloat(ACParams.MoveX, Input.GetAxis(Axis.Horizontal));
        anim.SetFloat(ACParams.MoveZ, Mathf.Clamp( Input.GetAxis(Axis.Vertical),0f,1f));
    }
}
