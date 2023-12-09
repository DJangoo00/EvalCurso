-- CREATE DATABASE cursosdb;

-- USE cursosdb;

-- user definition
CREATE TABLE [user] (
    id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    nombre NVARCHAR(100) NOT NULL,
    correo NVARCHAR(100) NOT NULL,
    password NVARCHAR(255) NOT NULL
);

-- role definition
CREATE TABLE [role] (
    id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    roleName NVARCHAR(50) NOT NULL
);

-- refreshtoken definition
CREATE TABLE refreshtoken (
    id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    idUserFk INT NOT NULL,
    token NVARCHAR(MAX) NULL,
    expires DATETIME2(6) NOT NULL,
    created DATETIME2(6) NOT NULL,
    revoked DATETIME2(6) NULL,
    FOREIGN KEY (idUserFk) REFERENCES [user] (id)
);

-- userrol definition
CREATE TABLE userrole (
    idUserFk INT NOT NULL,
    idRoleFk INT NOT NULL,
    PRIMARY KEY (idUserFk, idRoleFk),
    FOREIGN KEY (idRoleFk) REFERENCES [role] (id),
    FOREIGN KEY (idUserFk) REFERENCES [user] (id)
);

-- curso definition
CREATE TABLE curso (
    id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    nombre NVARCHAR(100) NOT NULL,
    img NVARCHAR(100) NOT NULL,
    descripcion NVARCHAR(200) NOT NULL,
    idInstructorFk INT NOT NULL,
    FOREIGN KEY (idInstructorFk) REFERENCES [user] (id)
);

-- estado definition
CREATE TABLE estado (
    id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    nombre NVARCHAR(100) NOT NULL
);

-- usercurso definition
CREATE TABLE usercurso (
    idUserFk INT NOT NULL,
    idCursoFk INT NOT NULL,
    idEstadoFk INT NOT NULL,
    calificacion INT NULL,
    comentario NVARCHAR(200) NULL,
    PRIMARY KEY (idUserFk, idCursoFk),
    FOREIGN KEY (idUserFk) REFERENCES [user] (id),
    FOREIGN KEY (idCursoFk) REFERENCES [curso] (id),
    FOREIGN KEY (idEstadoFk) REFERENCES [estado] (id)
);

