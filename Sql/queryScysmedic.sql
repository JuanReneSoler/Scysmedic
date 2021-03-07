
--drop database ScysmedicDB
--create database ScysmedicDB;

use ScysmedicDB;
go

create schema [Repository]; 
go
create schema [Shared];
go
create schema [Farmacias]; 
go
create schema [Laboratorios]; 
go
create schema [Hospitales]; 
go
create schema [App]; 
go

--create schema [Identity]

--ALTER SCHEMA [Identity] TRANSFER [dbo].AspNetUsers;
--ALTER SCHEMA [Identity] TRANSFER [dbo].[__EFMigrationsHistory]
--ALTER SCHEMA [Identity] TRANSFER [dbo].[AspNetRoleClaims]
--ALTER SCHEMA [Identity] TRANSFER [dbo].[AspNetRoles]
--ALTER SCHEMA [Identity] TRANSFER [dbo].[AspNetUserClaims]
--ALTER SCHEMA [Identity] TRANSFER [dbo].[AspNetUserLogins]
--ALTER SCHEMA [Identity] TRANSFER [dbo].[AspNetUserRoles]
--ALTER SCHEMA [Identity] TRANSFER [dbo].[AspNetUserTokens]
--ALTER SCHEMA [Identity] TRANSFER [Identity].[AspNetUsers]

create table [Repository].Documento(
	Id int not null primary key identity(1,1),
	Nombre varchar(max),
	Formato varchar(max),
	Path text not null,
	FechaCarga datetime2 not null,
); 
go

create table [Shared].TipoDocumento(
	Id int not null primary key identity(1,1),
	Descripcion varchar(50)
); 
go

create table [Shared].TipoEmpresa(
	Id int not null primary key identity(1,1),
	Siglas varchar(10) not null,
	Descripcion varchar(100)
); 
go

create table [Shared].TipoPago(
	Id int not null primary key identity(1,1),
	Descripcion varchar(10) not null
); 
go

create table [Shared].MotivoDevolucion(
	Id int not null primary key identity(1,1),
	Descripcion varchar(max) not null
); 
go

create table [Shared].Banco(
	Id int not null primary key identity(1,1),
	Siglas varchar(10) not null,
	Nombre varchar(100) not null,
	Descripcion text,
	Rnc varchar(30),
	Fecha datetime2 not null
); 
go

create table [Shared].TipoTargeta(
	Id int not null primary key identity(1,1),
	Nombre varchar(50) not null
); 
go

create table [Shared].Aseguradora(
	Id int not null primary key identity(1,1),
	Nombre varchar(100) not null
); 
go

create table [Farmacias].TipoMedicamento(
	Id int not null primary key identity(1,1),
	Descripcion varchar(100) not null
); 
go

create table [Farmacias].Farmacia(
	Id int not null primary key identity(1,1),
	Nombre varchar(100) not null,
	TipoEmpresaId int not null
); 
go

create table [Farmacias].FarmaciaCargo(
	Id int not null primary key identity(1,1),
	Descripcion varchar(100)
); 
go

create table [Farmacias].FarmaciaEmpleado(
	Id int not null primary key identity(1,1),
	Nombre varchar(100) not null,
	Apellido varchar(100) not null,
	TipoDocId int not null foreign key references Shared.TipoDocumento(Id),
	DocumentoIdentidad varchar(20),
	Sexo varchar(1) not null,
	FechaNacimiento datetime2 not null,
	UserId nvarchar(450)
); 
go

create table [Farmacias].FarmaciaEmpleadoHistorial(
	Id int not null primary key identity(1,1),
	EmpleadoId int not null foreign key references Farmacias.FarmaciaEmpleado(Id),
	FechaEntrada datetime2 not null,
	CargoId int not null foreign key references Farmacias.FarmaciaCargo(Id),
	FarmaciaId int not null foreign key references Farmacias.Farmacia(Id)
); 
go

create table [Farmacias].Suplidor(
	Id int not null primary key identity(1,1),
	Nombre varchar(100) not null,
	TipoEmpresaId int not null foreign key references Shared.TipoEmpresa(Id),
	Direccion varchar(max) not null,
	UbicacionLatitud varchar(100) not null,
	UbicacionLongitud varchar(100) not null,
	FechaInicio datetime2 not null
); 
go

create table [Farmacias].Medicamento(
	Id int not null primary key identity(1,1),
	Nombre varchar(100) not null,
	Descripcion text not null,
	TipoMedicamentoId int not null foreign key references Farmacias.TipoMedicamento(Id),
	Foto int foreign key references Repository.Documento(Id),
	FarmaciaId int not null foreign key references Farmacias.Farmacia(Id)
); 
go

create table [Farmacias].MedicamentoHostorial(
	Id int not null primary key identity(1,1),
	MedicamentoId int not null foreign key references Farmacias.Medicamento(Id),
	SuplidorId int not null foreign key references Farmacias.Suplidor(Id),
	FechaCompra datetime2 not null,
	FechaVencimiento datetime2 not null,
	CantidadAdquirida int not null,
	CantidadActual int not null,
	PrecioCompra int not null,
	PrecioVenta int not null,
	Itebis int not null,
); 
go

create table [Laboratorios].LaboratorioCargo(
	Id int not null primary key identity(1,1),
	Descripcion varchar(100)
); 
go

create table [Laboratorios].Laboratorio(
	Id int not null primary key identity(1,1),
	Nombre varchar(100),
	TipoEmpresaId int not null foreign key references Shared.TipoEmpresa(Id),
	Direccion varchar(max) not null,
	UbicacionLatitud varchar(100) not null,
	UbicacionLongitud varchar(100) not null
); 
go

create table [Laboratorios].LaboratorioEmpleado(
	Id int not null primary key identity(1,1),
	Nombre varchar(100) not null,
	Apellido varchar(100) not null,
	TipoDocId int not null foreign key references Shared.TipoDocumento(Id),
	DocumentoIdentidad varchar(20),
	Sexo varchar(1) not null,
	FechaNacimiento datetime2 not null,
	UserId nvarchar(450)
); 
go

create table [Laboratorios].LaboratorioEmpleadoHistorial(
	Id int not null primary key identity(1,1),
	EmpleadoId int not null foreign key references Laboratorios.LaboratorioEmpleado(Id),
	FechaEntrada datetime2 not null,
	CargoId int not null foreign key references Laboratorios.LaboratorioCargo(Id),
	LaboratorioId int not null foreign key references Laboratorios.Laboratorio(Id)
); 
go

create table [Hospitales].HospitalCargo(
	Id int not null primary key identity(1,1),
	Descripcion varchar(100)
); 
go

create table [Hospitales].Hospital(
	Id int not null primary key identity(1,1),
	Nombre varchar(100),
	TipoEmpresaId int not null foreign key references Shared.TipoEmpresa(Id),
	Direccion varchar(max),
	UbicacionLongitud int not null,
	UbicacionLatitud int not null,
); 
go

create table [Hospitales].HospitalEmpleado(
	Id int not null primary key identity(1,1),
	Nombre varchar(100) not null,
	Apellido varchar(100) not null,
	TipoDocId int not null foreign key references Shared.TipoDocumento(Id),
	DocId varchar(20),
	Sexo varchar(1) not null,
	FechaNacimiento datetime2 not null,
	UserId nvarchar(450)
); 
go

create table [Hospitales].HospitalEmpleadoHistorial(
	Id int not null primary key identity(1,1),
	EmpleadoId int not null foreign key references Hospitales.HospitalEmpleado(Id),
	FechaEntrada datetime2 not null,
	CargoId int not null foreign key references Hospitales.HospitalCargo(Id),
	LaboratorioId int not null foreign key references Hospitales.Hospital(Id)
); 
go

create table [Hospitales].Especialidad(
	Id int not null primary key identity(1,1),
	Descripcion varchar(100) not null
); 
go

create table [Hospitales].HospitalEmpleadoEspecialidad(
	Id int not null primary key identity(1,1),
	EmpleadoId int not null foreign key references Hospitales.HospitalEmpleado(Id),
	EspecialidadId int not null foreign key references Hospitales.Especialidad(Id)
); 
go

create table [App].FarmaciaUser(
	Id int not null primary key identity(1,1),
	FarmaciaId int not null foreign key references Farmacias.Farmacia(Id),
	UserId nvarchar(450),-- foreign key references [Identity].AspNetUsers(Id),
	FechaAfiliacion datetime2 not null
); 
go

create table [App].LaboratorioUser(
	Id int not null primary key identity(1,1),
	LaboratorioId int not null foreign key references Laboratorios.Laboratorio(Id),
	UserId nvarchar(450),-- foreign key references [Identity].AspNetUsers(Id),
	FechaAfiliacion datetime2 not null
); 
go

create table [App].HospitalUser(
	Id int not null primary key identity(1,1),
	HospitalId int not null foreign key references Hospitales.Hospital(Id),
	UserId nvarchar(450),-- foreign key references [Identity].AspNetUsers(Id),
	FechaAfiliacion datetime2 not null
); 
go

create table [App].HospitalEmpleadoUser(
	Id int not null primary key identity(1,1),
	HospitalId int not null foreign key references App.HospitalUser(Id),
	EmpleadoId int not null foreign key references Hospitales.HospitalEmpleado(Id),
	EspecialidadId int not null foreign key references Hospitales.HospitalEmpleadoEspecialidad(Id),
	FechaAfiliacion datetime2 not null
); 
go

create table [App].Receta(
	Id int not null primary key identity(1,1),
	FechaCreacion datetime2 not null,
	UserId nvarchar(450),-- foreign key references [Identity].AspNetUsers(Id),
	EmpleadoId int not null foreign key references Hospitales.HospitalEmpleado(Id)
); 
go

create table [App].RecetaDetalle(
	Id int not null primary key identity(1,1),
	RecetaId int not null foreign key references App.Receta(Id),
	MedicamentoId int not null foreign key references Farmacias.Medicamento(Id),
	Cantidad int not null,
	Aplicacion varchar(max) not null
); 
go

create table [App].Resultado(
	Id int not null primary key identity(1,1),
	UserId nvarchar(450),-- foreign key references [Identity].AspNetUsers(Id),
	LaboratorioId int not null foreign key references App.LaboratorioUser(Id),
	DocumentoId int not null foreign key references Repository.Documento(Id),
	FechaCreacion datetime2 not null,
); 
go

create table [App].Compra(
	Id int not null primary key identity(1,1),
	UserId nvarchar(450),-- foreign key references [Identity].AspNetUsers(Id),
	FarmaciaId int not null foreign key references App.FarmaciaUser(Id),
	RecetaId int not null foreign key references App.Receta(Id),
	FechaCompra datetime2 not null,
	CodigoVerificacion nvarchar(450) not null,
	PrecioPagar int not null,
	TipoPago int not null foreign key references Shared.TipoPago(Id)
); 
go

create table [App].CompraDetalle(
	Id int not null primary key identity(1,1),
	CompraId int not null foreign key references App.Compra(Id),
	MedicamentoRecetaId int not null foreign key references App.RecetaDetalle(Id),
	Cantidad int not null,
	PrecionCompra int not null,
	Itebis int not null,
	MotivoDevolucionId int not null foreign key references Shared.MotivoDevolucion(Id),
	Descripcion varchar(max)
); 
go

create table [App].Citas(
	Id int not null primary key identity(1,1),
	UserId nvarchar(450),-- foreign key references [Identity].AspNetUsers(Id),
	HospitalId int not null foreign key references App.HospitalUser(Id),
	EmpleadoId int not null foreign key references App.HospitalEmpleadoUser(Id),
	Fecha datetime2 not null
); 
go

create table [App].InformacionPersonal(
	Id int not null primary key identity(1,1),
	UserId nvarchar(450),-- foreign key references [Identity].AspNetUsers(Id),
	Nombre varchar(100) not null,
	Apellido varchar(100) not null,
	FechaNacimiento datetime2 not null,
	DocId varchar(20),
	Mail varchar(256) not null
); 
go

create table [App].TargetaVinculadas(
	Id int not null primary key identity(1,1),
	UserId nvarchar(450),-- foreign key references [Identity].AspNetUsers(Id),
	Numero varchar(25) not null,
	BancoId int not null foreign key references Shared.Banco(Id),
	TipoTargetaId int not null foreign key references Shared.TipoTargeta(Id),
	Fecha datetime2 not null
); 
go

create table [App].SeguroHistorial(
	Id int not null primary key identity(1,1),
	UserId nvarchar(450),-- foreign key references [Identity].AspNetUsers(Id),
	NumeroSeguro varchar(25) not null,
	SeguroId int not null foreign key references Shared.Aseguradora(Id),
	Fecha datetime2 not null,
	DocumentoId int not null foreign key references Repository.Documento(Id)
); 
go
