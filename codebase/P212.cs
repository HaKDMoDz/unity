using UnityEngine;
using System.Collections;

public class NewBehaviourScript:MonoNewBehaviour
{
	void Update()
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			Debug.Log("点击鼠标左键的位置为:"+Input.mousePosition);
		}
		if(Input.GetMouseButtonDown(1))
		{
			Debug.Log("点击鼠标右键的位置为:"+Input.mousePosition);
		}
		if(Input.GetMouseButtonDown(2))
		{
			Debug.Log("点击鼠标中键的位置为:"+Input.mousePosition);
		}
	}
}