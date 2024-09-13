using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Random = UnityEngine.Random;

public class meow2 : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("working");
            Vector3 pos = new Vector3(Random.Range(-5, 5), 1, Random.Range(-5, 5));
            GameObject newprefab = Instantiate(prefab);
            newprefab.transform.position = pos;
            float randomscale = UnityEngine.Random.Range(0.3f, 1.5f);
            newprefab.transform.localScale = new Vector3(randomscale, randomscale, randomscale);
        }
    }
}