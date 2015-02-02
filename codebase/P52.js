var verticalValue:int=0;
var horizonalValue:float=0.0f;
function OnGUI()
{
    verticalValue=GUI.VerticalSlider(Rect(25,25,30,100),verticalValue,100,0);
    horizonalValue=GUI.HorizonalSlider(Rect(50,25,100,30),horizonalValue,0.0f,100.0f);
    GUI.Label(Rect(10,150,Screen.width,30),"纵向滑动条当前进度:"+verticalValue+"%");
    GUI.Label(Rect(10,180,Screen.width,30),"横向滑动条当前进度:"+horizonalValue+"%");
}
