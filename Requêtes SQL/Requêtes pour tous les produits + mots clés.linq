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
	bool isResolved, 
	string[]? keywords = null)
{
	var q = Tickets.Where(t => t.IsResolved == isResolved);

	if (keywords is not null && keywords.Length > 0)
	{
		q = q.Where(t =>
		keywords.All(kw => ((string)t.IssueDescription).Contains(kw))
		);
	}
return q;
}

Query(false)
    .Dump("Problèmes en cours (tous produits)");

Query(true)
    .Dump("Problèmes résolus (tous produits)");
	
Query(false, new [] {"mise à jour"})
    .Dump("Problèmes en cours (tous produits) + mots clés");
	
Query(true, new [] {"erreur"})
    .Dump("Problèmes résolus (tous produits) + mots clés");


