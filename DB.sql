create database CourseSheduleManagement;

use CourseSheduleManagement;

create table Course(CourseId int Identity(1,1) NOT NULL,
      CourseName varchar(75) NOT NULL,
      CourseCode varchar(25) NOT NULL,
      Description varchar(max) NULL,
      Active bit NOT NULL,
	  Constraint [PK_Course] Primary Key Clustered ([CourseId] ASC));

create table Hall(HallId int Identity(1,1) NOT NULL,
      HallName varchar(75) NOT NULL,
	  Active bit NOT NULL,
	  Constraint [PK_Hall] Primary Key Clustered ([HallId] ASC));

create table Batch(BatchId int Identity(1,1) NOT NULL,
	  Year int NOT NULL,
	  CourseId int NOT NULL,
      BatchCode varchar(25) NOT NULL,
	  Active bit NOT NULL,
	  Constraint [PK_Batch] Primary Key Clustered ([BatchId] ASC),
	  Constraint [FK_Batch_Course] Foreign Key ([CourseId]) References [dbo].[Course] ([CourseId]));

create table Student(StudentId int Identity(1,1) NOT NULL,
      FirstName varchar(30) NOT NULL,
      LastName varchar(30) NOT NULL,
      Line1 varchar(70) NOT NULL,
      Line2 varchar(70) NULL,
      DoB datetime NOT NULL,
      Sex varchar(5) NOT NULL,
      NIC varchar(20) NOT NULL,
      Email varchar(70) NOT NULL,
	  Password varchar(70) NOT NULL,
	  CourseId int NOT NULL,
	  BatchId int NOT NULL,
	  Active bit NOT NULL,
	  Constraint [PK_Student] Primary Key Clustered ([StudentId] ASC),
	  Constraint [FK_Student_Course] Foreign Key ([CourseId]) References [dbo].[Course] ([CourseId]),
	  Constraint [FK_Student_Batch] Foreign Key ([BatchId]) References [dbo].[Batch] ([BatchId]));

create table StudentMobileNumber(StudentId int NOT NULL,
      MobileNumber int NOT NULL,
	  Constraint [FK_Student] Foreign Key ([StudentId]) References [dbo].[Student] ([StudentId]));

create table Module(ModuleId int Identity(1,1) NOT NULL,
	  ModuleName varchar(75)  NOT NULL,
	  Description varchar(max) NULL,
	  CourseId int NOT NULL,
	  Active bit NOT NULL,
	  Constraint [PK_Module] Primary Key Clustered ([ModuleId] ASC),
	  Constraint [FK_Module_Course] Foreign Key ([CourseId]) References [dbo].[Course] ([CourseId]));

create table Staff(StaffId int Identity(1,1) NOT NULL,
      FirstName varchar(30) NOT NULL,
      LastName varchar(30) NOT NULL,
      Line1 varchar(70) NOT NULL,
      Line2 varchar(70) NULL,
      DoB datetime NOT NULL,
      Sex varchar(5) NOT NULL,
      NIC varchar(20) NOT NULL,
      Email varchar(70) NOT NULL,
	  Password varchar(70) NOT NULL,
	  RoleId int NOT NULL,
	  Active bit NOT NULL,
	  Constraint [PK_Staff] Primary Key Clustered ([StaffId] ASC)
	  Constraint [FK_Role] Foreign Key ([RoleId]) References [dbo].[Role] ([RoleId]));

create table StaffMobileNumber(StaffId int NOT NULL,
      MobileNumber int NOT NULL,
	  Constraint [PK_StaffMobileNumber] Primary Key Clustered ([StaffId] ASC),
	  Constraint [FK_Staff] Foreign Key ([StaffId]) References [dbo].[Staff] ([StaffId]));

create table Schedule(ScheduleId int Identity(1,1) NOT NULL,
      Date datetime NOT NULL,
      StartTime datetime NOT NULL,
      EndTime datetime NOT NULL,
	  ScheduleType varchar(10) NOT NULL,
	  CourseId int NOT NULL,
	  HallId int NOT NULL,
	  BatchId int NOT NULL,
	  ModuleId int NOT NULL,
	  Active bit NOT NULL,
	  Constraint [PK_Schedule] Primary Key Clustered ([ScheduleId] ASC),
	  Constraint [FK_Schedule_Hall] Foreign Key ([HallId]) References [dbo].[Hall] ([HallId]),
	  Constraint [FK_Schedule_Course] Foreign Key ([CourseId]) References [dbo].[Course] ([CourseId]),
	  Constraint [FK_Schedule_Batch] Foreign Key ([BatchId]) References [dbo].[Batch] ([BatchId]),
	  Constraint [FK_Schedule_Module] Foreign Key ([ModuleId]) References [dbo].[Module] ([ModuleId]));


create table Lecture(LectureId int Identity(1,1) NOT NULL,
      StaffId int NOT NULL,
	  ScheduleId int NOT NULL,
	  LectureType varchar(10) NOT NULL,
	  Constraint [PK_Lecture] Primary Key Clustered ([LectureId] ASC),
	  Constraint [FK_Lecture_Schedule] Foreign Key ([ScheduleId]) References [dbo].[Schedule] ([ScheduleId]),
	  Constraint [FK_Lecture_Staff] Foreign Key ([StaffId]) References [dbo].[Staff] ([StaffId]));

create table Exam(ExamId int Identity(1,1) NOT NULL,
	  StaffId int NOT NULL,
	  ScheduleId int NOT NULL,
	  Constraint [PK_Exam] Primary Key Clustered ([ExamId] ASC),
	  Constraint [FK_Exam_Schedule] Foreign Key ([ScheduleId]) References [dbo].[Schedule] ([ScheduleId]),
	  Constraint [FK_Exam_Staff] Foreign Key ([StaffId]) References [dbo].[Staff] ([StaffId]));
	
create table Role(RoleId int Identity(1,1) NOT NULL,
      RoleName varchar(75) NOT NULL,
	  Active bit NOT NULL,
	  Constraint [PK_Role] Primary Key Clustered ([RoleId] ASC));
