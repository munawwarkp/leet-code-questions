
select 
    s.product_id,
    s.year as first_year,
   s.quantity,
    s.price 
from Sales s
join
(
    
select 
    product_id,
    MIN(year) as year
from Sales
group  by product_id
) t
on s.product_id = t.product_id
and s.year = t.year
