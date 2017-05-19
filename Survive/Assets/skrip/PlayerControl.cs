using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {



	public float moveSpeed;
	private Rigidbody myRigidbody;

	private Vector3 moveInput;
	private Vector3 moveVelocity;

	private Camera mainCamera;

	public tembak pestol;


	protected Animation Animation;

	protected void Awake()
	{
		Animation = GetComponentInChildren <Animation>();

	}

	void Start () {
		myRigidbody = GetComponent<Rigidbody>();
		mainCamera = FindObjectOfType<Camera>();
	}
	

	void Update () 
	{
		moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
		moveVelocity = moveInput * moveSpeed;

		Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
		Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
		float rayLength;


		if(groundPlane.Raycast(cameraRay, out rayLength))
		{
			Vector3 pointToLook = cameraRay.GetPoint(rayLength);

			transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
		}
		if (Input.GetMouseButtonDown (0))
			pestol.setNembak (true);
		

		if (Input.GetMouseButtonUp (0))
			pestol.setNembak (false);
		
	}

	void FixedUpdate (){
		myRigidbody.velocity = moveVelocity;
	}
}
