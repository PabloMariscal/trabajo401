using UnityEngine;
using System.Collections;

public class cubo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision colision){
		bola.cont = bola.cont + 5;
		Destroy(gameObject);
	}
}
