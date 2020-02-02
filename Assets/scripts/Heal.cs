using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    public bool healed = false;
    public Healthbar hb;
    GameObject gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameHandler");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.Space) && other.gameObject.tag.Equals("Infected")) 
        {

            {
                hb.LoseHealth();
                other.gameObject.GetComponent<Collision>().ChangeTheSprite();
                other.gameObject.tag = "uninfected";
                healed = true;
                gameManager.GetComponent<initGame>().Cure();
                
            }
        }
    }
}
