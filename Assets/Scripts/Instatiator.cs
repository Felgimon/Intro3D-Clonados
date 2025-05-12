using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instatiator : MonoBehaviour
{
    public GameObject cubePrefab;

    void Start()
    {
    }

    void Update()
    {
         
    }

    public void ClonarCubo()
    {
        Instantiate(cubePrefab);
    }
}
