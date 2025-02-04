CREATE TRIGGER ussSSActivityLogUpdate
   ON  ussSSActivityLog
   AFTER insert,update
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if (Select Count(*) from Inserted) > 1 
	Begin
		Return
	End 

    Declare @ActivityID Int,
		@CurrentState Int

Select @ActivityID = ActivityID From Inserted

Select top 1 @CurrentState = CurrentState
From ussSSActivityLog
Where ActivityID = @ActivityID
Order By StartDate 

Update ussSSActivity
Set CurrentStateID = @CurrentState
Where id = @ActivityID
And (CurrentStateID Is Null
Or CurrentStateID <> @CurrentState)

END

