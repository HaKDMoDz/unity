using UnityEngine;
using System.Collections;

public class NewBehaviourScript:MonoBehaviour
{
	//大地图地形对象
	GameObject plane;
	//大地图主角对象
	GameObject cube;

	float mapWidth;
	float mapHeight;
	float widthCheck;
	float heightCheck;
    //小地图主角的位置
	float mapcube_x=0;
	float mapcube_y=0;
    
	bool keyUp;
	bool keyDown;
	bool keyLeft;
	bool keyRight;

	public Texture map;
	public Texture map_cube;

	void Start()
	{
		plane=GameObject.Find("Plane");
		cube=GameObject.Find("Cube");

		float size_x=plane.GetComponent<MeshFilter>().mesh.bounds.size.x;
		float scal_x=plane.transform.localScale.x;
		float size_z=plane.GetComponent<MeshFilter>().mesh.bounds.size.z;
		float scal_z=plane.transform.localScale.z;

		mapWidth=size_x*scal_x;
	    mapHeight=size_z*scal_z;

	    widthCheck=mapWidth/2;
	    heightCheck=mapHeight/2;

	    check();
	}
	void OnGUI()
	{
		keyUp=GUILayout.RepeatButton("向前移动");
		keyDown=GUILayout.RepeatButton("向后移动");
		keyLeft=GUILayout.RepeatButton("向左移动");
		keyRight=GUILayout.RepeatButton("向右移动");

		GUI.DrawTexture(new Rect(Screen.width-map.width,0,map.width,map.height),map);
		GUI.DrawTexture(new Rect(mapcube_x,mapcube_y,map_cube.width,map_cube.height),map_cube);


	}
	void FixedUpdate()
	{
		if(keyUp)
		{
			cube.transform.Translate(Vector3.forward*Time.deltaTime*5);
			check();
		}
		if(keyDown)
		{
			cube.transform.Translate(-Vector3.forward*Time.deltaTime*5);
			check();
		}
		if(keyRight)
		{
			cube.transform.Translate(Vector3.right*Time.deltaTime*5);
			check();
		}
		if(keyLeft)
		{
			cube.transform.Translate(-Vector3.right*Time.deltaTime*5);
		}
	}

	void check()
	{
		float x=cube.transform.position.x;
		float z=cube.transform.position.z;
		if(x>=widthCheck)
		{
			x=widthCheck;
		}
		if(x<=-widthCheck)
		{
			x=-widthCheck;
		}
		if(z>=heightCheck)
		{
			z=heightCheck;
		}
		if(z<=-heightCheck)
		{
			z=-heightCheck;
		}
		cube.transform.position=new Vector3(x,cube.transform.position.y,z);
		mapcube_x=(map.width/mapWidth*x)+((map.width/2)-(map_cube.width/2))+(Screen.width-map.width);
		mapcube_y=map.height-((map.height/mapHeight*z)+(map.height/2));
	}

}