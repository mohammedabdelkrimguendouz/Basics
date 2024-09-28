
Declare @ReportMonth Int;
Declare @ReportYear Int;
Declare @TotalDays Int;
Declare @EmployeeID Int;
Declare @PresentDays Int;
Declare @AbsentDays Int;
Declare @LeaveDays Int;

set @ReportMonth=7;
set @ReportYear=2023;
set @EmployeeID=101;

set @TotalDays=Day (EOMonth (DATEFROMPARTS(@ReportYear,@ReportMonth,1)));

select @PresentDays = COUNT(*) from EmployeeAttendance 
Where EmployeeID=@EmployeeID And Month(AttendanceDate)=@ReportMonth And
Year(AttendanceDate)=@ReportYear And  Status='Present';

select @AbsentDays = COUNT(*) from EmployeeAttendance 
Where EmployeeID=@EmployeeID And Month(AttendanceDate)=@ReportMonth And
Year(AttendanceDate)=@ReportYear And  Status='Absent';

select @LeaveDays = COUNT(*) from EmployeeAttendance 
Where EmployeeID=@EmployeeID And Month(AttendanceDate)=@ReportMonth And
Year(AttendanceDate)=@ReportYear And  Status='Leave';

PRINT 'Employee Attendance Report for Employee ID: ' + CAST(@EmployeeID AS VARCHAR);
PRINT 'Report Month: ' + CAST(@ReportMonth AS VARCHAR) + '/' + CAST(@ReportYear AS VARCHAR);
PRINT 'Total Working Days: ' + CAST(@TotalDays AS VARCHAR);
PRINT 'Days Present: ' + CAST(@PresentDays AS VARCHAR);
PRINT 'Days Absent: ' + CAST(@AbsentDays AS VARCHAR);
PRINT 'Days on Leave: ' + CAST(@LeaveDays AS VARCHAR);
