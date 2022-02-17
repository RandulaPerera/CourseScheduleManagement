create database CourseSheduleManagement;

use CourseSheduleManagement;


create table Course(CourseId int Identity(1,1) NOT NULL,
      Name varchar(75) NOT NULL,
      Code varchar(25) NOT NULL,
      Description varchar(max) NULL,
      IsDelete bit NOT NULL,
	  Constraint [PK_Course] Primary Key Clustered ([CourseId] ASC));

create table Hall(HallId int Identity(1,1) NOT NULL,
      Name varchar(75) NOT NULL,
	  IsDelete bit NOT NULL,
	  Constraint [PK_Hall] Primary Key Clustered ([HallId] ASC));

create table UserRole(RoleId int Identity(1,1) NOT NULL,
      Name varchar(75) NOT NULL,
	  IsDelete bit NOT NULL,
	  Constraint [PK_UserRole] Primary Key Clustered ([RoleId] ASC));

create table Batch(BatchId int Identity(1,1) NOT NULL,
	  Year int NOT NULL,
	  CourseId int NOT NULL,
      Code varchar(75) NOT NULL,
	  IsDelete bit NOT NULL,
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
	  Password varchar(25) NOT NULL,
      MobileNumber int NOT NULL,
      Telephone int NOT NULL,
	  CourseId int NOT NULL,
	  BatchId int NOT NULL,
	  IsDelete bit NOT NULL,
	  Constraint [PK_Student] Primary Key Clustered ([StudentId] ASC),
	  Constraint [FK_Student_Course] Foreign Key ([CourseId]) References [dbo].[Course] ([CourseId]),
	  Constraint [FK_Student_Batch] Foreign Key ([BatchId]) References [dbo].[Batch] ([BatchId]));

create table Module(ModuleId int Identity(1,1) NOT NULL,
	  Name varchar(75)  NOT NULL,
	  Description varchar(max) NULL,
	  CourseId int NOT NULL,
	  IsDelete bit NOT NULL,
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
	  Password varchar(25) NOT NULL,
      MobileNumber int NOT NULL,
      Telephone int NOT NULL,
	  RoleId int NOT NULL,
	  IsDelete bit NOT NULL,
	  Constraint [PK_Staff] Primary Key Clustered ([StaffId] ASC),
	  Constraint [FK_Staff_UserRole] Foreign Key ([RoleId]) References [dbo].[UserRole] ([RoleId]));


create table Schedule(ScheduleId int Identity(1,1) NOT NULL,
      Date Date NOT NULL,
      StartTime Time NOT NULL,
      EndTime Time NOT NULL,
	  HallId int NOT NULL,
	  CourseId int NOT NULL,
	  ModuleId int NOT NULL,
	  Constraint [PK_Schedule] Primary Key Clustered ([ScheduleId] ASC),
	  Constraint [FK_Schedule_Hall] Foreign Key ([HallId]) References [dbo].[Hall] ([HallId]),
	  Constraint [FK_Schedule_Course] Foreign Key ([CourseId]) References [dbo].[Course] ([CourseId]),
	  Constraint [FK_Schedule_Module] Foreign Key ([ModuleId]) References [dbo].[Module] ([ModuleId]));


create table Lecture(ScheduleId int NOT NULL,
      LecturerBy int NOT NULL,
	  Type varchar(10) NOT NULL,
	  Constraint [PK_Lecture] Primary Key Clustered ([ScheduleId] ASC),
	  Constraint [FK_Lecture_Schedule] Foreign Key ([ScheduleId]) References [dbo].[Schedule] ([ScheduleId]),
	  Constraint [FK_Lecture_Staff] Foreign Key ([LecturerBy]) References [dbo].[Staff] ([StaffId]));

create table Exam(ScheduleId int NOT NULL,
	  PreparedBy int NOT NULL,
      ExamInvigilateBy  int NOT NULL,
	  Constraint [PK_Exam] Primary Key Clustered ([ScheduleId] ASC),
	  Constraint [FK_Exam_Schedule] Foreign Key ([ScheduleId]) References [dbo].[Schedule] ([ScheduleId]),
	  Constraint [FK_Exam_Staff1] Foreign Key ([PreparedBy]) References [dbo].[Staff] ([StaffId]),
	  Constraint [FK_Exam_Staff2] Foreign Key ([ExamInvigilateBy]) References [dbo].[Staff] ([StaffId]));
	 