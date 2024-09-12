using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int Score;
    public TextMeshProUGUI ScoreText;
    public ScoreData Sd;
    // Start is called before the first frame update
    void Start()
    {
        Sd.Score = 0;
        //Sd = GameObject.Find("ScoreData").GetComponent<ScoreData>();
    }

    void Update()
    {
        ScoreText.text = string.Format($"Point : {Sd.Score}");  //GameMainシーンでのスコア表示
        //Sd.Score = Score;  //ScoreDataの中のScore
    }
}
