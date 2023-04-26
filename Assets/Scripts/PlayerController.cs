using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public Camera sceneCamera;

    public Weapon weapon;

    public float moveSpeed = 10.0f;
    public Rigidbody2D playerRb;

    private bool shooting = false;
    public float shootInterval = 0.05f;
    private float shootCooldown;

    private Vector2 moveDirection;
    private Vector2 mousePosition;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        shootCooldown = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move();
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
        

        if (shooting && shootCooldown <= 0)
        {
            weapon.Fire();
            shootCooldown = shootInterval;
            
        }
        if (shootCooldown > 0)
        {
            shootCooldown -= Time.deltaTime;
        }


        
        mousePosition = sceneCamera.ScreenToWorldPoint(Input.mousePosition);
    }

    IEnumerator Shoot() 
    { 
        //canShoot = false;

        weapon.Fire();

        yield return new WaitForSeconds(shootInterval);
        //canShoot = true;
    }

    void Move()
    {
        

        //Rotate Player
        Vector2 aimDirection = mousePosition - playerRb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        playerRb.rotation = aimAngle;
    }
}
