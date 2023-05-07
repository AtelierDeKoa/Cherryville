using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Catchable : MonoBehaviour
{
    public static int itemCount = 0;

    public Material brightMaterial;
    public Material dimMaterial;
    public GameObject inventoryItem;
    public string popUpString;
    public bool active;
    public List<Catchable> activate;
    public PopUp popup;

    void OnTriggerStay(Collider other)
    {
        if (active && Input.GetKey(KeyCode.E))
        {
            if (inventoryItem != null)
            {
                itemCount++;
                inventoryItem.SetActive(true);
                Debug.Log(itemCount);
            }
            foreach (Catchable c in activate)
            {
                c.active = true;
            }
            popup.Activate(popUpString);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (active)
        {
        transform.GetComponent<Renderer>().material = brightMaterial;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (active)
        {
        transform.GetComponent<Renderer>().material = dimMaterial;

        }
    }
}
