using EmoployeePayroll_mvc.Models;
using EmoployeePayroll_mvc.Models.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmoployeePayroll_mvc.Repository
{
    public class EmployeeRepository
    {
        EmployeeContext dbContext = new EmployeeContext();
        public List<EmployeeViewModel> GetEmployees()
        {
            try
            {
                List<EmployeeViewModel> list = (from e in dbContext.Employees
                                                join d in dbContext.Departments on e.DepartmentId equals d.DeptId
                                                join s in dbContext.Salaries on e.SalaryId equals s.SalaryId
                                                select new EmployeeViewModel
                                                {
                                                    EmpId = e.EmpId,
                                                    Name = e.Name,
                                                    Gender = e.Gender,
                                                    DepartmentId = d.DeptId,
                                                    Department = d.DeptName,
                                                    SalaryId = s.SalaryId,
                                                    Amount = s.Amount,
                                                    StartDate = e.StartDate,
                                                    Description = e.Description
                                                }).ToList<EmployeeViewModel>();
                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool RegisterEmployee(RegisterRequestModel employee)
        {
            try
            {
                Employee validEmployee = dbContext.Employees.Where(x => x.Name == employee.Name && x.Gender == employee.Gender).FirstOrDefault();
                if (validEmployee == null)
                {
                    int departmentId = dbContext.Departments.Where(x => x.DeptName == employee.Department).Select(x => x.DeptId).FirstOrDefault();
                    Employee newEmployee = new Employee()
                    {
                        Name = employee.Name,
                        Gender = employee.Gender,
                        DepartmentId = departmentId,
                        SalaryId = Convert.ToInt32(employee.SalaryId),
                        StartDate = employee.StartDate,
                        Description = employee.Description
                    };
                    Employee returnData = dbContext.Employees.Add(newEmployee);
                }
                int result = dbContext.SaveChanges();
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public Employee GetEmployee(int id)
        {
            try
            {
                Employee list = dbContext.Employees.Where(x => x.EmpId == id).SingleOrDefault();

                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Update(Employee model)
        {
            var data = dbContext.Employees.FirstOrDefault(x => x.EmpId == model.EmpId);

            // Checking if any such record exist  
            if (data != null)
            {
                data.EmpId = model.EmpId;
                data.Name = model.Name;
                data.Gender = model.Gender;
                data.DepartmentId = model.DepartmentId;
                data.Department = model.Department;
                data.SalaryId = model.SalaryId;
                data.Salary = model.Salary;
                data.StartDate = model.StartDate;
                data.Description = model.Description;
                return dbContext.SaveChanges();
            }
            else
                return 0;
        }
        public int DeleteEmployee(int id)
        {
            try
            {
                Employee data = dbContext.Employees.Where(x => x.EmpId == id).SingleOrDefault();

                if (data != null)
                {
                    dbContext.Employees.Remove(data);
                    return dbContext.SaveChanges();
                }
                else
                    return 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}