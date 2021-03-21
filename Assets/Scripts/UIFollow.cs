using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFollow : MonoBehaviour
{

    public GameObject FollowE;
    void Update()
    {
        transform.position = new Vector3(FollowE.transform.position.x, FollowE.transform.position.y + 0.8f, FollowE.transform.position.z);
    }
}
