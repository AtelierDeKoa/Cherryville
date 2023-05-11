using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mostrador : MonoBehaviour
{
    public Camera puzzleCam;
    public GameObject puzzle;
    public GameObject puzzleUI;
    public AudioSource musicaAmb;
    public GameObject mapaUI;
    public GameObject mochilaUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        


    }
    private void OnTriggerStay(Collider other)
    {
        if (Catchable.itemCount == 6 && Input.GetKeyDown(KeyCode.E))
        {
            Cursor.lockState = CursorLockMode.None;
            puzzle.SetActive(true);
            puzzleUI.SetActive(true);
            Camera.SetupCurrent(puzzleCam);
            CameraRotation.blocked = true;
            CharacterMovement.blocked = true;
            mapaUI.SetActive(false);
            mochilaUI.SetActive(false);
            musicaAmb.Stop();
            Inventario.onPuzzle = true;
        }
    }
}
