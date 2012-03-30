using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour
{
	public AudioClip clip;

	public void CharacterHit (GameObject c)
	{
		CharacterController cc = c.GetComponent<CharacterController> ();
		cc.SendMessage ("GetCoin", 1, SendMessageOptions.DontRequireReceiver);
		//CharacterTest ct = c.GetComponent<CharacterTest>();
		//ct.GetCoin(1);
		AudioSource.PlayClipAtPoint(clip, transform.position);
		
		Destroy (gameObject);

	}
}
