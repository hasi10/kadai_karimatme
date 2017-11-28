using UnityEngine;
using System.Collections;
 
public class SceneLoadScript : MonoBehaviour {
 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
		public void SceneLoad () {
			Application.LoadLevel("Title");
		}
}