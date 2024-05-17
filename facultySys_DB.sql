/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     5/17/2024 1:26:55 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Admin') and o.name = 'FK_ADMIN_ADMIN_HAS_ACCOUNTS')
alter table Admin
   drop constraint FK_ADMIN_ADMIN_HAS_ACCOUNTS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Course') and o.name = 'FK_COURSE_COURSE_BE_DEPARTME')
alter table Course
   drop constraint FK_COURSE_COURSE_BE_DEPARTME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Staff') and o.name = 'FK_STAFF_BELONGS_T_DEPARTME')
alter table Staff
   drop constraint FK_STAFF_BELONGS_T_DEPARTME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Student') and o.name = 'FK_STUDENT_ASSIGNED__DEPARTME')
alter table Student
   drop constraint FK_STUDENT_ASSIGNED__DEPARTME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Student') and o.name = 'FK_STUDENT_STUDENT_H_ACCOUNTS')
alter table Student
   drop constraint FK_STUDENT_STUDENT_H_ACCOUNTS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('accounts') and o.name = 'FK_ACCOUNTS_ADMIN_HAS_ADMIN')
alter table accounts
   drop constraint FK_ACCOUNTS_ADMIN_HAS_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('accounts') and o.name = 'FK_ACCOUNTS_STUDENT_H_STUDENT')
alter table accounts
   drop constraint FK_ACCOUNTS_STUDENT_H_STUDENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('enrolls') and o.name = 'FK_ENROLLS_RELATIONS_COURSE')
alter table enrolls
   drop constraint FK_ENROLLS_RELATIONS_COURSE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('enrolls') and o.name = 'FK_ENROLLS_RELATIONS_STUDENT')
alter table enrolls
   drop constraint FK_ENROLLS_RELATIONS_STUDENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('phones') and o.name = 'FK_PHONES_HAS_ACCOUNTS')
alter table phones
   drop constraint FK_PHONES_HAS_ACCOUNTS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('requires') and o.name = 'FK_REQUIRES_REQUIRES_COURSE')
alter table requires
   drop constraint FK_REQUIRES_REQUIRES_COURSE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('requires') and o.name = 'FK_REQUIRES_REQUIRES2_COURSE')
alter table requires
   drop constraint FK_REQUIRES_REQUIRES2_COURSE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('teaches') and o.name = 'FK_TEACHES_TEACHES_COURSE')
alter table teaches
   drop constraint FK_TEACHES_TEACHES_COURSE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('teaches') and o.name = 'FK_TEACHES_TEACHES2_STAFF')
alter table teaches
   drop constraint FK_TEACHES_TEACHES2_STAFF
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Admin')
            and   type = 'U')
   drop table Admin
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Course')
            and   type = 'U')
   drop table Course
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Department')
            and   type = 'U')
   drop table Department
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Staff')
            and   type = 'U')
   drop table Staff
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Student')
            and   type = 'U')
   drop table Student
go

if exists (select 1
            from  sysobjects
           where  id = object_id('accounts')
            and   type = 'U')
   drop table accounts
go

if exists (select 1
            from  sysobjects
           where  id = object_id('enrolls')
            and   type = 'U')
   drop table enrolls
go

if exists (select 1
            from  sysobjects
           where  id = object_id('phones')
            and   type = 'U')
   drop table phones
go

if exists (select 1
            from  sysobjects
           where  id = object_id('requires')
            and   type = 'U')
   drop table requires
go

if exists (select 1
            from  sysobjects
           where  id = object_id('teaches')
            and   type = 'U')
   drop table teaches
go

/*==============================================================*/
/* Table: Department                                            */
/*==============================================================*/
create table Department (
   department_id        varchar(10)          not null,
   department_name      varchar(50)          not null,
   constraint PK_DEPARTMENT primary key nonclustered (department_id)
)
go

/*==============================================================*/
/* Table: Student                                               */
/*==============================================================*/
create table Student (
   student_id           int                  not null,
   department_id        varchar(10)          null,
   account_id           int                  not null,
   student_first_name   varchar(25)          not null,
   student_middle_name  varchar(25)          not null,
   student_last_name    varchar(25)          not null,
   entry_year           datetime             not null,
   student_address      varchar(256)         null,
   constraint PK_STUDENT primary key nonclustered (student_id),
   constraint FK_STUDENT_ASSIGNED__DEPARTME foreign key (department_id)
      references Department (department_id),
   constraint FK_STUDENT_STUDENT_H_ACCOUNTS foreign key (account_id)
      references accounts (account_id)
)
go

/*==============================================================*/
/* Table: accounts                                              */
/*==============================================================*/
create table accounts (
   account_id           int                  not null,
   admin_id             int                  null,
   student_id           int                  null,
   user_name            varchar(50)          not null,
   password             varchar(25)          not null,
   email                varchar(50)          not null,
   constraint PK_ACCOUNTS primary key nonclustered (account_id),
   constraint FK_ACCOUNTS_ADMIN_HAS_ADMIN foreign key (admin_id)
      references Admin (admin_id),
   constraint FK_ACCOUNTS_STUDENT_H_STUDENT foreign key (student_id)
      references Student (student_id)
)
go

/*==============================================================*/
/* Table: Admin                                                 */
/*==============================================================*/
create table Admin (
   admin_id             int                  not null,
   account_id           int                  not null,
   admin_first_name     varchar(25)          not null,
   admin_middle_name    varchar(25)          not null,
   admin_last_name      varchar(25)          not null,
   admin_address        varchar(256)         null,
   constraint PK_ADMIN primary key nonclustered (admin_id),
   constraint FK_ADMIN_ADMIN_HAS_ACCOUNTS foreign key (account_id)
      references accounts (account_id)
)
go

/*==============================================================*/
/* Table: Course                                                */
/*==============================================================*/
create table Course (
   course_id            int                  not null,
   department_id        varchar(10)          null,
   course_name          varchar(50)          not null,
   credit_hours         int                  not null,
   constraint PK_COURSE primary key nonclustered (course_id),
   constraint FK_COURSE_COURSE_BE_DEPARTME foreign key (department_id)
      references Department (department_id)
)
go

/*==============================================================*/
/* Table: Staff                                                 */
/*==============================================================*/
create table Staff (
   staff_id             int                  not null,
   department_id        varchar(10)          null,
   staff_first_name     varchar(25)          not null,
   staff_middle_name    varchar(25)          not null,
   staff_last_name      varchar(25)          not null,
   constraint PK_STAFF primary key nonclustered (staff_id),
   constraint FK_STAFF_BELONGS_T_DEPARTME foreign key (department_id)
      references Department (department_id)
)
go

/*==============================================================*/
/* Table: enrolls                                               */
/*==============================================================*/
create table enrolls (
   student_id           int                  not null,
   course_id            int                  not null,
   semester             varchar(25)          not null,
   grade                float                not null,
   year                 datetime             not null,
   constraint PK_ENROLLS primary key (student_id, course_id),
   constraint FK_ENROLLS_RELATIONS_STUDENT foreign key (student_id)
      references Student (student_id),
   constraint FK_ENROLLS_RELATIONS_COURSE foreign key (course_id)
      references Course (course_id)
)
go

/*==============================================================*/
/* Table: phones                                                */
/*==============================================================*/
create table phones (
   account_id           int                  not null,
   phone_number         varchar(15)          not null,
   constraint PK_PHONES primary key (account_id),
   constraint FK_PHONES_HAS_ACCOUNTS foreign key (account_id)
      references accounts (account_id)
)
go

/*==============================================================*/
/* Table: requires                                              */
/*==============================================================*/
create table requires (
   course_id            int                  not null,
   Cou_course_id        int                  not null,
   constraint PK_REQUIRES primary key (course_id, Cou_course_id),
   constraint FK_REQUIRES_REQUIRES_COURSE foreign key (course_id)
      references Course (course_id),
   constraint FK_REQUIRES_REQUIRES2_COURSE foreign key (Cou_course_id)
      references Course (course_id)
)
go

/*==============================================================*/
/* Table: teaches                                               */
/*==============================================================*/
create table teaches (
   course_id            int                  not null,
   staff_id             int                  not null,
   constraint PK_TEACHES primary key (course_id, staff_id),
   constraint FK_TEACHES_TEACHES_COURSE foreign key (course_id)
      references Course (course_id),
   constraint FK_TEACHES_TEACHES2_STAFF foreign key (staff_id)
      references Staff (staff_id)
)
go

