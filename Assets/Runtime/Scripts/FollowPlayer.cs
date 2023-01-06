using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offSet = new Vector3(0, 6, -10);


    void LateUpdate()
    {
        transform.position = player.transform.position + offSet;
        transform.rotation = player.transform.rotation;
    }
}
