# Write your MySQL query statement below
select name,bonus from Employee 
left outer join Bonus
on  Employee.empId = Bonus.empId 
where bonus is null or bonus < 1000