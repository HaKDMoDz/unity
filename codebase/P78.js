private var texSingle:Texture2D;
private var texAll:Object[];

function OnGUI()
{
	if(GUI.Button(Rect(0,10,100,50),"加载一张贴图"))
	{
		if (texSingle==null) 
		{
			texSingle=Resources.Load("single/0");
		}
	}
	if (GUI.Button(Rect(0,130,100,50),"加载一组贴图")) 
		{
			if (texAll==null) {
				texAll=Resources.LoadAll("Textures");
			}
		}
    if(texSingle!=null)
    {
    	GUI.DrawTexture(Rect(110,10,120,120),texSingle,ScaleMode.StretcToFill,true,0);
    }
    if (texAll!=null) 
    	{
    		for (var i = 0; i <texAll.length; i++)
    		{
    			GUI.DrawTexture(Rect(110+i*120,130,120,120),texAll[i],ScaleMode.StretcToFill,true,0);
    		}

        }
}