Create View ussSFArchiveYear
As

Select ROW_NUMBER() OVER(ORDER BY Year(JobDate) Asc) id, Year(JobDate) Year
From ussSFJob with(nolock)
Where StateID =9
Group By Year(JobDate)