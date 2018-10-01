using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomTarget : MonoBehaviour
{
    public Text scoreBoard;
    private int skor = 0;
    public GameObject target;
    public Vector3 sinirlama;
    private float sureKisiti = 0;
    // Use this for initialization
    void Start()
    {
        scoreBoard.text = "Puan: 0";
        scoreBoard.color = Color.white;
        scoreBoard.fontSize = 20;
        scoreBoard.fontStyle = FontStyle.Bold;
    }

    // Update is called once per frame
    void Update()
    {
        if (sureKisiti >= 2)
        {
            Vector3 rastgelenokta = new Vector3(Random.Range(-sinirlama.x, sinirlama.x), sinirlama.y, sinirlama.z);
            Instantiate(target, rastgelenokta, Quaternion.identity);
            sureKisiti = 0;
        }
        else
        {
            sureKisiti += Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Arrow")
        {
            //Debug.Log("Hedef Vurdu");
            gameObject.SetActive(false);
            other.gameObject.SetActive(false);
            skor += 10;
            scoreBoard.text = "Puan: " + skor.ToString();
        }
    }
}
