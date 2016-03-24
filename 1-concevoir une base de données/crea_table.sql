#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------


#------------------------------------------------------------
# Table: produit
#------------------------------------------------------------

CREATE TABLE produit(
        proid   int (11) Auto_increment  NOT NULL ,
        prolib  Varchar (25) ,
        prodes  Varchar (25) ,
        propri  DECIMAL (15,3)  ,
        propho  Varchar (25) ,
        procar  Varchar (25) ,
        prostk  Int ,
        reffou  Varchar (25) ,
        s_rubid Int ,
        PRIMARY KEY (proid )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: client
#------------------------------------------------------------

CREATE TABLE client(
        cliref  int (11) Auto_increment  NOT NULL ,
        clicoe  Float ,
        clinom  Varchar (25) ,
        clipre  Varchar (25) ,
        clicom  Varchar (25) ,
        clistat Bool ,
        PRIMARY KEY (cliref )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: commande
#------------------------------------------------------------

CREATE TABLE commande(
        comnum    int (11) Auto_increment  NOT NULL ,
        comdat    Date ,
        cometa    Varchar (25) ,
        compuht   DECIMAL (15,3)  ,
        comht     DECIMAL (15,3)  ,
        comtva    Float ,
        comttc    DECIMAL (15,3)  ,
        redsup    Varchar (25) ,
        paidat    Date ,
        paityp    Varchar (25) ,
        paidatpre Date ,
        cliref    Int ,
        PRIMARY KEY (comnum )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: bon_livraison
#------------------------------------------------------------

CREATE TABLE bon_livraison(
        livnum  int (11) Auto_increment  NOT NULL ,
        livdate Date ,
        livadr  Varchar (25) ,
        comnum  Int ,
        PRIMARY KEY (livnum )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: fournisseur
#------------------------------------------------------------

CREATE TABLE fournisseur(
        founum int (11) Auto_increment  NOT NULL ,
        founom Varchar (25) ,
        fouadr Varchar (25) ,
        PRIMARY KEY (founum )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: rubrique
#------------------------------------------------------------

CREATE TABLE rubrique(
        rubid  int (11) Auto_increment  NOT NULL ,
        rubnom Varchar (25) ,
        PRIMARY KEY (rubid )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: sous_rubrique
#------------------------------------------------------------

CREATE TABLE sous_rubrique(
        s_rubid  int (11) Auto_increment  NOT NULL ,
        s_rubnom Varchar (25) ,
        rubid    Int ,
        PRIMARY KEY (s_rubid )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: adresse
#------------------------------------------------------------

CREATE TABLE adresse(
        adrid  int (11) Auto_increment  NOT NULL ,
        adrcli Varchar (25) ,
        cliref Int ,
        PRIMARY KEY (adrid )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: compose
#------------------------------------------------------------

CREATE TABLE compose(
        qtecom   Varchar (25) ,
        discount Varchar (25) ,
        proid    Int NOT NULL ,
        comnum   Int NOT NULL ,
        PRIMARY KEY (proid ,comnum )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: details_livraison
#------------------------------------------------------------

CREATE TABLE details_livraison(
        qteliv Int ,
        livnum Int NOT NULL ,
        proid  Int NOT NULL ,
        PRIMARY KEY (livnum ,proid )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: profou
#------------------------------------------------------------

CREATE TABLE profou(
        proid  Int NOT NULL ,
        founum Int NOT NULL ,
        PRIMARY KEY (proid ,founum )
)ENGINE=InnoDB;

ALTER TABLE produit ADD CONSTRAINT FK_produit_s_rubid FOREIGN KEY (s_rubid) REFERENCES sous_rubrique(s_rubid);
ALTER TABLE commande ADD CONSTRAINT FK_commande_cliref FOREIGN KEY (cliref) REFERENCES client(cliref);
ALTER TABLE bon_livraison ADD CONSTRAINT FK_bon_livraison_comnum FOREIGN KEY (comnum) REFERENCES commande(comnum);
ALTER TABLE sous_rubrique ADD CONSTRAINT FK_sous_rubrique_rubid FOREIGN KEY (rubid) REFERENCES rubrique(rubid);
ALTER TABLE adresse ADD CONSTRAINT FK_adresse_cliref FOREIGN KEY (cliref) REFERENCES client(cliref);
ALTER TABLE compose ADD CONSTRAINT FK_compose_proid FOREIGN KEY (proid) REFERENCES produit(proid);
ALTER TABLE compose ADD CONSTRAINT FK_compose_comnum FOREIGN KEY (comnum) REFERENCES commande(comnum);
ALTER TABLE details_livraison ADD CONSTRAINT FK_details_livraison_livnum FOREIGN KEY (livnum) REFERENCES bon_livraison(livnum);
ALTER TABLE details_livraison ADD CONSTRAINT FK_details_livraison_proid FOREIGN KEY (proid) REFERENCES produit(proid);
ALTER TABLE profou ADD CONSTRAINT FK_profou_proid FOREIGN KEY (proid) REFERENCES produit(proid);
ALTER TABLE profou ADD CONSTRAINT FK_profou_founum FOREIGN KEY (founum) REFERENCES fournisseur(founum);
