using  UnityEngine;
using System.Collections;

public class NewBehaviourScript:MonoHehaviour
{
	void Update()
{
	if(Input.GetButtonDown("test"))
	{
		Debug.Log("单次按下test自定义按键");
	}

	if(Input.GetButton("test"))
	{
		Debug.Log("长按test自定义按键");
	}

	if(Input.GetButtonUp("test"))
	{
		Debug.Log("抬起test自定义按键");
	}
}
}