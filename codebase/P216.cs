using UnityEngine;
using System.Collections;

public class NewBehaviourScript:MonoBehaviour
{
	void Update()
	{
	float value=Input.GetAxis("test");
	Debug.Log("按数轴的数值为:"+value);
}

}
