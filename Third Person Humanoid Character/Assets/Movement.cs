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

        //jump
    }

    private void Turn()
    {

    }
    private void Move()
    {
        anim.SetFloat(ACParams.MoveX, Input.GetAxis(Axis.Horizontal));
        anim.SetFloat(ACParams.MoveZ, Input.GetAxis(Axis.Vertical));
    }
}
