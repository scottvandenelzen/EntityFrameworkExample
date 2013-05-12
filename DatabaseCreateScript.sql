-- this is a create script to create the contactsDB database ane the contacts table within it
--
CREATE DATABASE ContactsDB
GO
USE ContactsDB
GO
CREATE TABLE Contacts
(ID Int Identity(1,1),
 fname varchar(50) null,
 lname varchar(50) null,
 phone varchar(50) null
)
GO
