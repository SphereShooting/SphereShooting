using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bullet;
    Bullet b_cs;
    public GameObject planet;
    public GameObject player;
    GameObject gp;
    public bool auto = true;
    [Range(0.1f,5.0f)]
    public float autoFireRate = 1.0f;
    [SerializeField] bool Heroics = true;
    TestBOSSPlayer tbp;

    // Start is called before the first frame update
    void Start()
    {
        gp = player.transform.Find("GeneratePoint").gameObject;
        b_cs = bullet.GetComponent<Bullet>();
        tbp = gameObject.GetComponent<TestBOSSPlayer>();
        if (auto) { StartCoroutine(AutoFire()); }
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && !auto)
        {
            b_cs.Instantiate(bullet, gp.transform.position, Quaternion.Euler(player.transform.forward), planet, player);
        }
        else if(Heroics)
        {
            if (tbp.PlayerLife < autoFireRate)
            {
                autoFireRate = tbp.PlayerLife;
            }
        }
    }

    IEnumerator AutoFire()
    {
        while (true)
        {
            b_cs.Instantiate(bullet, gp.transform.position, Quaternion.Euler(player.transform.forward), planet, player);
            yield return new WaitForSeconds(autoFireRate);
        }
    }
}
