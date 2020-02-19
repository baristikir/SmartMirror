# DB Properties
## DB Database
Die zurzeit verwendete heißt SmartMirror. In dieser gibt es folgende Tabellen:
* Users
* Token
* APIs
### Users
In der Tabelle Users gibt es folgende Spalten:
* Username VARCHAR(255) NOT NULL
* Email VARCHAR(255)
* UserID INT AUTO_INCREMENT PRIMARY KEY
### Token
In der Tabelle Token gibt es folgende Spalten:
* API_ID INT
* UserID INT
* token VARCHAR(255)
### APIs
Die Tabelle beinhaltet die implementierten und funktionierenden SChnittstellen(APIs).
In der Tabelle AP gibt es folgende Spalten:
* Name VARCHAR(255)
* ID INT PRIMARY KEY

# MYSQL Code
## DATABASE
CREATE DATABASE SmartMirror;

## TABLES 
CREATE TABLE Users (Username VARCHAR(255), Email VARCHAR(255), UserID INT AUTO_INCREMENT PRIMARY KEY);
CREATE TABLE APIs (Name VARCHAR(255), ID INT AUTO_INCREMENT PRIMARY KEY);
create TABLE Token (API_ID INT, token VARCHAR(255),UserID INT,CONSTRAINT tokenID PRIMARY KEY(API_ID,USERID),CONSTRAINT Users FOREIGN KEY (UserID) REFERENCES Users(UserID), CONSTRAINT APIid FOREIGN KEY (API_ID) REFERENCES APIs(ID));

## Users
CREATE USER 'client' IDENTIFIED BY 'password';
GRANT SELECT ON SmartMirror.\* TO client;
FLUSH PRIVILEGES;


## add Example Values
INSERT INTO APIs (Name) values ("testAPI");
INSERT INTO Users (Username,Email) values ("Peter","Peter@test.com");
INSERT INTO Token (API_ID,UserID,token) values (1,1,"tokentest");

