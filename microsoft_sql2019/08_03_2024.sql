CREATE TABLE OBCMS_USER_REG
(
SNO INT NOT NULL,
USER_ID INT primary KEY,
FIRST_NAME varchar(255) NOT NULL,
LAST_NAME varchar(255) NOT NULL, 
USER_NAME varchar(255) NOT NULL,
PASSWORD varchar(255) NOT null,
CONFIRM_PASSWORD varchar(255) NOT NULL,
EMAIL varchar(255) NOT NULL,
PHONE_NUMBER varchar(20) NOT NULL,
ACCOUNT_TYPE varchar(20) NOT NULL
);


SELECT * FROM OBCMS_USER_REG;

INSERT OBCMS_USER_REG
(SNO,
USER_ID ,
FIRST_NAME ,
LAST_NAME , 
USER_NAME,
PASSWORD ,
 CONFIRM_PASSWORD ,
 EMAIL ,
 PHONE_NUMBER ,
 ACCOUNT_TYPE
)values(1,1001,'AARIF','S','MA2023M-C01E4F0','PASSWORD@123','PASSWORD@123','AARIF01CAD@GMAIL.COM',9025171297,'FREE '),				
(2,1002,'ABDUL RAHMAN','A','TI2023M-C01E59F','PASSWORD@123','PASSWORD@123','ABDULRAHMANCAD01@GMAIL.COM',9042116396,'FREE '),				
(3,1003,'ABINAYA','J','TI2023M-C01E83A','PASSWORD@123','PASSWORD@123','AHAMEDCAD01@GMAIL.COM',9659021407,'FREE '),				
(4,1004,'AHAMED ','J ','PU2023M-C01E6A4','PASSWORD@123','PASSWORD@123','ALEXANDARACAD01@GMAIL.COM',9360415014,'FREE '),				
(5,1005,'ALEXANDAR','A','TI2023M-C01E71D','PASSWORD@123','PASSWORD@123','ANANDRAVICHANDRANCAD01@GMAIL.COM',8489903993,'FREE '),				
(6,1006,'ANAND','R','TI2023F-C01E717','PASSWORD@123','PASSWORD@123','ANJUKAPUGAZ02@GMAIL.COM',6379944693,'FREE '),				
(7,1007,'ANJUKA','P','TI2023M-C01EADE','PASSWORD@123','PASSWORD@123','ARAVIND2K23CAD01@GMAIL.COM',8778624466,'FREE '),				
(8,1008,'ARAVIND','K','VI2023M-C01E69B','PASSWORD@123','PASSWORD@123','BASHEERCAD01@GMAIL.COM',9514690405,'FREE '),				
(9,1009,'BASHEER AHAMED','M','KA2023M-C01EA67','PASSWORD@123','PASSWORD@123','CHANDRANCAD01@GMAIL.COM',9361313775,'FREE '),				
(10,1010,'CHANDRAN','P','TH2023M-C01E7F5','PASSWORD@123','PASSWORD@123','DANIELRAJCAD01@GMAIL.COM',9092838116,'FREE '),				
(11,1011,'DANIELRAJ','A','TI2023M-C01E574','PASSWORD@123','PASSWORD@123','TDINESHCAD01@GMAIL.COM',9629724889,'FREE '),				
(12,1012,'DINESH','T','TI2023M-C01E4DC','PASSWORD@123','PASSWORD@123','VASANTHCAD01@GMAIL.COM',6379301181,'FREE '),				
(13,1013,'DOMENIG VASANTHAN','A','KA2023M-C01EA68','PASSWORD@123','PASSWORD@123','GOPALCAD01@GMAIL.COM',9361448297,'FREE '),				
(14,1014,'GOPAL','S','TI2023M-C01EAF1','PASSWORD@123','PASSWORD@123','HARSHCAD01@GMAIL.COM',9025664587,'FREE '),				
(15,1015,'HARSH','A','TI2023M-C01EA6D','PASSWORD@123','PASSWORD@123','JAYAPRAVINCAD01@GMAIL.COM',7094937902,'FREE '),				
(16,1016,'JAYAPRAVIN','D','TI2023F-C01E4E0','PASSWORD@123','PASSWORD@123','KIRUTHIGARCAD01@GMAIL.COM',7339220870,'FREE '),				
(17,1017,'JEMIMAH','J','TI2023F-C01E4EF','PASSWORD@123','PASSWORD@123','MOHANACAD01@GMAIL.COM',9994987424,'FREE'),				
(18,1018,'MANIMOHANA','S','PU2023F-C01E84A','PASSWORD@123','PASSWORD@123','NANCYACAD01@GMAIL.COM',8428267221,'FREE '),				
(19,1019,'KIRUTHIGA','R','TI2023M-C01E78F','PASSWORD@123','PASSWORD@123','NATRAYANCAD01@GMAIL.COM',8825684098,'FREE '),				
(20,1020,'NANCY','A','TI2023F-C01E4F5','PASSWORD@123','PASSWORD@123','PAVITHRACAD01@GMAIL.COM',9025862493,'FREE '),				
(21,1021,'NATRAYAN','M','TI2023M-C01E4EE','PASSWORD@123','PASSWORD@123','PRABHAHARNCAD01@GMAIL.COM',9043792705,'FREE '),				
(22,1022,'PAVITHRA','K','TI2023M-C01E5CF','PASSWORD@123','PASSWORD@123','RAMKISRIDHARCAD01@GMAIL.COM',6383693933,'FREE '),				
(23,1023,'PRABHAHARN','M','TI2023M-C01E4ED','PASSWORD@123','PASSWORD@123','SAHITHCAD01@GMAIL.COM',9042314497,'FREE '),				
(24,1024,'RAMKI','S','PE2023M-C01E4F3','PASSWORD@123','PASSWORD@123','JERRYCAD01@GMAIL.COM',9514605031,'FREE '),				
(25,1025,'SAHITH AFRIDI SABIBULLA','S','TI2023M-C01E4F6','PASSWORD@123','PASSWORD@123','SANJAYRBCAD01@GMAIL.COM',7708407173,'FREE '),				
(26,1026,'SAKTHIVEL','S','TI2023M-C01E84E','PASSWORD@123','PASSWORD@123','SANTHOSHCAD01@GMAIL.COM',9344560546,'FREE '),				
(27,1027,'SANJAY BALAKRISHNAN','B','TI2023F-C01EACF','PASSWORD@123','PASSWORD@123','ABINAYAKUMARCAD01@GMAIL.COM',8124568273,'FREE '),				
(28,1028,'SANTHOSH KUMAR','S','PE2023M-C01F0DC','PASSWORD@123','PASSWORD@123','SIRANJEEVICAD01@GMAIL.COM',6383685553,'FREE '),				
(29,1029,'SARAN','S','CU2023M-C01F0DE','PASSWORD@123','PASSWORD@123','SARANCAD01@GMAIL.COM',6380026784,'FREE '),				
(30,1030,'SIRANJEEVI','S','TI2023F-C01E85C','PASSWORD@123','PASSWORD@123','JEMIMAHCAD01@GMAIL.COM',9489189043,'FREE ');


CREATE TABLE OBCMS_USER_LOGIN(
USER_ID int NOT NULL,
USER_NAME varchar(255) NOT NULL,
PASSWORD varchar(255) NOT null,
OLD_PASSWORD varchar(255),
UPDATE_PASSWORD varchar(255)
);

SELECT * FROM OBCMS_USER_LOGIN;

drop table OBCMS_USER_LOGIN;

INSERT INTO  OBCMS_USER_LOGIN(USER_ID,
USER_NAME,
PASSWORD
)values(1001,'MA2023M-C01E4F0','PASSWORD@123'),
(1002,'TI2023M-C01E59F','PASSWORD@123'),
(1003,'TI2023M-C01E83A','PASSWORD@123'),
(1004,'PU2023M-C01E6A4','PASSWORD@123'),     
(1005,'TI2023M-C01E71D','PASSWORD@123'),
(1006,'TI2023F-C01E717','PASSWORD@123'),
(1007,'TI2023M-C01EADE','PASSWORD@123'),
(1008,'VI2023M-C01E69B','PASSWORD@123'),
(1009,'KA2023M-C01EA67','PASSWORD@123'),
(1010,'TH2023M-C01E7F5','PASSWORD@123'),
(1011,'TI2023M-C01E574','PASSWORD@123'),
(1012,'TI2023M-C01E4DC','PASSWORD@123'),
(1013,'KA2023M-C01EA68','PASSWORD@123'),
(1014,'TI2023M-C01EAF1','PASSWORD@123'),
(1015,'TI2023M-C01EA6D','PASSWORD@123'),
(1016,'TI2023F-C01E4E0','PASSWORD@123'),
(1017,'TI2023F-C01E4EF','PASSWORD@123'),
(1018,'PU2023F-C01E84A','PASSWORD@123'),
(1019,'TI2023M-C01E78F','PASSWORD@123'),
(1020,'TI2023F-C01E4F5','PASSWORD@123'),
(1021,'TI2023M-C01E4EE','PASSWORD@123'),
(1022,'TI2023M-C01E5CF','PASSWORD@123'),
(1023,'TI2023M-C01E4ED','PASSWORD@123'),
(1024,'PE2023M-C01E4F3','PASSWORD@123'),
(1025,'TI2023M-C01E4F6','PASSWORD@123'),
(1026,'TI2023M-C01E84E','PASSWORD@123'),
(1027,'TI2023F-C01EACF','PASSWORD@123'),
(1028,'PE2023M-C01F0DC','PASSWORD@123'),
(1029,'CU2023M-C01F0DE','PASSWORD@123'),
(1030,'TI2023F-C01E85C','PASSWORD@123');


CREATE TABLE OBCMS_USERS_LOGIN(
USER_NAME varchar(255) NOT NULL,
PASSWORD varchar(255) NOT null,
jobrole varchar(255)
);

INSERT INTO  OBCMS_USERS_LOGIN(
USER_NAME,
PASSWORD,
jobrole
)values('Branchhead','branchhead@123','branchhead'),
('Admin','admin@123','admin');


drop table OBCMS_USERS_LOGIN;