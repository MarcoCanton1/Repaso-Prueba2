using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject prefab;
    public int amount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < amount; i++)
            {
                GameObject clon;
                clon = Instantiate(prefab);
                Destroy(clon, 2);
            }
        }
    }
}
