using UnityEngine;
using System.Collections;

public class PlayerJump : MonoBehaviour
{

    public Vector3 jump;
    public float jumpForce = 2.0f;
    Rigidbody rb;

  
    public float DeploymentHeight;
    public float forceConst;
    private bool canJump;
    public bool flyMode =false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
       
    }


    void Update()
    {
        if (Input.GetKey("f") && flyMode == true)
        {

            rb.AddForce(jump * jumpForce * Time.deltaTime, ForceMode.Impulse);
            
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (canJump)
            {
                canJump = false;
                rb.AddForce(jump, ForceMode.Impulse);
            }
        }
        CheckGroundStatus();
    }


    void CheckGroundStatus()
    {

        RaycastHit hit;
        Ray landingRay = new Ray(transform.position, Vector3.down);
        Debug.DrawRay(transform.position, Vector3.down * DeploymentHeight);

        if (Physics.Raycast(landingRay, out hit, DeploymentHeight))
        {
            if (hit.collider == null)
            {
                canJump = false;
                Debug.Log(canJump);
            }
            else
            {
                canJump = true;
                Debug.Log(canJump);
            }

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "flyactivator")
        {
            flyMode = true;  
        }
    }
} 
