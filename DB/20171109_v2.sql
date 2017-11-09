/*
SQLyog Community v12.18 (64 bit)
MySQL - 5.6.21-log : Database - dbreclamos
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`dbreclamos` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `dbreclamos`;

/*Table structure for table `historialreclamos` */

DROP TABLE IF EXISTS `historialreclamos`;

CREATE TABLE `historialreclamos` (
  `idhistorialreclamo` int(11) NOT NULL AUTO_INCREMENT,
  `idreclamo` int(11) DEFAULT NULL,
  `idproblematicareclamo` int(11) DEFAULT NULL,
  `respuesta` varchar(2) DEFAULT NULL,
  `observacion` varchar(100) DEFAULT NULL,
  `accion` varchar(1) DEFAULT NULL,
  `fechaaccion` datetime DEFAULT NULL,
  PRIMARY KEY (`idhistorialreclamo`)
) ENGINE=InnoDB AUTO_INCREMENT=56 DEFAULT CHARSET=utf8;

/*Data for the table `historialreclamos` */

insert  into `historialreclamos`(`idhistorialreclamo`,`idreclamo`,`idproblematicareclamo`,`respuesta`,`observacion`,`accion`,`fechaaccion`) values 
(33,30,5,'NO','de 1 a 2','N','2017-11-08 01:46:13'),
(34,30,12,'SI','de 2 a 3','N','2017-11-08 01:46:13'),
(35,30,6,'SI','de 3 a 4','N','2017-11-08 01:46:13'),
(36,30,7,'NO','de 4 a 5','N','2017-11-08 01:46:13'),
(37,31,5,'NO','prueba 1','B','2017-11-08 01:48:07'),
(38,31,12,'NO','prueba 2','B','2017-11-08 01:48:07'),
(39,31,8,'NO','prueba 3','B','2017-11-08 01:48:07'),
(40,31,9,'NO','prueba 4','B','2017-11-08 01:48:07'),
(41,31,3,'SI','prueba 5','B','2017-11-08 01:48:07'),
(42,31,1,'SI','prueba 6','B','2017-11-08 01:48:07'),
(47,36,5,'NO','f','B','2017-11-08 02:06:20'),
(48,36,12,'NO','fff','B','2017-11-08 02:06:20'),
(49,36,8,'SI','otra','B','2017-11-08 02:06:20'),
(50,36,1,'SI','ok','B','2017-11-08 02:06:20'),
(51,37,5,'NO','sdfsd','N','2017-11-08 02:05:00'),
(52,37,12,'SI','rrr','N','2017-11-08 02:05:18'),
(53,37,6,'NO','rtggv','N','2017-11-08 02:05:29'),
(54,37,8,'SI','ok','N','2017-11-08 02:05:41'),
(55,37,1,'SI','ok','N','2017-11-08 02:05:45');

/*Table structure for table `personas` */

DROP TABLE IF EXISTS `personas`;

CREATE TABLE `personas` (
  `idpersona` int(11) NOT NULL AUTO_INCREMENT,
  `apellido` varchar(30) DEFAULT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  `dni` varchar(30) DEFAULT NULL,
  `tel` varchar(30) DEFAULT NULL,
  `cel` varchar(30) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `calle` varchar(100) DEFAULT NULL,
  `numero` int(11) DEFAULT '0',
  `piso` varchar(10) DEFAULT NULL,
  `dpto` varchar(10) DEFAULT NULL,
  `idtiposervicio` int(11) DEFAULT '1',
  `numreferencia` varchar(30) DEFAULT NULL,
  `observacion` varchar(200) DEFAULT NULL,
  `accion` varchar(1) DEFAULT 'N',
  `fechaaccion` datetime DEFAULT NULL,
  `idtipopersona` int(11) DEFAULT '1',
  `usuario` varchar(30) DEFAULT NULL,
  `contrasenia` varchar(30) DEFAULT NULL,
  `fechaingreso` date DEFAULT NULL,
  `fechaegreso` date DEFAULT NULL,
  PRIMARY KEY (`idpersona`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;

/*Data for the table `personas` */

insert  into `personas`(`idpersona`,`apellido`,`nombre`,`dni`,`tel`,`cel`,`email`,`calle`,`numero`,`piso`,`dpto`,`idtiposervicio`,`numreferencia`,`observacion`,`accion`,`fechaaccion`,`idtipopersona`,`usuario`,`contrasenia`,`fechaingreso`,`fechaegreso`) values 
(1,'Flores','Cesar','.','.','.','.','.',0,'.','.',2,'0','0','N','2017-11-03 11:36:21',2,NULL,NULL,NULL,NULL),
(2,'AAA modi','A modi','1','1234','1','1','1',1,'1','1',4,'1','OBS','B','2017-11-03 02:20:00',2,'1','',NULL,NULL),
(3,'AAA','A','4578','1','1','1','1',1,'1','1',4,'1','1','B','2017-11-03 02:06:30',2,'1','',NULL,NULL),
(4,'OTRO MODI','CESAR','1','1','1','1','1',1,'1','1',2,'1','1','M','2017-11-03 02:05:50',2,'1','',NULL,NULL),
(5,'APE','NOMBRE','1','3','2','EMAIL','CALLE',4,'PISO','DPTO',3,'REFER','OBS','N','2017-11-03 01:41:48',2,'1','',NULL,NULL),
(6,'APE','NOMBRE','1','3','2','EMAIL','CALLE',4,'PISO','DPTO',3,'REFER','OBS','N','2017-11-03 01:41:48',2,'1','',NULL,NULL),
(7,'APE','NOMBRE','1','3','2','EMAIL','CALLE',4,'PISO','DPTO',1,'','OBS','M','2017-11-08 02:14:27',1,'emp','emp','2017-11-03',NULL),
(8,'APE MODIFICADO','NOMBRE 12','12','12','12','EMAIL 12','CALLE 12',12,'PISO','DPTO',1,'','OBS MODIFICADO A1','M','2017-11-03 03:41:33',3,'admin','admin','2017-11-03',NULL),
(9,'tonga','NOMBRE','1','3','2','EMAIL','CALLE',4,'PISO','DPTO',1,'','OBS','B','2017-11-03 03:50:10',3,'1','','2017-11-03','2017-11-03'),
(10,'APE','NOMBRE','1','3','2','EMAIL','CALLE',4,'PISO','DPTO',3,'REFER','OBS','N','2017-11-03 02:19:48',2,'1','',NULL,NULL),
(11,'APE ADM','NOMB ADM','1','1','1','EMAIL ADM','CALLE ADM',1,'1','1',1,'','OBS ADMIN','N','2017-11-03 03:27:38',3,'1','','2017-11-03',NULL),
(12,'APE ADMIN','NOMBRE ADMIN','1','1','1','EMAIL ADM','CALLE ADM',1,'1','1',1,'','OBS ADM','N','2017-11-03 03:34:18',3,'1','','2017-11-03',NULL),
(13,'APE ADMIN','NOMBRE ADMIN','1','1','1','EMAIL ADM','CALLE ADM',1,'1','1',1,'','OBS ADM','N','2017-11-03 03:34:18',3,'1','','2017-11-03',NULL),
(14,'APE ADMIN','NOMBRE ADMIN','1','1','1','EMAIL ADM','CALLE ADM',1,'1','1',1,'','OBS ADM','M','2017-11-08 02:14:02',3,'quien','1234','2017-11-03',NULL),
(15,'APE ADMIN','NOMBRE ADMIN','1','1','1','EMAIL ADM','CALLE ADM',1,'1','1',1,'','OBS ADM','N','2017-11-03 03:34:18',3,'1','','2017-11-03',NULL),
(16,'APE ADMIN','NOMBRE ADMIN','1','1','1','EMAIL ADM','CALLE ADM',1,'1','1',1,'','OBS ADM','M','2017-11-08 02:14:13',3,'otro','otro','2017-11-03',NULL),
(17,'FLO EMP','NOMBRE ADMIN','12','12','12','EMAIL ADM','CALLE ADM',12,'12','12',1,'','OBS ADM','M','2017-11-03 03:40:07',3,'1','','2017-11-03',NULL);

/*Table structure for table `problematicareclamos` */

DROP TABLE IF EXISTS `problematicareclamos`;

CREATE TABLE `problematicareclamos` (
  `idproblematicareclamo` int(11) NOT NULL AUTO_INCREMENT,
  `problematicareclamo` varchar(100) DEFAULT NULL,
  `idtiporeclamo` int(11) DEFAULT NULL,
  `resp_si` int(11) DEFAULT NULL,
  `resp_no` int(11) DEFAULT NULL,
  `orden` int(11) DEFAULT NULL,
  PRIMARY KEY (`idproblematicareclamo`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

/*Data for the table `problematicareclamos` */

insert  into `problematicareclamos`(`idproblematicareclamo`,`problematicareclamo`,`idtiporeclamo`,`resp_si`,`resp_no`,`orden`) values 
(1,'Guardar pasos en bases de datos y mandar Mail a cliente',1,0,0,0),
(2,'Enviar MODEM nuevo a cliente por cambio',2,1,1,NULL),
(3,'Hacer controlar la instalación con un técnico eléctricista',2,1,1,NULL),
(4,'No se soluciona el problema, enviar técnico a domicilio',2,1,1,NULL),
(5,'¿Tiene internet?',2,1,12,1),
(6,'¿La luz de encendido de \"en línea\" esta encendida?',2,7,8,NULL),
(7,'¿Hacer prueba de conectividad y dio todo OK?',2,4,2,NULL),
(8,'¿No enciende MODEM?',2,1,9,NULL),
(9,'¿Está bien la conexión interna de casa \"cableado interno\"?',2,4,3,NULL),
(10,'¿Navega lento?',3,11,1,NULL),
(11,'Tiene de desactivar el antivirus. ¿Desactivo el antivirus?',3,5,1,NULL),
(12,'¿MODEM encendido?',2,6,8,NULL);

/*Table structure for table `reclamos` */

DROP TABLE IF EXISTS `reclamos`;

CREATE TABLE `reclamos` (
  `idreclamo` int(11) NOT NULL AUTO_INCREMENT,
  `fechainicio` datetime DEFAULT NULL,
  `fechafin` datetime DEFAULT NULL,
  `idcliente` int(11) DEFAULT NULL,
  `idempleado` int(11) DEFAULT NULL,
  `idtiporeclamo` int(11) DEFAULT NULL,
  `numeroreferencia` varchar(30) DEFAULT NULL,
  `accion` varchar(1) DEFAULT NULL,
  `fechaaccion` datetime DEFAULT NULL,
  `observacion` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idreclamo`)
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8;

/*Data for the table `reclamos` */

insert  into `reclamos`(`idreclamo`,`fechainicio`,`fechafin`,`idcliente`,`idempleado`,`idtiporeclamo`,`numeroreferencia`,`accion`,`fechaaccion`,`observacion`) values 
(30,'2017-11-07 06:39:09','2017-11-09 02:56:19',1,7,2,'R063856','M','2017-11-09 02:56:19','CIERRE DE CIRCUITO POR CAMBIO DE MODEN A CLIENTE!!!'),
(31,'2017-11-08 01:13:12',NULL,1,7,2,'R011252','B','2017-11-08 01:48:07',NULL),
(36,'2017-11-08 02:01:09',NULL,1,7,2,'R020100','B','2017-11-08 02:06:20',NULL),
(37,'2017-11-08 02:05:00',NULL,1,7,2,'R020451','N','2017-11-08 02:05:00',NULL);

/*Table structure for table `tipopersonas` */

DROP TABLE IF EXISTS `tipopersonas`;

CREATE TABLE `tipopersonas` (
  `idtipopersona` int(11) NOT NULL AUTO_INCREMENT,
  `tipopersona` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`idtipopersona`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

/*Data for the table `tipopersonas` */

insert  into `tipopersonas`(`idtipopersona`,`tipopersona`) values 
(1,'Empleado'),
(2,'Cliente'),
(3,'Administrador');

/*Table structure for table `tiposervicios` */

DROP TABLE IF EXISTS `tiposervicios`;

CREATE TABLE `tiposervicios` (
  `idtiposervicio` int(11) NOT NULL AUTO_INCREMENT,
  `servicio` varchar(30) DEFAULT NULL,
  `costo` decimal(10,0) DEFAULT NULL,
  `accion` varchar(1) DEFAULT NULL,
  `fechaaccion` datetime DEFAULT NULL,
  PRIMARY KEY (`idtiposervicio`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

/*Data for the table `tiposervicios` */

insert  into `tiposervicios`(`idtiposervicio`,`servicio`,`costo`,`accion`,`fechaaccion`) values 
(1,'','0','N','2017-11-03 11:31:06'),
(2,'4 MB','200','N','2017-11-03 11:34:28'),
(3,'6 MB','400','N','2017-11-03 11:34:38'),
(4,'10 MB','500','N','2017-11-03 11:37:14');

/*Table structure for table `tiposreclamos` */

DROP TABLE IF EXISTS `tiposreclamos`;

CREATE TABLE `tiposreclamos` (
  `idtiporeclamo` int(11) NOT NULL AUTO_INCREMENT,
  `tiporeclamo` varchar(30) DEFAULT NULL,
  `accion` varchar(1) DEFAULT NULL,
  `fechaaccion` datetime DEFAULT NULL,
  PRIMARY KEY (`idtiporeclamo`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

/*Data for the table `tiposreclamos` */

insert  into `tiposreclamos`(`idtiporeclamo`,`tiporeclamo`,`accion`,`fechaaccion`) values 
(1,'Fin reclamo','N','2017-11-06 15:45:10'),
(2,'Conexión','N','2017-11-06 15:45:21'),
(3,'Velocidad','N','2017-11-06 15:45:30');

/* Procedure structure for procedure `listarhistorialreclamos` */

/*!50003 DROP PROCEDURE IF EXISTS  `listarhistorialreclamos` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `listarhistorialreclamos`(
IN _numreferencia VARCHAR(30),
IN _pag INT,
IN _cantfil INT
)
BEGIN
	PREPARE STMT FROM " SELECT a.idreclamo,c.tiporeclamo,a.fechainicio,a.fechafin,b.idhistorialreclamo,b.idproblematicareclamo,d.problematicareclamo,b.respuesta,b.observacion,c.idtiporeclamo,a.observacion
			    FROM reclamos a INNER JOIN historialreclamos b ON (a.idreclamo=b.idreclamo AND b.accion!='B') 
				   	    INNER JOIN tiposreclamos c ON (c.idtiporeclamo=a.idtiporeclamo AND c.accion!='B')
				   	    LEFT JOIN problematicareclamos d ON (d.idproblematicareclamo=b.idproblematicareclamo)
			    WHERE (a.accion!='B') AND (a.numeroreferencia=?)
			    ORDER BY b.fechaaccion
			    LIMIT ?,?";
	SET @numreferencia = _numreferencia; 
	SET @pag = _pag; 
	SET @cantfil = _cantfil; 
	EXECUTE STMT USING @numreferencia,@pag,@cantfil;
	DEALLOCATE PREPARE STMT;
END */$$
DELIMITER ;

/* Procedure structure for procedure `listarnumreferenciasdereclamos` */

/*!50003 DROP PROCEDURE IF EXISTS  `listarnumreferenciasdereclamos` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `listarnumreferenciasdereclamos`(
in _idcliente int,
IN _pag INT,
IN _cantfil INT
)
BEGIN
		PREPARE STMT FROM " SELECT idreclamo,numeroreferencia 
					FROM reclamos 
				WHERE (accion!='B') AND (idcliente=?)
				GROUP BY idreclamo,numeroreferencia 
				ORDER BY fechaaccion
				    LIMIT ?,?";
		SET @idcliente = _idcliente; 
		SET @pag = _pag; 
		SET @cantfil = _cantfil; 
		EXECUTE STMT USING @idcliente,@pag,@cantfil;
		DEALLOCATE PREPARE STMT;
END */$$
DELIMITER ;

/* Procedure structure for procedure `listarreclamosporeferencia` */

/*!50003 DROP PROCEDURE IF EXISTS  `listarreclamosporeferencia` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `listarreclamosporeferencia`(
IN _numreferencia varchar(30),
IN _pag INT,
IN _cantfil INT
)
BEGIN
	PREPARE STMT FROM " SELECT a.idreclamo,a.fechainicio,a.fechafin,a.numeroreferencia,CONCAT(c.apellido,', ',c.nombre) AS Clientes,b.tiporeclamo,a.observacion
			    FROM reclamos a INNER JOIN tiposreclamos b ON (b.idtiporeclamo=a.idtiporeclamo AND b.accion!='B')
					    INNER JOIN personas c ON (a.idcliente=c.idpersona)
			    WHERE (a.accion!='B') AND (a.numeroreferencia=?)
			    ORDER BY a.fechainicio
			    LIMIT ?,?";
	SET @numreferencia = _numreferencia; 
	SET @pag = _pag; 
	SET @cantfil = _cantfil; 
	EXECUTE STMT USING @numreferencia,@pag,@cantfil;
	DEALLOCATE PREPARE STMT;
END */$$
DELIMITER ;

/* Procedure structure for procedure `listarreclamosporempleados` */

/*!50003 DROP PROCEDURE IF EXISTS  `listarreclamosporempleados` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `listarreclamosporempleados`(
IN _idempleado int,
IN _pag INT,
IN _cantfil INT
)
BEGIN
	PREPARE STMT FROM " SELECT a.idreclamo,a.fechainicio,a.fechafin,a.numeroreferencia,CONCAT(c.apellido,', ',c.nombre) AS Clientes,b.tiporeclamo,a.observacion
			    FROM reclamos a INNER JOIN tiposreclamos b ON (b.idtiporeclamo=a.idtiporeclamo AND b.accion!='B')
					    INNER JOIN personas c ON (a.idcliente=c.idpersona)
			    WHERE (a.accion!='B') AND (a.idempleado=?)
			    ORDER BY a.fechainicio
			    LIMIT ?,?";
	SET @idempleado = _idempleado; 
	SET @pag = _pag; 
	SET @cantfil = _cantfil; 
	EXECUTE STMT USING @idempleado,@pag,@cantfil;
	DEALLOCATE PREPARE STMT;
END */$$
DELIMITER ;

/* Procedure structure for procedure `listartiposervicios` */

/*!50003 DROP PROCEDURE IF EXISTS  `listartiposervicios` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `listartiposervicios`(
IN _tiposervicio VARCHAR(50),
IN _pag INT,
IN _cantfil INT
)
BEGIN
	IF (_tiposervicio IS NULL) THEN
		SELECT * FROM tiposervicios;
	ELSE
		PREPARE STMT FROM " SELECT * 
				    FROM tiposervicios 
			            WHERE (accion!='B') AND (servicio LIKE CONCAT(? ,'%'))
				    LIMIT ?,?";
		SET @servicio = _tiposervicio; 
		SET @pag = _pag; 
		SET @cantfil = _cantfil; 
		EXECUTE STMT USING @servicio,@pag,@cantfil;
		DEALLOCATE PREPARE STMT;
	END IF;
END */$$
DELIMITER ;

/* Procedure structure for procedure `listartiposreclamos` */

/*!50003 DROP PROCEDURE IF EXISTS  `listartiposreclamos` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `listartiposreclamos`(
IN _tiporeclamo VARCHAR(50),
IN _pag INT,
IN _cantfil INT
)
BEGIN
	IF (_tiporeclamo is null) THEN
		SELECT * 
		FROM tiposreclamos 
		WHERE (accion!='B') AND (idtiporeclamo!=1);
	ELSE
		PREPARE STMT FROM " SELECT * 
				    FROM tiposreclamos 
			            WHERE (accion!='B') AND (idtiporeclamo!=1) AND (tiporeclamo LIKE CONCAT(? ,'%'))
				    LIMIT ?,?";
		SET @tiporeclamo = _tiporeclamo; 
		SET @pag = _pag; 
		SET @cantfil = _cantfil; 
		EXECUTE STMT USING @tiporeclamo,@pag,@cantfil;
		DEALLOCATE PREPARE STMT;
	END IF;
END */$$
DELIMITER ;

/* Procedure structure for procedure `siguienteconsulta` */

/*!50003 DROP PROCEDURE IF EXISTS  `siguienteconsulta` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `siguienteconsulta`(
IN _idtiporeclamo int,
in _idproblematica int,
IN _respuesta VARCHAR(50),
IN _pag INT,
IN _cantfil INT
)
BEGIN
DECLARE _id INT;
	
	IF (_idproblematica>0) THEN
		IF (_respuesta!='SI') THEN
			SELECT resp_no INTO _id FROM problematicareclamos WHERE idproblematicareclamo=_idproblematica;
		ELSE
			SELECT resp_si INTO _id FROM problematicareclamos WHERE idproblematicareclamo=_idproblematica;
		END IF;
	
		PREPARE STMT FROM " SELECT idproblematicareclamo,problematicareclamo,resp_si,resp_no 
				    FROM problematicareclamos 
			            WHERE (idproblematicareclamo=?)
				    LIMIT ?,?";
		SET @idproblematicareclamo = _id; 
		SET @pag = _pag; 
		SET @cantfil = _cantfil; 
		EXECUTE STMT USING @idproblematicareclamo,@pag,@cantfil;
		DEALLOCATE PREPARE STMT;
	ELSE
		PREPARE STMT FROM " SELECT idproblematicareclamo,problematicareclamo,resp_si,resp_no 
				    FROM problematicareclamos 
			            WHERE (idtiporeclamo=?) AND (orden=1)
				    LIMIT ?,?";
		SET @idtiporeclamo = _idtiporeclamo; 
		SET @pag = _pag; 
		SET @cantfil = _cantfil; 
		EXECUTE STMT USING @idtiporeclamo,@pag,@cantfil;
		DEALLOCATE PREPARE STMT;
	END IF;
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_abmpersona` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_abmpersona` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_abmpersona`(
    IN _idpersona int,
    IN _apellido VARCHAR(30),
    IN _nombre VARCHAR(30),
    IN _dni VARCHAR(30),
    IN _cel VARCHAR(30),
    IN _tel VARCHAR(30),
    IN _email VARCHAR(100),
    IN _calle VARCHAR(100),
    IN _numero int,
    IN _piso VARCHAR(10),
    IN _dpto VARCHAR(10),
    IN _idtiposervicio int,
    IN _numreferencia VARCHAR(30),
    IN _observacion VARCHAR(200),
     IN _usu VARCHAR(30),
    IN _pass VARCHAR(30),
    
    IN _idtipopersona INT,
    IN _accion varCHAR(1),
    IN _fechaaccion datetime
    )
BEGIN
case _accion 
when 'N' then
	INSERT INTO personas (apellido,nombre,dni,cel,tel,email,calle,numero,piso,dpto,idtiposervicio,numreferencia,observacion,idtipopersona,accion,fechaaccion,usuario,contrasenia,fechaingreso) 
	VALUE (_apellido,_nombre,_dni,_cel,_tel,_email,_calle,_numero,_piso,_dpto,_idtiposervicio,_numreferencia,_observacion,_idtipopersona,_accion,_fechaaccion,_usu,_pass,_fechaaccion);
when 'M' then		
	update personas set apellido=_apellido,nombre=_nombre,dni=_dni,cel=_cel,tel=_tel,email=_email,calle=_calle,numero=_numero,piso=_piso,dpto=_dpto,idtiposervicio=_idtiposervicio,numreferencia=_numreferencia,observacion=_observacion,usuario=_usu,contrasenia=_pass,accion=_accion,fechaaccion=_fechaaccion,idtipopersona=_idtipopersona
	where idpersona=_idpersona;
WHEN 'B' THEN		
	UPDATE personas SET accion=_accion,fechaaccion=_fechaaccion,fechaegreso=_fechaaccion
	WHERE idpersona=_idpersona;
end case;
IF _idtipopersona!=2 THEN 
	CALL sp_buscadorempleados(0,'','',_dni,_idtipopersona,'',0,100);
ELSE		
	CALL sp_buscadorclientes('','','',_dni,'',0,100);
END IF;
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_abmreclamos` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_abmreclamos` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_abmreclamos`(
    IN _idreclamo int,
    IN _idproblematica INT,
    IN _fechaini datetime,
    IN _fechafin DATETIME,
    IN _idcliente INT,
    IN _idempleado INT,
    IN _idtiporeclamo INT,
    IN _numreferencia VARCHAR(10),
    IN _respuesta VARCHAR(2),
    IN _observacion VARCHAR(100),
    
    IN _accion varCHAR(1),
    IN _fechaaccion datetime
    )
BEGIN
case _accion 
when 'N' then
	if (_idreclamo<=0) then
		INSERT INTO reclamos (fechainicio,idcliente,idempleado,idtiporeclamo,numeroreferencia,accion,fechaaccion) 
		VALUE (_fechaini,_idcliente,_idempleado,_idtiporeclamo,_numreferencia,_accion,_fechaaccion);
	end if;
	SELECT idreclamo into _idreclamo FROM reclamos WHERE numeroreferencia=_numreferencia AND idcliente=_idcliente;
	INSERT INTO historialreclamos (idreclamo,idproblematicareclamo,respuesta,observacion,accion,fechaaccion) 
	VALUE (_idreclamo,_idproblematica,_respuesta,_observacion,_accion,_fechaaccion);	
WHEN 'B' THEN		
	UPDATE reclamos SET accion=_accion,fechaaccion=_fechaaccion
	WHERE idreclamo=_idreclamo;
	
	UPDATE historialreclamos SET accion=_accion,fechaaccion=_fechaaccion
	WHERE idreclamo=_idreclamo;
end case;
CALL siguienteconsulta(_idtiporeclamo,_idproblematica,_respuesta,0,100);
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_buscadorclientes` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_buscadorclientes` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_buscadorclientes`(
    IN _idcliente varchar(11),
    IN _apellido VARCHAR(30),
    IN _nombre VARCHAR(30),
    IN _dni VARCHAR(50),
    IN _accion VARCHAR(1),
    IN _pag INT,
    IN _cantfil INT
    )
BEGIN
if (_idcliente<=0) then
	if _accion = 'B' THEN
		IF _idcliente>0 THEN
			PREPARE STMT FROM "SELECT a.idpersona,CONCAT(a.apellido,', ', a.nombre) AS Nombre,b.servicio AS Servicio
						   FROM personas a INNER JOIN tiposervicios b ON (b.idtiposervicio=a.idtiposervicio)
						   WHERE (a.idtipopersona=2) AND
							 (a.idpersona=?) AND
							 (a.apellido LIKE CONCAT(? ,'%')) AND 
							 (a.nombre LIKE CONCAT(? ,'%')) AND 
							 (a.dni LIKE CONCAT(? ,'%')) AND
							 (a.accion='B')
						   ORDER BY a.apellido,a.nombre
						   LIMIT ?,?";
						   
			SET @idpersona = _idcliente; 
			SET @apellido = _apellido; 
			SET @nombre = _nombre; 
			SET @dni = _dni; 
			SET @pag = _pag; 
			SET @cantfil = _cantfil; 
			EXECUTE STMT USING @idpersona,@apellido,@nombre,@dni,@pag,@cantfil;
			DEALLOCATE PREPARE STMT;
		ELSE
			PREPARE STMT FROM "SELECT a.idpersona,CONCAT(a.apellido,', ', a.nombre) AS Nombre,b.servicio AS Servicio
						   FROM personas a INNER JOIN tiposervicios b ON (b.idtiposervicio=a.idtiposervicio)
						   WHERE (a.idtipopersona=2) AND
							 (a.apellido LIKE CONCAT(? ,'%')) AND 
							 (a.nombre LIKE CONCAT(? ,'%')) AND 
							 (a.dni LIKE CONCAT(? ,'%')) AND
							 (a.accion='B')
						   ORDER BY a.apellido,a.nombre
						   LIMIT ?,?";
						   
			SET @apellido = _apellido; 
			SET @nombre = _nombre; 
			SET @dni = _dni; 
			SET @pag = _pag; 
			SET @cantfil = _cantfil; 
			EXECUTE STMT USING @apellido,@nombre,@dni,@pag,@cantfil;
			DEALLOCATE PREPARE STMT;
		END IF;
	else
		IF _idcliente>0 THEN
			PREPARE STMT FROM "SELECT a.idpersona,CONCAT(a.apellido,', ', a.nombre) AS Nombre,b.servicio AS Servicio
						   FROM personas a INNER JOIN tiposervicios b ON (b.idtiposervicio=a.idtiposervicio)
						   WHERE (a.idtipopersona=2) AND
							 (a.idpersona=?) AND
							 (a.apellido LIKE CONCAT(? ,'%')) AND 
							 (a.nombre LIKE CONCAT(? ,'%')) AND 
							 (a.dni LIKE CONCAT(? ,'%')) AND
							 (a.accion!='B')
						   ORDER BY a.apellido,a.nombre
						   LIMIT ?,?";
						   
			SET @idpersona = _idcliente; 
			SET @apellido = _apellido; 
			SET @nombre = _nombre; 
			SET @dni = _dni; 
			SET @pag = _pag; 
			SET @cantfil = _cantfil; 
			EXECUTE STMT USING @idpersona,@apellido,@nombre,@dni,@pag,@cantfil;
			DEALLOCATE PREPARE STMT;
		ELSE
			PREPARE STMT FROM "SELECT a.idpersona,CONCAT(a.apellido,', ', a.nombre) AS Nombre,b.servicio AS Servicio
						   FROM personas a INNER JOIN tiposervicios b ON (b.idtiposervicio=a.idtiposervicio)
						   WHERE (a.idtipopersona=2) AND
							 (a.apellido LIKE CONCAT(? ,'%')) AND 
							 (a.nombre LIKE CONCAT(? ,'%')) AND 
							 (a.dni LIKE CONCAT(? ,'%')) AND
							 (a.accion!='B')
						   ORDER BY a.apellido,a.nombre
						   LIMIT ?,?";
						   
			SET @apellido = _apellido; 
			SET @nombre = _nombre; 
			SET @dni = _dni; 
			SET @pag = _pag; 
			SET @cantfil = _cantfil; 
			EXECUTE STMT USING @apellido,@nombre,@dni,@pag,@cantfil;
			DEALLOCATE PREPARE STMT;
		END IF;
	END IF;
	
		
else			
	PREPARE STMT FROM "SELECT a.apellido,a.nombre,a.dni,a.cel,a.tel,a.email,a.calle,a.numero,a.piso,a.dpto,b.servicio,a.numreferencia,a.observacion
				   FROM personas a INNER JOIN tiposervicios b ON (a.idtiposervicio=b.idtiposervicio)
				   WHERE (a.idpersona LIKE CONCAT(? ,'%'))";
		
		SET @idpersona = _idcliente; 
		EXECUTE STMT USING @idpersona;
		DEALLOCATE PREPARE STMT;
end if;
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_buscadorempleados` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_buscadorempleados` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_buscadorempleados`(
    IN _idempleado int,
    IN _apellido VARCHAR(30),
    IN _nombre VARCHAR(30),
    IN _dni VARCHAR(50),
    IN _idtipopersona int,
    IN _accion VARCHAR(1),
    IN _pag INT,
    IN _cantfil INT
    )
BEGIN
IF (_idempleado<=0) THEN
	IF _accion = 'B' THEN
		IF _idtipopersona>0 THEN
			PREPARE STMT FROM "SELECT a.idpersona,CONCAT(a.apellido,', ', a.nombre) AS Nombre,b.tipopersona AS TipoPersona
						   FROM personas a INNER JOIN tipopersonas b ON (b.idtipopersona=a.idtipopersona)
						   WHERE (a.idtipopersona=?) AND
							 (a.apellido LIKE CONCAT(? ,'%')) AND 
							 (a.nombre LIKE CONCAT(? ,'%')) AND 
							 (a.dni LIKE CONCAT(? ,'%')) AND
							 (a.accion='B')
						   ORDER BY a.apellido,a.nombre
						   LIMIT ?,?";
						   
			SET @idtipopersona = _idtipopersona; 
			SET @apellido = _apellido; 
			SET @nombre = _nombre; 
			SET @dni = _dni; 
			SET @pag = _pag; 
			SET @cantfil = _cantfil; 
			EXECUTE STMT USING @idtipopersona,@apellido,@nombre,@dni,@pag,@cantfil;
			DEALLOCATE PREPARE STMT;
		ELSE
			PREPARE STMT FROM "SELECT a.idpersona,CONCAT(a.apellido,', ', a.nombre) AS Nombre,b.tipopersona AS TipoPersona
						   FROM personas a INNER JOIN tipopersonas b ON (b.idtipopersona=a.idtipopersona)
						   WHERE (a.idtipopersona!=2) AND
							 (a.apellido LIKE CONCAT(? ,'%')) AND 
							 (a.nombre LIKE CONCAT(? ,'%')) AND 
							 (a.dni LIKE CONCAT(? ,'%')) AND
							 (a.accion='B')
						   ORDER BY a.apellido,a.nombre
						   LIMIT ?,?";
						   
			SET @apellido = _apellido; 
			SET @nombre = _nombre; 
			SET @dni = _dni; 
			SET @pag = _pag; 
			SET @cantfil = _cantfil; 
			EXECUTE STMT USING @apellido,@nombre,@dni,@pag,@cantfil;
			DEALLOCATE PREPARE STMT;
		END IF;
	ELSE
		IF _idtipopersona>0 THEN
			PREPARE STMT FROM "SELECT a.idpersona,CONCAT(a.apellido,', ', a.nombre) AS Nombre,b.tipopersona AS TipoPersona
						   FROM personas a INNER JOIN tipopersonas b ON (b.idtipopersona=a.idtipopersona)
						   WHERE (a.idtipopersona=?) AND
							 (a.apellido LIKE CONCAT(? ,'%')) AND 
							 (a.nombre LIKE CONCAT(? ,'%')) AND 
							 (a.dni LIKE CONCAT(? ,'%')) AND
							 (a.accion!='B')
						   ORDER BY a.apellido,a.nombre
						   LIMIT ?,?";
						   
			SET @idtipopersona = _idtipopersona; 
			SET @apellido = _apellido; 
			SET @nombre = _nombre; 
			SET @dni = _dni; 
			SET @pag = _pag; 
			SET @cantfil = _cantfil; 
			EXECUTE STMT USING @idtipopersona,@apellido,@nombre,@dni,@pag,@cantfil;
			DEALLOCATE PREPARE STMT;
		ELSE
			PREPARE STMT FROM "SELECT a.idpersona,CONCAT(a.apellido,', ', a.nombre) AS Nombre,b.tipopersona AS TipoPersona
						   FROM personas a INNER JOIN tipopersonas b ON (b.idtipopersona=a.idtipopersona)
						   WHERE (a.idtipopersona!=2) AND
							 (a.apellido LIKE CONCAT(? ,'%')) AND 
							 (a.nombre LIKE CONCAT(? ,'%')) AND 
							 (a.dni LIKE CONCAT(? ,'%')) AND
							 (a.accion!='B')
						   ORDER BY a.apellido,a.nombre
						   LIMIT ?,?";
						   
			SET @apellido = _apellido; 
			SET @nombre = _nombre; 
			SET @dni = _dni; 
			SET @pag = _pag; 
			SET @cantfil = _cantfil; 
			EXECUTE STMT USING @apellido,@nombre,@dni,@pag,@cantfil;
			DEALLOCATE PREPARE STMT;
		END IF;
	END IF;
	
		
ELSE			
	PREPARE STMT FROM "SELECT a.apellido,a.nombre,a.dni,a.cel,a.tel,a.email,a.calle,a.numero,a.piso,a.dpto,b.tipopersona,a.observacion,a.fechaingreso,a.fechaegreso,a.usuario,a.contrasenia
				   FROM personas a INNER JOIN tipopersonas b ON (a.idtipopersona=b.idtipopersona)
				   WHERE (a.idpersona=?)";
		
		SET @idpersona = _idempleado; 
		EXECUTE STMT USING @idpersona;
		DEALLOCATE PREPARE STMT;
END IF;
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_buscadortipopersonas` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_buscadortipopersonas` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_buscadortipopersonas`(
    IN _idtipopersona int,
    in _tipopersona varchar(30),
    IN _pag INT,
    IN _cantfil INT
    )
BEGIN
if (_idtipopersona<=0) then
	PREPARE STMT FROM "SELECT a.idtipopersona,a.tipopersona
				FROM tipopersonas a 
				   WHERE (a.idtipopersona!=2) AND (a.tipopersona LIKE CONCAT(? ,'%'))
				   ORDER BY a.tipopersona
				   LIMIT ?,?";
		
		SET @tipopersona = _tipopersona; 
		SET @pag = _pag; 
		SET @cantfil = _cantfil; 
		EXECUTE STMT USING @tipopersona,@pag,@cantfil;
		DEALLOCATE PREPARE STMT;
else			
	PREPARE STMT FROM "SELECT a.idtipoperosna,a.tipopersona
				FROM tipopersonas a 
			   WHERE (a.idtipoperosna LIKE CONCAT(? ,'%'))";
		
		SET @idtipoperosna = _idtipoperosna; 
		EXECUTE STMT USING @idtipoperosna;
		DEALLOCATE PREPARE STMT;
end if;
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_buscadortiposervicios` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_buscadortiposervicios` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_buscadortiposervicios`(
    IN _idtiposervicio int,
    in _servicio varchar(30),
    IN _pag INT,
    IN _cantfil INT
    )
BEGIN
if (_idtiposervicio<=0) then
	PREPARE STMT FROM "SELECT a.idtiposervicio,a.servicio,a.costo
				FROM tiposervicios a 
				   WHERE (a.accion!='B') AND (a.idtiposervicio>1) AND (a.servicio LIKE CONCAT(? ,'%'))
				   ORDER BY a.servicio
				   LIMIT ?,?";
		
		SET @servicio = _servicio; 
		SET @pag = _pag; 
		SET @cantfil = _cantfil; 
		EXECUTE STMT USING @servicio,@pag,@cantfil;
		DEALLOCATE PREPARE STMT;
else			
	PREPARE STMT FROM "SELECT a.idtiposervicio,a.servicio,a.costo
				FROM tiposervicios a 
			   WHERE (a.idtiposervicio LIKE CONCAT(? ,'%'))";
		
		SET @idtiposervicio = _idtiposervicio; 
		EXECUTE STMT USING @idtipservicio;
		DEALLOCATE PREPARE STMT;
end if;
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_cerrarreclamo` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_cerrarreclamo` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_cerrarreclamo`(
    IN _idreclamo int,
    IN _fecha DATETIME,
    IN _obs VARCHAR(100),
    
    IN _accion varCHAR(1),
    IN _fechaaccion datetime
    )
BEGIN
	UPDATE reclamos SET fechafin=_fecha,observacion=_obs,accion=_accion,fechaaccion=_fechaaccion
	WHERE idreclamo=_idreclamo;
	
	SELECT fechafin FROM reclamos WHERE idreclamo=_idreclamo;
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_login` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_login` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_login`(
    IN _usuario VARCHAR(50),
    IN _password VARCHAR(50)
    )
BEGIN
	PREPARE STMT FROM "SELECT a.idpersona,a.apellido,a.nombre,b.tipopersona
			   FROM personas a INNER JOIN tipopersonas b ON (a.idtipopersona=b.idtipopersona)
			   WHERE (a.accion!='B') AND 
			         (a.usuario=?) AND 
			         (a.contrasenia=?)";
		
		SET @usuario = _usuario; 
		SET @password = _password; 
		EXECUTE STMT USING @usuario,@password;
		DEALLOCATE PREPARE STMT;
END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
