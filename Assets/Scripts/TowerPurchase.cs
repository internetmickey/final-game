using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPurchase : MonoBehaviour
{
    public ScoreTracker scoreTracker;
    public int score;
    public int towerCost = 25;
    public GameObject towerBottom;
    public GameObject towerTop;

    public GameObject bottomButton;
    public GameObject topButton;

    void Start()
    {
        scoreTracker = GameObject.FindAnyObjectByType<ScoreTracker>();
        
    }

    private void Update()
    {
        score = scoreTracker.playerScore;
    }


    public void BuyBottomTower()
    {
        //Activates bottom tower, subtracts the cost, disables button, and updates score.
        if (score >= towerCost)
        {
            towerBottom.SetActive(true);
            scoreTracker.playerScore -= towerCost;
            bottomButton.SetActive(false);
            scoreTracker.scoreText.text = "Score: " + scoreTracker.playerScore;
        }
    }

    public void BuyTopTower()
    {
        //Activates top tower, subtracts the cost, disables button, and updates score.
        if (score >= towerCost)
        {
            towerTop.SetActive(true);
            scoreTracker.playerScore -= towerCost;
            topButton.SetActive(false);
            scoreTracker.scoreText.text = "Score: " + scoreTracker.playerScore;
        }
    }

}
