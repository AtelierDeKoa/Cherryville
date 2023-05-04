using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catchable : MonoBehaviour
{
    public static int itemCount = 0;

    public Material brightMaterial;
    public Material dimMaterial;
    public GameObject inventoryItem;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (inventoryItem != null)
            {
                itemCount++;
                inventoryItem.SetActive(true);
                Debug.Log(itemCount);
            }
            Destroy(gameObject);
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
