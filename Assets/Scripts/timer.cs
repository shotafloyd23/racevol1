using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
	public int timeLeft;
	public Text countdownText;
	public GameObject menu;
	public string a;
	public Text finalscore;
	public GameObject text;

	void Start()
	{
		StartCoroutine("LoseTime");
		menu.SetActive (false);
	}

	void OnCollisionEnter(Collision col)
	{
		Debug.Log("Collision " + col.gameObject.name);
	}

	void OnTriggerEnter(Collider other)
	{  
		if (other.tag == a) {
			StopCoroutine ("LoseTime");
			menu.SetActive (true);


		}
	}
	void Update()
	{
		countdownText.text = ("Time Left = " + timeLeft);


	
		 if (menu.activeSelf) {
			StopCoroutine ("LoseTime");

			finalscore.text = ("YOUR TIME IS " + timeLeft + "" + "second");
			text.SetActive (false);
		}

	}

	IEnumerator LoseTime()
	{
		while (true)
		{
			yield return new WaitForSeconds(1);
			timeLeft++;
		}
	}
}