-- Drop database if it exists
IF EXISTS (SELECT name FROM sys.databases WHERE name = N'EventManagementDB')
BEGIN
    ALTER DATABASE EventManagementDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE EventManagementDB;
END
GO

-- Create database
CREATE DATABASE EventManagementDB;
GO

USE EventManagementDB;
GO

-- Drop table if it exists
IF OBJECT_ID('Events', 'U') IS NOT NULL
    DROP TABLE Events;
GO

-- Create table
CREATE TABLE Events (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(100) NOT NULL,
    Description NVARCHAR(MAX),
    Date DATETIME NOT NULL,
    Location NVARCHAR(200)
);
GO

-- Insert sample data
INSERT INTO Events (Title, Description, Date, Location) VALUES
(N'Annual Conference', N'Technology and innovation conference.', '2025-09-15', N'Tel Aviv'),
(N'Music Festival', N'Outdoor live music event.', '2025-07-10', N'Jerusalem'),
(N'Art Exhibition', N'Modern art showcase.', '2025-08-22', N'Haifa');
GO
