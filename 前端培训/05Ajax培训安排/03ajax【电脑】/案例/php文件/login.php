<?php
	header('Content-Type:text/html;charset=utf-8');

	//模拟关联数组
	$users=array(
		'admin'=>123456,
		'test'=>654321,
		'demo'=>123321
	);

	//检测数组中无没有某个key，有返true无返回false
	//var_dump(array_key_exists('admin',$users))
	
	//接受用户的数据
	$username=$_POST['username'];//用户提交上来的用户名
	$pass=$_PSOT['pass'];//用户提交上来的密码

	//$users[$username];

	//var_dump(array_key_exists($username,$users))
	
	//是否存在某个用户
	$hasusername=array_key_exists($username,$users);

	//不但存在某个用户并且提交上来的密码要和数据库中一致
	if($hasusername&&$pass==$users[$username]){
		echo '登录成功';
		//跳转地址
		//header('location:http://www.baidu.com');
		//header('refresh:3;url=http://www.baidu.com');
	}else{
		echo '登录失败,请重试';
		//header('refresh:3;url=./login.html');
	}
?>