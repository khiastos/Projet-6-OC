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

IQueryable<object> Query(
    bool? isResolved,
    string product,
    string version,
    DateOnly? start,
    DateOnly? end)
{
    var q = Tickets
        .Include(t => t.ProductBuild)
            .ThenInclude(pb => pb.Product)
        .Include(t => t.ProductBuild)
            .ThenInclude(pb => pb.ProductVersion)
        .Include(t => t.ProductBuild)
            .ThenInclude(pb => pb.OperatingSystem)
        .AsQueryable();
	
	q = q.Where(t => t.ProductBuild.Product.Name == product);
	
    if (isResolved.HasValue)
    {
        q = q.Where(t => t.IsResolved == isResolved.Value);
    }

    if (!string.IsNullOrEmpty(version))
    {
        q = q.Where(t => t.ProductBuild.ProductVersion.VersionNumber == version);
    }

    if (start.HasValue && end.HasValue)
    {
        if (isResolved is false)
        {
            q = q.Where(t => t.CreationDate >= start.Value && t.CreationDate <= end.Value);
        }
        else
        {
            q = q.Where(t => t.ResolutionDate >= start.Value && t.ResolutionDate <= end.Value);
        }
    }

    return q.Select(t => new
    {
        t.Id,
        ProductName = t.ProductBuild.Product.Name,
        VersionNumber = t.ProductBuild.ProductVersion.VersionNumber,
        OperatingSystemName = t.ProductBuild.OperatingSystem.Name,
        t.CreationDate,
        ResolutionDate = t.ResolutionDate == default ? "/" : t.ResolutionDate.ToString(),
        Statut = t.IsResolved ? "Résolu" : "En cours",
        t.IssueDescription,
        ResolutionDescription = string.IsNullOrEmpty(t.ResolutionDescription) ? "/" : t.ResolutionDescription
    });
}


Query(false, "Trader en Herbe", "1.2", null, null)
    .Dump("Problèmes en cours (par produit) + une version");

Query(true, "Maître des Investissements", "2.0", null, null)
    .Dump("Problèmes résolus (par produit) + une version");

Query(null, "Planificateur d'Entraînement","1.0", new DateOnly(2025,1,1), new DateOnly(2025,8,30))
    .Dump("Tous les problèmes (par produit) + une version + période donnée");

Query(true, "Planificateur d'Anxiété Sociale","1.0", new DateOnly(2025,1,1), new DateOnly(2025,8,30))
    .Dump("Problèmes résolus (par produit) + une version + période donnée");

