using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{

    [Header("Refences")]
    [SerializeField] private Transform PlayerCamera;
    [SerializeField] private Rigidbody PlayerBody;
    private Vector3 PlayerMovementInput;
    
    [Header("Movment Control")]
    public float Speed;

    [Header("Blance")]
    public float stabilization;
    public float damping;

    private void Start()
    {
        PlayerBody = GetComponent<Rigidbody>(); 
    }

    void Update()
    {
        PlayerMovementInput = new Vector3(0f, 0f, Input.GetAxis("Vertical"));
        MovePlayer();

    }

    private void FixedUpdate()
    {
        Vector3 torque = stabilization * Vector3.Cross(transform.up, Vector3.up) - damping * PlayerBody.angularVelocity;
        PlayerBody.AddTorque(torque);
    }

    private void MovePlayer()
    {
        Vector3 MoveVector = transform.TransformDirection(PlayerMovementInput) * Speed;
        PlayerBody.velocity = new Vector3(MoveVector.x, PlayerBody.velocity.y, MoveVector.z);
    }
}
