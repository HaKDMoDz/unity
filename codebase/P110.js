private var objCube:GameObject;
private var objCylinder:GameObject;
private var speed:int=100;

function Start()
{
	objCube=GameObject.Find("Cube");
	objCylinder=GameObject.Find("Cylinder");
}

function OnGUI()
{
	if(GUILayout.Button("立方体沿x轴旋转",GUILayout.Height(50)))
	{
		objCube.transform.Rotate(Vector3.right*Time.deltaTime*speed);
	}
	if(GUILayout.Button("立方体沿y轴旋转",GUILayout.Height(50)))
	{
         objCube.transform.Rotate(Vector3.up*Time.deltaTime*speed);
	}
	if(GUILayout.Button("立方体沿z轴旋转",GUILayout.Height(50)))
	{
		objCube.transform.Rotate(Vector3.forward*Time.deltaTime*speed);
	}

	if(GUILayout.Button("立方体沿圆柱体旋转",GUILayout.Height(50)))
	{
		objCube.transform.RotateAround(objCylinder.transform.position,Vector3.up,Time.deltaTime*speed);


	}
	GUILayout.Label("立方体旋转角度"+objCube.transform.rotation);
}