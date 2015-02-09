using UnityEngine;
using System.Collections;

public class NewBehaviourScript:MonoBehaviour
{
	int MouseFrame=0;

	void Update()
	{
		if(Input.GetMouseButton(0))
		{
			MouseFrame++;
			Debug.Log("鼠标左键长按"+MouseFrame+"帧");
		}
		if(Input.GetMouseButtonUp(0))
		{
			MouseFrame=0;
		}
		if(Input.GetMouseButton(1))
		{
			MouseFrame++;
			Debug.Log("鼠标右键长按"+MouseFrame+"帧");

		}
		if(Input.GetMouseButtonUp(1))
		{
			MouseFrame=0;
		}
		if(Input.GetMouseButton(2))
		{
			MouseFrame++;
			Debug.Log("鼠标中键长按"+MouseFrame+"帧");
		}
		if(Input.GetMouseButtonUp(2))
		{
			MouseFrame=0;
		}
	}
}