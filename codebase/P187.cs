using UnityEngine;
using System.Collections;

public class NewBehaviourScript:MonoBehaviour
{
	GameObject connectedObj=null;
	Component jointComponent=null;
	
	void Start()
	{
		connectedObj=GameObject.Find("Cube1");
	}
	
	void OnGUI()
	{
		if(GUILayout.RepeatButton("添加链条关节"))
		{
			ResetJoint();
			jointComponent=gameObject.AddComponent("HingeJoint");
			HingeJoint hjoint=(HingeJoint)jointComponent;
			connectedObj.rigidbody.useGravity=true;
			hjoint.connectedBody=connectedObj.rigidbody;
		}
		if(GUILayout.RepeatButton("添加固定关节"))
		{
			ResetJoint();
			jointComponent=gameObject.AddComponent("FixedJoint");
			FixedJoint fjoint=(FixedJoint)jointComponent;
			connectedObj.rigidbody.useGravity=true;
			fjoint.connectedBody=connectedObj.rigidbody;
			
		}
	}
	void ResetJoint()
	{
		Destroy(jointComponent);
		this.transform.position=new Vector3(821.0f,72.0f,660.0f);
		connectedObj.gameObject.transform.position=new Vector3(805.0f,48.0f,660.0f);
		connectedObj.rigidbody.useGravity=false;
	}
}