CREATE PROCEDURE [dbo].[spPeople_ReadOne]
	@Id int
AS
begin
	select [Id], [FirstName], [LastName], [DateOfBirth]
	from dbo.People
	where Id = @Id;
end
