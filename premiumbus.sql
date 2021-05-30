-- phpMyAdmin SQL Dump
-- version 4.6.6
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: May 26, 2021 at 09:33 PM
-- Server version: 5.7.17-log
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `premiumbus`
--

-- --------------------------------------------------------

--
-- Table structure for table `ticket`
--

CREATE TABLE `ticket` (
  `id` int(11) NOT NULL,
  `username` varchar(32) NOT NULL,
  `sales_time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `journey_date` date NOT NULL,
  `schedule_departure` varchar(11) NOT NULL,
  `schedule_arrival` varchar(11) NOT NULL,
  `From_To` varchar(32) NOT NULL,
  `price` decimal(8,2) NOT NULL,
  `trip_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `ticket`
--

INSERT INTO `ticket` (`id`, `username`, `sales_time`, `journey_date`, `schedule_departure`, `schedule_arrival`, `From_To`, `price`, `trip_id`) VALUES
(27, 'test', '2021-05-25 23:55:59', '2020-12-01', '6:00', '3:15', 'From Sumy TO Kiev', '45.00', 0),
(28, 'test', '2021-05-25 23:56:03', '2020-12-01', '6:00', '3:15', 'From Sumy TO Kiev', '45.00', 0),
(38, 'test', '2021-05-26 18:11:02', '2020-12-01', '6:00', '3:15', 'From Sumy TO Kiev', '45.00', 0),
(39, 'test', '2021-05-26 18:11:13', '2020-12-01', '6:00', '3:15', 'From Sumy TO Kiev', '45.00', 0),
(40, 'test', '2021-05-26 18:17:55', '2020-12-01', '6:00', '3:15', 'From Sumy TO Kiev', '45.00', 4);

-- --------------------------------------------------------

--
-- Table structure for table `trip`
--

CREATE TABLE `trip` (
  `id` int(11) NOT NULL,
  `departure_time` varchar(6) NOT NULL,
  `arrival_time` varchar(6) NOT NULL,
  `monthdate` varchar(10) NOT NULL,
  `numseats` int(11) NOT NULL,
  `freeseats` int(11) NOT NULL,
  `pfrom` varchar(32) NOT NULL,
  `pto` varchar(32) NOT NULL,
  `ticketprice` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='exact line schedule with arrival and departure time for the station_from and station_to';

--
-- Dumping data for table `trip`
--

INSERT INTO `trip` (`id`, `departure_time`, `arrival_time`, `monthdate`, `numseats`, `freeseats`, `pfrom`, `pto`, `ticketprice`) VALUES
(4, '3:15', '6:00', '2020.12.1', 33, 25, 'Sumy', 'Kiev', 45),
(5, '12:00', '3:00', '2021.5.20', 50, 47, 'Kiev', 'Sumy', 10);

-- --------------------------------------------------------

--
-- Table structure for table `user_account`
--

CREATE TABLE `user_account` (
  `id` int(11) NOT NULL,
  `username` varchar(64) NOT NULL,
  `password` varchar(64) NOT NULL,
  `first_name` varchar(64) NOT NULL,
  `last_name` varchar(64) NOT NULL,
  `registration_time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `role` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='list of all users who can sell tickets';

--
-- Dumping data for table `user_account`
--

INSERT INTO `user_account` (`id`, `username`, `password`, `first_name`, `last_name`, `registration_time`, `role`) VALUES
(1, 'admin', 'admin', ' Administrator', 'Potatoaaa', '2021-05-22 23:05:23', 'admin'),
(2, 'admin2', '123123', 'ada', 'maada', '2021-05-23 19:33:04', 'user'),
(3, 'test', 'test', 'momo', 'toto', '2021-05-23 19:54:36', 'user');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `ticket`
--
ALTER TABLE `ticket`
  ADD PRIMARY KEY (`id`),
  ADD KEY `ticket_schedule_arrival` (`schedule_arrival`),
  ADD KEY `ticket_schedule_departure` (`schedule_departure`),
  ADD KEY `seat_reserved` (`From_To`);

--
-- Indexes for table `trip`
--
ALTER TABLE `trip`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `schedule_ak_1` (`departure_time`);

--
-- Indexes for table `user_account`
--
ALTER TABLE `user_account`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `user_account_ak_1` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `ticket`
--
ALTER TABLE `ticket`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=43;
--
-- AUTO_INCREMENT for table `trip`
--
ALTER TABLE `trip`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `user_account`
--
ALTER TABLE `user_account`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
