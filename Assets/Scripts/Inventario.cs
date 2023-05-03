using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public Graphic mochilaIcon;
    public Graphic mochilaAbiertaImg;
    public bool mochilaAbierta;
    //public Graphic reproductorImg;
    //public Graphic destornilladorImg;
    //public Graphic cintaImg;
    //public Graphic cableImg;
    //public Graphic cassetteImg;
    //public Graphic pilaImg;

    // Start is called before the first frame update
    void Start()
    {
        mochilaAbiertaImg.gameObject.SetActive(false);
        mochilaAbierta = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (!mochilaAbierta)
            {
                mochilaAbiertaImg.gameObject.SetActive(true);
                mochilaIcon.gameObject.SetActive(false);
                mochilaAbierta = true;
            }else
            {
                mochilaAbiertaImg.gameObject.SetActive(false);
                mochilaIcon.gameObject.SetActive(true);
                mochilaAbierta = false;
            }
        }
        
    }
}
