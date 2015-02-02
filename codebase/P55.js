var viewTexture0:Texture2D;
var viewTexture1:Texture2D;

function OnGUI()
{
	GUI.BeginGroup(new Rect(10,50,200,400));
	GUI.DrawTexture(Rect(10,20,viewTexture0.width,viewTexture0.height),viewTexture0);

	GUI.Label(Rect(10,150,100,40),"群组视图1");
	GUI.Button(Rect(10,190,100,40),"按钮");
	GUI.EndGroup();

	GUI.BeginGroup(new Rect(300,0,500,400));
	GUI.DrawTexture(Rect(10,20,viewTexture1.width,viewTexture1.height),viewTexture1);

	GUI.Label(Rect(10,150,100,40),"群组视图2");
	GUI.Button(Rect(10,190,100,40),"按钮");
	GUI.EndGroup();
    
}