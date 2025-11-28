namespace Demo.Pl.ViewModels.DepartmentViewModels
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }
        public string name { get; set; } = string.Empty;

        public string Code { get; set; } = string.Empty;

        public DateOnly DateOfCreation { get; set; }

        public string? Description { get; set; }
    }
}
