CREATE PROCEDURE [dbo].[SP_Adresse_Update]
	@adRue NVARCHAR(60),
	@adNum NVARCHAR(6),
  @adCp int,
  @adVille NVARCHAR(60),
  @adPays NVARCHAR(60),
  @email NVARCHAR(60),
  @numTel int,
  @Id int
AS
	UPDATE [Adresse] SET [AdRue] = @adRue,[AdNum] =@adNum,[AdCp]=@adCp,[AdVille]=@adVille,[AdPays]=@adPays,[NumTel]=@numTel,[EMail]=@email
  WHERE Id=@Id
