using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment2.Models;

namespace Assignment2.ViewModel
{
    public class EmpDept
    {
        Employee EmpObj = new Employee();
        Department DeptObj = new Department();
        public int Id { get => EmpObj.EmpId; set { EmpObj.EmpId = value; } }
        public string EmployeeName { get { return EmpObj.EmpName; } set { EmpObj.EmpName = value; } }
        public int DeptId { get => DeptObj.depid; set { DeptObj.depid = value; } }
        public string DepartmentName { get => DeptObj.DeptName; set { DeptObj.DeptName = value; } }

    }
}