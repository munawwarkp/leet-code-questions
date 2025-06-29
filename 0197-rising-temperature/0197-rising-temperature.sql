/* Write your T-SQL query statement below */
select yesterday.id from  Weather yesterday
join Weather today
on datediff(DAY,today.recordDate,yesterday.recordDate) = 1 
where yesterday.temperature>today.temperature