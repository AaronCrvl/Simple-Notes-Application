create table Note
(
	ID_NOTE INT PRIMARY KEY,
	TITLE VARCHAR(40),
	CONTENT VARCHAR(1000),
	CREATION_DATE DATETIME,
	ACTIVE BIT
)

INSERT INTO NOTE (ID_NOTE, TITLE, CONTENT, CREATION_DATE, ACTIVE)
VALUES (1, 'Hi!', 'Feel free to try', getdate(), 1)