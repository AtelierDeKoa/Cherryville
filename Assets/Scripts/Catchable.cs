using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catchable : MonoBehaviour
{
    public Material brightMaterial;
    public Material dimMaterial;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            Destroy(this.gameObject);
            //Meterlo en el inventario
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        transform.GetComponent<Renderer>().material = brightMaterial;
    }

    private void OnTriggerExit(Collider other)
    {
        transform.GetComponent<Renderer>().material = dimMaterial;
    }
}
