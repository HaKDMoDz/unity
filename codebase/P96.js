function OnGUI()
{
	if(GUILayout.Button("创建立方体",GUILayout.Height(50)))
	{
		var objCube=GameObject.CreatePrimitive(PrimitiveType.Cube);
		objCube.AddComponent(Rigidbody);
		objCube.name="Cube";
		objCube.renderer.material.color=Color.blue;
		objCube.transform.position=new Vector3(0.0f,10.0f,0.0f);

	}
	if(GUILayout.Button("创建球体",GUILayout.Height(50)))
	{
		var objSphere=GameObject.CreatePrimitive(PrimitiveType.Sphere);
		objSphere.AddComponent(Rigidbody);
		objSphere.name="Sphere";
		objSphere.renderer.material.color=Color.red;
		objSphere.transform.position=new Vector3(0.0f,10.0f,0.0f);
	}
}