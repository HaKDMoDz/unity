using UnityEditor;
using UnityEngine;
class NewBehaviourScript:MonoBehaviour
{
	[MenuItem("新的菜单栏/克隆选择的对象")]
	static void ClothObject()
	{
		Instantiate(Selection.activeTransform,Vector3.zero,Quaternion.identity);
	}
	[MenuItem("新的菜单栏/克隆选择的对象",true)]
	static bool NoClothObject()
	{
		return Selection.activeGameObject!=null;
	}
	[MenuItem("新的菜单栏/删除选择的对象")]
	static void RemoveObject()
	{
		DestroyImmediate(Selection.activeGameObject,true);
	}
	[MenuItem("新的菜单栏/删除选择的对象",true)]
	static bool NoRemoveObject()
	{
		return Selection.activeGameObject!=null;
	}
}