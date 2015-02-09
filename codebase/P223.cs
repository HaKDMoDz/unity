using UnityEngine;
using System.Collections;

public class NewBehaviourScript:MonoBehaviour
{
	private GameObject obj=null;

	void Start()
	{
		obj=GameObject.Find("man");

	}

	void OnGUI()
	{
		if(GUILayout.Button("播放完整动画"))
		{
			obj.animation.Play();
		}
		if(GUILayout.Button("切割动画0-50帧"))
		{
			PlayCuttingAnimation(obj,0,50);
		}
		if(GUILayout.Button("合并动画0-50帧 与 100-150 帧"))
		{
			PlayCombinedAnimation(obj,0,50,100,150);
		}
	}

	public void PlayCuttingAnimation(GameObject manObject,int startFrame,int endFrame)
	{
		AnimationClip clip=manObject.animation.clip;

		manObject.animation.AddClip(clip,"cutClip",startFrame,endFrame);
		manObject.animation.Play("cutClip");

	}
	public void PlayCombinedAnimation(GameObject manObject,int startFrame0,int endFrame0,int startFrame1,int endFrame1)

	{
		AnimationClip clip=manObject.animation.clip;

		manObject.animation.AddClip(clip,"startClip",startFrame0,endFrame0,false);

		manObject.animation.AddClip(clip,"endClip",startFrame1,endFrame1,false);

		manObject.animation.PlayQueued("startClip",QueueMode.PlayNow);

		manObject.animation.PlayQueued("endClip",QueueMode.CompleteOthers);
	}
}

















