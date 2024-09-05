using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriGenetator : MonoBehaviour
{
    public GameObject igaguriPrefab;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject igaguri = Instantiate(igaguriPrefab);
            igaguri.GetComponent<IgaguriController>().Shoot(new Vector3(0, 200, 2000));
        }
    }
}
