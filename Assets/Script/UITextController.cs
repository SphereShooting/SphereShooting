using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITextController : MonoBehaviour
{
    [SerializeField] GameObject UIText;

    void Start()
    {
        SoundController.soundNumber = 8;
        StartCoroutine("TextSetActive");
    }

    //UITextのアクティブ状態を制御する
    IEnumerator TextSetActive()
    {
        yield return new WaitForSeconds(3.0f);

        UIText.SetActive(false);
    }

    //UITextの内容を書き換えるメソッド
    void ChangeUIText(string text)
    {
        UIText.GetComponent<Text>().text = text;
    }
}
