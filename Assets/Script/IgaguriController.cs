using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IgaguriController : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("target"))
        {
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<ParticleSystem>().Play();
            Destroy(gameObject,0.3f);
        }
    }
}
