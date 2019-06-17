using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameTesting : MonoBehaviour
{

    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        float StartTime = Time.realtimeSinceStartup;
        transform.position += transform.forward * speed * Time.deltaTime;
        float EndTime = Time.realtimeSinceStartup;
        Debug.Log((EndTime - StartTime)*1000);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
