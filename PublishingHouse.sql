-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Мар 26 2024 г., 22:53
-- Версия сервера: 8.0.30
-- Версия PHP: 8.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `PublishingHouse`
--

-- --------------------------------------------------------

--
-- Структура таблицы `Authors`
--

CREATE TABLE `Authors` (
  `author_id` int NOT NULL,
  `birth_date` date DEFAULT NULL,
  `last_name` varchar(255) DEFAULT NULL,
  `first_name` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16;

--
-- Дамп данных таблицы `Authors`
--

INSERT INTO `Authors` (`author_id`, `birth_date`, `last_name`, `first_name`) VALUES
(1, '1980-05-15', 'Smith', 'John'),
(2, '1975-09-22', 'Johnson', 'Emily'),
(3, '1990-03-10', 'Brown', 'Michael'),
(4, '1988-07-01', 'Williams', 'Jessica'),
(5, '1970-12-05', 'Davis', 'Christopher'),
(6, '1985-02-18', 'Martinez', 'Jennifer'),
(7, '1978-08-20', 'Miller', 'David'),
(8, '1982-04-25', 'Taylor', 'Michelle'),
(9, '1973-11-30', 'Anderson', 'William'),
(10, '1987-06-08', 'Thomas', 'Elizabeth'),
(11, '1979-01-12', 'Jackson', 'Daniel'),
(12, '1983-09-17', 'White', 'Linda'),
(13, '1976-07-03', 'Harris', 'Richard'),
(14, '1989-03-29', 'Martin', 'Mary'),
(15, '1972-10-15', 'Thompson', 'Thomas'),
(16, '1986-05-18', 'Garcia', 'Patricia'),
(17, '1974-02-22', 'Clark', 'Daniel'),
(18, '1991-11-09', 'Lewis', 'Sandra'),
(19, '1977-08-10', 'Lee', 'Paul'),
(20, '1981-01-05', 'Walker', 'Sarah');

-- --------------------------------------------------------

--
-- Структура таблицы `Books`
--

CREATE TABLE `Books` (
  `book_id` int NOT NULL,
  `author_id` int DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  `title` varchar(255) DEFAULT NULL,
  `genre` varchar(255) DEFAULT NULL,
  `price` decimal(10,2) DEFAULT NULL,
  `year` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16;

--
-- Дамп данных таблицы `Books`
--

INSERT INTO `Books` (`book_id`, `author_id`, `quantity`, `title`, `genre`, `price`, `year`) VALUES
(1, 1, 99, 'asd', 'asd', '20.00', 1900),
(3, 2, 38, 'To Kill a Mockingbird', 'Fiction', '15.99', 1960),
(4, 3, 20, '1984', 'Science Fiction', '18.99', 1949),
(5, 4, 60, 'Pride and Prejudice', 'Romance', '10.99', 1813),
(6, 5, 45, 'The Great Gatsby', 'Drama', '14.99', 1925),
(7, 6, 25, 'The Catcher in the Rye', 'Coming-of-age', '13.99', 1951),
(8, 7, 35, 'Moby-Dick', 'Adventure', '17.99', 1851),
(9, 8, 55, 'Jane Eyre', 'Gothic Fiction', '11.99', 1847),
(10, 9, 15, 'The Grapes of Wrath', 'Historical Fiction', '16.99', 1939),
(11, 10, 65, 'Animal Farm', 'Satire', '9.99', 1945),
(12, 11, 30, 'Lord of the Flies', 'Allegorical Novel', '14.99', 1954),
(13, 12, 40, 'The Picture of Dorian Gray', 'Gothic Fiction', '12.99', 1890),
(14, 13, 20, 'Catch-22', 'Satire', '16.99', 1961),
(15, 14, 50, 'One Hundred Years of Solitude', 'Magic Realism', '19.99', 1967),
(16, 15, 35, 'Brave New World', 'Dystopian Fiction', '20.99', 1932),
(17, 16, 25, 'The Hobbit', 'Fantasy', '18.99', 1937),
(18, 17, 45, 'Wuthering Heights', 'Gothic Fiction', '13.99', 1847),
(19, 18, 55, 'The Lord of the Rings', 'Fantasy', '29.99', 1954),
(20, 19, 10, 'Gone with the Wind', 'Historical Fiction', '24.99', 1936),
(21, 20, 60, 'The Da Vinci Code', 'Mystery', '21.99', 2003);

-- --------------------------------------------------------

--
-- Структура таблицы `Customers`
--

CREATE TABLE `Customers` (
  `customer_id` int NOT NULL,
  `last_name` varchar(255) DEFAULT NULL,
  `first_name` varchar(255) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16;

--
-- Дамп данных таблицы `Customers`
--

INSERT INTO `Customers` (`customer_id`, `last_name`, `first_name`, `address`) VALUES
(1, 'Smith', 'David', '123 Main St'),
(2, 'Johnson', 'Sarah', '456 Elm St'),
(3, 'Brown', 'Daniel', '789 Oak St'),
(4, 'Williams', 'Jennifer', '567 Pine St'),
(5, 'Jones', 'Michael', '890 Maple St'),
(6, 'Garcia', 'Maria', '345 Birch St'),
(7, 'Rodriguez', 'Jose', '678 Cedar St'),
(8, 'Wilson', 'Mary', '901 Walnut St'),
(9, 'Martinez', 'James', '234 Elmwood Ave'),
(10, 'Anderson', 'Patricia', '567 Oakwood Ave'),
(11, 'Taylor', 'Robert', '890 Cedar Ave'),
(12, 'Thomas', 'Linda', '123 Pine Ave'),
(13, 'Hernandez', 'William', '456 Birch Ave'),
(14, 'Moore', 'Elizabeth', '789 Maple Ave'),
(15, 'Martin', 'Charles', '901 Oak Ave'),
(16, 'Jackson', 'Karen', '234 Pine Blvd'),
(17, 'Thompson', 'John', '567 Elm Blvd'),
(18, 'White', 'Laura', '890 Oakwood Blvd'),
(19, 'Lopez', 'Mark', '123 Cedar Blvd'),
(20, 'Lee', 'Michelle', '456 Pine Blvd');

-- --------------------------------------------------------

--
-- Структура таблицы `Orders`
--

CREATE TABLE `Orders` (
  `order_id` int NOT NULL,
  `book_id` int DEFAULT NULL,
  `customer_id` int DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  `status` varchar(255) DEFAULT NULL,
  `order_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16;

--
-- Дамп данных таблицы `Orders`
--

INSERT INTO `Orders` (`order_id`, `book_id`, `customer_id`, `quantity`, `status`, `order_date`) VALUES
(3, 3, 3, 3, 'In Progress', '2023-03-10'),
(4, 4, 4, 1, 'Completed', '2023-03-05'),
(5, 5, 1, 4, 'Pending', '2023-03-03'),
(6, 6, 2, 2, 'Pending', '2023-03-08'),
(7, 7, 3, 1, 'Completed', '2023-02-28'),
(8, 8, 4, 3, 'In Progress', '2023-03-12'),
(9, 9, 5, 2, 'Completed', '2023-03-02'),
(10, 10, 6, 1, 'Pending', '2023-03-07'),
(11, 11, 7, 4, 'In Progress', '2023-03-11'),
(12, 12, 8, 2, 'Completed', '2023-03-04'),
(13, 13, 9, 1, 'Pending', '2023-03-09'),
(14, 14, 10, 3, 'Completed', '2023-03-06'),
(15, 15, 11, 2, 'In Progress', '2023-03-13'),
(16, 16, 12, 4, 'Completed', '2023-03-10'),
(17, 17, 13, 1, 'Pending', '2023-03-05'),
(18, 18, 14, 3, 'In Progress', '2023-03-12'),
(19, 19, 15, 2, 'Completed', '2023-03-01'),
(20, 20, 16, 4, 'Pending', '2023-03-08'),
(28, 3, 2, 1, 'Pending', '2024-03-09'),
(29, 3, 2, 1, 'Pending', '2024-03-09');

-- --------------------------------------------------------

--
-- Структура таблицы `Reviews`
--

CREATE TABLE `Reviews` (
  `review_id` int NOT NULL,
  `book_id` int DEFAULT NULL,
  `review_date` date DEFAULT NULL,
  `rating` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16;

--
-- Дамп данных таблицы `Reviews`
--

INSERT INTO `Reviews` (`review_id`, `book_id`, `review_date`, `rating`) VALUES
(4, 4, '2024-03-12', 4),
(5, 5, '2024-03-13', 2),
(6, 6, '2024-03-14', 5),
(7, 7, '2024-03-15', 3),
(9, 9, '2024-03-17', 1),
(10, 10, '2024-03-18', 5),
(13, 3, '2024-03-11', 3),
(14, 4, '2024-03-12', 4),
(15, 5, '2024-03-13', 2),
(16, 6, '2024-03-14', 5),
(17, 7, '2024-03-15', 3),
(18, 8, '2024-03-16', 4),
(19, 9, '2024-03-17', 1),
(20, 10, '2024-03-18', 5);

-- --------------------------------------------------------

--
-- Структура таблицы `UserGroups`
--

CREATE TABLE `UserGroups` (
  `group_id` int NOT NULL,
  `group_name` varchar(255) DEFAULT NULL,
  `permissions` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16;

--
-- Дамп данных таблицы `UserGroups`
--

INSERT INTO `UserGroups` (`group_id`, `group_name`, `permissions`) VALUES
(1, 'Admin', 'full_access'),
(2, 'Customer', 'view_books, create_orders');

-- --------------------------------------------------------

--
-- Структура таблицы `Users`
--

CREATE TABLE `Users` (
  `user_id` int NOT NULL,
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `group_id` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16;

--
-- Дамп данных таблицы `Users`
--

INSERT INTO `Users` (`user_id`, `username`, `password`, `group_id`) VALUES
(1, 'admin', '123', 1),
(2, 'bob', '321', 2);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `Authors`
--
ALTER TABLE `Authors`
  ADD PRIMARY KEY (`author_id`);

--
-- Индексы таблицы `Books`
--
ALTER TABLE `Books`
  ADD PRIMARY KEY (`book_id`),
  ADD KEY `FK_Book_Author` (`author_id`);

--
-- Индексы таблицы `Customers`
--
ALTER TABLE `Customers`
  ADD PRIMARY KEY (`customer_id`);

--
-- Индексы таблицы `Orders`
--
ALTER TABLE `Orders`
  ADD PRIMARY KEY (`order_id`),
  ADD KEY `FK_Order_Book` (`book_id`),
  ADD KEY `FK_Order_Customer` (`customer_id`);

--
-- Индексы таблицы `Reviews`
--
ALTER TABLE `Reviews`
  ADD PRIMARY KEY (`review_id`),
  ADD KEY `FK_Review_Book` (`book_id`);

--
-- Индексы таблицы `UserGroups`
--
ALTER TABLE `UserGroups`
  ADD PRIMARY KEY (`group_id`),
  ADD UNIQUE KEY `group_name` (`group_name`);

--
-- Индексы таблицы `Users`
--
ALTER TABLE `Users`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `username` (`username`),
  ADD KEY `group_id` (`group_id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `Authors`
--
ALTER TABLE `Authors`
  MODIFY `author_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT для таблицы `Books`
--
ALTER TABLE `Books`
  MODIFY `book_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT для таблицы `Customers`
--
ALTER TABLE `Customers`
  MODIFY `customer_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT для таблицы `Orders`
--
ALTER TABLE `Orders`
  MODIFY `order_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT для таблицы `Reviews`
--
ALTER TABLE `Reviews`
  MODIFY `review_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT для таблицы `UserGroups`
--
ALTER TABLE `UserGroups`
  MODIFY `group_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `Users`
--
ALTER TABLE `Users`
  MODIFY `user_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `Books`
--
ALTER TABLE `Books`
  ADD CONSTRAINT `FK_Book_Author` FOREIGN KEY (`author_id`) REFERENCES `Authors` (`author_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `Orders`
--
ALTER TABLE `Orders`
  ADD CONSTRAINT `FK_Order_Book` FOREIGN KEY (`book_id`) REFERENCES `Books` (`book_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_Order_Customer` FOREIGN KEY (`customer_id`) REFERENCES `Customers` (`customer_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `Reviews`
--
ALTER TABLE `Reviews`
  ADD CONSTRAINT `FK_Review_Book` FOREIGN KEY (`book_id`) REFERENCES `Books` (`book_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `Users`
--
ALTER TABLE `Users`
  ADD CONSTRAINT `users_ibfk_1` FOREIGN KEY (`group_id`) REFERENCES `UserGroups` (`group_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
