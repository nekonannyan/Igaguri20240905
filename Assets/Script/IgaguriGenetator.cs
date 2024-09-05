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
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            igaguri.GetComponent<IgaguriController>().Shoot(worldDir.normalized * 2000);
        }
    }
}
