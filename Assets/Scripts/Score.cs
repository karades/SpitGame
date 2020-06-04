using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    float score;
    [SerializeField]
    TextMeshProUGUI textScore;

    // Start is called before the first frame update
    void Start()
    {
        textScore = this.GetComponent<TextMeshProUGUI>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = "Score: " + score ;
    }
    
    public void addPoints(float points)
    {
        score += points;
        Debug.Log(score);
    }
}
