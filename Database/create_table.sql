
use rhdbs;

#用户
DROP TABLE IF EXISTS rhdbs.user_info;
create table rhdbs.user_info (
	user_id varchar(30)	DEFAULT ' ' NOT NULL,
	pwd varchar(30)		DEFAULT ' ' NOT NULL,
	role tinyint(2)		DEFAULT 0 NOT NULL,
	note varchar(255)	DEFAULT ' ' NOT NULL,
        menu_set varchar(800)	DEFAULT ' ' NOT NULL,
PRIMARY KEY(user_id)
);

#客户信息
DROP TABLE IF EXISTS rhdbs.cust_info;
CREATE TABLE rhdbs.cust_info (
	cust_id			INT(10)			NOT NULL AUTO_INCREMENT,
	cust_name		VARCHAR(20)		NOT NULL DEFAULT ' ',
	sex			CHAR(10)		NOT NULL DEFAULT ' ',
	birthday		DATE			NOT NULL,
	hometown		VARCHAR(40)		NOT NULL DEFAULT ' ',
	id_card			VARCHAR(20)		NOT NULL DEFAULT ' ',
	address			VARCHAR(250)		NOT NULL DEFAULT ' ',
	company			VARCHAR(40)		NOT NULL DEFAULT ' ',
	phone			VARCHAR(20)		NOT NULL DEFAULT ' ',
	mobile			VARCHAR(20)		NOT NULL DEFAULT ' ',
	email			VARCHAR(200)		NOT NULL DEFAULT ' ',
	qq			VARCHAR(20)		NOT NULL DEFAULT ' ',
	source			VARCHAR(100)		NOT NULL DEFAULT ' ',
	level			CHAR(10)		NOT NULL DEFAULT ' ',
	ask_flag		CHAR(10)		NOT NULL DEFAULT ' ',
	ask_time		TIMESTAMP		NOT NULL DEFAULT NOW(),
	deal_flag		CHAR(10)		NOT NULL DEFAULT ' ',
	note			VARCHAR(512)		NOT NULL DEFAULT ' ',
	remind_flag		CHAR(10)		NOT NULL DEFAULT ' ',
	remind_time		TIMESTAMP		NOT NULL DEFAULT NOW(),
	xczx			VARCHAR(512)		NOT NULL DEFAULT ' ',
	dhzx			VARCHAR(512)		NOT NULL DEFAULT ' ',
	tbtx			VARCHAR(512)		NOT NULL DEFAULT ' ',
	cjjl			VARCHAR(512)		NOT NULL DEFAULT ' ',
	set_time		TIMESTAMP		NOT NULL DEFAULT NOW(),
PRIMARY KEY(cust_id)
);

#客户照片
DROP TABLE IF EXISTS rhdbs.cust_photo;
CREATE TABLE rhdbs.cust_photo (
	photo_id		INT(10)      	NOT NULL AUTO_INCREMENT,
	cust_id			INT(10)		NOT NULL,
	photo			MEDIUMBLOB	NOT NULL,
PRIMARY KEY(photo_id)
);

