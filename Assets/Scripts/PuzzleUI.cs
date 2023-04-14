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
        parteDelantera.SetActive(false);
        trasera = true;
    }

    public void GoBack()
    {
        SceneManager.LoadScene("OutdoorsScene");
    }

    public void Girar()
    {
        if (trasera == true)
        {
            reproductor.transform.localEulerAngles = new Vector3(0, 90, 90);
            parteDelantera.SetActive(true);
            parteTrasera.SetActive(false);
            trasera = false;
        }else if(trasera == false)
        {
            reproductor.transform.localEulerAngles = new Vector3(180, 90, 90);
            parteTrasera.SetActive(true);
            parteDelantera.SetActive(false);
            trasera = true;
        }
    }
}
