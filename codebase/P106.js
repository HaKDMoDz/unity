var obj:GameObject;

function Start()
{
	obj=GameObject.Find("Sphere");
}

function OnGUI()
{
	if(GUILayout.Button("开始克隆实例",GUILayout.Height(50)))
	{
		var clone:GameObject=Instantiate(obj,obj.transform.position,obj.transform.rotation);
        Destroy(clone,5);
	}
}