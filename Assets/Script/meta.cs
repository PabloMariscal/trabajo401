using UnityEngine;
using System.Collections;

public class meta : MonoBehaviour {
	static meta Instance;
	public static int fase = 0;

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
		fase++;
		Application.LoadLevel (fase);
	}
}
