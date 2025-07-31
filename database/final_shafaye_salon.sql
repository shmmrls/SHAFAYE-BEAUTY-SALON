-- MySQL dump 10.13  Distrib 8.0.42, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: final_shafaye_salon
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.32-MariaDB

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
-- Table structure for table `appointment_services`
--

DROP TABLE IF EXISTS `appointment_services`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `appointment_services` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `appointment_id` int(11) NOT NULL,
  `service_id` int(11) NOT NULL,
  `staff_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `appointment_id` (`appointment_id`),
  KEY `service_id` (`service_id`),
  KEY `staff_id` (`staff_id`),
  CONSTRAINT `appointment_services_ibfk_1` FOREIGN KEY (`appointment_id`) REFERENCES `appointments` (`appointment_id`),
  CONSTRAINT `appointment_services_ibfk_2` FOREIGN KEY (`service_id`) REFERENCES `services` (`service_id`),
  CONSTRAINT `appointment_services_ibfk_3` FOREIGN KEY (`staff_id`) REFERENCES `staff` (`staff_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appointment_services`
--

LOCK TABLES `appointment_services` WRITE;
/*!40000 ALTER TABLE `appointment_services` DISABLE KEYS */;
INSERT INTO `appointment_services` VALUES (1,1,13,5),(2,1,19,3),(3,2,20,3),(4,2,28,9),(5,3,36,1),(6,3,11,10),(7,3,30,9),(8,4,1,2),(9,4,26,8),(10,5,18,5),(11,6,2,2);
/*!40000 ALTER TABLE `appointment_services` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `appointments`
--

DROP TABLE IF EXISTS `appointments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `appointments` (
  `appointment_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `appointment_date` date NOT NULL,
  `appointment_time` varchar(10) NOT NULL,
  `status` varchar(20) DEFAULT 'Pending',
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `inventory_deducted` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`appointment_id`),
  KEY `user_id` (`user_id`),
  CONSTRAINT `appointments_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `user_register` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appointments`
--

LOCK TABLES `appointments` WRITE;
/*!40000 ALTER TABLE `appointments` DISABLE KEYS */;
INSERT INTO `appointments` VALUES (1,1,'2025-07-24','05:00 PM','Completed','2025-07-24 08:54:20',1),(2,1,'2025-07-25','03:00 PM','Cancelled','2025-07-25 06:05:04',0),(3,1,'2025-07-28','02:00 PM','Pending','2025-07-27 09:08:27',0),(4,1,'2025-07-30','03:00 pm','Completed','2025-07-29 21:02:11',1),(5,1,'2025-07-31','10:00 AM','Completed','2025-07-29 22:10:55',1),(6,1,'2025-07-30','10:00 AM','Approved','2025-07-30 00:21:10',0);
/*!40000 ALTER TABLE `appointments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contact_messages`
--

DROP TABLE IF EXISTS `contact_messages`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `contact_messages` (
  `message_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) DEFAULT NULL,
  `subject` varchar(200) DEFAULT NULL,
  `message` text DEFAULT NULL,
  `sent_at` timestamp NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`message_id`),
  KEY `user_id` (`user_id`),
  CONSTRAINT `contact_messages_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `user_register` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contact_messages`
--

LOCK TABLES `contact_messages` WRITE;
/*!40000 ALTER TABLE `contact_messages` DISABLE KEYS */;
INSERT INTO `contact_messages` VALUES (1,1,'Sample Tanong','Ano pong mas maganda? Rebond o ako?','2025-07-25 00:57:10');
/*!40000 ALTER TABLE `contact_messages` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `expenses`
--

DROP TABLE IF EXISTS `expenses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `expenses` (
  `expense_id` int(11) NOT NULL AUTO_INCREMENT,
  `expense_type` varchar(50) DEFAULT NULL,
  `amount` decimal(10,2) NOT NULL,
  `description` text DEFAULT NULL,
  PRIMARY KEY (`expense_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `expenses`
--

LOCK TABLES `expenses` WRITE;
/*!40000 ALTER TABLE `expenses` DISABLE KEYS */;
INSERT INTO `expenses` VALUES (1,'Inventory Restocking',30000.00,'Fixed monthly budget for inventory restocking'),(2,'Rent',15000.00,'Monthly salon rent'),(3,'Utilities',3000.00,'Monthly water and electricity'),(4,'Internet',2000.00,'Monthly internet subscription');
/*!40000 ALTER TABLE `expenses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `faq`
--

DROP TABLE IF EXISTS `faq`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `faq` (
  `faq_id` int(11) NOT NULL AUTO_INCREMENT,
  `question` text DEFAULT NULL,
  `answer` text DEFAULT NULL,
  `is_visible` tinyint(1) DEFAULT 1,
  PRIMARY KEY (`faq_id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `faq`
--

LOCK TABLES `faq` WRITE;
/*!40000 ALTER TABLE `faq` DISABLE KEYS */;
INSERT INTO `faq` VALUES (1,'What services does Shafaye Salon offer?','Shafaye Salon offers haircuts, hair coloring, nail care, facials, waxing, and other beauty treatments. You can view the full list when booking an appointment.',1),(2,'How can I book an appointment?','Simply log in to your account, go to the \"Book Appointment\" tab, select your preferred services, and confirm your schedule.',1),(3,'Can I choose my preferred stylist?','Currently, stylists are auto-assigned based on availability. Each staff member can handle up to 10 clients per day to ensure quality service.',1),(4,'What happens if I cancel my appointment?','You can cancel your appointment at least 1 day before the scheduled date. Repeated last-minute cancellations may affect future bookings.',1),(5,'How many services can I book at once?','You may select up to 3 different services per appointment to ensure proper time allocation and service quality.',1),(6,'Is walk-in allowed at Shafaye Salon?','While we accept walk-ins when available, we recommend booking online to secure your preferred time and services.',1),(7,'Where is Shafaye Salon located?','You can find our location and contact information in the homepage of the website or app before logging in/signing up.',1),(8,'Do I need to create a profile before booking?','Yes, you need to complete your user profile before booking to ensure we have your contact and preference details.',1),(9,'Can I book services for a friend using my account?','For security and proper tracking, we recommend that each client books through their own account.',1),(10,'How do I leave a review after my appointment?','Go to your transaction history, select the completed appointment, and click \"Leave a Review.\"',1),(11,'Can I see my past appointments?','Yes, your past appointments are shown in the Transaction History tab, including details like services, staff, and status.',1),(12,'How do I contact Shafaye Salon?','You can reach us through the Contact Us page, message us on Facebook, or call the number listed in our footer.',1),(13,'What if no staff is available for my selected time?','If no staff is available, the system will ask you to choose a different time or date when booking.',1),(14,'Can I upload a reference photo for hair or nail services?','At the moment, the upload feature is not available. However, you can show your reference photo in person during your visit.',1),(15,'Can I reschedule my appointment?','Rescheduling is not allowed. If you can’t make it, please cancel and book a new appointment.',1),(16,'Will I receive a confirmation for my appointment?','All appointments are reviewed and confirmed manually on-site. You will not receive an automatic confirmation.',1);
/*!40000 ALTER TABLE `faq` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventory`
--

DROP TABLE IF EXISTS `inventory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `inventory` (
  `item_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_name` varchar(100) NOT NULL,
  `quantity` int(11) DEFAULT 0,
  `unit` varchar(20) DEFAULT NULL,
  `reorder_level` int(11) DEFAULT NULL,
  PRIMARY KEY (`item_id`)
) ENGINE=InnoDB AUTO_INCREMENT=40 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventory`
--

LOCK TABLES `inventory` WRITE;
/*!40000 ALTER TABLE `inventory` DISABLE KEYS */;
INSERT INTO `inventory` VALUES (1,'Disposable Cape',199,'pcs',50),(2,'Shampoo',5000,'ml',1000),(3,'Conditioner',5000,'ml',1000),(4,'Hair Dye',150,'tubes',30),(5,'Developer',10000,'ml',2000),(6,'Bleach Powder',5000,'g',1000),(7,'Keratin Solution',4000,'ml',800),(8,'Hot Oil',3000,'ml',600),(9,'Rebond Cream',7000,'ml',1500),(10,'Neutralizer',7000,'ml',1500),(11,'Nail Polish',190,'bottles',50),(12,'Gel Polish',150,'bottles',30),(13,'Acrylic Powder',3000,'g',600),(14,'Acetone',7960,'ml',2000),(15,'Cuticle Remover',2000,'ml',500),(16,'Nail File',300,'pcs',60),(17,'Buffer Block',299,'pcs',60),(18,'Facial Cleanser',3990,'ml',800),(19,'Facial Toner',3990,'ml',800),(20,'Facial Mask',299,'sachets',60),(21,'Serum',2000,'ml',400),(22,'Cotton Pads',4995,'pcs',1000),(23,'Massage Oil',10000,'ml',2000),(24,'Alcohol',5000,'ml',1000),(25,'Wax Beads',4000,'g',800),(26,'Wax Strips',3000,'pcs',600),(27,'Thread Roll',99,'pcs',20),(28,'Soothing Gel',1990,'ml',400),(29,'Talc Powder',2000,'g',400),(30,'Lash Lift Solution',200,'sachets',40),(31,'Lash Adhesive',150,'tubes',30),(32,'Lash Tint',1000,'ml',200),(33,'Eye Pads',500,'pairs',100),(34,'Microbrush',1000,'pcs',200),(35,'Hand Spa Cream',3000,'ml',600),(36,'Foot Spa Scrub',2990,'ml',600),(37,'Disposable Bed Sheets',500,'pcs',100),(38,'Foil Sheets',2000,'pcs',400),(39,'Sample',11,'pcs',5);
/*!40000 ALTER TABLE `inventory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventory_usage`
--

DROP TABLE IF EXISTS `inventory_usage`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `inventory_usage` (
  `usage_id` int(11) NOT NULL AUTO_INCREMENT,
  `service_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `quantity_used` int(11) DEFAULT 1,
  PRIMARY KEY (`usage_id`),
  KEY `service_id` (`service_id`),
  KEY `item_id` (`item_id`),
  CONSTRAINT `inventory_usage_ibfk_1` FOREIGN KEY (`service_id`) REFERENCES `services` (`service_id`),
  CONSTRAINT `inventory_usage_ibfk_2` FOREIGN KEY (`item_id`) REFERENCES `inventory` (`item_id`)
) ENGINE=InnoDB AUTO_INCREMENT=146 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventory_usage`
--

LOCK TABLES `inventory_usage` WRITE;
/*!40000 ALTER TABLE `inventory_usage` DISABLE KEYS */;
INSERT INTO `inventory_usage` VALUES (1,1,1,1),(2,2,1,1),(3,2,2,20),(4,2,3,15),(5,3,1,1),(6,4,1,1),(7,4,2,20),(8,4,3,15),(9,5,1,1),(10,5,4,30),(11,5,5,40),(12,6,1,1),(13,6,4,30),(14,6,5,40),(15,7,1,1),(16,7,4,30),(17,7,5,40),(18,8,1,1),(19,8,9,70),(20,8,10,70),(21,9,1,1),(22,9,9,70),(23,9,10,70),(24,10,1,1),(25,10,9,70),(26,10,10,70),(27,11,1,1),(28,11,8,20),(30,12,1,1),(31,12,7,25),(33,13,11,5),(34,13,16,1),(35,13,17,1),(36,13,14,20),(40,14,12,5),(41,14,16,1),(42,14,17,1),(43,14,14,20),(47,15,11,5),(48,15,16,1),(49,15,17,1),(50,15,35,10),(54,16,11,5),(55,16,16,1),(56,16,17,1),(57,17,12,5),(58,17,16,1),(59,17,17,1),(60,18,11,5),(61,18,14,20),(62,18,36,10),(63,19,18,10),(64,19,19,10),(65,19,20,1),(66,19,22,5),(70,20,18,10),(71,20,19,10),(72,20,20,1),(73,20,21,5),(74,20,22,5),(77,21,23,15),(78,21,37,1),(80,22,23,15),(81,22,37,1),(83,23,23,15),(84,23,37,1),(86,24,23,15),(87,25,23,15),(88,26,27,1),(89,26,28,10),(91,27,27,1),(92,27,28,10),(94,28,25,15),(95,28,26,5),(96,28,28,10),(97,29,25,15),(98,29,26,5),(99,29,28,10),(100,30,25,15),(101,30,26,5),(102,30,28,10),(103,31,30,1),(104,31,33,1),(105,31,34,1),(106,32,31,1),(107,32,33,1),(108,32,34,1),(109,33,31,1),(110,33,33,1),(111,33,34,1),(112,34,32,5),(113,34,34,1),(114,34,22,5),(115,35,35,10),(116,35,37,1),(118,36,36,10),(119,36,37,1),(121,37,23,15),(122,37,11,5),(124,38,23,15),(125,38,12,5),(126,38,35,10),(127,38,36,10),(131,39,23,15),(132,39,12,5),(133,39,35,10),(134,39,36,10),(135,39,20,1),(138,40,1,1),(139,40,6,20),(140,40,5,40),(141,40,38,5),(145,20,39,1);
/*!40000 ALTER TABLE `inventory_usage` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payments`
--

DROP TABLE IF EXISTS `payments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payments` (
  `payment_id` int(11) NOT NULL AUTO_INCREMENT,
  `appointment_id` int(11) NOT NULL,
  `payment_date` date NOT NULL,
  `payment_type` varchar(20) DEFAULT 'Cash',
  `payment_status` varchar(20) DEFAULT 'Paid',
  PRIMARY KEY (`payment_id`),
  UNIQUE KEY `appointment_id` (`appointment_id`),
  CONSTRAINT `payments_ibfk_1` FOREIGN KEY (`appointment_id`) REFERENCES `appointments` (`appointment_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payments`
--

LOCK TABLES `payments` WRITE;
/*!40000 ALTER TABLE `payments` DISABLE KEYS */;
INSERT INTO `payments` VALUES (1,1,'2025-07-25','Cash','Paid'),(2,4,'2025-07-30','Cash','Paid'),(3,6,'2025-07-30','Cash','Paid');
/*!40000 ALTER TABLE `payments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reviews`
--

DROP TABLE IF EXISTS `reviews`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reviews` (
  `review_id` int(11) NOT NULL AUTO_INCREMENT,
  `appointment_id` int(11) NOT NULL,
  `staff_id` int(11) DEFAULT NULL,
  `service_rating` int(11) DEFAULT NULL,
  `staff_rating` int(11) DEFAULT NULL,
  `comment` text DEFAULT NULL,
  `is_visible` tinyint(1) DEFAULT 1,
  PRIMARY KEY (`review_id`),
  KEY `appointment_id` (`appointment_id`),
  KEY `staff_id` (`staff_id`),
  CONSTRAINT `reviews_ibfk_1` FOREIGN KEY (`appointment_id`) REFERENCES `appointments` (`appointment_id`),
  CONSTRAINT `reviews_ibfk_2` FOREIGN KEY (`staff_id`) REFERENCES `staff` (`staff_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reviews`
--

LOCK TABLES `reviews` WRITE;
/*!40000 ALTER TABLE `reviews` DISABLE KEYS */;
INSERT INTO `reviews` VALUES (1,1,5,5,5,'Ang galing. Alagang alaga niya kuko ko. The best. Babalik pa.',1);
/*!40000 ALTER TABLE `reviews` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `service_categories`
--

DROP TABLE IF EXISTS `service_categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `service_categories` (
  `category_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  PRIMARY KEY (`category_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `service_categories`
--

LOCK TABLES `service_categories` WRITE;
/*!40000 ALTER TABLE `service_categories` DISABLE KEYS */;
INSERT INTO `service_categories` VALUES (1,'Hair Services'),(2,'Nail Services'),(3,'Facial and Skin Care'),(4,'Massage Services'),(5,'Waxing / Threading'),(6,'Lashes and Brows'),(7,'Spa Packages');
/*!40000 ALTER TABLE `service_categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `service_staff_roles`
--

DROP TABLE IF EXISTS `service_staff_roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `service_staff_roles` (
  `id` int(11) NOT NULL,
  `service_id` int(11) NOT NULL,
  `role_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `service_staff_roles`
--

LOCK TABLES `service_staff_roles` WRITE;
/*!40000 ALTER TABLE `service_staff_roles` DISABLE KEYS */;
INSERT INTO `service_staff_roles` VALUES (1,15,'Massage Therapist'),(2,21,'Massage Therapist'),(3,22,'Massage Therapist'),(4,23,'Massage Therapist'),(5,24,'Massage Therapist'),(6,25,'Massage Therapist'),(7,37,'Massage Therapist'),(8,38,'Massage Therapist'),(16,1,'Hair Stylist'),(17,2,'Hair Stylist'),(18,3,'Hair Stylist'),(19,4,'Hair Stylist'),(20,5,'Hair Stylist'),(21,6,'Hair Stylist'),(22,7,'Hair Stylist'),(23,40,'Hair Stylist'),(31,8,'Rebond Specialist'),(32,9,'Rebond Specialist'),(33,10,'Rebond Specialist'),(34,11,'Hair Treatment Specialist'),(35,12,'Hair Treatment Specialist'),(36,20,'Hair Treatment Specialist'),(37,3,'Barber'),(38,4,'Barber'),(40,19,'Facial Specialist'),(41,20,'Facial Specialist'),(43,13,'Nail Technician'),(44,14,'Nail Technician'),(45,15,'Nail Technician'),(46,16,'Nail Technician'),(47,17,'Nail Technician'),(48,18,'Nail Technician'),(50,26,'Threading Specialist'),(51,27,'Threading Specialist'),(53,28,'Waxing Specialist'),(54,29,'Waxing Specialist'),(55,30,'Waxing Specialist'),(56,26,'Threading Specialist'),(57,31,'Threading Specialist'),(58,32,'Threading Specialist'),(59,33,'Threading Specialist'),(60,34,'Threading Specialist'),(63,35,'Massage Therapist'),(64,36,'Massage Therapist'),(65,37,'Massage Therapist'),(66,38,'Massage Therapist'),(67,39,'Massage Therapist'),(70,35,'Nail Technician'),(71,36,'Nail Technician'),(72,37,'Nail Technician'),(73,38,'Nail Technician'),(74,39,'Nail Technician'),(77,35,'All-Around Spa Therapist'),(78,36,'All-Around Spa Therapist'),(79,37,'All-Around Spa Therapist'),(80,38,'All-Around Spa Therapist'),(81,39,'All-Around Spa Therapist');
/*!40000 ALTER TABLE `service_staff_roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `services`
--

DROP TABLE IF EXISTS `services`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `services` (
  `service_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `description` varchar(255) DEFAULT NULL,
  `price` decimal(10,2) NOT NULL,
  `category_id` int(11) DEFAULT NULL,
  `is_available` tinyint(1) DEFAULT 1,
  `image_name` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`service_id`),
  KEY `category_id` (`category_id`),
  CONSTRAINT `services_ibfk_1` FOREIGN KEY (`category_id`) REFERENCES `service_categories` (`category_id`)
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `services`
--

LOCK TABLES `services` WRITE;
/*!40000 ALTER TABLE `services` DISABLE KEYS */;
INSERT INTO `services` VALUES (1,'Haircut (Women) - Basic','Basic haircut service for women',300.00,1,1,'haircut_women_basic'),(2,'Haircut (Women) - Styled','Styled haircut for a fashionable look',500.00,1,1,'haircut_women_styled'),(3,'Haircut (Men) - Basic','Basic haircut service for men',250.00,1,1,'haircut_men_basic'),(4,'Haircut (Men) - With shampoo/blow-dry','Men’s haircut including shampoo and blow-dry',400.00,1,1,'haircut_men_shampoo'),(5,'Hair Color - Short Hair','Hair coloring for short-length hair',2000.00,1,1,'haircolor_short'),(6,'Hair Color - Medium','Hair coloring for medium-length hair',2500.00,1,1,'haircolor_medium'),(7,'Hair Color - Long','Hair coloring for long-length hair',3000.00,1,1,'haircolor_long'),(8,'Hair Rebonding - Short','Hair rebonding treatment for short hair',2500.00,1,1,'rebonding_short'),(9,'Hair Rebonding - Medium','Hair rebonding treatment for medium hair',3500.00,1,1,'rebonding_medium'),(10,'Hair Rebonding - Long','Hair rebonding treatment for long hair',4500.00,1,1,'rebonding_long'),(11,'Hot Oil Treatment','Hair nourishment using hot oil',700.00,1,1,'hot_oil'),(12,'Keratin Treatment','Smoothing and straightening keratin treatment',1500.00,1,1,'keratin'),(13,'Manicure - Basic','Classic nail grooming for hands',300.00,2,1,'manicure_basic'),(14,'Manicure - Acrylic / Gel','Gel or acrylic nail application',400.00,2,1,'manicure_gel'),(15,'Manicure - w/ hand massage','Manicure with soothing hand massage',450.00,2,1,'manicure_massage'),(16,'Pedicure - Basic','Classic nail grooming for feet',350.00,2,1,'pedicure_basic'),(17,'Pedicure - Acrylic / Gel','Gel or acrylic application for toenails',450.00,2,1,'pedicure_gel'),(18,'Pedicure - w/ scrub','Pedicure with exfoliating foot scrub',500.00,2,1,'pedicure_scrub'),(19,'Basic Facial Cleaning','Facial cleansing for healthy skin',1200.00,3,1,'facial_basic'),(20,'Anti-Acne Treatment Facial','Treatment facial for acne-prone skin',1700.00,3,1,'facial_acne'),(21,'Normal Massage - 1 Hour','Relaxing 1-hour body massage',450.00,4,1,'massage_normal_1hr'),(22,'Normal Massage - 90 Mins','Relaxing 90-minute body massage',700.00,4,1,'massage_normal_90mins'),(23,'Hot Stone Massage - 1 Hour','1-hour massage using heated stones',850.00,4,1,'massage_stone'),(24,'Foot Reflexology - 30 mins','30-minute foot reflexology session',400.00,4,1,'foot_reflex_30'),(25,'Foot Reflexology - 1 hour','1-hour foot reflexology session',700.00,4,1,'foot_reflex_1hr'),(26,'Eyebrow Threading','Precise eyebrow shaping with thread',250.00,5,1,'threading_eyebrow'),(27,'Upper Lip Threading','Upper lip hair removal with thread',150.00,5,1,'threading_lip'),(28,'Underarm Waxing','Underarm hair removal using wax',350.00,5,1,'waxing_underarm'),(29,'Brazilian / Bikini Waxing','Bikini or Brazilian wax treatment',750.00,5,1,'waxing_brazilian'),(30,'Full Leg Waxing','Full leg waxing for smooth skin',800.00,5,1,'waxing_leg'),(31,'Lash Lift','Natural-looking lash curling treatment',1500.00,6,1,'lash_lift'),(32,'Lash Extensions - Classic','Classic lash extensions for a fuller lash line',1500.00,6,1,'lash_classic'),(33,'Lash Extensions - Volume','Volume lash extensions for a dramatic look',1800.00,6,1,'lash_volume'),(34,'Eyebrow Tinting','Tinting service for darker, fuller brows',300.00,6,1,'eyebrow_tint'),(35,'Hand Spa','Hydrating and relaxing hand spa treatment',550.00,7,1,'hand_spa'),(36,'Foot Spa','Foot spa with soak, scrub, and massage',750.00,7,1,'foot_spa'),(37,'Massage + Mani + Pedi - Basic','Basic spa combo: massage, manicure, and pedicure',1300.00,7,1,'package_basic'),(38,'Massage + Mani + Pedi - Premium','Premium spa combo for full pampering',2000.00,7,1,'package_premium'),(39,'Full Pamper Package','Complete spa package for head-to-toe care',4999.00,7,1,'package_full'),(40,'Hi-lights','Hi-light your hair to standout.',1500.00,1,0,'hi-lights');
/*!40000 ALTER TABLE `services` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `staff` (
  `staff_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `position` varchar(50) DEFAULT NULL,
  `salary` decimal(10,2) DEFAULT NULL,
  `status` varchar(20) DEFAULT 'Active',
  PRIMARY KEY (`staff_id`),
  KEY `user_id` (`user_id`),
  CONSTRAINT `staff_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `user_register` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff` VALUES (1,4,'Massage Therapist',14500.00,'Active'),(2,5,'Hair Stylist',18000.00,'Active'),(3,6,'Facial Specialist',15000.00,'Active'),(4,7,'Rebond Specialist',13500.00,'Active'),(5,8,'Nail Technician',17500.00,'Active'),(6,9,'Barber',11500.00,'Active'),(7,10,'Hair Colorist',12000.00,'Active'),(8,11,'Threading Specialist',13000.00,'Active'),(9,12,'Waxing Specialist',14000.00,'Active'),(10,13,'Hair Treatment Specialist',16000.00,'Active'),(11,14,'All-Around Spa Specialist',16000.00,'Active');
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_profiles`
--

DROP TABLE IF EXISTS `user_profiles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_profiles` (
  `user_id` int(11) NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `date_of_birth` date DEFAULT NULL,
  PRIMARY KEY (`user_id`),
  CONSTRAINT `user_profiles_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `user_register` (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_profiles`
--

LOCK TABLES `user_profiles` WRITE;
/*!40000 ALTER TABLE `user_profiles` DISABLE KEYS */;
INSERT INTO `user_profiles` VALUES (1,'theshamimorales@gmail.com','09262027104','2006-03-12'),(2,'rubygalarion1312@gmail.com','09753594059','1983-03-23'),(3,NULL,NULL,NULL),(19,NULL,NULL,NULL);
/*!40000 ALTER TABLE `user_profiles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_register`
--

DROP TABLE IF EXISTS `user_register`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_register` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(1000) NOT NULL,
  `role` varchar(20) DEFAULT 'user',
  `first_name` varchar(100) DEFAULT NULL,
  `last_name` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_register`
--

LOCK TABLES `user_register` WRITE;
/*!40000 ALTER TABLE `user_register` DISABLE KEYS */;
INSERT INTO `user_register` VALUES (1,'shmmrls','1cbe34a5d6167898691099ff97d63cb8997bc51ce9ab6634dd9311ab8d83902a','user','Trisha','Morales'),(2,'rubygalarion','d031e7acc5206d6ffae2bff83cf6a11d901bb5a71cbd6017c08699747df91604','user','Ruby','Galarion'),(3,'adminsha','b0d45294be199f4bd477cd152dc2f631bfceab970a7b0ff5b9d9510b67437bbb','admin','Admin','Sha'),(4,'jessicalee','b0d45294be199f4bd477cd152dc2f631bfceab970a7b0ff5b9d9510b67437bbb','staff','Jessica','Lee'),(5,'shuyamino','b0d45294be199f4bd477cd152dc2f631bfceab970a7b0ff5b9d9510b67437bbb','staff','Shu','Yamino'),(6,'mariaangelicadelacruz','b0d45294be199f4bd477cd152dc2f631bfceab970a7b0ff5b9d9510b67437bbb','staff','Maria Angelica','Dela Cruz'),(7,'joffantone','b0d45294be199f4bd477cd152dc2f631bfceab970a7b0ff5b9d9510b67437bbb','staff','Jof','Fantone'),(8,'dianaflores','b0d45294be199f4bd477cd152dc2f631bfceab970a7b0ff5b9d9510b67437bbb','staff','Diana','Flores'),(9,'jakerivera','b0d45294be199f4bd477cd152dc2f631bfceab970a7b0ff5b9d9510b67437bbb','staff','Jake','Rivera'),(10,'kylasantos','b0d45294be199f4bd477cd152dc2f631bfceab970a7b0ff5b9d9510b67437bbb','staff','Kyla','Santos'),(11,'rheagutierrez','b0d45294be199f4bd477cd152dc2f631bfceab970a7b0ff5b9d9510b67437bbb','staff','Rhea','Gutierrez'),(12,'zarabautista','b0d45294be199f4bd477cd152dc2f631bfceab970a7b0ff5b9d9510b67437bbb','staff','Zara','Bautista'),(13,'isabelferrer','b0d45294be199f4bd477cd152dc2f631bfceab970a7b0ff5b9d9510b67437bbb','staff','Isabel','Ferrer'),(14,'janazobel','b0d45294be199f4bd477cd152dc2f631bfceab970a7b0ff5b9d9510b67437bbb','staff','Jana','Zobel'),(16,'adminfaye','b0d45294be199f4bd477cd152dc2f631bfceab970a7b0ff5b9d9510b67437bbb','admin','Admin','Faye'),(17,'newadmin','a480823803b84dc5e9181d6cbcd82743d66073c6003eba396b651f2a877dcc18','admin','New','Admin'),(19,'alwinbenitez','b0d45294be199f4bd477cd152dc2f631bfceab970a7b0ff5b9d9510b67437bbb','user','Alwin','Benitez');
/*!40000 ALTER TABLE `user_register` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-08-01  1:49:34

-- 1. CREATE ADMIN USER
CREATE USER IF NOT EXISTS 'salon_admin'@'localhost' IDENTIFIED BY 'AdminSalon2025!';
GRANT ALL PRIVILEGES ON final_shafaye_salon.* TO 'salon_admin'@'localhost';

-- 2. CREATE STAFF USER
CREATE USER IF NOT EXISTS 'salon_staff'@'localhost' IDENTIFIED BY 'StaffSalon2025!';
GRANT SELECT ON final_shafaye_salon.appointments TO 'salon_staff'@'localhost';
GRANT SELECT ON final_shafaye_salon.appointment_services TO 'salon_staff'@'localhost';
GRANT SELECT ON final_shafaye_salon.services TO 'salon_staff'@'localhost';
GRANT SELECT ON final_shafaye_salon.service_categories TO 'salon_staff'@'localhost';
GRANT SELECT ON final_shafaye_salon.payments TO 'salon_staff'@'localhost';
GRANT SELECT ON final_shafaye_salon.user_register TO 'salon_staff'@'localhost';
GRANT SELECT ON final_shafaye_salon.user_profiles TO 'salon_staff'@'localhost';
GRANT SELECT ON final_shafaye_salon.staff TO 'salon_staff'@'localhost';
GRANT SELECT ON final_shafaye_salon.reviews TO 'salon_staff'@'localhost';

-- 3. CREATE CUSTOMER USER
CREATE USER IF NOT EXISTS 'salon_customer'@'localhost' IDENTIFIED BY 'CustomerSalon2025!';
GRANT SELECT ON final_shafaye_salon.services TO 'salon_customer'@'localhost';
GRANT SELECT ON final_shafaye_salon.service_categories TO 'salon_customer'@'localhost';
GRANT SELECT ON final_shafaye_salon.faq TO 'salon_customer'@'localhost';
GRANT SELECT, INSERT ON final_shafaye_salon.appointments TO 'salon_customer'@'localhost';
GRANT SELECT, INSERT ON final_shafaye_salon.appointment_services TO 'salon_customer'@'localhost';
GRANT SELECT ON final_shafaye_salon.staff TO 'salon_customer'@'localhost';
GRANT SELECT ON final_shafaye_salon.service_staff_roles TO 'salon_customer'@'localhost';
GRANT UPDATE (status) ON final_shafaye_salon.appointments TO 'salon_customer'@'localhost';
GRANT SELECT, INSERT ON final_shafaye_salon.reviews TO 'salon_customer'@'localhost';
GRANT SELECT, UPDATE ON final_shafaye_salon.user_profiles TO 'salon_customer'@'localhost';
GRANT SELECT ON final_shafaye_salon.user_register TO 'salon_customer'@'localhost';
GRANT SELECT, INSERT ON final_shafaye_salon.contact_messages TO 'salon_customer'@'localhost';
GRANT SELECT ON final_shafaye_salon.payments TO 'salon_customer'@'localhost';

-- RESTRICT customer access to limited staff info
REVOKE SELECT ON final_shafaye_salon.staff FROM 'salon_customer'@'localhost';
GRANT SELECT (staff_id, user_id, position, status) ON final_shafaye_salon.staff TO 'salon_customer'@'localhost';

-- 4. CREATE WEB APPLICATION USER
CREATE USER IF NOT EXISTS 'salon_webapp'@'localhost' IDENTIFIED BY 'WebApp2025!';
GRANT SELECT, INSERT, UPDATE, DELETE ON final_shafaye_salon.* TO 'salon_webapp'@'localhost';

-- FINALIZE
FLUSH PRIVILEGES;

