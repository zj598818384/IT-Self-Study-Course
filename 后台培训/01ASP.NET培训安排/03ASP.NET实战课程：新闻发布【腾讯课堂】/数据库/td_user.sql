use db_news

--创建数据表--
create table td_user
(
	Userid int primary key identity(1,1),--用户编号
	UserName nvarchar(50),--用户名称
	PassWord nvarchar(50),--用户密码
	Email nvarchar(50),--电子邮箱
	Role nvarchar(50)--权限角色(1 管理员(所有权限) 2 普通成员(只能查询))
)
drop table td_user