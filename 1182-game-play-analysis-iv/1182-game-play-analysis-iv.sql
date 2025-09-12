with rankActivity as(
select 
	a.player_id as aPlayer_id,
	MIN(a.event_date) as firstLogin,
	b.player_id as bPlayer_id,
	b.event_date as bEventDate
from Activity a
join
Activity b
on a.event_date < b.event_date and a.player_id=b.player_id
group by a.player_id,b.player_id,b.event_date
)
select
	round(
		CAST(COUNT(distinct aPlayer_id) as decimal(10,2))/ 
		CAST(( select count(distinct player_id) from Activity) as decimal(10,2)),
	2) as fraction
from rankActivity
where DATEDIFF(DAY,firstLogin,bEventDate)=1