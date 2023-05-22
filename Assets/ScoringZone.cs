using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringZone : MonoBehaviour
{
    // Scoreboard element to increase score
    public GameObject scoreBoard;
    // The ID that identifies the zone to increment the score
    public string zoneID;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D other) {
        scoreBoard.GetComponent<scoretexttest>().IncrementValue(zoneID);
    }
}
