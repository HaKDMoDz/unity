using UnityEngine;
using System.Collections;

public class NewBehaviourScript:MonoBehaviour
{
	GameObject addFrceObj=null;
	GameObject addPosObj=null;
	GameObject cubeObj=null;
	void Start()
	{
		addFrceObj=GameObject.Find("Sphere0");
		addPosObj=GameObject.Find("Sphere1");
		
		cubeObj=GameObject.Find("Cube");
		
	}
	
	void OnGUI()
	{
		if(GUILayout.Button("普通力",GUILayout.Height(50)))
		{
			addFrceObj.rigidbody.AddForce(1000,0,1000);
		}
		if(GUILayout.Button("位置力",GUILayout.Height(50)))
		{
			Vector3 force=cubeObj.transform.position-addPosObj.transform.position;
			addPosObj.rigidbody.AddForceAtPosition(force,addPosObj.transform.position,ForceMode.Impulse);
		}
	}
}