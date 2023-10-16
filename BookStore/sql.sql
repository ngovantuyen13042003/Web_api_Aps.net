drop database if exists BookStore
go
create database BookStore;
go
use BookStore;
-- Create the 'book' table
CREATE TABLE book (
    id INT IDENTITY(1, 1) PRIMARY KEY,
    name NVARCHAR(MAX),
    description NVARCHAR(MAX),
    price FLOAT,
    amount INT,
    language NVARCHAR(MAX),
    author NVARCHAR(MAX),
    publisher NVARCHAR(MAX)
);

-- Create the 'category' table
CREATE TABLE category (
    id INT IDENTITY(1, 1) PRIMARY KEY,
    name NVARCHAR(MAX)
);

-- Create the 'customer' table
CREATE TABLE customer (
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    Username NVARCHAR(MAX),
    Password NVARCHAR(MAX),
    Gender NVARCHAR(MAX),
    Address NVARCHAR(MAX),
    ReceiveAddress NVARCHAR(MAX),
    Email NVARCHAR(MAX),
    PhoneNumber NVARCHAR(MAX),
    ImagePath NVARCHAR(MAX),
    DateOfBirth DATE
);

-- Create the 'images' table
CREATE TABLE images (
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    NameImage NVARCHAR(MAX),
    TypeImage NVARCHAR(MAX),
    DataImage VARBINARY(MAX),
    BookId INT,
    FOREIGN KEY (BookId) REFERENCES book(id)
);

-- Create the 'cart' table
CREATE TABLE cart (
    IdCart INT IDENTITY(1, 1) PRIMARY KEY,
    BookName NVARCHAR(MAX),
    Author NVARCHAR(MAX),
    Price FLOAT,
    Amount INT,
    book_id INT,
    customer_id INT,
    FOREIGN KEY (book_id) REFERENCES book(id)on update cascade on delete cascade,
    FOREIGN KEY (customer_id) REFERENCES customer(Id)on update cascade on delete cascade
);

-- Create the 'book_category' table
CREATE TABLE book_category (
    book_id INT,
    category_id INT,
    PRIMARY KEY (book_id, category_id),
    FOREIGN KEY (book_id) REFERENCES book(id)on update cascade on delete cascade,
    FOREIGN KEY (category_id) REFERENCES category(id)on update cascade on delete cascade
);
-- Create the 'customer_book' table for the many-to-many relationship between 'customer' and 'book'
CREATE TABLE customer_book (
    customer_id INT,
    book_id INT,
    PRIMARY KEY (customer_id, book_id),
    FOREIGN KEY (customer_id) REFERENCES customer(Id) on update cascade on delete cascade,
    FOREIGN KEY (book_id) REFERENCES book(id) on update cascade on delete cascade
);
-- Create the 'book_images' table for the many-to-many relationship between 'book' and 'images'
CREATE TABLE book_images (
    book_id INT,
    image_id INT,
    PRIMARY KEY (book_id, image_id),
    FOREIGN KEY (book_id) REFERENCES book(id) on update cascade on delete cascade,
    FOREIGN KEY (image_id) REFERENCES images(Id) on update cascade on delete cascade
);
