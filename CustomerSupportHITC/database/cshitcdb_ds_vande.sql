-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: localhost    Database: cshitcdb
-- ------------------------------------------------------
-- Server version	8.0.33

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
-- Table structure for table `ds_vande`
--

DROP TABLE IF EXISTS `ds_vande`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ds_vande` (
  `id` int NOT NULL AUTO_INCREMENT,
  `idLoaiVanDe` int NOT NULL,
  `SoDienThoai` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `TenKhachHang` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `DiaChi` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `TraLoi` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `NguoiTao` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `NgayTao` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `TrangThai` char(1) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL COMMENT 'T: Open\nF: Close',
  `NgayHoanThanh` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `MucDoUuTien` char(1) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL COMMENT 'L: Low\nN: Normal\nH: High',
  `NoiDung` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `NguoiXuLy` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `YKienKhachHang` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `DanhGiaKhachHang` char(1) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL COMMENT '1: 1 star\n2: 2 star\n3: 3 star\n4: 4 star\n5: 5 star',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ds_vande`
--

LOCK TABLES `ds_vande` WRITE;
/*!40000 ALTER TABLE `ds_vande` DISABLE KEYS */;
INSERT INTO `ds_vande` VALUES (1,1,'+84123456789','Nguyễn Văn A','Hà Nội','Đã phản hồi khách hàng','HITC','7/10/2023','T','8/10/2023','L','Khách hàng phản hồi về cước','HITC','Không','5'),(3,3,'+84238283223','Nguyễn văn C','Hà nội','tttt','admin','2023/07/10','T','2023/07/20','N','dddd','admin','tttt','3'),(5,5,'+84727372323','Nguyễn Thị B','sdad','fffefe','Admin 2','2023/07/12','T','2023/07/19','L','sdasdad','Admin 2','fewfffef','4'),(6,6,'+843243424','Nguyễn thị F','Hà Nội','dfsdfasd','admin 3','2023/07/10','F','2023/07/19','L','dsff','admin 3','dấdadad','3'),(7,6,'+8473273273','Nguyễn Thị D','dewew','4ff433f','admin4','2023/07/10','T','2023/07/26','N','dưef4','admin4','43f3f4f','4'),(8,2,'+848238283','Nguyễn văn F','Hà Nội','ádd','admin4','2023/07/09','T','2023/07/20','N','dád','admin4','addad','4'),(9,2,'+84342342343','Lê Văn A','Hà Nội','fsdfsdf','admin4','2023/07/10','T','2023/07/19','N','fdfdfs','admin4','fdsdf','3'),(10,4,'+8427372731','Nguyễn thị O','Hà Nội','adasda','admin5','2023/07/10','T','2023/07/20','N','sadsad','admin5','dấd','3'),(11,3,'+847327273','Nguyễn Văn kk','Hà Nội','sfewwef','admin6','2023/07/10','T','2023/07/20','N','dfsdfs','admin6','fsdff','4'),(12,6,'+8473273781287','Lê thị G','Hà Nội','fsdfdsf','admin6','2023/07/10','T','2023/07/19','N','dfdsf','admin6','èwefef','4'),(13,2,'+84873887123','Lê Thị G','Hà Nội','dfsdafds','admin7','2023/07/10','T','2023/07/20','N','abcxyz','admin7','fsdfsa','4'),(14,4,'+842321323123','Nguyễn Thị D','Hà Nội','dfdsfaf','admin8 ','2023/07/11','T','2023/07/21','N','dfdsfds','admin8 ','dfasdf','4'),(15,4,'+84234234234','Nguyễn thị dd','ssadsds','asd','admin9','2023/07/02','T','2023/07/08','N','dasda','admin9','ádsdsa','3'),(16,2,'+843871872378','Trần Văn F','Hà Nội','fdsfdsf','admin3','2023/07/10','T','2023/07/21','N','fsdfdsf','admin3','dfdsfd','4'),(17,6,'+84827327344','Trần Thị A','fefef','ewfewfewf','Admin6','2023/07/05','T','2023/07/22','N','ưefwef','Admin6','ewfcds','4'),(18,4,'+843989123921','Trần Văn FFF','Hà Nội','dsfaf','admin4','2023/07/03','F','2023/07/08','H','dsfd','admin4','fsfsdf','4'),(19,2,'+8442321323','Lê thị D','Hà Nội','sadsad','admin9','2023/07/02','T','2023/07/08','N','sadasd','admin9','gfewfef','3');
/*!40000 ALTER TABLE `ds_vande` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-08-15  9:20:27
