create view fournisprod
as 
select proid, prolib, prodes, propri, propho, procar,prostk,reffou,s_rubid, p.founum,founom,fouadr from produit p  
join fournisseur f 
on p.founum=f.founum
