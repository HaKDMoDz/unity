var buttonTexture:Texture2D;
private var str:String;

private var frameTime:int;

function Start() {
	//初始化赋值
	str="请您点击按钮";
}
function OnGUI()
{
	GUI.Label(Rect(10,10,Screen.width,30),str);
	if (GUI.Button(Rect(10,50,buttonTexture.width,buttonTexture.height),buttonTexture)) {
		str="您点击了按钮图片";
	}
	GUI.color=Color.green;
	GUI.backgroundColor=Color.red;
	if (GUI.Button(Rect(10,200,70,30),"文字按钮")) {
		str="您点击了文字按钮";
	}
	GUI.color=Color.yellow;
	GUI.backgroundColor=Color.black;
	if (GUI.RepeatButton(Rect(10,250,100,30),"按钮按下中")) {
		str="按钮按下中的时间:"+frameTime;
		frameTime++;
	}
}