<Query Kind="Expression">
  <Connection>
    <ID>47ecd2e9-66f8-4175-8a8a-6ca36dbab977</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

//skills for which we do not have any qualfied employees

//how do u tell something is null? 
// in C# -- (thing == null) or (thing.property == null) ?  
// Ans. thing.Collection.Count == 0

from row in Skills 
where row.EmployeeSkills.Count == 0
select new
{
	row.Description
}