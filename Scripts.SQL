USE master;
ALTER DATABASE Proyecto_Final SET single_user with rollback immediate

DROP DATABASE IF EXISTS Proyecto_Final;
CREATE DATABASE Proyecto_Final;
USE Proyecto_Final;



---------
-- DB Diseno
---------

CREATE TABLE [ANIMALES] (
  [id] int PRIMARY KEY NOT NULL,
  [nombre] varchar(255) NOT NULL,
  [especie] varchar(255) NOT NULL,
  [raza] varchar(255) NOT NULL,
  [edad] int NOT NULL,
  [estado_salud] varchar(255) NOT NULL,
  [refugio_ID] int NOT NULL,
  [imagen_URL] varchar(255) NOT NULL
)
GO

CREATE TABLE [ADOPCIONES] (
  [id] int IDENTITY(1,1) PRIMARY KEY NOT NULL,
  [animal_ID] int NOT NULL,
  [refugio_ID] int,
  [adoptante_ID] int NOT NULL,
  [fecha] datetime
)
GO

CREATE TABLE [REFUGIOS] (
  [id] int PRIMARY KEY NOT NULL,
  [nombre] varchar(255) NOT NULL,
  [direccion] varchar(255) NOT NULL,
  [capacidad] int NOT NULL,
  [cantidad_anim] int NOT NULL,
  [contacto_ID] int NOT NULL,
  [telefono] varchar(255) NOT NULL,
  [email] varchar(255)  NOT NULL
)
GO

CREATE TABLE [VOLUNTARIOS] (
  [id] int IDENTITY(1,1) PRIMARY KEY NOT NULL,
  [voluntario_ID] int NOT NULL,
  [disponibilidad] varchar(255) NOT NULL
)
GO



CREATE TABLE [USUARIOS] (
  [id] int PRIMARY KEY NOT NULL,
  [nombre] varchar(255) NOT NULL,
  [apellido] varchar(255) NOT NULL,
  [edad] int NOT NULL,
  [telefono] varchar(255) NOT NULL,
  [email] varchar(255) NOT NULL,
  [usuario] varchar(255) NOT NULL,
  [password] varchar(255) NOT NULL,
  [role] int NOT NULL,
  [estado] bit NOT NULL

)
GO

CREATE TABLE [ROLES] (
  [id] int PRIMARY KEY NOT NULL,
  [role] varchar(255) NOT NULL
)
GO

CREATE TABLE [DONACIONES] (
  [id] int IDENTITY(1,1) PRIMARY KEY NOT NULL,
  [refugio_ID] int NOT NULL,
  [donante_ID] int NOT NULL,
  [fecha] datetime NOT NULL,
  [cantidad] int NOT NULL
)
GO

CREATE TABLE [ERRORES] (
  [id] int PRIMARY KEY NOT NULL,
  [error] varchar(255) NOT NULL
)
GO

CREATE TABLE [TESTIMONIOS] (
  [id] int IDENTITY(1,1) PRIMARY KEY NOT NULL,
  [usuario_id] int NOT NULL,
  [mensaje] varchar(255) NOT NULL
)
GO

CREATE TABLE [IMAGENES] (
  [id] int PRIMARY KEY NOT NULL,
  [usuario_id] int NOT NULL,
  [nombre] varchar(255) NOT NULL,
  [extension] varchar(255) NOT NULL,
  [url] varchar(255) NOT NULL,
  [imagen] varbinary(MAX) NOT NULL
)
GO

ALTER TABLE [ANIMALES] ADD FOREIGN KEY ([refugio_ID]) REFERENCES [REFUGIOS] ([id])
GO

ALTER TABLE [VOLUNTARIOS] ADD FOREIGN KEY ([voluntario_ID]) REFERENCES [USUARIOS] ([id])
GO

ALTER TABLE [DONACIONES] ADD FOREIGN KEY ([donante_ID]) REFERENCES [USUARIOS] ([id])
GO

ALTER TABLE [ADOPCIONES] ADD FOREIGN KEY ([animal_ID]) REFERENCES [ANIMALES] ([id])
GO

ALTER TABLE [ADOPCIONES] ADD FOREIGN KEY ([refugio_ID]) REFERENCES [REFUGIOS] ([id])
GO

ALTER TABLE [ADOPCIONES] ADD FOREIGN KEY ([adoptante_ID]) REFERENCES [USUARIOS] ([id])
GO

ALTER TABLE [DONACIONES] ADD FOREIGN KEY ([refugio_ID]) REFERENCES [REFUGIOS] ([id])
GO

ALTER TABLE [REFUGIOS] ADD FOREIGN KEY ([contacto_ID]) REFERENCES [USUARIOS] ([id])
GO

ALTER TABLE [USUARIOS] ADD FOREIGN KEY ([role]) REFERENCES [ROLES] ([id])
GO

ALTER TABLE [TESTIMONIOS] ADD FOREIGN KEY ([usuario_id]) REFERENCES [USUARIOS] ([id])
GO

ALTER TABLE [IMAGENES] ADD FOREIGN KEY ([usuario_id]) REFERENCES [USUARIOS] ([id])
GO

--------
-- Roles
---------

-- Registro 1
INSERT INTO ROLES (id, role) 
VALUES (1, 'Admin');

-- Registro 2
INSERT INTO ROLES (id, role) 
VALUES (2, 'User');

--------
-- Usuarios
---------

-- Registro 1
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role,estado) 
VALUES (1001, 'Juan', 'Perez', 28, '555-123-4567', 'juanperez@email.com', 'juanp', 'mypassword1', 1,1);

-- Registro 2
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role,estado) 
VALUES (1002, 'Maria', 'Gonzalez', 34, '555-234-5678', 'mariagonzalez@email.com', 'mariag', 'mypassword2', 1,1);

-- Registro 3
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role,estado) 
VALUES (1003, 'Carlos', 'Castro', 19, '555-345-6789', 'carloscastro@email.com', 'carlosc', 'mypassword3', 1,1);

-- Registro 4
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role,estado) 
VALUES (1004, 'Ana', 'Rodriguez', 42, '555-456-7890', 'anarodriguez@email.com', 'anar', 'mypassword4', 1,1);

-- Registro 5
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role,estado) 
VALUES (1005, 'Pedro', 'Lopez', 25, '555-567-8901', 'pedrolopez@email.com', 'pedrol', 'mypassword5', 1,1);

-- Registro 6
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role,estado) 
VALUES (1006, 'Sofia', 'Diaz', 31, '555-678-9012', 'sofiadiaz@email.com', 'sofiad', 'mypassword6', 2,1);

-- Registro 7
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role,estado) 
VALUES (1007, 'Miguel', 'Ramirez', 37, '555-789-0123', 'miguelramirez@email.com', 'miguelr', 'mypassword7', 2,1);

-- Registro 8
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role,estado) 
VALUES (1008, 'Laura', 'Sanchez', 22, '555-890-1234', 'laurasanchez@email.com', 'lauras', 'mypassword8', 2,1);

-- Registro 9
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role,estado) 
VALUES (1009, 'Diego', 'Gutierrez', 29, '555-901-2345', 'diegogutierrez@email.com', 'diegog', 'mypassword9', 2,1);

-- Registro 10
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role,estado) 
VALUES (1010, 'Carla', 'Lopez', 26, '555-012-3456', 'carlalopez@email.com', 'carlal', 'mypassword10', 2,1);

-- Registro 11
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role,estado) 
VALUES (1011, 'Ana', 'García', 28, '8888-7777', 'ana.garcia@email.com', 'anagarcia', 'password123', 2,1);

-- Registro 12
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role,estado) 
VALUES (1012, 'Pedro', 'López', 35, '7777-6666', 'pedro.lopez@email.com', 'pedrol', 'password123', 2,1);

-- Registro 13
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role,estado) 
VALUES (1013, 'María', 'Fernández', 45, '5555-4444', 'maria.fernandez@email.com', 'mariaf', 'password123', 2,1);

-- Registro 14
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role,estado) 
VALUES (1014, 'Juan', 'Pérez', 27, '4444-3333', 'juan.perez@email.com', 'juanp', 'password123', 2,1);

-- Registro 15
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role,estado) 
VALUES (1015, 'Sofía', 'González', 33, '3333-2222', 'sofia.gonzalez@email.com', 'sofiag', 'password123', 2,1);

-- Registro 16
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role,estado) 
VALUES (1016, 'Luis', 'Hernández', 22, '2222-1111', 'luis.hernandez@email.com', 'luish', 'password123', 2,1);

-- Registro 17
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role,estado) 
VALUES (1017, 'Carolina', 'Martínez', 29, '1111-0000', 'carolina.martinez@email.com', 'carolinam', 'password123', 2,1);

-- Registro 18
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role,estado) 
VALUES (1018, 'Miguel', 'Sánchez', 40, '9999-8888', 'miguel.sanchez@email.com', 'miguels', 'password123', 2,1);

-- Registro 19
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role,estado) 
VALUES (1019, 'Patricia', 'Castillo', 32, '8888-7777', 'patricia.castillo@email.com', 'patriciac', 'password123', 2,1);

-- Registro 20
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role,estado) 
VALUES (1020, 'Ricardo', 'Morales', 37, '7777-6666', 'ricardo.morales@email.com', 'ricardom', 'password123', 2,1);

--------
-- Refugios
---------

-- Registro 1
INSERT INTO REFUGIOS (id, nombre, direccion, capacidad, cantidad_anim, contacto_ID, telefono, email) 
VALUES (1, 'Refugio de Animales Peluditos', 'San José, Barrio Escalante, Av. 13, Calle 29', 100, 35, 1001, '555-123-4567', 'info@peluditoscr.com');

-- Registro 2
INSERT INTO REFUGIOS (id, nombre, direccion, capacidad, cantidad_anim, contacto_ID, telefono, email) 
VALUES (2, 'Asociación para la Protección de Animales Abandonados', 'Heredia, San Francisco, Calle Pública, Finca La Esperanza', 50, 50, 1002, '555-234-5678', 'info@proteccionanimalcr.com');

-- Registro 3
INSERT INTO REFUGIOS (id, nombre, direccion, capacidad, cantidad_anim, contacto_ID, telefono, email) 
VALUES (3, 'Refugio Felino de Costa Rica', 'Escazú, Barrio San Miguel, 600m este de la Cruz Roja', 150, 50, 1003, '81-1234-5678', 'info@refugiofelino.com');

-- Registro 4
INSERT INTO REFUGIOS (id, nombre, direccion, capacidad, cantidad_anim, contacto_ID, telefono, email) 
VALUES (4, 'Fundación Animalia', 'Cartago, Oreamuno, Finca Las Cañas', 100, 40, 1004, '555-345-6789', 'info@fundacionanimalia.org');

-- Registro 5
INSERT INTO REFUGIOS (id, nombre, direccion, capacidad, cantidad_anim, contacto_ID, telefono, email) 
VALUES (5, 'Hogar de Esperanza Animal', 'San José, Barrio La Granja, 2nd Avenue, 13th Street', 50, 35, 1005, '555-456-7890', 'info@hogaresperanzaanimal.com');

-- Registro 6
INSERT INTO REFUGIOS (id, nombre, direccion, capacidad, cantidad_anim, contacto_ID, telefono, email) 
VALUES (6, 'Refugio Los Amigos Fieles', 'Heredia, Santo Domingo de Heredia, 3rd Street, 5th Avenue', 60, 42, 1006, '555-678-1234', 'contacto@refugiolosamigosfieles.com');


--------
-- Animales
---------

INSERT INTO ANIMALES (id, nombre, especie, raza, edad, estado_salud, refugio_ID, imagen_URL)
VALUES (1, 'Luna', 'Gato', 'Siamés', 3, 'Saludable', 1, 'https://example.com/luna.jpg'),
       (2, 'Rocky', 'Perro', 'Bulldog', 5, 'Enfermo', 2, 'https://example.com/rocky.jpg'),
       (3, 'Simba', 'Perro', 'Chiwawa', 2, 'Saludable', 3, 'https://example.com/simba.jpg'),
       (4, 'Nemo', 'Pez', 'Payaso', 1, 'Saludable', 1, 'https://example.com/nemo.jpg'),
       (5, 'Dory', 'Pez', 'Azul', 2, 'Saludable', 2, 'https://example.com/dory.jpg'),
       (6, 'Toby', 'Gato', 'Siames', 4, 'Enfermo', 3, 'https://example.com/toby.jpg'),
       (7, 'Cleo', 'Perro', 'Cocker', 6, 'Saludable', 1, 'https://example.com/cleo.jpg'),
       (8, 'Bolt', 'Perro', 'Pastor Alemán', 3, 'Saludable', 2, 'https://example.com/bolt.jpg'),
       (9, 'Fluffy', 'Conejo', 'Peluche', 1, 'Saludable', 3, 'https://example.com/fluffy.jpg'),
       (10, 'Garfield', 'Gato', 'Persa', 2, 'Saludable', 1, 'https://example.com/garfield.jpg');

INSERT INTO ANIMALES (id, nombre, especie, raza, edad, estado_salud, refugio_ID, imagen_URL)
VALUES (11, 'Max', 'Perro', 'Bulldog Francés', 2, 'Saludable', 4, 'https://example.com/max.jpg'),
       (12, 'Catty', 'Gato', 'Siamés', 1, 'Enfermo', 5, 'https://example.com/catty.jpg'),
       (13, 'Bambi', 'Perro', 'Pastor Alemán', 3, 'Saludable', 6, 'https://example.com/bambi.jpg'),
       (14, 'Kiki', 'Gato', 'Persa', 4, 'Saludable', 4, 'https://example.com/kiki.jpg'),
       (15, 'Scooby', 'Perro', 'Gran Danés', 5, 'Saludable', 5, 'https://example.com/scooby.jpg'),
       (16, 'Oliver', 'Gato', 'American Shorthair', 2, 'Saludable', 6, 'https://example.com/oliver.jpg'),
       (17, 'Jerry', 'Gato', 'American Shorthair', 1, 'Saludable', 4, 'https://example.com/jerry.jpg'),
       (18, 'Benny', 'Perro', 'Beagle', 6, 'Enfermo', 5, 'https://example.com/benny.jpg'),
       (19, 'Flor', 'Conejo', 'Holandés', 3, 'Saludable', 6, 'https://example.com/flor.jpg'),
       (20, 'Rocky', 'Gato', 'Persa', 4, 'Enfermo', 4, 'https://example.com/rocky2.jpg');

INSERT INTO ANIMALES (id, nombre, especie, raza, edad, estado_salud, refugio_ID, imagen_URL)
VALUES (21, 'Toby', 'Perro', 'Labrador Retriever', 1, 'Saludable', 4, 'https://example.com/toby.jpg'),
       (22, 'Luna', 'Gato', 'Bengalí', 2, 'Saludable', 5, 'https://example.com/luna.jpg'),
       (23, 'Maxi', 'Perro', 'Chihuahua', 4, 'Enfermo', 6, 'https://example.com/maxi.jpg'),
       (24, 'Mimi', 'Gato', 'Angora', 3, 'Saludable', 4, 'https://example.com/mimi.jpg'),
       (25, 'Buddy', 'Perro', 'Bulldog Inglés', 6, 'Enfermo', 5, 'https://example.com/buddy.jpg'),
       (26, 'Garfield', 'Gato', 'Persa', 5, 'Saludable', 6, 'https://example.com/garfield.jpg'),
       (27, 'Bella', 'Perro', 'Poodle', 2, 'Saludable', 4, 'https://example.com/bella.jpg'),
       (28, 'Milo', 'Gato', 'Sphynx', 1, 'Saludable', 5, 'https://example.com/milo.jpg'),
       (29, 'Rusty', 'Perro', 'Terrier', 3, 'Enfermo', 6, 'https://example.com/rusty.jpg'),
       (30, 'Whiskers', 'Gato', 'Bombay', 4, 'Saludable', 4, 'https://example.com/whiskers.jpg');


--------
-- ADOPCIONES
---------

INSERT INTO ADOPCIONES (animal_ID, refugio_ID, adoptante_ID, fecha)
VALUES
  (1, 1, 1003, '2023-03-21 10:00:00'),
  (3, 2, 1012, '2023-03-20 10:00:00'),
  (4, 3, 1010, '2023-03-19 10:00:00'),
  (6, 4, 1004, '2023-03-18 10:00:00'),
  (12, 5, 1005, '2023-03-17 10:00:00'),
  (7, 6, 1006, '2023-03-16 10:00:00'),
  (15, 1, 1007, '2023-03-15 10:00:00'),
  (20, 2, 1008, '2023-03-14 10:00:00'),
  (21, 1, 1019, '2023-03-13 10:00:00'),
  (25, 2, 1011, '2023-03-12 10:00:00');


--------
-- DONACIONES
---------

INSERT INTO DONACIONES (refugio_ID, donante_ID, fecha, cantidad)
VALUES
  (1, 1001, '2023-03-21 10:00:00', 150),
  (3, 1002, '2023-03-20 10:00:00', 200),
  (4, 1003, '2023-03-19 10:00:00', 100),
  (6, 1004, '2023-03-18 10:00:00', 150),
  (4, 1005, '2023-03-17 10:00:00', 300),
  (3, 1002, '2023-03-20 10:00:00', 200),
  (2, 1003, '2023-03-23 10:00:00', 100),
  (2, 1004, '2023-03-18 10:00:00', 150),
  (2, 1005, '2023-03-15 10:00:00', 300),
  (5, 1006, '2023-03-16 10:00:00', 500);
  
INSERT INTO DONACIONES (refugio_ID, donante_ID, fecha, cantidad)
VALUES (1, 1001, '2022-01-01 10:00:00', 200);

INSERT INTO DONACIONES (refugio_ID, donante_ID, fecha, cantidad)
VALUES (2, 1002, '2022-01-02 11:00:00', 300);

INSERT INTO DONACIONES (refugio_ID, donante_ID, fecha, cantidad)
VALUES (3, 1003, '2022-01-03 12:00:00', 400);

INSERT INTO DONACIONES (refugio_ID, donante_ID, fecha, cantidad)
VALUES (4, 1004, '2022-01-04 13:00:00', 500);

INSERT INTO DONACIONES (refugio_ID, donante_ID, fecha, cantidad)
VALUES (5, 1005, '2022-01-05 14:00:00', 600);

INSERT INTO DONACIONES (refugio_ID, donante_ID, fecha, cantidad)
VALUES (6, 1006, '2022-01-06 15:00:00', 150);

INSERT INTO DONACIONES (refugio_ID, donante_ID, fecha, cantidad)
VALUES (1, 1007, '2022-01-07 16:00:00', 250);

INSERT INTO DONACIONES (refugio_ID, donante_ID, fecha, cantidad)
VALUES (2, 1008, '2022-01-08 17:00:00', 350);

INSERT INTO DONACIONES (refugio_ID, donante_ID, fecha, cantidad)
VALUES (3, 1009, '2022-01-09 18:00:00', 450);

INSERT INTO DONACIONES (refugio_ID, donante_ID, fecha, cantidad)
VALUES (4, 1010, '2022-01-10 19:00:00', 550);

--------
-- TESTIMONIOS
---------

INSERT INTO TESTIMONIOS (usuario_id, mensaje)
VALUES (1001, '¡Adoptar mi perro de este refugio fue la mejor decisión que he tomado!');

INSERT INTO TESTIMONIOS (usuario_id, mensaje)
VALUES (1002, 'Me encanta donar a esta organización porque sé que cada dólar va a ayudar a los animales necesitados.');

INSERT INTO TESTIMONIOS (usuario_id, mensaje)
VALUES (1003, 'Adopté a mi gato de este refugio y ha traído mucha alegría a mi vida.');

INSERT INTO TESTIMONIOS (usuario_id, mensaje)
VALUES (1004, 'Me siento bien sabiendo que mi donación está ayudando a proporcionar comida y refugio a los animales necesitados.');

INSERT INTO TESTIMONIOS (usuario_id, mensaje)
VALUES (1005, '¡Adoptar mi perro de este refugio cambió mi vida para mejor!');

INSERT INTO TESTIMONIOS (usuario_id, mensaje)
VALUES (1006, 'Dono a esta organización cada mes porque creo en su misión de ayudar a los animales.');

INSERT INTO TESTIMONIOS (usuario_id, mensaje)
VALUES (1007, 'Adoptar a mi gato de este refugio fue una experiencia maravillosa. El personal fue muy amable y atento.');

INSERT INTO TESTIMONIOS (usuario_id, mensaje)
VALUES (1008, 'Siento que estoy haciendo una diferencia al donar a esta organización y ayudar a salvar a los animales.');

INSERT INTO TESTIMONIOS (usuario_id, mensaje)
VALUES (1009, 'Adopté a mi perro de este refugio y se ha convertido en mi mejor amigo y compañero constante.');

INSERT INTO TESTIMONIOS (usuario_id, mensaje)
VALUES (1010, 'Me encanta apoyar a este refugio porque van más allá para ayudar a los animales necesitados.');
  
--------
-- Voluntarios
---------
  
INSERT INTO VOLUNTARIOS(voluntario_ID, disponibilidad)
VALUES (1012, '8am - 5pm martes a jueves ');
INSERT INTO VOLUNTARIOS(voluntario_ID, disponibilidad)
VALUES (1013, '7am - 3pm miercoles y viernes');
INSERT INTO VOLUNTARIOS(voluntario_ID, disponibilidad)
VALUES (1014, '2pm - 4pm lunes a viernes ');
INSERT INTO VOLUNTARIOS(voluntario_ID, disponibilidad)
VALUES (1015, '9am - 1pm miercoles y jueves');
INSERT INTO VOLUNTARIOS(voluntario_ID, disponibilidad)
VALUES (1016, '8pm - 11am martes a viernes ');


---------
-- PROCEDURES
---------

-- ANIMALES_NOT_IN_ADOPCIONES para ver cuales animales no estan adoptados

USE [Proyecto_Final]
GO

CREATE PROCEDURE [dbo].[ANIMALES_NOT_IN_ADOPCIONES]
	
AS
BEGIN

SELECT [ANIMALES].*
FROM [ANIMALES]
LEFT JOIN [ADOPCIONES] ON [ANIMALES].[id] = [ADOPCIONES].[animal_ID]
WHERE [ADOPCIONES].[animal_ID] IS NULL;

END

--------
-- Registrar Usuario 
---------
CREATE PROCEDURE [dbo].[RegistrarUsuario]
    @nombre varchar(255),
	@apellido varchar(255),
	@edad int,
	@telefono varchar(255),
	@email varchar(255),
	@usuario varchar(255),
	@password varchar(255),
	@role int
AS
BEGIN

	INSERT INTO USUARIOS (nombre, apellido, edad, telefono, email, usuario,password, role, estado) 
	VALUES (@nombre, @apellido, @edad, @telefono,@email,@usuario, @password, 2, 1);

END
GO

CREATE PROCEDURE [dbo].[ValidarUsuario]
	@email varchar(255),
	@password varchar(255)
AS
BEGIN
	
	SELECT 
		   @email,
		   estado
	  FROM dbo.USUARIOS
	  WHERE @email = @email
		AND @password		  = @password
		AND estado			  = 1

END
GO

--------
-- Consultar Usuario  
---------

CREATE PROCEDURE [dbo].[ConsultarUsuarios]


AS
BEGIN


SELECT id, nombre, apellido, edad, telefono, email, usuario, password, role, estado FROM dbo.USUARIOS

end
--------
-- Consultar Testimonios  
---------

CREATE PROCEDURE [dbo].[ConsultarTestimonios]

AS 
BEGIN
	SELECT USUARIOS.nombre, USUARIOS.apellido, TESTIMONIOS.mensaje
    FROM USUARIOS
    INNER JOIN TESTIMONIOS ON USUARIOS.id = TESTIMONIOS.usuario_id;

	END
	GO


--------
-- Consultar Voluntarios 
---------
CREATE PROCEDURE [dbo].[ConsultarVoluntarios]

AS 
BEGIN
	SELECT USUARIOS.nombre, USUARIOS.apellido, VOLUNTARIOS.disponibilidad
    FROM USUARIOS
    INNER JOIN VOLUNTARIOS ON USUARIOS.id = VOLUNTARIOS.voluntario_ID;

	END
	GO
	
--------
-- AgregarTestimonio
---------
CREATE PROCEDURE [dbo].[AgregarTestimonio]
	@usuario_id int,
	@mensaje varchar(255)

AS
BEGIN

	INSERT INTO TESTIMONIOS(usuario_id, mensaje) 
	VALUES (@usuario_id, @mensaje);

END
GO

--------
-- AdoptarMascota
---------
CREATE PROCEDURE [dbo].AdoptarMascota
	@animal_ID int, 
	@adoptante_ID int

AS
BEGIN

	INSERT INTO ADOPCIONES(animal_ID, adoptante_ID, refugio_ID, fecha) 
	VALUES (@animal_ID, @adoptante_ID, 2, GETDATE());

END
GO

--------
-- AgregarVoluntario
---------

CREATE PROCEDURE [dbo].[AgregarVoluntario]

    @voluntario_ID int,
    @disponibilidad varchar(255)

AS
BEGIN

    INSERT INTO VOLUNTARIOS(voluntario_ID, disponibilidad) 
    VALUES (@voluntario_ID, @disponibilidad);

END
GO

--------
-- Donar
---------

CREATE PROCEDURE [dbo].[Donar]
    @refugio_ID int,
    @donante_ID int,
    @cantidad int

AS
BEGIN

    INSERT INTO DONACIONES(refugio_ID, donante_ID, fecha, cantidad) 
    VALUES (@refugio_ID, @donante_ID, SYSDATETIME(), @cantidad);

END
GO
