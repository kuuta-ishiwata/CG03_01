using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleSprite : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject hitKey;
    private int timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        if(timer % 100 > 50)
        {
            hitKey.SetActive(false);
        }
        else
        {
            hitKey.SetActive(true);
        }


        
    }
}
