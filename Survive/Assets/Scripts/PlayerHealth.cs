using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int maxHealth;
	public int currentHealth;
	public Transform canvas;
	public Transform timerspawner;
	public Transform lights;
	public spawner otherscript;

	public Text healthCount;



	void Start () 
	{
		currentHealth = maxHealth;
		healthCount.text = currentHealth.ToString ();
	}
	

	void Update () 
	{
		if (currentHealth <=0)
		{
			otherscript.Stop();
			gameObject.SetActive(false);
			lights.gameObject.SetActive(true);
			canvas.gameObject.SetActive(true);
			timerspawner.gameObject.SendMessage("ended");
		}
	}
	public void dmgplayer(int dmgamount)
	{
		currentHealth -= dmgamount;
		healthCount.text = currentHealth.ToString ();
	}
}
