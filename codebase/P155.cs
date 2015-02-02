using UnityEngine;
using System.Collections;
public class NewBehaviourScript:MonoBehaviour
{
	private Camera camera;
	void Start()
	{
		camera=gameObject.GetComponent<Camera>();
	}
	void OnGUI()
	{
		if(GUILayout.Button("放射观察",GUILayout.Height(50)))
		{
			camera.isOrthoGraphic=false;
		}
		if(GUILayout.Button("垂直观察",GUILayout.Height(50)))
		{
			camera.isOrthoGraphic=true;
		}
	}
}