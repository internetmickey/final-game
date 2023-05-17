using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    public int playerScore = 0;
    public TextMeshProUGUI scoreText;
    public int bruteScore = 25;
    public int gruntScore = 10;
    public int bouncerScore = 5;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + playerScore;   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            // or if (Input.GetButtonUp("Cancel")) {
            Application.Quit();
        }
    }

    public void AddScoreBouncer()
    {
        playerScore += bouncerScore;
        
        scoreText.text = "Score: " + playerScore;
    }
    public void AddScoreGrunt()
    {
        playerScore += gruntScore;
        
        scoreText.text = "Score: " + playerScore;
    }

    public void AddScoreBrute()
    {
        playerScore += bruteScore;
        
        scoreText.text = "Score: " + playerScore;
    }


}
