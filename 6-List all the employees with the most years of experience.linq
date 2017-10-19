<Query Kind="Expression">
  <Connection>
    <ID>5c651883-3d8c-4c73-8cca-2e7a81c2da81</ID>
    <Persist>true</Persist>
    <Server> DESKTOP-D47JLGO\SQLEXPRESS</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

//List all the employees with the most years of experience.


from row in EmployeeSkills
group row by new
		{
			row.Employee.EmployeeID,
			row.Employee.FirstName,
			row.Employee.LastName
		}
	into empData
where empData.Sum(x => x.YearsOfExperience) ==
	(from y in Employees select y.EmployeeSkills.Sum(z => z==null?0 : z.YearsOfExperience)).Max()
select new
		{
			Name = empData.Key.FirstName+" "+empData.Key.LastName,
			YOE = empData.Sum(x => x.YearsOfExperience)
		}
								
