using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitung : MonoBehaviour {
    coba tcoba;
	// Use this for initialization
	void Start () {
        tcoba = GetComponent<coba>();
		
	}
	
	// Update is called once per frame
	void Update () {
        kalkulasi(tcoba.score);
	}
    private void kalkulasi (int nilai) {
        print("hasil "+nilai.ToString()+"nilai"+(nilai*2).ToString());

    }
}
