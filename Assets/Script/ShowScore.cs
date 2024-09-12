using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowScore : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public ScoreData Sd;

    private void Start()
    {
        Sd = GameObject.Find("ScoreData").GetComponent<ScoreData>();
    }

    void Update()
    {
        ScoreText.text = string.Format($"Point : {Sd.GetScore()}");  //GameMainシーンでのスコア表示
    }
}
