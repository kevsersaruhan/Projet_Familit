CREATE PROCEDURE [dbo].[SP_Showroom_Delete]
	@id int
AS

	Declare @AdresseIds Table (
		AdresseId int
	);

	Print 'Récupération des Adresse Id du personnel';
	insert into @AdresseIds (AdresseId)
	select AdresseId from Personnel
	where ShowroomId = @id;

	Print 'Suppression du personnel du ShowRoom';
	Delete From Personnel where ShowroomId = @id;
	Print 'Suppression des adresses du personnel';
	Delete From Adresse Where Id in (Select AdresseId from @AdresseIds)

	Declare @AdresseId int;
	Select @AdresseId = @AdresseId from Showroom where Id = @id;

	Print 'Suppresion du ShowRoom';
	Delete From Showroom where Id = @id;
	Print 'Suppression de l''adresse du ShowRoom';
	Delete From Adresse where Id = @AdresseId;

