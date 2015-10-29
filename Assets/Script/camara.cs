using UnityEngine;
using System.Collections;

public class camara : MonoBehaviour {
	private bool mov;
	// Use this for initialization
	void Start () {
		mov = true;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetTouch(0).phase ==TouchPhase.Ended){
			if(mov==false){
				mov=true;
			}else {
				mov=false;
			}
		}
		if (mov==true){
			this.transform.Translate(0.0f,0.02f,0.05f);
		}
	}
}
