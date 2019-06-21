IF OBJECT_ID('Movies', 'U') IS NOT NULL
DROP TABLE Movies
GO
-- Create the table in the specified schema
CREATE TABLE Movies
(
   MovieID        INT    NOT NULL   PRIMARY KEY, -- primary key column
   Name      [NVARCHAR](50)  NOT NULL,
   HaveIt  [NVARCHAR](50)  NOT NULL,
);
GO