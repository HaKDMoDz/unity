private var editUsername:String;
private var editPassword:String;
private var editShow:String;

function Start(){
	editShow="请您输入正确的用户名和密码";
	editUsername="请输入用户名";
	editPassword="请输入密码";
}
function OnGUI(){
	GUI.Label(Rect(10,10,Screen.width,30),editShow);
	if (GUI.Button(Rect(10,120,100,50),"登录")) {
         editShow="您输入的用户名为:"+editUsername+"您输入的密码为:"+editPassword;
	}
	GUI.Label(Rect(10,40,50,30),"用户名");
	GUI.Label(Rect(10,80,50,30),"密码");

	editUsername=GUI.TextField(Rect(60,40,200,30),editUsername,15);
	editPassword=GUI.PasswordField(Rect(60,80,200,30),editPassword,"*"[0],15);
}