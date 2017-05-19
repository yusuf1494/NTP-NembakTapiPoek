using UnityEngine;
using System.Collections;

public class DamagePlayerController : MonoBehaviour {

	public int damageAmount;
	public void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			other.gameObject.GetComponent<PlayerHealth>().dmgplayer(damageAmount);
		}
	}

}
