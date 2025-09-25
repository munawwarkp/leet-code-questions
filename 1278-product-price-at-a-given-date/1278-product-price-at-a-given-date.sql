# Write your MySQL query statement below
select 
    product_id,
    10 as price
from Products p
group by product_id
HAVING MIN(p.change_date) > '2019-08-16'

union all

select 
   a.product_id,
   a.new_price
from Products a
join
    (
        select
            product_id,
            MAX(change_date) as max_date
        from 
        Products
        where change_date <= '2019-08-16'
        group by product_id
    ) b
on a.product_id = b.product_id
and a.change_date = b.max_date

