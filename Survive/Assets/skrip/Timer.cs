using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour 
{
//	public Text highScoreText;
	public Text timertext;
	private float starttime;
//	public float HiScoreCount;
	private bool finish = false;
//	private bool hiScore;


	// Use this for initialization
	void Start () 
	{
		starttime = Time.time;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (finish)
			return;
		
		float t = Time.time - starttime;

		string minutes = ((int) t / 60).ToString();
		string seconds = (t % 60).ToString("f2");

		timertext.text = minutes + ":" + seconds;
		//highScoreText.text = minutes + ":" + seconds;
	}
	public void ended()
	{
		finish = true;
		timertext.color = Color.green;
	}
}
