using UnityEngine;
using System.Collections;

public class CharacterTest : MonoBehaviour
{
	
	private CharacterController cc;
	private int numCoins = 0;
	private int numLives = 4;
	public GameObject lastHit;

	// Use this for initialization
	void Start ()
	{
		cc = gameObject.GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	
	public void GetCoin (int num)
	{
		numCoins += num;
		// if more than 100, 1up!
		if (numCoins > 100) {
			numLives += 1;
			numCoins -= 100;
		}
	}
	
	void OnGUI ()
	{
		GUILayout.Label ("Coin : " + numCoins);
	}
	
	void OnControllerColliderHit (ControllerColliderHit hit)
	{
		Debug.Log ("OCC : " + hit.gameObject);
		lastHit = hit.gameObject;
		hit.gameObject.SendMessage ("CharacterHit", gameObject, 
			SendMessageOptions.DontRequireReceiver);
	}
}
