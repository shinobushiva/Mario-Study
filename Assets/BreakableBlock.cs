using UnityEngine;
using System.Collections;

public class BreakableBlock : MonoBehaviour
{

	public void CharacterHit (GameObject c)
	{
		CharacterController cc = c.GetComponent<CharacterController> ();	
		
		CharacterTest ct = c.GetComponent<CharacterTest> ();
		if (ct.lastHit == gameObject &&
			cc.collisionFlags == CollisionFlags.Below) {
			Destroy (gameObject);
		}

	}
}
