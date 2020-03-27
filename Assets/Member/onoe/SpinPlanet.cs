using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPlanet : MonoBehaviour
{
    Rigidbody rb;
    [HideInInspector] public float deltaSpin;
    [HideInInspector] public float DeltaSpin{
        get
        {
            return deltaSpin;
        }
    }
    float eRot;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        deltaSpin = 0.0f;
        eRot = transform.rotation.eulerAngles.x;
    }

    // Update is called once per frame
    void Update()
    {
        float hrz = Input.GetAxis("Horizontal");
        float vrt = Input.GetAxis("Vertical");

        //Debug.Log("hrz:" + hrz + "/vrt:" + vrt);
        float ssH = 0.0f;
        float ssV = 0.0f;

        if (hrz != 0)
        {
            ssH = Mathf.Clamp(rb.angularVelocity.z + hrz, -1, 1);
        }
        if (vrt != 0)
        {
            ssV = Mathf.Clamp(1 + vrt * 0.9f, 0.1f, 1.9f);
        }
        else
        {
            ssV = 1;
        }

        rb.angularVelocity = new Vector3(-ssV, 0, -ssH);
        deltaSpin = Mathf.Abs(transform.rotation.eulerAngles.x - eRot);
        eRot = transform.rotation.eulerAngles.x;
    }
}
