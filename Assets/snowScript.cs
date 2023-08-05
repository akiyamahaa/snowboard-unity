using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowScript : MonoBehaviour
{
    public float accel = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<SurfaceEffector2D>().speed += accel * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<SurfaceEffector2D>().speed -= accel * Time.deltaTime;
        }
    }
}
