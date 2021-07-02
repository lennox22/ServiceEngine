drop database serviceengine;
create database serviceengine;
use serviceengine;

create table ticket (
	id int not null auto_increment primary key,
    openedUsername varchar(50),
    openedtime datetime,
    issue varchar(150),
    body varchar(2000),
    closedUsername varchar(50),
    closedtime datetime
    );
    
    create table bookmark (
	id int not null auto_increment primary key,
    username varchar(50),
    ticket int
    );
    
select* from ticket;
select * from bookmark;

insert into ticket (id, openedUsername, openedtime, issue, body, closedUsername, closedtime) values (1,'McPherson','2021-01-13 00:00:01.000000','White page of death','When you click on that button the page just goes white.',null,null);
insert into ticket (id, openedUsername, openedtime, issue, body, closedUsername, closedtime) values (2,'Foxtrot','2021-02-20 00:00:01.000000','Username is wrong','I need the username to be changed. Not sure how it was put in but it is wrong.',null,null);
insert into ticket (id, openedUsername, openedtime, issue, body, closedUsername, closedtime) values (3,'Limerick','2021-04-17 00:00:01.000000','Page 3 will not load','It skips over page 3. If I click on page 3 it shows an error.',null,null);
insert into ticket (id, openedUsername, openedtime, issue, body, closedUsername, closedtime) values (4,'McPherson','2021-06-16 00:00:01.000000','no save button','When I am filling out the form there is no save button.',null,null);
insert into ticket (id, openedUsername, openedtime, issue, body, closedUsername, closedtime) values (5,'Samcity','2021-06-29 00:00:01.000000','add an email','The email is incorrect on the application. Can someone change it?',null,null);

insert into bookmark (id, username, ticket) values (1,'Franko',1);
insert into bookmark (id, username, ticket) values (2,'Sanderson',5);
insert into bookmark (id, username, ticket) values (3,'Maxwell',3);
insert into bookmark (id, username, ticket) values (4,'Banto',5);
insert into bookmark (id, username, ticket) values (5,'Maxwell',2);
insert into bookmark (id, username, ticket) values (6,'Banto',1);
