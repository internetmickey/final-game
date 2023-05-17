using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPurchase : MonoBehaviour
{
    public ScoreTracker scoreTracker;
    public PlayerController player;
    public int score;
    public int towerCost = 25;

    public GameObject towerBottom;
    public int bottomCost = 100;

    public GameObject towerTop;
    public int topCost = 200;


    public GameObject towerTopTop;
    public int topTopCost = 300;

    public GameObject towerBottomBottom;
    public int bottomBottomCost = 400;

    private int healthUpCost = 250;
    private int getHealthCost = 50;



    public GameObject bottomButton;
    public GameObject bottomBottomButton;
    public GameObject topButton;
    public GameObject topTopButton;

    void Start()
    {
        scoreTracker = GameObject.FindObjectOfType<ScoreTracker>();
        player = GameObject.FindObjectOfType<PlayerController>();

    }

    private void Update()
    {
        score = scoreTracker.playerScore;
    }


    public void BuyBottomTower()
    {
        //Activates bottom tower, subtracts the cost, disables button, and updates score.
        if (score >= bottomCost)
        {
            towerBottom.SetActive(true);
            scoreTracker.playerScore -= bottomCost;
            bottomButton.SetActive(false);
            scoreTracker.scoreText.text = "Score: " + scoreTracker.playerScore;
        }
    }

    public void BuyTopTower()
    {
        //Activates top tower, subtracts the cost, disables button, and updates score.
        if (score >= topCost)
        {
            towerTop.SetActive(true);
            scoreTracker.playerScore -= topCost;
            topButton.SetActive(false);
            scoreTracker.scoreText.text = "Score: " + scoreTracker.playerScore;
        }
    }

    public void BuyBottomBottomTower()
    {
        //Activates bottom tower, subtracts the cost, disables button, and updates score.
        if (score >= bottomBottomCost)
        {
            towerBottomBottom.SetActive(true);
            scoreTracker.playerScore -= bottomBottomCost;
            bottomBottomButton.SetActive(false);
            scoreTracker.scoreText.text = "Score: " + scoreTracker.playerScore;
        }
    }

    public void BuyTopTopTower()
    {
        //Activates top tower, subtracts the cost, disables button, and updates score.
        if (score >= topTopCost)
        {
            towerTopTop.SetActive(true);
            scoreTracker.playerScore -= topTopCost;
            topTopButton.SetActive(false);
            scoreTracker.scoreText.text = "Score: " + scoreTracker.playerScore;
        }
    }

    public void BuyMoreHealth()
    {
     if (score >= healthUpCost)
        {
            player.maxHealth += 100;
            scoreTracker.playerScore -= healthUpCost;
            scoreTracker.scoreText.text = "Score: " + scoreTracker.playerScore;
        }
    }

    public void BuyGetHealth()
    {
        if (score >= getHealthCost)
        {
            player.currentHealth += 25;
            scoreTracker.playerScore -= getHealthCost;
            scoreTracker.scoreText.text = "Score: " + scoreTracker.playerScore;
        }   
    }


}
