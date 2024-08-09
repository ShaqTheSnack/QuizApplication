



----------------------------THIS PAGE CONTAINS SCRIPTS USED TO CREATE THIS PROGRAMS DATABASE----------------------------





-- THIS WILL CREATE THE TABLE ->
CREATE TABLE HistoryTable (
    HistoryQuestionID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Question varchar(255),
    RealAnswer varchar(255),
    FalseAnswer1 varchar(255),
    FalseAnswer2 varchar(255),
    FalseAnswer3 varchar(255),
    FalseAnswer4 varchar(255),
);

CREATE TABLE ScienceTable (
    ScienceQuestionID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Question varchar(255),
    RealAnswer varchar(255),
    FalseAnswer1 varchar(255),
    FalseAnswer2 varchar(255),
    FalseAnswer3 varchar(255),
    FalseAnswer4 varchar(255),
);

CREATE TABLE MovieTable (
    MovieQuestionID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Question varchar(255),
    RealAnswer varchar(255),
    FalseAnswer1 varchar(255),
    FalseAnswer2 varchar(255),
    FalseAnswer3 varchar(255),
    FalseAnswer4 varchar(255),
);

CREATE TABLE GeographyTable (
    GeographyQuestionID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Question varchar(255),
    RealAnswer varchar(255),
    FalseAnswer1 varchar(255),
    FalseAnswer2 varchar(255),
    FalseAnswer3 varchar(255),
    FalseAnswer4 varchar(255),
);

CREATE TABLE SportsTable (
    SportsQuestionID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Question varchar(255),
    RealAnswer varchar(255),
    FalseAnswer1 varchar(255),
    FalseAnswer2 varchar(255),
    FalseAnswer3 varchar(255),
    FalseAnswer4 varchar(255),
);

CREATE TABLE ProgrammingTable (
    ProgrammingQuestionID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Question varchar(255),
    RealAnswer varchar(255),
    FalseAnswer1 varchar(255),
    FalseAnswer2 varchar(255),
    FalseAnswer3 varchar(255),
    FalseAnswer4 varchar(255),
);

CREATE TABLE DatabaseTable (
    DatabaseQuestionID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Question varchar(255),
    RealAnswer varchar(255),
    FalseAnswer1 varchar(255),
    FalseAnswer2 varchar(255),
    FalseAnswer3 varchar(255),
    FalseAnswer4 varchar(255),
);

CREATE TABLE ClientSideTable (
    ClientSideQuestionID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Question varchar(255),
    RealAnswer varchar(255),
    FalseAnswer1 varchar(255),
    FalseAnswer2 varchar(255),
    FalseAnswer3 varchar(255),
    FalseAnswer4 varchar(255),
);

CREATE TABLE NetworkingTable (
    NetworkingQuestionID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Question varchar(255),
    RealAnswer varchar(255),
    FalseAnswer1 varchar(255),
    FalseAnswer2 varchar(255),
    FalseAnswer3 varchar(255),
    FalseAnswer4 varchar(255),
);

CREATE TABLE GUITable (
    GUIQuestionID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Question varchar(255),
    RealAnswer varchar(255),
    FalseAnswer1 varchar(255),
    FalseAnswer2 varchar(255),
    FalseAnswer3 varchar(255),
    FalseAnswer4 varchar(255),
);

CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    UserName NVARCHAR(255) NOT NULL,
    PassWord NVARCHAR(255) NOT NULL, 
    FirstName NVARCHAR(255) NOT NULL,
    LastName NVARCHAR(255) NOT NULL
);
-- THIS WILL CREATE THE TABLE <-





-- THIS WILL POPULATE THE TABLES WITH DATA ->
INSERT INTO HistoryTable (Question, RealAnswer, FalseAnswer1, FalseAnswer2, FalseAnswer3, FalseAnswer4)
VALUES
('Hvem var Danmarks første kvindelige statsminister?', 'Helle Thorning-Schmidt', 'Anker Jørgensen', 'Poul Schlüter', 'Anders Fogh Rasmussen', 'Lars Løkke Rasmussen'),

('Hvornår fandt Slaget på Dybbøl sted?', '1864', '1807', '1814', '1848', '1870'),

('Hvem var dansk konge under Grevens Fejde?', 'Christian III', 'Frederik II', 'Christian IV', 'Frederik III', 'Christian V'),

('Hvem skrev digtet "Jylland mellem tvende have"?', 'Steen Steensen Blicher', 'Adam Oehlenschläger', 'H.C. Andersen', 'Johannes V. Jensen', 'Holger Drachmann'),

('Hvornår blev Grundloven vedtaget i Danmark?', '1849', '1814', '1901', '1866', '1920'),

('Hvem var den danske opdagelsesrejsende, der ledede ekspeditionen til Grønland?', 'Knud Rasmussen', 'Ejnar Mikkelsen', 'Peter Freuchen', 'Jens Munk', 'Lauge Koch'),

('Hvad hed Danmarks første radiokanal, som startede i 1920?', 'Københavns Radio', 'Danmarks Radio', 'Radio Mercur', 'Radio24syv', 'Radio Nova'),

('Hvornår indførtes kristendommen som statsreligion i Danmark?', 'ca. år 960', 'ca. år 1100', 'ca. år 800', 'ca. år 1200', 'ca. år 1400'),

('Hvem var leder af den danske modstandsbevægelse under 2. verdenskrig?', 'Flemming Muus', 'Christian Frederik von Schalburg', 'Frits Clausen', 'Kim Malthe-Bruun', 'Poul Henningsen'),

('Hvilken begivenhed fandt sted den 5. juni 1849?', 'Den danske grundlovsdag', 'Indførelsen af parlamentarisme', 'Kroningen af Christian VIII', 'Underskrivelsen af Roskildefreden', 'Nedlæggelsen af kronen under Treårskrigen');

INSERT INTO ScienceTable (Question, RealAnswer, FalseAnswer1, FalseAnswer2, FalseAnswer3, FalseAnswer4)
VALUES
('Hvad er hastigheden af lyset i vakuum?', '299,792,458 meter per sekund', '100,000,000 meter per sekund', '200,000,000 meter per sekund', '400,000,000 meter per sekund', '500,000,000 meter per sekund'),

('Hvem opdagede elektronerne?', 'J.J. Thomson', 'Albert Einstein', 'Niels Bohr', 'Marie Curie', 'Isaac Newton'),

('Hvad er kemisk betegnelse for vand?', 'H2O', 'CO2', 'NaCl', 'O2', 'CH4'),

('Hvad er den kemiske formel for bordssalt?', 'NaCl', 'H2O', 'CO2', 'O2', 'HCl'),

('Hvem er kendt for sin teori om relativitet?', 'Albert Einstein', 'Isaac Newton', 'Niels Bohr', 'Stephen Hawking', 'Marie Curie'),

('Hvad er den kemiske formel for ilt?', 'O2', 'H2O', 'CO2', 'NaCl', 'HCl'),

('Hvem opdagede penicillin?', 'Alexander Fleming', 'Marie Curie', 'Louis Pasteur', 'Antonie van Leeuwenhoek', 'Robert Koch'),

('Hvad er det kemiske symbol for guld?', 'Au', 'Ag', 'Pt', 'Cu', 'Fe'),

('Hvem var den første kvinde, der vandt en Nobelpris?', 'Marie Curie', 'Rosalind Franklin', 'Dorothy Hodgkin', 'Rita Levi-Montalcini', 'Barbara McClintock'),

('Hvad er den største planet i vores solsystem?', 'Jupiter', 'Mars', 'Venus', 'Saturn', 'Uranus');

INSERT INTO MovieTable (Question, RealAnswer, FalseAnswer1, FalseAnswer2, FalseAnswer3, FalseAnswer4)
VALUES
('Hvem spillede hovedrollen i filmen "Forrest Gump"?', 'Tom Hanks', 'Brad Pitt', 'Leonardo DiCaprio', 'Johnny Depp', 'Robert Downey Jr.'),

('Hvad hedder den første film i Star Wars-serien?', 'Episode IV - A New Hope', 'Episode I - The Phantom Menace', 'Episode V - The Empire Strikes Back', 'Episode VII - The Force Awakens', 'Episode III - Revenge of the Sith'),

('Hvem instruerede filmen "The Shawshank Redemption"?', 'Frank Darabont', 'Martin Scorsese', 'Steven Spielberg', 'Quentin Tarantino', 'Christopher Nolan'),

('Hvad er hovedkarakterens navn i filmen "The Godfather"?', 'Don Vito Corleone', 'Tony Montana', 'Michael Corleone', 'Frank Costello', 'Sonny Corleone'),

('Hvem spillede James Bond i filmen "Casino Royale" fra 2006?', 'Daniel Craig', 'Pierce Brosnan', 'Sean Connery', 'Roger Moore', 'Timothy Dalton'),

('Hvad er titlen på den første Harry Potter-film?', 'Philosopher''s Stone', 'Chamber of Secrets', 'Prisoner of Azkaban', 'Goblet of Fire', 'Order of the Phoenix'),

('Hvem spillede hovedrollen i filmen "The Matrix"?', 'Keanu Reeves', 'Matt Damon', 'Hugh Jackman', 'Will Smith', 'Bradley Cooper'),

('Hvem vandt en Oscar for bedste skuespillerinde for sin rolle i filmen "La La Land" fra 2016?', 'Emma Stone', 'Jennifer Lawrence', 'Natalie Portman', 'Meryl Streep', 'Cate Blanchett'),

('Hvad er titlen på den første film i Marvel Cinematic Universe?', 'Iron Man', 'Thor', 'Captain America', 'The Avengers', 'Guardians of the Galaxy'),

('Hvem instruerede filmen "Avatar" fra 2009?', 'James Cameron', 'Christopher Nolan', 'Peter Jackson', 'George Lucas', 'Steven Spielberg');

INSERT INTO GeographyTable (Question, RealAnswer, FalseAnswer1, FalseAnswer2, FalseAnswer3, FalseAnswer4)
VALUES
('Hvad er hovedstaden i Frankrig?', 'Paris', 'London', 'Rom', 'Berlin', 'Madrid'),

('Hvad er verdens største ø?', 'Grønland', 'Australien', 'Madagaskar', 'Borneo', 'New Zealand'),

('Hvilket land er verdens største efter areal?', 'Rusland', 'USA', 'Canada', 'Kina', 'Brasilien'),

('Hvad er verdens længste flod?', 'Nilen', 'Amazonas', 'Yangtze', 'Mississippi', 'Ganges'),

('Hvad er verdens højeste bjerg?', 'Mount Everest', 'K2', 'Kangchenjunga', 'Lhotse', 'Makalu'),

('Hvor ligger pyramiderne i Giza?', 'Egypten', 'Sudan', 'Libyen', 'Algeriet', 'Syrien'),

('Hvilken europæisk hovedstad kaldes også for "Lysenes By"?', 'Paris', 'Rom', 'London', 'Berlin', 'Madrid'),

('Hvilket land har flest indbyggere?', 'Kina', 'Indien', 'USA', 'Indonesien', 'Brasilien'),

('Hvilket land har flest tidzoner?', 'Rusland', 'USA', 'Canada', 'Brasilien', 'Kina'),

('Hvor ligger Matterhorn-bjerget?', 'Schweiz', 'Italien', 'Frankrig', 'Østrig', 'Tyskland');

INSERT INTO SportsTable (Question, RealAnswer, FalseAnswer1, FalseAnswer2, FalseAnswer3, FalseAnswer4)
VALUES
('Hvilken sport spilles på en bane kaldet "court"?', 'Tennis', 'Fodbold', 'Basketball', 'Golf', 'Baseball'),

('Hvilken atletikøvelse kaldes også for "heptathlon"?', 'Syvkamp', 'Ti-kamp', 'Maraton', 'Hækkeløb', 'Spydkast'),

('Hvilket land er kendt for at være fødestedet for moderne olympiske lege?', 'Grækenland', 'Italien', 'Frankrig', 'USA', 'Storbritannien'),

('Hvem vandt FIFA Verdensmesterskabet i fodbold i 2018?', 'Frankrig', 'Tyskland', 'Argentina', 'Brasilien', 'Spanien'),

('Hvad er den længste distance i olympisk svømning?', '1500 meter fri', '400 meter fri', '100 meter fri', '200 meter medley', '50 meter fri'),

('Hvilket hold vandt Super Bowl LV i 2021?', 'Tampa Bay Buccaneers', 'Kansas City Chiefs', 'New England Patriots', 'Los Angeles Rams', 'Dallas Cowboys'),

('Hvilken sportsgren spiller et hold i kampen om en Stanley Cup?', 'Ishockey', 'Basketball', 'Amerikansk fodbold', 'Baseball', 'Fodbold'),

('Hvem vandt Tour de France i 2021?', 'Tadej Pogačar', 'Egan Bernal', 'Geraint Thomas', 'Chris Froome', 'Primoz Roglic'),

('Hvem er verdensmester i formel 1 for 2021 sæsonen?', 'Max Verstappen', 'Lewis Hamilton', 'Valtteri Bottas', 'Sebastian Vettel', 'Charles Leclerc'),

('Hvem vandt Wimbledon-turneringen for herrer i 2021?', 'Novak Djokovic', 'Roger Federer', 'Rafael Nadal', 'Andy Murray', 'Stefanos Tsitsipas');

INSERT INTO ProgrammingTable (Question, RealAnswer, FalseAnswer1, FalseAnswer2, FalseAnswer3, FalseAnswer4)
VALUES
('Hvad er en metode i C#?', 'En funktion', 'En variabeltype', 'En datastruktur', 'En kommentar', 'En filtype'),

('Hvordan laves en ny instans af en klasse i C#?', '''new''', '''class''', '''instance''', '''object''', '''create'''),

('Hvad er en boolsk variabel i C#?', 'Variabel der kan være sand eller falsk', 'Variabel der indeholder tekst', 'Variabel der indeholder tal', 'Variabel der bruges til beregninger', 'Variabel der ikke kan ændres'),

('Hvordan tilføjes elementer til en liste (List<T>) i C#?', 'Add()', 'Insert()', 'Append()', 'Push()', 'Put()'),

('Hvad betyder det at "debugge" en applikation i C#?', 'Finde og rette fejl', 'Skrive koden første gang', 'Teste applikationen', 'Gemme applikationen', 'Opdatere applikationen'),

('Hvad er en if-sætning i C#?', 'En kontrolstruktur', 'En løkke', 'En funktion', 'En kommentar', 'En variabel'),

('Hvordan skrives en kommentar i C#?', '//', '/** */', '/* */', '''''', '<!---->'),

('Hvad betyder det at override en metode i C#?', 'Erstatte metodes implementering', 'Tilføje ny metode', 'Skjule metode fra baseklasse', 'Udføre metode to gange', 'Oprette ny klasse'),

('Hvad er en "interface" i C#?', 'Kontrakt for funktionalitet', 'Form for datatype', 'Type exception', 'Filtype i C#', 'Type variabel'),

('Hvad er en klasse i C#?', 'Skabelon til objekter', 'Samling af metoder', 'Filtype', 'Variabel', 'Kommentar');

INSERT INTO DatabaseTable (Question, RealAnswer, FalseAnswer1, FalseAnswer2, FalseAnswer3, FalseAnswer4)
VALUES
('Hvad er SQL?', 'Sprog til databaseforespørgsler', 'Programmeringssprog', 'Webudviklingssprog', 'Grafikprogram', 'Operativsystem'),

('Hvad er en primærnøgle?', 'Unik identifikator', 'Felt med null-værdier', 'Tillader dubletter', 'Relationer mellem tabeller', 'Kun tekst'),

('Hvad er forskellen mellem SQL og NoSQL?', 'SQL er relationel, NoSQL er ikke-relationel', 'SQL bruger kun XML, NoSQL kun JSON', 'SQL er hurtigere end NoSQL', 'SQL understøtter kun én datatype, NoSQL flere', 'Ingen forskel'),

('Hvad er en JOIN i SQL?', 'Kombinerer rækker fra tabeller', 'Opretter ny database', 'Opdaterer data', 'Sletter rækker', 'Vælger data'),

('Hvad er en indeks i en database?', 'Forbedrer dataforespørgsler', 'Kun tal', 'Kan indeholde null', 'Tillader dubletter', 'Viser relationer'),

('Hvordan indsættes data i en SQL tabel?', 'Med INSERT INTO', 'Med SELECT', 'Med DELETE', 'Med UPDATE', 'Med CREATE TABLE'),

('Hvordan vælges data fra en SQL tabel?', 'Med SELECT', 'Med INSERT INTO', 'Med DELETE', 'Med UPDATE', 'Med CREATE TABLE'),

('Hvordan slettes data fra en SQL tabel?', 'Med DELETE', 'Med INSERT INTO', 'Med SELECT', 'Med UPDATE', 'Med CREATE TABLE'),

('Hvordan opdateres data i en SQL tabel?', 'Med UPDATE', 'Med INSERT INTO', 'Med SELECT', 'Med DELETE', 'Med CREATE TABLE'),

('Hvad er en fremmednøgle?', 'Refererer til primærnøgle', 'Unik identifikator', 'Kun tal', 'Tillader dubletter', 'Viser relationer');

INSERT INTO ClientSideTable (Question, RealAnswer, FalseAnswer1, FalseAnswer2, FalseAnswer3, FalseAnswer4)
VALUES
('Hvad står HTML for?', 'HyperText Markup Language', 'HyperText Modeling Language', 'Home Tool Markup Language', 'Hyperlink Transfer Markup Language', 'HyperText Management Language'),

('Hvad står CSS for?', 'Cascading Style Sheets', 'Creative Style Sheets', 'Colorful Style Sheets', 'Cascading Script Sheets', 'Cascading System Sheets'),

('Hvad står JS for?', 'JavaScript', 'JavaServer', 'JSON Script', 'Java Syntax', 'JavaScripting'),

('Hvordan defineres en ny HTML side?', '<!DOCTYPE html>', '<html>', '<head>', '<body>', '<title>'),

('Hvordan tilføjes CSS til en HTML side?', '<link rel="stylesheet" href="style.css">', '<style>...</style>', '<script src="styles.js"></script>', '<div class="style">', '<meta name="stylesheet" content="style.css">'),

('Hvordan tilføjes JavaScript til en HTML side?', '<script src="script.js"></script>', '<link rel="stylesheet" href="script.css">', '<style>...</style>', '<div class="script">', '<meta name="script" content="script.js">'),

('Hvordan tilføjes en kommentar i HTML?', '<!-- Kommentar -->', '// Kommentar', '/* Kommentar */', '<! Kommentar >', '{ Kommentar }'),

('Hvordan centreres en div i CSS?', 'margin: 0 auto;', 'text-align: center;', 'align: center;', 'padding: 0 auto;', 'display: center;'),

('Hvordan tilføjes en event listener i JavaScript?', 'element.addEventListener(event, function)', 'element.onClick = function()', 'element.onEvent = function()', 'element.listen(event, function)', 'element.event = function()'),

('Hvordan ændres indholdet af et element med JavaScript?', 'element.innerHTML = "nyt indhold";', 'element.textContent = "nyt indhold";', 'element.value = "nyt indhold";', 'element.innerText = "nyt indhold";', 'element.innerHtml = "nyt indhold";');

INSERT INTO NetworkingTable (Question, RealAnswer, FalseAnswer1, FalseAnswer2, FalseAnswer3, FalseAnswer4)
VALUES
('Hvad er DNS?', 'Domain Name System', 'Dynamic Network Service', 'Data Name Service', 'Domain Network Service', 'Digital Network System'),

('Hvad er DHCP?', 'Dynamic Host Config Protocol', 'Digital Host Control', 'Dynamic Host Control', 'Data Host Configuration', 'Domain Host Control'),

('Hvad er en IP-adresse?', 'Enhedens ID', 'Internetforbindelse', 'Netværksprotokol', 'Software', 'Computers model'),

('Hvad er en firewall?', 'Netværksfiltrering', 'Virusbeskyttelse', 'Netværksforbindelse', 'Overvågning', 'Hastighedsoptimering'),

('Hvad betyder HTTPS?', 'Sikker HTTP', 'Hurtig sikker protokol', 'HyperText Security', 'Højtydende HTTP', 'HyperText Protocol'),

('Forskel mellem TCP og UDP?', 'TCP pålidelig, UDP ikke', 'TCP hurtigere end UDP', 'TCP mindre båndbredde', 'TCP tekst, UDP både tekst og billeder', 'Ingen forskel'),

('Hvad er en MAC-adresse?', 'Fysisk adresse', 'Netværksenhed', 'Internetforbindelsestype', 'Krypteringsmetode', 'Netværkssoftware'),

('Hvad er en gateway?', 'Netværksforbinder', 'Trådløs forbindelse', 'Netværksbeskyttelse', 'Datavideresender', 'DNS-administrator'),

('Hvad er en router?', 'Datavideresender', 'Trådløs forbindelse', 'DNS-administrator', 'Virtuelt netværk', 'Netværksbeskyttelse'),

('Hvad er en switch?', 'Datavideresender', 'Trådløs forbindelse', 'DNS-administrator', 'Virtuelt netværk', 'Netværksbeskyttelse');

INSERT INTO GUITable (Question, RealAnswer, FalseAnswer1, FalseAnswer2, FalseAnswer3, FalseAnswer4)
VALUES
('Hvad står GUI for?', 'Grafisk Brugerflade', 'Globalt Brugerinterface', 'Generelt Brugerinput', 'Grafisk Bruger Interaktion', 'Grafisk Brugerbeskyttelse'),

('Hvad er en widget i GUI?', 'Interaktivt element', 'Programmeringssprog', 'Netværksprotokol', 'Filformat', 'Billede'),

('Hvad er en knap i GUI?', 'Klikbart element', 'Lydindstilling', 'Billedredigering', 'Skrifttype', 'Farvevalg'),

('Hvad er en dialogboks i GUI?', 'Interaktivt pop-up vindue', 'Skærmskabelon', 'Webbrowser', 'Grafikprogram', 'Menu'),

('Hvordan oprettes en dropdown-menu i GUI?', 'Med <select> tag', 'Med <input> tag', 'Med <button> tag', 'Med <form> tag', 'Med <option> tag'),

('Hvordan tilføjes billedfiler i GUI?', 'Med <img> tag', 'Med <div> tag', 'Med <p> tag', 'Med <span> tag', 'Med <a> tag'),

('Hvordan ændres baggrundsfarven i GUI?', 'Med CSS: background-color', 'Med CSS: text-color', 'Med CSS: font-color', 'Med CSS: border-color', 'Med CSS: baggrund'),

('Hvordan tilføjes en event handler i GUI?', 'Med JavaScript', 'Med CSS', 'Med HTML', 'Med SQL', 'Med PHP'),

('Hvordan ændres tekststørrelsen i GUI?', 'Med CSS: font-size', 'Med CSS: text-size', 'Med CSS: font-style', 'Med CSS: text-style', 'Med CSS: størrelse'),

('Hvad er en tooltip i GUI?', 'Pop-up med info', 'Menu i sidebar', 'Animationseffekt', 'Filter i søgefelt', 'Bannerannonce');
--THIS WILL POPULATE THE TABLES WITH DATA <-





--THIS IS MY PROCEDURES ->
GO
CREATE PROCEDURE GetAllQuestionHistory
AS
BEGIN
    SELECT * FROM HistoryTable;
END;

GO
CREATE PROCEDURE GetAllQuestionScience
AS
BEGIN
    SELECT * FROM ScienceTable;
END;

GO
CREATE PROCEDURE GetAllQuestionMovie
AS
BEGIN
    SELECT * FROM MovieTable;
END;

GO
CREATE PROCEDURE GetAllQuestionGeography
AS
BEGIN
    SELECT * FROM GeographyTable;
END;

GO
CREATE PROCEDURE GetAllQuestionSports
AS
BEGIN
    SELECT * FROM SportsTable;
END;

GO
CREATE PROCEDURE GetAllQuestionProgramming
AS
BEGIN
    SELECT * FROM ProgrammingTable;
END;

GO
CREATE PROCEDURE GetAllQuestionDatabase
AS
BEGIN
    SELECT * FROM DatabaseTable;
END;

GO
CREATE PROCEDURE GetAllQuestionClientSide
AS
BEGIN
    SELECT * FROM ClientSideTable;
END;

GO
CREATE PROCEDURE GetAllQuestionNetworking
AS
BEGIN
    SELECT * FROM NetworkingTable;
END;

GO
CREATE PROCEDURE GetAllQuestionGUI
AS
BEGIN
    SELECT * FROM GUITable;
END;

GO

CREATE PROCEDURE GetUsernameCount
    @Username NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT COUNT(*)
    FROM Users
    WHERE UserName = @Username;
END;

GO

CREATE PROCEDURE CheckLogin
    @inputUsername NVARCHAR(255),
    @inputPassword NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT COUNT(*) AS Result
    FROM Users 
    WHERE UserName = @inputUsername AND PassWord = @inputPassword;
END

GO

CREATE PROCEDURE InsertUser
    @Username NVARCHAR(255),
    @Password NVARCHAR(255),
    @FirstName NVARCHAR(255),
    @LastName NVARCHAR(255)
AS
BEGIN
    INSERT INTO Users (UserName, PassWord, FirstName, LastName)
    VALUES (@Username, @Password, @FirstName, @LastName)
END;
--THIS IS MY PROCEDURES <-
