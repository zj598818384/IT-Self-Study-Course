use db_news

--�������ݱ�--
create table td_user
(
	Userid int primary key identity(1,1),--�û����
	UserName nvarchar(50),--�û�����
	PassWord nvarchar(50),--�û�����
	Email nvarchar(50),--��������
	Role nvarchar(50)--Ȩ�޽�ɫ(1 ����Ա(����Ȩ��) 2 ��ͨ��Ա(ֻ�ܲ�ѯ))
)
drop table td_user