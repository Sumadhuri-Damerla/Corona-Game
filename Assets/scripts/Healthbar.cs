using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Healthbar : MonoBehaviour
{
    public GameObject sprite1;
    public GameObject sprite2;
    public GameObject sprite3; 
    public GameObject sprite4;
    public GameObject sprite5;
    private int counter;
    private float timer;
    public float maxTimer = 10f;
    public int maxCounter = 6;
    // Start is called before the first frame update
    void Start()
    {
        counter = 6;
        timer = maxTimer;
    }

    // Update is called once per frame
    void Update()
    {
       
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            GainHealth();
            timer = maxTimer;
        }
        
        
    }
    public void LoseHealth()
    {
        counter--;
        if (counter == 5)
        {
            //GameObject.Destroy(sprite1);
            sprite1.SetActive(false);
        }
        else if (counter == 4)
        {
            //GameObject.Destroy(sprite2);
            sprite2.SetActive(false);

        }
        else if (counter == 3)
        {
            //GameObject.Destroy(sprite3);
            sprite3.SetActive(false);

        }
        else if (counter == 2)
        {
            //GameObject.Destroy(sprite4);
            sprite4.SetActive(false);

        }
        /*
        else if (counter == 1)
        {
            GameObject.Destroy(sprite5);
        }
        */
        else if (counter == 0)
        {
            SceneManager.LoadScene(sceneName: "GameOver");
        }
    }
    public void GainHealth()
    {
        
        if (counter > 5)
        {
            counter = maxCounter;
        }
        if (counter == 5)
        {
            //Instantiate(sprite1);
            sprite1.SetActive(true);
        }
        else if (counter == 4)
        {
            //Instantiate(sprite2);
            sprite2.SetActive(true);
        }
        else if (counter == 3)
        {
            //Instantiate(sprite3);
            sprite3.SetActive(true);
        }
        else if (counter == 2)
        {
            //Instantiate(sprite4);
            sprite4.SetActive(true);
        }

        counter++;
    }
}
