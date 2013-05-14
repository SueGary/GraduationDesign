create table TJ_TTDJB
(
ID	Int     IDENTITY(1,1)  primary key not null,
TTBM	NVARCHAR(10) not null,
TTMC	text not null,
DZ	text,
TTXZID	int not null,
LXDH	NVARCHAR(20) not null,
YDDH	NVARCHAR(20),
LXR	NVARCHAR(20) not null,
FRDB	NVARCHAR(20) not null,
DZYX	NVARCHAR(30) ,
DJRQ	Datetime not null,
JZRQ	Datetime not null,
)