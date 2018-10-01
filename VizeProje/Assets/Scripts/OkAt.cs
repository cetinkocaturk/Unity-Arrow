using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OkAt : MonoBehaviour
{
    public GameObject efekt;
    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * 60;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Target")
        {
            Instantiate(efekt, transform.position, transform.rotation);
            //Debug.Log("Ok Vurdu");
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
