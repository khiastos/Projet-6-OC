<Query Kind="Statements">
  <Connection>
    <ID>7a037fd4-2e07-4cab-8ff2-f9ba6fdc5f6a</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Driver Assembly="(internal)" PublicKeyToken="no-strong-name">LINQPad.Drivers.EFCore.DynamicDriver</Driver>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <SqlSecurity>true</SqlSecurity>
    <Server>(localdb)\MSSQLLocalDB</Server>
    <Database>NexaWorks</Database>
    <DisplayName>NexaWorks</DisplayName>
    <DriverData>
      <EncryptSqlTraffic>True</EncryptSqlTraffic>
      <PreserveNumeric1>True</PreserveNumeric1>
      <EFProvider>Microsoft.EntityFrameworkCore.SqlServer</EFProvider>
    </DriverData>
  </Connection>
</Query>

#nullable enable

IQueryable<Tickets> Query (
	bool? isResolved, 
	string product,
	DateOnly? start,
	DateOnly? end,
	string[]? keywords = null)
{
	var q = Tickets.AsQueryable();
	
	if (isResolved.HasValue)
	{
		q = q.Where(t => t.IsResolved == isResolved.Value);
	}
	
	if (!string.IsNullOrEmpty(product))
	{
		q = q.Where(t => t.ProductName == product);
	}
	
	if (start.HasValue && end.HasValue)
	{
		if (isResolved is false)
			q = q.Where(t => t.CreationDate >= start.Value 
			&& t.CreationDate <= end.Value);
		else
			q = q.Where(t => t.ResolutionDate >= start.Value 
			&& t.ResolutionDate <= end.Value);
	}
	
	if (keywords is not null && keywords.Length > 0)
	{
		q = q.Where(t =>
		keywords.All(kw => ((string)t.IssueDescription).Contains(kw))
		);
	}
	
return q;
}

Query(false, "Planificateur d'Anxiété Sociale", null, null, new[] {"correctement"})
    .Dump("Problèmes en cours (par produit) + toutes les versions + mots clefs");

Query(true, "Trader en Herbe", new DateOnly(2025,1,1), new DateOnly(2025,2,28), new[] {"erreur"})
    .Dump("Problèmes résolus (par produit) + toutes les versions + mots clefs");
	
Query(null, "Maître des Investissements", null, null, new[] {"achats"})
    .Dump("Tous les problèmes (par produit) + toutes les versions + mots clefs + période donnée");

Query(true, "Planificateur d'Entraînement", new DateOnly(2025,6,1), new DateOnly(2025,8,28), new[] {"bug"})
    .Dump("Problèmes résolus (par produit) + toutes les versions + mots clefs + période donnée");


