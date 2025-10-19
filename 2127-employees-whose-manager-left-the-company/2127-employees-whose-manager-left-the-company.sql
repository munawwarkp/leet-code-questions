/* Write your T-SQL query statement below */
select 
	employee_id
from Employees
where Employees.salary<30000
and Employees.manager_id not in (select employee_id from Employees)
order by employee_id