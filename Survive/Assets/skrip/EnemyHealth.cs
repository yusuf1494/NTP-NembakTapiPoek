using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	public GameObject blood;

	public int health;
	private int maxhealth;

	public int killCount;
//	public Text killnumber;

	// Use this for initialization
	void Awake () 
	{

	}

	void Start () 
	{
		killCount = 0;
//		killnumber.text = "Kills : " + KillCount.ToString();
		maxhealth = health;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(maxhealth <= 0)
		{
			killCount = killCount + 1;
//			killnumber.text = "Kills : " + killCount.ToString();
			Instantiate(blood, transform.position, transform.rotation);
			Destroy(gameObject);
		}
	}
	public void dmgingenemy(int dmg)
	{
		maxhealth -= dmg;
	}
}
