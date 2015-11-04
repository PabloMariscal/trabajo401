using UnityEngine;
using System.Collections;

public class plano : MonoBehaviour {
	static plano Instance;

	
	// Use this for initialization
	void Start () {
		if (Instance != null) {
			Instance = null;
			GameObject.Destroy (gameObject);
		} else {
			GameObject.DontDestroyOnLoad (gameObject);
			Instance = this;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter (Collision colision){
		Application.LoadLevel (4);
	}
}
