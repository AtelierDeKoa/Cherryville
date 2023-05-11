using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScreen : MonoBehaviour
{
    public GameObject controls;
    // Start is called before the first frame update
    void Start()
    {
        controls.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("OutdoorsScene");
    }

    public void Controls()
    {
        controls.SetActive(true);
    }

    public void CloseControls()
    {
        controls.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exit game");
    }
}
