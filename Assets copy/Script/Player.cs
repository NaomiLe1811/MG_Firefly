using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed = 10f; //this variable indicate how fast our player will be moving
    private Rigidbody2D rb; //physics to move our player
    private Vector2 playerDirection;//process our player input

    // Start is called before the first frame update
    void Start()
    {
     rb = GetComponent<Rigidbody2D>(); //fetching the Rigidbody2D from our "Player" game object
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        float directionX = Input.GetAxisRaw("Horizontal");
        playerDirection = new Vector2(directionX, directionY).normalized; //we add .normalized at the end to ensure the player's movement is consitent
    }

    //Next, we want to create a fixedupdate, 
    void FixedUpdate()
    {
        rb.velocity = new Vector2(playerDirection.x, playerDirection.y) * playerSpeed;
    }
}
