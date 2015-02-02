var obj:GameObject;

function Start()
{
	obj=GameObject.Find("Cube");
}
function Update()
{
}
function OnGUI()
{
    if(GUILayout.Button("向前移动",GUILayout.Height(50)))
    {
    	obj.transform.Translate(Vector3.forward*Time.deltaTime);
    }
    if(GUILayout.Button("向后移动",GUILayout.Height(50)))
    {
        obj.transform.Translate(-Vector3.fwd*Time.deltaTime);
    }
    if(GUILayout.Button("向左移动",GUILayout.Height(50)))
    {
    	obj.transform.Translate(Vector3.left*Time.deltaTime);
    }
    if(GUILayout.Button("向右移动",GUILayout.Height(50)))
    {
    	obj.transform.Translate(Vector3.right*Time.deltaTime);
    }
    GUILayout.Label("立方体的位置: "+obj.transform.position);
}