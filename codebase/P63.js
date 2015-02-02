var mySkin:GUISkin;

function OnGUI()
{
	GUI.skin=mySkin;
	GUI.Button(Rect(0,100,300,100),"abc","Custom0");
	GUI.Button(Rect(300,100,300,100),"","Custom1");
}