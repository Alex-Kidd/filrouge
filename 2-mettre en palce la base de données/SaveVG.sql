use fil_rouge

exec sp_addumpdevice 'disk','savVG','C:\Backup\VG.bak' 
--création du fichier de sauvegarde VG.bak
go
backup database fil_rouge to savVG
--sauvegarde de la base 
go
restore database fil_rouge from savVG 
--chargement sauvegarde de la base 
go