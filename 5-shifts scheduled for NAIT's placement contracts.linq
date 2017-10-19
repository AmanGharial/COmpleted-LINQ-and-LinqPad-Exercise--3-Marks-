<Query Kind="Expression">
  <Connection>
    <ID>5c651883-3d8c-4c73-8cca-2e7a81c2da81</ID>
    <Persist>true</Persist>
    <Server> DESKTOP-D47JLGO\SQLEXPRESS</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

/*From the shifts scheduled for NAIT's placement contracts, 
show the number of employees needed for each day (ordered by day-of-week).
of the day of week (Sunday, as the first day of the week, is number zero) 
and the number of employees needed.*/


from row in Shifts
where row.PlacementContract.Location.Name.Contains("Nait")
group row by row.DayOfWeek into result
select new
{
	DayOfWeek = result.Key==0?"Sun"
				: result.Key==1?"Mon"
				: result.Key==2?"Tue"
				: result.Key==3?"Wed"
				: result.Key==4?"Thu"
				: result.Key==5?"Fri"
				: "Sat",
	NumberOfEmployees = result.Sum(a => a.NumberOfEmployees)
}