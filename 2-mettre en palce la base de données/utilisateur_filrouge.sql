create login relation with password = 'pwd' , DEFAULT_DATABASE=[fil_rouge]
go
create login commercial with password = 'pwd' , DEFAULT_DATABASE=[fil_rouge]
go

create user agentrelation for login relation 
go
create user agentcommercial for login commercial
go


/**************droit service relation fournisseur****************/

grant select on dbo.produit to agentrelation
grant select on dbo.fournisseur to agentrelation
grant select on dbo.rubrique to agentrelation
grant select on dbo.sous_rubrique to agentrelation
go
grant update on dbo.produit to agentrelation
grant update on dbo.fournisseur to agentrelation
grant update on dbo.rubrique to agentrelation
grant update on dbo.sous_rubrique to agentrelation
go
grant delete on dbo.produit to agentrelation
grant delete on dbo.fournisseur to agentrelation
grant delete on dbo.rubrique to agentrelation
grant delete on dbo.sous_rubrique to agentrelation
go
grant insert on dbo.produit to agentrelation
grant insert on dbo.fournisseur to agentrelation
grant insert on dbo.rubrique to agentrelation
grant insert on dbo.sous_rubrique to agentrelation
go

/*************droit service commercial*********/

grant select on dbo.client to agentcommercial
grant select on dbo.commande to agentcommercial
grant select on dbo.bon_livraison to agentcommercial
grant select on dbo.facture to agentcommercial
go

grant update on dbo.client to agentcommercial
grant update on dbo.commande to agentcommercial
grant update on dbo.bon_livraison to agentcommercial
grant update on dbo.facture to agentcommercial
go

grant delete on dbo.client to agentcommercial
grant delete on dbo.commande to agentcommercial
grant delete on dbo.bon_livraison to agentcommercial
grant delete on dbo.facture to agentcommercial
go

grant insert on dbo.client to agentcommercial
grant insert on dbo.commande to agentcommercial
grant insert on dbo.bon_livraison to agentcommercial
grant insert on dbo.facture to agentcommercial
go

