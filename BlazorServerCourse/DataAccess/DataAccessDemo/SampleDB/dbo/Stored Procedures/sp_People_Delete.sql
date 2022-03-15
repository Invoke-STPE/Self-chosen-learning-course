CREATE PROCEDURE [dbo].[sp_People_Delete]
	@Id int
AS
begin 
	set nocount on;
	delete from dbo.People
	where Id = @Id;
end