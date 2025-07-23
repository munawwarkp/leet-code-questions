/* Write your T-SQL query statement below */
select sub.*
    from(
        select *
        from Cinema
        where description<>'boring'
        )sub
where sub.id%2<>0
 order by rating desc