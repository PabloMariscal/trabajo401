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

		if (mov==true){
			this.transform.Translate(0.0f,0.04f,0.08f);
		}
		//if(Input.GetKeyUp(KeyCode.Space)) {
		if(Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Ended){
			if(mov==false){
				mov=true;
			}else {
				mov=false;
			}
		}

	}
}
