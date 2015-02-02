//动画数组
private var anim:Object[];
//帧序列
private var nowFram:int;
//动画数帧的总数
private var mFrameCount:int;

private var fps:float=15;
private var time:float=0;

function Start()
{
	anim=Resources.LoadAll("animation");
	mFrameCount=anim.Length;
}

function OnGUI()
{
	DrawAnimation(anim,Rect(100,100,32,48));
}

function DrawAnimation(tex:Object[],rect:Rect)
{
	GUILayout.Label("当前动画播放: 第"+nowFram+"帧");
	GUI.DrawTexture(rect,tex[nowFram],ScaleMode.StretchToFill,true,0);

	time+=Time.deltaTime;

	if(time>=1.0/fps)
	{
		nowFram++;
		time=0;
		if(nowFram>=mFrameCount)
		{
			nowFram=0;
		}
	}
}