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
    bool isResolved,
    string[]? keywords = null)
{
    var q = Tickets
        .Include(t => t.ProductBuild)
            .ThenInclude(pb => pb.Product)
        .Include(t => t.ProductBuild)
            .ThenInclude(pb => pb.ProductVersion)
        .Include(t => t.ProductBuild)
            .ThenInclude(pb => pb.OperatingSystem)
        .Where(t => t.IsResolved == isResolved);

    if (keywords is not null && keywords.Length > 0)
    {
        q = q.Where(t =>
            keywords.All(kw =>
                t.IssueDescription != null && t.IssueDescription.Contains(kw)));
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


Query(false)
    .Dump("Problèmes en cours (tous produits)");

Query(true)
    .Dump("Problèmes résolus (tous produits)");
	
Query(false, new [] {"mise à jour"})
    .Dump("Problèmes en cours (tous produits) + mots clés");
	
Query(true, new [] {"erreur"})
    .Dump("Problèmes résolus (tous produits) + mots clés");


