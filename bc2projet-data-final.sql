-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : ven. 08 oct. 2021 à 11:37
-- Version du serveur : 10.4.21-MariaDB
-- Version de PHP : 7.4.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `bc2projet`
--

-- --------------------------------------------------------

--
-- Structure de la table `categories`
--

CREATE TABLE `categories` (
  `Id` int(11) NOT NULL,
  `Libelle` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `categories`
--

INSERT INTO `categories` (`Id`, `Libelle`) VALUES
(1, 'Autre'),
(2, 'Informatique'),
(3, 'Sport'),
(5, 'Alimentaire'),
(6, 'Jeux vidéo'),
(7, 'Ecole'),
(8, 'Véhicule');

-- --------------------------------------------------------

--
-- Structure de la table `produits`
--

CREATE TABLE `produits` (
  `Id` int(11) NOT NULL,
  `Libelle` longtext DEFAULT NULL,
  `Description` longtext DEFAULT NULL,
  `Price` double NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Img` longtext DEFAULT NULL,
  `DatePublish` datetime(6) NOT NULL,
  `SoldAt` datetime(6) NOT NULL,
  `Sold` tinyint(1) NOT NULL,
  `SellerId` int(11) NOT NULL,
  `PurchaserId` int(11) NOT NULL,
  `CategoryId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `produits`
--

INSERT INTO `produits` (`Id`, `Libelle`, `Description`, `Price`, `Quantity`, `Img`, `DatePublish`, `SoldAt`, `Sold`, `SellerId`, `PurchaserId`, `CategoryId`) VALUES
(2, 'Stylo', 'Stylo neuf de couleur Noir', 10, 999, 'stylo.jpg', '2021-10-07 19:38:32.000000', '2021-10-28 19:38:32.000000', 0, 1, 1, 7),
(3, 'PC Portable', 'Chromebook - 8Go RAM - Intel I5 3.8GHz', 699, 10, 'PC-Portable.jpg', '2021-10-07 19:38:32.000000', '2021-10-28 19:38:32.000000', 0, 1, 1, 2),
(6, 'Tablette graphique', 'Sublime tablette graphique !', 499, 25, 'tabletteGraphique.jpg', '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000', 0, 1, 1, 2),
(7, 'Sandwich', 'Sandwich poulet crudité', 2.5, 50, 'sandwich.jpg', '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000', 0, 1, 1, 5),
(8, 'Tour Gamer', 'Tour de gamer pour jouer à vos jeux vidéos favoris !', 999, 2, 'tourGamer.jpg', '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000', 0, 1, 1, 2),
(9, 'Battlefield 2042', 'Version dématérialiser du jeu sur PC', 59.99, 25, 'battlefield2042.jpg', '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000', 0, 1, 1, 6),
(10, 'Tesla Model X', 'Tesla Model X - 25000 km', 60000, 10, 'teslaModelX.jpg', '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000', 0, 1, 1, 8),
(11, 'Pack de ballons de football', 'Pack de 2 ballons de foot', 14, 635, 'gray.png', '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000', 0, 1, 1, 3),
(12, 'Chateau', 'Haut de France - 1300m² - Jardin & Piscine', 2400000, 1, 'gray.png', '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000', 0, 1, 1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `users`
--

CREATE TABLE `users` (
  `Id` int(11) NOT NULL,
  `Username` longtext DEFAULT NULL,
  `Email` longtext DEFAULT NULL,
  `Password` longtext DEFAULT NULL,
  `Roles` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `users`
--

INSERT INTO `users` (`Id`, `Username`, `Email`, `Password`, `Roles`) VALUES
(1, 'Unknow', 'Admin@myges.fr', '123456', 'ROLE_ADMIN'),
(4, 'User', 'user@myges.fr', '123456', 'ROLE_USER'),
(5, 'Anonyme', 'anonyme@myges.fr', '123456', 'ROLE_ANONYME');

-- --------------------------------------------------------

--
-- Structure de la table `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20211007173657_1', '5.0.10');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`Id`);

--
-- Index pour la table `produits`
--
ALTER TABLE `produits`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Produits_CategoryId` (`CategoryId`),
  ADD KEY `IX_Produits_PurchaserId` (`PurchaserId`),
  ADD KEY `IX_Produits_SellerId` (`SellerId`);

--
-- Index pour la table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`Id`);

--
-- Index pour la table `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `categories`
--
ALTER TABLE `categories`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT pour la table `produits`
--
ALTER TABLE `produits`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT pour la table `users`
--
ALTER TABLE `users`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `produits`
--
ALTER TABLE `produits`
  ADD CONSTRAINT `FK_Produits_Categories_CategoryId` FOREIGN KEY (`CategoryId`) REFERENCES `categories` (`Id`),
  ADD CONSTRAINT `FK_Produits_Users_PurchaserId` FOREIGN KEY (`PurchaserId`) REFERENCES `users` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Produits_Users_SellerId` FOREIGN KEY (`SellerId`) REFERENCES `users` (`Id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
