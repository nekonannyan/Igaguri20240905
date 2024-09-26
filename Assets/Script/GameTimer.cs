using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    //カウントダウン
    public float countdown = 60.0f;

    //時間を表示するText型の変数
    public TextMeshProUGUI timeText;

    // Update is called once per frame
    void Update()
    {
        //時間をカウントダウンする
        countdown -= Time.deltaTime;

        //時間を表示する
        timeText.text = countdown.ToString("f1");

        //countdownが0以下になったとき
        if (countdown <= 0)
        {
            SceneManager.LoadScene("Result");
        }
    }
}
