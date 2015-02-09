using UnityEngine;
using System.Collections;

public class NewBehaviourScript:MonoBehaviour
{
	GameObject particle=null;
	float velocity_x=0.0f;
	float velocity_y=0.0f;
	float velocity_z=0.0f;
	
	void Start()
	{
		particle=GameObject.Find("ParticleSystem");
	}
	
	void OnGUI()
	{
		GUILayout.Label("粒子最大尺寸");
		particle.particleEmitter.maxSize=GUILayout.HorizontalSlider
			(particle.particleEmitter.maxSize,0.0f,10.0f,GUILayout.Width(150));
		
		GUILayout.Label("粒子消失时间");
		particle.particleEmitter.maxEnergy=GUILayout.HorizontalSlider
			(particle.particleEmitter.maxEnergy,0.0f,10.0f,GUILayout.Width(150));
		
		GUILayout.Label("粒子的最大生成数量");
		particle.particleEmitter.maxEmission=GUILayout.HorizontalSlider
			(particle.particleEmitter.maxEmission,0.0f,100.0f,GUILayout.Width(150));
		
		GUILayout.Label("粒子x轴的移动速度");
		velocity_x=GUILayout.HorizontalSlider(velocity_x,0.0f,10.0f,GUILayout.Width(150));
		particle.particleEmitter.worldVelocity=new Vector3(velocity_x,particle.particleEmitter.worldVelocity.y,particle.particleEmitter.worldVelocity.z);
		
	}
}