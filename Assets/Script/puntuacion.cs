using UnityEngine;
using System.Collections;

public class puntuacion : MonoBehaviour {
	// Use this for initialization
	void Start () {
		bola.existe = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		GUILayout.Label ("Puntuacion: " + bola.cont);
		if (GUI.Button(new Rect(Screen.width / 2 - 50 , Screen.height / 2 + 70, 150, 50), "Jugar de nuevo"))
		{
			meta.fase = 0;
			bola.cont=0;
			Application.LoadLevel (meta.fase);
			
		}
		if (GUI.Button(new Rect(Screen.width / 2 -150, Screen.height / 2, 150, 50), "Guardar"))
		{
			PlayerPrefs.SetInt("puntuacion" , bola.cont);
		}
		if (GUI.Button(new Rect(Screen.width / 2 +75, Screen.height / 2, 150, 50), "Cargar"))
		{
			bola.cont = PlayerPrefs.GetInt("puntuacion");
		}
	}

}
