using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePlayer : MonoBehaviour
{
    private Rigidbody rb;
    private float velocity;
    private bool canJump = true;
    // Start is called before the first frame update
    void Start()
    {
        velocity = 10f;
        rb = GetComponent<Rigidbody>();

    }

    public void setVelocity(float x)
    {
        this.velocity = x;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.5f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.5f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0f, 0.5f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -0.5f);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up * -45 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * 45 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * 10 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * 10 * Time.deltaTime);
        }*/
        //Debug.Log(Input.GetAxis("Horizontal"));
        /*float x = Input.GetAxis("Horizontal");
        if (x != 0)
        {
            transform.Translate(x * Time.deltaTime, 0f, 0f);
        }
        float y = Input.GetAxis("Vertical");
        if (y != 0)
        {
            transform.Translate(0f, 0f, y * Time.deltaTime);
        }*/


        //Usando rigidbody
        float extraRotation = 0f;
        if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(-0.5f, 0f, 0f);
            Vector3 newPosition = rb.position + transform.TransformDirection(Vector3.left * velocity * Time.deltaTime);
            rb.MovePosition(newPosition);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 newPosition = rb.position + transform.TransformDirection(Vector3.right * velocity * Time.deltaTime);
            rb.MovePosition(newPosition);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 newPosition = rb.position + transform.TransformDirection(Vector3.forward * velocity * Time.deltaTime);
            rb.MovePosition(newPosition);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 newPosition = rb.position + transform.TransformDirection(Vector3.back * velocity * Time.deltaTime);
            rb.MovePosition(newPosition);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.Rotate(Vector3.up * -45 * Time.deltaTime);
            extraRotation = -1f;
            
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            extraRotation = 1f;
        }

        Vector3 newRotation = new Vector3(0f, rb.rotation.eulerAngles.y + extraRotation, 0f);
        Quaternion rot = new Quaternion();
        rot.eulerAngles = newRotation;
        rb.MoveRotation(rot);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 newPosition = rb.position + transform.TransformDirection(Vector3.forward * velocity * Time.deltaTime);
            rb.MovePosition(newPosition);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 newPosition = rb.position + transform.TransformDirection(Vector3.back * velocity * Time.deltaTime);
            rb.MovePosition(newPosition);
        }

        if (Input.GetKey(KeyCode.Space) && canJump)
        {
            rb.AddForce(Vector3.up * 250);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plane")
        {
            canJump = true;
        }
        if (collision.gameObject.name == "Player"){
            canJump = true;
        }
        if (collision.gameObject.name == "Cube")
        {
            canJump = true;
        }
        if (collision.gameObject.name == "Cube (1)")
        {
            canJump = true;
        }
        if (collision.gameObject.name == "Cube (2)")
        {
            canJump = true;
        }
        if (collision.gameObject.name == "Cube (3)")
        {
            canJump = true;
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Plane")
        {
            canJump = false;
        }
        if (collision.gameObject.name == "Player")
        {
            canJump = false;
        }
        if (collision.gameObject.name == "Cube (1)")
        {
            canJump = false;
        }
        if (collision.gameObject.name == "Cube (2)")
        {
            canJump = false;
        }
        if (collision.gameObject.name == "Cube (3)")
        {
            canJump = false;
        }

    }
}
