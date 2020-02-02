using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    public bool healed = false;
    public Healthbar hb;

    // Start is called before the first frame update
    void Start()
    {
        
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
            }
        }
    }
}
