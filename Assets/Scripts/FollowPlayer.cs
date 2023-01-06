using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offSet = new Vector3(0, 5, -10);

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offSet;
    }
}
