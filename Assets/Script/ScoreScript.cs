using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreScript : MonoBehaviour
{   
    int score =0;
    Text NowScore;




    void Start()
    {
        score = 0;
        //Textコンポーネントを取得する
        NowScore = gameObject.GetComponent<Text>();
    }
    

    private void Update()
    {
        //score += 1;
        //NowScore.text = "Score:" + score.ToString();

        NowScore.text = "Score:" + EnemyMove.score.ToString();
    }



    //Mainシーンの始めに走る
    void OnSceneLoaded(Scene kuroda, LoadSceneMode mode)
    {
        score = 0;
    }

    
}

