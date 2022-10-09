create database MNST
use MNST
create table STUDENT(
Student_ID nvarchar(20) not null ,
FullName nvarchar(100)not null,
Gender nvarchar(6)not null,
Addresss nvarchar(100)not null,
AvgScore FLOAT not null,
Faculty_ID int not null,
PRIMARY KEY (Student_ID),
FOREIGN KEY (Faculty_ID) references FACULTY(Faculty_ID)
)

create table FACULTY(
Faculty_ID int,
FacultyName nvarchar(100),
PRIMARY KEY(Faculty_ID),
)
ALTER TABLE STUDENT
ADD CONSTRAINT FK_STUDENT_Faculty_ID
FOREIGN KEY (Faculty_ID)
REFERENCES FACULTY (Faculty_ID)



INSERT INTO FACULTY(Faculty_ID,FacultyName)
VALUES (1,N'Công Nghệ Thông Tin')
INSERT INTO FACULTY(Faculty_ID,FacultyName)
VALUES (2,N'Ngôn Ngữ Anh')
INSERT INTO FACULTY(Faculty_ID,FacultyName)
VALUES (3,N'Quản Trị Kinh Doanh')
INSERT INTO FACULTY(Faculty_ID,FacultyName)
VALUES (4,N'Công Nghệ Oto')
INSERT INTO FACULTY(Faculty_ID,FacultyName)
VALUES (5,N'Marketing')

INSERT INTO STUDENT(Student_ID,FullName,Gender,Addresss,AvgScore,Faculty_ID)
VALUES (2011064226,N'Phạm Anh Hào',N'Nam',N'Cần Thơ',8.5,1)
INSERT INTO STUDENT(Student_ID,FullName,Gender,Addresss,AvgScore,Faculty_ID)
VALUES (2011064265,N'Lê Huỳnh Duy Khải',N'Nam',N'Vĩnh Long',6.5,1)
INSERT INTO STUDENT(Student_ID,FullName,Gender,Addresss,AvgScore,Faculty_ID)
VALUES (2011064114,N'Đoàn Thị Huyền Trân',N'Nữ',N'Long An',9,2)
INSERT INTO STUDENT(Student_ID,FullName,Gender,Addresss,AvgScore,Faculty_ID)
VALUES (2011065678,N'Đoàn Phúc Kỳ Anh',N'Nữ',N'Hậu Giang',7,3)

sp_help 'dbo.FACULTY'