/* Write your T-SQL query statement below */
with RunningTotalCTE as (
    select 
        person_name,
        sum(weight) over (order by turn) as cumulative_weight
        from Queue
)
select top 1 person_name
from RunningTotalCTE
where cumulative_weight <= 1000
order by cumulative_weight desc
