using UnityEngine;
using System.Collections;

public class ButtonPress : MonoBehaviour {

	public GameObject flipme;
	public bool flip;

	public float height = 5;
	public float tumble = 40;

	public float x, y, z;
	public int a, h = 0, t = 0;

	// Use this for initialization
	void Start () {

	
	 
	}
	
	// Update is called once per frame
	public void flipCoin(int on){

		if (on == 1){

			int a = Random.Range (1, 3);

			if (a == 1) { //heads
				x = 30;
		//		h++;
				
			} else { 		//tails
				x = 220;
		//		t++;
			}

			transform.position = new Vector3 (0.0f, height, -2.0f);
			
			AudioSource audio = GetComponent<AudioSource> ();
			audio.Play ();
			flipme.GetComponent<Rigidbody> ().angularVelocity = Random.insideUnitSphere * tumble;
			flipme.GetComponent<Rigidbody> ().rotation = Quaternion.Euler (x, 5.0f * y, 5.0f * z);
		}
	
	}
}
