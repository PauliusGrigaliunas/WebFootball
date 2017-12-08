
CREATE VIEW [dbo].[AllTiemsView]
	AS (SELECT [Name],[FirstTeamScore]
	FROM [TeamsTable] as a left outer join [GameTable] as b
	on a.[Id]=b.[FirstTeam]
	UNION
    SELECT [Name],[FirstTeamScore]
	FROM [TeamsTable] as a left outer join [GameTable] as b
	on a.[Id]=b.[SecondTeam]);





