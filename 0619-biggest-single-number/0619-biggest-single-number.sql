-- /* Write your T-SQL query statement belo    


select 
	isnull(
		(select top 1 num from MyNumbers
		group by num
		having count(*) =1
		order by num desc
		),null
	) as num
