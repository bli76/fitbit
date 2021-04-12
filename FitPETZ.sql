CREATE TABLE Team(
    ID int,
    Motto varchar(50),
    Description varchar(100),
    Type nchar(10)
);

CREATE TABLE User(
    ID nchar(10),
    TeamID int,
    Email varchar(50),
    Age int,
    Height int, 
    Weight int, 
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
    ID int,
    PlayerID int, 
    Name varchar(50),
    Animal varchar(50),
    Birthday smalldatetime
);

CREATE TABLE ChallengeAssignments(
    ID int,
    Title varchar(50),
    Description varchar(100),
    Quantity int,
    Duration smalldatetime,
    Reward int
);
