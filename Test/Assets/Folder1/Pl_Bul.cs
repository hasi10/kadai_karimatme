using UnityEngine;
using System.Collections;

public class Pl_Bul : MonoBehaviour {

	bool m_xPlus = true;

	public float DX;
	// Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
    	if(m_xPlus){
    		transform.position += new Vector3(2f*Time.deltaTime, 0f, 0f);
    		if(transform.position.x >= 2)
    			m_xPlus = false;
    	}else{
    		transform.position -= new Vector3(2f*Time.deltaTime, 0f, 0f);
    		if(transform.position.x <= -2){
    			m_xPlus = true;
    		}
    	}
    }
	void OnCollisionEnter(Collision other){
		if(other.gameObject.CompareTag("Pl_Atk")){
		Destroy(this.gameObject);

		Destroy(other.gameObject);
	   }
	}
}
