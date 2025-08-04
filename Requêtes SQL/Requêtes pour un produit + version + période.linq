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
	DateOnly? end)
{
	var q = Tickets.AsQueryable();
	
	if (isResolved.HasValue)
	{
		q = q.Where(t => t.IsResolved == isResolved.Value);
	}
	
	q = q.Where(t => (t.ProductName) == product);
	
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
	
return q;
}

Query(false, "Trader en Herbe", "1,2", null, null)
    .Dump("Problèmes en cours (par produit) + une version");

Query(true, "Maître des Investissements", "2", null, null)
    .Dump("Problèmes résolus (par produit) + une version");

Query(null, "Planificateur d'Entraînement","1", new DateOnly(2025,1,1), new DateOnly(2025,8,30))
    .Dump("Tous les problèmes (par produit) + une version + période donnée");

Query(true, "Planificateur d'Anxiété Sociale","1", new DateOnly(2025,1,1), new DateOnly(2025,8,30))
    .Dump("Problèmes résolus (par produit) + une version + période donnée");

