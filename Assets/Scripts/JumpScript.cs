using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class JumpScript : MonoBehaviour {

	// Use this for initialization
	private float tumble = 40;
	private float height = 5;
	private float x, y = 0, z = 0;
	private int a, h = 0, t = 0;

	public Button cName;

	//Get sounds
	public AudioSource[] sounds;
	public AudioSource s1;
	public AudioSource s2;


	void Start () {

		transform.position = new Vector3(0.0f, 5, -2.0f);
		sounds = GetComponents<AudioSource> ();
		s1 = sounds [0];
		s2 = sounds [1];

	
	}
	
	// Update is called once per frame
	public void flipCoin2 (int on){


		if (on == 1){
				cName.gameObject.SetActive(false);
				
				a = Random.Range (1, 3);

				if (a == 1) { //heads
					x = 30;
					h++;
				//	Debug.Log ("HEADS " + h + " " + t);

				} else { 		//tails
					x = 220;
					t++;
				//	Debug.Log ("TAILS " + h + " " + t);
				}


				transform.position = new Vector3 (0.0f, height, -2.0f);

			    int b = Random.Range (0, 2);
				
				//Random Audio
				if (b == 0)  //s1
					s1.Play();
				else if (b == 1)
					s2.Play();
				//spawn coin tumble
				GetComponent<Rigidbody> ().angularVelocity = Random.insideUnitSphere * tumble;
				GetComponent<Rigidbody> ().rotation = Quaternion.Euler (x, 5.0f * y, 5.0f * z);
		
			}
		}
}

