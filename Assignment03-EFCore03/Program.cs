namespace Assignment03_EFCore03
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // using CompanyDbContext dbContext = new CompanyDbContext();

            #region Loading Related Data 

            #region Example 01
            //var Emp01 = dbContext.Employees.FirstOrDefault(E => E.EmpId == 20);

            //if(Emp01 is not null)
            //{
            //	Console.WriteLine($"Employee Name = {Emp01.EmpName}"); // Sama
            //	Console.WriteLine($"Employee Department Id = {Emp01.DepartmentId}"); // 20
            //	Console.WriteLine($"Employee Department Name = {Emp01.EmployeeDepartment?.DeptName}"); // NULL

            //	var EmpDepartment = dbContext.Departments.FirstOrDefault(D => D.DeptId == Emp01.DepartmentId);
            //	Console.WriteLine($"Employee Department Name = {EmpDepartment?.DeptName}"); // HR

            //} 
            #endregion

            #region Example 02

            //var Emp01 = dbContext.Employees.Select(E=> new { E.EmpId , E.EmpName , E.DepartmentId , E.EmployeeDepartment.DeptName })
            //	.FirstOrDefault(E => E.EmpId == 20);
            //// EF Core automatically generates the necessary JOIN in SQL when you project a navigation property inside .Select()

            //if (Emp01 is not null)
            //{
            //	Console.WriteLine($"Employee Name = {Emp01.EmpName}"); // Sama
            //	Console.WriteLine($"Employee Department Id = {Emp01.DepartmentId}"); // 20
            //	Console.WriteLine($"Employee Department Name = {Emp01.DeptName}"); // HR
            //}

            #endregion

            #region Eager Loading 

            #region Example 01
            //var Emp01 = dbContext.Employees.Include(E => E.EmployeeDepartment)
            //	                           .FirstOrDefault(E => E.EmpId == 20);

            //if(Emp01 is not null)
            //{
            //	Console.WriteLine($"Employee Name = {Emp01.EmpName}"); // Sama
            //	Console.WriteLine($"Employee Department Id = {Emp01.DepartmentId}"); // 20
            //	Console.WriteLine($"Employee Department Name = {Emp01.EmployeeDepartment?.DeptName}"); // HR
            //	Console.WriteLine($"Employee Department Name = {Emp01.EmployeeDepartment?.DateOfCreation}"); // 10/30/2025 12:00:00 AM
            //} 
            #endregion

            #region Example 02

            //var EmployeeWithManagedDepartment = dbContext.Employees.Include(x => x.ManagedDepartment)
            //													   .FirstOrDefault(E => E.EmpId == 20);

            //if (EmployeeWithManagedDepartment is not null)
            //{
            //	Console.WriteLine($"Employee Name = {EmployeeWithManagedDepartment.EmpName}"); // Sama
            //	Console.WriteLine($"Employee Department Id = {EmployeeWithManagedDepartment.DepartmentId}"); // 20
            //	Console.WriteLine($"Employee Department Name = {EmployeeWithManagedDepartment.EmployeeDepartment?.DeptName}"); // NULL
            //	Console.WriteLine($"Employee Managed Department Id = {EmployeeWithManagedDepartment.ManagedDepartment?.DeptId}"); // 50
            //	Console.WriteLine($"Employee Managed Department Name = {EmployeeWithManagedDepartment.ManagedDepartment?.DeptName}"); // IT
            //}

            #endregion

            #region Example 03

            //var Student = dbContext.Students.Include(S => S.StdCourses)
            //	                            .ThenInclude(SC => SC.Course)
            //								.FirstOrDefault(S => S.StudentId == 1);


            //if(Student  is not null)
            //{
            //	Console.WriteLine($"Student Id : {Student.StudentId}"); //1 
            //	Console.WriteLine($"Student Name : {Student.SName}"); // Aliaa
            //	Console.WriteLine("Student Courses : ");
            //	foreach(var course in Student.StdCourses)
            //	{
            //		Console.WriteLine("Course Details :");
            //		Console.WriteLine($"Course Id: {course.CourseId}");
            //		Console.WriteLine($"Course Name : {course.Course?.CName}");
            //		Console.WriteLine($"Course Grade : {course.Grade}");
            //		Console.WriteLine("=====================");
            //	}	
            //}


            #endregion
            #endregion

            #region Explicit Loading 

            #region Example 01
            //var Employee = dbContext.Employees.FirstOrDefault(E => E.EmpId == 20);
            //if(Employee is not null)
            //{
            //	Console.WriteLine($"Employee Name :{Employee.EmpName}"); // Sama 
            //	Console.WriteLine($"Department Id : {Employee.DepartmentId}"); //20

            //	dbContext.Entry(Employee).Reference(E => E.EmployeeDepartment).Load();
            //	Console.WriteLine($"Department Name : {Employee.EmployeeDepartment?.DeptName}"); // HR
            //} 
            #endregion

            #region Example 02


            //var Department = dbContext.Departments.FirstOrDefault(E => E.DeptId == 20);
            //if(Department is not null)
            //{
            //	Console.WriteLine($"Department Id : {Department.DeptId}"); // 20
            //	Console.WriteLine($"Department Name : {Department.DeptName}"); // HR

            //	dbContext.Entry(Department).Collection(D => D.Employees)
            //		                             .Query().Where(E=>E.Age > 27).Load();
            //	foreach (var employee in Department.Employees)
            //	{
            //		Console.WriteLine($"{employee.EmpName}");
            //	}
            //}

            #endregion

            #endregion

            #region Lazy Loading 
            //var Emp01 = dbContext.Employees.FirstOrDefault(e => e.EmpId == 20);


            //if (Emp01 is not null)
            //{
            //	Console.WriteLine($"Employee Name = {Emp01.EmpName}"); // Sama
            //	Console.WriteLine($"Employee Department Id = {Emp01.DepartmentId}"); // 20
            //	Console.WriteLine($"Employee Department Name = {Emp01.EmployeeDepartment?.DeptName}"); // HR
            //}
            #endregion
            #endregion

            #region Join Operators

            #region Join() - Inner Join

            #region Example 01
            //var DepartmentsWithEmployees = dbContext.Departments
            //	                              .Join(dbContext.Employees  , 
            //								  D=>D.DeptId , 
            //								  E=>E.DepartmentId ,
            //								  (D , E) => new
            //								  {
            //									  EmployeeId = E.EmpId,
            //									  EmployeeName = E.EmpName,
            //									  DepartmentId = D.DeptId,
            //									  DepartmentName = D.DeptName
            //								  });

            //DepartmentsWithEmployees = from D in dbContext.Departments
            //						   join E in dbContext.Employees
            //						   on D.DeptId equals E.DepartmentId
            //						   select new
            //						   {
            //							   EmployeeId = E.EmpId,
            //							   EmployeeName = E.EmpName,
            //							   DepartmentId = D.DeptId,
            //							   DepartmentName = D.DeptName
            //						   };

            //foreach (var item in DepartmentsWithEmployees)
            //	Console.WriteLine(item); 
            #endregion

            #region Example 02
            //var DepartmentsWithManager = dbContext.Departments
            //								  .Join(dbContext.Employees,
            //								  D => D.DeptManagerId,
            //								  E => E.EmpId,
            //								  (D, E) => new
            //								  {
            //									  EmployeeId = E.EmpId,
            //									  EmployeeName = E.EmpName,
            //									  DepartmentId = D.DeptId,
            //									  DepartmentName = D.DeptName
            //								  });

            //DepartmentsWithManager = from D in dbContext.Departments
            //						   join E in dbContext.Employees
            //						   on D.DeptManagerId equals E.EmpId
            //						   select new
            //						   {
            //							   EmployeeId = E.EmpId,
            //							   EmployeeName = E.EmpName,
            //							   DepartmentId = D.DeptId,
            //							   DepartmentName = D.DeptName
            //						   };

            //foreach (var item in DepartmentsWithManager)
            //	Console.WriteLine(item);
            #endregion

            #endregion

            #region GroupJoin() - Left Outer Join 
            #region Example 01
            //var Result = dbContext.Departments
            //	.GroupJoin(dbContext.Employees,
            //	D => D.DeptId,
            //	E => E.DepartmentId,
            //	(D, Employees) => new
            //	{
            //		Department = D,
            //		Employees = Employees
            //	});

            //Result = from D in dbContext.Departments
            //		 join E in dbContext.Employees
            //		 on D.DeptId equals E.DepartmentId into Groups
            //		 select new
            //		 {
            //			 Department = D,
            //			 Employees = Groups
            //		 };

            //foreach (var item in Result)
            //{
            //	Console.WriteLine($"Department Id : {item.Department.DeptId} - Department Name : {item.Department.DeptName} ");
            //	foreach(var employee in item.Employees)
            //	Console.WriteLine($"Employee Id : {employee.EmpId} - Employee Name : {employee.EmpName} ");

            //} 
            #endregion

            #region Example 02
            //var Result = dbContext.Departments
            //	.GroupJoin(dbContext.Employees,
            //	D => D.DeptId,
            //	E => E.DepartmentId,
            //	(D, Employees) => new
            //	{
            //		Department = D,
            //		Employees = Employees
            //	}).Where(X=>X.Employees.Count() > 2);

            //Result = from D in dbContext.Departments
            //		 join E in dbContext.Employees
            //		 on D.DeptId equals E.DepartmentId into Groups
            //		 where Groups.Count() > 2
            //		 select new
            //		 {
            //			 Department = D,
            //			 Employees = Groups
            //		 };

            //foreach (var item in Result)
            //{
            //	Console.WriteLine($"Department Id : {item.Department.DeptId} - Department Name : {item.Department.DeptName} ");
            //	foreach (var employee in item.Employees)
            //		Console.WriteLine($"Employee Id : {employee.EmpId} - Employee Name : {employee.EmpName} ");

            //}
            #endregion
            #endregion

            #region Left Outer Join 

            #region LeftJoin() - is not Working 
            //var Result = dbContext.Departments.LeftJoin(dbContext.Employees , 
            //	D=>D.DeptId , 
            //	E => E.DepartmentId ,
            //	(D , E) =>  new
            //	{
            //		D.DeptId , 
            //		E.EmpName
            //	}); 
            #endregion

            #region Using Group Join Instead

            #region Example 01
            //var Result = dbContext.Departments
            //	.GroupJoin(dbContext.Employees,
            //	D => D.DeptId,
            //	E => E.DepartmentId,
            //	(D, Employees) => new
            //	{
            //		Department = D,
            //		Employees = Employees
            //	}).SelectMany(X => X.Employees);


            //var Result02 = from D in dbContext.Departments
            //			   join E in dbContext.Employees
            //			   on D.DeptId equals E.DepartmentId into Employees
            //			   select new
            //			   {
            //				   Department = D,
            //				   Employees = Employees
            //			   } into Groups 
            //			   select Groups.Employees;



            //foreach (var item in Result02)
            //	Console.WriteLine(item.DeptName); 
            #endregion

            #region Example 02 - Department Left Join Employee

            //var Result = dbContext.Departments
            //	.GroupJoin(dbContext.Employees,
            //	D => D.DeptId,
            //	E => E.DepartmentId,
            //	(D, Employees) => new
            //	{
            //		Department = D,
            //		Employees = Employees
            //	}).SelectMany(X => X.Employees.DefaultIfEmpty() , (RS , E) => new 
            //	{
            //		DepartmentId = RS.Department.DeptId,
            //		DepartmentName = RS.Department.DeptName,
            //		EmployeeId = E != null ? E.EmpId : 0 ,
            //		EmployeeName = E != null ? E.EmpName : "No Employee" 					
            //	});

            //Result = from D in dbContext.Departments
            //		 join E in dbContext.Employees
            //		 on D.DeptId equals E.DepartmentId into Employees
            //		 select new
            //		 {
            //			 Department = D,
            //			 Employees = Employees.DefaultIfEmpty()
            //		 } into Groups
            //		 from E in Groups.Employees
            //		 select new
            //		 {
            //			 DepartmentId = Groups.Department.DeptId,
            //			 DepartmentName = Groups.Department.DeptName,
            //			 EmployeeId = E != null ? E.EmpId : 0,
            //			 EmployeeName = E != null ? E.EmpName : "No Employee"
            //		 };

            //foreach (var item in Result)
            //	Console.WriteLine(item);



            #endregion

            #region Example 03 - Employee Left Join Department 

            //var Result = dbContext.Employees
            //	.GroupJoin(dbContext.Departments,
            //	E => E.DepartmentId,
            //	D => D.DeptId,
            //	(Employee, Departments) => new
            //	{
            //		Employee,
            //		Departments
            //	}).SelectMany(X => X.Departments.DefaultIfEmpty(), (RS, Department) => new
            //	{
            //		EmployeeId = RS.Employee.EmpId,
            //		EmployeeName = RS.Employee.EmpName,
            //		DepartmentId = Department != null ? Department.DeptId : 0,
            //		DepartmentName = Department != null ? Department.DeptName : "NoDepartment",

            //	}); ;


            //Result = from E in dbContext.Employees
            //		 join D in dbContext.Departments
            //		 on E.DepartmentId equals D.DeptId into Groups
            //		 select new
            //		 {
            //			 Departments = Groups,
            //			 Employee = E
            //		 } into R
            //		 from Department in R.Departments.DefaultIfEmpty()
            //		 select new
            //		 {
            //			 EmployeeId = R.Employee.EmpId,
            //			 EmployeeName = R.Employee.EmpName,
            //			 DepartmentId = Department != null ? Department.DeptId : 0,
            //			 DepartmentName = Department != null ? Department.DeptName : "NoDepartment",
            //		 };



            //foreach (var item in Result)
            //	Console.WriteLine(item);



            #endregion

            #endregion


            #endregion

            #region Cross Join 

            //var Result = dbContext.Employees.SelectMany(E => dbContext.Departments.Select(D => new
            //{
            //	Employee = E.EmpName,
            //	Department = D.DeptName
            ////}));

            //var Result = from E in dbContext.Employees
            //		 from D in dbContext.Departments
            //		 select new
            //		 {
            //			 Employee = E.EmpName,
            //			 Department = D.DeptName
            //		 };

            //foreach (var item in Result)
            //	Console.WriteLine(item);


            #endregion
            #endregion
        }
    }
}
