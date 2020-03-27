using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitSphereShot : MonoBehaviour
{
    [SerializeField] float speed = 0.1f;
    GameObject planet;
    private void Start()
    {
        planet = GameObject.Find("Planet");

    }

    void FixedUpdate()
    {
        //transform.position += transform.forward * speed;
        transform.RotateAround(planet.transform.position, transform.right, 0.5f);
    }


}
