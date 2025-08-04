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
	string version,
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
	
	if (!string.IsNullOrEmpty(version))
	{
		q = q.Where(t => t.VersionNumber == version);
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

Query(true, "Planificateur d'Anxiété Sociale", "1", null, null, new[] {"utilisateur"})
    .Dump("Problèmes résolus (par produit) + version + mots clefs");

Query(false, "Trader en Herbe","1", null, null, new[] {"transactions"})
    .Dump("Problèmes en cours (par produit) + version + mots clefs");
	
Query(null, "Maître des Investissements", "2", new DateOnly(2025,1,1), new DateOnly(2025,8,30), new[] {"erreur"})
    .Dump("Tous les problèmes (par produit) + version + mots clefs + période donnée");

Query(true, "Planificateur d'Entraînement", "1,1", new DateOnly(2025,7,1), new DateOnly(2025,8,1), new[] {"correctement"})
    .Dump("Problèmes résolus (par produit) + version + mots clefs + période donnée");


