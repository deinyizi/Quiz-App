CREATE TABLE [User] (
	[Id] INT PRIMARY KEY NOT NULL IDENTITY,
	[Username] VARCHAR(100) NOT NULL UNIQUE, 
	[Password] VARCHAR(100) NOT NULL, 
	[Email] VARCHAR(100) NOT NULL
)

CREATE TABLE [QuestionTable] (
	[Id] INT PRIMARY KEY NOT NULL IDENTITY, 
	[Subject] VARCHAR(100) NOT NULL, 
	[QuestionStr] VARCHAR(1000) NOT NULL, 
	[Option1] VARCHAR(500) NOT NULL, 
	[Option2] VARCHAR(500) NOT NULL, 
	[Option3] VARCHAR(500) NOT NULL, 
	[Option4] VARCHAR(500) NOT NULL,
	[Answer] VARCHAR(500) NOT NULL
)

SELECT * FROM [User]

INSERT INTO [User] ([Username], [Password]) VALUES ('admin', 'admin') 

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Geography', 'What is the capital of Canada?', 'Toronto', 'Manitoba', 'Ottawa', 'British Columbia', 'Ottawa')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Geography', 'What is the name of the largest ocean in the world?', 'The Pacific Ocean', 'The Southern Ocean', 'The Indian Ocean', 'The Atlantic Ocean', 'The Pacific Ocean')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Geography', 'What country are the Great Pyramids of Giza located in? ', 'Asia', 'Egypt ', 'North America', 'South America', 'Egypt ')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Geography', 'How many States does the United States consist of?  ', '50', '30 ', '70', '20', '50 ')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Geography', 'What country lies above Mexico?  ', 'Ukraine', 'Nigeria ', 'The United Kingdom ', 'The United States of America ', 'The United States of America  ')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Geography', 'What is the coldest place on Earth?  ', 'Antarctica ', 'Canada ', 'United Kindom', 'Nigeria', 'Antarctica  ')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Geography', 'What planet is closest to Earth?  ', 'Saturn', 'Jupiter', 'Venus', ' Mars', 'Venus ')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Geography', 'How many countries are there in Africa?  ', '54', '25', '30', '66', '54 ')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Geography', 'What place is known as the largest micro-continent? ', 'Asia', 'Ireland', 'Mauritus', 'Madagascar', 'Madagascar ')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Geography', 'Pierre is the capital of what US state? ', 'South Dakota', 'Arizona ', 'New York', 'Colorado', 'South Dakota ')



INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('History', ' How many U.S. presidents have been assassinated?', 'Six', 'five', 'Two', 'Four', 'Four')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('History', 'When did Mao Zedong come to power?', '1970', '1949', '2000', '1940', '1949')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('History', 'The ancient Egyptians worshiped dung beetle?', 'Aquq', 'The scarab', 'Sobba', 'Bobt', 'The scarab')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('History', ' Which Russian astronaut was the first man to conduct a spacewalk?', 'Quey Frady', 'Alexey Leonov', 'Hebrew Jock', 'Susan Max', 'Alexey Leonov')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('History', 'What year did the War of 1812 end?', '1910', '1815', '2003', '1867', '1815')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('History', 'The ancient Egyptians worshiped dung beetle?', 'Aquq', 'The scarab', 'Sobba', 'Bobt', 'The scarab')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('History', 'The ancient Egyptians worshiped dung beetle?', 'Aquq', 'The scarab', 'Sobba', 'Bobt', 'The scarab')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('History', 'The ancient Egyptians worshiped dung beetle?', 'Aquq', 'The scarab', 'Sobba', 'Bobt', 'The scarab')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('History', 'The ancient Egyptians worshiped dung beetle?', 'Aquq', 'The scarab', 'Sobba', 'Bobt', 'The scarab')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('History', 'The ancient Egyptians worshiped dung beetle?', 'Aquq', 'The scarab', 'Sobba', 'Bobt', 'The scarab')



INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Current Affair', 'Who is the current Governor of Central Bank of Nigeria ', 'Odeinyi ', 'Godwin Emefiele', 'James Vivk', 'Peterson', 'Godwin Emefiele')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Current Affair', 'What is a 70 years anniversary called?', 'Platinum', 'Africa', 'North America', 'Vmerica', 'Platinum')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Current Affair', 'Who is the current Senate President of Nigeria?', 'Agrop Hewd', 'Ahmed Ibrahim Lawan', 'kolode Qury', 'Zazic Geogre', 'Ahmed Ibrahim Lawan')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Current Affair', 'Which continent is the smallest in the world?', 'Asia', 'Africa', 'Australia', 'South America', 'Australia')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Current Affair', 'Who formed the first political party in Nigeria?', 'Agrop Gvvc', 'Lawan', 'kolode', 'Herbert Macaulay', 'Herbert Macaulay')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Current Affair', 'Who is the current Senate President of Nigeria?', 'Agrop Hewd', 'Ahmed Ibrahim Lawan', 'kolode Qury', 'Zazic Geogre', 'Ahmed Ibrahim Lawan')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Current Affair', 'Who is the current Senate President of Nigeria?', 'Agrop Hewd', 'Ahmed Ibrahim Lawan', 'kolode Qury', 'Zazic Geogre', 'Ahmed Ibrahim Lawan')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Current Affair', 'Who is the current Senate President of Nigeria?', 'Agrop Hewd', 'Ahmed Ibrahim Lawan', 'kolode Qury', 'Zazic Geogre', 'Ahmed Ibrahim Lawan')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Current Affair', 'Who is the current Senate President of Nigeria?', 'Agrop Hewd', 'Ahmed Ibrahim Lawan', 'kolode Qury', 'Zazic Geogre', 'Ahmed Ibrahim Lawan')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Current Affair', 'Who is the current Senate President of Nigeria?', 'Agrop Hewd', 'Ahmed Ibrahim Lawan', 'kolode Qury', 'Zazic Geogre', 'Ahmed Ibrahim Lawan')


INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Biology', 'What is the white substance contained in the fibre cells?', 'Frezeona', 'Cellulose', 'Skin', 'Germs', 'Cellulose')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Biology', 'What are the groups of sporangia borne on the fern leaves called?', 'Hezu', 'Sori', 'Venzea', 'Pazeu', 'Sori.')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Biology', ' Which of the following shows coiled RNA strand and capsomeres?', 'Poliovirus ', 'Tobacco masaic virus', 'Measles virus', 'Retrovirus', 'Tobacco masaic virus')


INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Biology', ' The motile bacteria are able to move by:', 'Fimbriae', 'Flagella ', 'Cilia ', 'Pili', 'Flagella ')


INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Biology', ' An example of an edible underground stem is:', 'Carrot  ', 'Groundnut ', 'Sweet potato', 'Potato', 'Potato')


INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Biology', ' Which of the following shows coiled RNA strand and capsomeres?', 'Poliovirus ', 'Tobacco masaic virus', 'Measles virus', 'Retrovirus', 'Tobacco masaic virus')


INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Biology', ' Which of the following shows coiled RNA strand and capsomeres?', 'Poliovirus ', 'Tobacco masaic virus', 'Measles virus', 'Retrovirus', 'Tobacco masaic virus')


INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Biology', ' Which of the following shows coiled RNA strand and capsomeres?', 'Poliovirus ', 'Tobacco masaic virus', 'Measles virus', 'Retrovirus', 'Tobacco masaic virus')

INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Biology', ' Which of the following shows coiled RNA strand and capsomeres?', 'Poliovirus ', 'Tobacco masaic virus', 'Measles virus', 'Retrovirus', 'Tobacco masaic virus')


INSERT INTO [QuestionTable] ([Subject], [QuestionStr], [Option1], [Option2], [Option3], [Option4], [Answer])
VALUES 
('Biology', ' Which of the following shows coiled RNA strand and capsomeres?', 'Poliovirus ', 'Tobacco masaic virus', 'Measles virus', 'Retrovirus', 'Tobacco masaic virus')


SELECT * FROM [QuestionTable] WHERE subject='Geography'

DELETE FROM [QuestionTable];