-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: propet
-- ------------------------------------------------------
-- Server version	5.7.16-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `adocao`
--

DROP TABLE IF EXISTS `adocao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `adocao` (
  `cpf` varchar(21) DEFAULT NULL,
  `idCao` int(11) DEFAULT NULL,
  `dataAdocao` datetime DEFAULT NULL,
  `idAdocao` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`idAdocao`),
  KEY `cpf` (`cpf`),
  KEY `idCao` (`idCao`),
  CONSTRAINT `adocao_ibfk_1` FOREIGN KEY (`cpf`) REFERENCES `pessoa` (`cpf`),
  CONSTRAINT `adocao_ibfk_2` FOREIGN KEY (`idCao`) REFERENCES `cachorro` (`idCao`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `adocao`
--

LOCK TABLES `adocao` WRITE;
/*!40000 ALTER TABLE `adocao` DISABLE KEYS */;
INSERT INTO `adocao` VALUES ('111.111.111-11',50006,'2016-11-29 00:00:00',1),('222.222.222-22',50004,'2016-11-29 00:00:00',2);
/*!40000 ALTER TABLE `adocao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cachorro`
--

DROP TABLE IF EXISTS `cachorro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cachorro` (
  `nomeCao` varchar(20) DEFAULT NULL,
  `raca` varchar(50) DEFAULT NULL,
  `sexo` char(1) DEFAULT NULL,
  `idade` varchar(20) DEFAULT NULL,
  `cor` varchar(20) DEFAULT NULL,
  `bairro` varchar(50) DEFAULT NULL,
  `porte` varchar(30) DEFAULT NULL,
  `vacinado` tinyint(1) DEFAULT NULL,
  `observacao` varchar(100) DEFAULT NULL,
  `idCao` int(11) NOT NULL AUTO_INCREMENT,
  `dataRegistro` datetime DEFAULT NULL,
  `peso` float DEFAULT NULL,
  `falecido` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idCao`)
) ENGINE=InnoDB AUTO_INCREMENT=50010 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cachorro`
--

LOCK TABLES `cachorro` WRITE;
/*!40000 ALTER TABLE `cachorro` DISABLE KEYS */;
INSERT INTO `cachorro` VALUES ('Cachorro externo','Raça Não Definida (RND)','F','Filhote','Amarelo','Jardim Cruzeiro Do Sul','Mini',0,'',50001,'2016-11-29 00:00:00',NULL,0),('Paçoca','Raça Não Definida (RND)','F','Filhote','Tigrado','Cidade Jardim','Pequeno',1,'',50002,'2016-11-29 00:00:00',NULL,0),('Bilu','Bichon Frisé','M','5-6 anos','Branco','Cidade Universitária','Mini',0,'',50003,'2016-11-01 00:00:00',NULL,0),('Totó','Akita Americano','F','1-2 anos','Amarelo','Jardim Albertini','Pequeno',1,'',50004,'2016-11-09 00:00:00',NULL,0),('Kite','Golden Retriever','M','1-2 anos','Dourado','Jardim Centenário','Grande',1,'',50005,'2016-11-08 00:00:00',NULL,0),('Princesa','Akita Inu','F','3-4 anos','Branco','Azulville','Pequeno/Médio',1,'',50006,'0201-11-29 00:00:00',NULL,0),('Bola','Bichon Frisé','F','5-6 anos','Creme','Cidade Jardim','Médio',0,'',50007,'0201-11-29 00:00:00',NULL,0),('Killer','Chihuahua','M','7-8 anos','Dourado','Centro Comunitário','Mini',1,'',50008,'0201-11-29 00:00:00',NULL,0),('Loco','Raça Não Definida (RND)','M','7-8 anos','Bicolor','Bosque São Carlos','Gigante',0,'',50009,'0201-11-29 00:00:00',NULL,0);
/*!40000 ALTER TABLE `cachorro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cachorrodoacao`
--

DROP TABLE IF EXISTS `cachorrodoacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cachorrodoacao` (
  `cpfDono` varchar(21) DEFAULT NULL,
  `nomeCao` varchar(20) DEFAULT NULL,
  `raca` varchar(50) DEFAULT NULL,
  `sexo` char(1) DEFAULT NULL,
  `idade` varchar(20) DEFAULT NULL,
  `cor` varchar(20) DEFAULT NULL,
  `bairro` varchar(50) DEFAULT NULL,
  `porte` varchar(30) DEFAULT NULL,
  `vacinado` tinyint(1) DEFAULT NULL,
  `observacao` varchar(100) DEFAULT NULL,
  `idCao` int(11) NOT NULL AUTO_INCREMENT,
  `dataRegistro` datetime DEFAULT NULL,
  `falecido` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idCao`),
  KEY `cpfDono` (`cpfDono`),
  CONSTRAINT `cachorrodoacao_ibfk_1` FOREIGN KEY (`cpfDono`) REFERENCES `pessoa` (`cpf`)
) ENGINE=InnoDB AUTO_INCREMENT=50002 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cachorrodoacao`
--

LOCK TABLES `cachorrodoacao` WRITE;
/*!40000 ALTER TABLE `cachorrodoacao` DISABLE KEYS */;
INSERT INTO `cachorrodoacao` VALUES ('444.444.444-44','Cachorro externo','Raça Não Definida (RND)','F','Filhote','Amarelo','Jardim Cruzeiro Do Sul','Mini',0,'',50000,'2016-11-29 00:00:00',0),('444.444.444-44','Cachorro externo','Akita Americano','M','3-4 anos','Amarelo','Jardim Cruzeiro Do Sul','Mini',1,'',50001,'2016-11-29 00:00:00',0);
/*!40000 ALTER TABLE `cachorrodoacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estoque`
--

DROP TABLE IF EXISTS `estoque`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `estoque` (
  `idEstoque` int(11) NOT NULL AUTO_INCREMENT,
  `idProduto` int(11) DEFAULT NULL,
  `quantidade` mediumtext,
  `dataRegistro` datetime DEFAULT NULL,
  PRIMARY KEY (`idEstoque`),
  KEY `estoque_ibfk_1` (`idProduto`),
  CONSTRAINT `estoque_ibfk_1` FOREIGN KEY (`idProduto`) REFERENCES `produto` (`idProduto`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estoque`
--

LOCK TABLES `estoque` WRITE;
/*!40000 ALTER TABLE `estoque` DISABLE KEYS */;
INSERT INTO `estoque` VALUES (11,27,'0','2016-11-29 00:00:00'),(12,28,'0','2016-11-29 00:00:00'),(13,29,'0','2016-11-29 00:00:00'),(14,30,'0','2016-11-29 00:00:00'),(15,31,'0','2016-11-29 00:00:00'),(16,32,'0','2016-11-29 00:00:00'),(17,33,'0','2016-11-29 00:00:00'),(18,34,'0','2016-11-29 00:00:00'),(19,35,'0','2016-11-29 00:00:00'),(20,36,'0','2016-11-29 00:00:00'),(21,27,'20','2016-11-29 00:00:00'),(22,28,'15','2016-11-29 00:00:00'),(23,29,'13','2016-11-29 00:00:00'),(24,30,'8','2016-11-29 00:00:00'),(25,31,'30','2016-11-29 00:00:00'),(26,32,'5','2016-11-29 00:00:00'),(27,33,'7','2016-11-29 00:00:00'),(28,34,'9','2016-11-29 00:00:00'),(29,35,'4','2016-11-29 00:00:00');
/*!40000 ALTER TABLE `estoque` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pessoa`
--

DROP TABLE IF EXISTS `pessoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pessoa` (
  `nome` varchar(50) DEFAULT NULL,
  `cpf` varchar(21) NOT NULL,
  `endereco` varchar(100) DEFAULT NULL,
  `cep` varchar(12) DEFAULT NULL,
  `numero` int(11) DEFAULT NULL,
  `complemento` varchar(50) DEFAULT NULL,
  `bairro` varchar(50) DEFAULT NULL,
  `telefone` varchar(16) DEFAULT NULL,
  `celular` varchar(16) DEFAULT NULL,
  `email` varchar(254) DEFAULT NULL,
  `interesse` varchar(20) DEFAULT NULL,
  `porteInteresse` varchar(20) DEFAULT NULL,
  `dataRegistro` datetime DEFAULT NULL,
  `cidade` varchar(50) DEFAULT NULL,
  `semInteresse` char(1) DEFAULT NULL,
  PRIMARY KEY (`cpf`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pessoa`
--

LOCK TABLES `pessoa` WRITE;
/*!40000 ALTER TABLE `pessoa` DISABLE KEYS */;
INSERT INTO `pessoa` VALUES ('José Silva','111.111.111-11','Rua Um','11111-111',20,'','Condomínio Oscar Barros','(  )     -','(11) 1 1111-1111','','Adotar','Pequeno/Médio','2016-11-29 00:00:00','São Carlos','N'),('Patrícia Rocha','222.222.222-22','Rua Dura Igual Pedra','22222-222',24,'','Água Vermelha','(22) 2222-2222','(  )       -','','Adotar','Pequeno','2016-11-29 00:00:00','São Carlos','N'),('Firmino Firme','333.333.333-33','Rua Concreta','22222-222',1000,'','Jardim Cardinalli','(  )     -','(  )       -','firmefirmino@rockmail.com','Doar','Qualquer Porte','2016-11-29 00:00:00','São Carlos','N'),('Joao Dias','337.197.498-78','Alameda do Churras do Jao','11111-111',116,'','Cidade Jardim','(11) 1111-1111','(  )       -','','Adotar','Qualquer Porte','2016-11-29 00:00:00','São Carlos','N'),('Firmino Firme','444.444.444-44','Rua Concreta','11111-111',1000,'','Jardim Cruzeiro Do Sul','(11) 1111-1111','(  )       -','','Doar','Qualquer Porte','2016-11-29 00:00:00','São Carlos','N');
/*!40000 ALTER TABLE `pessoa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produto`
--

DROP TABLE IF EXISTS `produto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produto` (
  `idProduto` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) DEFAULT NULL,
  `unidadeMedida` varchar(20) DEFAULT NULL,
  `categoria` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idProduto`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produto`
--

LOCK TABLES `produto` WRITE;
/*!40000 ALTER TABLE `produto` DISABLE KEYS */;
INSERT INTO `produto` VALUES (27,'Pedigree P','Quilograma(kg)','Ração para Porte Pequeno'),(28,'DogChow P','Quilograma(kg)','Ração para Porte Pequeno'),(29,'Royal Cannin M','Quilograma(kg)','Ração para Porte Pequeno/Médio'),(30,'Pedigree G','Quilograma(kg)','Ração para Porte Grande'),(31,'Royal Cannin Gigantes','Quilograma(kg)','Ração para Porte Gigante'),(32,'Johnson','Litro(L)','Shampoo'),(33,'DogLab','Unidade(Un)','Vacina V8'),(34,'DogVDEZ','Unidade(Un)','Vacina V10'),(35,'DogFeliz','Unidade(Un)','Vacina Anti-Rábica'),(36,'Dog Saudavel','Unidade(Un)','Vacina Leishmaniose');
/*!40000 ALTER TABLE `produto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `nome` varchar(20) NOT NULL,
  `senha` varchar(20) DEFAULT NULL,
  `administrador` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`nome`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES ('admin','admin',1);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'propet'
--

--
-- Dumping routines for database 'propet'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-11-29 18:51:37
