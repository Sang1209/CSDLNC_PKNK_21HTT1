--use master
--go
--drop database csc12002_21clc10_n10
create database csc12002_21clc10_n10

create table account_de (
	username char(10) not null primary key,
	password varchar(30) not null,
	name varchar(20) not null,
	phone varchar(12) not null,
	email varchar(50),
	address varchar(50) not null,
	gender bit not null,
	department smallint not null,
)

create table account_adst (
	username char(10) not null primary key,
	password varchar(30) not null,
	name varchar(20) not null,
	phone varchar(12) not null,
	email varchar(50),
	address varchar(50) not null,
	gender bit not null,
	admin bit not null,
)

create table department (
	id smallint not null primary key,
	address varchar(50) not null,
)

create table schedule (
	date date not null,
	shift_id smallint not null,
	dentist char(10) not null,
	patient int not null,
	asisstant char(10),
	type int,
	department smallint not null,
	constraint pk_schedule primary key (date,shift_id,dentist)
)

create table shift_period (
	id smallint not null primary key,
	start time not null,
	finish time not null,
)

create table patient_profile (
	id int not null primary key,
	name varchar(20) not null,
	age smallint not null,
	birth date not null,
	phone varchar(12) not null,
	email varchar(50),
	address varchar(50) not null,
	gender bit not null,
	bill float,
	paid float,
	overall_condition varchar(100),
	contraindicated_note varchar(100),
)

create table contraindicated (
	patient int not null,
	medicine varchar(10) not null,
	constraint pk_contraindicated primary key (patient,medicine)
)

create table treatment (
	id int not null primary key,
	department int not null,
	dentist char(10) not null,
	patient int not null,
	asisstant char(10),
	description varchar(100),
	date date not null,
	note varchar(100),
	method int,
	tooth int,
	state smallint,
	total float,
	reexam_date date
)

create table treatment_list (
	id smallint not null primary key,
	name varchar(50) not null,
)

create table tooth_list (
	id smallint not null primary key,
	name varchar(10) not null,
)

create table payment (
	treatment int not null,
	no smallint not null,
	total float not null,
	given float not null,
	method int not null,
	date date not null,
	payer varchar(20) not null,
	note varchar(100),
	constraint pk_payment primary key (treatment,no)
)

create table payment_method (
	id smallint not null primary key,
	name varchar(20) not null,
)

create table prescription (
	treatment int not null,
	medicine varchar(10) not null,
	quantity int not null,
	note varchar(100),
	constraint pk_presription primary key (treatment,medicine)
)

create table medicine (
	id varchar(10) not null primary key,
	name varchar(20) not null,
)

create table quantity_medicine (
	medicine varchar(10) not null,
	department smallint not null,
	remain int not null,
	constraint pk_quantity_medicine primary key (department,medicine)
)
go
alter table account_de add foreign key (department) references department(id)

alter table schedule add foreign key (dentist) references account_de(username)
alter table schedule add foreign key (asisstant) references account_de(username)
alter table schedule add foreign key (department) references department(id)
alter table schedule add foreign key (shiftid) references shift_period(id)
alter table schedule add foreign key (patient) references patient_profile(id)

alter table schedule add foreign key (type) references treatment(id)
alter table contraindicated add foreign key (patient) references patient_profile(id)
alter table contraindicated add foreign key (medicine) references medicine(id)

alter table treatment add foreign key (dentist) references account_de(username)
alter table treatment add foreign key (asisstant) references account_de(username)
alter table treatment add foreign key (department) references department(id)
alter table treatment add foreign key (patient) references patient_profile(id)
alter table treatment add foreign key (method) references treatment_list(id)
alter table treatment add foreign key (tooth) references tooth_list(id)

alter table payment add foreign key (method) references payment_method(id)
alter table payment add foreign key (treatment) references treatment(id)

alter table prescription add foreign key (treatment) references treatment(id)
alter table prescription add foreign key (medicine) references medicene(id)







