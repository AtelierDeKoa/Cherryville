using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public Graphic mochilaIcon;
    public Graphic mochilaAbiertaImg;
    public bool mochilaAbierta;
    public TextMeshProUGUI popUp;
    public TextMeshProUGUI popUpInv;

    // Start is called before the first frame update
    void Start()
    {
        mochilaAbiertaImg.gameObject.SetActive(false);
        mochilaAbierta = false;
    }

    // Update is called once per frame
    void Update()
    {
        popUpInv.text = popUp.text;
        if (Input.GetKeyDown(KeyCode.I)||Input.GetKeyDown(KeyCode.Escape))
        {
            if (!mochilaAbierta)
            {
                mochilaAbiertaImg.gameObject.SetActive(true);
                mochilaIcon.gameObject.SetActive(false);
                mochilaAbierta = true;
                Cursor.lockState = CursorLockMode.None;
                CameraRotation.blocked = true;
                CharacterMovement.blocked = true;
            }else
            {
                mochilaAbiertaImg.gameObject.SetActive(false);
                mochilaIcon.gameObject.SetActive(true);
                mochilaAbierta = false;
                Cursor.lockState = CursorLockMode.Locked;
                CameraRotation.blocked = false;
                CharacterMovement.blocked = false;
            }
        }
        
    }

    public void Continue()
    {
        Cursor.lockState = CursorLockMode.Locked;
        mochilaAbiertaImg.gameObject.SetActive(false);
        mochilaIcon.gameObject.SetActive(true);
        mochilaAbierta = false;
        CameraRotation.blocked = false;
        CharacterMovement.blocked = false;
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
