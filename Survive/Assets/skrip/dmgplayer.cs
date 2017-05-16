using UnityEngine;
using System.Collections;

public class dmgplayer : MonoBehaviour {

	public int dmgamount;
	public void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			other.gameObject.GetComponent<PlayerHealth>().dmgplayer(dmgamount);
		}
	}

}
