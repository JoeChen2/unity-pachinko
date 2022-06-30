using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float timeToLive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<Rigidbody2D>().simulated)
        {
            timeToLive -= Time.deltaTime;
        }

        if(timeToLive <= 0.0f)
        {
            Destroy(gameObject);
        }
    }

    
	
	void OnBecameInvisible ()
	{
	   Destroy(gameObject);
	}
}
