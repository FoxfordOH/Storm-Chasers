using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private float speed = 5.75f;
    private Animator Anim;
    public float horizontalInput;
    public float verticalInput;

    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        //Bounds();
    }

    private void Move()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            Anim.SetBool("WalkUp", true);
            Anim.SetBool("WalkDown", false);
            Anim.SetBool("WalkLeft", false);
            Anim.SetBool("WalkRight", false);
        }
        else if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow))
        {
            Anim.SetBool("WalkUp", false);
            Anim.SetBool("WalkDown", false);
            Anim.SetBool("WalkLeft", false);
            Anim.SetBool("WalkRight", false);

        }

        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            Anim.SetBool("WalkDown", true);
            Anim.SetBool("WalkUp", false);
            Anim.SetBool("WalkLeft", false);
            Anim.SetBool("WalkRight", false);

        }
        else if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            Anim.SetBool("WalkUp", false);
            Anim.SetBool("WalkDown", false);
            Anim.SetBool("WalkLeft", false);
            Anim.SetBool("WalkRight", false);
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Anim.SetBool("WalkLeft", true);
            Anim.SetBool("WalkUp", false);
            Anim.SetBool("WalkRight", false);
            Anim.SetBool("WalkDown", false);

        }
        else if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            Anim.SetBool("WalkUp", false);
            Anim.SetBool("WalkDown", false);
            Anim.SetBool("WalkLeft", false);
            Anim.SetBool("WalkRight", false);

        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            Anim.SetBool("WalkRight", true);
            Anim.SetBool("WalkUp", false);
            Anim.SetBool("WalkDown", false);
            Anim.SetBool("WalkLeft", false);

        }
        else if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            Anim.SetBool("WalkUp", false);
            Anim.SetBool("WalkDown", false);
            Anim.SetBool("WalkLeft", false);
            Anim.SetBool("WalkRight", false);

        }


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