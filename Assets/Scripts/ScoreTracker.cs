using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    public int playerScore = 0;
    public TextMeshProUGUI scoreText;
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

    public void AddScore()
    {
        playerScore += 5;
        Debug.Log("WORKING");
        scoreText.text = "Score: " + playerScore;
    }

     
}
