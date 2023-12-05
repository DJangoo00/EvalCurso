DROP DATABASE cursosdb IF NOT EXISTS;

CREATE DATABASE cursosdb CHARACTER SET utf8mb4;

USE cursosdb;

-- user definition
CREATE TABLE
    user (
        id int NOT NULL AUTO_INCREMENT,
        nombre varchar(100) NOT NULL,
        correo varchar(100) NOT NULL,
        password varchar(255) NOT NULL,
        PRIMARY KEY (id)
    ) 

-- rol definition
CREATE TABLE
    rol (
        id int NOT NULL AUTO_INCREMENT,
        roleName varchar(50) NOT NULL,
        PRIMARY KEY (id)
    )

-- refreshtoken definition
CREATE TABLE
    refreshtoken (
        id int NOT NULL AUTO_INCREMENT,
        idUserFk int NOT NULL,
        token longtext DEFAULT NULL,
        expires datetime(6) NOT NULL,
        created datetime(6) NOT NULL,
        revoked datetime(6) DEFAULT NULL,
        PRIMARY KEY (id),
        FOREIGN KEY (idUserFk) REFERENCES user (id)
    )

-- userrol definition
CREATE TABLE
    userrol (
        idUserFk int NOT NULL,
        idRolFk int NOT NULL,
        PRIMARY KEY (idRolFk, idUserFk),
        FOREIGN KEY (idRolFk) REFERENCES rol (id),
        FOREIGN KEY (idUserFk) REFERENCES user (id)
    )

-- curso definition
CREATE TABLE
    curso (
        id int NOT NULL AUTO_INCREMENT,
        nombre varchar(100) NOT NULL,
        img varchar(100) NOT NULL,
        descripcion varchar(200) NOT NULL,
        idInstructorFk int NOT NULL AUTO_INCREMENT,
        PRIMARY KEY (id),
        FOREIGN KEY (idInstructorFk) REFERENCES user (id)
    ) 

-- estado definition
CREATE TABLE
    estado (
        id int NOT NULL AUTO_INCREMENT,
        nombre varchar(100) NOT NULL,
        PRIMARY KEY (id)
    ) 

-- usercurso definition
CREATE TABLE
    usercurso (
        idUserFk INT NOT NULL,
        idCursoFk INT NOT NULL,
        idEstadoFk INT NOT NULL,
        calificacion TINTYINT NULL,
        comentario varchar(200) NULL,
        PRIMARY KEY (idUserFk, idCursoFk)
        FOREIGN KEY (idUserFk) REFERENCES user (id),
        FOREIGN KEY (idCursoFk) REFERENCES curso (id),
        FOREIGN KEY (idEstadoFk) REFERENCES estado (id)
    )

-- index definitions
CREATE INDEX index_1
ON user (id);

CREATE INDEX index_2
ON rol (id);

CREATE INDEX index_3
ON userrol (idUserFk, idRolFk);

CREATE INDEX index_4
ON curso (id, nombre);

CREATE INDEX index_5
ON estado (id);

CREATE INDEX index_6
ON usercurso (idUserFk, idCursoFk, idEstadoFk, calificacion);