using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    [HideInInspector] public int eNum;
    public int ENum
    {
        get { return eNum; }
        set { eNum = value; }
    }
    EnemyBullet eB;
    EnemyMove eM;

    // Start is called before the first frame update
    void Start()
    {
        eNum = 1;
        eB = enemy.GetComponent<EnemyBullet>();
        eM = enemy.GetComponent<EnemyMove>();
        StartCoroutine(PopEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PopEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(eNum % 10 + 1);
            Vector3 pos = transform.position + (transform.position - player.transform.position);
            eM.Instantiate(enemy, pos, Quaternion.Euler(-30, 0, 0), gameObject, player, eB, this);
            eNum++;
        }
    }
}
