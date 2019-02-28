using System;
using System.Collections.Generic;

namespace Sca.Data.Entities
{
    public partial class Department
    {
        public Department()
        {
            #region Generated Constructor
            ParentDepartments = new HashSet<Department>();
            RootDepartments = new HashSet<Department>();
            DepartmentCertifications = new HashSet<DepartmentCertification>();
            DepartmentDivisions = new HashSet<DepartmentDivision>();
            DepartmentUsers = new HashSet<DepartmentUser>();
            DepartmentFlowCharts = new HashSet<DepartmentFlowChart>();
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime OperationStart { get; set; }

        public DateTime? OperationEnd { get; set; }

        public int? RootId { get; set; }

        public int? ParentId { get; set; }

        public string Description { get; set; }

        public bool Active { get; set; }

        public string Procedures { get; set; }

        public DateTime? ChangeDate { get; set; }

        public Byte[] RowVersion { get; set; }

        public int? PreviousVersion { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Department ParentDepartment { get; set; }

        public virtual ICollection<Department> ParentDepartments { get; set; }

        public virtual Department RootDepartment { get; set; }

        public virtual ICollection<Department> RootDepartments { get; set; }

        public virtual ICollection<DepartmentCertification> DepartmentCertifications { get; set; }

        public virtual ICollection<DepartmentDivision> DepartmentDivisions { get; set; }

        public virtual ICollection<DepartmentUser> DepartmentUsers { get; set; }

        public virtual ICollection<DepartmentFlowChart> DepartmentFlowCharts { get; set; }

        #endregion

    }
}
