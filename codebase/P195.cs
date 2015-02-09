using UnityEngine;
using System.Collections;

public class NewBehaviourScript:MonoBehaviour
{
	Cloth cloth=null;
	void Start()
	{
		cloth=(Cloth)GetComponent<InteractiveCloth>();
	}
	void OnGUI()
	{
		if(GUILayout.RepeatButton("向上"))
		{
			cloth.externalAcceleration=new Vector3(0,10,0);

		}
		if(GUILayout.RepeatButton("向下"))
		{
			cloth.externalAcceleration=new Vector3(0,-10,0);
		}
		if(GUILayout.RepeatButton("向左"))
		{
			cloth.externalAcceleration=new Vector3(10,0,0);
		}
		if(GUILayout.RepeatButton("向右"))
		{
			cloth.externalAcceleration=new Vector3(-10,0,0);
		}
	}
}