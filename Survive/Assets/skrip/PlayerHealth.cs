using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int maxHealth;
	public int currentHealth;
	public Transform canvas;
	public Transform timerspawner;
	public Transform lights;
	public spawner otherscript;





	void Start () 
	{
		currentHealth = maxHealth;
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
	}
}
