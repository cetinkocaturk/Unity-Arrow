using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject ok;
    Vector3 fark;
    // Use this for initialization
    void Start()
    {
        fark = transform.position - ok.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ok.transform.position + fark;
    }
}
