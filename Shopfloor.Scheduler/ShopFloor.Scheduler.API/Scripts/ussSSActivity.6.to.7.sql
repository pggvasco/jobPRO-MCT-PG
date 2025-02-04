Update ussSSActivity
Set CurrentStateID = 
Case when (Select top 1 CurrentState
From ussSSActivityLog
Where ActivityID = ussSSActivity.ID
Order By StartDate ) Is Null Then 0 Else (Select top 1 CurrentState
From ussSSActivityLog
Where ActivityID = ussSSActivity.ID
Order By StartDate ) End