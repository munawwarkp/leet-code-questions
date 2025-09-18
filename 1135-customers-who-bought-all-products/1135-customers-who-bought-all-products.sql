/* Write your T-SQL query statement below */
select customer_id
from(

select 
    customer_id,
    product_key,
    ROW_NUMBER() over(partition by customer_id order by product_key) row_count
from Customer
group by customer_id,product_key
) a
where row_count = (select count(*) from Product)