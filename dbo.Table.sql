create table Cars
( 
--Id, BrandId, ColorId, ModelYear, DailyPrice, Description 
  CarId int primary key identity(1,1),
  BrandId varchar(50) not null,
  ColarId varchar(50) not null,
  ModelYear smalldatetime not null,
  DailyPrice money not null,
  Description varchar(50) not null


)
