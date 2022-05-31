using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Algo : MonoBehaviour
{
    private Transform thisTransform;
    public GameObject[] players;
    public float angularVelocity;
    private GameObject wall;
    private Pared wallScript;
    public GameObject show1;


    // Start is called before the first frame update
    void Start()
    {
        angularVelocity = 45f;
        thisTransform = gameObject.transform;
        //wall = GameObject.Find("Wall");
        //wallScript = wall.GetComponent<Pared>();
        /*for (int i = 0; i < thisTransform.childCount; i++)
        {
            Transform childTransform = thisTransform.GetChild(i);
            Debug.Log(childTransform.name);
        }*/
        //Acceder a objetos mediante el tag
        //players = GameObject.FindGameObjectsWithTag("Player");
        
        
        //thisTransform.Translate(new Vector3(1,0,0));
    }

    // Update is called once per frame
    void Update()
    {
        //thisTransform.Translate(Vector3.forward*50f * Time.deltaTime);
        //thisTransform.Rotate(0, 45f * Time.deltaTime, 0, Space.World);
        //print(Time.deltaTime);
        /*for (int i = 0; i < players.Length; i++)
        {
            players[i].
        }*/
        transform.Rotate(0, angularVelocity * Time.deltaTime, 0, Space.World);

        //wall.SetActive(wallScript.isActive);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Hellephant")
        {
            
            CubePlayer cubeplayer = other.GetComponent<CubePlayer>();
            Debug.Log(cubeplayer);
            cubeplayer.setVelocity(20f);
            Destroy(this.gameObject);
            show1.SetActive(true);



        }
    }


    private void OnEnable()
    {
        Debug.Log("Enabled");
    }

    private void OnDisable()
    {
        Debug.Log("Disabled");
    }

    private void OnMouseEnter()
    {
        Debug.Log("Entró el mouse.");
    }

    private void OnMouseExit()
    {
        Debug.Log("Salió el mouse.");
    }

    private void OnMouseOver()
    {
        Debug.Log("AAAAAAAAAAAAAAAAAAAAAAA.");
    }

    private void OnMouseDown()
    {
        
    }

    private void OnMouseUp()
    {
        
    }
}
