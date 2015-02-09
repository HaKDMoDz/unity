using UnityEngine;
using System.Collections;

public class NewBehaviourScript:MonoBehaviour
{
	public Transform target;
	public float distance=20.0f;
	
	float x;
	float y;
	
	float yMinLimit=-20.0f;
	float yMaxLimit=80.0f;
	
	float xSpeed=250.0f;
	float ySpeed=120.0f;
	
	void Start()
	{
		Vector2 angles=transform.eulerAngles;
		x=angles.y;
		y=angles.x;
		if(rigidbody)
		{
			rigidbody.freezeRotation=true;
		}
	}
	
	void LateUpdate()
	{
		if(target)
		{
			x+=Input.GetAxis("Mouse X")*xSpeed*0.02f;
			y-=Input.GetAxis("Mouse Y")*ySpeed*0.02f;
			y=ClampAngle(y,yMinLimit,yMaxLimit);
			Quaternion rotation=Quaternion.Euler(y,x,0);
			
			Vector3 position=rotation*new Vector3(0.0f,0.0f,-distance)+target.position;
			
			transform.rotation=rotation;
			transform.position=position;
		}
	}
	float ClampAngle(float angle,float min,float max)
	{
		if(angle<-360)
		{
			angle+=360;
		}
		if(angle>360)
		{
			angle-=360;
		}
		return Mathf.Clamp(angle,min,max);
	}
	
}
















