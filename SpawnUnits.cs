using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnUnits : MonoBehaviour
{
    public Transform unitObj;

    void Start()
    {
        StartCoroutine(unitTimer());
    }

    
    void Update()
    {
        
    }

    IEnumerator unitTimer()
    {
        yield return new WaitForSeconds(3);
        Instantiate(unitObj, transform.position, transform.rotation);
        StartCoroutine(unitTimer());

    }
}
