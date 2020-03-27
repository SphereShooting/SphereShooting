using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [HideInInspector] public GameObject planet;
    [HideInInspector] public GameObject player;
    Vector3 axis;
    public float existDistance = 100;
    [Range(0.1f, 2.0f)]
    public float bulletSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        axis = Vector3.Cross(transform.position - planet.transform.position, player.transform.position - planet.transform.position);
        StartCoroutine(Movement());
    }

    public void Instantiate(GameObject bullet, Vector3 position, Quaternion rotation, GameObject parent, GameObject planet, GameObject player)
    {
        this.planet = planet;
        this.player = player;
        Instantiate(bullet, position, rotation, parent.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Movement()
    {
        for (int i = 0; i < existDistance / bulletSpeed; i++)
        {
            transform.RotateAround(planet.transform.position, axis, bulletSpeed);
            yield return null;
        }
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" || other.gameObject.name == "ResetNet")
        {
            Destroy(this.gameObject);
        }
    }
}
