using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offsetViewFP = new Vector3(-0.1199989f, 2.39f, 0.99f);
    private Vector3 offsetViewAll = new Vector3(0f, 4.82f, -8.69f);
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        if (transform.name == "Main Camera")
        {
            offset = offsetViewAll;
        }
        else
        {
            offset = offsetViewFP;

        }
    }

    // Update is called once per frame
    void  LateUpdate()
    {
        transform.position = player.transform.position + offset;
        //if (transform.name == "Main Camera")
        //{
        //    transform.rotation = player.transform.rotation; 

        //}
    }
}
