# Write your MySQL query statement below
with firstRow as
(
    select
    player_id,
    event_date,
    row_number() over (partition by player_id order by event_date) as row_num
    from Activity
)

select player_id,event_date as first_login from firstRow
where row_num = 1
