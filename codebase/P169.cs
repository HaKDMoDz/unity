using UnityEngine;
using System.Collections;

public class NewBehaviourScript:MonoBehaviour
{
	string show=null;

	void Start()
	{
		show="未发生碰撞";
	}
	void OnCollisoinEnter(Collision collision)
	{
		show="进入碰撞,碰撞名称:"+collision.gameObject.name;
	}
	void OnCollisionStay(Collision collision)
	{
		show="碰撞中,碰撞名称:"+collision.gameObject.name;
	}
	void OnCollisionExit(Collision collision)
	{
		show="碰撞结束,碰撞名称:"+collision.gameObject.name;
		collison.gameObject.rigidbody.Sleep();
	}

	void OnGUI()
	{
		GUI.Label(new Rect(100,0,300,40),show);
	}
}