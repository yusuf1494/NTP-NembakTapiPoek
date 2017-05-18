using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {

	public GameObject[] enemies;
	GameObject[] spawnedenemies;
	public Vector3 spawnValues;
	public GameObject boss;
	public float spawnWait;
	public float spawnMost;
	public float spawnLeast;
	public int startWait;
	public bool stop;
	int bossSpawnTimes;
	int randEnemy;

	public AudioClip bosssound;
	private AudioSource source;



	void Awake () 
	{
		source = GetComponent<AudioSource>();
	}

	// Use this for initialization
	void Start () 
	{
		StartCoroutine(spawning());
		InvokeRepeating("BossSpawn",60.0f, 60.0f);
		bossSpawnTimes = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		spawnWait = Random.Range (spawnLeast, spawnMost);
		spawnedenemies = GameObject.FindGameObjectsWithTag("enemy");
	}

	IEnumerator spawning()
	{
		yield return new WaitForSeconds(startWait);

		while (!stop)
		{
			
			randEnemy = Random.Range (0,7);
			Vector3 spawnPos = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), 10, Random.Range (-spawnValues.z, spawnValues.z));
			Instantiate (enemies[randEnemy], spawnPos + transform.TransformPoint (0,0,0), gameObject.transform.rotation);
			yield return new WaitForSeconds (spawnWait);
		}
	}
	public void Stop()
	{
		stop = true;
		foreach(GameObject se in spawnedenemies)
		{
			se.SetActive(false);
		}

	}
	void BossSpawn()
	{
		bossSpawnTimes = bossSpawnTimes + 1;
		source.PlayOneShot(bosssound,2.0f);
		Vector3 spawnPos = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), 4.5f, Random.Range (-spawnValues.z, spawnValues.z));
		Instantiate (boss, spawnPos + transform.TransformPoint (0,0,0), gameObject.transform.rotation);
	}
}
