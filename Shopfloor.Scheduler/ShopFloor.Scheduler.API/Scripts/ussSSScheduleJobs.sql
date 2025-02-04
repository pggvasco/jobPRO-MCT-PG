CREATE PROCEDURE [dbo].[ussSSScheduleJobs] 
    @JobNumber VARCHAR(20) = ''
AS 
    BEGIN

        DECLARE @OperationCode VARCHAR(41) ;
        DECLARE @OperationDescription VARCHAR(103) ;
        DECLARE @WorkCentreRate FLOAT ;
        DECLARE @LocationCode VARCHAR(20) ;
        DECLARE @ActivityCode VARCHAR(20) ;
        DECLARE @ActivityDescription VARCHAR(50) ;

		DECLARE @DrawingCode VARCHAR(20) ;
	
        DECLARE @CustomerCode VARCHAR(20) ;
        DECLARE @CustomerDescription VARCHAR(50) ;

        DECLARE @IDJCMaster INT ;
        DECLARE @OperationID INT ;
        DECLARE @CostCentreID INT ;
        DECLARE @JobID INT ;
        DECLARE @CustomerID INT ;
        DECLARE @Sequence INT ;
        DECLARE @PartID INT ;
        DECLARE @DrawingID INT ;
        
        SET @Sequence = 1;

        DECLARE @JobDate DATETIME ;
        DECLARE @RequiredDate DATETIME ;
        DECLARE @StartDate DATETIME ;
               
        DECLARE @JobDescription VARCHAR(50) ;
		DECLARE @JobLineDescription VARCHAR(50) ;

        DECLARE @EstimatedMinutes FLOAT;
        DECLARE @OrderPrice FLOAT ;
        DECLARE @EstimatedOperationCost FLOAT ;

        DECLARE JobCursor CURSOR
            FOR SELECT  ussLocation.Code,
                        ussWorkCentre.HourlyRate,
                        ussDrawingNumber.Code,
                        ussActivity.Code,
                        ussActivity.Description,
                        ussJobFileLine.Description_01,
                        ussWorkCentre.Code,
                        ussWorkCentre.Description,
                        ussJobFile.JobDate,
                        ussJobFile.Description_01,
                        ussJobFile.PlanDelDate,
                        ussJobFile.Total,
                        ussJobFileLine.PurchasePrice,
                        Client.Account,
                        Client.Name,
                        ussJobFile.idJCMaster,
                        ussJobFileLine.Minutes
                FROM    ussJobFile
                        LEFT JOIN ussJobFileLine ON idJob = ussJobFile.id
                        LEFT JOIN ussWorkCentre ON ussWorkCentre.id = idWorkCentre
                        LEFT JOIN ussLocation ON ussLocation.id = ussJobFile.idLocation
                        LEFT JOIN ussActivity ON ussActivity.id = idActivity
                        LEFT JOIN ussDrawingNumber ON ussDrawingNumber.id = idDrawingNo
                        LEFT JOIN Client ON Client.DCLink = idAccount
                WHERE   idCalcType = 3
                        AND JobNo = @JobNumber

        OPEN JobCursor ;

        FETCH NEXT FROM JobCursor INTO @LocationCode, @WorkCentreRate,@DrawingCode, @ActivityCode, @ActivityDescription, @JobLineDescription, @OperationCode, @OperationDescription, @JobDate, @JobDescription, @RequiredDate, @OrderPrice, @EstimatedOperationCost, @CustomerCode, @CustomerDescription, @IDJCMaster, @EstimatedMinutes

        WHILE @@FETCH_STATUS = 0
            BEGIN
            
				IF (@Sequence = 1)
					BEGIN
						SET @StartDate = @JobDate;
					END
    
                IF ( SELECT COUNT(id)
                     FROM   ussSSCustomer
                     WHERE  Code = @CustomerCode
                   ) = 0 
                    BEGIN
                        INSERT  INTO ussSSCustomer ( Code, Description )
                        VALUES  (
                                  @CustomerCode,
                                  @CustomerDescription
                                )
                    END

                SELECT  @CustomerID = id
                FROM    ussSSCustomer
                WHERE   Code = @CustomerCode
                
                  IF ( SELECT COUNT(id)
                     FROM   ussSSDrawing
                     WHERE  Code = @DrawingCode
                   ) = 0 
                    BEGIN
                        INSERT  INTO ussSSDrawing
                                (
                                  Code
                                )
                        VALUES  (
                                @DrawingCode
                                ) ;
                    END
                    
                SELECT  @DrawingID = id
                FROM    ussSSDrawing
                WHERE   Code = @DrawingCode

                IF ( SELECT COUNT(id)
                     FROM   ussSSJob
                     WHERE  Number = @JobNumber
                   ) = 0 
                    BEGIN
                        INSERT  INTO ussSSJob
                                (
                                  Number,
                                  Description,
                                  JobDate,
                                  RequiredDeliveryDate,
                                  OrderPrice,
                                  CustomerID,
                                  JobCardID,
                                  DrawingID
                                ) 
                        VALUES  (
                                  @JobNumber,
                                  @JobDescription,
                                  @JobDate,
                                  @RequiredDate,
                                  @OrderPrice,
                                  @CustomerID,
                                  @IDJCMaster,
                                  @DrawingID
                                )
                    END
                    
                    
                SELECT  @JobID = id
                FROM    ussSSJob
                WHERE   Number = @JobNumber


                IF ( SELECT COUNT (id)
                     FROM   ussSSCostCentre
                     WHERE  Code = @LocationCode 
                   ) = 0
                     BEGIN
                        INSERT  INTO ussSSCostCentre
                                (
                                  Code,
                                  Description,
                                  TransactionCode
                                )
                        VALUES  (
                                  @LocationCode,
                                  @LocationCode,
                                  @LocationCode
                                ) ;
                    END
                  
                                 
                 IF ( SELECT COUNT(id)
                     FROM   ussSSPart
                     WHERE  Code = @ActivityCode
                   ) = 0 
                    BEGIN
                        INSERT  INTO ussSSPart
                                (
                                  Code,
                                  Description
                                )
                        VALUES  (
                                  @ActivityCode,
                                  @ActivityDescription
                                ) ;
                    END
                    
                SELECT  @PartID = id
                FROM    ussSSPart
                WHERE   Code = @ActivityCode
                    
                IF ( SELECT COUNT(id)
                     FROM   ussSSOperation
                     WHERE  Code = @OperationCode
                   ) = 0 
                    BEGIN
                        SELECT  @CostCentreID = id
                        FROM    ussSSCostCentre
                        WHERE   Code = @LocationCode
                        
                        INSERT  INTO ussSSOperation
                                (
                                  Code,
                                  [Description],
                                  Rate,
                                  ServiceCode,
                                  CostCentreID
                                )
                        VALUES  (
                                  @OperationCode,
                                  @OperationDescription,
                                  @WorkCentreRate,
                                  @OperationCode,
                                  @CostCentreID
                                ) ;
                    END

                SELECT  @OperationID = id
                FROM    ussSSOperation
                WHERE   Code = @OperationCode

                INSERT  INTO ussSSActivity
                        (
                          OperationID,
                          JobID,
                          PartID ,
                          [Description],
                          EstimatedStartDate,
                          Sequence,
                          EstimatedOperationCost,
                          EstimatedDuration
                        )
                VALUES  (
                          @OperationID,
                          @JobID,
                          @PartID,
                          @JobLineDescription,
                          @StartDate,
                          @Sequence,
                          @EstimatedOperationCost,
                          @EstimatedMinutes
                        )
	
				SET @Sequence = @Sequence + 1;
				SET @StartDate = DATEADD("n", @EstimatedMinutes, @StartDate);
	
                FETCH NEXT FROM JobCursor INTO @LocationCode, @WorkCentreRate,@DrawingCode, @ActivityCode, @ActivityDescription, @JobLineDescription, @OperationCode, @OperationDescription, @JobDate, @JobDescription, @RequiredDate, @OrderPrice, @EstimatedOperationCost, @CustomerCode, @CustomerDescription, @IDJCMaster, @EstimatedMinutes
            END

        CLOSE JobCursor ;
        DEALLOCATE JobCursor ;
    END


