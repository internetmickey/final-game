using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollissionDetection : MonoBehaviour
{
    public GameObject scoreTracker;
   
    // Start is called before the first frame update
    void Start()
    {
        //scoreTracker = ScoreTracker.GameObject.Find("ScoreTracker");

    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        Destroy(gameObject);
        /*if (other.gameObject.CompareTag("Enemy"))
        {
         Destroy(other.gameObject);
         //scoreTracker.playerScore  += 5;
        }
        */
        
    }

    
}
