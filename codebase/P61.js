var mySkin:GUISkin;
private var choose:boolean=false;

var windowRect:Rect=Rect(20,20,120,50);
var edit:String="请输入字符串";

function OnGUI()
{
	GUI.skin=mySkin;
	GUI.Button(Rect(100,100,100,100),"自定义按钮");
	choose=GUI.Toggle(Rect(10,50,100,30),choose,"单项选择");
	edit=GUI.TextField(Rect(200,10,200,20),edit,25);
	windowRect=GUI.Window(0,windowRect,setWindow,"这是一个窗口");
}

function setWindow(windowID:int)
{
	GUI.DragWindow();
	GUI.Button(Rect(10,20,100,30),"自定义按钮");
}