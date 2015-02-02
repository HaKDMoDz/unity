private var Camera0:GameObject;
private var Camera1:GameObject;
private var Camera2:GameObject;

functoin Start()
{
	Camera0=GameObject.Find("Camera0");
	Camera1=GameObject.Find("Camera1");
	Camera2=GameObject.Find("Camera2");

}

function OnGUI()
{
	if(GUILayout.Button("投射侧面",GUILayout.Height(50)))
	{
		Camera1.active=false;
		Camera2.active=false;
		Camera0.active=true;
	}
	if(GUILayout.Button("投射正面",GUILayout.Height(50)))
	{
		Camera0.active=false;
		Camera2.active=false;
		Camera1.active=true;
	}
	if(GUILayout.Button("投射上面",GUILayout.Height(50)))
	{
		Camera0.active=false;
		Camera1.active=false;
		Camera2=true;
	}
}