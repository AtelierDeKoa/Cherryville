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
        Debug.Log("Deber�a cambiar el color");
    }

    private void OnTriggerExit(Collider other)
    {
        transform.GetComponent<Renderer>().material = dimMaterial;
        Debug.Log("Deber�a volver el color original");
    }
}
