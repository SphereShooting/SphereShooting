using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    [SerializeField] GameObject ContinueButton;
    [SerializeField] GameObject TitleButton;

    //ポーズボタンを押したとき時間を止める
    public void OnPauseButtonClicked()
    {
        Time.timeScale = 0f;
        ContinueButton.SetActive(true);
        TitleButton.SetActive(true);
    }

    //コンティニューボタンを押したとき時間を動かす
    public void OnContinueButtonClicked()
    {
        Time.timeScale = 1f;
        ContinueButton.SetActive(false);
        TitleButton.SetActive(false);
    }

    //タイトルボタンを押したとき時間を動かしてタイトルに飛ぶ
    public void OnTitleButtonClicked()
    {
        Time.timeScale = 1f;
        EnemyMove.terminationGauge = 0;
        EnemyMove.score = 0;
        SceneManager.LoadScene("Title");
    }

    //リトライボタンを押したときシーンをはじめから再生
    public void OnRetryButtonClicked()
    {
        Time.timeScale = 1f;
        EnemyMove.terminationGauge = 0;
        EnemyMove.score = 0;
        SceneManager.LoadScene("kuroda");
    }

    //ネクストステージボタンを押したとき次のステージのシーンが再生される
    public void OnNextStageButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Title");
    }


}
