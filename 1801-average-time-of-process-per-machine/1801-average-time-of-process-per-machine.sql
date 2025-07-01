/* Write your T-SQL query statement below */
select a.machine_id, round(AVG(a.timestamp-b.timestamp),3) as processing_time from Activity a
left join Activity b
on a.machine_id=b.machine_id and a.process_id=b.process_id and a.activity_type='end' and b.activity_type='start'
where b.timestamp is not null
group by a.machine_id
