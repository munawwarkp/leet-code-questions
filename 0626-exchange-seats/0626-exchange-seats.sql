select 
	case
		when id%2=0 then id-1
        WHEN id % 2 = 1 AND id <> (SELECT MAX(id) FROM Seat) THEN id + 1
		else 
		id
	end as id,
	student
from Seat
order by id asc
