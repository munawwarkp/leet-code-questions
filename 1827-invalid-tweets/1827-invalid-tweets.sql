/* Write your T-SQL query statement below */
select tweet_id from Tweets
where DATALENGTH(content)>15