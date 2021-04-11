CREATE TABLE Team(
    IDtag int,
    Motto varchar(50),
    Descriptionof varchar(100),
    Typeof nchar(10)
);

CREATE TABLE User(
    Idusername nchar(10),
    TeamID int,
    Email varchar(50),
    Age int,
    Heightof int, 
    Weightof int, 
    Gender nchar(10),
    Petokens int,
    WeeklyPoints int
);

CREATE TABLE Challenge(
    ID int,
    PlayerID int, 
    DateOf datetime,
    Complete datetime,
    Title nchar(10),
    Descriptionof varchar(100),
    Quantity int,
    Duration smalldatetime,
    Reward int
);

CREATE TABLE Pet(
    Id int,
    PlayerIDowner int, 
    NameOf varchar(50),
    Animal varchar(50),
    Birthday smalldatetime
);

CREATE TABLE ChallengeAssignments(
    Id int,
    Title varchar(50),
    Descriptionof varchar(100),
    Quantity int,
    Duration smalldatetime,
    Reward int
);

