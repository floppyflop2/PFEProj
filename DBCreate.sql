Drop table students

CREATE TABLE Students
(StudentId int NOT NULL IDENTITY(1,1),
StudentName varchar(255) NOT NULL,
StudentFirstname varchar(255) NOT NULL,
StudentDepartement varchar(255) NOT NULL,
StudentEmail varchar(255) NOT NULL,
CONSTRAINT PK_StudentId PRIMARY KEY NONCLUSTERED (StudentId),     
UNIQUE (StudentEmail))
