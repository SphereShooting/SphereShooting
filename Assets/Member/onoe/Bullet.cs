using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [HideInInspector] public GameObject mainCamera;
    [HideInInspector] public GameObject planet;
    [HideInInspector] public GameObject player;
    public float existFrame = 100;
    [Range(0.1f, 2.0f)]
    public float bulletSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.Find("Player");
        //mainCamera = player.transform.Find("Main Camera").gameObject;
        //planet = GameObject.Find("Planet");
        StartCoroutine(Movement());
    }

    public void Instantiate(GameObject bullet, Vector3 position, Quaternion rotation, GameObject planet, GameObject player)
    {
        this.planet = planet;
        this.player = player;
        mainCamera = player.transform.Find("Main Camera").gameObject;
        Instantiate(bullet, position, rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Movement()
    {
        for(int i = 0; i < existFrame; i++)
        {
            transform.RotateAround(planet.transform.position, mainCamera.transform.right, bulletSpeed);
            yield return null;
        }
        Destroy(this.gameObject);
    }
}
