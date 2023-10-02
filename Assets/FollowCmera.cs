using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCmera : MonoBehaviour
{

    [SerializeField] GameObject Thingstofollow;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Thingstofollow.transform.position + new Vector3(0,0,-10);
    }
}
