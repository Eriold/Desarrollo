-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 29-10-2019 a las 05:10:17
-- Versión del servidor: 10.1.37-MariaDB
-- Versión de PHP: 7.3.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `production`
--
CREATE DATABASE IF NOT EXISTS `production` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_spanish_ci;
USE `production`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `client`
--

CREATE TABLE `client` (
  `id` varchar(15) COLLATE utf16_spanish2_ci NOT NULL,
  `name` varchar(50) COLLATE utf16_spanish2_ci DEFAULT NULL,
  `last_name` varchar(50) COLLATE utf16_spanish2_ci DEFAULT NULL,
  `e_mail` varchar(50) COLLATE utf16_spanish2_ci DEFAULT NULL,
  `telephoneNumber` int(11) DEFAULT NULL,
  `estimate_money` double NOT NULL,
  `project_scope` varchar(200) COLLATE utf16_spanish2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16 COLLATE=utf16_spanish2_ci;

--
-- Volcado de datos para la tabla `client`
--

INSERT INTO `client` (`id`, `name`, `last_name`, `e_mail`, `telephoneNumber`, `estimate_money`, `project_scope`) VALUES
('', '', '', '', 0, 0, ''),
('', '', '', '', 0, 0, ''),
('', '', '', '', 0, 0, ''),
('', '', '', '', 0, 0, ''),
('', '', '', '', 0, 0, ''),
('', '', '', '', 0, 0, '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `developer`
--

CREATE TABLE `developer` (
  `id` varchar(20) COLLATE utf8_spanish_ci NOT NULL,
  `name` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `lastName` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `e_mail` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `telephoneNumber` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `developer`
--

INSERT INTO `developer` (`id`, `name`, `lastName`, `e_mail`, `telephoneNumber`) VALUES
('', '', '', '', 0),
('', '', '', '', 0),
('', '', '', '', 0),
('', '', '', '', 0),
('', '', '', '', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `internalproductor`
--

CREATE TABLE `internalproductor` (
  `id` varchar(30) COLLATE utf8_spanish_ci NOT NULL,
  `name` varchar(30) COLLATE utf8_spanish_ci NOT NULL,
  `last_name` varchar(30) COLLATE utf8_spanish_ci NOT NULL,
  `email` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `telephone_number` int(20) NOT NULL,
  `job_title` varchar(30) COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `internalproductor`
--

INSERT INTO `internalproductor` (`id`, `name`, `last_name`, `email`, `telephone_number`, `job_title`) VALUES
('', '', '', '', 0, ''),
('', '', '', '', 0, ''),
('', '', '', '', 0, ''),
('', '', '', '', 0, ''),
('', '', '', '', 0, ''),
('', '', '', '', 0, ''),
('', '', '', '', 0, ''),
('', '', '', '', 0, ''),
('', '', '', '', 0, ''),
('', '', '', '', 0, ''),
('', '', '', '', 0, ''),
('', '', '', '', 0, ''),
('', '', '', '', 0, ''),
('', '', '', '', 0, ''),
('', '', '', '', 0, ''),
('', '', '', '', 0, ''),
('', '', '', '', 0, ''),
('', '', '', '', 0, ''),
('', '', '', '', 0, ''),
('', '', '', '', 0, ''),
('', '', '', '', 0, ''),
('', '', '', '', 0, ''),
('', '', '', '', 0, ''),
('', '', '', '', 0, ''),
('', '', '', '', 0, ''),
('', '', '', '', 0, '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `processmonitoring`
--

CREATE TABLE `processmonitoring` (
  `id_Monitoring` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `status`
--

CREATE TABLE `status` (
  `name` varchar(50) COLLATE utf16_spanish2_ci DEFAULT NULL,
  `color` varchar(20) COLLATE utf16_spanish2_ci NOT NULL,
  `description_status` varchar(200) COLLATE utf16_spanish2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16 COLLATE=utf16_spanish2_ci;

--
-- Volcado de datos para la tabla `status`
--

INSERT INTO `status` (`name`, `color`, `description_status`) VALUES
('', '', ''),
('', '', ''),
('', '', ''),
('', '', ''),
('', '', ''),
('', '', ''),
('', '', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `taskgame`
--

CREATE TABLE `taskgame` (
  `nameTask` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `descriptionTask` varchar(200) COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `taskgame`
--

INSERT INTO `taskgame` (`nameTask`, `descriptionTask`) VALUES
('', ''),
('', ''),
('', ''),
('', ''),
('', ''),
('', ''),
('', ''),
('', ''),
('', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `videogame`
--

CREATE TABLE `videogame` (
  `id_videogame` varchar(20) COLLATE utf16_spanish2_ci NOT NULL,
  `name_videogame` varchar(100) COLLATE utf16_spanish2_ci NOT NULL,
  `thematic` varchar(100) COLLATE utf16_spanish2_ci NOT NULL,
  `startDate` datetime DEFAULT NULL,
  `finishDate` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16 COLLATE=utf16_spanish2_ci;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
