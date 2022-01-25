using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSimulation : MonoBehaviour
{
    public float waterDensity = 10f;
    private Rigidbody body;
    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        float diveProcent = -transform.position.y + transform.localScale.x * 0.5f;
        diveProcent = Mathf.Clamp(diveProcent,0, 1);
        body.AddForce(transform.up * diveProcent * waterDensity);
        body.drag = 2 * diveProcent;
        body.angularDrag = 2 * diveProcent;
    }
}
