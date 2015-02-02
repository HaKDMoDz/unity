var texture:Texture2D;
function OnGUI()
{
	GUILayout.BeginHorizontal();
	GUILayout.Box("开始水平布局");
	GUILayout.Button("按钮");
	GUILayout.Label("文本框");
	GUILayout.TextField("输入框");
	GUILayout.Box(texture);
	GUILayout.EndHorizontal();

	GUILayout.BeginVertical();
	GUILayout.Box("开始垂直布局");
	GUILayout.Button("按钮");
	GUILayout.Label("文本框");
	GUILayout.TextField("输入框");
	GUILayout.Box(texture);
	GUILayout.EndVertical();
}