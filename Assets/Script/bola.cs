using UnityEngine;
using System.Collections;

public class bola : MonoBehaviour {
	static bola Instance;
	private bool mov;
	static public int cont = 0;
	// Use this for initialization
	void Start () {
		mov = true;
		if (Instance != null) {
			Instance = null;
			GameObject.Destroy (gameObject);
		} else {
			GameObject.DontDestroyOnLoad (gameObject);
			Instance = this;
		}
	}
	
	// Update is called once per fhrame
	void Update () {

		if(Input.touchCount > 0 && Input.GetTouch(0).phase ==TouchPhase.Ended && mov==false){
			mov=true;
		}
		
		if(Input.touchCount > 0 && Input.GetTouch(0).phase ==TouchPhase.Ended && mov==true){
			mov=false;
		}
		if (mov==true){
			this.transform.Translate(0.0f,0.0f,0.05f);
		}
		if (mov==false){
			this.transform.Translate(-0.05f,0.0f,0.0f);
		}

		if (this.transform.position.y == -3) {
			Application.LoadLevel (4);
		}
	}

	void OnGUI (){
		GUILayout.Label ("Puntuacion: " + cont);
	}
}
