using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class initGame : MonoBehaviour
{
    public int initialCount = 2;
    public GameObject prefab;
    int infected;
    int cured;
    GameObject[] players;
    float Xmin, Xmax, Ymin, Ymax;


    // Start is called before the first frame update
    void Start()
    {
        players = new GameObject[initialCount];
        cured = 0;
        infected = initialCount;

        Xmin = GameObject.Find("leftBound").transform.position.x;
        Xmax = GameObject.Find("rightBound").transform.position.x;
        Ymin = GameObject.Find("lowerBound").transform.position.y;
        Ymax = GameObject.Find("upperBound").transform.position.y;

        for (int i = 0; i < initialCount; i++)
        {
            players[i] = Instantiate(prefab, new Vector3(Random.Range(Xmin,Xmax), Random.Range(Ymin, Ymax), 0), Quaternion.identity);

            
            players[i].GetComponent<infectedMovement>().initializeSpeed(Random.Range(0.01f, 0.2f));

    /*        if (i % 2 == 0)
            {
                players[i].tag = "uninfected";
                GameObject tempChild = players[i].transform.GetChild(0).gameObject; 
                tempChild.GetComponent<Animator>().SetBool("infected", false);
            }
     */       
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (cured == initialCount)
        {
            Invoke("delayedSceneLoad", 2f);   
        }
    }


    IEnumerator delay(float time)
    {
        yield return new WaitForSeconds(time);

    }

    void delayedSceneLoad()
    {
        SceneManager.LoadScene(sceneName: "Victory");
    }

    public void Cure()
    {
        cured++;
        infected--;
    }

    public void Infect()
    {
        infected++;
        cured--;
    }
    
}
