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
-- Table structure for table `diagnosticos`
--

DROP TABLE IF EXISTS `diagnosticos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `diagnosticos` (
  `iddiagnosticos` int NOT NULL AUTO_INCREMENT,
  `idPatologia` int DEFAULT NULL,
  `quierechat` int DEFAULT NULL,
  `idPaciente` int DEFAULT NULL,
  `idDoctor` int DEFAULT NULL,
  `estado` varchar(45) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `gravedad` int DEFAULT NULL,
  PRIMARY KEY (`iddiagnosticos`),
  KEY `idPaciente` (`idPaciente`),
  KEY `idDoctor` (`idDoctor`),
  KEY `idPatologia` (`idPatologia`),
  CONSTRAINT `diagnosticos_ibfk_1` FOREIGN KEY (`idPaciente`) REFERENCES `usuarios` (`idUsuarios`),
  CONSTRAINT `diagnosticos_ibfk_2` FOREIGN KEY (`idDoctor`) REFERENCES `usuarios` (`idUsuarios`),
  CONSTRAINT `diagnosticos_ibfk_3` FOREIGN KEY (`idPatologia`) REFERENCES `patologia` (`idpatologia`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diagnosticos`
--

LOCK TABLES `diagnosticos` WRITE;
/*!40000 ALTER TABLE `diagnosticos` DISABLE KEYS */;
INSERT INTO `diagnosticos` VALUES (29,2,1,2,NULL,'pendiente',45),(30,2,1,2,NULL,'pendiente',45),(31,2,1,2,NULL,'pendiente',45),(32,2,1,2,NULL,'pendiente',45),(33,2,NULL,2,NULL,'pendiente',45),(34,4,1,2,NULL,'pendiente',30),(35,6,1,2,NULL,'pendiente',100);
/*!40000 ALTER TABLE `diagnosticos` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-11-08  0:44:56
