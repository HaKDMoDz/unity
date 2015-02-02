var addStr:String ="添加测试字符串";

function OnGUI()
{
	if(GUI.Button(Rect(50,50,100,30),addStr))
	{
		addStr+=addStr;
	}
	if(GUILayout.Button(addStr))
	{
		addStr+=addStr;
	}
}
