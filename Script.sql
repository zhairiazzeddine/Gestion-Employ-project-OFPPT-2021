create database  Gestion_employé
on (name='Gestion_employé_mdf',filename='D:\Gestion_employé database\Gestion_employé_mdf.mdf', size=10)
log on (name='Gestion_employé_ldf',filename='D:\Gestion_employé database\Gestion_employé_ldf.ldf', size=4)
use Gestion_employé
create table ServiceE( Code varchar(5) primary key, Libellé varchar(50) not null)
create table Employé( Matricule varchar(5) primary key, Nom varchar(50)not null, Prénom varchar(50)not null, Date_naissance date, Grade varchar(50)not null, Echelle int, Code_service varchar(5) foreign key references ServiceE(Code) )
create table Congé (Matricule varchar(5) foreign key references Employé(Matricule), Date_congé Date not null, Type_congé varchar(50) not null, Durée int not null, CONSTRAINT PK_MA_DC primary key (Matricule,Date_congé))




INSERT INTO ServiceE values ('S1','Resource Humains'),('S2','Service informatique')
declare @i int=2

while(@i<=20)
begin
insert into ServiceE values ('S'+convert(varchar,@i),'Service'+convert(varchar,@i))
set @i=@i+1

end

select * from ServiceE


sp_addumpdevice 'Disk','Unité1','D:\Gestion_employé database\Unité1.bak'

backup database Gestion_employé to Unité1 with init 
restore database from Unité1 with replace


declare @CD varchar(5), @Lib varchar(50) 

declare  C cursor for select * from ServiceE
open C
fetch  from C into @CD,@Lib
while (@@FETCH_STATUS=0)
begin
fetch  from C into @CD,@Lib
print 'Le Code Service Est : '+convert(varchar,@CD)+'      Le Nom : '+convert(varchar,@Lib)
end
close C
deallocate C



create view vue_statique_type
as
select Type_congé,Count(*) as nbre,MIN(Durée)as minimum, MAX(Durée) as maximum, AVG(Durée)as moyenne, SUM(Durée) as total from Congé
Group By Type_congé

use Gestion_employé
select * from vue_statique_type

create view vue_durée_total_par_année_par_mois 
as
select datepart(yy,date_congé) as année ,datepart(mm,date_congé) as mois, sum(durée) as total  
from Congé  
group by datepart(yy,date_congé) ,datepart(mm,date_congé)
select * from vue_durée_total_par_année_par_mois