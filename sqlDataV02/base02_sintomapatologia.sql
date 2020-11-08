-- MySQL dump 10.13  Distrib 8.0.21, for Win64 (x86_64)
--
-- Host: localhost    Database: base02
-- ------------------------------------------------------
-- Server version	8.0.21

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
-- Table structure for table `sintomapatologia`
--

DROP TABLE IF EXISTS `sintomapatologia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sintomapatologia` (
  `idsintomasPato` int NOT NULL AUTO_INCREMENT,
  `idsintomas` int NOT NULL,
  `idpatologia` int NOT NULL,
  `coeficiente` int DEFAULT NULL,
  PRIMARY KEY (`idsintomasPato`),
  KEY `idpatologia` (`idpatologia`),
  KEY `idsintomas` (`idsintomas`),
  CONSTRAINT `sintomapatologia_ibfk_1` FOREIGN KEY (`idpatologia`) REFERENCES `patologia` (`idpatologia`),
  CONSTRAINT `sintomapatologia_ibfk_2` FOREIGN KEY (`idsintomas`) REFERENCES `sintomas` (`idsintomas`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sintomapatologia`
--

LOCK TABLES `sintomapatologia` WRITE;
/*!40000 ALTER TABLE `sintomapatologia` DISABLE KEYS */;
INSERT INTO `sintomapatologia` VALUES (10,7,2,10),(11,4,2,50),(26,2,4,30),(29,1,6,15),(30,3,6,16);
/*!40000 ALTER TABLE `sintomapatologia` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-11-08  0:44:55
