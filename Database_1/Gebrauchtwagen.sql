CREATE TABLE Verkaeufer (
	verkaeufer_id int not null primary key,
	vorname varchar(30) not null,
	nachname varchar(30) not null
)
GO
CREATE TABLE Fahrzeug (
	fahrzeug_id int not null primary key,
	marke varchar(30) not null,
	modell varchar(30) not null,
	preis money not null,
	verkaeufer_id int,
	constraint fk_fahrzeug_verkaeufer foreign key (verkaeufer_id)
	references Verkaeufer (verkaeufer_id)
)