using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Collision : MonoBehaviour
{

    public Sprite sprite1; // Drag your first sprite here
  //  public Sprite sprite2; // Drag your second sprite here
    private Collider2D anything;
    
    

    private SpriteRenderer spriteRenderer;
    private Animator animator;

    void Start()
    {
        GameObject child = transform.GetChild(0).gameObject;
        animator = child.GetComponent<Animator>();

        spriteRenderer = child.GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = sprite1; // set the sprite to sprite1

    }

    void Update()
    {
      
    }

   public void ChangeTheSprite()
    {
        
           
            animator.SetBool("infected",false);
     
   
           
          
    }

}