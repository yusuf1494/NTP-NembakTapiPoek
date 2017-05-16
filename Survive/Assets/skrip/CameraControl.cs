using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public Transform followTarget;
	public Vector3 targetOffset;
	public float camSpeed = 5f;

	private Transform myTransform;

	void Start(){
		myTransform = transform;
	}

	public void SetTarget (Transform aTransform){
		followTarget = aTransform;
	}

	void Update (){
		if(followTarget != null)
			myTransform.position = Vector3.Lerp (myTransform.position, followTarget.position + targetOffset, camSpeed * Time.deltaTime);
	}
}