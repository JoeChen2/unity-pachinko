using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoretexttest : MonoBehaviour
{
    // Scores in scorezones
    private Dictionary<string, int> scoretable;

    // Start is called before the first frame update
    void Start()
    {
        scoretable = new Dictionary<string, int>(){
            {"l",0},
            {"1",0},
            {"2",0},
            {"3",0},
            {"4",0},
            {"5",0},
            {"6",0},
            {"7",0},
            {"r",0}
        };
        // scoretable.Add("L",0);
        // scoretable.Add("1",0);
        // scoretable.Add("2",0);
        // scoretable.Add("3",0);
        // scoretable.Add("4",0);
        // scoretable.Add("5",0);
        // scoretable.Add("6",0);
        // scoretable.Add("7",0);
        // scoretable.Add("R",0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementValue(string zone)
    {
        scoretable[zone] += 1;
        updateScore();
    }

    public void updateScore()
    {
        string scoretext = "";
        foreach (KeyValuePair<string, int> pair in scoretable)
        {
            scoretext = scoretext + string.Format("{0}:{1}\n",pair.Key,pair.Value);
        }
        GetComponent<TextMeshProUGUI>().text = scoretext;
    }
}
