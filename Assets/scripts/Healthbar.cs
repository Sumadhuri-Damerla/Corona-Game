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
    // Start is called before the first frame update
    void Start()
    {
        counter = 6;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoseHealth()
    {
        counter--;
        if (counter == 5)
        {
            GameObject.Destroy(sprite1);
        }
        else if (counter == 4)
        {
            GameObject.Destroy(sprite2);
        }
        else if (counter == 3)
        {
            GameObject.Destroy(sprite3);
        }
        else if (counter == 2)
        {
            GameObject.Destroy(sprite4);
        }
        /*
        else if (counter == 1)
        {
            GameObject.Destroy(sprite5);
        }
        */
        else
        {
            SceneManager.LoadScene(sceneName: "GameOver");
        }
    }
}
