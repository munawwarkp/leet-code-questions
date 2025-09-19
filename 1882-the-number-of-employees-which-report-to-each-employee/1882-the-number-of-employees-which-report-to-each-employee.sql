/* Write your T-SQL query statement below */
select 
    e.employee_id,
    e.name,
    COUNT(*) reports_count,
    round(cast(sum(d.age) as decimal(10,2))/count(*),0 ) as average_age
from Employees e
join
Employees d
on e.employee_id =d.reports_to
group by e.name,e.employee_id
order by e.employee_id