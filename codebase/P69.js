function OnGUI()
{
	GUILayout.BeginArea(Rect(0,0,200,60));
	GUILayout.BeginHorizontal();
	GUILayout.BeginVertical();
	GUILayout.Box("Text1");

	GUILayout.Space(10);
	GUILayout.Box("Text2");
	GUILayout.EndVertical();
	GUILayout.Space(20);

	GUILayout.BeginVertical();
	GUILayout.Box("Text3");
	GUILayout.Space(10);
	GUILayout.Box("Text4");
	GUILayout.EndVertical();

	GUILayout.EndHorizontal();

	GUILayout.EndArea();
}