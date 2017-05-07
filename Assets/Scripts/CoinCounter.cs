using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
	
	public string badCoinTagString;
	public GameObject menu;
	public PlayerMover mymover;
	public Rigidbody body;


	void Start() {;
		menu.SetActive (false);

	}


	void OnCollisionEnter(Collision col)
	{
		Debug.Log("Collision " + col.gameObject.name);
	}

	void OnTriggerEnter(Collider other)
	{
		
		 if (other.tag == badCoinTagString) {
			menu.SetActive (true);
			mymover.enabled = false;
			body.isKinematic = true;
			

		}


	}



	void Update() {

		if (menu.activeSelf) {
			mymover.enabled = false;
			body.isKinematic = true;
		} 


		}  


	}











