using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickspawner : MonoBehaviour
{
    public GameObject uzun�ub;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            spawner();
        }
        void spawner()
        {
            Instantiate(uzun�ub, transform.position, transform.rotation);
        }
    }
}
