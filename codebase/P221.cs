using UnityEngine;
using System.Collections;

public class NewBehaviourScript:MonoBehaviour
{
	public const string ANIM_NAME0="idle";
	public const string ANIM_NAME1="run";
	public const string ANIM_NAME2="walk";
	public const string ANIM_NAME3="jump_pose";

	private GameObject obj=null;

	void Start()
	{
		obj=GameObject.Find("Constructor");
		obj.animation.wrapMode=WrapMode.Loop;
	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.A))
		{
			obj.animation.Play(ANIM_NAME0);
		}
		if(Input.GetKeyDown(KeyCode.B))
		{
			obj.animation.Play(ANIM_NAME1);
		}
		if(Input.GetKeyDown(KeyCode.C))
		{
			obj.animation.Play(ANIM_NAME2);
		}
		if(Input.GetKeyDown(KeyCode.D))
		{
			obj.animation.Play(ANIM_NAME3);
		}
	}
	void OnGUI()
	{
		GUILayout.Label("点击字母ABCD 切换播放模型骨骼动画");
	}
}