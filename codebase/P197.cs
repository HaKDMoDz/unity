using UnityEngine;
using System.Collections;

public class NewBehaviourScript:MonoBehaviour
{
	private TrailRenderer trailRender;

	void Start()
	{
		trailRender=gameObject.GetComponent<TrailRenderer>();
	}
	void OnGUI()
	{
		if(GUILayout.Button("增加宽度",GUILayout.Height(50)))
		{
			trailRender.startWidth+=1;
			trailRender.endWidth+=1;
		}
		if(GUILayout.Button("显示路径",GUILayout.Height(50)))
		{
			trailRender.enabled=true;
		}
		if(GUILayout.Button("隐藏路径",GUILayout.Height(50)))
		{
			trailRender.enabled=false;
		}
	}
}