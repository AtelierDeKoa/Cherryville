using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catchable : MonoBehaviour
{
    public void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
}
