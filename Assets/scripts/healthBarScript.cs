using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBarScript : MonoBehaviour
{
    // Start is called before the first frame update
    float x, y;

    void Start()
    {
         x = transform.localPosition.x;
         y = transform.localPosition.y;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = transform.parent.gameObject;
        GameObject obj = player.transform.GetChild(0).gameObject;
        transform.position =  new Vector3(obj.transform.position.x+x, obj.transform.position.y +y, obj.transform.position.z );
    }
}
