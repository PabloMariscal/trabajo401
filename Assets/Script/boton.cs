using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class boton : MonoBehaviour {


	public void OnClick(){
		meta.fase = 0;
		Application.LoadLevel (meta.fase);
	}
}
