CREATE DATABASE address_db;
USE address_db;

CREATE TABLE addresses (
    id INT AUTO_INCREMENT PRIMARY KEY,
    street VARCHAR(100),
    house_number VARCHAR(20),
    postal_code VARCHAR(20),
    city VARCHAR(100),
    country VARCHAR(100)
);