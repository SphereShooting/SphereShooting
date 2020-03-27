using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossLifeScript : MonoBehaviour
{
    [SerializeField] Slider BossLifeSlider;
    [SerializeField] GameObject Results;
    [SerializeField] GameObject TitleButton;
    [SerializeField] GameObject NextStageButton;
    [SerializeField] GameObject GameClearOrOver;
    [SerializeField] GameObject split2Boss1;
    float OverBossLife = 1.0f;

    void GetOverBossLife(float damege)
    {
        OverBossLife -= damege;

        BossLifeSlider.value = OverBossLife;

        if (BossLifeSlider.value <= 6.705523e-07)
        {
            split2Boss1.SetActive(false);
            Results.SetActive(true);
            TitleButton.SetActive(true);
            NextStageButton.SetActive(true);
            //Textコンポーネントを取得する
            Text GameOver = GameClearOrOver.GetComponent<Text>();
            GameOver.text = "GAME CLEAR";
            Time.timeScale = 0f;
        }
    }
}
