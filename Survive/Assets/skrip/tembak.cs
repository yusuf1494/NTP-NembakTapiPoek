using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class tembak : MonoBehaviour 
{
	public AudioClip shootsound;
	public AudioClip reloadsound;
	private AudioSource source;
	private float volLowRange = .5f;
	private float volHiRange = 1.0f;

	public bool nembak;

	public pelors pelor;
	public float pelorsspeed;


	public float rateoffire;
	private float shotcounter;

	public Transform ujungBedil;

	public int tempPelor;
	public int maxPelor;

	public bool reload;

	public Text ammocount;

	// Use this for initialization
	void Awake () 
	{
		source = GetComponent<AudioSource>();
	}

	void Start()
	{
		ammocount.text = tempPelor.ToString();
	}



	// Update is called once per frame
	void Update () 
	{
		if (nembak)
		{
			shotcounter -= Time.deltaTime;
			if(shotcounter <= 0 && tempPelor >= 0 && !reload)
			{
				float vol = Random.Range (volLowRange, volHiRange);
				source.PlayOneShot(shootsound,vol);
				shotcounter = rateoffire;
				pelors pelorbaru = Instantiate(pelor, ujungBedil.position, ujungBedil.rotation)as pelors;
				pelorbaru.pelorspeed = pelorsspeed;
				tempPelor --;
				ammocount.text = tempPelor.ToString();
			}
			if (tempPelor <=0 && !reload)
			{
				reload = true;
				ammocount.text = "RELOADING";
				source.PlayOneShot(reloadsound,1.0f);
				StartCoroutine (ReloadWeapon(2));
				tempPelor = maxPelor;
			}
		}
		else
		{
			shotcounter = 0;
			if(Input.GetKeyDown(KeyCode.R))
			{
				reload = true;
				ammocount.text = "RELOADING";
				source.PlayOneShot(reloadsound,1.0f);
				StartCoroutine (ReloadWeapon(2));
				tempPelor = maxPelor;
			}
		}
	}
	public IEnumerator ReloadWeapon(float timer) 
	{
		yield return new WaitForSeconds (timer);
		reload = false;
		tempPelor = maxPelor;
		ammocount.text = tempPelor.ToString();
	}
}
