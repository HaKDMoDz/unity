using UnityEngine;
using System.Collections;

public class NewBehaviour:MonoBehaviour
{
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.W))
		{
			Debug.Log("您按下了W键");
		}
		if(Input.GetKeyDown(KeyCode.S))
		{
			Debug.Log("您按下了S键");
		}
		if(Input.GetKeyDown(KeyCode.A))
		{
			Debug.Log("您按下了A键");
		}
		if(Input.GetKeyDown(KeyCode.D))
		{
			Debug.Log("您按下了D键");
		}
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Debug.Log("您按下了空格键");
		}
	}
}