using UnityEngine;
using System.Collections;

public class pelors : MonoBehaviour {

	public float pelorspeed;

	public float hapuspelor;

	public int dmgdone;

	public AudioClip dmgsound;
	private AudioSource source;
	private float volLowRange = .2f;
	private float volHiRange = 2.0f;

	// Use this for initialization
	void Awake () 
	{
		source = GetComponent<AudioSource>();
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
		if (other.gameObject.tag == "enemy")
		{
			float vol = Random.Range (volLowRange, volHiRange);
			source.PlayOneShot(dmgsound, vol);
			other.gameObject.GetComponent<EnemyHealth>().dmgingenemy(dmgdone);
			Destroy(gameObject, 1);
		}
	}
}
