CREATE DATABASE EzTechDB;

CREATE TABLE Opgaver (
    ID int NOT NULL PRIMARY KEY,
    KundeNavn varchar(255) NOT NULL,
    KundeAdresse varchar(255) NOT NULL,
    Beskrivelse varchar(255),
	HjælperTilknyttet int,
	IsDone Bit NOT NULL,
);

Create TABLE Hjælpere(
ID int NOT NULL PRIMARY KEY,
Navn varchar(255) NOT NULL,
TelefonNummer int NOT NULL,
Kodeord varchar(255) NOT NULL,
Email varchar(255) NOT NULL,

);

Create TABLE Administrator(
ID int NOT NULL PRIMARY KEY,
Navn varchar(255) NOT NULL,
Kodeord varchar(255) NOT NULL,
);
