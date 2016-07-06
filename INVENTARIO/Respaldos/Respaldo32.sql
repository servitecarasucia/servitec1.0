-- MySQL dump 10.13  Distrib 5.7.13, for Win64 (x86_64)
--
-- Host: localhost    Database: servitecwebd
-- ------------------------------------------------------
-- Server version	5.7.13-log

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
-- Current Database: `servitecwebd`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `servitecwebd` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `servitecwebd`;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categoria` (
  `id_categoria` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `descripcion` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id_categoria`)
) ENGINE=MyISAM AUTO_INCREMENT=77 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES (45,'Memorias','Memoria'),(46,'Audifonos / Manos Libres','Audifonos / Manos Libres'),(47,'Cobertores','Cobertores'),(48,'Procesadores','Procesadores'),(49,'Motherboard','Motherboard'),(50,'Cables','Cables'),(51,'Cartuchos de Toner e Ink-Jet','Cartuchos de Toner e Ink-Jet'),(52,'Teclados Y Teclados Numericos','Teclados Y Teclados Numericos'),(53,'Mouse y Mouse Pads','Mouse y Mouse Pads'),(54,'Control P/Juegos PC','Control P/Juegos PC'),(55,'Ventiladores Enfriamiento/','Dicipadores de Calor'),(56,'Funda / Bolso / Maletin','Funda / Bolso / Maletin'),(57,'Sintonizador','Sintonizador'),(58,'Baterias y Cargadores','Baterias y Cargadores'),(59,'Accesorios P/Celular','Accesorios P/Celular'),(60,'Papeleria','Papeleria'),(61,'Audio / Video','Audio / Video'),(62,'Accesorios P/ Laptop','Accesorios P/ Laptop'),(63,'Lectores / Adaptadores','Lectores / Adaptadores'),(64,'Redes / Comunicacion','Redes / Comunicacion'),(65,'Kit de Limpieza','Kit de Limpieza'),(66,'Componentes Informaticos','Componentes Informaticos'),(67,'Almacenamiento','Almacenamiento'),(68,'Software','Software'),(69,'Calculadora/Contometro','Calculadora/Contometro'),(70,'Bocinas/Parlantes','Bocinas/Parlantes'),(71,'Camaras','Camaras'),(72,'Cintas Para Impresor','Matriciales'),(73,'Proteccion / Respaldo de Energia','Proteccion / Respaldo de Energia'),(74,'Impresores/Multifuncionales','Impresores/Multifuncionales'),(75,'Soportes/Rack','Soportes/Rack'),(76,'Sistema de Vigilancia','Sistema de Vigilancia');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `codcliente` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(250) DEFAULT NULL,
  `nit` varchar(250) DEFAULT NULL,
  `nrc` varchar(250) DEFAULT NULL,
  `giro` varchar(250) DEFAULT NULL,
  `direccion` varchar(250) DEFAULT NULL,
  `telefono` varchar(250) DEFAULT NULL,
  `fax` varchar(250) DEFAULT NULL,
  `e_mail` varchar(250) DEFAULT NULL,
  `estado` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`codcliente`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (8,'Elena Patricia','no tiene','no tiene','no tiene','El refujio San Francisco Menéndez Ahuachapán','74520350','','','inactivo'),(9,'Ciria Damaray Chicas Vda de Tobanche','0108-111283-102-2','211428-2','Vta. de papel','Casco la hacienda col. San Jose Cara Sucia San Francisco Menéndez Ahuachapán','2455-0248','','','Activo'),(10,'Jose Israel Pineda Escobar','0107-120381-101-0','208882-2','Act. Juridicas y Notariales','Calle ppal. Barrio San Martin Cara Sucia San Francisco Menéndez Ahuachapán','00000000','','','Activo'),(11,'Maria del Carmen Martinez de Henriquez','0108-090466-101-2','116052-2','Vta. de Medicina','Av. Central sur Barrio el progreso Cara Sucia San Francisco Menéndez Ahuachapán','farmacia Getsemani','','','Activo');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientescf`
--

DROP TABLE IF EXISTS `clientescf`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clientescf` (
  `idclientescf` int(11) NOT NULL AUTO_INCREMENT,
  `cliente` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`idclientescf`)
) ENGINE=MyISAM AUTO_INCREMENT=26 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientescf`
--

LOCK TABLES `clientescf` WRITE;
/*!40000 ALTER TABLE `clientescf` DISABLE KEYS */;
INSERT INTO `clientescf` VALUES (1,'Consumidor Final'),(25,'William Zepeda'),(24,'Elena Patricia'),(23,'David Cortez');
/*!40000 ALTER TABLE `clientescf` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `configuraciones`
--

DROP TABLE IF EXISTS `configuraciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `configuraciones` (
  `id_config` int(11) NOT NULL,
  `tirage_fact` varchar(250) DEFAULT NULL,
  `tirage_compro` varchar(250) DEFAULT NULL,
  `tirage_fact_actual` varchar(250) DEFAULT NULL,
  `tirage_compro_actual` varchar(250) DEFAULT NULL,
  `numfact` varchar(250) DEFAULT NULL,
  `numcompro` varchar(250) DEFAULT NULL,
  `iva` decimal(8,0) DEFAULT NULL,
  `cotrans` decimal(8,0) DEFAULT NULL,
  `porce_iva_ret` decimal(8,0) DEFAULT NULL,
  PRIMARY KEY (`id_config`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `configuraciones`
--

LOCK TABLES `configuraciones` WRITE;
/*!40000 ALTER TABLE `configuraciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `configuraciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departamentos`
--

DROP TABLE IF EXISTS `departamentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `departamentos` (
  `cod_departamento` int(11) NOT NULL,
  `departamentos` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`cod_departamento`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamentos`
--

LOCK TABLES `departamentos` WRITE;
/*!40000 ALTER TABLE `departamentos` DISABLE KEYS */;
INSERT INTO `departamentos` VALUES (1,'Ahuachapán'),(2,'Santa Ana'),(3,'Sonsonate'),(4,'Chalatenango'),(5,'Cuscatlán'),(6,'San Salvador'),(7,'La Libertad'),(8,'San Vicente'),(9,'La Paz'),(10,'Cabañas'),(11,'Usulután'),(12,'San Miguel'),(13,'Morazán'),(14,'La Unión');
/*!40000 ALTER TABLE `departamentos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detallecompra`
--

DROP TABLE IF EXISTS `detallecompra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detallecompra` (
  `coddetallefacturac` int(11) NOT NULL AUTO_INCREMENT,
  `codfacturac` int(11) DEFAULT NULL,
  `codproducto` varchar(500) DEFAULT NULL,
  `cantidadunit` double DEFAULT NULL,
  `descuento` double DEFAULT NULL,
  `precioreal` double DEFAULT NULL,
  `preciodescuento` double DEFAULT NULL,
  `total` double DEFAULT NULL,
  `total1` double DEFAULT NULL,
  `preciopublico` double DEFAULT NULL,
  PRIMARY KEY (`coddetallefacturac`),
  KEY `codfacturac` (`codfacturac`),
  KEY `codproducto` (`codproducto`)
) ENGINE=MyISAM AUTO_INCREMENT=2988 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detallecompra`
--

LOCK TABLES `detallecompra` WRITE;
/*!40000 ALTER TABLE `detallecompra` DISABLE KEYS */;
INSERT INTO `detallecompra` VALUES (2972,600,'798302167148',4,0,0,0,6.52,0,1.63),(2973,600,'798302167117',3,0,0,0,3.33,0,1.11),(2974,600,'1957351101391',3,0,0,0,10.2,0,3.4),(2975,600,'798302167339',3,0,0,0,9,0,3),(2976,600,'798302167469',4,0,0,0,15.8,0,3.95),(2977,600,'798302167032',5,0,0,0,13.05,0,2.61),(2978,600,'798302167193',5,0,0,0,11.45,0,2.29),(2979,600,'4713621226051',2,0,0,0,10.5,0,5.25),(2980,600,'4710728124648',5,0,0,0,15.25,0,3.05),(2981,600,'798302167360',5,0,0,0,28.85,0,4.95),(2982,600,'4713621226273',3,0,0,0,8.4,0,2.8),(2983,600,'7798135469375',11,0,0,0,23.65,0,2.15),(2984,600,'4713621226259',2,0,0,0,40,0,20),(2985,600,'4713621225689',1,0,0,0,1.15,0,1.15),(2986,600,'798302167186',10,0,0,0,5.2,0,0.52),(2987,600,'798302167346',9,0,0,0,5.13,0,0.57);
/*!40000 ALTER TABLE `detallecompra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalleventa`
--

DROP TABLE IF EXISTS `detalleventa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalleventa` (
  `coddetallefacturav` int(11) NOT NULL AUTO_INCREMENT,
  `codfacturav` int(11) DEFAULT NULL,
  `codproducto` varchar(500) DEFAULT NULL,
  `cantidadunit` double DEFAULT NULL,
  `descuento` double DEFAULT NULL,
  `precioreal` double DEFAULT NULL,
  `preciodescuento` double DEFAULT NULL,
  `total` double DEFAULT NULL,
  `total1` double DEFAULT NULL,
  `preciopublico` double DEFAULT NULL,
  PRIMARY KEY (`coddetallefacturav`),
  KEY `codfacturav` (`codfacturav`),
  KEY `codproducto` (`codproducto`)
) ENGINE=MyISAM AUTO_INCREMENT=8760 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalleventa`
--

LOCK TABLES `detalleventa` WRITE;
/*!40000 ALTER TABLE `detalleventa` DISABLE KEYS */;
INSERT INTO `detalleventa` VALUES (8759,3200,'798302167193',1,0,0,0,4.4,0,4.4);
/*!40000 ALTER TABLE `detalleventa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `direccion`
--

DROP TABLE IF EXISTS `direccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `direccion` (
  `id_direcciones` int(11) NOT NULL AUTO_INCREMENT,
  `direccion` varchar(1000) DEFAULT NULL,
  `id_municipio` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_direcciones`),
  KEY `id_municipio` (`id_municipio`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `direccion`
--

LOCK TABLES `direccion` WRITE;
/*!40000 ALTER TABLE `direccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `direccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `facturacompra`
--

DROP TABLE IF EXISTS `facturacompra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `facturacompra` (
  `codfacturac` int(11) NOT NULL AUTO_INCREMENT,
  `numfacturac` int(11) DEFAULT NULL,
  `tipo` varchar(100) DEFAULT NULL,
  `codproveedor` int(11) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `sumas` double DEFAULT NULL,
  `descuento` double DEFAULT NULL,
  `iva` double DEFAULT NULL,
  `nosujeta` double DEFAULT NULL,
  `exentas` double DEFAULT NULL,
  `total` double DEFAULT NULL,
  `formadepago` varchar(50) DEFAULT NULL,
  `unoretencion` double DEFAULT NULL,
  `estado` varchar(50) DEFAULT NULL,
  `tiraje` varchar(50) DEFAULT NULL,
  `fechalimite` date DEFAULT NULL,
  PRIMARY KEY (`codfacturac`),
  KEY `codproveedor` (`codproveedor`)
) ENGINE=MyISAM AUTO_INCREMENT=601 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facturacompra`
--

LOCK TABLES `facturacompra` WRITE;
/*!40000 ALTER TABLE `facturacompra` DISABLE KEYS */;
INSERT INTO `facturacompra` VALUES (600,1,'Factura',58,'2016-07-01',207.48,0,0,0,0,207.48,'Contado',0,'valida','1','2016-07-01');
/*!40000 ALTER TABLE `facturacompra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `facturaventa`
--

DROP TABLE IF EXISTS `facturaventa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `facturaventa` (
  `codfacturav` int(11) NOT NULL AUTO_INCREMENT,
  `numfacturav` int(11) DEFAULT NULL,
  `tipo` varchar(100) DEFAULT NULL,
  `codcliente` int(11) DEFAULT NULL,
  `fecha` datetime DEFAULT NULL,
  `sumas` double DEFAULT NULL,
  `descuento` double DEFAULT NULL,
  `iva` double DEFAULT NULL,
  `nosujeta` double DEFAULT NULL,
  `exentas` double DEFAULT NULL,
  `total` double DEFAULT NULL,
  `formadepago` varchar(50) DEFAULT NULL,
  `unoretencion` double DEFAULT NULL,
  `estado` varchar(50) DEFAULT NULL,
  `tiraje` varchar(50) DEFAULT NULL,
  `fechavence` datetime DEFAULT NULL,
  `comision` double DEFAULT NULL,
  PRIMARY KEY (`codfacturav`),
  KEY `codcliente` (`codcliente`)
) ENGINE=MyISAM AUTO_INCREMENT=3201 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facturaventa`
--

LOCK TABLES `facturaventa` WRITE;
/*!40000 ALTER TABLE `facturaventa` DISABLE KEYS */;
INSERT INTO `facturaventa` VALUES (3200,114,'Factura',1,'2016-07-02 00:00:00',4.4,0,0,0,0,4.4,'Contado',NULL,'valida','16AN000F','2016-07-02 00:00:00',0);
/*!40000 ALTER TABLE `facturaventa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grp`
--

DROP TABLE IF EXISTS `grp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `grp` (
  `IdGrp` int(11) NOT NULL AUTO_INCREMENT,
  `cGrp` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`IdGrp`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grp`
--

LOCK TABLES `grp` WRITE;
/*!40000 ALTER TABLE `grp` DISABLE KEYS */;
INSERT INTO `grp` VALUES (1,'Administrador'),(2,'SUPER USUARIO'),(3,'VENDEDOR');
/*!40000 ALTER TABLE `grp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grpusr`
--

DROP TABLE IF EXISTS `grpusr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `grpusr` (
  `IdGrpUsr` int(11) NOT NULL AUTO_INCREMENT,
  `IdGrp` int(11) NOT NULL,
  `IdUsr` varchar(15) NOT NULL,
  PRIMARY KEY (`IdGrpUsr`),
  KEY `IdGrp` (`IdGrp`),
  KEY `IdUsr` (`IdUsr`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grpusr`
--

LOCK TABLES `grpusr` WRITE;
/*!40000 ALTER TABLE `grpusr` DISABLE KEYS */;
INSERT INTO `grpusr` VALUES (1,1,'admin'),(2,3,'usuario1'),(3,2,'super');
/*!40000 ALTER TABLE `grpusr` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `menu`
--

DROP TABLE IF EXISTS `menu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `menu` (
  `IdOpc` int(11) NOT NULL AUTO_INCREMENT,
  `cNomOpc` varchar(20) DEFAULT NULL,
  `nIdBar` int(11) DEFAULT NULL,
  `cAccion` varchar(50) DEFAULT NULL,
  `cDescripcion` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdOpc`)
) ENGINE=MyISAM AUTO_INCREMENT=28 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menu`
--

LOCK TABLES `menu` WRITE;
/*!40000 ALTER TABLE `menu` DISABLE KEYS */;
INSERT INTO `menu` VALUES (1,'Maestros',0,'Ninguna','Maestros'),(2,'Grupos',1,'mGrupo','Maestro Grupos'),(3,'Usuarios',1,'mUsuarios','Maestro de usuarios'),(4,'Menu',1,'mMenu','Maestro del menu'),(5,'Configuracion',0,'Ninguna','Configuracion'),(6,'Grupos de usuarios',5,'frmUsuarios','Grupos de usuarios'),(7,'Permisos',5,'frmPermisos','Permisos'),(8,'Mantenimiento',0,'Ninguna','Menu mantenimiento'),(9,'Productos',8,'Productos','Mustra los productos'),(10,'Proveedores',8,'Proveedores','Muestra los proveedores'),(21,'Configuraciones',8,'Configuraciones','muestra las configuraciones'),(12,'Movimientos',0,'Ninguna','Nada'),(13,'Compras',12,'compra','facturas compras'),(14,'Ventas',12,'Ventas','Facturas ventas'),(15,'Clientes',8,'Clientes','Clientes'),(16,'Documentos',0,'Ninguna','para ver docuentos'),(17,'Compras realizadas',16,'Compras_realizadas','muestra las compras realizadas'),(18,'Ventas Realizadas',16,'VentasRealizadas','muestra las ventas realizadas'),(19,'Kardex',16,'Kardex','muestra el kardez'),(20,'Reportes',16,'Reportes','Muestra las distintos reportez'),(22,'Respaldos',8,'Respaldos','Hace respaldo del al base de datos'),(23,'Compras y Ventas',12,'VentasCompras','Para ver las compras y las ventas '),(24,'Cotizar',0,'Ventas','para cotizar'),(25,'Combinar ',8,'Combinar','Para combinar articulos'),(26,'Notas de Credito',12,'Creditos','Notas de credito'),(27,'Generar Documentos',12,'GenerarDocumentos','generar');
/*!40000 ALTER TABLE `menu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `municipios`
--

DROP TABLE IF EXISTS `municipios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `municipios` (
  `id_municipio` int(11) NOT NULL AUTO_INCREMENT,
  `municipio` varchar(50) DEFAULT NULL,
  `cod_departamento` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_municipio`),
  KEY `cod_departamento` (`cod_departamento`)
) ENGINE=MyISAM AUTO_INCREMENT=264 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `municipios`
--

LOCK TABLES `municipios` WRITE;
/*!40000 ALTER TABLE `municipios` DISABLE KEYS */;
INSERT INTO `municipios` VALUES (1,'Ahuachapán',1),(2,'Jujutla',1),(3,'Atiquizaya',1),(4,'Concepción de Ataco',1),(5,'El Refugio',1),(6,'Guaymango',1),(7,'Apaneca',1),(8,'San Francisco Menéndez',1),(9,'San Lorenzo',1),(10,'San Pedro Puxtla',1),(11,'Tacuba',1),(12,'Turín',1),(13,'Candelaria de la Frontera',2),(14,'Chalchuapa',2),(15,'Coatepeque',2),(16,'El Congo',2),(17,'El Porvenir',2),(18,'Masahuat',2),(19,'Metapán',2),(20,'San Antonio Pajonal',2),(21,'San Sebastián Salitrillo',2),(22,'Santa Ana',2),(23,'Santa Rosa Guachipilín',2),(24,'Santiago de la Frontera',2),(25,'Texistepeque',2),(26,'Acajutla',3),(27,'Armenia',3),(28,'Caluco',3),(29,'Cuisnahuat',3),(30,'Izalco',3),(31,'Juayúa',3),(32,'Nahuizalco',3),(33,'Nahulingo',3),(34,'Salcoatitán',3),(35,'San antonio del Monte',3),(36,'San Julián',3),(37,'Santa Catarina Masahuat',3),(38,'Santa Isabel Ishuatán',3),(39,'Santo Domingo',3),(40,'Sonsonate',3),(41,'Sonzacate',3),(42,'Agua Caliente',4),(43,'Arcatao',4),(44,'Azacualpa',4),(45,'Chalatenango',4),(46,'Citalá',4),(47,'Comalapa',4),(48,'Concepción Quezaltepeque',4),(49,'Dulce Nombre de Maria',4),(50,'El Carrizal',4),(51,'El Paraíso',4),(52,'La Laguna',4),(53,'La Palma',4),(54,'La Reina',4),(55,'Las Vueltas',4),(56,'Nueva Concepción',4),(57,'Nueva Trinidad',4),(58,'Nombre de Jesús',4),(59,'Ojos de Agua',4),(60,'Potonico',4),(61,'San Antonio de la Cruz',4),(62,'San Antonio Los Ranchos',4),(63,'San Fernando',4),(64,'San Francisco Lempa',4),(65,'San Francisco Morazán',4),(66,'San Ignacio',4),(67,'San Isidro Labrador',4),(68,'San José Cancasque',4),(69,'San José Las Flores',4),(70,'San Luis del Carmen',4),(71,'San Miguel de Mercedes',4),(72,'San Rafael',4),(73,'Santa Rita',4),(74,'Tejutla',4),(75,'Candelaria',5),(76,'Cojutepeque',5),(77,'El Carmen',5),(78,'El Rosario',5),(79,'Monte San Juan',5),(80,'Oratorio de Concepción',5),(81,'San Bartolomé Perulapía',5),(82,'San Cristóbal',5),(83,'San José Guayabal',5),(84,'San Pedro Perulapán ',5),(85,'San Rafael Cedros',5),(86,'San Ramón',5),(87,'Santa Cruz Analquito',5),(88,'Santa Cruz Michapa',5),(89,'Suchitoto',5),(90,'Tenancingo',5),(91,'Aguilares',6),(92,'Apopa',6),(93,'Ayutuxtepeque',6),(94,'Cuscatancingo',6),(95,'Delgado',6),(96,'El Paisnal',6),(97,'Guazapa',6),(98,'Ilopango',6),(99,'Mejicanos',6),(100,'Nejapa',6),(101,'Panchimalco',6),(102,'Rosario de Mora',6),(103,'San Marcos',6),(104,'San Martín',6),(105,'San Salvador',6),(106,'Santiago Texacungos',6),(107,'Santo Tomás',6),(108,'Santo Tomás',6),(109,'Soyapango',6),(110,'Tonacatepeque',6),(111,'Antiguo Cuscatlán',7),(112,'Chitiupán',7),(113,'Ciudad Arce',7),(114,'Colón',7),(115,'Comasagua',7),(116,'Huizúcar',7),(117,'Jayaque',7),(118,'Jicalapa',7),(119,'La Libertad',7),(120,'Santa Tecla',7),(121,'Nuevo Cuscatlán',7),(122,'San Juan Opico',7),(123,'Quezaltepeque',7),(124,'Sacacoyo',7),(125,'San José Villanueva',7),(126,'San Matías',7),(127,'San Pablo Tacachico',7),(128,'Talnique',7),(129,'Tamanique',7),(130,'Teotepeque',7),(131,'Tepecoyo',7),(132,'Zaragoza',7),(133,'Apastepeque',8),(134,'Guadalupe',8),(135,'San Cayetano Istepeque',8),(136,'San Esteban Catarina',8),(137,'San Ildefonso',8),(138,'San Lorenzo',8),(139,'San Sebastián',8),(140,'San Vicente',8),(141,'Santa Clara',8),(142,'Santo Domingo',8),(143,'Tecoluca',8),(144,'Tepetitán',8),(145,'Verapaz',8),(146,'Cuyulán',9),(147,'El Rosario',9),(148,'Jerusalén',9),(149,'Mercedes La Ceiba',9),(150,'Olocuilta',9),(151,'Paraíso de Osorio',9),(152,'San Antonio Masahuat',9),(153,'San Emigdio',9),(154,'San Francisco Chinameca',9),(155,'San Juan Nonualco',9),(156,'San Juan Talpa',9),(157,'San Juan tepezontes',9),(158,'San Luis Talpa',9),(159,'San Luis La Herradura',9),(160,'San Miguel Teepezontes',9),(161,'San Pedro Masahuat',9),(162,'San Pedro Nonualco',9),(163,'San Rafael Obrajuelo',9),(164,'Santa María Ostuma',9),(165,'Santiago Nonualco',9),(166,'Tapalhuaca',9),(167,'Zacatecoluca',9),(168,'Cinquera',10),(169,'Dolores',10),(170,'Guacotecti',10),(171,'Ilobasco',10),(172,'Jutiapa',10),(173,'San Isidro',10),(174,'Sensutepeque',10),(175,'Tejutepeque',10),(176,'Victoria',10),(177,'Alegría',11),(178,'Berlín',11),(179,'California',11),(180,'Concepción Batres',11),(181,'El Triunfo',11),(182,'Ereguayquín',11),(183,'Estanzuelas',11),(184,'Jiquilisco',11),(185,'Jucuapa',11),(186,'Jucuarán',11),(187,'Mercedes Umaña',11),(188,'Nueva Granada',11),(189,'Ozatlán',11),(190,'Puerto El Triunfo',11),(191,'San Agustín',11),(192,'San Buenaventura',11),(193,'San Dionisio',11),(194,'San Francisco Javier',11),(195,'Santa Elena',11),(196,'Santa María',11),(197,'Santiago de María',11),(198,'Tacapán',11),(199,'Usulután',11),(200,'Carolina',12),(201,'Chapeltique',12),(202,'Chinameca',12),(203,'Chirilagua',12),(204,'Ciudad Barrios',12),(205,'Comacarán',12),(206,'El Tránsito',12),(207,'Lolotique',12),(208,'Moncagua',12),(209,'Nueva Guadalupe',12),(210,'Nuevo Edén de San Juan',12),(211,'Quelepa',12),(212,'San Antonio del Mosco',12),(213,'San Gerardo',12),(214,'San Jorge',12),(215,'San Luis de la Reina',12),(216,'San Miguel',12),(217,'San Rafael Oriente',12),(218,'Sesori',12),(219,'Uluazapa',12),(220,'Arambala',13),(221,'Cacaopera',13),(222,'Chilanga',13),(223,'Corinto',13),(224,'Delicias de Concepción',13),(225,'El Divisadero',13),(226,'El Rosario',13),(227,'Gualococti',13),(228,'Guatajiagua',13),(229,'Joateca',13),(230,'Jocoatiquea',13),(231,'Jocoro',13),(232,'Lolotiquillo',13),(233,'Meanguera',13),(234,'Osicala',13),(235,'Periquín',13),(236,'San Carlos',13),(237,'San Fernando',13),(238,'San Francisco Gotera',13),(239,'San Isidro',13),(240,'San Simón',13),(241,'Sensembra',13),(242,'Sociedad',13),(243,'Torola',13),(244,'Yamabal',13),(245,'Yoloaiquín',13),(246,'La Unión',14),(247,'San Alejo',14),(248,'Yucuaquín',14),(249,'Conchugua',14),(250,'Intipucá',14),(251,'San José',14),(252,'El Carmen',14),(253,'Yayantique',14),(254,'Bolívar',14),(255,'Meanguera del Golfo',14),(256,'Santa Rosa de Lima',14),(257,'Pasaquina',14),(258,'Anamorós',14),(259,'Nueva Esparta',14),(260,'El Sauce',14),(261,'Concepción de Oriente',14),(262,'Polorós',14),(263,'Lislique',14);
/*!40000 ALTER TABLE `municipios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `notificaciones`
--

DROP TABLE IF EXISTS `notificaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `notificaciones` (
  `idnoti` int(11) NOT NULL AUTO_INCREMENT,
  `orden` int(11) DEFAULT NULL,
  `tipo` varchar(50) DEFAULT NULL,
  `cliente` varchar(50) DEFAULT NULL,
  `cantidad` double DEFAULT NULL,
  `idfacturav` int(11) DEFAULT NULL,
  PRIMARY KEY (`idnoti`),
  KEY `idfacturav` (`idfacturav`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `notificaciones`
--

LOCK TABLES `notificaciones` WRITE;
/*!40000 ALTER TABLE `notificaciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `notificaciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `numeros`
--

DROP TABLE IF EXISTS `numeros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `numeros` (
  `idnumeros` int(11) NOT NULL AUTO_INCREMENT,
  `numero` int(11) DEFAULT NULL,
  `nombre` varchar(25) DEFAULT NULL,
  KEY `idnumeros` (`idnumeros`)
) ENGINE=MyISAM AUTO_INCREMENT=89 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `numeros`
--

LOCK TABLES `numeros` WRITE;
/*!40000 ALTER TABLE `numeros` DISABLE KEYS */;
INSERT INTO `numeros` VALUES (1,1,'un'),(2,2,'dos'),(3,3,'tres'),(4,4,'cuatro'),(5,5,'cinco'),(6,6,'seis'),(7,7,'siete'),(8,8,'ocho'),(9,9,'nueve'),(10,10,'diez'),(11,11,'once'),(12,12,'doce'),(13,13,'trece'),(14,14,'catorce'),(15,15,'quince'),(16,16,'diciseis'),(17,17,'diecisiete'),(18,18,'dieciocho'),(19,19,'diecinueve'),(20,20,'veinte'),(22,30,'treinta'),(23,31,'uno'),(24,40,'cuarenta'),(25,50,'cincuenta'),(26,60,'sesenta'),(27,70,'setenta'),(28,80,'ochenta'),(29,90,'noventa'),(30,100,'cien'),(31,101,'ciento'),(32,200,'doscientos'),(33,300,'trescientos'),(34,400,'cuatrocientos'),(35,500,'quinientos'),(36,600,'seiscientos'),(37,700,'setecientos'),(38,800,'ochocientos'),(39,900,'nuevecientos'),(40,1000,'mil'),(46,23,'veintitres'),(45,22,'veintidos'),(44,21,'veintiun'),(47,24,'veiticuatro'),(48,25,'veinticinco'),(49,26,'veintiseis'),(50,27,'veintisiete'),(51,28,'veintiocho'),(52,29,'veintinueve'),(53,1000,'mil'),(54,2000,'dos mil'),(55,3000,'tres mil'),(56,4000,'cuatro mil'),(57,5000,'cinco mil'),(58,6000,'seis mil'),(59,7000,'siete mil'),(60,8000,'ocho mil'),(61,9000,'nueve mil'),(62,10000,'dies mil'),(63,11000,'once mil'),(64,12000,'doce mil'),(65,13000,'trece mil'),(66,14000,'catorce mil'),(67,15000,'quince mil'),(68,16000,'dieciseis mil'),(69,17000,'diecisiete mil'),(70,18000,'dieciocho mil'),(71,19000,'dicinueve mil'),(72,20000,'veinte mil'),(73,21000,'veintiun mil'),(74,22000,'veintidos mil'),(75,23000,'veintitres mil'),(76,24000,'veinticuatro mil'),(77,25000,'veinticinco mil'),(78,26000,'vintiseis mil'),(79,27000,'veintisiete mil'),(80,28000,'veintiocho mil'),(81,29000,'veintinueve mil'),(82,30000,'treinta mil'),(83,40000,'cuarenta mil'),(84,50000,'cincuenta mil'),(85,60000,'sensenta mil'),(86,70000,'setenta mil'),(87,80000,'ochenta mil'),(88,90000,'noventa mil');
/*!40000 ALTER TABLE `numeros` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `permisos`
--

DROP TABLE IF EXISTS `permisos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `permisos` (
  `IdPermiso` int(11) NOT NULL AUTO_INCREMENT,
  `IdGrp` int(11) NOT NULL,
  `IdOpc` int(11) NOT NULL,
  PRIMARY KEY (`IdPermiso`),
  KEY `IdGrp` (`IdGrp`),
  KEY `IdOpc` (`IdOpc`)
) ENGINE=MyISAM AUTO_INCREMENT=59 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permisos`
--

LOCK TABLES `permisos` WRITE;
/*!40000 ALTER TABLE `permisos` DISABLE KEYS */;
INSERT INTO `permisos` VALUES (1,1,1),(2,1,2),(3,1,3),(4,1,4),(5,1,5),(6,1,6),(7,1,7),(8,1,8),(9,1,9),(10,1,10),(11,1,21),(12,1,15),(13,1,22),(14,1,12),(15,1,13),(16,1,14),(17,1,16),(18,1,17),(19,1,18),(20,1,19),(21,1,20),(22,2,8),(23,2,9),(24,2,10),(44,2,14),(26,2,15),(27,2,22),(28,2,12),(29,2,13),(43,2,21),(31,2,16),(32,2,17),(33,2,23),(34,1,23),(35,3,8),(36,3,9),(37,3,10),(38,3,15),(39,3,12),(40,3,13),(41,3,16),(42,3,17),(45,2,18),(46,3,14),(48,3,18),(49,1,25),(50,2,25),(51,3,25),(56,2,20),(53,2,26),(54,3,26),(55,2,27),(57,3,23),(58,3,27);
/*!40000 ALTER TABLE `permisos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `productos` (
  `codproducto` varchar(500) NOT NULL,
  `nombre` varchar(500) DEFAULT NULL,
  `descripcion` varchar(500) DEFAULT NULL,
  `precio_unit` double DEFAULT NULL,
  `precioindi` double DEFAULT NULL,
  `preciopublico` double DEFAULT NULL,
  `existencias` double DEFAULT NULL,
  `id_categoria` int(11) DEFAULT NULL,
  `unid_med` varchar(50) DEFAULT NULL,
  `valida` varchar(50) DEFAULT NULL,
  `popular` double DEFAULT NULL,
  `frecuente` double DEFAULT NULL,
  `mayoreo` double DEFAULT NULL,
  PRIMARY KEY (`codproducto`),
  KEY `id_categoria` (`id_categoria`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` VALUES ('4710728124723','Cable extencion HDMI 6ft Omega','Cable extencion HDMI 6ft Omega  A/M to A/F',4.74,4.74,0,-6,50,'Unidad','1',7.5,6.96,6.43),('798302167148','Cable Extencion USB 15ft 4.5mts Xtech','Cable Extencion USB 15ft 4.5mts Xtech 306',1.63,1.63,0,0,50,'Unidad','1',3.15,2.75,2.6),('798302167117','Cable P/Impresor 10ft 3.8mts Xtech','Cable P/Impresor 10ft 3.8mts Xtech - 303 2.0',1.11,1.11,0,0,50,'Unidad','1',2.15,2,1.9),('1957351101391','Cable Splitter VGA Imexx 2 puntas','Cable Splitter VGA Imexx 2 puntas  -10517',3.4,3.4,0,0,50,'Unidad','1',6.55,6.2,5.85),('798302167339','Cable Splitter VGA Xtech 2 puntas  0.9ft','Cable Splitter VGA Xtech 2 puntas  0.9ft 325',3,3,0,0,50,'Unidad','1',5.8,5.5,5.2),('798302167032','Cable HDMI 10ft 3m Xtech','Cable HDMI 10ft 3m Xtech-152',2.61,2.61,0,0,50,'Unidad','1',5.3,5.05,4.75),('798302167469','Cable HDMI 15ft 5.3mts Xtech','Cable HDMI 15ft 5.3mts Xtech 338',3.95,3.95,0,0,50,'Unidad','1',7.6,7.2,6.85),('798302167193','Cable HDMI 6ft 1.8m Xtech','Cable HDMI 6ft 1.8m Xtech-311',2.29,2.29,0,-1,50,'Unidad','1',4.4,4.2,3.95),('4713621226051','Cable HDMI a Micro HDMI 1.8mts Agiler','Cable HDMI a Micro HDMI 1.8mts Agiler AGI-1129',5.25,5.25,0,0,50,'Unidad','1',8.55,8.3,7.7),('4710728124648','Cable P/Monitor VGA 6ft Omega BK','Cable P/Monitor VGA 6ft Omega BK',3.05,3.05,0,0,50,'Unidad','1',6.5,5.8,5.55),('4713621225887','Cable DVI (M) To HDMI 6ft Agiler','Cable DVI (M) To HDMI 6ft Agiler AGI-1119',6.85,6.85,0,0,50,'Unidad','1',11.15,10.8,10.05),('798302167360','Cable P/Monitor DVI To DVI 6ft Xtech','Cable P/Monitor DVI To DVI 6ft Xtech',4.95,4.95,0,1,50,'Unidad','1',9.05,8.55,8.05),('4713621226273','Cable OTG USB to Micro USB Agiler','Cable OTG USB to Micro USB Agiler AGI-1194',2.8,2.8,0,0,50,'Unidad','1',6,5.4,5.1),('7798135469375','Cable OTG USB To Mini USB Eurocase','Cable OTG USB To Mini USB Eurocase 1442',2.15,2.15,0,0,50,'Unidad','1',4.6,4.15,3.9),('798302167346','Cable Serial Sata Datos HDD Xtech','Cable Serial Sata Datos HDD Xtech 326',0.57,0.57,0,0,50,'Unidad','1',1.6,1.4,1.3),('798302167186','Cable Serial SATA Poder 0.5ft Xtech','Cable Serial SATA Poder 0.5ft Xtech 310 IDE to Sata',0.52,0.52,0,0,50,'Unidad','1',1.45,1.3,1.15),('4713621226259','Cable Convertidor HDMI to VGA Audio Output Agiler','Cable Convertidor HDMI to VGA Audio Output Agiler',20,20,0,0,50,'Unidad','1',32.6,31.6,29.3),('4713621225689','Cable de Audio Male To Male 3.5 Agiler','Cable de Audio Male To Male 3.5 Agiler-1136',1.15,1.15,0,0,50,'Unidad','1',2,1.85,1.7),('013803134933','Cartucho Canon CL-141 Color','Cartucho Canon CL-141 Color 8 ml',15.63,15.63,0,0,51,'Unidad','1',24.73,22.96,21.19),('013803214871','Cartucho Canon  CL-41 Color','Cartucho Canon  CL-41 Color 4ml x 3',19.98,19.98,0,0,51,'Unidad','1',31.61,29.35,27.09),('013803215502','Cartucho Canon CL-146 Color','Cartucho Canon CL-146 Color 9 ml',15.72,15.72,0,0,51,'Unidad','1',24.87,23.09,22),('013803215465','Cartucho Canon PG-145','Cartucho Canon PG-145 8ml',12.27,12.27,0,0,51,'Unidad','1',20.8,19.4,18),('013803215014','Cartucho Canon PG-210 Black','Cartucho Canon PG-210 Black 9ml',12.42,12.42,0,0,51,'Unidad','1',21,19.64,18.25),('886112670122','Cartucho HP 662 Tricolor','Cartucho HP 662 Tricolor  CZ104AL',7.85,7.85,0,0,51,'Unidad','1',13.3,12.4,11.55),('886112670115','Cartucho HP 662 Black','Cartucho HP 662 Black CZ103AL',7.85,7.85,0,0,51,'Unidad','1',13.3,12.41,11.53),('884962983553','Cartucho HP 122 Tricolor','Cartucho HP 122 Tricolor CH562HL',11.25,11.25,0,0,51,'Unidad','1',19.05,17.8,16.5),('884962983546','Cartucho HP 122 Black','Cartucho HP 122 Black CH561HL',9.15,9.15,0,0,51,'Unidad','1',15.5,14.45,13.45),('884420013327','Cartucho HP 901 Black','Cartucho HP 901 Black CC653AL 4.5ML',14.4,14.4,0,0,51,'Unidad','1',24.4,22.8,21.15),('884420013341','Cartucho HP 901 Tricolor','Cartucho HP 901 Tricolor CC656AL 13ML',26.35,26.35,0,0,51,'Unidad','1',41.69,38.71,35.73),('883585983179','Cartucho HP 60 Black','Cartucho HP 60 Black CC640WL 4.5 ml',16,16,0,0,51,'Unidad','1',25.31,23.5,21.7),('883585983193','Cartucho HP 60 Tricolor','Cartucho HP 60 Tricolor CC6473WL 3ml',19.25,19.25,0,0,51,'Unidad','1',30.45,28.28,26.1),('829160902227','Cartucho HP 22Tricolor','Cartucho HP 22Tricolor C9352AL 6ml',20.85,20.85,0,0,51,'Unidad','1',32.98,30.63,28.27),('883585991419','Cartucho HP 564 amarillo','Cartucho HP 564 amarilloCB320WL',12.55,12.55,0,0,51,'Unidad','1',19.85,18.44,17.02),('883585991396','Cartucho HP 564 Azul','Cartucho HP 564 Azul CB318WL 3ML',12.55,12.55,0,0,51,'Unidad','1',19.85,18.44,17.02),('883585991402','Cartucho HP 564 Rojo','Cartucho HP 564 Rojo  CB319WL 3ML',12.55,12.55,0,0,51,'Unidad','1',19.85,18.44,17.02),('010343885325','Refil Epson T664420 Amarillo','Refil Epson T664420 Amarillo',7.965,7.965,0,0,51,'Unidad','1',12.6,11.7,10.8),('010343885318','Refil Epson T664320 Rojo','Refil Epson T664320 Rojo 70 ml',7.965,7.965,0,0,51,'Unidad','1',12.6,11.7,10.8),('010343876965','Cartucho Epson 133 Amarillo T133420','Cartucho Epson 133 Amarillo T133420 5ml',11.45,11.45,0,0,51,'Unidad','1',18.11,16.82,15.53),('010343876958','Cartucho Epson 133 Rojo T133320','Cartucho Epson 133 Rojo T133320 5ml',11.45,11.45,0,0,51,'Unidad','1',18.11,16.82,15.53),('010343858886','Cartucho Epson 73N Rojo T073320','Cartucho Epson 73N Rojo T073320 5ml',10.02,10.02,0,0,51,'Unidad','1',15.85,14.72,13.59),('010343858879','Cartucho Epson 73N Azul T073220','Cartucho Epson 73N Azul T073220 5ml',10.02,10.02,0,0,51,'Unidad','1',15.85,14.72,13.59),('010343858893','Cartucho Epson 73N Amarillo T073420','Cartucho Epson 73N Amarillo T073420 5ml',10.02,10.02,0,0,51,'Unidad','1',15.85,14.72,13.59),('091163231929','Teclado Genius USB LuxeMate i200 Multimedia','Teclado Genius LuxeMate i200 Compact Multimedia',6.12,6.12,0,0,52,'Unidad','1',15.21,14.52,13.83),('798302180680','Teclado USB Omega KB 2000 Multimedia','Teclado USB Omega KB 2000 Multimedia',3.11,3.11,0,0,52,'Unidad','1',7,6.65,6.3),('798302160989','Teclado USB Xtech XTK190s Multimedia','Teclado USB Xtech XTK190s Multimedia',3.9,3.9,0,0,52,'Unidad','1',7.95,7.5,7),('091163235323','Teclado Numerico USB Genius Numpad i110','Teclado Numerico USB Genius Numpad i110',7.5,7.5,0,0,52,'Unidad','1',12.7,11.86,11),('4710728125744','Mouse USB Omega Gaming 6D Black','Mouse USB Omega Gaming 6D Black',7.5,7.5,0,0,53,'Unidad','1',12.5,11.85,11),('091166144295','Mouse Wireless Genius NS-6000','Mouse Wireless Genius NS-6000 Optical',7.5,7.5,0,0,53,'Unidad','1',15.25,14.4,13.55),('091163251477','Mouse USB Genius DX-110 Black','Mouse USB Genius DX-110 Black',3.95,3.95,0,0,53,'Unidad','1',7.55,7.15,6.7),('798302074934','Mouse USB Klip Xtreme KMO-120 Black','Mouse USB Klip Xtreme Galet KMO-120 Black',5.1,5.1,0,0,53,'Unidad','1',8.65,8.05,7.5),('798302180550','Mouse USB Klip Xtreme KMO-104 Black','Mouse USB Klip Xtreme KMO-104 Black Ebony',4.1,4.1,0,0,53,'Unidad','1',7.4,6.95,6.5),('4710728125140','Mouse Pad Omega Gaming','Mous Pad Omega Gaming',2.5,2.5,0,0,53,'Unidad','1',3.95,3.67,3.39),('550325','Mouse Pad Ergonomico Etouch','Mouse Pad Ergonomico Etouch Gotas,Chicago,Gatoy Perro, Liso',1.6,1.6,0,0,53,'Unidad','1',2.5,2.35,2.17),('6936103601186','Control P/Juegos Etouch USB / PC','Control P/Juegos Etouch USB / PC',2.9,2.9,0,0,54,'Unidad','1',7.5,6.5,5.5),('091163230625','Control P/Juego Genius MacFire G-08X2 USB/PC','Control P/Juego Genius MacFire G-08X2 USB/PC 8 BOtones',2.9,2.9,0,0,54,'Unidad','1',7.2,6.55,5.8),('025215488610','Ventilador P/Laptop Maxell LaptopXStand USB','Ventilador P/Laptop Maxell LaptopXStand LC-1 Aluminio',18.5,18.5,0,0,55,'Unidad','1',29.27,27.18,25.09),('085854229227','Funda Case Logic Ipad mini/Tablet 7\" Rosado','Funda Case Logic Ipad mini/Tablet 7\" Rosado TNEO-108',8.5,8.5,0,0,56,'Unidad','1',14.4,13.45,12.45),('085854228862','Funda Case Logic Ipad mini/Tablet 7\" Black','Funda Case Logic Ipad mini/Tablet 7\" Black TNEO108',8.5,8.5,0,0,56,'Unidad','1',14.4,13.45,12.5),('4710728127397','Funda P/Laptop Omega 12\" Black','Funda P/Laptop Omega 12\" Black 10-12\"',2.99,2.99,0,0,56,'Unidad','1',6,5.4,4.75),('4710728127243','Funda P/Laptop Omega 15.6\" Black','Funda P/Laptop Omega 15.6\" Black 658309',4.5,4.5,0,0,56,'Unidad','1',9.15,8.65,7.6),('4710728127380','Funda P/Laptop Omega 7\"-10\" Black','Funda P/Laptop Omega 7\"-10\" Black 658305H',3.2,3.2,0,0,56,'Unidad','1',7.25,6.5,5.75),('4710728127342','Funda P/Laptop  Omega 10\" Rosa','Funda P/Laptop  Omega 10\" Rosa 658308',3.2,3.2,0,0,56,'Unidad','1',6.5,5.75,5.4),('025215489433','Sintonizador CarMedia Player Maxell FMT-31','Sintonizador CarMedia Player Maxell FMT-31 1.4\" LCD',18.1,18.1,0,0,57,'Unidad','1',28.63,26.59,24.54),('4710728126000','Bateria Portable Omega 4000 mah Black','Bateria Portable Omega 4000 mah Black Power bank',14.9,14.9,0,0,58,'Unidad','1',23.6,21.9,20.2),('4710728126406','Estuche Con Teclado P/Tablet 7\" Omega Black','Estuche Con Teclado P/Tablet 7\" Omega Black KB-1700',8,8,0,0,56,'Unidad','1',18.05,17.17,15.35),('886540003400','Baston Selfie Stick Argom Black','Baston Selfie Stick Argom Black ARG-AC-9175B',7.25,7.25,0,0,59,'Unidad','1',11.5,10.65,9.85),('886540001529','Soporte Vehicular P/Celular Argom Black','Soporte Vehicular P/Celular Argom Black ARG-AC-0325',4.6,4.6,0,0,59,'Unidad','1',7.8,7.3,6.75),('034707004245','Etiquetas P/CD/DVD Memorex Pk120','Etiquetas P/CD/DVD Memorex Pk120',18,0.3,0,0,60,'Caja','1',28.48,26.44,24.41),('034707004122','Etiquetador P/CD/DVD Memorex  Pk50','Etiquetador P/CD/DVD Memorex  Pk50',6.5,0.3,0,0,60,'Caja','1',11,10.3,9.55),('4713621995810','Tarjeta de Sonido USB Agiler 1130','Tarjeta de Sonido USB Agiler 1130 sound 5.1 tide',4.95,4.95,0,0,61,'Unidad','1',8.95,8.4,7.85),('025215487934','Microfono P/Laptop  Maxell Unidireccional TRS3.5','Microfono P/Laptop  Maxell Unidireccional TRS3.5',5,5,0,0,61,'Unidad','1',8.5,7.9,7.35),('025215493638','Audifono con Microfono Big-550 Maxell Bla-Rosa','Audifono con Microfono Big-550 Maxell Full SiZe',12,12,0,0,46,'Unidad','1',19,17.65,16.3),('025215491658','Audifono con Microfono Maxell SMS-10 Amarillo','Audifono con Microfono Maxell SMS-10 Mid-Size',13,13,0,0,46,'Unidad','1',22.05,20.55,19.1),('025215491238','Audifonos Plugs Earbuds Maxell Rosado','Audifonos Plugs Earbuds Maxell Rosado IN-225',3.47,3.47,0,0,46,'Unidad','1',5.5,5.1,4.7),('025215491207','Audifonos Plugs Earbuds Maxell Blanco','Audifonos Plugs Earbuds Maxell Blanco IN225',3.47,3.47,0,0,46,'Unidad','1',5.5,5.1,4.7),('025215491221','Audifonos Plugs Earbuds Maxell Blanco','Audifonos Plugs Earbuds Maxell Blanco IN225',3.47,3.47,0,0,46,'Unidad','1',5.5,5.1,4.7),('025215191312','Audifono Jelleez Maxell EB-CB azul 3.5','Audifono Jelleez Maxell EB-CB azul',3.47,3.47,0,0,46,'Unidad','1',5.5,5.1,4.7),('025215191367','Audifono Jelleez Maxell EB-PK Rosado 3.5','Audifono Jelleez Maxell EB-PK',3.47,3.47,0,0,46,'Unidad','1',5.5,5.1,4.7),('3022889219318','Audifono Cool Beans Maxell CBS-P Rosado','Audifono Cool Beans Maxell CBS-P Rosado',5,5,0,0,46,'Unidad','1',7.9,7.35,6.8),('025215192968','Audifono Juicy Tunes Maxell  Rosado','Audifono Juicy Tunes Maxell  Rosado  JT-P',4,4,0,0,46,'Unidad','1',7.25,6.8,6.35),('025215192999','Audifono Juicy Tunes Maxell  Morado','Audifono Juicy Tunes Maxell  Rosado JT-PU',4,4,0,0,46,'Unidad','1',7.25,6.8,6.4),('798302061637','Audifono Klip Xtreme KSE-100G','Audifono Klip Xtreme KSE-100G Verde',4,4,0,0,46,'Unidad','1',7.25,6.8,6.4),('798302060555','Audifono Klip Xtreme KSE-100','Audifono Klip Xtreme KSE-100 Gris',4,4,0,0,46,'Unidad','1',7.25,6.8,6.4),('798302061644','Audifono Klip Xtreme KSE-100P','Audifono Klip Xtreme KSE-100P Rosa',4,4,0,0,46,'Unidad','1',7.25,6.8,6.4),('4710728126925','Audifono de Diadema con Microfono Omega Black','Audifono de Diadema con Microfono Omega Black',1.75,1.75,0,0,46,'Unidad','1',3.35,2.95,2.75),('4710728126932','Audifono Stylish Omega Largo Negro','Audifono Stylish Omega Largo Negro',1.8,1.8,0,0,46,'Unidad','1',3.45,3,2.8),('4710728127885','Audifono Stylish Omega Redondo Negro','Audifono Stylish Omega Redondo Negro',1.8,1.8,0,0,46,'Unidad','1',3.45,3,2.85),('4710728127168','Microfo Con Pedestal Para PC Omega Plateado','Microfo Con Pedestal Para PC Omega Plateado',1.5,1.5,0,0,61,'Unidad','1',3,2.7,2.5),('740617128147','Memoria MicroSDHC a SD 8GB Kingston Class4','Memoria MicroSDHC a SD 8GB Kingston Class4',3.85,3.85,0,0,45,'Unidad','1',6.5,6,5.65),('740617245882','Memoria MicroSDHC a SD 8GB Kingston Class10','Memoria MicroSDHC a SD 8GB Kingston Class10',4.58,4.58,0,0,45,'Unidad','1',8.3,7.75,7.25),('740617173741','Memoria MicroSDHC a SD 16GB Kingston Class4','Memoria MicroSDHC a SD 16GB Kingston Class4',4.5,4.5,0,0,45,'Unidad','1',10.15,9.65,9.15),('740617245974','Memoria MicroSDHC a SD 16GB Kingston Class10','Memoria MicroSDHC a SD 16GB Kingston Class10',4.75,4.75,0,0,45,'Unidad','1',11.25,10.75,10.2),('740617244106','Memoria USB 8GB Kingston DT106 2.0','Memoria USB 8GB Kingston DT106 2.0',3.16,3.16,0,0,45,'Unidad','1',7.5,7.15,6.8),('740617198218','Memoria USB 8GB Kingston DTSE9 2.0','Memoria USB 8GB Kingston DTSE9 2.0',3.22,3.22,0,0,45,'Unidad','1',7.65,7.2,6.95),('740617226669','Memoria USB 8GB Kingston DTSE3 Amarillo 2.0','Memoria USB 8GB Kingston DTSE3 2.0',3.49,3.49,0,0,45,'Unidad','1',7.9,7.5,7.1),('740617229172','Memoria USB/OTG 8GB Kingston DTMicroDuo 2.0','Memoria USB/OTG 8GB Kingston DTMicroDuo 2.0 BK',3.65,3.65,0,0,45,'Unidad','1',8.25,7.8,7.4),('740617198256','Memoria USB 16GB Kingston DTSE9 Metal 2.0','Memoria USB 16GB Kingston DTSE9 Metal 2.0',5.39,5.39,0,0,45,'Unidad','1',12.15,11.6,10.95),('740617230789','Memoria USB/OTG 16GB Kingston DTMicroDuo 3.0','Memoria USB/OTG 16GB Kingston DTMicroDuo 3.0',9.81,9.81,0,0,45,'Unidad','1',22.15,21.05,19.95),('4713435794197','Memoria USB 8GB Adata UV100 2.0','Memoria USB 8GB Adata UV100 2.0 slim',2.9,2.9,0,0,45,'Unidad','1',6.55,5.9,5.25),('4713435796627','Memoria USB 8GB Adata UV128 3.0','Memoria USB 8GB Adata UV100 3.0',3.25,3.25,0,0,45,'Unidad','1',6.95,6.25,5.85),('4713435796634','Memoria USB 16GB Adata UV128 3.0','Memoria USB 16GB Adata UV128 3.0',4.7,4.7,0,0,45,'Unidad','1',10,9.05,8.5),('091163242826','Touch Pen Genius 80S P/Cell/Tab Gris','Touch Pen Genius 80S P/Cell/Tab Gris',2,2,0,0,59,'Unidad','1',4,3.85,3.6),('091163242734','Touch Pen Genius 80S P/Cell/Tab Black','Touch Pen Genius 80S P/Cell/Tab Black',2,2,0,0,59,'Unidad','1',4,3.85,3.6),('091163241638','Touch Pen Genius 100S P/Cell/Tab Black','Touch Pen Genius 100S P/Cell/Tab Black',2,2,0,0,59,'Unidad','1',4,3.8,3.6),('4710728121265','Ventilador Mini P/Laptop 7\"-10\" Omega usb','Ventilador Mini P/Laptop 7\"-10\" Omega',3,3,0,0,55,'Unidad','1',6.45,6.1,5.75),('025215720727','Bateria Alkaline AA Maxell 1.5V Ud.','Bateria Alkaline AA Maxell 1.5V',0.3,0.3,0,0,58,'Unidad','1',0.65,0.6,0.55),('025215720734','Bateria Alkaline AAA Maxell 1.5V Ud.','Bateria Alkaline AAA Maxell 1.5V Ud.',0.3,0.3,0,0,58,'Unidad','1',0.65,0.6,0.55),('025215723025','Bateria Alkaline D Maxell 1.5V Pak LR20-2BP','Bateria Alkaline D Maxell 1.5V Pak LR20-2BP',2.9,2.9,0,0,58,'Unidad','1',4.6,4.25,3.95),('008562010604','Bateria Recargable Compact AAx2 Sony Ni-MHAA/AAA','Bateria Recargable Compact AAx2 Sony 3x 1000x recargas',11,11,0,0,58,'Unidad','1',21.15,19.85,18.65),('008562005952','Bateria Recargable AA Sony Ni-MHAAA 900Mah','Bateria Recargable AA Sony Ni-MHAAA 900Mah',4.5,4.5,0,0,58,'Unidad','1',10.15,9.65,9.15),('008562007635','Bateria CR2025 Sony 3v','Bateria CR2025 Sony 3v',0.9,0.9,0,0,58,'Unidad','1',2,1.9,1.7),('4891199001123','Bateria CR2016 GP Lithium DL-2016 3v','Bateria CR2016 GP Lithium DL-2016 3v',0.9,0.9,0,0,58,'Unidad','1',2,1.9,1.7),('4710728129612','Candado de Seguridad P/Laptop Omega','Candado de Seguridad P/Laptop Omega 654105',3,3,0,0,62,'Unidad','1',6.5,6.1,5.75),('4969887282977','Candado de Seguridad P/PC Sanwa SL-022K','Candado de Seguridad P/PC Sanwa',4,4,0,0,62,'Unidad','1',8.5,8.15,7.7),('766623317474','Cable Convertidor USB A Paralelo Manhattan 6ft','Cable Convertidor USB A Paralelo Manhattan 6ft 1.8m',9,9,0,0,50,'Unidad','1',15.25,14.25,13.2),('4713621995698','Cable Convertidor USB A Paralelo Agiler Bidireccional','Cable Convertidor USB A Paralelo Agiler Bidireccional 1222',7.95,7.95,0,0,50,'Unidad','1',13.45,12.55,11.65),('4713621125712','Convetidor Bi-Direccional Ide -Sata Agiler','Convertidor Bi-Direccional Ide -Sata Agiler 1160',6.5,6.5,0,0,63,'Unidad','1',10.28,9.55,8.81),('4713621125767','Convertidor SVGA To HDMI+ Audio Agiler 1218','Convertidor SVGA To HDMI+ Audio Agiler 1218',23.45,23.45,0,0,63,'Unidad','1',37.1,34.45,31.8),('766623211062','Tenasa Crimpadora P/RJ45 Intellinet','Tenasa Crimpadora P/RJ45 Intellinet',10.5,10.5,0,0,64,'Unidad','1',16.6,15.45,14.25),('766623211063','Lector de Memorias Todo en 1 Omega USB 2.0','Lector de Memorias Todo en 1 Omega USB 2.0',3.5,3.5,0,0,63,'Unidad','1',5.9,5.5,5.15),('798302169913','Adaptador HDMI Ajustable Xtech- 347 BK','Adaptador HDMI Ajustable Xtech- 347 BK',4,4,0,0,63,'Unidad','1',6.35,5.9,5.4),('798302169890','Convertidor HDMI To VGA Xtech-345','Convertidor HDMI To VGA Xtech-345',10,10,0,0,63,'Unidad','1',15.85,14.7,13.55),('4710728120466','Lector USB 3 Puertos Omega HUB-USB 2.0','Lector USB 3 Puertos Omega HUB-USB 2.0',4,4,0,0,63,'Unidad','1',7.8,7.25,6.75),('051131946507','Kit de Limpieza de Pantalla 3M','Kit de Limpieza de Pantalla 3M',7.23,7.23,0,0,65,'Unidad','1',11.45,10.6,9.8),('4713621225993','Cable HDMI To Mini HDMI 6ft Agiler-1127','Cable HDMI To Mini HDMI 6ft Agiler-1127',5.2,5.2,0,0,50,'Unidad','1',8.25,7.65,7.05),('722868929889','Cargador de Pared P/Iphone 6,5,Air Belkin 10W BK','Cargador de Pared P/Iphone 6,5,Air Belkin 10W 2.1AMP',10.01,10.01,0,0,58,'Unidad','1',15.85,14.7,13.6),('ct170-ufe','Convertidor USB To RJ45 USB 2.0','Convertidor USB To RJ45 USB 2.0 etouch',5.75,5.75,0,0,64,'Unidad','1',10.75,9.75,9.1),('4713621226037','Adaptador Audio 2 Entradas 3.5 mm Agiler-1102','Adaptador Audio 2 Entradas 3.5 mm Agiler-1102',1.4,1.4,0,0,63,'Unidad','1',2.4,2.2,2.05),('860160160217','Cable USB P/Galaxy Tab BK Etouch','Cable USB P/Galaxy Tab Etouch',2.5,2.5,0,0,50,'Unidad','1',4.25,3.95,3.65),('4713621226082','Convertidor HDMI To MHL-TV Agi-1164','Convertidor HDMI To MHL-TV Agi-1164 Blanco',14.5,14.5,0,0,63,'Unidad','1',22.95,21.3,19.66),('790069332760','Tarjeta de Red Inalambrica PCI N150 D-Link DWA-525','Tarjeta de Red Inalambrica PCI N150 D-Link DWA-525',10.05,10.05,0,0,64,'Unidad','1',15.15,17.05,15.9),('798302033917','Tarjeta de Red Inalambrica PCI Expres Ion150 Nexxt','Tarjeta de Red Inalambrica PCI Expres Ion150 Nexxt',8.65,8.65,0,0,64,'Unidad','1',15.65,14.65,13.7),('798305031507','Tarjeta Red Ethernet 10/100/1000Sirius1000 Nexxt','Tarjeta Red Ethernet 10/100/1000Mbps Sirius1000 Nexxt',7.4,7.4,0,0,64,'Unidad','1',13.4,12.5,11.7),('845973001056','Tarjeta Red Ethernet PCI 10/100 TP-LINK TF-3200','Tarjeta Red Ethernet PCI 10/100 MbpsTP-LINK TF-3200',6.5,6.5,0,0,64,'Unidad','1',11,10.25,9.55),('845973001049','Tarjeta Red PCI Expres 10/100/1000 TP-LINK TG-3468','Tarjeta Red PCI Expres 10/100/1000 TP-LINK TG-3468',11.4,11.4,0,0,64,'Unidad','1',19.3,18.05,16.75),('ST1000DM003','Disco Duro Desktop 1TB Seagate SATA','Disco Duro Desktop 1TB Seagate SATA',51.05,51.05,0,0,67,'Unidad','1',98.05,92.3,86.5),('740617241013','Memoria RAM DDR4 4GB Kingston HyperX 2133Mhz','Memoria RAM DDR4 4GB HyperX 2133Mhz',19.64,19.64,0,0,45,'Unidad','1',42.16,37.7,35.5),('740617230451','Memoria RAM DDR3 4GB Kingston HyperX 1600Mhz','Memoria RAM DDR3 4GB Kingston HyperX 1600Mhz',19.26,19.26,0,0,45,'Unidad','1',41.35,39.17,36.95),('OES013872','Tarjeta Puerto USB 3.0 PCI Expres','Tarjeta Puerto USB 3.0 PCI Expres',11.5,11.5,0,0,66,'Unidad','1',19.5,18.2,18.9),('BX80662G4400','Procesador Intel Pentium 2 Core G4400 LGA1151','2 Core G4400 LGA1151 3MB Cache 3.3Ghz',63.48,63.48,0,0,66,'Unidad','1',100.45,93.25,86.1),('824142126356','Tarjeta de Video GT710 MSI 1GB DDR3 PCI-E 2.0','Tarjeta de Video GT710 MSI 1GB DDR3 PCI-Expres 2.0',37.31,37.31,0,0,66,'Unidad','1',63.25,59,54.8),('790069382550','Router Inalambrico D-LINK 3G/DIR-514 N300','Router Inalambrico D-LINK 3G/DIR-514 N300',35,35,0,0,64,'Unidad','1',59.3,55.4,31.4),('588003973113','Antivirus ESET NOD32 Para 3 PCS 1Año','Antivirus ESET NOD32 Para 3 PCS 1Año',40.2,40.2,0,0,68,'Unidad','1',72.65,68.15,63.6),('798302055452','Switch  8 Puertos Nexxt Naxos800 10/100','Switch  8 Puertos Nexxt Naxos800 10/100 ASIDTO84u3',9.05,9.05,0,0,64,'Unidad','1',15.35,14.3,13.3),('4710728127793','Rack Interno P/Disco Duro 2.5&3.5\" Omega','Rack Interno P/Disco Duro 2.5&3.5\" Omega',3,3,0,0,66,'Unidad','1',8,7,6),('845973020293','Switch 16 Puertos TP-LINK 10/100/Mbps TL-SF1016D','16 Puertos TP-LINK 10/100/Mbps TL-SF1016D',20.25,20.25,0,0,64,'Unidad','1',36.6,34.35,32.05),('824142121580','Motherboard MSI H110M PRO-VH LGA 1151 DDR4','MSI H110M PRO-VH LGA 1151 DDR4',62.97,62.97,0,0,66,'Unidad','1',106.75,99.6,92.5),('798302076327','Papel Fotografico KlipXtreme 8.5*11 20PK KPA-540','KlipXtreme 8.5*11 20PK KPA-540 Textura Premiun',6.26,6.26,0,0,60,'Unidad','1',11.3,10.6,9.9),('6935482001372','Papel Fotografico Etouch 8.5*11\" 20Sheets PTC190G','Etouch 8.5*11\" 20Sheets PTC190G Inkjet 190g',2.25,2.25,0,0,60,'Unidad','1',4.35,3.8,3.55),('4710728128394','Fuente de Poder 800w Omega ATX V2.0','Fuente de Poder 800w Omega ATX V2.0',17.5,17.5,0,0,66,'Unidad','1',33.6,31.65,29.65),('790069263729','Switch KVM 4 Puertos 1 Monitor D-LINK DKVM-4K','1 Monitor D-LINK DKVM-4K Multimedia',38,38,0,0,66,'Unidad','1',68.4,60.15,55.8),('606449051278','Router Inalambrico NetGear 4PTS 10/100 WGR614','NetGear 4PTS 10/100 WGR614 300Mps',25,25,0,0,64,'Unidad','1',42.35,39.55,36.7),('836837009349','Disipador de Calor Cooler Master P/AMD','Disipador de Calor Cooler Master P/AMD',1.5,1.5,0,0,55,'Unidad','1',4.25,3.9,3.55),('NK804A-925EA','Disipador de Calor Ever Cool P/AMD','Disipador de Calor Ever Cool P/AMD',1.5,1.5,0,0,55,'Unidad','1',4.25,3.9,3.55),('OES098120','Fuente de Poder 550W Omega ATX','Fuente de Poder 550W Omega ATX550 SATA',11.5,11.5,0,0,66,'Unidad','1',19.5,18.2,16.9),('4713621965622','Fuente de Poder 525W Agiler -PS525','Fuente de Poder 525W Agiler -PS525',11,11,0,0,66,'Unidad','1',18.65,17.4,16.15),('4710728129537','Audifonos Inalambricos 5 en 1 Omega W/FM','Inalambricos 5 en 1 Omega W/FM 30 Mts Distancia',5.95,5.95,0,0,46,'Unidad','1',16.5,15.5,14),('4710728124662','Cable P/Impresor 6ft Generico Omega BK','Cable P/Impresor 6ft Generico Omega BK',1,1,0,0,50,'Unidad','1',1.8,1.7,1.6),('AB190GEN02','Cable Extencion VGA 10ft Xtech BK','Cable Extencion VGA 10ft Xtech BK',4,4,0,0,50,'Unidad','1',7.25,6.8,6.3),('6906912684007','Pasta Termica P/Procesador 2grs Etouch Heringa','P/Procesador 2grs Etouch Heringa ST-360J',0.5,0.5,0,0,55,'Unidad','1',1.5,1.35,1.25),('886540002724','Enclousure P/Disco Duro 2.5 Sata Argom AC-1030','Enclousure P/Disco Duro 2.5 Argom Laptop',5.2,5.2,0,0,66,'Unidad','1',9.4,8.8,8.2),('010343888272','Refil Epson T673220 Azul','Refil Epson T673220 Azul c13t67322a',7.6,7.6,0,0,51,'Unidad','1',12.85,12.05,11.15),('010343888289','Refil Epson T673320 Roja','Refil Epson T673320 Roja C13T67332A',7.63,7.63,0,0,51,'Unidad','1',12.95,12.1,11.2),('4971850169284','Calculadora Casio HL-820LV-BK','Calculadora Casio HL-820LV-BK 8 Digitos',2.5,2.5,0,0,69,'Unidad','1',4.8,4.5,4.25),('4971850091530','Calculadora Casio HL-820VA','Calculadora Casio HL-820VA 8 Digitos',2.5,2.5,0,0,69,'Unidad','1',4.8,4.5,4.25),('4971850137931','Calculadora Cientifica Casio Fx-82MS','Calculadora Cientifica Casio Fx-82MS 240Funciones',8,8,0,0,69,'Unidad','1',12.65,11.75,10.85),('4971850093084','Calculadora Display Casio MW-8V-BK','Calculadora Display Casio MW-8V-BK',4.5,4.5,0,0,69,'Unidad','1',7.2,6.7,6.15),('6935482001358','Papel Fotografico Etouch 4*6\" 20Sheets Premium','Etouch 4*6\" 20Sheets Premium 190g',1.5,1.5,0,0,60,'Unidad','1',3.5,3,2.85),('025215298011','Cassette MiniDV 60Min Maxell','Cassette MiniDV 60Min Maxell',2.5,2.5,0,0,67,'Unidad','1',4.25,3.95,3.65),('025215669477','DVD-RW Camcorder 30Min/1.4GB Maxell','DVD-RW Camcorder 30Min/1.4GB Maxell',1.25,1.25,0,0,67,'Unidad','1',2.95,2.65,2.5),('025215669422','DVD-R Camcorder 30Min/1.4GB Maxell','DVD-R Camcorder 30Min/1.4GB Maxell',0.65,0.65,0,0,67,'Unidad','1',1.5,1.35,1.15),('CD-CASE','Cajas Plasticas P/CD Negra','Cajas Plasticas P/CD Negra',0.095,0.095,0,0,67,'Unidad','1',0.2,0.15,0.15),('4710728121272','Cargador Universal P/Laptop Omega 90W','Cargador Universal P/Laptop Omega 90W 10tipos',23,23,0,0,58,'Unidad','1',38.95,36.35,33.8),('097855104847','Bocina Bloetooth Logitech x100 Orange','Bocina Inalambrica Bloetooth Logitech x100',27.44,27.44,0,0,70,'Unidad','1',43.41,40.31,37.21),('097855104854','Bocina  Bloetooth Logitech x100 Red','Bocina  Bloetooth Logitech x100 Red 8463',27.44,27.44,0,0,70,'Unidad','1',43.41,40.31,37.21),('091163234760','Bocina Mini Portable Genius SP-i170 BK','Bocina Mini Portable Genius SP-i170 BK',9,9,0,0,70,'Unidad','1',14.25,13.22,12.2),('091163239611','Bocina Mini Portable Genius SP-i165 Blanca','Bocina Mini Portable Genius SP-i165 Blanca',9,9,0,0,70,'Unidad','1',14.25,13.22,12.2),('8692202010011','Bocina Bloetooth Mini Music Rosa','Bocina Bloetooth Mini Music Rosa',6.19,6.19,0,0,70,'Unidad','1',12,11.15,10.5),('025215648762','CD-R 100mb 80min 48x Maxell','CD-R 100mb 80min Maxell  Datos,Fotos,Musica',0.1375,0.1375,0,0,67,'Unidad','1',0.25,0.2,0.19),('025215638763','DVD-R 4.7GB 120Min 16x Maxell','DVD-R 4.7GB 120Min Maxell Datos,Video,Music',0.24,0.24,0,0,67,'Unidad','1',0.38,0.35,0.33),('025215639760','DVD+R 4.7GB 120min 16x Maxell','DVD+R 4.7GB 120min 16x Maxell',0.26,0.26,0,0,67,'Unidad','1',0.4,0.38,0.35),('034707057128','DVD+R 8.5GB Doble Capa 240min Memorex 8x','DVD+R 8.5GB Doble Capa 240min Memorex 8x',1,1,0,0,67,'Unidad','1',1.9,1.8,1.7),('021200103841','Espuma Limpiador de Superficies 3M 15oz(425g)','Espuma Limpiador de Superficies 3M 15oz(425g)',4.23,4.23,0,0,65,'Unidad','1',9.05,8.6,8.15),('054007428183','Limpiador de Contactos 3M 10.5oz (297g)','Limpiador de Contactos 3M 10.5oz (297g) 16-102',7.35,7.35,0,0,65,'Unidad','1',12.45,11.6,10.8),('811176003005','Aire Comprimido Sabo Duster','Aire Comprimido Sabo Duster',6.5,6.5,0,0,65,'Unidad','1',11,10.3,9.55),('6935482012279','Bote de Tinta Universal 500ML Etouch Roja','Bote de Tinta Universal 500ML Etouch Roja',3.35,3.35,0,0,51,'Unidad','1',7.5,7.2,6.8),('6935482012262','Bote de Tinta Universal 500ML Etouch Azul','Bote de Tinta Universal 500ML Etouch Azul',3.35,3.35,0,0,51,'Unidad','1',7.5,7.2,6.8),('6935482012286','Bote de Tinta Universal 500Ml Etouch Amarillo','Bote de Tinta Universal 500Ml Etouch Amarillo',3.35,3.35,0,0,51,'Unidad','1',7.5,7.2,6.8),('TBKE','Bote de Tinta Universal Etouch Black','Bote de Tinta Universal Etouch Black',3.35,3.35,0,0,51,'Unidad','1',7.5,7.2,6.8),('085854223546','Funda P/Camara Case Logic Blue','Funda P/Camara Case Logic Blue',3.15,3.15,0,0,56,'Unidad','1',6.75,6.05,5.35),('085854223553','Funda P/Camara Case Logic Green','Funda P/Camara Case Logic Green',3.15,3.15,0,0,56,'Unidad','1',6.5,6.05,5.35),('085854223256','Porta CC/DVD Case Logic 136 Unidades BK','Porta CC/DVD Case Logic 136 Unidades BK',5.5,5.5,0,0,56,'Unidad','1',11.8,10.55,9.3),('798302060197','Porta CD/DVD Klip Xtreme 40 Unidades KWC-40 BK','Klip Xtreme 40 Unidades KWC-40 BK',5.38,5.38,0,0,56,'Unidad','1',9.75,9.1,8.5),('091163240693','Camara Web VGA FaceCam 321 Genius 8MP','Camara Web VGA FaceCam 321 Genius 8MP',6,6,0,0,71,'Unidad','1',13.5,12.8,12.2),('091163239840','Camara Web VGA FaceCam 320 Genius','Camara Web VGA FaceCam 320 Genius',3,3,0,0,71,'Unidad','1',7.15,6.75,6.1),('4710728127182','Camara Web 5.0MP Omega','Camara Web 5.0MP Omega',3,3,0,0,71,'Unidad','1',6.4,6.1,5.75),('4710728129384','Camara Web 8.0 MP Omega','Camara Web 8.0 MP Omega',4.5,4.5,0,0,71,'Unidad','1',11.15,10.15,8.65),('010343852624','Cinta Epson ERC-31B','TM-U950/925/TM-H5000/II/H5200 M-930',1.07,1.07,0,0,72,'Unidad','1',4.25,3.75,3.5),('1957359962239','Teatro en Casa SoundPro Imexx 2.1 x19 Ime-32195','Salida 38W, Bajas 14w, 1Subwofer 2 Parlantes, Control',32.5,32.5,0,0,70,'Unidad','1',58.75,55.05,51.4),('858277000243','Regulador de Voltaje 720W CDP AVR604','4 conectores 4 Pts USB',12.13,12.13,0,0,73,'Unidad','1',20.56,19.2,17.8),('798302100374','Bateria UPS 750VA Forza NT-761','4 Conectores 375W 120Voltios 18Min',32.03,32.03,0,0,73,'Unidad','1',65.14,57.91,54.29),('798302104860','Bateria UPS 500VA Forza NT-501','4 Conectores 250W 120Voltios 12min',28.72,28.72,0,0,73,'Unidad','1',48.7,45.43,42.18),('CS706XTK02','Case 4 en 1 Kit Xtech (Case,Fuernte,Tecl,Mouse,Spk)','(Case,Fuernte,Tecl,Mouse,Speaker)',29.38,29.38,0,0,66,'Unidad','1',49.8,46.5,43.15),('6953337600433','Ventilador P/Laptop 15\" CoolCold','Ventilador P/Laptop 15\" CoolCold Chino',10.5,10.5,0,0,55,'Unidad','1',17.75,16.6,15.4),('013803268515','Impresor Multifuncion Canon Pixma MG2510 BK','Cartucho 145-146',23,23,0,0,74,'Unidad','1',38.98,36.38,33.75),('013803256314','Impresor Multifuncion Canon Pixma MG3610 Blanco','CArtucho 140-141',39,39,0,0,74,'Unidad','1',70.05,66.1,61.7),('010343918252','Impresos Multifuncion Epson L220','Sistema Inyeccion Continuo',179,179,0,0,74,'Unidad','1',245,245,245),('091163234791','Parlante Genius SW-G2.1 1250','RMS:38W 4Piezas',41,41,0,0,70,'Unidad','1',69.5,64.86,60.2),('886540002205','Soporte para Tv 32\"-55\" Brazo Articulado Argom','Tv 32\"-55\" Brazo Articulado Argom AGR-BR-1446',22.99,22.99,0,0,75,'Unidad','1',38.95,36.35,33.75),('798302055148','Sistema de VideoVigilancia 4Canales Nexxt','Xpy40002-KX No incluye Idsco Duro',137,137,0,0,76,'Unidad','1',216.75,201.25,185.77),('685417703487','Monitor AOC 20\" Led I2080SW','Monitor AOC 20\" Led I2080SW',77.27,77.27,0,0,61,'Unidad','1',122.25,113.5,113.5);
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proveedor` (
  `codproveedor` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(250) DEFAULT NULL,
  `nit` varchar(250) DEFAULT NULL,
  `nrc` varchar(250) DEFAULT NULL,
  `giro` varchar(250) DEFAULT NULL,
  `direccion` varchar(250) DEFAULT NULL,
  `telefono` varchar(250) DEFAULT NULL,
  `fax` varchar(250) DEFAULT NULL,
  `e_mail` varchar(250) DEFAULT NULL,
  `estado` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`codproveedor`)
) ENGINE=MyISAM AUTO_INCREMENT=59 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor` VALUES (52,'Omega Technology De El Salvador S.A de C.V','0614-220205-103-1','163527-2','Venta de equipo tencologico','Alameda Roosevelt y 53 av. Nte. Edif. Omega, San Salvador San Salvador San Salvador','2260-0022','080-51-00227-29  Davivienda','','Activo'),(53,'INTCOMEX  S.A de C.V','0813-020300-10-0','119901-1','Venta de computadoras y equipo de computacion','CAlle y col. la mascota n. 517-519 San Salvador San Salvador','25553000','00194-000010-7 BA','','Activo'),(54,'RAF, S.A. DE C.V.','0210-260371-001-6','3-5','Vta de computadora, equipo periferico y programas informaticos','Edif. Raf. km. 8 carr. a sta. Tecla, ant. Cuscatlan. Santa Tecla La Libertad','2213-3333','00549-019011-8','','Activo'),(55,'SuperSonidos El Salvador, S.A. de C.V','9483-190698-101-4','107551-9','Venta de otros productos no clasificados previamente','Carret. Oeste Panamericana, km.20 Complejo OfibodegasNejapa #19 Nejapa San Salvador','2201-8900','00542-009556-4','','Activo'),(56,'COMPUACCESORIOS, S.A. DE C.V.','0614-110701-102-6','134051-6','Venta de maquinaria y equipo de oficina, computadores y sus componentes','Av. Olimpica y 57 Av. Sur  #2 col. Flor Blanca, San Salvador San Salvador','2296-9700 / 2245-4400','','','Activo'),(57,'Tecno Avance, S.A. de C.V','0614-050689-102-5','3946-2','Venta de maquinaria y equipo de oficina, computadores y sus componentes, incluye softwares','Calle lorena 122 y 138, Colonia Roma San Salvador San Salvador','2528-6800','','Ventas@tecnoavance.com','Activo'),(58,'Roxana Lopez','0108-270383-102-0','218741-0','Vta de Computadoras','Cara Sucia San Francisco Menéndez Ahuachapán','V1','','','Activo');
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `respaldos`
--

DROP TABLE IF EXISTS `respaldos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `respaldos` (
  `idrespaldo` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` varchar(200) DEFAULT NULL,
  `nombrearchivo` varchar(150) DEFAULT NULL,
  `automatico` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`idrespaldo`)
) ENGINE=MyISAM AUTO_INCREMENT=33 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `respaldos`
--

LOCK TABLES `respaldos` WRITE;
/*!40000 ALTER TABLE `respaldos` DISABLE KEYS */;
INSERT INTO `respaldos` VALUES (6,'30/06/2016 10:07:26 a.m.','Respaldo6','false'),(7,'30/06/2016 10:08:11 a.m.','Respaldo7','false'),(8,'30/06/2016 10:08:34 a.m.','Respaldo8',' '),(9,'30/06/2016 10:10:40 a.m.','Respaldo9',' '),(10,'30/06/2016 10:11:02 a.m.','Respaldo10',' '),(11,'30/06/2016 10:26:14 a.m.','Respaldo11',' '),(12,'30/06/2016 10:29:49 a.m.','Respaldo12',' '),(13,'30/06/2016 10:33:32 a.m.','Respaldo13',' '),(14,'30/06/2016 10:35:55 a.m.','Respaldo14',' '),(15,'30/06/2016 10:37:27 a.m.','Respaldo15',' '),(16,'30/06/2016 10:44:27 a.m.','Respaldo16',' '),(17,'30/06/2016 10:48:45 a.m.','Respaldo17',' '),(18,'30/06/2016 10:49:17 a.m.','Respaldo18',' '),(19,'30/06/2016 10:49:43 a.m.','Respaldo19',' '),(20,'30/06/2016 10:51:03 a.m.','Respaldo20',' '),(21,'30/06/2016 10:51:51 a.m.','Respaldo21',' '),(22,'30/06/2016 04:01:01 p.m.','Respaldo22',' '),(23,'01/07/2016 08:39:04 a.m.','Respaldo23',' '),(24,'01/07/2016 08:55:47 a.m.','Respaldo24',' '),(25,'01/07/2016 08:57:48 a.m.','Respaldo25',' '),(26,'01/07/2016 09:03:30 a.m.','Respaldo26',' '),(27,'01/07/2016 09:05:04 a.m.','Respaldo27',' '),(28,'01/07/2016 09:06:38 a.m.','Respaldo28',' '),(29,'01/07/2016 09:44:19 a.m.','Respaldo29',' '),(30,'01/07/2016 09:48:37 a.m.','Respaldo30',' '),(31,'01/07/2016 01:04:46 p.m.','Respaldo31',' '),(32,'05/07/2016 11:37:18 a.m.','Respaldo32',' ');
/*!40000 ALTER TABLE `respaldos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tirajes`
--

DROP TABLE IF EXISTS `tirajes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tirajes` (
  `idtiraje` int(11) NOT NULL,
  `tirajefs` varchar(50) DEFAULT NULL,
  `tirajefd` varchar(50) DEFAULT NULL,
  `tirajefh` varchar(50) DEFAULT NULL,
  `tirajefa` varchar(50) DEFAULT NULL,
  `tirajecs` varchar(50) DEFAULT NULL,
  `tirajecd` varchar(50) DEFAULT NULL,
  `tirajech` varchar(50) DEFAULT NULL,
  `tirajeca` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idtiraje`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tirajes`
--

LOCK TABLES `tirajes` WRITE;
/*!40000 ALTER TABLE `tirajes` DISABLE KEYS */;
INSERT INTO `tirajes` VALUES (1,'16AN000F','1','150','115',' 15HC001C','1','100','1324');
/*!40000 ALTER TABLE `tirajes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usr`
--

DROP TABLE IF EXISTS `usr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usr` (
  `IdUsr` char(15) NOT NULL,
  `cNom` varchar(20) DEFAULT NULL,
  `cApe` varchar(20) DEFAULT NULL,
  `cClave` varchar(80) DEFAULT NULL,
  `cEstado` varchar(2) DEFAULT NULL,
  PRIMARY KEY (`IdUsr`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usr`
--

LOCK TABLES `usr` WRITE;
/*!40000 ALTER TABLE `usr` DISABLE KEYS */;
INSERT INTO `usr` VALUES ('admin','Usuario','Administrador','dcr1276512','A'),('super','SUPER','SUPER','admin','A'),('usuario1','USUARIO','USUARIO','admin','A');
/*!40000 ALTER TABLE `usr` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-07-05 11:37:25
