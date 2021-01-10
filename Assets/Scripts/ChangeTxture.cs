using UnityEngine;
using System.Collections;

public class ChangeTxture : MonoBehaviour {



	public Texture b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, b13;
	public Renderer rend;



	private int count = 2;

	void Start() {
		rend = GetComponent<Renderer>();
	}

	public void changeTexture(int on){
		if (on == 1) {

			switch (count)
			{
			case 1:
				rend.material.mainTexture = b1;
				count++;
				break;
			case 2:
				rend.material.mainTexture = b2;
				count++;
				break;
			case 3:
				rend.material.mainTexture = b3;
				count++;
				break;
			case 4:
				rend.material.mainTexture = b4;
				count++;
				break;
			case 5:
				rend.material.mainTexture = b5;
				count++;
				break;
			case 6:
				rend.material.mainTexture = b6;
				count++;
				break;
			case 7:
				rend.material.mainTexture = b7;
				count++;
				break;
			case 8:
				rend.material.mainTexture = b8;
				count++;
				break;
			case 9:
				rend.material.mainTexture = b9;
				count++;
				break;
			case 10:
				rend.material.mainTexture = b10;
				count++;
				break;
			case 11:
				rend.material.mainTexture = b11;
				count++;
				break;
			case 12:
				rend.material.mainTexture = b12;
				count++;
				break;
			case 13:
				rend.material.mainTexture = b13;
				count++;
				break;
				}

			if (count > 13)
				count = 1;
		}

	}
}
