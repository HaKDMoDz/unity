using UnityEditor;
using UnityEngine;

[AddComponentMenu("新的脚本/自动旋转")]
class NewBehaviourScript:MonoBehaviour
{
	void Update()
	{
		transform.Rotate(0.0f,Time.deltaTime*200,0.0f);
	}
}