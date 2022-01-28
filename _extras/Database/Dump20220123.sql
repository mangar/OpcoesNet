CREATE DATABASE  IF NOT EXISTS `opcoesnet` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `opcoesnet`;
-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: opcoesnet
-- ------------------------------------------------------
-- Server version	8.0.28

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `acoes`
--

DROP TABLE IF EXISTS `acoes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `acoes` (
  `id` int NOT NULL AUTO_INCREMENT,
  `ticker` varchar(50) NOT NULL,
  `quantidade` int NOT NULL DEFAULT '0',
  `preco_medio` decimal(10,2) NOT NULL DEFAULT '0.00',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `acoes`
--

LOCK TABLES `acoes` WRITE;
/*!40000 ALTER TABLE `acoes` DISABLE KEYS */;
INSERT INTO `acoes` (`id`, `ticker`, `quantidade`, `preco_medio`) VALUES (16,'ITUB4',500,26.97),(26,'BBDC4',2000,21.67),(32,'MGLU3',500,15.00);
/*!40000 ALTER TABLE `acoes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `acoes_movimentacoes`
--

DROP TABLE IF EXISTS `acoes_movimentacoes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `acoes_movimentacoes` (
  `id` int NOT NULL AUTO_INCREMENT,
  `acoes_id` int NOT NULL,
  `quantidade` int NOT NULL DEFAULT '0',
  `preco` decimal(10,2) NOT NULL DEFAULT '0.00',
  `descricao` text,
  `data_registro` date DEFAULT NULL,
  `createdAt` datetime NOT NULL,
  `updatedAt` datetime NOT NULL,
  PRIMARY KEY (`id`),
  KEY `acoes_id` (`acoes_id`),
  CONSTRAINT `acoes_movimentacoes_ibfk_1` FOREIGN KEY (`acoes_id`) REFERENCES `acoes` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `acoes_movimentacoes`
--

LOCK TABLES `acoes_movimentacoes` WRITE;
/*!40000 ALTER TABLE `acoes_movimentacoes` DISABLE KEYS */;
INSERT INTO `acoes_movimentacoes` (`id`, `acoes_id`, `quantidade`, `preco`, `descricao`, `data_registro`, `createdAt`, `updatedAt`) VALUES (26,32,100,10.00,'','2022-01-23','2022-01-23 21:39:37','2022-01-23 21:39:37'),(27,32,100,15.00,'','2022-01-23','2022-01-23 21:39:43','2022-01-23 21:39:43'),(28,32,200,20.00,'','2022-01-23','2022-01-23 21:39:48','2022-01-23 21:39:48'),(29,32,100,10.00,'','2022-01-23','2022-01-23 21:44:07','2022-01-23 21:44:07');
/*!40000 ALTER TABLE `acoes_movimentacoes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'opcoesnet'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-01-23 21:51:14
