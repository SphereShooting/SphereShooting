using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSummonScript : MonoBehaviour
{
    float terminationGaugeUp;
    [SerializeField] GameObject BOSS1;
    bool isCalledOnce = false;
    [SerializeField] GameObject planet;
    [SerializeField] GameObject warnig;
    [SerializeField] GameObject OverBossLife;


    // Update is called once per frame
    void Update()
    {
        terminationGaugeUp = EnemyMove.terminationGauge;
        if (terminationGaugeUp >= 10)
        {
            if (!isCalledOnce)
            {
                SoundController.soundNumber = 6;
                StartCoroutine("warningUp");
                Debug.Log("ゲージがたまった");
                BOSS1.SetActive(true);
                planet.GetComponent<EnemyGenerator>().enabled = false;
                GameObject[] tagobjs = GameObject.FindGameObjectsWithTag("BOSSBullet");
                foreach (GameObject obj in tagobjs)
                {
                    Destroy(obj);
                }
                isCalledOnce = true;
            }
        }
    }

    IEnumerator warningUp()
    {
        
        OverBossLife.SetActive(true);
        warnig.SetActive(true);
        //Time.timeScale = 0f;

        yield return new WaitForSeconds(2f);

        //Time.timeScale = 1f;
        warnig.SetActive(false);
    }
}
