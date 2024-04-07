using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoretexttest : MonoBehaviour
{
    // Total score so far
    private int totalscore = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementValue(int score)
    {
        totalscore += score;
        updateScore();
    }

    public void updateScore()
    {
        string scoretext = "Current score: " + totalscore.ToString();
        GetComponent<TextMeshProUGUI>().text = scoretext;
    }
}
