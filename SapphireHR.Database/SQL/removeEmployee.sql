USE SapphireHR;
GO
DROP PROCEDURE IF EXISTS dbo.removeEmployee;
GO
CREATE PROCEDURE removeEmployee (
	@p0 int
)
AS
BEGIN TRANSACTION;  
	Delete from EmployeeTravels where EmployeeId = @p0
	Delete from EmployeeTransfers where EmployeeId = @p0
	Delete from EmployeeTimetables where EmployeeId = @p0
	Delete from EmployeeSalaries where EmployeeId = @p0
	Delete from EmployeeTerminations where EmployeeId = @p0
	Delete from EmployeeResignations where EmployeeId = @p0
	Delete from EmployeePensions where EmployeeId = @p0
	Delete from EmployeeLeaves where EmployeeId = @p0
	Delete from EmployeeFamilies where EmployeeId = @p0
	Delete from EmployeeExperiences where EmployeeId = @p0
	Delete from EmployeeEmergencies where EmployeeId = @p0
	Delete from EmployeeEducations where EmployeeId = @p0
	Delete from EmployeeBank where EmployeeId = @p0
	Delete from Employees where Id = @p0

COMMIT;
GO