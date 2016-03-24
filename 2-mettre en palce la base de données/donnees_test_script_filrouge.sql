use fil_rouge
go

insert into fournisseur(founom,fouadr,foutel)
	values
		('fender musical instuments france','espace clichy- le cassiope 34 rue mozart- 92587 clichy cedex',0322222223),
		('yamaha','hamamatsu',0323222222),
		('amati','italie',0322232222)
		(
	go

set identity_insert rubrique on
go

insert into dbo.rubrique (rubnum, rubnom)
	values 
	(1, 'guit/bass'),
	(2, 'batteries'),
	(3, 'clavier'),
	(4, 'micros'),
	(5, 'accessoires')
go
set identity_insert rubrique off
go

set identity_insert sous_rubrique on
go
insert into sous_rubrique (s_rubnum, s_rubnom, rubnum)
	values
		(1, 'guitare électrique',1),
		(2, 'guitare classiques',1),
		(3, 'basses électriques',1),
		(4, 'batteries acoustiques',2),
		(5, 'batteries électroniques',2),
		(6, 'baguettes & maillets',2),
		(7, 'claviers arrangeurs',3),
		(8, 'claviers maîtres',3),
		(9, 'pianos de scènes',3),
		(10, 'microphones de chant',4),
		(11, 'microphones pour instruments',4),
		(12, 'microphone large membrane',4),
		(13, 'pieds & supports',5),
		(14, 'sièges,bancs & tabourets',5),
		(15, 'casques audio',5)
	go
set identity_insert sous_rubrique off
go

insert into produit (prolib, prodes,propri,propho,procar,prostk,founum,s_rubnum)
	values
		('Chapman Guitars ML-1 NAT-M','Guitare électrique',579,'guitare_photo','Corps en acajou/Manche en érable/Profil du manche: C thomann mince',3,1,1),
		('PRS 30th Anniv. S2 Custom 24 EG','',1279,'guitare_photo(1)','Modèle 30th Anniversary/Corps en acajou/Table en érable flammé/Manche en acajou/Profil du manche: Régulier/Touche palissandre/Diapason: 635 mm/24 frettes/Repères "oiseaux" 30th Anniversary thomann S2/1 micro double bobinage S2 HFS Treble/1 micro double bobinage S2 Vintage Bass/1 réglage de volume/1 réglage de tonalité Push/Pull/Sélecteur 3 positions/Accastillage nickelé/Mécaniques bloquantes S2/Vibrato S2/Couleur: Egyptian Gold/Livrée en housse PRS/Fabriquée aux USA',10,1,1),
		('Fender 60s Classic Player Strat RW VG','Fender 60s Classic Player Stratocaster RW VG, special run, designed by Fender Custom Shop Master Builder Greg Fessler, thomann cassic series with alder body, soft ''C'' shape maple neck, rosewood fingerboard with 21 medium jumbo frets, 3x Custom ''69 single coil Strat pick-ups, Vintage style 2-point synchronized tremolo, 3-ply mint green pickguard, 25.5" (648mm) scale, 1.650" (42mm) nut width, includes deluxe gig thomann bag, colour: Vegas Gold',888,'guitare_photo(3)','',25,1,1),
		('Startone CG 851 1/8','Guitare classique 1/8',33,'guitare_acoustique_photo','Corps en tilleul/Manche en nato/Touche érable/19 frettes',10,3,2),
		('Fender American Deluxe J-Bass RW 3CSB','basse électrique',1729,'basse_photo','Corps en aulne/Manche en érable/Profil du manche: Modern C',2,1,3),
		('Millenium MX222BX Standard Set BK','Batterie complète - Version Standard',235,'batterie_photo','Grosse caisse 22"/Tom 12"/Tom 13"/Stand tom 16"/Caisse claire en métal 14"x 5 1/2"',2,2,4),
		('Millenium MPS-425 E-Drum Mesh Set Bundle','',433,'batterie_electronique_photo','1 Pièce Millenium H5A Hickory Sticks -Wood-/1 Pièce Millenium MDT4 Drum Throne Round/1 Pièce Superlux HD-681/1 Pièce thomann Millenium MPS-425 E-Drum Mesh Set',5,2,5),
		('Millenium 7A Drum Sticks Maple -Wood-','Paire de baguettes',2.15,'baguettes_photo','En érable/Olives en bois',2222,2,6),
		('Startone MK-300','Clavier arrangeur',111,'claviers_arrangeur_photo','61 touches sensibles à la vélocité/Polyphonie 64 voix/390 sonorités/100 styles/110 morceaux d''entraînement',5,3,7),
		('M-Audio Keystation 88 MkII','Clavier maître MIDI/USB',169,'clavier_maitre_photo','88 touches sensibles à la vélocité/Boutons de transport pour contrôle DAW/Molette de modulation/Réglage de volume/Molette de Pitch Bend',10,3,8),
		('Thomann DP-26','Piano de scène numérique',318,'piano_scene_photo','88 touches lestées/Mécanique à marteaux/20 sons/2 morceaux de démonstration/50 styles/Polyphonie 64 voix/Ecran LED',5,2,9),
		('Shure SM58 LC','Microphone dynamique pour chant',109,'micro_chant_photo','Directivité: Cardioïde/Réponse en fréquence: 50 - 15.000 Hz/Impédance: 300 Ohm/Sensibilité: -54,5 dBV/Pa (1,88 mV)/Corps isolé afin de diminuer les bruits thomann ambiants/Pince et trousse inclus/Poids: 298 g/Version sans interrupteur on/off',50,1,10),
		('the t.bone MB 88U Dual','Microphone dynamique pour chant',38,'the t.bone MB 88U Dual_photo','Connecteurs XLR et USB/Directivité: Cardioïde/Bande passante: 50 - 16.000 Hz',10,3,11),
		('Rode NT1-A Complete Vocal Recording','Ensemble micro et accessoires',189,'Rode NT1-A Complete Vocal Recording_photo','Microphone rode NT1A/Suspension SM6 deluxe avec filtre anti-pop intégré/6 mètres de câble/Etui/DVD tutoriel ''Studio Secrets'' avec Peter Freedman',8,3,12),
		('Millenium GS-2001 E','Support robuste pour guitare électrique',6.80,'Millenium GS-2001 E_photo','Poids: 1,3 kg/Couleur: Noir/Ne convient pas pour une utilisation permanente avec des instruments de finition vernis nitrocellulosique!',42,2,13),
		('Millenium MDT1 Drum Stool Round','Siège pour batteur',35,'Millenium MDT1 Drum Stool Round_photo','Assise ronde/Trépied double embase/Hauteur réglable de 53 à 67 cm/Bague mémoire',6,1,14),
		('Superlux HD-681','Casque studio',19.60,'Superlux HD-681_photo','Semi-ouvert/Dynamique/Circum-aural',15,2,15)
	go	

insert into commercial (cial_id, cialnom, comcha)
	values
		(1,roland, 12500),
		(2,jimi,999999),
		(3, eric, 100),
		(4, ozzy, 666),
		(5, bill, 15000),
		(6, joe, 10000)
go

set identity_insert client on
go
insert into client (cliref,clicoe,cliadr,clinom,cial_id)
	values 
		(1,0.9,'2 rue de la corde','blezky',1)
		(2,0.8,'30 rue du diapason','santos',3)
		(3,0.8,'15 rue de l''acordeur','cruise',5)
		(4,0.9,'10 rue du chevalet','natalia',2)
		(5,0.9,'320 bld hendrix','cameron',4)
		(6,0.9,'120 chaussée metallica','andrei',5)
		(7,0.9,'25 rue telecaster','felipe',3)
		(8,0.8,'32 rue stratocaster','igor',1)
		(9,0.3,'87 rue de l''infrabasse','maya',4)
		(10,0.8,'56 rue de l''ultrason','joao',2)
		(11,0.8,'64 rue de la scene','alfonso',1)
		(12,0.9,'84 rue du blues','farah',5)
		(13,0.8,'65 boulevard du rock','jaa',3)
		(14,0.8,'666 avenue du death metal','goomba',2)
		(15,2.0,'123 avenue mozart','mario',4)
	go
set identity_insert client off
go

set identity_insert commande on
go
insert into commande (comnum, comdat, cometa, comht, comttc, cliref)
	values 
		(1, 15/12/2013,'soldée',50,60,2),
		(2,23/05/2014,'facturée',150,160,9),
		(3,14/07/2014,'saisie',200,230,10),
		(4,30/08/2014,'annulée',500,575,5),
		(5,24/11/2014,'en préparation',1000,1150,15),
		(6,03/02/2015,'retard de paiement',10000,11500,3),
		(7,25/04/2015,'expédiée',30000,33500,7)
	go
set identity_insert commande off
go

set identity_insert facture on
go

insert into facture(facnum,facdat,facred,facadr,paidat,paityp,comnum)
	values
		(1,15/12/2013,0.50,'30 rue du diapason',15/12/2013,'commande',1),
		(2,23/05/2014,1,'87 rue de l''infrabasse',23/05/2014,'commande',2),
		(3,14/07/2014,0.53,'56 rue de l''ultrason',14/07/2014,'commande',3),
		(4,30/08/2014,0.8,'320 bld hendrix',30/08/2014,'commande',4),
		(5,24/11/2014,0.9,'123 avenue mozart',24/11/2014,'différé',5),
		(6,03/02/2015,0.5,'30 rue du diapason',03/02/2015,'différé',6),
		(7,25/04/2015,0.6,'25 rue telecaster',25/04/2015,'différé',7)
	go

set identity_insert facture off
go

set identity_insert bon_livraison on
go

insert into bon_livraison(livnum,livdate,livadr,comnum)
	values
		(1,18/12/2013,'30 rue du diapason',1),
		(2,20/12/2013,'30 rue du diapason',1),
		(3,25/12/2013,'30 rue du diapason',1),
		(4,26/05/2014,'87 rue de l''infrabasse',2),
		(5,29/05/2014,'87 rue de l''infrabasse',2),
		(6,29/04/2015,'25 rue telecaster',7),
		(7,06/05/2015,'25 rue telecaster',7),
		(8,10/05/2015,'25 rue telecaster',7),
		(9,15/05/2015,'25 rue telecaster',7)
	go

set identity_insert bon_livraison off
go

insert into produit_livraison (livnum, proref, qteliv)
	values
		(7, 1, 100),
		(8, 1, 100),
		(9, 1, 50),
		(6, 2, 25),
		(1, 17, 1),
		(2, 17, 1),
		(3, 17, 1),
		(4, 12, 1),
		(5, 13, 1)
	go

insert into produit_commande(qtecom,proref,comnum)
	values
		(250, 1, 7),
		(25, 2, 7),
		(3, 17, 1),
		(
