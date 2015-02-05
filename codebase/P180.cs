using UnityEngine;
using System.Collections;

public class NewBehaviourScript:MonoBehaviour
{
	private CharacterController controller=null;
	private float moveSpeed=3.0f;
	private float rotateSpeed=3.0f;
	private GameObject colliderObj=null;
	
	void Start()
	{
		controller=GetComponent<CharacterController>();
		
	}
	void OnGUI()
	{
				if (GUILayout.RepeatButton ("向左旋转")) {
						transform.Rotate (0, -rotateSpeed, 0);
				}
				if (GUILayout.RepeatButton ("向右旋转")) {
						transform.Rotate (0, rotateSpeed, 0);
				}
				if (GUILayout.RepeatButton ("向前移动")) {
						Vector3 forward = transform.TransformDirection (Vector3.forward);
						controller.Move (forward * moveSpeed);
				}
				if (GUILayout.RepeatButton ("向后移动")) {
						Vector3 forward = transform.TransformDirection (Vector3.forward);
						controller.Move (forward * -moveSpeed);
				}
				if (GUILayout.RepeatButton ("起飞")) {
						transform.Translate (0, 1, 0);
				}
				if (GUILayout.RepeatButton ("降落")) {
						transform.Translate (0, -1, 0);
				}
				//降落中
				if (controller.collisionFlags == CollisionFlags.Sides) {
						if (colliderObj != null) {
								GUI.color = Color.black;
								GUI.Label (new Rect (200, 100, 200, 100), "碰撞的游戏对象为:" + colliderObj.name);
						}
				}
		}
		void OnControllerColliderHit(ControllerColliderHit hit)
		{
			colliderObj=hit.gameObject;
		}
}










