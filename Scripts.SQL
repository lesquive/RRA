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
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role) 
VALUES (1001, 'Juan', 'Perez', 28, '555-123-4567', 'juanperez@email.com', 'juanp', 'mypassword1', 1);

-- Registro 2
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role) 
VALUES (1002, 'Maria', 'Gonzalez', 34, '555-234-5678', 'mariagonzalez@email.com', 'mariag', 'mypassword2', 1);

-- Registro 3
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role) 
VALUES (1003, 'Carlos', 'Castro', 19, '555-345-6789', 'carloscastro@email.com', 'carlosc', 'mypassword3', 1);

-- Registro 4
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role) 
VALUES (1004, 'Ana', 'Rodriguez', 42, '555-456-7890', 'anarodriguez@email.com', 'anar', 'mypassword4', 1);

-- Registro 5
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role) 
VALUES (1005, 'Pedro', 'Lopez', 25, '555-567-8901', 'pedrolopez@email.com', 'pedrol', 'mypassword5', 1);

-- Registro 6
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role) 
VALUES (1006, 'Sofia', 'Diaz', 31, '555-678-9012', 'sofiadiaz@email.com', 'sofiad', 'mypassword6', 2);

-- Registro 7
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role) 
VALUES (1007, 'Miguel', 'Ramirez', 37, '555-789-0123', 'miguelramirez@email.com', 'miguelr', 'mypassword7', 2);

-- Registro 8
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role) 
VALUES (1008, 'Laura', 'Sanchez', 22, '555-890-1234', 'laurasanchez@email.com', 'lauras', 'mypassword8', 2);

-- Registro 9
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role) 
VALUES (1009, 'Diego', 'Gutierrez', 29, '555-901-2345', 'diegogutierrez@email.com', 'diegog', 'mypassword9', 2);

-- Registro 10
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role) 
VALUES (1010, 'Carla', 'Lopez', 26, '555-012-3456', 'carlalopez@email.com', 'carlal', 'mypassword10', 2);

-- Registro 11
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role) 
VALUES (1011, 'Ana', 'García', 28, '8888-7777', 'ana.garcia@email.com', 'anagarcia', 'password123', 2);

-- Registro 12
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role) 
VALUES (1012, 'Pedro', 'López', 35, '7777-6666', 'pedro.lopez@email.com', 'pedrol', 'password123', 2);

-- Registro 13
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role) 
VALUES (1013, 'María', 'Fernández', 45, '5555-4444', 'maria.fernandez@email.com', 'mariaf', 'password123', 2);

-- Registro 14
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role) 
VALUES (1014, 'Juan', 'Pérez', 27, '4444-3333', 'juan.perez@email.com', 'juanp', 'password123', 2);

-- Registro 15
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role) 
VALUES (1015, 'Sofía', 'González', 33, '3333-2222', 'sofia.gonzalez@email.com', 'sofiag', 'password123', 2);

-- Registro 16
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role) 
VALUES (1016, 'Luis', 'Hernández', 22, '2222-1111', 'luis.hernandez@email.com', 'luish', 'password123', 2);

-- Registro 17
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role) 
VALUES (1017, 'Carolina', 'Martínez', 29, '1111-0000', 'carolina.martinez@email.com', 'carolinam', 'password123', 2);

-- Registro 18
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role) 
VALUES (1018, 'Miguel', 'Sánchez', 40, '9999-8888', 'miguel.sanchez@email.com', 'miguels', 'password123', 2);

-- Registro 19
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role) 
VALUES (1019, 'Patricia', 'Castillo', 32, '8888-7777', 'patricia.castillo@email.com', 'patriciac', 'password123', 2);

-- Registro 20
INSERT INTO USUARIOS (id, nombre, apellido, edad, telefono, email, usuario, password, role) 
VALUES (1020, 'Ricardo', 'Morales', 37, '7777-6666', 'ricardo.morales@email.com', 'ricardom', 'password123', 2);

--------
-- Refugios
---------

-- Registro 1
INSERT INTO REFUGIOS (id, nombre, direccion, capacidad, cantidad_anim, contacto_ID, telefono, correo_electronico) 
VALUES (1, 'Refugio de Animales Peluditos', 'San José, Barrio Escalante, Av. 13, Calle 29', 100, 35, 1001, '555-123-4567', 'info@peluditoscr.com');

-- Registro 2
INSERT INTO REFUGIOS (id, nombre, direccion, capacidad, cantidad_anim, contacto_ID, telefono, correo_electronico) 
VALUES (2, 'Asociación para la Protección de Animales Abandonados', 'Heredia, San Francisco, Calle Pública, Finca La Esperanza', 50, 50, 1002, '555-234-5678', 'info@proteccionanimalcr.com');

-- Registro 3
INSERT INTO REFUGIOS (id, nombre, direccion, capacidad, cantidad_anim, contacto_ID, telefono, correo_electronico) 
VALUES (3, 'Refugio Felino de Costa Rica', 'Escazú, Barrio San Miguel, 600m este de la Cruz Roja', 150, 50, 1003, '81-1234-5678', 'info@refugiofelino.com');

-- Registro 4
INSERT INTO REFUGIOS (id, nombre, direccion, capacidad, cantidad_anim, contacto_ID, telefono, correo_electronico) 
VALUES (4, 'Fundación Animalia', 'Cartago, Oreamuno, Finca Las Cañas', 100, 40, 1004, '555-345-6789', 'info@fundacionanimalia.org');

-- Registro 5
INSERT INTO REFUGIOS (id, nombre, direccion, capacidad, cantidad_anim, contacto_ID, telefono, correo_electronico) 
VALUES (5, 'Hogar de Esperanza Animal', 'San José, Barrio La Granja, 2nd Avenue, 13th Street', 50, 35, 1005, '555-456-7890', 'info@hogaresperanzaanimal.com');

-- Registro 6
INSERT INTO REFUGIOS (id, nombre, direccion, capacidad, cantidad_anim, contacto_ID, telefono, correo_electronico) 
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

INSERT INTO ADOPCIONES (id, animal_ID, refugio_ID, adoptante_ID, fecha)
VALUES
  (1, 1, 1, 1003, '2023-03-21'),
  (2, 3, 2, 1012, '2023-03-20'),
  (3, 4, 3, 1010, '2023-03-19'),
  (4, 6, 4, 1004, '2023-03-18'),
  (5, 12, 5, 1005, '2023-03-17'),
  (6, 7, 6, 1006, '2023-03-16'),
  (7, 15, 1, 1007, '2023-03-15'),
  (8, 20, 2, 1008, '2023-03-14'),
  (9, 21, 1, 1019, '2023-03-13'),
  (10, 25, 2, 1011, '2023-03-12');
