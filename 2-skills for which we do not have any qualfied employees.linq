<Query Kind="Expression">
  <Connection>
    <ID>5c651883-3d8c-4c73-8cca-2e7a81c2da81</ID>
    <Persist>true</Persist>
    <Server> DESKTOP-D47JLGO\SQLEXPRESS</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

//skills for which we do not have any qualfied employees
//Skills

//EmployeeSkills



//how do u tell something is null? in C# -- (thing == null) or (thing.property == null) ?  Ans. thing.Collection.Count == 0

from row in Skills 
where row.EmployeeSkills.Count == 0
select new
{
	row.Description
}