function OnGUI()
{
	GUILayout.Button("设置布局按钮宽度为300,高度为30",GUILayout.Width(300),GUILayout.Height(30));
	GUILayout.Button("设置布局按钮宽度为100，高度为20",GUILayout.MinWidth(100),GUILayout.MinHeight(20));
	GUILayout.Button("设置布局按钮宽度为400，高度为40",GUILayout.MaxWidth(400),GUILayout.MaxHeight(40));

	GUILayout.Button("设置宽度不等于最宽按钮",GUILayout.ExpandWidth(false));
	GUILayout.Button("设置宽度等于最宽按钮",GUILayout.ExpandWidth(true));
}