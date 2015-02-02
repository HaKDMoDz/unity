var winArrayList=new ArrayList();
var icon:Texture;
function Start()
{
	winArrayList.Add(Rect(winArrayList.Count*100,50,150,100));

}
function OnGUI()
{
	var count=winArrayList.Count;
	for(var i=0;i<count;i++)
	{
		winArrayList[i]=GUILayout.Window(i,winArrayList[i],AddWindow,"窗口ID"+i);
	}
}
function AddWindow(windowID:int)
{
	GUILayout.BeginHorizontal();
	GUILayout.Label(icon,GUILayout.Width(50),GUILayout.Height(50));
	GUILayout.Label("这是一个全新的窗口");
	GUILayout.EndHorizontal();

	GUILayout.BeginHorizontal();
	if(GUILayout.Button("添加新的窗口"));
	{
		winArrayList.Add(Rect(winArrayList.Count*100,50,150,100));
	}
	if(GUILayout.Button("关闭当前的窗口"));
	{
		winArrayList.RemoveAt(windowID);
	}
	GUILayout.EndHorizontal();

	GUI.DragWindow(Rect(0,0,Screen.width,Screen.height));
}