function Start()
{
	var objs=GameObject.FindGameObjectsWithTag("MyTag");
	objs[5].tag="TestTag";

	for(var obj in objs)
	{
		Debug.Log("以"+obj.tag+"标签为游戏对象的名称"+obj.name);
		if(obj.tag=="TestTag")
		{
			Debug.Log("这个标签为TestTag");
		}
		if(obj.CompareTag("TestTag"))
		{
			Debug.Log("obj这个对象附带的标签为TestTag");
		}
	}
}