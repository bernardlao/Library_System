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
-- Table structure for table `tblauthor`
--

DROP TABLE IF EXISTS `tblauthor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblauthor` (
  `authorID` bigint(20) NOT NULL AUTO_INCREMENT,
  `fname` varchar(100) DEFAULT NULL,
  `mname` varchar(100) DEFAULT NULL,
  `lname` varchar(100) DEFAULT NULL,
  `corporation` varchar(300) DEFAULT NULL,
  PRIMARY KEY (`authorID`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tblbook`
--

DROP TABLE IF EXISTS `tblbook`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblbook` (
  `bookID` bigint(20) NOT NULL AUTO_INCREMENT,
  `callNumber` varchar(100) DEFAULT NULL,
  `title` varchar(300) NOT NULL,
  `deweyDecimal` varchar(100) DEFAULT NULL,
  `cattersNo` varchar(100) DEFAULT NULL,
  `yearOfPublication` int(11) DEFAULT NULL,
  `pages` int(11) DEFAULT NULL,
  `volume` int(11) DEFAULT NULL,
  `quantity` int(11) NOT NULL,
  `noteArea` varchar(300) DEFAULT NULL,
  `typeOfIllustration` varchar(100) DEFAULT NULL,
  `publisherID` bigint(20) NOT NULL,
  `ISBN` varchar(100) DEFAULT NULL,
  `isCopyright` bit(1) NOT NULL,
  `subjectID` bigint(20) NOT NULL,
  PRIMARY KEY (`bookID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tblbookauthor`
--

DROP TABLE IF EXISTS `tblbookauthor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblbookauthor` (
  `bookAuthorID` bigint(20) NOT NULL AUTO_INCREMENT,
  `bookID` bigint(20) NOT NULL,
  `authorID` bigint(20) NOT NULL,
  PRIMARY KEY (`bookAuthorID`),
  KEY `bookID_idx` (`bookID`),
  KEY `authorID_idx` (`authorID`),
  CONSTRAINT `authorID` FOREIGN KEY (`authorID`) REFERENCES `tblauthor` (`authorID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `bookID` FOREIGN KEY (`bookID`) REFERENCES `tblbook` (`bookID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=77 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tblborrowedbook`
--

DROP TABLE IF EXISTS `tblborrowedbook`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblborrowedbook` (
  `borrowedBookID` bigint(20) NOT NULL AUTO_INCREMENT,
  `bookID` bigint(20) NOT NULL,
  `borrowerID` varchar(100) NOT NULL,
  `quantity` int(11) NOT NULL,
  `dateBorrowed` datetime DEFAULT NULL,
  `dateReturned` datetime DEFAULT NULL,
  `dateAllowance` int(11) DEFAULT NULL,
  `ApproverUserID` bigint(20) DEFAULT NULL,
  `ReceiverUserID` bigint(20) DEFAULT NULL,
  `status` varchar(100) NOT NULL,
  PRIMARY KEY (`borrowedBookID`),
  KEY `borrowerID_idx` (`borrowerID`),
  KEY `bookID_idx` (`bookID`),
  KEY `approverUserID_idx` (`ApproverUserID`),
  KEY `receiverUserID_idx` (`ReceiverUserID`),
  CONSTRAINT `BBapproverUserID` FOREIGN KEY (`ApproverUserID`) REFERENCES `tbluser` (`userID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `BBbookID` FOREIGN KEY (`bookID`) REFERENCES `tblbook` (`bookID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `BBborrowerID` FOREIGN KEY (`borrowerID`) REFERENCES `tblborrower` (`borrowerID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `BBreceiverUserID` FOREIGN KEY (`ReceiverUserID`) REFERENCES `tbluser` (`userID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tblborrower`
--

DROP TABLE IF EXISTS `tblborrower`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblborrower` (
  `borrowerID` varchar(100) NOT NULL,
  `borrowerType` varchar(100) NOT NULL,
  `fname` varchar(100) NOT NULL,
  `mname` varchar(100) DEFAULT NULL,
  `lname` varchar(100) NOT NULL,
  `bdate` date NOT NULL,
  `address` varchar(300) NOT NULL,
  `status` varchar(100) NOT NULL,
  PRIMARY KEY (`borrowerID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbllogs`
--

DROP TABLE IF EXISTS `tbllogs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbllogs` (
  `logID` bigint(20) NOT NULL AUTO_INCREMENT,
  `userID` bigint(20) NOT NULL,
  `logTable` varchar(100) NOT NULL,
  `logType` varchar(100) NOT NULL,
  `logDescription` text NOT NULL,
  `logDate` datetime NOT NULL,
  PRIMARY KEY (`logID`)
) ENGINE=InnoDB AUTO_INCREMENT=150 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tblpenalty`
--

DROP TABLE IF EXISTS `tblpenalty`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblpenalty` (
  `penaltyID` bigint(20) NOT NULL AUTO_INCREMENT,
  `borrowedBookID` bigint(20) NOT NULL,
  `status` varchar(100) NOT NULL,
  PRIMARY KEY (`penaltyID`),
  KEY `PborrowedBookID_idx` (`borrowedBookID`),
  CONSTRAINT `PborrowedBookID` FOREIGN KEY (`borrowedBookID`) REFERENCES `tblborrowedbook` (`borrowedBookID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tblpublisher`
--

DROP TABLE IF EXISTS `tblpublisher`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblpublisher` (
  `publisherID` bigint(20) NOT NULL AUTO_INCREMENT,
  `publisherName` varchar(300) DEFAULT NULL,
  `address` varchar(300) DEFAULT NULL,
  PRIMARY KEY (`publisherID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tblsubject`
--

DROP TABLE IF EXISTS `tblsubject`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblsubject` (
  `subjectID` bigint(20) NOT NULL AUTO_INCREMENT,
  `subjectName` varchar(300) NOT NULL,
  PRIMARY KEY (`subjectID`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbluser`
--

DROP TABLE IF EXISTS `tbluser`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbluser` (
  `userID` bigint(20) NOT NULL AUTO_INCREMENT,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `salt` varchar(100) NOT NULL,
  `librarianID` varchar(100) DEFAULT NULL,
  `fname` varchar(100) NOT NULL,
  `mname` varchar(100) DEFAULT NULL,
  `lname` varchar(100) NOT NULL,
  PRIMARY KEY (`userID`),
  UNIQUE KEY `username_UNIQUE` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

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

-- Dump completed on 2017-10-16  5:16:01
