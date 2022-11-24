using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.iOS;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    public Scrollbar controllerBar;
    public Rigidbody rb;

    [SerializeField] public float speed = 20f;

    private void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    private void Update()
    {
    }
    private void FixedUpdate()
    {
        float directionValue = controllerBar.value;
        RollAndSteer(directionValue);
    }
    
    public void RollAndSteer(float aSteerValue)
    {
        rb.AddForce(Vector3.forward*speed);
        
        if(aSteerValue!=0.5)
            rb.AddForce(Vector3.right * CalculateSteerSpeed(aSteerValue));
        
    }
    

    public float CalculateSteerSpeed(float aDirectionValue)
    {
        float calculatedSteerValue =10f;

        if(aDirectionValue<0.5f)
        {
            if(aDirectionValue==0f)

                calculatedSteerValue = -12f;
            else
                calculatedSteerValue = aDirectionValue * -12f;
        }

        else if(aDirectionValue>0.5f)
        {
            calculatedSteerValue = aDirectionValue * 12f;
        }
        

        return calculatedSteerValue;
    }

}
