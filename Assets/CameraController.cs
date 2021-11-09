using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

	[SerializeField]
	//Transform focus = default;
	public Transform target;
	public Vector3 lookDirection;
	public GameObject Player;

	[SerializeField, Range(1f, 20f)]
	float distance = 5f;
	//void LateUpdate()
	//{
	//	Vector3 focusPoint = focus.position;
	//	Vector3 lookDirection = transform.forward;
	//	transform.localPosition = focusPoint - lookDirection * distance;
	//	transform.LookAt(target1);
	//	if (Input.GetKeyDown("q"))
	//       {
	//		//transform.RotateAround(target.transform.position, Vector3.up, 500 * Time.deltaTime);
	//		transform.rotation = Quaternion.RotateTowards(transform.rotation, target1, 200 * Time.deltaTime);
	//	}

	//}
	void Start()
    {
		Player = GameObject.FindGameObjectWithTag("Player");
		target = Player.transform;
		//VectorParametr = lookDirection.x;
	}
	IEnumerator RotateMe(Vector3 byAngles, float inTime)
	{
		var fromAngle = transform.rotation;
		var toAngle = Quaternion.Euler(transform.eulerAngles + byAngles);
		for (var t = 0f; t < 1; t += Time.deltaTime / inTime)
		{
			transform.rotation = Quaternion.Slerp(fromAngle, toAngle, t);
			Player.transform.rotation = Quaternion.Slerp(fromAngle, toAngle, t);
			yield return null;
		}
	}
	void Update()
	{
		Vector3 focusPoint = Player.transform.position;
		lookDirection = transform.forward ;
		//Debug.Log(lookDirection);
		transform.localPosition = focusPoint - lookDirection * distance;
	    transform.LookAt(target);
		if (Input.GetKeyDown("e"))
		{
			StartCoroutine(RotateMe(Vector3.up * 90, 0.8f));
		}
		if (Input.GetKeyDown("q"))
		{
			StartCoroutine(RotateMe(Vector3.up * -90, 0.8f));
		}
	}
}
