private var window0:Rect=Rect(20,20,200,200);
private var window1:Rect=Rect(250,20,200,200);

function OnGUI()
{
	//在这里注册两个窗口
	GUI.Window(0,window0,oneWindow,"第一个窗口");
	GUI.Window(1,window1,twoWindow,"第二个窗口");
}

function oneWindow(windowID:int)
{
	GUI.Box(Rect(10,50,150,50),"这里窗口ID是"+windowID);
	if(GUI.Button(Rect(10,120,150,50),"普通按钮"))
	{
		Debug.Log("窗口ID="+windowID+"按钮被点击");
	}
}

function twoWindow(windowID:int)
{
	GUI.Box(Rect(10,50,150,50),"这里窗口ID是"+windowID);
	if (GUI.Button(Rect(10,120,150,50),"普通按钮")) 
	{
         Debug.Log("窗口ID="+windowID+"按钮被点击");
	}
}
