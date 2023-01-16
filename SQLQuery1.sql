create database Project2;
use Project2;

create table adminlogin
(A_ID int Primary key,a_Name varchar(20),adminUserName varchar(20),adminPassword varchar(20),adminTP int );
insert into adminlogin
values(001,'sanjaya','sanjaya','pass',0777887788);
select*from adminlogin;

create table customerServicelogin
(E_ID int Primary key,E_Name varchar(20),UserName varchar(20),EPassword varchar(20),TP int );
insert into customerServicelogin
values(001,'dasun','user','pass',0777888888);
select*from customerServicelogin;

create table StorekeeperElogin
(SE_ID int Primary key,SE_Name varchar(20),UserName varchar(20),SEPassword varchar(20),TP int );
insert into StorekeeperElogin
values(001,'nisal','nisal','pass',0777888888);
select*from StorekeeperElogin;
use Project;
select*from StorekeeperElogin;

create table addItem
(Invoice_no varchar(10)not null,ItemCode varchar(10) primary key ,Date_ date,Item_Name varchar(20) not null,Invater_Model varchar(10),Qty int not null);
insert into addItem
values('I001','0001','2022/06/18','Invater','12W',8);
select*from addItem;

create table cusRegister
(Cus_code varchar(10) primary key,Cus_Nic varchar(14)not null,First_Name varchar(20)not null,Last_Name varchar(20)not null,Address varchar(80)not null,Email varchar(80),Tp int not null,Bill_No varchar(10));


create table Income
(Sales_Qty int,Cost_Amount int,Income int,Profit int);

create table Packages
(System_Model varchar(10),Minimum_Generation varchar(10),InvaterModel varchar(80),No_Of_Panels int,Typical_area_required_For_Installation int);
/**/
use Project;
create table AddOder_tabel
(Package_Code varchar(10),Customer_ID varchar(10),Order_ID varchar(10)primary key,Location varchar(80),Status varchar(80));

create table DamageItem_table
(Invoice_no varchar(10),Item_Code varchar(10),Item_Name varchar(80));

create table PaymentDetails
(payment_No varchar(10)primary key,package_NO varchar(10),Customer_ID varchar(10),Date date,Status varchar(80),Amount int);

create table addUser
(UserName varchar(80),password varchar(80),Position varchar(20),UserID varchar(10),Name varchar(80),TP int);
use Project;
select*from addUser;
use Project;
create table DamageItems
(Invoice_No varchar(10),Item_Code varchar(10),Item_Name varchar(80),Damage_Date date);
use Project;
select*from AddOder_tabel;
use Project;
create table CompleteOrder
(Package_Code varchar(10),Customer_ID varchar(10),Order_ID varchar(10)primary key,Location varchar(80),Status varchar(80));
select*from  CompleteOrder;