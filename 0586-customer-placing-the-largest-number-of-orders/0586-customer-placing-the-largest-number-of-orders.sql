/* Write your T-SQL query statement below */
with highestOrder as
(
    select customer_number,count(1) as count_num from Orders
    group by(customer_number)
)
select customer_number from highestOrder
order by count_num desc
offset 0 rows fetch next 1 row only