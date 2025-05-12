using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCloner : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject spherePrefab;
    public GameObject cylinderPrefab;
    int min = 0;
    int max = 2;
    int randomNumber;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void Cloner()
    {
        randomNumber = Random.Range(min, max + 1);
        if (randomNumber == 0)
        {
            Instantiate(cubePrefab);
        }
        else if (randomNumber == 1)
        {
            Instantiate(spherePrefab);
        }
        else if (randomNumber == 2)
        {
            Instantiate(cylinderPrefab);
        }
    }
}
