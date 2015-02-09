using UnityEngine;
using System.Collections;
public class NewBehaviourScript:MonoBehaviour
{
	int keyFrame=0;

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.A))
		{
			Debug.Log("A按下一次");
		}
		if(Input.GetKey(KeyCode.A))
		{
			keyFrame++;
			Debug.Log("A按下了"+keyFrame+"帧");
		}
		if(Input.GetKeyUp(KeyCode.A))
		{
			keyFrame=0;
			Debug.Log("A键抬起");
		}
	}
}