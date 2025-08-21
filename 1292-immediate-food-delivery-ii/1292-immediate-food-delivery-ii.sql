with rankCte as (
select *,
		RANK() over (partition by customer_id order by order_date asc) as rk
from Delivery
)
select ROUND( sum(case when order_date = customer_pref_delivery_date then 1.00 else 0 end)*100/(select COUNT(distinct customer_id) from Delivery), 2) as immediate_percentage
from rankCte
where rk = 1