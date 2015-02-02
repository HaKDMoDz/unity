var scrollPosition:Vector2;
function Start()
{
    scrollPositon[0]=50;
    scrillPosition[1]=50;
}
function OnCUI()
{
    scrollPosition=GUI.BeginScrollView(Rect(0,0,200,200),scrollPosition,Rect(0,0,Screen.width,300),true,true);
    GUI.Label(Rect(100,40,Screen.width,30),"测试滚动试图,测试滚动试图，测试滚动视图，测试滚动视图");

    GUI.EndScrollView();
}
