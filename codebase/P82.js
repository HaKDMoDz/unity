private var animUp:Object[];
private var animDown:Object[];
private var animLeft:Object[];
private var animRight:Object[];
//地图贴图
private var map:Texture2D;
//当前任务动画
private var tex:Object[];
private var x:int;
private var y:int;

private var nowFram:int;
private var mFrameCount:int;

private var fps:float=10;
private var time:float=0;

function Start()
{
	animUP=Resources.LoadAll("up");
	ainmDown=Resources.LoadAll("down");
	animRight=Resources.LoadAll("right");
	animLeft=Resources.LoadAll("left");

	map=Resources.Load("map/map");
	tex=animUp;
}
function OnGUI()
{
	GUI.DrawTexture(Rect(0,0,Screen.width,Screen.height),map,ScaleMode.StretchToFill,true,0);

	DrawAnimation(tex,Rect(x,y,32,48));
	if(GUILayout.RepeatButton("向上"))
	{
		y-=2;
		tex=animUp;
	}
	if(GUILayout.RepeatButton("向下"))
	{
		y+=2;
		tex=animDown;
	}
	if(GUILayout.RepeatButton("向左"))
	{
		x-=2;
		tex=animLeft;
	}
	if(GUILayout.RepeatButton("向右"))
	{
		x+=2;
		tex=animRight;
	}

}

function DrawAnimation(tex:Object[],rect:Rect)
{
	GUI.DrawTexture(rect,tex[nowFram],ScaleMode.StretchToFill,true,0);

	time+=Time.deltaTime;
	if(time>1.0/fps)
	{
		nowFram++;
		time=0;
		if(nowFram>=tex.Length)
			nowFram=0;
	}
}