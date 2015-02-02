using UnityEngine;
using System.Collentions;

public class Label:MonoBehavior{
	public Texture img;

	void OnGUI()
	{
		GUI.Label(new Rect(10,10,200,20),"Hello World");
		GUI.Label(new Rect(10,50,200,200),img);
	}
}