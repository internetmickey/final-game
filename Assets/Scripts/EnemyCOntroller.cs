using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class EnemyCOntroller : MonoBehaviour
{
    public Rigidbody2D enemyRb;

    public float speed = 10f;

    public int health = 25;

    [SerializeField] private ScoreTracker scoreTracker;

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

        if (health < 0)
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
            health -= 5;
        }
    }
}
