using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class BruteController : MonoBehaviour
{
    [SerializeField] public Rigidbody2D enemyRb;

    [SerializeField] float speed = 10f;

    [SerializeField] public int health = 25;

    [SerializeField] private ScoreTracker scoreTracker;

    [SerializeField] public float damage = 20f;

    public PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
        scoreTracker = GameObject.FindObjectOfType<ScoreTracker>();
        player = GameObject.FindObjectOfType<PlayerController>();
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
            scoreTracker.AddScoreBrute();
            GameObject.FindGameObjectWithTag("Wave Manager").GetComponent<WaveSpawner>().spawnedEnemies.Remove(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("Wave Manager").GetComponent<WaveSpawner>().spawnedEnemies.Remove(gameObject);
            player.currentHealth -= damage;
        }

        if (other.gameObject.CompareTag("Bullet"))
        {
            health -= 4;
        }
    }

   
}
