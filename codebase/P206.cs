using UnityEngine;
using System.Collections;

public class NewBehaviourScript:MonoScript
{
	int keyFrame=0;
	void Update()
	{
		if(Input.anyKeyDown)
		{
			keyFrame=0;
			Debug.Log("任意键按下");
		}
		if(Input.anyKey)
		{
			keyFrame++;
			Debug.Log("任意键被长按"+keyFrame+"帧");
		}
	}
}