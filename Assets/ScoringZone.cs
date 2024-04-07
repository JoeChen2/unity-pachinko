using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringZone : MonoBehaviour
{
    // Scoreboard element to increase score
    public GameObject scoreBoard;
    // The score a zone is worth when the ball falls into it.
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D other) 
    {
        scoreBoard.GetComponent<scoretexttest>().IncrementValue(score);
    }
}
