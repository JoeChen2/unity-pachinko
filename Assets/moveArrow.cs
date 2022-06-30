using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveArrow : MonoBehaviour
{
    public float period;
    public float maxangle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angle = Mathf.Sin(Time.time/period * Mathf.PI)*maxangle;
        transform.eulerAngles = new Vector3(0,0,angle);
    }
}
