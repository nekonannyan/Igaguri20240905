using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public ScoreData Sd;
    void Start()
    {
        //Sd = GameObject.Find("ScoreData").GetComponent<ScoreData>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Sd.Score += 1;
        Debug.Log("ƒ|ƒCƒ“ƒg’Ç‰Á");
    }
}
