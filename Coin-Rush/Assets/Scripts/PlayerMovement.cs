using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    public Scrollbar controllerBar;
    public Rigidbody rb;
    public bool isTriggered = false;
    
    
    [SerializeField] public float speed = 20f;
    [SerializeField] public float directionValue;


    private void Start()
    {
        rb= GetComponent<Rigidbody>();
    }
    
  
    private void FixedUpdate()
    {
        directionValue = controllerBar.value;
        RollAndSteer();
        
    }

    private void RollAndSteer()
    {
        rb.velocity = Vector3.forward*speed;

        if (directionValue != 0.5f)
            rb.AddForce(Vector3.right * CalculateSteerSpeed(directionValue));
    }

    private float CalculateSteerSpeed(float aDirectionValue)
    {
        float calculatedSteerValue ;

        calculatedSteerValue = (aDirectionValue - 0.5f) *  400f;

        return calculatedSteerValue;
    }
    
    
   

}
