using UnityEngine;
using System.Collections;

public class bola : MonoBehaviour {
	private bool mov;
	static public bool existe=true;
	static public int cont = 0;
	// Use this for initialization
	void Start () {
		mov = true;
		existe = true;
	}

	// Update is called once per fhrame
	void Update () {
		if (existe == true) {
			cont = cont + 1;
		}

		if (mov==true){
			this.transform.Translate(0.0f,0.0f,0.1f);
		}
		if (mov==false){
			this.transform.Translate(-0.1f,0.0f,0.0f);
		}
		


		//if(Input.GetKeyUp(KeyCode.Space)) {
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Ended) {
			if (mov == false) {
				mov = true;
			} else {
				mov = false;
			}
		}

	}

	void OnGUI (){
		GUILayout.Label ("Puntuacion: " + cont);
	}
}
