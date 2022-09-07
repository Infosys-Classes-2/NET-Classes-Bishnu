
-- Create new table
CREATE TABLE [dbo].[Person1]
(
	[Id] INT NOT NULL identity PRIMARY KEY, 
    [Name] VARCHAR(50) NULL, 
    [Address] VARCHAR(50) NULL
)

-- Insert data into table
INSERT INTO Person (Name, Address)
VALUES ('Jenny Maharjan', 'Ktm, Nepal');
INSERT INTO Person (Name, Address)
VALUES ('Bishnu Rawal', 'Ktm, Nepal');

-- Query
select * from person

-- Foreign Key
