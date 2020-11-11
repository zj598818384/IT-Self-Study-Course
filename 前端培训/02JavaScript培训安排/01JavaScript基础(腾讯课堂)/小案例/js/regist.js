//书写需要对页面进行验证的js代码
window.onload=function(){
	//给页面上的用户名的input绑定两个事件
	var usernameInput=document.getElementById('username');

	//绑定获取焦点事件
	usernameInput.onfocus=function(){
		if(usernameInput.value=="请输入用户名"){
			usernameInput.value="";
		}
	}

	//失去焦点的事件
	usernameInput.onblur=function(){
		//在失去焦点之后，判断其中的用户名的数据是否正确
		checkUsername();//调用函数
	}

	//给密码框绑定失去焦点事件
	document.getElementById('pwd').onblur=function(){
		passWord();
	}

	//给确认密码绑定事件
	document.getElementById('repwd').onblur=function(){
		checkRePwd();
	}


}

//定义验证用户名的函数
function checkUsername(){
	//给页面上的用户名的input绑定两个事件
	var usernameInput=document.getElementById('username');
	var sname=document.getElementById('sname');
	if(/^\w{6,12}$/.test(usernameInput.value)){
		sname.innerHTML="<font color='green' size='1'>用户名正确</font>";
		return true;
	}
	else{
		sname.innerHTML="<font color='red' size='1'>用户名必须在6~12位</font>";
		return false;
	}
}

//定义密码的函数
function passWord(){
	var pwd=document.getElementById('pwd');
	var mima=document.getElementById('mima');
	if(/^\w{6}$/.test(pwd.value)){
		mima.innerHTML="<font color='green' size='1'>密码正确</font>";
		return true;
	}
	else{
		mima.innerHTML="<font color='red' size='1'>密码必须是6位</font>";
		return false;
	}
}

//验证确认密码
function checkRePwd(){
	//获取第一次输入的密码
	var pwd=document.getElementById('pwd').value;
	//获取第二次输入的密码
	var repwd=document.getElementById('repwd').value;
	var mima1=document.getElementById('mima1');
	//判断两次密码是否一致
	if(pwd==repwd){
		mima1.innerHTML="<font color='green' size='1'>密码正确</font>";
		return true;
	}
	else{
		mima1.innerHTML="<font color='red' size='1'>两次密码不一致</font>";
		return false;
	}
	
}

//验证性别是否选择
function checkRadio(){
	//获取页面上所有的单选按钮
	var sexs=document.getElementsByName('sex');
	//获取到设置性别提示的span
	var ssex=document.getElementById('ssex');
	//遍历所有的单选按钮
	for(var i=0;i<sexs.length;i++){
		if(sexs[i].checked){
			//因为是单选按钮，所以肯定有一个被选中其他的就不可能备选中了，这个循环就可以结束了
			ssex.innerHTML="<font color='green' size='1'>性别已选</font>";
			return true;
		}
	}
	ssex.innerHTML="<font color='red' size='1'>请选择您的性别</font>";
	return false;
}

// 针对注册页面，到底在点击提交按钮的时候，能不能直接将form表单中的数据提交给服务器
// 需要先对页面上的数据进行验证，只有全部验证通过之后才能将form中的数据提交给服务器
// 只要有任何一项验证没有通过，这个提交都不能执行。
// 
// 在form标签上有一个事件，onsubmit事件，就是针对提交表单而存在的事件


function checkForm(){
	if(checkUsername()&&passWord()&&checkRePwd()&&checkRadio()){
		return true;
	}
	return false;
}

//在js中提交表单的有多种方式：
//常用的是在表单中书写：<button value="注册" style="margin-left:90px" type="submit">注册</button>
//将表单中的数据提交form标签中action指定的服务器。

//也可以通过js动态的将表单的数据提交给服务器：
//可以在页面上任何的地方书写一个按钮，超链接等都可以，然后给这个标签绑定单击的事件，
//在事件中获取表单对象，然后调用表单自身的submit方法提交表单

function _submit(){
	//获取表单对象
	if(checkForm()){
		document.getElementById('userForm').submit();
	}
}