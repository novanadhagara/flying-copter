using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rintangan : MonoBehaviour {
    Rigidbody2D fisika;
    public float kecepatan;
    public float posisiAwal;
    public float posisiRandom;
    public float posisiTabrakan;
    ///0.2, -5
	// Use this for initialization
	void Start () {
        posisiAwal = transform.position.x;

        posisiTabrakan = transform.position.x;

        fisika = GetComponent<Rigidbody2D>();
        fisika.velocity = new Vector2(-1f * kecepatan, 0f);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void resetObject()
    {
        Random.InitState(System.DateTime.Now.Millisecond);
        posisiRandom = Random.Range(0.2f, -5f)*0.8f;
        

        fisika.velocity = Vector2.zero;
        transform.position = new Vector3(posisiAwal,posisiRandom,transform.position.z);
        fisika.velocity = new Vector2(-1f * kecepatan, 0f);



    }
    void OnTriggerEnter2D(Collider2D collision)
     {
     if(collision.gameObject.CompareTag("ujung"))
     {
            resetObject();
     }

    }
}

