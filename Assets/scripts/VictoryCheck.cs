using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryCheck : MonoBehaviour
{
    public GameObject person1;
    public GameObject person2;
    public GameObject person3;
    public GameObject person4;
    public GameObject person5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (person1.tag.Equals("uninfected") && person2.tag.Equals("uninfected") && person3.tag.Equals("uninfected") && person4.tag.Equals("uninfected") && person5.tag.Equals("uninfected"))
        {
            SceneManager.LoadScene(sceneName: "Victory");
        }
        else if (person1.tag.Equals("Infected") && person2.tag.Equals("Infected") && person3.tag.Equals("Infected") && person4.tag.Equals("Infected") && person5.tag.Equals("Infected"))
            {
                SceneManager.LoadScene(sceneName: "GameOver");
            }
    }
}
