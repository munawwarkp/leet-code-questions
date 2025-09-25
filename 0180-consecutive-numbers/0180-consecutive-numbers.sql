/* Write your T-SQL query statement below */
select 
    distinct a.num as ConsecutiveNums 
from Logs a
join Logs b on a.id = b.id + 1
join Logs c on b.id+2 = c.id
where a.num=b.num and a.num = c.num