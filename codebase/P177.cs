using UnityEngine;
using System.Collections;

public class NewBehaviourScript:MonoBehaviour
{
	private CharacterController controller=null;
	private float moveSpeed=30.0f;
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
			controller.SimpleMove(Vector3.forward*moveSpeed);
		}
		if(GUILayout.RepeatButton("向后移动"))
		{
			controller.SimpleMove(Vector3.forward*-moveSpeed);
		}
		if(GUILayout.RepeatButton("向左移动"))
		{
			controller.SimpleMove(Vector3.right*-moveSpeed);
		}
		if(GUILayout.RepeatButton("向右移动"))
		{
			controller.SimpleMove(Vector3.right*moveSpeed);
		}
	}
}