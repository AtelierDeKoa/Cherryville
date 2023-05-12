using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class AnimacionInicial : MonoBehaviour
{
    public GameObject blackImg;
    public GameObject mapa;
    public GameObject inventario;
    public GameObject popUp;
    public AudioSource musicaAmb;
    public PopUp popUpScript;
    public GameObject aster;
    public GameObject violet;
    public TextMeshProUGUI aster_Text;
    public TextMeshProUGUI violet_Text;
    public GameObject cameraAnim;
    public AudioSource sonidos;
    public AudioClip pasos;
    public AudioSource conversationAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Black());
        StartCoroutine(Conversation());
        StartCoroutine(EndCinematic());
        mapa.SetActive(false);
        inventario.SetActive(false);
        popUp.SetActive(false);
        aster.SetActive(false);
        violet.SetActive(false);
    }

    IEnumerator Black()
    {
        yield return new WaitForSeconds(3f);
        Destroy(blackImg);
    }

    IEnumerator Conversation()
    {
        yield return new WaitForSeconds(2.5f);
        sonidos.Play();
        yield return new WaitForSeconds(1.5f);
        conversationAudioSource.Play();
        yield return new WaitForSeconds(0.5f);
        aster_Text.text = "Violet, do you copy?";
        aster.SetActive(true);
        yield return new WaitForSeconds(3f);
        aster.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        violet_Text.text = "Loud and clear. \n Over.";
        violet.SetActive(true);
        sonidos.clip = pasos;
        sonidos.loop = true;
        sonidos.Play();
        yield return new WaitForSeconds(3f);
        violet.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        aster_Text.text = "Are you in? What do you see? \n Over.";
        aster.SetActive(true);
        yield return new WaitForSeconds(3f);
        aster.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        violet_Text.text = "Yes, It's an old music store, but there are really cool stuff here. \n Over.";
        violet.SetActive(true);
        yield return new WaitForSeconds(6f);
        violet.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        aster_Text.text = "Make sure you find something for listening to music. \n Over.";
        aster.SetActive(true);
        yield return new WaitForSeconds(4f);
        aster.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        violet_Text.text = "Yeah yeah, don't worry Aster, I'm on it. \n Out. ";
        violet.SetActive(true);
        yield return new WaitForSeconds(5f);
        violet.SetActive(false);
    }

    IEnumerator EndCinematic()
    {
        yield return new WaitForSeconds(33f);
        sonidos.Stop();
        mapa.SetActive(true);
        inventario.SetActive(true);
        popUp.SetActive(true);
        popUpScript.PopUpInicial();
        musicaAmb.Play();
        cameraAnim.gameObject.GetComponent<Animator>().enabled = false;
        CharacterMovement.blocked = false;
        CameraRotation.blocked = false;
    }
}
