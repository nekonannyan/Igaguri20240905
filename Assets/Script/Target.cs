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

        if (collision.gameObject.CompareTag("bigIgaguri"))
        {
            GetComponent<ParticleSystem>().Play();
            Sd.Score *= 3;
        }
        else
        {
            Sd.Score += 1;
        }
        Debug.Log("ƒ|ƒCƒ“ƒg’Ç‰Á");
    }
}
