using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour
{
    // Start is called before the first frame update
    ReflectionProbe probe;
    void Start()
    {
        this.probe = GetComponent<ReflectionProbe>();
    }

    // Update is called once per frame
    void Update()
    {
        this.probe.transform.position =
        new Vector3(Camera.main.transform.position.x,
                    Camera.main.transform.position.y*-0.5f,
                    Camera.main.transform.position.z+1.8f);
        probe.RenderProbe();
    }
}
