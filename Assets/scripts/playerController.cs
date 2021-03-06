using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class playerController : MonoBehaviour
{

    public float speed;             //Floating point variable to store the player's movement speed.

    private Rigidbody2D player;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
    public float forceX = 0, forceY = 0;
    private float timer;
    public float maxTimer = .2f;
    private SpriteRenderer spriteRenderer;
    public Animator animator;
 
    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        player = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        timer = maxTimer;
        SoundManagerScript.PlaySound("theme");
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SoundManagerScript.PlaySound("spacebutton");
        }
        
        if (Input.anyKey)
        {

            
            if (Input.GetKey("up"))
            {
                animator.SetFloat("Speed", Mathf.Abs(forceY));
                forceX = 0; forceY = speed;
                transform.eulerAngles = new Vector3(0, 0, 0);
                SoundManagerScript.PlaySound("footsteps");

            }
            if (Input.GetKey("down"))
                {
                    animator.SetFloat("Speed", Mathf.Abs(forceY));
                    forceX = 0; forceY = -speed;
                    transform.eulerAngles = new Vector3(0, 0, 180);
                    SoundManagerScript.PlaySound("running");

            }
            if (Input.GetKey("left"))
                {
                    animator.SetFloat("Speed", Mathf.Abs(forceX));
                    forceX = -speed; forceY = 0;
                    transform.eulerAngles = new Vector3(0, 0, 90);
                    SoundManagerScript.PlaySound("running");

            }
            if (Input.GetKey("right"))
                {
                    animator.SetFloat("Speed", Mathf.Abs(forceX));
                    forceX = speed; forceY = 0;
                    transform.eulerAngles = new Vector3(0, 0, -90);
                    SoundManagerScript.PlaySound("running");

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
            animator.SetFloat("Speed", 0);
            
            }
        }

}
