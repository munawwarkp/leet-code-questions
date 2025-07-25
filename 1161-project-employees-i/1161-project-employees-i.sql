/* Write your T-SQL query statement below */
select
    p.project_id,
    round(
    AVG(cast(e.experience_years as decimal(10,2)))
    ,2) as average_years
from Project p
left join Employee e
on p.employee_id=e.employee_id
group by p.project_id
