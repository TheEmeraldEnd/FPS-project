using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locomotion : MonoBehaviour
{
    private CharacterController controller;
    [SerializeField] float playerSpeed;

    //Get Character controller
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    //Control Character
    private void Update()
    {
        Vector3 move = Vector3.zero;
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        move += (transform.forward * playerSpeed * v * Time.deltaTime);
        move += (transform.right * playerSpeed * Time.deltaTime * h);

        controller.Move(move);
    }
}
