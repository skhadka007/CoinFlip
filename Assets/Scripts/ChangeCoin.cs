using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeCoin : MonoBehaviour {
	

	public Texture Australia, Singapore, Sweden, China, Netherlands, Israel, Russia, Nepal, HongKong, Taiwan;
	public Texture Norway, SouthKorea, Canada, India, Mexico, US;
	public Renderer rend;

	public Button cName;

	public GameObject coin;
	
	public int count = 2;
	
	void Start() {
		rend = GetComponent<Renderer>();
	}
	
	public void changeTexture(int on){
		if (on == 1) {
			
			switch (count)
			{
			case 1:
				rend.material.mainTexture = US;
				cName.gameObject.SetActive(true);
				cName.GetComponentInChildren<Text>().text = "United States: 1 US Dollar";
				coin.transform.position = new Vector3(0.0f, 0.9f, -2.0f);
				coin.transform.rotation = Quaternion.Euler(90.0f, 0.0f, 0.0f);
				count++;
				break;
			case 2:
				rend.material.mainTexture = Singapore;
				cName.gameObject.SetActive(true);
				cName.GetComponentInChildren<Text>().text = "Singapore: 1 Singapore Dollar";
				coin.transform.position = new Vector3(0.0f, 0.9f, -2.0f);
				coin.transform.rotation = Quaternion.Euler(90.0f, 0.0f, 0.0f);
				count++;
				break;
			case 3:
				rend.material.mainTexture = Sweden;
				cName.gameObject.SetActive(true);
				cName.GetComponentInChildren<Text>().text = "Sweden: 1 Krona";
				coin.transform.position = new Vector3(0.0f, 0.9f, -2.0f);
				coin.transform.rotation = Quaternion.Euler(90.0f, 0.0f, 0.0f);
				count++;
				break;
			case 4:
				rend.material.mainTexture = China;
				cName.gameObject.SetActive(true);
				cName.GetComponentInChildren<Text>().text = "China: 1 Yuan";
				coin.transform.position = new Vector3(0.0f, 0.9f, -2.0f);
				coin.transform.rotation = Quaternion.Euler(90.0f, 0.0f, 0.0f);
				count++;
				break;
			case 5:
				rend.material.mainTexture = Netherlands;
				cName.gameObject.SetActive(true);
				cName.GetComponentInChildren<Text>().text = "Netherlands: 2 Euro";
				coin.transform.position = new Vector3(0.0f, 0.9f, -2.0f);
				coin.transform.rotation = Quaternion.Euler(90.0f, 0.0f, 0.0f);
				count++;
				break;
			case 6:
				rend.material.mainTexture = Israel;
				cName.gameObject.SetActive(true);
				cName.GetComponentInChildren<Text>().text = "Israel: 2 New Sheqalim";
				coin.transform.position = new Vector3(0.0f, 0.9f, -2.0f);
				coin.transform.rotation = Quaternion.Euler(90.0f, 0.0f, 0.0f);
				count++;
				break;
			case 7:
				rend.material.mainTexture = Russia;
				cName.gameObject.SetActive(true);
				cName.GetComponentInChildren<Text>().text = "Russia: 5 Ruble";
				coin.transform.position = new Vector3(0.0f, 0.9f, -2.0f);
				coin.transform.rotation = Quaternion.Euler(90.0f, 0.0f, 0.0f);
				count++;
				break;
			case 8:
				rend.material.mainTexture = Nepal;
				cName.gameObject.SetActive(true);
				cName.GetComponentInChildren<Text>().text = "Nepal: 5 Nepali Rupees";
				coin.transform.position = new Vector3(0.0f, 0.9f, -2.0f);
				coin.transform.rotation = Quaternion.Euler(90.0f, 0.0f, 0.0f);
				count++;
				break;
			case 9:
				rend.material.mainTexture = HongKong;
				cName.gameObject.SetActive(true);
				cName.GetComponentInChildren<Text>().text = "Hong Kong: 10 Hong Kong Dollars";
				coin.transform.position = new Vector3(0.0f, 0.9f, -2.0f);
				coin.transform.rotation = Quaternion.Euler(90.0f, 0.0f, 0.0f);
				count++;
				break;
			case 10:
				rend.material.mainTexture = Taiwan;
				cName.gameObject.SetActive(true);
				cName.GetComponentInChildren<Text>().text = "Taiwan: 10 New Taiwan Dollar";
				coin.transform.position = new Vector3(0.0f, 0.9f, -2.0f);
				coin.transform.rotation = Quaternion.Euler(90.0f, 0.0f, 0.0f);
				count++;
				break;
			case 11:
				rend.material.mainTexture = Norway;
				cName.gameObject.SetActive(true);
				cName.GetComponentInChildren<Text>().text = "Norway: 20 Krone";
				coin.transform.position = new Vector3(0.0f, 0.9f, -2.0f);
				coin.transform.rotation = Quaternion.Euler(90.0f, 0.0f, 0.0f);
				count++;
				break;
			case 12:
				rend.material.mainTexture = SouthKorea;
				cName.gameObject.SetActive(true);
				cName.GetComponentInChildren<Text>().text = "South Korea: 100 Won";
				coin.transform.position = new Vector3(0.0f, 0.9f, -2.0f);
				coin.transform.rotation = Quaternion.Euler(90.0f, 0.0f, 0.0f);
				count++;
				break;
			case 13:
				rend.material.mainTexture = Canada;
				cName.gameObject.SetActive(true);
				cName.GetComponentInChildren<Text>().text = "Canada: 1 Canadian Dollar";
				coin.transform.position = new Vector3(0.0f, 0.9f, -2.0f);
				coin.transform.rotation = Quaternion.Euler(90.0f, 0.0f, 0.0f);
				count++;
				break;
			case 14:
				rend.material.mainTexture = India;
				cName.gameObject.SetActive(true);
				cName.GetComponentInChildren<Text>().text = "India: 2 Indian Rupees";
				coin.transform.position = new Vector3(0.0f, 0.9f, -2.0f);
				coin.transform.rotation = Quaternion.Euler(90.0f, 0.0f, 0.0f);
				count++;
				break;
			case 15:
				rend.material.mainTexture = Mexico;
				cName.gameObject.SetActive(true);
				cName.GetComponentInChildren<Text>().text = "Mexico: 10 Pesos";
				coin.transform.position = new Vector3(0.0f, 0.9f, -2.0f);
				coin.transform.rotation = Quaternion.Euler(90.0f, 0.0f, 0.0f);
				count++;
				break;
			case 16:
				rend.material.mainTexture = Australia;
				cName.gameObject.SetActive(true);
				cName.GetComponentInChildren<Text>().text = "Australia: 1 Australian Dollar";
				coin.transform.position = new Vector3(0.0f, 0.9f, -2.0f);
				coin.transform.rotation = Quaternion.Euler(90.0f, 0.0f, 0.0f);
				count++;
				break;

			}
			
			if (count > 16)
				count = 1;
			
		}
		
	}
}
