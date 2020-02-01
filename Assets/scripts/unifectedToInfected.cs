using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unifectedToInfected : MonoBehaviour
{
    public Sprite uninfectedSprite; 
    public Sprite infectedSprite;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = uninfectedSprite; // set the sprite to sprite1
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Infected"))
        {
            if (spriteRenderer.sprite == uninfectedSprite) // if the spriteRenderer sprite = sprite1 then change to sprite2
            {
                spriteRenderer.sprite = infectedSprite;
                transform.gameObject.tag = "Infected";
            }
        }
    }
}
