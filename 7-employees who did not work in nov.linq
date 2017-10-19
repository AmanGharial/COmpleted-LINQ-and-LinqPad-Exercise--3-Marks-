<Query Kind="Expression">
  <Connection>
    <ID>5c651883-3d8c-4c73-8cca-2e7a81c2da81</ID>
    <Persist>true</Persist>
    <Server> DESKTOP-D47JLGO\SQLEXPRESS</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

/*7. List the names of all employees who did not work in
November. Show the name in the format of
"LastName, FirstName" and sort it by last name and then */

//Employees
//Schedules

from x in Employees
	orderby x.LastName 
	where !(from y in Schedules 
				where y.Day.Month == 11
				select y.EmployeeID)
				.Contains(x.EmployeeID)
			select x.LastName+", "+x.FirstName