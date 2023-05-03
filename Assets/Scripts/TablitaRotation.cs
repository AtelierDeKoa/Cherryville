using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TablitaRotation : MonoBehaviour
{
    float rotation;
    bool colision;
    public Vector3 axisRotation;
    public Vector3 pointRotation;
    public GameObject tablita;

    // Start is called before the first frame update
    void Start()
    {
        rotation = 0;
        Vector3 axisStart = transform.GetChild(0).position;
        Vector3 axisEnd = transform.GetChild(1).position;
        axisRotation = (axisEnd - axisStart).normalized;
        pointRotation = (axisEnd + axisStart) / 2;
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 50*Time.deltaTime;
        float delta = colision ? Mathf.Min(speed, 90 - rotation) : Mathf.Max(-speed, - rotation);
        rotation += delta;
        tablita.transform.RotateAround(pointRotation, axisRotation, delta);
    }

    private void OnTriggerEnter(Collider c)
    {
        colision = true;
    }

    private void OnTriggerExit(Collider c)
    {
        colision = false;
    }
}
