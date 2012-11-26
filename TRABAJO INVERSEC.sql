CREATE DATABASE INVERSEC_3
USE INVERSEC_3

CREATE TABLE EMPRESA (
codigo int IDENTITY (0,1)PRIMARY KEY not null,
nombre VARCHAR(100)not null,
giro VARCHAR(100) not null,
);

CREATE TABLE USUARIO(
codigo_us int IDENTITY (0,1)PRIMARY KEY not null,
nombre VARCHAR(100)not null,
pass VARCHAR(20)not null,
codigo_emp int FOREIGN KEY REFERENCES EMPRESA(codigo) 
);

CREATE TABLE GIRO
(
codigo int IDENTITY(0,1) not null PRIMARY KEY ,
nombre VARCHAR(60) not null unique
)
CREATE TABLE CLIENTE
(
rut_emp VARCHAR(20) PRIMARY KEY not null,
titular VARCHAR(60) not null,
nombre VARCHAR(100) not null,
codigo_giro int not null FOREIGN KEY REFERENCES GIRO(codigo),
direccion VARCHAR(150)not null,
fono int ,
fax int ,
e_mail VARCHAR(100),

);

CREATE TABLE PROVEEDOR
(
rut_emp VARCHAR(20) PRIMARY KEY not null,
titular VARCHAR(60) not null,
nombre VARCHAR(100) not null,
codigo_giro int not null FOREIGN KEY REFERENCES GIRO(codigo),
direccion VARCHAR(150)not null,
fono int ,
fax int ,
e_mail VARCHAR(100),

);

CREATE TABLE FACTURA
(
num_fact int IDENTITY(0,1) PRIMARY KEY not null ,
guia VARCHAR(7) CHECK (guia IN('Factura','Guia'))not null,
numero_fact int not null ,
fecha DATE not null ,
neto int  ,
iva int  ,
total int  , 
codigo_emp int FOREIGN KEY (codigo_emp) REFERENCES EMPRESA(codigo),
rut_pro VARCHAR (20) FOREIGN KEY REFERENCES PROVEEDOR(rut_emp) ON DELETE CASCADE ON UPDATE CASCADE,
rut_cli VARCHAR (20) FOREIGN KEY REFERENCES CLIENTE(rut_emp) ON DELETE CASCADE ON UPDATE CASCADE

);

CREATE TABLE CLASIFICACION
(
cod_clasif int IDENTITY (0,1 )PRIMARY KEY not null,
nombre VARCHAR (100) not null unique,
nueva_classif int  REFERENCES CLASIFICACION (cod_clasif)
);

CREATE TABLE MARCA
(
cod_marca int IDENTITY(0,1) PRIMARY KEY not null ,
nombre VARCHAR(100) not null unique,
);

CREATE TABLE BODEGA(
cod_bodega int IDENTITY(0,1) PRIMARY KEY not null ,
nombre VARCHAR(100) not null unique ,
);

CREATE TABLE PRODUCTO
(
cod_pro VARCHAR(25) PRIMARY KEY not null ,
nombre VARCHAR(100)	not null,
stock int not null ,
precio int not null,
USprecio int ,
modelo VARCHAR(50),
descripcion VARCHAR(150), 
cod_clasif int not null ,
cod_marca int not null ,
cod_bodega int not null ,
FOREIGN KEY (cod_clasif)REFERENCES CLASIFICACION(cod_clasif),
FOREIGN KEY (cod_marca)REFERENCES MARCA(cod_marca),
FOREIGN KEY (cod_bodega)REFERENCES BODEGA(cod_bodega),
);

CREATE TABLE FACT_PRODUCTO
(
  num_fact int not null,
  cod_pro VARCHAR(25) not null,
  cantidad int not null,
  precio int ,
  descripcion VARCHAR(150),
  FOREIGN KEY (num_fact) REFERENCES FACTURA(NUM_FACT) ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (cod_pro) REFERENCES PRODUCTO(cod_pro) ON DELETE CASCADE ON UPDATE CASCADE
);

INSERT INTO MARCA (nombre) VALUES ('Samsung')
INSERT INTO GIRO(nombre) VALUES ('distribuidora')
INSERT INTO CLASIFICACION (nombre) VALUES ('Repuestos')
INSERT INTO CLASIFICACION (nombre,nueva_classif) VALUES ('Repuestos1',0)
INSERT INTO CLASIFICACION (nombre,nueva_classif) VALUES ('Repuestos11',1)
INSERT INTO CLASIFICACION (nombre,nueva_classif) VALUES ('Repuestos21',2)
INSERT INTO CLASIFICACION (nombre,nueva_classif) VALUES ('Repuestos31',2)
INSERT INTO CLASIFICACION (nombre) VALUES ('Ventilacion')
INSERT INTO BODEGA (nombre) VALUES ('Bodega 1')
INSERT INTO BODEGA (nombre) VALUES ('Bodega 2')
INSERT INTO PRODUCTO(cod_pro,nombre,stock,precio,USprecio,modelo,descripcion,cod_clasif,cod_marca,cod_bodega)VALUES(1,'equipo1',10,50000,500,'atsu','fea',0,0,0)
INSERT INTO PRODUCTO(cod_pro,nombre,stock,precio,USprecio,modelo,descripcion,cod_clasif,cod_marca,cod_bodega)VALUES(2,'equipo2',10,80000,600,'asu','fea',1,0,0)
INSERT INTO PRODUCTO(cod_pro,nombre,stock,precio,USprecio,modelo,descripcion,cod_clasif,cod_marca,cod_bodega)VALUES(887,'equipo9',10,7000,560,'asu','fea',0,0,1)
INSERT USUARIO(nombre,pass)VALUES('j',1)

SELECT * FROM CLASIFICACION
SELECT * FROM MARCA
SELECT * FROM PROVEEDOR
SELECT * FROM CLIENTE
SELECT * FROM FACTURA
SELECT * FROM FACT_PRODUCTO
SELECT * FROM PRODUCTO
SELECT * FROM BODEGA
SELECT * FROM GIRO
SELECT * FROM EMPRESA


INSERT INTO EMPRESA(nombre,giro)VALUES('INVERSEC','Importadora')
INSERT INTO FACTURA(numero_fact,guia,fecha,codigo_emp,neto,iva,total,rut_pro) VALUES (1,'Factura','10-12-2010',0,0,0,0,'12312')
INSERT INTO FACTURA(numero_fact,guia,fecha,codigo_emp,neto,iva,total,rut_pro) VALUES (0,'guia','7-12-2010',0,0,0,0,'12312')
INSERT INTO FACTURA(numero_fact,guia,fecha,codigo_emp,neto,iva,total,rut_cli) VALUES (3,'Factura','12-12-2010',0,0,0,0,'123')


INSERT INTO FACT_PRODUCTO(num_fact,cod_pro,cantidad,precio,descripcion,USprecio)VALUES(6,1,5,2,'asdfasfd',2)
INSERT INTO FACT_PRODUCTO(num_fact,cod_pro,cantidad,precio,descripcion,USprecio)VALUES(6,1,3,2,'asdfasfd',2)

DELETE FROM FACTURA WHERE guia='Factura'
DELETE FROM GIRO WHERE codigo=0
DELETE FROM PROVEEDOR WHERE rut_emp='123'
DELETE FROM FACT_PRODUCTO WHERE num_fact=0

create view H_PROVEEDOR as SELECT p.nombre,rut_emp,f.numero_fact,f.fecha,sum(fb.cantidad)as cantidad,f.total FROM PROVEEDOR p INNER JOIN FACTURA f on  p.rut_emp=f.rut_pro  inner join FACT_PRODUCTO fb on  f.num_fact=fb.num_fact group by p.nombre,p.rut_emp,f.numero_fact,f.fecha,f.total
create view H_PRO as SELECT p.rut_emp,f.numero_fact,f.fecha cantidad,f.total FROM PROVEEDOR p INNER JOIN FACTURA f on  f.rut_pro=p.rut_emp
create view H_CLIENTE as SELECT p.rut_emp,f.numero_fact,f.fecha,sum(fb.cantidad)as cantidad,f.total FROM CLIENTE p INNER JOIN FACTURA f on  f.rut_cli=p.rut_emp  inner join FACT_PRODUCTO fb on  f.num_fact=fb.num_fact group by p.rut_emp,f.numero_fact,f.fecha,f.total
SELECT * FROM H_PROVEEDOR
SELECT * FROM h_pro

SELECT * FROM FACTURA WHERE numero_fact=5555 AND guia='Guia' AND rut_pro='123345-0'

select p.titular,p.rut_emp,p.nombre,g.nombre giro,p.direccion,p.fono,p.fax,p.e_mail FROM PROVEEDOR p,giro g WHERE p.rut_emp='123345-0' AND p.codigo_giro=(SELECT codigo from GIRO WHERE codigo_giro= p.codigo_giro)
select CONVERT(VARCHAR,fecha,105) fecha from FACTURA where numero_fact=5555
select fp.cod_pro,p.nombre,fp.descripcion,fp.cantidad,fp.precio,fp.USprecio from FACT_PRODUCTO fp,PRODUCTO p, PROVEEDOR pro,FACTURA f WHERE fp.num_fact=(select num_fact from factura where numero_fact=5555 and pro.rut_emp='123345-0') AND fp.cod_pro=p.cod_pro AND f.guia='Guia' group by fp.cod_pro,p.nombre,fp.descripcion,fp.cantidad,fp.precio,fp.USprecio

UPDATE FACT_PRODUCTO SET descripcion='aaaaaaaa' where (select rut_pro from factura where numero_fact=5555)='123345-0'AND num_fact=(select num_fact from FACTURA where numero_fact=5555)

Select p.cod_pro,p.nombre,c.nombre clasificacion,m.nombre marca,p.modelo,p.descripcion,p.stock,b.nombre bodega,p.precio,p.USprecio from PRODUCTO p, MARCA m,CLASIFICACION c,BODEGA b WHERE m.cod_marca=p.cod_marca AND c.cod_clasif=p.cod_clasif AND b.cod_bodega=p.cod_bodega


SELECT DISTINCT p.nombre ,f.rut_pro FROM FACTURA f,PROVEEDOR p WHERE f.rut_pro=p.rut_emp 
SELECT p.nombre Nombre,p.rut_emp Rut,f.numero_fact Factura,f.fecha Fecha,SUM(fp.cantidad) Cantidad,f.total Total from proveedor p join FACTURA f on p.rut_emp='123345-0' join FACT_PRODUCTO fp on fp.num_fact=f.num_fact group by p.nombre,p.rut_emp,f.numero_fact,f.fecha,f.total
select descripcion,COUNT(*) from FACT_PRODUCTO where cod_pro=1 group by descripcion
select p.titular,p.rut_emp,p.nombre,g.nombre giro,p.direccion,p.fono,p.fax,p.e_mail FROM PROVEEDOR p join giro g on  g.codigo= p.codigo_giro
SELECT p.cod_pro cod_pro, p.nombre, p.descripcion, p.modelo, c.nombre clasificacion, m.nombre marca, b.nombre bodega FROM PRODUCTO p join clasificacion c on c.cod_clasif=p.cod_clasif join marca m on m.cod_marca=p.cod_marca join bodega b on b.cod_bodega=p.cod_bodega
SELECT cod_clasif from CLASIFICACION WHERE nombre='respuestos'

select p.titular,p.rut_emp,p.nombre,g.nombre giro,p.direccion,p.fono,p.fax,p.e_mail FROM PROVEEDOR p,giro g WHERE p.rut_emp='16909657-0' AND p.codigo_giro=g.codigo

/*SELECT para guia */
select fp.cod_pro,p.nombre,fp.descripcion,fp.cantidad,fp.precio from   FACTURA f join FACT_PRODUCTO fp on f.rut_pro='16909657-0' and f.numero_fact=1 and guia='guia' and fp.num_fact=f.num_fact join PRODUCTO p on fp.cod_pro=p.cod_pro 
SELECT f.rut_pro Rut, p.nombre Nombre ,f.fecha Fecha, f.numero_fact Factura from Proveedor p join factura f on f.guia='guia' and f.rut_pro=p.rut_emp
/*SELECT para historial cliente*/
SELECT p.nombre Nombre,p.rut_emp Rut,f.numero_fact Factura,f.fecha,sum(fb.cantidad) Cantidad,f.total Total FROM CLIENTE p join FACTURA f on p.rut_emp=f.rut_cli join FACT_PRODUCTO fb on fb.num_fact=f.num_fact and f.fecha  between '01-01-2012' and '01-02-2012' group by p.nombre,p.rut_emp,f.numero_fact,f.fecha,f.total 
/*SELECT para historial proveedor*/
SELECT p.nombre Nombre,p.rut_emp Rut,f.numero_fact Factura,f.fecha,sum(fb.cantidad) Cantidad,f.total Total FROM PROVEEDOR p join FACTURA f on p.rut_emp=f.rut_pro join FACT_PRODUCTO fb on fb.num_fact=f.num_fact and f.fecha  between '01-01-2012' and '01-02-2012' group by p.nombre,p.rut_emp,f.numero_fact,f.fecha,f.total 
/*SELECT para inventario por bodega*/
Select p.cod_pro Codigo,p.nombre Nombre,c.nombre Clasificacion,m.nombre Marca,p.modelo Modelo,p.descripcion Descripción,p.stock Stock,b.nombre Bodega,p.precio Precio,p.USprecio US$ from PRODUCTO p join MARCA m on m.cod_marca=p.cod_marca join CLASIFICACION c on c.cod_clasif=p.cod_clasif join BODEGA b on 'bodega 1'=b.nombre and p.cod_bodega=0
/*SELECT para inventario por clasificacion*/
Select p.cod_pro Codigo,p.nombre Nombre,c.nombre Clasificacion,m.nombre Marca,p.modelo Modelo,p.descripcion Descripción,p.stock Stock,b.nombre Bodega,p.precio Precio,p.USprecio US$ from PRODUCTO p join MARCA m on m.cod_marca=p.cod_marca join CLASIFICACION c on p.cod_clasif=(select cod_clasif from clasificacion where nombre='respuestos') and c.nombre='respuestos' join BODEGA b on p.cod_bodega=b.cod_bodega

/*SELECT para ingresos por fecha en historial de productos*/
SELECT p.cod_pro Codigo,p.nombre Nombre,fp.descripcion Descripcion,b.nombre Bodega, CONVERT(VARCHAR,f.fecha,105) Fecha, sum(fp.cantidad) Cantidad from PRODUCTO p join FACT_PRODUCTO fp on p.cod_pro=fp.cod_pro join FACTURA f on f.num_fact=fp.num_fact and f.fecha between '01-01-2012' and '01-02-2012' join bodega b on p.cod_bodega=b.cod_bodega join PROVEEDOR pro on pro.rut_emp=f.rut_pro group by f.fecha,p.cod_pro,p.nombre,fp.descripcion,b.nombre
/*SELECT para salidas por fecha en historial de productos*/
SELECT p.cod_pro Codigo,p.nombre Nombre,fp.descripcion Descripcion,b.nombre Bodega, CONVERT(VARCHAR,f.fecha,105) Fecha, sum(fp.cantidad) Cantidad from PRODUCTO p join FACT_PRODUCTO fp on p.cod_pro=fp.cod_pro join FACTURA f on f.num_fact=fp.num_fact and f.fecha between '01-01-2012' and '01-02-2012' join bodega b on p.cod_bodega=b.cod_bodega join Cliente cli on cli.rut_emp=f.rut_cli group by f.fecha,p.cod_pro,p.nombre,fp.descripcion,b.nombre
/**/
SELECT p.cod_pro Codigo,p.nombre Nombre,fp.descripcion Descripcion,b.nombre Bodega, CONVERT(VARCHAR,f.fecha,105) Fecha, sum(fp.cantidad) Cantidad from PRODUCTO p join FACT_PRODUCTO fp on p.cod_pro=fp.cod_pro and p.nombre='equipo1' join FACTURA f on f.num_fact=fp.num_fact  join bodega b on p.cod_bodega=b.cod_bodega join PROVEEDOR pro on pro.rut_emp=f.rut_pro group by f.fecha,p.cod_pro,p.nombre,fp.descripcion,b.nombre
/**/
SELECT p.cod_pro Codigo,p.nombre Nombre,fp.descripcion Descripcion,b.nombre Bodega, CONVERT(VARCHAR,f.fecha,105) Fecha, sum(fp.cantidad) Cantidad from PRODUCTO p join FACT_PRODUCTO fp on p.cod_pro=fp.cod_pro and p.nombre='equipo2' join FACTURA f on f.num_fact=fp.num_fact join bodega b on p.cod_bodega=b.cod_bodega join Cliente cli on cli.rut_emp=f.rut_cli group by f.fecha,p.cod_pro,p.nombre,fp.descripcion,b.nombre

UPDATE PRODUCTO set precio=