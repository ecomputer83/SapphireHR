USE SapphireHR;
GO
DROP PROCEDURE IF EXISTS dbo.removePerformanceReview;
GO
CREATE PROCEDURE removePerformanceReview (
	@p0 int
)
AS
BEGIN TRANSACTION;  
	Delete from EmployeeProffesionalExcellence where EmployeeId = @p0
	Delete from EmployeePersonalExcellence where EmployeeId = @p0
	Delete from EmployeeTrainingRequirement where EmployeeId = @p0
	Delete from EmployeeObservation where EmployeeId = @p0
	Delete from EmployeeInitiativeAchievement where EmployeeId = @p0
	Delete from EmployeePersonalGoals where EmployeeId = @p0
	Delete from EmployeeProfGoalAchieved where EmployeeId = @p0
	Delete from EmployeeProfGoalPlan where EmployeeId = @p0
	Delete from EmployeeRoleComment where EmployeeId = @p0
	Delete from EmployeeResponsibilityComment where EmployeeId = @p0
	Delete from EmployeeHODImprovementComment where EmployeeId = @p0
	Delete from EmployeeROImprovementComment where EmployeeId = @p0

COMMIT;
GO