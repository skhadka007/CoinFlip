using UnityEngine;
using System.Collections;

public class OnOff : MonoBehaviour {

	public GameObject image;

	public void imageOnOff(int on)
	{
		if (on == 1) 
		{
			image.SetActive(!image.activeSelf);

		}
	}
}
