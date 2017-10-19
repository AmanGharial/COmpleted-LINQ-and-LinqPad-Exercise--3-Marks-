<Query Kind="Expression">
  <Connection>
    <ID>5c651883-3d8c-4c73-8cca-2e7a81c2da81</ID>
    <Persist>true</Persist>
    <Server> DESKTOP-D47JLGO\SQLEXPRESS</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

/*List all employees with multiple skills; ignore employees with only one skill. 
Show the name of the employee and the list of their skillsets; 
for each skill, show the name of the skill, the level of competance and
the years of experience. Use the following text for the
levels: 0 = Novice, 1 = Proficient, 2 = Expert.*/

from person in Employees
where person.EmployeeSkills.Count>1
select new
{
	Name = person.FirstName+" "+person.LastName,
	Skills = from personskill in person.EmployeeSkills
				select new
				{
					personskill.Skill.Description,
					Level=personskill.Level==1?"Novice":personskill.Level==2?"Proficient":"Expert",
					YearExperience = personskill.YearsOfExperience
				}
}