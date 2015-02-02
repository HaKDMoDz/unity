function OnGUI()
{
	GUILayout.BeginArea(Rect(0,0,Screen.width,Screen.height));

	GUILayout.BeginHorizontal();

	GUILayout.BeginVertical();
	GUILayout.Box("Text1");
	GUILayout.FlexibleSpace();
	GUILayout.Box("Text2");
	GUILayout.EndVertical();

	GUILayout.FlexibleSpace();

	GUILayout.BeginVertical();
	GUILayout.Box("Text3");
	GUILayout.FlexibleSpace();
	GUILayout.Box("Text4");
	GUILayout.EndVertical();

	GUILayout.EndHorizontal();

	GUILayout.EndArea();
}