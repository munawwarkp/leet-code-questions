# Write your MySQL query statement below
select
    query_name,
   ROUND( avg(cast(rating as decimal(10,2))/position),2)as quality,
   ROUND(
   100*sum(case when rating<3 then 1 else 0 end)/cast(count(*) as decimal(10,2))
    ,2) as poor_query_percentage
from Queries
group by query_name