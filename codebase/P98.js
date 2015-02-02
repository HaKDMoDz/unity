private var objCube:GameObject;
private var objSphere:GameObject;
private var isCubeRotate=false;
private var isSphereRotate=false;

private var CubeInfo:String="旋转立方体";
private var SphereInfo:String="旋转球体";

function Start()
{
	objCube=GameObject.Find("Cube");
	objSphere=GameObject.Find("Object/Sphere");
}

function Update()
{
	if(isCubeRotate)
	{
		if(objCube)
		{
			objCube.transform.Rotate(0.0f,Time.deltaTime*200,0.0f);
		}
	}
	if(isSphereRotate)
	{
		if(objSphere)
		{
		    objSphere.transform.Rotate(0.0f,Time.deltaTime*200,0.0f);
		}
	}
}

function OnGUI()
{
	if(GUILayout.Button(CubeInfo,GUILayout.Height(50)))
	{
		if(!isCubeRotate)
		{
			isCubeRotate=true;
			CubeInfo="停止旋转立方体";
		}
		else
		{
			isCubeRotate=false;
			CubeInfo="旋转立方体";
		}
	}
	if(GUILayout.Button(SphereInfo,GUILayout.Height(50)))
	{
		if(!isSphereRotate)
		{
			isSphereRotate=true;
			SphereInfo="停止旋转球体";
		}
		else
		{
			isSphereRotate=false;
			SphereInfo="旋转球体";
		}
	}
	if(GUILayout.Button("立即销毁模型",GUILayout.Height(50)))
	{
		Destroy(objCube);
		Destroy(objSphere);
	}
}