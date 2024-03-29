  select a.productid, count(*) as [Count]
  from (select distinct(productid) from dbo.Sales) a
  left join
  (select aa.*, ab.productid from
  (select customerid, min(datetime) as [datetime] from dbo.Sales group by customerid) aa
  join dbo.Sales ab on aa.customerid = ab.customerid and aa.datetime = ab.datetime) b on a.productid = b.productid
  group by a.productid
  order by [Count] desc
 