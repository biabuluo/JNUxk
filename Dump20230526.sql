-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: localhost    Database: jnujwxk
-- ------------------------------------------------------
-- Server version	8.0.31

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
-- Temporary view structure for view `allstudy_view`
--

DROP TABLE IF EXISTS `allstudy_view`;
/*!50001 DROP VIEW IF EXISTS `allstudy_view`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `allstudy_view` AS SELECT 
 1 AS `skid`,
 1 AS `uid`,
 1 AS `stuname`,
 1 AS `sex`,
 1 AS `major`,
 1 AS `cid`,
 1 AS `tid`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `allteach_view`
--

DROP TABLE IF EXISTS `allteach_view`;
/*!50001 DROP VIEW IF EXISTS `allteach_view`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `allteach_view` AS SELECT 
 1 AS `skid`,
 1 AS `cid`,
 1 AS `cname`,
 1 AS `points`,
 1 AS `tid`,
 1 AS `teaname`,
 1 AS `location`,
 1 AS `date_time`,
 1 AS `stunum`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `courselist`
--

DROP TABLE IF EXISTS `courselist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `courselist` (
  `cid` varchar(20) NOT NULL,
  `cname` varchar(50) NOT NULL,
  `points` int NOT NULL,
  PRIMARY KEY (`cid`),
  UNIQUE KEY `cname` (`cname`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `courselist`
--

LOCK TABLES `courselist` WRITE;
/*!40000 ALTER TABLE `courselist` DISABLE KEYS */;
INSERT INTO `courselist` VALUES ('c001','变形课',1),('c002','魔咒课',2),('c003','草药课',2),('c004','黑魔法防御术',2),('c005','魔药课',2);
/*!40000 ALTER TABLE `courselist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `datelimit`
--

DROP TABLE IF EXISTS `datelimit`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `datelimit` (
  `id` int NOT NULL AUTO_INCREMENT,
  `choose_s` date NOT NULL,
  `choose_e` date NOT NULL,
  `change_s` date NOT NULL,
  `change_e` date NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `datelimit`
--

LOCK TABLES `datelimit` WRITE;
/*!40000 ALTER TABLE `datelimit` DISABLE KEYS */;
INSERT INTO `datelimit` VALUES (1,'2024-01-03','9999-12-31','2024-01-01','9999-12-31');
/*!40000 ALTER TABLE `datelimit` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `studentlist`
--

DROP TABLE IF EXISTS `studentlist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `studentlist` (
  `uid` varchar(20) NOT NULL,
  `stuname` varchar(20) NOT NULL,
  `sex` varchar(20) DEFAULT NULL,
  `major` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`uid`),
  CONSTRAINT `sfk_uid` FOREIGN KEY (`uid`) REFERENCES `userlist` (`uid`) ON DELETE CASCADE,
  CONSTRAINT `studentlist_ibfk_1` FOREIGN KEY (`uid`) REFERENCES `userlist` (`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studentlist`
--

LOCK TABLES `studentlist` WRITE;
/*!40000 ALTER TABLE `studentlist` DISABLE KEYS */;
INSERT INTO `studentlist` VALUES ('2020101001','小宇宙','男','麻瓜研究'),('2020101002','影山茂夫','男','麻瓜研究'),('2020101003','哈利波特','男','魔咒工程'),('2020101004','赫敏','女','魔咒工程'),('2020101005','罗恩','男','魔咒工程'),('2020101006','马尔福','男','黑魔法技术'),('2020101007','隆巴顿','男','魔药工程'),('2020101008','卢娜','女','占卜科学与技术'),('2020101642','teststu','男','麻瓜研究');
/*!40000 ALTER TABLE `studentlist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `studytable`
--

DROP TABLE IF EXISTS `studytable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `studytable` (
  `skid` int NOT NULL,
  `uid` varchar(20) NOT NULL,
  PRIMARY KEY (`uid`,`skid`),
  KEY `skid` (`skid`),
  CONSTRAINT `studytable_ibfk_1` FOREIGN KEY (`uid`) REFERENCES `studentlist` (`uid`) ON DELETE CASCADE,
  CONSTRAINT `studytable_ibfk_2` FOREIGN KEY (`skid`) REFERENCES `teachtable` (`skid`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studytable`
--

LOCK TABLES `studytable` WRITE;
/*!40000 ALTER TABLE `studytable` DISABLE KEYS */;
INSERT INTO `studytable` VALUES (2,'2020101001'),(2,'2020101002'),(2,'2020101003'),(2,'2020101005'),(2,'2020101007'),(2,'2020101008'),(2,'2020101642'),(3,'2020101001'),(3,'2020101002'),(3,'2020101004'),(3,'2020101006'),(3,'2020101008'),(3,'2020101642'),(4,'2020101001'),(4,'2020101002'),(4,'2020101004'),(4,'2020101006'),(4,'2020101642'),(5,'2020101001'),(6,'2020101001'),(6,'2020101002'),(6,'2020101004'),(6,'2020101005'),(8,'2020101001'),(8,'2020101002'),(8,'2020101003'),(8,'2020101004'),(8,'2020101006'),(8,'2020101007'),(8,'2020101008'),(8,'2020101642'),(9,'2020101001'),(9,'2020101002'),(9,'2020101003'),(9,'2020101006'),(9,'2020101007'),(9,'2020101642'),(16,'2020101001'),(16,'2020101002'),(16,'2020101003'),(16,'2020101004'),(16,'2020101005'),(16,'2020101007'),(16,'2020101008'),(17,'2020101001'),(17,'2020101002'),(17,'2020101003'),(17,'2020101005'),(17,'2020101007'),(17,'2020101008'),(19,'2020101001'),(19,'2020101002'),(19,'2020101003'),(19,'2020101006'),(19,'2020101008'),(20,'2020101001'),(20,'2020101002'),(21,'2020101001'),(21,'2020101002'),(21,'2020101003'),(21,'2020101004'),(21,'2020101008'),(22,'2020101001'),(22,'2020101002'),(22,'2020101003'),(22,'2020101004'),(22,'2020101006'),(22,'2020101008'),(23,'2020101001'),(23,'2020101002'),(23,'2020101005'),(23,'2020101008'),(24,'2020101001'),(24,'2020101002'),(24,'2020101005');
/*!40000 ALTER TABLE `studytable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `teacherlist`
--

DROP TABLE IF EXISTS `teacherlist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `teacherlist` (
  `uid` varchar(20) NOT NULL,
  `teaname` varchar(50) NOT NULL,
  `sex` varchar(20) DEFAULT NULL,
  `college` varchar(70) NOT NULL,
  `title` varchar(50) NOT NULL,
  PRIMARY KEY (`uid`),
  CONSTRAINT `tfk_uid` FOREIGN KEY (`uid`) REFERENCES `userlist` (`uid`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teacherlist`
--

LOCK TABLES `teacherlist` WRITE;
/*!40000 ALTER TABLE `teacherlist` DISABLE KEYS */;
INSERT INTO `teacherlist` VALUES ('001','斯内普','男','斯莱特林','院长'),('002','邓布利多','男','格兰芬多','校长'),('003','麦格','女','格兰芬多','院长'),('004','海格','男','其它','讲师'),('005','卢平','男','格兰芬多','讲师'),('007','纽特','男','赫奇帕奇','教授'),('008','弗利维','男','拉文克劳','院长');
/*!40000 ALTER TABLE `teacherlist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `teachtable`
--

DROP TABLE IF EXISTS `teachtable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `teachtable` (
  `skid` int NOT NULL AUTO_INCREMENT,
  `cid` varchar(20) NOT NULL,
  `tid` varchar(20) NOT NULL,
  `location` varchar(20) NOT NULL,
  `date_time` varchar(30) NOT NULL,
  `stunum` int DEFAULT '0',
  PRIMARY KEY (`skid`),
  KEY `cid` (`cid`),
  KEY `tid` (`tid`),
  CONSTRAINT `teachtable_ibfk_1` FOREIGN KEY (`cid`) REFERENCES `courselist` (`cid`) ON DELETE CASCADE,
  CONSTRAINT `teachtable_ibfk_2` FOREIGN KEY (`tid`) REFERENCES `teacherlist` (`uid`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teachtable`
--

LOCK TABLES `teachtable` WRITE;
/*!40000 ALTER TABLE `teachtable` DISABLE KEYS */;
INSERT INTO `teachtable` VALUES (1,'c001','001','N102','1-1',0),(2,'c002','001','N102','1-2',7),(3,'c003','001','N103','1-3',6),(4,'c004','001','N104','1-4',5),(5,'c005','001','N105','1-5',1),(6,'c001','002','N201','1-1',4),(8,'c002','002','N202','2-2',8),(9,'c001','003','N301','3-1',6),(16,'c003','003','N305','3-2',7),(17,'c004','008','N501','5-1',6),(19,'c002','005','N322','3-4',5),(20,'c003','007','N512','3-3',2),(21,'c001','007','N421','5-3',5),(22,'c003','004','N414','4-3',6),(23,'c005','005','N411','4-2',4),(24,'c005','008','N110','4-5',3);
/*!40000 ALTER TABLE `teachtable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `userlist`
--

DROP TABLE IF EXISTS `userlist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `userlist` (
  `uid` varchar(20) NOT NULL,
  `pwd` varchar(32) NOT NULL,
  `identity` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userlist`
--

LOCK TABLES `userlist` WRITE;
/*!40000 ALTER TABLE `userlist` DISABLE KEYS */;
INSERT INTO `userlist` VALUES ('001','dc5c7986daef50c1e02ab09b442ee34f',1),('002','93dd4de5cddba2c733c65f233097f05a',1),('003','e88a49bccde359f0cabb40db83ba6080',1),('004','11364907cf269dd2183b64287156072a',1),('005','ce08becc73195df12d99d761bfbba68d',1),('007','9e94b15ed312fa42232fd87a55db0d39',1),('008','a13ee062eff9d7295bfc800a11f33704',1),('2020101001','285097911166BEDC5395BFCBF77E72AA',0),('2020101002','7a1a680fd72f0629a34b651d63faa543',0),('2020101003','4673fa44f6aa7b21ea199a32f2c99824',0),('2020101004','3415c91f3f3c17f415d158f6e915f378',0),('2020101005','2b6b5cc6d2bdbb47d980f72d0390a07e',0),('2020101006','fa1d87e70453af3f436df731b9cc17a9',0),('2020101007','35192552da460d522eaa837988b45a94',0),('2020101008','50e4dbeff3bb91a31e8c4306a267dc77',0),('2020101642','9077DC86B6A0BF059C2620949FA210FA',0),('admin','21232f297a57a5a743894a0e4a801fc3',2);
/*!40000 ALTER TABLE `userlist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Final view structure for view `allstudy_view`
--

/*!50001 DROP VIEW IF EXISTS `allstudy_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `allstudy_view` AS select `a`.`skid` AS `skid`,`a`.`uid` AS `uid`,`b`.`stuname` AS `stuname`,`b`.`sex` AS `sex`,`b`.`major` AS `major`,`c`.`cid` AS `cid`,`c`.`tid` AS `tid` from ((`studytable` `a` join `studentlist` `b`) join `teachtable` `c`) where ((`a`.`uid` = `b`.`uid`) and (`a`.`skid` = `c`.`skid`)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `allteach_view`
--

/*!50001 DROP VIEW IF EXISTS `allteach_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `allteach_view` AS select `a`.`skid` AS `skid`,`a`.`cid` AS `cid`,`b`.`cname` AS `cname`,`b`.`points` AS `points`,`a`.`tid` AS `tid`,`c`.`teaname` AS `teaname`,`a`.`location` AS `location`,`a`.`date_time` AS `date_time`,`a`.`stunum` AS `stunum` from ((`teachtable` `a` join `courselist` `b`) join `teacherlist` `c`) where ((`a`.`cid` = `b`.`cid`) and (`a`.`tid` = `c`.`uid`)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-26 15:45:55
