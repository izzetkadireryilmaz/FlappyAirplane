using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkySpawnScripts : MonoBehaviour
{
    public float maxTime = 1;
    public float Timer = 0;
    public GameObject Skyscrapers;
    public float height;

    void Start()
    {
        GameObject newSkyscrapers = Instantiate(Skyscrapers);
        newSkyscrapers.transform.position = transform.position + new Vector3(0,Random.Range(-height,height), 0); 
    } 

    void Update()
    {
        if (Timer > maxTime)
        {
            GameObject newSkyscrapers = Instantiate(Skyscrapers);
            newSkyscrapers.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newSkyscrapers,15);
            Timer = 0;
        }

        Timer += Time.deltaTime;
    }
}
