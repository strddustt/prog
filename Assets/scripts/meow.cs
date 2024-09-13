using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class meow : MonoBehaviour
{
    public GameObject prefab;
    Material mat;
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < 100; i++)
        {
            StartCoroutine(instantiator(0, false));
        }
        StartCoroutine(instantiator(1, true));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private Color random()// ik had hier de material ook aan kunnen passen, maar dit is makkelijker.
    {
        int i = Random.Range(0, 4);
        switch (i)
        {
            case 0: return Color.red;
            case 1: return Color.green;
            case 2: return Color.blue;
            case 3: return Color.white;
        }
        Debug.Log("failsafe");
        return Color.white;
    }
    private IEnumerator instantiator(float time, bool a)
    {
        Debug.Log("instantiating");
        Vector3 Transform = new Vector3(Random.Range(0,10), Random.Range(7, 10), Random.Range(0, 10)); // vector3 in eigen functie aanmaken is niet beter naar mijn mening ivm het feit dat ik het maar 2 keer aanvraag in mn hele script.
        GameObject newprefab = Instantiate(prefab);
        newprefab.transform.position = Transform;
        mat = newprefab.GetComponent<MeshRenderer>().material;
        mat.SetColor("_Color", random());
        yield return new WaitForSeconds(time);
        if (a == true)
        {
            StartCoroutine(instantiator(1, true));
        }
            yield return new WaitForSeconds(3);
        Destroy(newprefab);
        yield break;
    }
}
