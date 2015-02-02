var str:String;
var imageTexture:Texture;
private var imageWidth:int;
private var imageHeight:int;
private var screenWidth:int;
private var screenHeight:int;


function Start () {
screenWidth=Screen.width;
screenHeight=Screen.height;

imageWidth=imageTexture.width;
imageHeight=imageTexture.height;
}

function onGUI(){
   GUI.Label(Rect(100,10,100,30),str);
   GUI.Label(Rect(100,40,100,30),"当前屏幕宽:"+screenWidth);
   GUI.Label(Rect(100,80,100,30),"当前屏幕高:"+screenHeight);
   GUI.Label(Rect(100,120,imageWidth,imageHeight),imageTexture);
}