-- MySqlBackup.NET 2.3.8.0
-- Dump Time: 2023-04-12 23:02:04
-- --------------------------------------
-- Server version 8.0.32 MySQL Community Server - GPL


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb3 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of customer
-- 

DROP TABLE IF EXISTS `customer`;
CREATE TABLE IF NOT EXISTS `customer` (
  `id` int NOT NULL AUTO_INCREMENT,
  `customer_name` varchar(255) NOT NULL,
  `email` varchar(45) NOT NULL,
  `phone_number` varchar(45) NOT NULL,
  `address` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb3;

-- 
-- Dumping data for table customer
-- 

/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer`(`id`,`customer_name`,`email`,`phone_number`,`address`) VALUES(1,'Mary Denver','jane@gmail.com','09456782645','New York, New York'),(2,'John Smith','john.smith@gmail.com','09876543210','Los Angeles, CA'),(3,'Emily Johnson','emily.johnson@yahoo.com','09765432109','San Francisco, CA'),(4,'David Lee','david.lee@hotmail.com','09654321098','Seattle, WA'),(5,'Michelle Chen','michelle.chen@gmail.com','09543210987','Chicago, IL'),(6,'Daniel Kim','daniel.kim@yahoo.com','09432109876','New York, NY'),(7,'Bradley Thompson','avery.thompson@hotmail.com','09321098765','Dallas, TX'),(8,'Sophia Lee','sophia.lee@gmail.com','09210987654','Houston, TX'),(9,'Ryan Chen','ryan.chen@yahoo.com','09109876543','Atlanta, GA'),(10,'Emma Davis','emma.davis@hotmail.com','09098765432','Denver, CO'),(12,'Juan','email.com','91241513615','newyork'),(13,'Ela','email.com','91241513615','newyork'),(14,'Maria ','email.com','91241513615','newyork'),(15,'Gacia','email.com','91241513615','newyork'),(19,'Juan','email.com','91241513615','newyork'),(20,'Ela','email.com','91241513615','newyork'),(21,'Maria ','email.com','91241513615','newyork'),(22,'Gacia','email.com','91241513615','newyork'),(31,'Pink Floyd ','fffff.com','ffff','Liverpool, England');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;

-- 
-- Definition of employees
-- 

DROP TABLE IF EXISTS `employees`;
CREATE TABLE IF NOT EXISTS `employees` (
  `id` int NOT NULL AUTO_INCREMENT,
  `employee_name` varchar(255) NOT NULL,
  `hourly_wage` decimal(10,2) NOT NULL,
  `date_hired` date DEFAULT NULL,
  `username` varchar(255) DEFAULT NULL,
  `employee_password` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb3;

-- 
-- Dumping data for table employees
-- 

/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
INSERT INTO `employees`(`id`,`employee_name`,`hourly_wage`,`date_hired`,`username`,`employee_password`) VALUES(1,'John Jones',50.00,'2022-03-05 00:00:00','admin','21232f297a57a5a743894a0e4a801fc3'),(2,'Alice Anderson',40.00,'2021-01-15 00:00:00',NULL,NULL),(3,'Bob Brown',45.00,'2020-09-01 00:00:00',NULL,NULL),(4,'Cathy Chen',35.00,'2022-01-30 00:00:00',NULL,NULL),(5,'David Davis',55.00,'2021-11-07 00:00:00',NULL,NULL),(6,'Eva Evans',42.00,'2022-02-14 00:00:00',NULL,NULL),(7,'Frank Fernandez',38.00,'2020-06-23 00:00:00',NULL,NULL),(8,'Grace Gonzalez',47.00,'2021-07-08 00:00:00',NULL,NULL),(9,'Henry Hernandez',51.00,'2020-12-12 00:00:00',NULL,NULL),(10,'Isabel Ingram',39.00,'2022-04-02 00:00:00',NULL,NULL),(11,'Jake Jackson',43.00,'2021-03-18 00:00:00',NULL,NULL),(12,'John',24.00,'2021-04-19 00:00:00','john','527bd5b5d689e2c32ae974c6229ff785'),(13,'Bones',23.00,'2023-04-23 00:00:00','bones','775f172869d40d605be241a5070b0afa'),(14,'jeff',23.00,'2023-03-06 00:00:00','jeff','166ee015c0e0934a8781e0c86a197c6e'),(15,'Cage',44.00,'2023-03-06 00:00:00','cage','9f1f78a320748365cb6994db2bc970bb'),(18,'john cage',25.00,'2023-03-06 00:00:00','admin','21232f297a57a5a743894a0e4a801fc3'),(19,'radiohead',100.00,'2023-04-04 00:00:00','radiohead','222a5a8b3ad3d7d0e6805e301898eaaf'),(20,'Testing testing testing',0.00,'2023-04-07 00:00:00','admin','21232f297a57a5a743894a0e4a801fc3');
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;

-- 
-- Definition of project_employee
-- 

DROP TABLE IF EXISTS `project_employee`;
CREATE TABLE IF NOT EXISTS `project_employee` (
  `id` int NOT NULL AUTO_INCREMENT,
  `hours` time DEFAULT NULL,
  `Employees_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Project_employee_Employees1_idx` (`Employees_id`),
  CONSTRAINT `fk_Project_employee_Employees1` FOREIGN KEY (`Employees_id`) REFERENCES `employees` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb3;

-- 
-- Dumping data for table project_employee
-- 

/*!40000 ALTER TABLE `project_employee` DISABLE KEYS */;
INSERT INTO `project_employee`(`id`,`hours`,`Employees_id`) VALUES(1,NULL,1),(2,NULL,2),(3,NULL,3),(4,NULL,4),(5,NULL,5),(6,NULL,6),(7,NULL,7),(8,NULL,8),(9,NULL,9),(10,NULL,10);
/*!40000 ALTER TABLE `project_employee` ENABLE KEYS */;

-- 
-- Definition of projects
-- 

DROP TABLE IF EXISTS `projects`;
CREATE TABLE IF NOT EXISTS `projects` (
  `id` int NOT NULL AUTO_INCREMENT,
  `project_name` varchar(255) NOT NULL,
  `project_budget` float NOT NULL,
  `project_start` date NOT NULL,
  `project_end` date NOT NULL,
  `Customer_id` int NOT NULL,
  `Project_employee_id` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Projects_Customer_idx` (`Customer_id`),
  KEY `FK_employee` (`Project_employee_id`),
  CONSTRAINT `FK_employee` FOREIGN KEY (`Project_employee_id`) REFERENCES `project_employee` (`id`),
  CONSTRAINT `fk_Projects_Customer` FOREIGN KEY (`Customer_id`) REFERENCES `customer` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb3;

-- 
-- Dumping data for table projects
-- 

/*!40000 ALTER TABLE `projects` DISABLE KEYS */;
INSERT INTO `projects`(`id`,`project_name`,`project_budget`,`project_start`,`project_end`,`Customer_id`,`Project_employee_id`) VALUES(1,'E-commere Website',90000,'2023-02-25 00:00:00','2023-04-25 00:00:00',1,1),(2,'Mobile App Development',50000,'2023-03-15 00:00:00','2023-06-15 00:00:00',2,1),(3,'Data Analysis Platform',75000,'2023-04-01 00:00:00','2023-09-01 00:00:00',3,2),(4,'Online Course Platform',60000,'2023-03-01 00:00:00','2023-07-01 00:00:00',4,2),(5,'Event Planning App',40000,'2023-04-20 00:00:00','2023-07-20 00:00:00',5,3),(6,'Fitness Tracking App',35000,'2023-05-01 00:00:00','2023-08-01 00:00:00',6,4),(7,'Inventory Management System',80000,'2023-04-10 00:00:00','2023-11-10 00:00:00',7,5),(8,'Social Media Marketing',90000,'2023-05-15 00:00:00','2023-10-15 00:00:00',8,6),(9,'Travel Booking Website',65000,'2023-03-25 00:00:00','2023-09-25 00:00:00',9,7),(10,'Real Estate Listing Website',55000,'2023-06-01 00:00:00','2023-10-01 00:00:00',10,8);
/*!40000 ALTER TABLE `projects` ENABLE KEYS */;

-- 
-- Definition of job_orders
-- 

DROP TABLE IF EXISTS `job_orders`;
CREATE TABLE IF NOT EXISTS `job_orders` (
  `id` int NOT NULL AUTO_INCREMENT,
  `description` varchar(255) DEFAULT NULL,
  `order_date` datetime NOT NULL,
  `is_finished` int DEFAULT NULL,
  `Projects_id` int NOT NULL,
  `Employee_id` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Job_orders_Projects1_idx` (`Projects_id`),
  KEY `fk_Job_orders_Project_employee1_idx` (`Employee_id`),
  CONSTRAINT `fk_Job_orders_Project_employee1` FOREIGN KEY (`Employee_id`) REFERENCES `project_employee` (`id`),
  CONSTRAINT `fk_Job_orders_Projects1` FOREIGN KEY (`Projects_id`) REFERENCES `projects` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb3;

-- 
-- Dumping data for table job_orders
-- 

/*!40000 ALTER TABLE `job_orders` DISABLE KEYS */;
INSERT INTO `job_orders`(`id`,`description`,`order_date`,`is_finished`,`Projects_id`,`Employee_id`) VALUES(15,NULL,'2023-02-20 00:00:00',1,3,2),(24,'asdasd','2023-04-12 00:00:00',NULL,6,4),(27,'opopop','2023-03-31 00:00:00',1,5,3),(28,'make this perfect','2023-04-12 00:00:00',NULL,10,8);
/*!40000 ALTER TABLE `job_orders` ENABLE KEYS */;

-- 
-- Definition of orders_finished
-- 

DROP TABLE IF EXISTS `orders_finished`;
CREATE TABLE IF NOT EXISTS `orders_finished` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Job_orders_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Orders_finished_Job_orders1_idx` (`Job_orders_id`),
  CONSTRAINT `fk_Orders_finished_Job_orders1` FOREIGN KEY (`Job_orders_id`) REFERENCES `job_orders` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3;

-- 
-- Dumping data for table orders_finished
-- 

/*!40000 ALTER TABLE `orders_finished` DISABLE KEYS */;
INSERT INTO `orders_finished`(`id`,`Job_orders_id`) VALUES(1,15),(2,27);
/*!40000 ALTER TABLE `orders_finished` ENABLE KEYS */;

-- 
-- Dumping functions
-- 

DROP FUNCTION IF EXISTS `get_customer_project`;
DELIMITER |
CREATE FUNCTION `get_customer_project`(customer_id INT) RETURNS varchar(255) CHARSET utf8mb3
    DETERMINISTIC
BEGIN
    DECLARE project_name VARCHAR(255);

    -- Select the project associated with the customer
    SELECT p.project_name INTO project_name
    FROM projects p
    WHERE p.Customer_id = customer_id
    LIMIT 1;

    -- Return the customer name and project name
    RETURN CONCAT((SELECT customer_name FROM customer WHERE id = customer_id), ' - ', project_name);
END |
DELIMITER ;

-- 
-- Dumping procedures
-- 

DROP PROCEDURE IF EXISTS `update_project_budget`;
DELIMITER |
CREATE PROCEDURE `update_project_budget`(
    IN project_id INT,
    IN new_budget DECIMAL(10,2)
)
BEGIN
    UPDATE projects
    SET project_budget = new_budget
    WHERE id = project_id;
END |
DELIMITER ;

-- 
-- Dumping views
-- 

DROP TABLE IF EXISTS `customer_project_details`;
DROP VIEW IF EXISTS `customer_project_details`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `customer_project_details` AS select `c`.`customer_name` AS `customer_name`,`p`.`project_name` AS `project_name`,`p`.`project_start` AS `project_start`,`p`.`project_end` AS `project_end`,`p`.`project_budget` AS `project_budget`,`e`.`employee_name` AS `project_employee_name` from (((`projects` `p` join `customer` `c` on((`p`.`Customer_id` = `c`.`id`))) join `project_employee` `pe` on((`p`.`Project_employee_id` = `pe`.`id`))) join `employees` `e` on((`pe`.`Employees_id` = `e`.`id`)));

DROP TABLE IF EXISTS `customer_projects`;
DROP VIEW IF EXISTS `customer_projects`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `customer_projects` AS select `p`.`id` AS `Project ID`,`p`.`project_name` AS `Project Name`,`p`.`project_budget` AS `Budget`,`p`.`project_start` AS `Start`,`p`.`project_end` AS `End`,`c`.`customer_name` AS `Customer` from (`projects` `p` join `customer` `c` on((`p`.`Customer_id` = `c`.`id`)));

DROP TABLE IF EXISTS `job_finished_details`;
DROP VIEW IF EXISTS `job_finished_details`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `job_finished_details` AS select `jo`.`id` AS `id`,`c`.`customer_name` AS `Customer Name`,`p`.`project_name` AS `Project Name`,`e`.`employee_name` AS `Employee Name` from (((`job_orders` `jo` join `projects` `p` on((`jo`.`Projects_id` = `p`.`id`))) join `customer` `c` on((`p`.`Customer_id` = `c`.`id`))) join `employees` `e` on((`jo`.`Employee_id` = `e`.`id`))) where (`jo`.`is_finished` = '1');

DROP TABLE IF EXISTS `job_order_details`;
DROP VIEW IF EXISTS `job_order_details`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `job_order_details` AS select `j`.`id` AS `Job Order ID`,`j`.`order_date` AS `Order Date`,(case when (`j`.`is_finished` is null) then 'no' else 'yes' end) AS `Finished (?)`,`e`.`employee_name` AS `Employee`,`c`.`customer_name` AS `Customer` from (((`job_orders` `j` join `employees` `e` on((`j`.`Employee_id` = `e`.`id`))) join `projects` `p` on((`j`.`Projects_id` = `p`.`id`))) join `customer` `c` on((`p`.`Customer_id` = `c`.`id`)));


-- 
-- Dumping triggers
-- 

DROP TRIGGER /*!50030 IF EXISTS */ `delete_customer_projects`;
DELIMITER |
CREATE TRIGGER `delete_customer_projects` BEFORE DELETE ON `customer` FOR EACH ROW BEGIN
    -- Delete the customer's projects
    DELETE FROM projects WHERE Customer_id = OLD.id;

    -- Delete the job orders associated with the customer's projects
    DELETE FROM job_orders WHERE Projects_id IN (SELECT id FROM projects WHERE Customer_id = OLD.id);
END |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `set_projects_employee_id`;
DELIMITER |
CREATE TRIGGER `set_projects_employee_id` BEFORE INSERT ON `job_orders` FOR EACH ROW BEGIN
  -- when a user inserts a project ID, the employee_id field is also 
  -- updated. It gets its value from the 'projects' table where 
  -- id in projects table is equal to Projects_id in job_order table
  SET NEW.Employee_id = (
    SELECT Project_employee_id
    FROM projects
    WHERE id = NEW.Projects_id
  );
END |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `job_orders_BEFORE_UPDATE`;
DELIMITER |
CREATE TRIGGER `job_orders_BEFORE_UPDATE` BEFORE UPDATE ON `job_orders` FOR EACH ROW BEGIN
	-- this trigger works the same way as BEFORE INSERT but for UPDATES
    SET NEW.Employee_id = (
    SELECT Project_employee_id
    FROM projects
    WHERE id = NEW.Projects_id
  );
END |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `add_to_orders_finished`;
DELIMITER |
CREATE TRIGGER `add_to_orders_finished` AFTER UPDATE ON `job_orders` FOR EACH ROW BEGIN
    -- If the job order is finished, insert its ID into the orders_finished table
    IF NEW.is_finished = 1 THEN
        INSERT INTO orders_finished (Job_orders_id) VALUES (NEW.id);
    END IF;
END |
DELIMITER ;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2023-04-12 23:02:04
-- Total time: 0:0:0:0:288 (d:h:m:s:ms)
