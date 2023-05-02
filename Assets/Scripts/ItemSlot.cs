using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    public GameObject objectAccepted;
    public GameObject objectToModify;
    public GameObject objectToEnable;
    public bool enable;
    public GameObject nextSlot;
    public Animator finalAnimator;
    public GameObject tabla;
    public AudioSource musicaPuzzle;

    
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        if (dropped == objectAccepted)
        {
            objectAccepted.SetActive(false);
            objectToModify.SetActive(enable);
            gameObject.SetActive(false);

            if (objectToEnable != null)
            {
                objectToEnable.SetActive(true);
            }

            if (nextSlot != null)
            {
                nextSlot.SetActive(true);
            }
            else
            {
                finalAnimator.SetBool("IsOpen", true);
                Cursor.lockState = CursorLockMode.Locked;
                tabla.SetActive(false);
                musicaPuzzle.Play();
            }
        }
    }

}
