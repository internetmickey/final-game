using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceController : MonoBehaviour
{
    [SerializeField] public Rigidbody2D enemyRb;

    [SerializeField] float speed = 10f;

    [SerializeField] public int health = 25;

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
