using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SoundToggle : MonoBehaviour {

	public Sprite sOn, sOff;
	public Button audioBtn;

	public AudioListener listen;
	
	private int count = 2;

	// Use this for initialization
	void Start () {
//		rend = GetComponent<Renderer>();
//		listen = GetComponent<AudioListener> ();
	}
	
	public void soundPic(int on){
		if (on == 1) {
			
			switch (count)
			{
			case 1:
				audioBtn.GetComponent<Image> ().sprite = sOn;
				AudioListener.volume = 1.0f;
				count++;
				break;
			case 2:
				audioBtn.GetComponent<Image> ().sprite = sOff;
				AudioListener.volume = 0.0f;
				count++;
				break;
			}
			if (count > 2)
				count = 1;
		}
	}
}
