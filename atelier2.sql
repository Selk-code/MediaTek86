-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 02 juin 2026 à 20:45
-- Version du serveur : 8.4.7
-- Version de PHP : 8.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `atelier2`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(12, '2026-10-07 00:00:00', '2026-10-14 00:00:00', 2),
(12, '2026-07-02 00:00:00', '2026-08-31 00:00:00', 1),
(11, '2026-06-05 00:00:00', '2026-06-12 00:00:00', 4),
(0, '2026-06-02 00:00:00', '2026-06-05 00:00:00', 0),
(4, '2025-05-13 00:00:00', '2025-08-10 00:00:00', 4),
(3, '2025-05-10 00:00:00', '2025-08-07 00:00:00', 3),
(2, '2025-05-07 00:00:00', '2025-08-04 00:00:00', 2),
(1, '2025-05-04 00:00:00', '2025-12-01 00:00:00', 1),
(10, '2025-05-01 00:00:00', '2025-11-30 00:00:00', 4),
(9, '2025-04-28 00:00:00', '2025-11-27 00:00:00', 3),
(8, '2025-04-25 00:00:00', '2025-11-24 00:00:00', 2),
(7, '2025-04-22 00:00:00', '2025-11-21 00:00:00', 1),
(6, '2025-04-19 00:00:00', '2025-11-18 00:00:00', 4),
(5, '2026-06-03 00:00:00', '2026-06-05 00:00:00', 3),
(4, '2025-04-13 00:00:00', '2025-11-12 00:00:00', 2),
(3, '2025-04-10 00:00:00', '2025-11-09 00:00:00', 1),
(2, '2025-04-07 00:00:00', '2025-11-06 00:00:00', 4),
(1, '2025-04-04 00:00:00', '2025-11-03 00:00:00', 3),
(10, '2025-04-01 00:00:00', '2025-10-30 00:00:00', 2),
(9, '2025-03-29 00:00:00', '2025-10-27 00:00:00', 1),
(8, '2025-03-26 00:00:00', '2025-10-24 00:00:00', 4),
(7, '2025-03-23 00:00:00', '2025-10-21 00:00:00', 3),
(6, '2025-03-20 00:00:00', '2025-10-18 00:00:00', 2),
(4, '2025-03-14 00:00:00', '2025-10-12 00:00:00', 4),
(3, '2025-03-11 00:00:00', '2025-10-09 00:00:00', 3),
(2, '2025-03-08 00:00:00', '2025-10-06 00:00:00', 2),
(1, '2025-03-05 00:00:00', '2025-10-03 00:00:00', 1),
(10, '2025-03-02 00:00:00', '2025-09-30 00:00:00', 4),
(9, '2025-02-27 00:00:00', '2025-09-27 00:00:00', 3),
(8, '2025-02-24 00:00:00', '2025-09-24 00:00:00', 2),
(7, '2025-02-21 00:00:00', '2025-09-21 00:00:00', 1),
(6, '2025-02-18 00:00:00', '2025-09-18 00:00:00', 4),
(4, '2025-02-12 00:00:00', '2025-09-12 00:00:00', 2),
(3, '2025-02-09 00:00:00', '2025-09-09 00:00:00', 1),
(2, '2025-02-06 00:00:00', '2025-09-06 00:00:00', 4),
(1, '2025-02-03 00:00:00', '2025-09-03 00:00:00', 3),
(10, '2025-01-30 00:00:00', '2025-08-31 00:00:00', 2),
(9, '2025-01-27 00:00:00', '2025-08-28 00:00:00', 1),
(8, '2025-01-24 00:00:00', '2025-08-25 00:00:00', 4),
(7, '2025-01-21 00:00:00', '2025-08-22 00:00:00', 3),
(6, '2025-01-18 00:00:00', '2025-08-19 00:00:00', 2),
(4, '2025-01-12 00:00:00', '2025-08-13 00:00:00', 4),
(3, '2025-01-09 00:00:00', '2025-08-10 00:00:00', 3),
(2, '2025-01-06 00:00:00', '2025-08-07 00:00:00', 2),
(1, '2025-01-03 00:00:00', '2025-08-05 00:00:00', 1);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `prenom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `tel` varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `mail` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Kellie', 'Franklin', '08 18 59 42 17', 'iaculis@aol.couk', 1),
(2, 'Dale', 'Richardson', '07 83 86 48 61', 'amet@aol.couk', 3),
(3, 'Sandra', 'Alvarado', '05 52 14 65 87', 'inceptos.hymenaeos@hotmail.com', 3),
(4, 'Grace', 'Pena', '01 17 77 68 66', 'fusce@aol.couk', 2),
(5, 'Shellie', 'Flores', '06 27 84 80 54', 'eu.odio@yahoo.couk', 1),
(6, 'Aaron', 'Mcfarland', '01 78 31 57 87', 'nascetur.ridiculus.mus@outlook.org', 2),
(8, 'Wanda', 'Salinas', '06 53 38 64 26', 'faucibus@outlook.edu', 3),
(9, 'Stuart', 'Alford', '02 27 98 18 33', 'sed.facilisis@icloud.ca', 1),
(10, 'Melanie', 'Charles', '05 69 14 57 56', 'et.rutrum@google.couk', 3),
(14, 'gabriel', 'paul', '06 06 06 06 06', 'paul@jacj.fr', 2);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  `pwd` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('Responsable', '254ad9a19af3b990a6643a443eb353d4d4584e66858bbdd2fb0cbd3b395c73d8');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
