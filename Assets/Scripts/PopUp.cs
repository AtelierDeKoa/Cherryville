using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopUp : MonoBehaviour
{
    public Animator animator;
    public TextMeshProUGUI text;
    public AudioSource notificationPopUp;
    public bool finalPopup = false;
    public Animator popUpFinalAnim;

    public void Awake()
    {
        Activate("Look for a Music Player. Press E to catch it.", false);
    }

    public void Activate(string s)
    {
        Activate(s, true);
    }

    public void Activate(string s, bool sound)
    {
        StartCoroutine(Animation(s, sound));
    }

    public IEnumerator Animation(string s, bool sound)
    {
        animator.SetBool("Alert", true);
        text.text = s;
        if (sound) notificationPopUp.Play();
        yield return new WaitForSeconds(4f);
        animator.SetBool("Alert", false);
        if(Catchable.itemCount >= 6 && !finalPopup)
        {
            finalPopup = true;
            yield return new WaitForSeconds(2f);
            Activate("Go to the Counter to fix the Music Player", false);
            animator.SetBool("Alert", true);
            yield return new WaitForSeconds(6f);
            animator.SetBool("Alert", false);
        }
    }

    public void FinalPopUp()
    {
        StartCoroutine(AnimFinal());
    }

    public IEnumerator AnimFinal()
    {
        yield return new WaitForSeconds(12f);
        popUpFinalAnim.SetBool("Alert", true);
        Cursor.lockState = CursorLockMode.None;
    }
}
