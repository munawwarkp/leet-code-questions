/* Write your T-SQL query statement below */
 
 select 
	s.user_id,
	cast(ISNULL(
		SUM(case when action='confirmed' then 1 end)*1.00/
		count(*),0) as decimal(16,2))
		
		as confirmation_rate
	from Signups s
	left join Confirmations c
	on s.user_id = c.user_id
	group  by s.user_id
