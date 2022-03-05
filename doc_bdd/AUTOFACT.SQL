DROP DATABASE IF EXISTS Autofact;

CREATE DATABASE IF NOT EXISTS Autofact;
USE Autofact;
# -----------------------------------------------------------------------------
#       TABLE : COMMANDE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS COMMANDE
 (
   IDCOMMANDE SMALLINT NOT NULL  ,
   IDCLIENT SMALLINT NOT NULL  ,
   DATECREATION DATETIME NULL  ,
   PAYE BOOL NULL  
   , PRIMARY KEY (IDCOMMANDE) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE COMMANDE
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_COMMANDE_CLIENT
     ON COMMANDE (IDCLIENT ASC);

# -----------------------------------------------------------------------------
#       TABLE : PRESTATION
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS PRESTATION
 (
   IDPRESTATION SMALLINT NOT NULL  ,
   IDCATEGORIE SMALLINT NOT NULL  ,
   LIBELLE CHAR(32) NULL  ,
   DESCRIPTION CHAR(32) NULL  
   , PRIMARY KEY (IDPRESTATION) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE PRESTATION
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_PRESTATION_CATEGORIE
     ON PRESTATION (IDCATEGORIE ASC);

# -----------------------------------------------------------------------------
#       TABLE : CLIENT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CLIENT
 (
   IDCLIENT SMALLINT NOT NULL  ,
   NOM CHAR(32) NULL  ,
   PRENOM CHAR(32) NULL  ,
   TELEPHONE CHAR(32) NULL  ,
   MAIL CHAR(32) NULL  
   , PRIMARY KEY (IDCLIENT) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : CATEGORIE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CATEGORIE
 (
   IDCATEGORIE SMALLINT NOT NULL  ,
   LIBELLE CHAR(32) NULL  
   , PRIMARY KEY (IDCATEGORIE) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : CONTENIR
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CONTENIR
 (
   IDCOMMANDE SMALLINT NOT NULL  ,
   IDPRESTATION SMALLINT NOT NULL  ,
   QUANTITE CHAR(32) NULL  
   , PRIMARY KEY (IDCOMMANDE,IDPRESTATION) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE CONTENIR
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_CONTENIR_COMMANDE
     ON CONTENIR (IDCOMMANDE ASC);

CREATE  INDEX I_FK_CONTENIR_PRESTATION
     ON CONTENIR (IDPRESTATION ASC);


# -----------------------------------------------------------------------------
#       CREATION DES REFERENCES DE TABLE
# -----------------------------------------------------------------------------


ALTER TABLE COMMANDE 
  ADD FOREIGN KEY FK_COMMANDE_CLIENT (IDCLIENT)
      REFERENCES CLIENT (IDCLIENT) ;


ALTER TABLE PRESTATION 
  ADD FOREIGN KEY FK_PRESTATION_CATEGORIE (IDCATEGORIE)
      REFERENCES CATEGORIE (IDCATEGORIE) ;


ALTER TABLE CONTENIR 
  ADD FOREIGN KEY FK_CONTENIR_COMMANDE (IDCOMMANDE)
      REFERENCES COMMANDE (IDCOMMANDE) ;


ALTER TABLE CONTENIR 
  ADD FOREIGN KEY FK_CONTENIR_PRESTATION (IDPRESTATION)
      REFERENCES PRESTATION (IDPRESTATION) ;

