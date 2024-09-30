﻿using SchoolProject.Data.Entities;
using SchoolProject.Data.Entities.Procedures;
using SchoolProject.Data.Entities.Views;

namespace SchoolProject.Service.Abstracts
{
    public interface IDepartmentService
    {
        public Task<Department> GetDepartmentById(int id);
        public Task<bool> IsDepartmentIdExist(int id);
        public Task<List<ViewDepartment>> GetViewDepartmentDataAsync();
        public Task<IReadOnlyCollection<DepartmentStudentcountProc>> GetDepartmentStudentcountProc(DepartmentStudentcountProcParameters parameters);
    }
}