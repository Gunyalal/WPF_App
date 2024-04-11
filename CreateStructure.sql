create table dbo.RDOGOVOR (
  dog_no int identity primary key,
  dog_date date,
  update_time date
);

INSERT INTO dbo.RDOGOVOR
( dog_date, update_time)
VALUES('2024-01-01', '2024-04-10');
INSERT INTO dbo.RDOGOVOR
(dog_date, update_time)
VALUES('2020-02-01', '2024-02-15');
INSERT INTO dbo.RDOGOVOR
(dog_date, update_time)
VALUES('2006-05-03', '2006-05-03');
INSERT INTO dbo.RDOGOVOR
(dog_date, update_time)
VALUES('2004-05-03', '2006-05-03');
INSERT INTO dbo.RDOGOVOR
(dog_date, update_time)
VALUES('2000-01-01', '2003-01-01');
