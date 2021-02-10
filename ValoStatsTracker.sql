CREATE DATABASE  IF NOT EXISTS `valorantdata` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `valorantdata`;
-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: valorantdata
-- ------------------------------------------------------
-- Server version	8.0.22

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
-- Table structure for table `agents`
--

DROP TABLE IF EXISTS `agents`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `agents` (
  `name` varchar(20) NOT NULL,
  `type` varchar(20) NOT NULL,
  `first_ability` varchar(20) NOT NULL DEFAULT '0',
  `second_ability` varchar(20) NOT NULL DEFAULT '0',
  `third_ability` varchar(20) NOT NULL DEFAULT '0',
  `ultimate_ability` varchar(20) NOT NULL DEFAULT '0',
  `first_ability_cost` int NOT NULL,
  `second_ability_cost` int NOT NULL,
  `third_ability_charge_method` varchar(20) NOT NULL,
  `ultimate_ability_points` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`name`),
  UNIQUE KEY `name` (`name`),
  UNIQUE KEY `first_ability` (`first_ability`),
  UNIQUE KEY `second_ability` (`second_ability`),
  UNIQUE KEY `third_ability` (`third_ability`),
  UNIQUE KEY `ultimate_ability` (`ultimate_ability`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `agents`
--

LOCK TABLES `agents` WRITE;
/*!40000 ALTER TABLE `agents` DISABLE KEYS */;
INSERT INTO `agents` VALUES ('Breach','Initiator','Aftershock','Flashpoint','Fault Line','Rolling Thunder',100,200,'cooldown',7),('Brimstone','Controller','Stim Beacon','Incendiary','Sky Smoke','Orbital Strike',100,300,'shop',6),('Cypher','Sentinel','Trapwire','Cyber Cage','Spycam','Neural Theft',200,100,'reusable',7),('Jett','Duelist','Cloudburst','Updraft','Tailwind','Blade Storm',100,100,'kills',7),('Omen','Controller','Shrouded Step','Paranoia','Dark Cover','From the Shadows',100,200,'cooldown',7),('Phoenix','Duelist','Blaze','Curveball','Hot Hands','Run it Back',200,200,'kills',6),('Raze','Duelist','Boom Bot','Blast Pack','Paint Shells','Showstopper',200,200,'kills',6),('Reyna','Duelist','Leer','Devour','Dismiss','Empress',200,100,'points',6),('Sage','Sentinel','Barrier Orb','Slow Orb','Healing Orb','Resurrection',400,100,'cooldown',7),('Skye','Initiator','Trailblazer','Guiding Light','Regrowth','Seekers',200,100,'shop',6);
/*!40000 ALTER TABLE `agents` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maps`
--

DROP TABLE IF EXISTS `maps`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `maps` (
  `name` varchar(30) NOT NULL,
  `total_matches` int NOT NULL DEFAULT '0',
  `attacker_win` int NOT NULL DEFAULT '0',
  `defender_win` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`name`),
  UNIQUE KEY `name` (`name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maps`
--

LOCK TABLES `maps` WRITE;
/*!40000 ALTER TABLE `maps` DISABLE KEYS */;
INSERT INTO `maps` VALUES ('Accent',9543,5864,3679),('Bind',8756,5412,3344),('Haven',7321,5194,2127),('Icebox',3974,1254,2720),('Split',5462,2154,3308);
/*!40000 ALTER TABLE `maps` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `player_stats`
--

DROP TABLE IF EXISTS `player_stats`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `player_stats` (
  `battle_tag` int NOT NULL,
  `name` varchar(20) NOT NULL,
  `rank_points` int DEFAULT NULL,
  `num_of_kills` int NOT NULL DEFAULT '0',
  `num_of_deaths` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`battle_tag`),
  UNIQUE KEY `battle_tag` (`battle_tag`),
  UNIQUE KEY `name` (`name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `player_stats`
--

LOCK TABLES `player_stats` WRITE;
/*!40000 ALTER TABLE `player_stats` DISABLE KEYS */;
INSERT INTO `player_stats` VALUES (1008,'JuanDee',315,614,579),(2019,'Beastmaster64',421,333,69),(3471,'h3lloW0rLd',573,868,941),(4653,'DummyBoi',73,45,70),(5421,'MartySalamat',96,69,13),(6482,'RandomBibbo',169,95,67),(7117,'7Lucky7',777,969,696),(7354,'BillyGin',1349,5159,4476),(7489,'ThePlayer',452,1020,1249),(9110,'n00bL0L',55,887,1284);
/*!40000 ALTER TABLE `player_stats` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purchase_history`
--

DROP TABLE IF EXISTS `purchase_history`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `purchase_history` (
  `player_id` int NOT NULL,
  `purchased_id` int NOT NULL,
  `purchased_item` varchar(30) NOT NULL,
  `cost_in_php` decimal(7,2) NOT NULL DEFAULT '0.00',
  `paid_amount_in_php` decimal(7,2) NOT NULL DEFAULT '0.00',
  `date_purchased` date NOT NULL,
  PRIMARY KEY (`purchased_id`),
  UNIQUE KEY `purchased_id` (`purchased_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchase_history`
--

LOCK TABLES `purchase_history` WRITE;
/*!40000 ALTER TABLE `purchase_history` DISABLE KEYS */;
INSERT INTO `purchase_history` VALUES (5487,135484,'battle pass',2000.00,2000.00,'2020-12-12'),(5487,159357,'prime vandal',1000.00,1000.00,'2020-12-12'),(3214,321987,'battle pass',2000.00,2000.00,'2020-11-12'),(7478,465897,'prime vandal',1000.00,2000.00,'2020-11-12'),(6548,951357,'battle pass',2000.00,2000.00,'2020-06-05');
/*!40000 ALTER TABLE `purchase_history` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `weapon_skins`
--

DROP TABLE IF EXISTS `weapon_skins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `weapon_skins` (
  `name` varchar(30) NOT NULL,
  `is_New` tinyint(1) NOT NULL,
  `is_Available` tinyint(1) NOT NULL,
  `price` int DEFAULT NULL,
  `collection_set` varchar(20) NOT NULL,
  PRIMARY KEY (`name`),
  UNIQUE KEY `name` (`name`),
  UNIQUE KEY `name_2` (`name`),
  CONSTRAINT `weapon_skins_chk_1` CHECK ((`price` between 0 and 10000))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `weapon_skins`
--

LOCK TABLES `weapon_skins` WRITE;
/*!40000 ALTER TABLE `weapon_skins` DISABLE KEYS */;
INSERT INTO `weapon_skins` VALUES ('Ego Stinger',0,1,1775,'Ego'),('Elderflame Operator',0,1,2475,'Elderflame'),('Glitchpop Judge',0,1,2175,'Glitchpop'),('Nebula Guardian',0,1,1775,'Nebula'),('Oni Knife',0,1,3550,'Oni'),('Prime Vandal',0,1,1775,'Prime'),('Sensation Frenzy',0,0,875,'Sensation'),('Singularity Phantom',0,1,2175,'Singularity'),('Smite Odin',0,1,875,'Smite'),('WinterWunderland Marshal',1,1,1275,'WinterWunderland');
/*!40000 ALTER TABLE `weapon_skins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `weapons`
--

DROP TABLE IF EXISTS `weapons`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `weapons` (
  `name` varchar(20) NOT NULL,
  `type` varchar(20) NOT NULL,
  `magazine_size` int NOT NULL DEFAULT '0',
  `equip_time` decimal(3,2) NOT NULL,
  `reload_time` decimal(3,2) NOT NULL,
  `cost` varchar(20) NOT NULL,
  `headshot_damage` int NOT NULL,
  `torso_damage` int NOT NULL,
  `leg_damage` int NOT NULL,
  PRIMARY KEY (`name`),
  UNIQUE KEY `name` (`name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `weapons`
--

LOCK TABLES `weapons` WRITE;
/*!40000 ALTER TABLE `weapons` DISABLE KEYS */;
INSERT INTO `weapons` VALUES ('Bulldog','Assault Rifles',24,1.00,2.50,'2100',115,35,30),('Classic','Sidearms',12,0.75,1.75,'0',78,26,22),('Ghost','Sidearms',15,0.75,1.50,'500',105,30,25),('Guardian','Assault Rifles',12,1.00,2.50,'2400',195,65,49),('Judge','Shotguns',7,1.00,2.20,'1600',34,17,15),('Odin','Heavy Weapons',100,1.25,5.00,'3200',95,38,32),('Operator','Sniper Rifles',5,1.50,3.70,'5000',255,150,120),('Sheriff','Sidearms',6,1.00,2.25,'800',160,55,48),('Spectre','SMGs',30,0.75,2.25,'1600',78,26,22),('Vandal','Assault Rifles',25,1.00,2.50,'2900',160,40,34);
/*!40000 ALTER TABLE `weapons` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'valorantdata'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-02-10  6:36:40
