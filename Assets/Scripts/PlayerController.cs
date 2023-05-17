using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    public Camera sceneCamera;

    public Weapon weapon;

    public ScoreTracker scoreTracker;

    public float moveSpeed = 10.0f;
    public Rigidbody2D playerRb;
    public float maxHealth = 1000;
    public float currentHealth = 1000;

    private bool shooting = false;
    private bool canShoot = true;
    public float shootInterval = 10f;
    private float shootCooldown;
    public float damage = 2;

    private Vector2 moveDirection;
    private Vector2 mousePosition;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        shootCooldown = 0f;
        scoreTracker = GameObject.FindObjectOfType<ScoreTracker>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move();
        FixHealth();

        if (currentHealth < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    void ProcessInputs()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shooting = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            shooting = false;
        }
        

        if (Input.GetMouseButton(0) && shootCooldown <= 0 && canShoot)
        {
            StartCoroutine(Shoot());
            //shootCooldown = shootInterval;
            
        }
       


        
        mousePosition = sceneCamera.ScreenToWorldPoint(Input.mousePosition);
    }

    IEnumerator Shoot() 
    { 
        canShoot = false;

        weapon.Fire();

        yield return new WaitForSeconds(shootInterval);
        canShoot = true;
    }

    void Move()
    {
        

        //Rotate Player
        Vector2 aimDirection = mousePosition - playerRb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        playerRb.rotation = aimAngle;
    }
    void FixHealth()
    {
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    void GameOver()
    {

    }

}
