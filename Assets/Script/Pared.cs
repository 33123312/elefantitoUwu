using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pared : MonoBehaviour
{
    public bool isActive = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Algo>() != null)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger exit");
    }
}


