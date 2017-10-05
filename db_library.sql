-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: db_library
-- ------------------------------------------------------
-- Server version	5.6.21-log

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
-- Dumping data for table `tblauthor`
--

LOCK TABLES `tblauthor` WRITE;
/*!40000 ALTER TABLE `tblauthor` DISABLE KEYS */;
INSERT INTO `tblauthor` VALUES (1,'John','L','Doe',NULL),(2,'Susan','Tayo','Baker',NULL),(3,'Susana','M','Tayo',NULL),(4,'Dennis','L','Ritchie',NULL),(5,'Steven','M','Jobs',NULL),(6,NULL,NULL,NULL,'Department of Education'),(7,'Susan','M','Baker',NULL),(8,'Billy','','Gates',NULL),(10,'Billy','Joe','Crawford',NULL),(11,'Richard','J','Bullock',NULL),(20,'John','Le','Doe',NULL);
/*!40000 ALTER TABLE `tblauthor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tblbook`
--

LOCK TABLES `tblbook` WRITE;
/*!40000 ALTER TABLE `tblbook` DISABLE KEYS */;
INSERT INTO `tblbook` VALUES (1,'100.1 D64t c2001','The hunter\'s hobby','100.1','D64t',2001,199,1,3,'1. includes\r\nAlgebra and Chemistry','ill.',1,NULL,'',2),(2,'100.1 D64t c2001','The hunter\'s hobby','100.1','D64t',2001,199,2,4,NULL,'ill.',1,NULL,'',2),(3,'200.1 J25s c2000','Science and Everything','200.1','J25s',2000,200,NULL,5,'1. Includes Biological Structure of Life','ill',2,'1111-1111-1111-1111','',3),(5,'123.12 D12h c2000','Hanabi','123.12','D12h',2000,200,NULL,1,'1. Includes japanese language',NULL,2,NULL,'',3);
/*!40000 ALTER TABLE `tblbook` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tblbookauthor`
--

LOCK TABLES `tblbookauthor` WRITE;
/*!40000 ALTER TABLE `tblbookauthor` DISABLE KEYS */;
INSERT INTO `tblbookauthor` VALUES (10,5,6),(39,3,2),(40,3,5),(41,3,8),(42,3,10),(43,3,11),(44,1,1),(48,2,1);
/*!40000 ALTER TABLE `tblbookauthor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tblborrowedbook`
--

LOCK TABLES `tblborrowedbook` WRITE;
/*!40000 ALTER TABLE `tblborrowedbook` DISABLE KEYS */;
INSERT INTO `tblborrowedbook` VALUES (1,5,'110562',1,NULL,NULL,NULL,NULL,NULL,'Request'),(2,3,'110563',1,'2017-10-05 21:48:01','2017-10-10 22:01:12',1,3,3,'Received'),(3,5,'110563',1,'2017-10-05 21:46:29','2017-10-09 21:50:03',1,3,3,'Received');
/*!40000 ALTER TABLE `tblborrowedbook` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tblborrower`
--

LOCK TABLES `tblborrower` WRITE;
/*!40000 ALTER TABLE `tblborrower` DISABLE KEYS */;
INSERT INTO `tblborrower` VALUES ('110562','Others','Bernard','Herrera','Lao','1993-09-28','Catmon Malabon','Approved'),('110563','Others','Leonardo',NULL,'Da Vinci','1994-09-28','Catmon Malabon City','Approved'),('123123123123','Student','John',NULL,'Doe','2009-10-27','New York City','Approved');
/*!40000 ALTER TABLE `tblborrower` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbllogs`
--

LOCK TABLES `tbllogs` WRITE;
/*!40000 ALTER TABLE `tbllogs` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbllogs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tblpenalty`
--

LOCK TABLES `tblpenalty` WRITE;
/*!40000 ALTER TABLE `tblpenalty` DISABLE KEYS */;
INSERT INTO `tblpenalty` VALUES (2,3,'Sanctioned'),(3,2,'Penaltied');
/*!40000 ALTER TABLE `tblpenalty` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tblpublisher`
--

LOCK TABLES `tblpublisher` WRITE;
/*!40000 ALTER TABLE `tblpublisher` DISABLE KEYS */;
INSERT INTO `tblpublisher` VALUES (1,'Ligaya Publishing House','Quezon City'),(2,'Liwayway Publishing Corporation','Navotas City');
/*!40000 ALTER TABLE `tblpublisher` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tblsubject`
--

LOCK TABLES `tblsubject` WRITE;
/*!40000 ALTER TABLE `tblsubject` DISABLE KEYS */;
INSERT INTO `tblsubject` VALUES (2,'T.L.E'),(3,'Science'),(4,'Mathematics'),(6,'Filipino'),(7,'English');
/*!40000 ALTER TABLE `tblsubject` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `tbluser`
--

LOCK TABLES `tbluser` WRITE;
/*!40000 ALTER TABLE `tbluser` DISABLE KEYS */;
INSERT INTO `tbluser` VALUES (1,'admin','7EF2EE6C9A2B3DBF19FA5A5CEEC7EE8ED51A0C03B0D4E21BE8CFE74C79A25990','vPNpT',NULL,'admin',NULL,'admin'),(2,'ivy','3E118E34C1FDC4CCF44B38AC9D69F7ECD47274EF6A34D979CE84E1FAEA6D0FE3','IPNe','140134','Ivyrose','Veranda','Ruiz'),(3,'bernard','C96DF173325E870D759332F21C7592E8174A14CDD777F2C71EBB030CAC15FC1B','Tnm','110562','Bernard','Herrera','Lao'),(4,'leo','','',NULL,'fn',NULL,'ln'),(5,'opacs','062F921D150A420C61AB28FB1E1628B30E591723BD342E309EDACED406C90A53','tmn','1234567','leonardo','','da vinci'),(6,'ernie','071C073ADB1D0216F390FD5C8838E4EFB8D95435D0B15B403F64A7BD8FBA8C48','jYI','140599','Ernie','Pablo','Pascual'),(7,'ace','8EF114608D1DCDEBC1428935E99593FB6DD48035E0C798086A080B4041491B76','2VV1','123456','Ace','Leongson','Francisco');
/*!40000 ALTER TABLE `tbluser` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'db_library'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-10-10 22:55:53
