<Query Kind="Expression">
  <Connection>
    <ID>47ecd2e9-66f8-4175-8a8a-6ca36dbab977</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

//3-Show all skills requiring a ticket and which employees have those skills. 
//Include all the data as seen in the following image. 
//Order the employees by years of experience (highest to lowest). 
//Use the following text for the levels: 0 = Novice, 1 = Proficient, 2 = Expert. (Hint: Use nested ternary operators to handle the levels as text.)


from row in Skills
where row.RequiresTicket //== true
select new
{
	row.Description,
	//row.EmployeeSkills,
	Employees = from person in row.EmployeeSkills
				where person.SkillID == row.SkillID
				orderby person.YearsOfExperience descending 
				select new
				{
					Name = person.Employee.FirstName+' '+ person.Employee.LastName,
					Level = person.Level==1?"Novice"
					: person.Level==2?"Proficient"
					: "Expert",
					YearExperience = person.YearsOfExperience 
				}
}