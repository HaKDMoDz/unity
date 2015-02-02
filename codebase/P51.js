private var select:int;
private var barResource:String[];

private var selectToggle0:boolean;
private var selectToggle1:boolean;

function Start()
{
    select=0;
    barResource=["第一个工具栏","第二个工具栏","第三个工具栏","第四个工具栏"];

    selectToggle0=false;
    selectToggle1=false;
}
function OnGUI()
{
    var oldSelect=select;
    select=GUI.Toolbar(Rect(10,10,barResource.length*100,30),select,barResoure);
    if(oldSelect!=select)
    {
        selectToggle0=false;
        selectToggle1=false;
    }
    switch(select)
    {
        case 0:
            selectToggle0=GUI.Toggle(Rect(10,50,150,30),selectToggle0,"第一个工具栏单项选择--1");
            selectToggle1=GUI.Toggle(Rect(10,80,150,30),selectToggle1,"第一个工具栏单项选择--2");
            break;
        case 1:
            selectToggle0=GUI.Toggle(Rect(10,50,150,30),selectToggle0,"第二个工具栏单项选择--1");
            selectToggle1=GUI.Toggle(Rect(10,80,150,30),selectToggle1,"第二个工具栏单项选择--2");
            break;
        case 2:
            selectToggle0=GUI.Toggle(Rect(10,50,150,30),selectToggle0,"第三个工具栏单项选择--1");
            selectToggle1=GUI.Toggle(Rect(10,80,150,30),selectToggle1,"第三个工具栏单项选择--2");
            break;
        case 3:
            selectToggle0=GUI.Toggle(Rect(10,50,150,30),selectToggle0,"第四个工具栏单项选择--1");
            selectToggle1=GUI.Toggle(Rect(10,80,150,30),selectToggle1,"第四个工具栏单项选择--2");
            break;
    }
}
