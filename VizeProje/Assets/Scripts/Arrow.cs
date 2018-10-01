using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arrow : MonoBehaviour
{
    private float okSogumaSuresi = 2, oyunSuresi = 60;
    private bool soguma;
    public AudioSource ses;
    public Text oyunSureYazdir;
    public int Hız;
    public GameObject ok;
    public Transform okNoktasi;
    // Use this for initialization
    void Start()
    {
        soguma = true;
        YaziStil();
    }

    // Update is called once per frame
    void Update()
    {
        HareketEttir();
        if (Input.GetButton("Fire1") && soguma)
        {
            ses.Play();
            Instantiate(ok, okNoktasi.position, okNoktasi.rotation);
            okSogumaSuresi = 0;
        }
        if (okSogumaSuresi < 1)
        {
            okSogumaSuresi += Time.deltaTime;
            soguma = false;
        }
        else
            soguma = true;
    }
    private void FixedUpdate()
    {
        if (oyunSuresi >= 0)
        {
            oyunSureYazdir.text = string.Format("{0:0}", oyunSuresi) + " saniye kaldı";
            oyunSuresi -= Time.deltaTime;
        }
        else
        {
            oyunSureYazdir.text = "Süre Bitti";
            Application.LoadLevel(2);
        }
    }
    public void HareketEttir()
    {
        float x = Input.GetAxis("Horizontal");
        //float y = Input.GetAxis("Vertical");
        Vector3 okHareketi = new Vector3(x, 0, 0);
        GetComponent<Rigidbody>().velocity = okHareketi * Hız;
    }
    public void YaziStil()
    {
        oyunSureYazdir.text = "Puan: 0";
        oyunSureYazdir.color = Color.magenta;
        oyunSureYazdir.fontSize = 20;
        oyunSureYazdir.fontStyle = FontStyle.Bold;
    }
}
