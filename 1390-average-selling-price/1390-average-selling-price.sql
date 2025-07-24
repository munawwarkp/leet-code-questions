select  product_id,ISNULL(round( cast (sumof as float)/units ,2),0) as average_price
from 
   (
    select 
        sum(us.units*p.price) as sumof,
        SUM(us.units) as units,
        p.product_id 
    from Prices p
    left join UnitsSold us
    on p.product_id=us.product_id and us.purchase_date between p.start_date and p.end_date
    group by p.product_id
    ) sub
