CREATE DATABASE Lienzos
GO
Use Lienzos
go
create table Tab_Roles(
	Id_Rol int IDENTITY(1,1) primary key,
	Nombre_Rol varchar(25),
	Descripcion varchar(100),
);
CREATE TABLE Tab_Permisos(
    ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL, 
	Modulo VARCHAR(20) NOT NULL,
    Accion VARCHAR(27) NULL,
    Id_Rol INT NOT NULL,
	CONSTRAINT Fk_PERMISOS_ROLES FOREIGN KEY(Id_Rol) REFERENCES Tab_Roles(Id_Rol)
);
CREATE TABLE Tab_Usuarios(
	ID_Usuario INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	Nombre VARCHAR(25) NOT NULL,
	Primer_Apellido VARCHAR(25) NOT NULL,
	Segundo_Apellido VARCHAR(25) NOT NULL,
	Nombre_Usuario VARCHAR(25) NOT NULL,
	Genero INT NOT NULL,
	Id_Rol int NOT NULL,
	Contrasena VARCHAR(MAX) NOT NULL,
	Estado INT NOT NULL,
	CONSTRAINT Fk_USUARIOS_ROLES FOREIGN KEY(Id_Rol) REFERENCES Tab_Roles(Id_Rol),
);
CREATE TABLE Tab_Clientes(
	ID_Cliente INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	Nombre VARCHAR(25) NOT NULL,
	Primer_Apellido VARCHAR(25) NOT NULL,
	Segundo_Apellido VARCHAR(25) NOT NULL,
	Nombre_Usuario VARCHAR(25) NOT NULL,
	Genero INT NOT NULL
);
CREATE TABLE Tab_Tipo_Productos(
	ID_Tipo_Producto INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	Nombre VARCHAR(25)NOT NULL,
	Descripcion varchar(100)NULL
);
CREATE TABLE Tab_Productos(
	ID_Producto INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	Nombre VARCHAR(25)NOT NULL,
	Descripcion VARCHAR(100)NULL,
	ID_Tipo_Producto INT NOT NULL,
	Precio DECIMAL NOT NULL,
	Cantidad INT NOT NULL,
	CONSTRAINT Fk_PRODUCTOS_TIPO FOREIGN KEY(ID_Tipo_Producto) REFERENCES Tab_Tipo_Productos(ID_Tipo_Producto),
);
CREATE TABLE Tab_Venta(
	ID_Usuario INT NOT NULL,
	ID_Cliente INT NOT NULL,
	Tipo_pago VARCHAR(25) NOT NULL,
	Numero_factura INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	Fecha_venta DATETIME NOT NULL,
	Total FLOAT NOT NULL,
	CONSTRAINT Fk_VENTAS_USUARIOS FOREIGN KEY(Id_Usuario) REFERENCES Tab_Usuarios(Id_Usuario),
	CONSTRAINT Fk_VENTAS_CLIENTES FOREIGN KEY(ID_Cliente) REFERENCES Tab_Clientes(ID_Cliente)
);

CREATE TABLE Tab_Venta_detallada(
	Numero_factura INT NOT NULL,
	ID_Producto INT NOT NULL,
	Linea INT NOT NULL,
	PRIMARY KEY(ID_Producto,Linea),
	CONSTRAINT Fk_DETALLE_VENTAS FOREIGN KEY(Numero_factura) REFERENCES Tab_Venta(Numero_factura),
	CONSTRAINT Fk_DETALLE_PRODUCTOS FOREIGN KEY(ID_Producto) REFERENCES Tab_Productos(ID_Producto),
);

CREATE TABLE Tab_Bitacora_Sesiones(
    codigo_ingreso_salida int IDENTITY(1,1) primary key, 
    fecha_hora_ingreso DATETIME NOT NULL,
    fecha_hora_salida DATETIME NULL,
    Id_Usuario INT,
	CONSTRAINT Fk_SESIONES_USUARIOS FOREIGN KEY(Id_Usuario) REFERENCES Tab_Usuarios(Id_Usuario)
);

CREATE TABLE Tab_Bitacora_Movimientos(
   codigo_movimiento_usuario int IDENTITY(1,1) primary key, 
   fecha_hora_movimiento DATETIME NOT NULL,
   tipo_movimiento varchar(50),
   modulo VARCHAR(20),
   Id_Usuario INT,
   CONSTRAINT Fk_MOVIMIENTOS_USUARIOS FOREIGN KEY(Id_Usuario) REFERENCES Tab_Usuarios(Id_Usuario)
);