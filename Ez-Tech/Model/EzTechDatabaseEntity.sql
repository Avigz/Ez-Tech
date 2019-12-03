 --Insert into Hjælpere(ID, Navn, TelefonNummer, Kodeord, Email, IsAdmin) Values(1, 'Carl', 51912007, 2021, 'carl.dreslet@gmail.com', 0);

 -- Insert into Hjælpere(ID, Navn, TelefonNummer, Kodeord, Email, IsAdmin) Values(2, 'Jacob', 51912008, 2022, 'Jacob@gmail.com', 0);
 -- Insert into Hjælpere(ID, Navn, TelefonNummer, Kodeord, Email, IsAdmin) Values(3, 'Timm', 51912009, 2023, 'Timm@gmail.com', 0);
 -- Insert into Hjælpere(ID, Navn, TelefonNummer, Kodeord, Email, IsAdmin) Values(4, 'Jonas', 51912010, 2024, 'Jonas@gmail.com', 1);
 -- Insert into Hjælpere(ID, Navn, TelefonNummer, Kodeord, Email, IsAdmin) Values(5, 'Anders', 51912011, 2025, 'Anders@gmail.com', 0);

 --Insert into Kunder(KundeID, KundeNavn, KundeNummer, KundeAdresse) values(1, 'Carl', '51912007', 'Perikumhaven 59A')


--Insert into Opgaver(ID, KundeID, KundeNavn, KundeAdresse, Beskrivelse, HjælperTilknyttet, IsDone) 
--Values(2, 02, 'Carl', 'Kolibrivej', 'Herlev', 4, 0);

--Insert into Opgaver(ID, KundeID, KundeNavn, KundeAdresse, Beskrivelse, HjælperTilknyttet, IsDone) 
--Values(3, 03, 'Saad', 'Antomivej', 'Solrød', 2, 1);

-- Insert into Opgaver(ID, KundeID, Beskrivelse, HjælperTilknyttet, IsDone) 
--Values(1, 01, 'Hjælp mig', NULL, 1);

--Insert into Opgaver(ID, KundeID, KundeNavn, KundeAdresse, Beskrivelse, HjælperTilknyttet, IsDone) 
--Values(4, 04, 'Mathias', 'Vedehænget', 'Trekroner', 1, 0);

--Insert into Opgaver(ID, KundeID, KundeAdresse, Beskrivelse, HjælperTilknyttet, IsDone) 
--Values(5, 05, 'Anja', 'Juvelvej', 'Hillerød', 4, 0);