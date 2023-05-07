using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PuzzleUI : MonoBehaviour
{
    public GameObject reproductor;
    public GameObject parteTrasera;
    public GameObject parteDelantera;
    public bool trasera;

    void Start()
    {
        parteDelantera.SetActive(true);
        parteTrasera.SetActive(false);
        trasera = false;
    }

    public void Girar()
    {
        if (trasera)
        {
            reproductor.transform.eulerAngles = new Vector3(-90, 90, -90);
            reproductor.transform.position = new Vector3(-4.086f, 1.186499f, 3.25f);
            parteDelantera.SetActive(true);
            parteTrasera.SetActive(false);
            trasera = false;
        }else
        {
            reproductor.transform.eulerAngles = new Vector3(90, 90, -90);
            reproductor.transform.position = new Vector3(-4.0992f, 1.186499f, 3.25f);
            parteTrasera.SetActive(true);
            parteDelantera.SetActive(false);
            trasera = true;
        }
    }
}
