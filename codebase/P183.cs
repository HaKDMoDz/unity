using UnityEngine;
using System.Collections;

public class NewBehaviourScript:MonoBehaviour
{
	void Update()
	{
		Ray ray=new Ray(Vector3.zero,transform.position);
		RaycastHit hit;
		Physics.Raycast(ray,out hit,100);
		Debug.DrawLine(ray.origin,hit.point);

	}
}