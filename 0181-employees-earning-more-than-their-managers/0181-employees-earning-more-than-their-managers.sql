# Write your MySQL query statement below
with salTable as
(
    select 
    emp.name as Employee,
    emp.salary as empSalary,
    man.name as Manager,
    man.salary as manSalary
    from Employee emp
     join Employee man
    on emp.managerId = man.id

)
select Employee from salTable
where empSalary > manSalary