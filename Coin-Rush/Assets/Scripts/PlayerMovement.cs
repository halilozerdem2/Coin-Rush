using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Scrollbar controllerBar;
    [SerializeField] public float moveSpeed=10f;
    public float steerSpeed;

    private void Awake()
    {
        rb=GetComponent<Rigidbody>();
        controllerBar=FindObjectOfType<Scrollbar>();
    }
    private void FixedUpdate()
    {
        Roll();
        Steer(steerSpeed);
    }
    private void Update()
    {
        CalculateSteerSpeed();
    }

    private void CalculateSteerSpeed()
    {
        steerSpeed = (controllerBar.value - 0.5f) * 400f;
    }

    public void Roll()
    {
        rb.velocity = new Vector3(0,0,moveSpeed);
    }
    public void Steer(float aValue)
    {
        rb.AddForce(new Vector3 (aValue,0,0));
    }


}
