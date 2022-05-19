using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public GameObject cube;

    void Start()
    {
        cube.SetActive(false);   
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cube.SetActive(!cube.activeInHierarchy);
        }
        
    }
}
