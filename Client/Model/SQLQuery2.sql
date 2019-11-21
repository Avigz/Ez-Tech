
Create TABLE Kunder(
KundeID int NOT NULL PRIMARY KEY,
KundeNavn varchar(255) NOT NULL,
KundeNummer varchar(11) NOT NULL,
KundeAdresse varchar(255) NOT NULL
);

CREATE TABLE Opgaver  (
    ID int NOT NULL PRIMARY KEY,
	KundeID INT FOREIGN KEY REFERENCES Kunder(KundeID) NOT NULL,
    Beskrivelse varchar(255),
	HjælperTilknyttet INT,
	IsDone Bit NOT NULL,
);

Create TABLE Hjælpere(
ID int NOT NULL PRIMARY KEY,
Navn varchar(255) NOT NULL,
TelefonNummer varchar(11) NOT NULL,
Kodeord varchar(255) NOT NULL,
Email varchar(255) NOT NULL,
IsAdmin BIT NOT NULL
);


