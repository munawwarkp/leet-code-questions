/* Write your T-SQL query statement below */
select customer_id,count(1) as count_no_trans  from Visits
left outer join Transactions
on Visits.visit_id = Transactions.visit_id
where transaction_id is null
group by customer_id