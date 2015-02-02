private var obj:GameObject;
private var render:Renderer;
public var texture:Texture;

function Start()
{
	obj=GameObject.Find("Cube");
	obj.AddComponent("Test");
	render=obj.GetComponent("Renderer");
}

function OnGUI()
{
	if(GUILayout.Button("添加颜色",GUILayout.Width(100),GUILayout.Height(50)))
	{
		render.material.color=Color.green;
	}
	if(GUILayout.Button("添加贴图",GUILayout.Width(100),GUILayout.Height(50)))
	{
		render.material=null;
		render.material.mainTexture=texture;
	}
}
function Update()
{
	
}