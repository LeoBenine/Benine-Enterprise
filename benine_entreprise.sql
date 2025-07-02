DROP DATABASE IF EXISTS benine_enterprise;
CREATE DATABASE benine_enterprise;
USE benine_enterprise;

CREATE TABLE Funcionarios (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(255) NOT NULL,
    CPF VARCHAR(14) NOT NULL,
    DataNascimento DATE NOT NULL,
    Cargo VARCHAR(100),
    Celular VARCHAR(20),
    Salario DECIMAL(10,2),
    Login VARCHAR(100) NOT NULL UNIQUE
);

USE benine_enterprise;
CREATE TABLE Usuarios (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Login VARCHAR(100) NOT NULL UNIQUE,
    Senha VARCHAR(100) NOT NULL
);