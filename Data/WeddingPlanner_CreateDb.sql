-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema WeddingPlanner
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `WeddingPlanner` ;

-- -----------------------------------------------------
-- Schema WeddingPlanner
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `WeddingPlanner` DEFAULT CHARACTER SET utf8 ;
USE `WeddingPlanner` ;

-- -----------------------------------------------------
-- Table `WeddingPlanner`.`users`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `WeddingPlanner`.`users` ;

CREATE TABLE IF NOT EXISTS `WeddingPlanner`.`users` (
  `UserId` INT NOT NULL AUTO_INCREMENT,
  `Email` VARCHAR(200) NOT NULL,
  `FirstName` VARCHAR(45) NOT NULL,
  `LastName` VARCHAR(45) NOT NULL,
  `Password` VARCHAR(400) NOT NULL,
  `CreatedAt` DATETIME NOT NULL DEFAULT NOW(),
  `UpdatedAt` DATETIME NOT NULL DEFAULT NOW() ON UPDATE NOW(),
  PRIMARY KEY (`UserId`),
  UNIQUE INDEX `Email_UNIQUE` (`Email` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `WeddingPlanner`.`weddings`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `WeddingPlanner`.`weddings` ;

CREATE TABLE IF NOT EXISTS `WeddingPlanner`.`weddings` (
  `WeddingId` INT NOT NULL AUTO_INCREMENT,
  `CreatorUserId` INT NOT NULL,
  `WedderOneUserId` INT NOT NULL,
  `WedderTwoUserId` INT NOT NULL,
  `WeddingDate` DATE NOT NULL,
  `Address` VARCHAR(400) NOT NULL,
  `CreatedAt` DATETIME NOT NULL DEFAULT NOW(),
  `UpdatedAt` DATETIME NOT NULL DEFAULT NOW() ON UPDATE NOW(),
  PRIMARY KEY (`WeddingId`),
  INDEX `fk_weddings_users1_idx` (`WedderOneUserId` ASC) VISIBLE,
  INDEX `fk_weddings_users2_idx` (`WedderTwoUserId` ASC) VISIBLE,
  INDEX `fk_weddings_users3_idx` (`CreatorUserId` ASC) VISIBLE,
  CONSTRAINT `fk_weddings_users1`
    FOREIGN KEY (`WedderOneUserId`)
    REFERENCES `WeddingPlanner`.`users` (`UserId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_weddings_users2`
    FOREIGN KEY (`WedderTwoUserId`)
    REFERENCES `WeddingPlanner`.`users` (`UserId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_weddings_users3`
    FOREIGN KEY (`CreatorUserId`)
    REFERENCES `WeddingPlanner`.`users` (`UserId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `WeddingPlanner`.`guests`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `WeddingPlanner`.`guests` ;

CREATE TABLE IF NOT EXISTS `WeddingPlanner`.`guests` (
  `GuestId` INT NOT NULL AUTO_INCREMENT,
  `UserId` INT NOT NULL,
  `WeddingId` INT NOT NULL,
  `CreatedAt` DATETIME NOT NULL DEFAULT NOW(),
  `UpdatedAt` DATETIME NOT NULL DEFAULT NOW() ON UPDATE NOW(),
  PRIMARY KEY (`GuestId`),
  INDEX `fk_guests_users_idx` (`UserId` ASC) VISIBLE,
  INDEX `fk_guests_Wedding1_idx` (`WeddingId` ASC) VISIBLE,
  CONSTRAINT `fk_guests_users`
    FOREIGN KEY (`UserId`)
    REFERENCES `WeddingPlanner`.`users` (`UserId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_guests_Wedding1`
    FOREIGN KEY (`WeddingId`)
    REFERENCES `WeddingPlanner`.`weddings` (`WeddingId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
