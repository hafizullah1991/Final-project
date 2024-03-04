namespace EmployeeManagementSystem.Models
{
    public class Employee: IUserActivity
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNumbwer { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public string Country { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
