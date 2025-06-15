# Write your MySQL query statement below
with cusWithoutOrderId as
(
	select id from Customers
	except 
	select customerId from Orders
)
select name as Customers from Customers join cusWithoutOrderId
on Customers.id = cusWithoutOrderId.id
