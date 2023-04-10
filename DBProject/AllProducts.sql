CREATE VIEW [dbo].[AllProducts]
AS
SELECT prod.[Name] AS ProductName
	  ,grp.[Name] AS GroupName
FROM [dbo].[GroupProductRelation] AS rel
LEFT JOIN [dbo].[Groups] AS grp ON rel.GroupId = grp.ID
LEFT JOIN [dbo].[Products] AS prod ON rel.ProductId = prod.ID