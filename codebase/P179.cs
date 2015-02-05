using UnityEngine;
using System.Collections;

public class NewBehaviourScript:MonoBehaviour
{
	private CharacterController controller=null;
	private float moveSpeed=3.0f;
	private float rotateSpeed=3.0f;

	void Start()
	{
		controller=GetComponent<CharacterController>();
	}
	void OnGUI()
	{
		if(GUILayout.RepeatButton("向左旋转"))
		{
			transform.Rotate(0,-rotateSpeed,0);
		}
		if(GUILayout.RepeatButton("向右旋转"))
		{
			transform.Rotate(0,rotateSpeed,0);
		}
		if(GUILayout.RepeatButton("向前移动"))
		{
			Vector3 forward=transform.TransformDirection(Vector3.forward);
			controller.Move(forward*moveSpeed);
		}
		if(GUILayout.RepeatButton("向后移动"))
		{
			Vector3 forward=transform.TransformDirection(Vector3.forward);
			controller.Move(forward*-moveSpeed);
		}
		if(GUILayout.RepeatButton("起飞"))
		{
			transform.Translate(0,1,0);
		}
		if(GUILayout.RepeatButton("降落"))
		{
			transform.Translate(0,-1,0);
		}
	}
}