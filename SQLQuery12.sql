use marathon

CREATE TABLE KitStock 
( 
k_id int NOT NULL PRIMARY KEY IDENTITY(1,1),
KitName nchar(50) NOT NULL,
iCount int
)