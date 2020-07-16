using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Animator jesseAC;
    private float InputX;
    private float InputY;
    // Start is called before the first frame update
    void Start()
    {
        jesseAC = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /// Gettitng the input from the palyer here
        InputX = Input.GetAxis(Axis.Horizontal);
        InputY = Input.GetAxis(Axis.Vertical);

        // Sending the Input to the player Animator controller
        jesseAC.SetFloat(ACParams.MoveX, InputX);
        jesseAC.SetFloat(ACParams.MoveZ, InputY);
    }
}
