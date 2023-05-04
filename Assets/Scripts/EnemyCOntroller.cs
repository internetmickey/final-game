using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class EnemyCOntroller : MonoBehaviour
{
    public Rigidbody2D enemyRb;

    public float speed = 1f;

    public ScoreTracker scoreTracker;

    public float health = 100f; 


    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
        scoreTracker = GameObject.FindObjectOfType<ScoreTracker>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
        
        if (health <= 0)
        {
            Destroy(gameObject);
            scoreTracker.AddScore();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Bullet"))
        {
            health -= 10;
        }
    }
}
