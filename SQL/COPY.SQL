-- DROP SCHEMA dbo;

CREATE SCHEMA dbo;
-- master.dbo.Departamentos definition

-- Drop table

-- DROP TABLE master.dbo.Departamentos;

CREATE TABLE master.dbo.Departamentos (
	ID_Departamento int IDENTITY(1,1) NOT NULL,
	NombreDepartamento nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK_Departamentos PRIMARY KEY (ID_Departamento)
);


-- master.dbo.Habitaciones definition

-- Drop table

-- DROP TABLE master.dbo.Habitaciones;

CREATE TABLE master.dbo.Habitaciones (
	Id_Habitaciones int IDENTITY(1,1) NOT NULL,
	Nombre nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CamasSencillas int NOT NULL,
	CamasDobles int NOT NULL,
	Bano nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Televisor nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Terraza nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Comedor nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Cocina nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	SalaConSofa nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Precio int NOT NULL,
	CONSTRAINT PK_Habitaciones PRIMARY KEY (Id_Habitaciones)
);


-- master.dbo.MSreplication_options definition

-- Drop table

-- DROP TABLE master.dbo.MSreplication_options;

CREATE TABLE master.dbo.MSreplication_options (
	optname sysname COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	value bit NOT NULL,
	major_version int NOT NULL,
	minor_version int NOT NULL,
	revision int NOT NULL,
	install_failures int NOT NULL
);


-- master.dbo.[__EFMigrationsHistory] definition

-- Drop table

-- DROP TABLE master.dbo.[__EFMigrationsHistory];

CREATE TABLE master.dbo.[__EFMigrationsHistory] (
	MigrationId nvarchar(150) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	ProductVersion nvarchar(32) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CONSTRAINT PK___EFMigrationsHistory PRIMARY KEY (MigrationId)
);


-- master.dbo.spt_fallback_db definition

-- Drop table

-- DROP TABLE master.dbo.spt_fallback_db;

CREATE TABLE master.dbo.spt_fallback_db (
	xserver_name varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	xdttm_ins datetime NOT NULL,
	xdttm_last_ins_upd datetime NOT NULL,
	xfallback_dbid smallint NULL,
	name varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	dbid smallint NOT NULL,
	status smallint NOT NULL,
	version smallint NOT NULL
);


-- master.dbo.spt_fallback_dev definition

-- Drop table

-- DROP TABLE master.dbo.spt_fallback_dev;

CREATE TABLE master.dbo.spt_fallback_dev (
	xserver_name varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	xdttm_ins datetime NOT NULL,
	xdttm_last_ins_upd datetime NOT NULL,
	xfallback_low int NULL,
	xfallback_drive char(2) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	low int NOT NULL,
	high int NOT NULL,
	status smallint NOT NULL,
	name varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	phyname varchar(127) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
);


-- master.dbo.spt_fallback_usg definition

-- Drop table

-- DROP TABLE master.dbo.spt_fallback_usg;

CREATE TABLE master.dbo.spt_fallback_usg (
	xserver_name varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	xdttm_ins datetime NOT NULL,
	xdttm_last_ins_upd datetime NOT NULL,
	xfallback_vstart int NULL,
	dbid smallint NOT NULL,
	segmap int NOT NULL,
	lstart int NOT NULL,
	sizepg int NOT NULL,
	vstart int NOT NULL
);


-- master.dbo.spt_monitor definition

-- Drop table

-- DROP TABLE master.dbo.spt_monitor;

CREATE TABLE master.dbo.spt_monitor (
	lastrun datetime NOT NULL,
	cpu_busy int NOT NULL,
	io_busy int NOT NULL,
	idle int NOT NULL,
	pack_received int NOT NULL,
	pack_sent int NOT NULL,
	connections int NOT NULL,
	pack_errors int NOT NULL,
	total_read int NOT NULL,
	total_write int NOT NULL,
	total_errors int NOT NULL
);


-- master.dbo.Clientes definition

-- Drop table

-- DROP TABLE master.dbo.Clientes;

CREATE TABLE master.dbo.Clientes (
	clientes_id int IDENTITY(1,1) NOT NULL,
	Pregunta_Secreta nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Roll nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	customer_fechaNacimiento datetime2 NOT NULL,
	Celular nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Correo nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Id_Departamento int NOT NULL,
	Municipio nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Barrio nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Direccion nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Respuesta_Secreta nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	customer_NombreCompleto nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Auth_Correo nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Auth_Celular nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Contrasena nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	DepartamentoID_Departamento int NULL,
	CONSTRAINT PK_Clientes PRIMARY KEY (clientes_id),
	CONSTRAINT FK_Clientes_Departamentos_DepartamentoID_Departamento FOREIGN KEY (DepartamentoID_Departamento) REFERENCES master.dbo.Departamentos(ID_Departamento)
);
 CREATE NONCLUSTERED INDEX IX_Clientes_DepartamentoID_Departamento ON dbo.Clientes (  DepartamentoID_Departamento ASC  )  
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;


-- master.dbo.Sedes definition

-- Drop table

-- DROP TABLE master.dbo.Sedes;

CREATE TABLE master.dbo.Sedes (
	ID_Sedes int IDENTITY(1,1) NOT NULL,
	Tipo nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Nombre_sede nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Ciudad nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CapacidadSede int NOT NULL,
	NumHabitaciones int NOT NULL,
	HabitacionId int NOT NULL,
	ServiciosSede nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CONSTRAINT PK_Sedes PRIMARY KEY (ID_Sedes),
	CONSTRAINT FK_Sedes_Habitaciones_HabitacionId FOREIGN KEY (HabitacionId) REFERENCES master.dbo.Habitaciones(Id_Habitaciones) ON DELETE CASCADE
);
 CREATE NONCLUSTERED INDEX IX_Sedes_HabitacionId ON dbo.Sedes (  HabitacionId ASC  )  
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;


-- master.dbo.Tarifas definition

-- Drop table

-- DROP TABLE master.dbo.Tarifas;

CREATE TABLE master.dbo.Tarifas (
	ID_Tarifa int IDENTITY(1,1) NOT NULL,
	ID_Sede int NOT NULL,
	NumeroPersonas int NOT NULL,
	NumeroHabitaciones int NOT NULL,
	TipoAlojamiento nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Tarifas int NOT NULL,
	SedeID_Sedes int NOT NULL,
	CONSTRAINT PK_Tarifas PRIMARY KEY (ID_Tarifa),
	CONSTRAINT FK_Tarifas_Sedes_SedeID_Sedes FOREIGN KEY (SedeID_Sedes) REFERENCES master.dbo.Sedes(ID_Sedes) ON DELETE CASCADE
);
 CREATE NONCLUSTERED INDEX IX_Tarifas_SedeID_Sedes ON dbo.Tarifas (  SedeID_Sedes ASC  )  
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;


-- master.dbo.Reservas definition

-- Drop table

-- DROP TABLE master.dbo.Reservas;

CREATE TABLE master.dbo.Reservas (
	ID_Reservas int IDENTITY(1,1) NOT NULL,
	FechaReserva datetime2 NOT NULL,
	FechaLlegada datetime2 NOT NULL,
	FechaSalida datetime2 NOT NULL,
	NumeroPersonas int NOT NULL,
	NumeroNoches int NOT NULL,
	Lavanderia nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	ID_Sede int NOT NULL,
	ID_Cliente int NOT NULL,
	SedeID_Sedes int NOT NULL,
	clientes_id int NOT NULL,
	CONSTRAINT PK_Reservas PRIMARY KEY (ID_Reservas),
	CONSTRAINT FK_Reservas_Clientes_clientes_id FOREIGN KEY (clientes_id) REFERENCES master.dbo.Clientes(clientes_id) ON DELETE CASCADE,
	CONSTRAINT FK_Reservas_Sedes_SedeID_Sedes FOREIGN KEY (SedeID_Sedes) REFERENCES master.dbo.Sedes(ID_Sedes) ON DELETE CASCADE
);
 CREATE NONCLUSTERED INDEX IX_Reservas_SedeID_Sedes ON dbo.Reservas (  SedeID_Sedes ASC  )  
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;
 CREATE NONCLUSTERED INDEX IX_Reservas_clientes_id ON dbo.Reservas (  clientes_id ASC  )  
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;


-- dbo.spt_values source

create view spt_values as
select name collate database_default as name,
	number,
	type collate database_default as type,
	low, high, status
from sys.spt_values;