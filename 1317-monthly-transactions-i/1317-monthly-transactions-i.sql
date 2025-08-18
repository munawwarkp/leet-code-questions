
select 
	FORMAT(trans_date,'yyy-MM')as month,
	country,
	COUNT(*) as trans_count,
	sum(case when state='approved' then 1 else 0 end) as approved_count,
	SUM(amount) as trans_total_amount,
	SUM(case when state='approved' then amount else 0 end) as approved_total_amount
from 
	Transactions
group by country,FORMAT(trans_date,'yyy-MM')
