using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour {

	public GameObject bullet;

	public Transform muzzle;

	public float speed = 500;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.Z)){
			GameObject bullets = GameObject.Instantiate(bullet)as GameObject;

			Vector3 force;
			force = this.gameObject.transform.forward * speed;

			bullets.GetComponent<Rigidbody>().AddForce(force);

			bullets.transform.position = muzzle.position;
		}
	}
}
