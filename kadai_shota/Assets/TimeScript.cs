using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour {
	private float time = 3;
	public GameObject exchangeButton;
	public GameObject gameOverText; 
	
	void Start () {
		gameOverText.SetActive(false); 
		GetComponent<Text>().text = ((int)time).ToString();
	}
	
	void Update () {
		time -= Time.deltaTime;
		if (time < 0) {
			StartCoroutine("GameOver");
		}
/*
		if (Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene ("Title");
		}
*/
		if (time < 0) time = 0;
		GetComponent<Text> ().text = ((int)time).ToString ();
	}

	IEnumerator GameOver () {
		gameOverText.SetActive(true);
/*
		exchangeButton.GetComponent<Button>().interactable = false;
*/
		yield return new WaitForSeconds(2.0f);
	}
}