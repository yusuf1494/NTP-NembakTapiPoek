using UnityEngine;
using System.Collections;

public class pelormusuh : MonoBehaviour {

	public float pelorspeed;

	public float hapuspelor;

	public int dmgdone;


	// Use this for initialization
	void Awake () 
	{
		
	}
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector3.forward * pelorspeed * Time.deltaTime);

		hapuspelor -= Time.deltaTime;
		if(hapuspelor <= 0 )
		{
			Destroy(gameObject);
		}
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Player")
		{
			other.gameObject.GetComponent<PlayerHealth>().dmgplayer(dmgdone);
			Destroy(gameObject, 1);
		}
	}
}
