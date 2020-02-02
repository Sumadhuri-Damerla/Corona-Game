using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    public float speed;             //Floating point variable to store the player's movement speed.

    private Rigidbody2D player;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
    public float forceX = 0, forceY = 0;
    private float timer = 10;
    public float maxTimer = 1f;
    private SpriteRenderer spriteRenderer;
    public Sprite hero;
    public Sprite hero2;
    public Sprite hero3;


    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        player = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        timer = maxTimer;
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            timer = maxTimer;
        }
        if (Input.anyKey)
        {

            
            if (Input.GetKey("up"))
            {
                
                if (timer < 0)
                {
                    Debug.Log("up");
                    timer = maxTimer;
                    spriteRenderer.sprite = hero;
                }
                spriteRenderer.sprite = hero3;
                
                forceX = 0; forceY = speed;
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
                if (Input.GetKey("down"))
                {
                    forceX = 0; forceY = -speed;
                    transform.eulerAngles = new Vector3(0, 0, 180);
            }
                if (Input.GetKey("left"))
                {
                    forceX = -speed; forceY = 0;
                    transform.eulerAngles = new Vector3(0, 0, 90);
            }
                if (Input.GetKey("right"))
                {
                    forceX = speed; forceY = 0;
                transform.eulerAngles = new Vector3(0, 0, -90);
            }
                if (Input.GetKey("escape"))
                {
                    Application.Quit();
                }


                float playerX = player.position.x;
                float playerY = player.position.y;
                player.MovePosition(new Vector2(playerX + forceX, playerY + forceY));

            }
            else
            {
                forceX = 0;
                forceY = 0;
                float playerX = player.position.x;
                float playerY = player.position.y;

                //Gage's comment because I hated it was any key to move
                player.MovePosition(new Vector2(playerX + forceX, playerY + forceY));

            spriteRenderer.sprite = hero2;
            }
        }

}
