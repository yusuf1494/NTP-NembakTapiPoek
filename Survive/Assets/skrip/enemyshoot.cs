using UnityEngine;
using System.Collections;

public class enemyshoot : MonoBehaviour {

	public pelormusuh pelormusuh;
	public float pelorsspeed;

	public float rateoffire;
	private float shotcounter;

	public Transform enemygun;

	public bool nembak;

	// Use this for initialization
	void Start () {
		nembak = true;
	
	}
	
	// Update is called once per frame
	void Update () {
		shotcounter -= Time.deltaTime;
		if (nembak && shotcounter <=0)
		{
			shotcounter = rateoffire;
			pelormusuh pelorbaru = Instantiate(pelormusuh, enemygun.position, enemygun.rotation)as pelormusuh;
			pelorbaru.pelorspeed = pelorsspeed;
		}
		else
		{
			shotcounter =0;
		}
	
	}
}
