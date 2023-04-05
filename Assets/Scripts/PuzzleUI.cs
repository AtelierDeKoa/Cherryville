using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PuzzleUI : MonoBehaviour
{
    public void GoBack()
    {
        SceneManager.LoadScene("OutdoorsScene");
    }
}
