using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BOSS1Gimmick : MonoBehaviour
{
    [SerializeField] float BOSSLife = 40.0f;
    [SerializeField] GameObject Split1BOSS;
    [SerializeField] GameObject OverBossLife;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            BOSSLife -= 1.0f;

            OverBossLife.SendMessage("GetOverBossLife",0.01f);

            if (BOSSLife <= 0)
            {
                EnemyMove.score += 1000;
                Split1BOSS.SetActive(true);
                //BOSSBulletタグのオブジェクトをすべて消す
                GameObject[] tagobjs = GameObject.FindGameObjectsWithTag("BOSSBullet");
                foreach (GameObject obj in tagobjs)
                {
                    Destroy(obj);
                }
                Destroy(this.gameObject);
            }
        } 
    }
}
