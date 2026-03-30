CREATE TABLE dbo.Uyeler (
    UyeID INT IDENTITY PRIMARY KEY,
    Email NVARCHAR(50),
    Sifre NVARCHAR(50)
);


INSERT INTO Uyeler (Email, Sifre)
VALUES ('test', '1234');
