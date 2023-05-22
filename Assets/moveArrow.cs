using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveArrow : MonoBehaviour
/**
*use to move the ball dropper tube back and forth.
*/
{
    // Time taken for a complete back and forth motion of the ball dropper.
    public float period;
    // The maxium angle the dropper will displace.
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
