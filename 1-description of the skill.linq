<Query Kind="Expression">
  <Connection>
    <ID>5c651883-3d8c-4c73-8cca-2e7a81c2da81</ID>
    <Persist>true</Persist>
    <Server> DESKTOP-D47JLGO\SQLEXPRESS</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

//LINQ and LinqPad Exercise (3 Marks)
//List all skills, alphabetically, showing only the description of the skill.
from skill in Skills
orderby skill.Description 
select new
{
	skill.Description
}

//following is descending
/*
from skill in Skills
orderby skill.Description descending
select new
{
	skill.Description
}
*/