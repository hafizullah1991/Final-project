namespace EmployeeManagementSystem.Models
{
    public interface IUserActivity
    {
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public string Country { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
