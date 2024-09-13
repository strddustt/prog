using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meow3 : MonoBehaviour
{
    GameObject prefab;
    private List<GameObject> gameObjects = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            guh(100);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            for (int i = 0; i < gameObjects.Count; i++)
            {
                Destroy(gameObjects[0]);
                gameObjects.Remove(gameObjects[0]);
            }
        }
    }
    private void guh(int count)
    {
        for (int i = 0; i < count; i++)
        {
            GameObject cube = Instantiate(prefab);
            gameObjects.Add(cube);
        }
    }
}
