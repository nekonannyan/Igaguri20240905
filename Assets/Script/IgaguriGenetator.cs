using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class IgaguriGenetator : MonoBehaviour
{
    public GameObject igaguriPrefab;
    public GameObject igaguriBigPrefab;
    private GameObject igaguri;
    private int count = 0;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (count == 100)
            {
                igaguri = Instantiate(igaguriBigPrefab);
                count = 0;
            }
            else
            {
                igaguri = Instantiate(igaguriPrefab);
                count++;
            }
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            igaguri.GetComponent<IgaguriController>().Shoot(worldDir.normalized * 2000);
            Destroy( igaguri,10 );
        }
    }
}
