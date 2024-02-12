CREATE DATABASE BelgiumCampusITVersity;

USE BelgiumCampusITVersity;

CREATE TABLE Students (
	StudentID int,
	LastName varchar(255),
	FirstName varchar(255),
	CourseID varchar(255)
);

Use BelgiumCampusITVersity
INSERT INTO dbo.Students
VALUES
(13456, 'Tshepo', 'Kekena', 'PRG361'),
(13042, 'Molefe', 'Lenyai', 'WPR262'),
(13985, 'Ofentse', 'Setshogo', 'PRG282'),
(17495, 'Tshepo', 'Masilela', 'WPR282'),
(18045, 'Faith', 'Maseko', 'PRG282'),
(17324, 'Atlegang', 'Themba', 'PRG282'),
(13126, 'Siyanda', 'Makhushe', 'PRG361'),
(13540, 'Masego', 'Shay', 'PRG282'),
(13729, 'Jayson', 'Shay', 'PRG361'),
(15850, 'Rebecca', 'Malope', 'PRG282'),
(13836, 'Jacob', 'Madubung', 'WPR262'),
(12406, 'Yasmin', 'Marcinos', 'PRG361'),
(13964, 'Sarah', 'Smith', 'WPR262'),
(17456, 'Mace', 'Cash', 'PRG282'),
(15629, 'Tshepo', 'Modau', 'PRG361'),
(16041, 'Lucy', 'Bronze', 'WPR282'),
(12852, 'Tshiamo', 'Malope', 'PRG282');

SELECT * FROM dbo.Students;