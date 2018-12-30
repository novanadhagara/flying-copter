using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class kontrol : MonoBehaviour {
    Rigidbody2D fisika;
    public Text teksSkor;
    public float gayaKeatas;
    public int skor;
    public GameObject panelGameOver;

    // Use this for initialization
    void Start() {
        fisika = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0))
        {
            fisika.velocity = Vector2.zero;
            fisika.AddForce(new Vector2(0f, gayaKeatas));
        }
       
    }
    public void game_ulangin() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

     }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("skore"))
        {
            skor += 10;
            teksSkor.text = "Score " + skor.ToString();
        }else if(collision.gameObject.CompareTag("rintangan")) {
            panelGameOver.SetActive(true);
        }
    }
}
