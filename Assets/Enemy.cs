using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5);
        transform.rotation = Quaternion.Euler(0, 180, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
