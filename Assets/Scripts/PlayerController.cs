using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private float speed = 5.75f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        //Bounds();
    }
    
private void Move()
    {
        //Vector3.right = Vector3(1, 0, 0)
        //deltatime - convert from fps to actual seconds (delta = the change in time)

        // local variable
        // usable only in this block of code
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        //if(horizontalInput <0 = run this anim)
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // Anim.SetBool("TurnLeft", true);
            // Anim.SetBool("TurnRight", false);
        }
        else if(Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            // Anim.SetBool("TurnLeft", false);
            // Anim.SetBool("TurnRight", false);
    
        }

        if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Anim.SetBool("TurnRight", true);
            // Anim.SetBool("TurnLeft", false);

        }
        else if(Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            // Anim.SetBool("TurnRight", false);
            // Anim.SetBool("TurnLeft", false);
    
        }


        //Input.GetAxis gives -1...+1
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        transform.Translate(Vector3.up * verticalInput * speed * Time.deltaTime);
    }

    // private void Bounds()
    // {
    //     // decision statement
    //     // if
    //     // if...else
    //     // else...if
    //     // boolean - true/false

    //     if(transform.position.y < -4.15f)
    //     {
    //         transform.position = new Vector3(transform.position.x,-4.15f,0);
    //     }
    //     else if(transform.position.y > 1.48f)
    //     {
    //         transform.position = new Vector3(transform.position.x,1.48f,0);
    //     }

    //     if(transform.position.x > 8.1f)
    //     {
    //         transform.position = new Vector3(-8.1f,transform.position.y,0);
    //     }
    //     else if(transform.position.x < -8.1f)
    //     {
    //         transform.position = new Vector3(8.1f,transform.position.y,0);
    //     }
    // }

}
