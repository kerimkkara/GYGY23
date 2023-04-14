CREATE TABLE Characters (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL,
    Age INT,
    Gender NVARCHAR(10),
    Powers NVARCHAR(500),
    Birthplace NVARCHAR(50),
    Story NVARCHAR(MAX),
    Home NVARCHAR(50)
);


CREATE TABLE Movies (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(100) NOT NULL,
    ReleaseDate DATE,
    Budget MONEY,
    BoxOfficeRevenue MONEY,
    Director NVARCHAR(50),
    Writer NVARCHAR(50),
    Cast NVARCHAR(500)
);


CREATE TABLE TVShows (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(100) NOT NULL,
    ReleaseDate DATE,
    Seasons INT,
    Episodes INT,
    Creator NVARCHAR(50),
    Cast NVARCHAR(500)
);


CREATE TABLE CharacterMovies (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    CharacterId INT NOT NULL,
    MovieId INT NOT NULL,
    FOREIGN KEY (CharacterId) REFERENCES Characters(Id),
    FOREIGN KEY (MovieId) REFERENCES Movies(Id)
);

-- Karakter Dizileri tablosu oluþturma
CREATE TABLE CharacterTVShows (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    CharacterId INT NOT NULL,
    TVShowId INT NOT NULL,
    FOREIGN KEY (CharacterId) REFERENCES Characters(Id),
    FOREIGN KEY (TVShowId) REFERENCES TVShows(Id)
);
