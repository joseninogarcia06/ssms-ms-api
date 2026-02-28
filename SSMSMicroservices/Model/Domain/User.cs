public class User
{
    public Guid Id { get; set; }

    public string Salutation { get; set; }

    public string CreatedBy { get; set; }

    public DateTimeOffset CreatedOn { get; set; }

    public string CreatedByType { get; set; } 

    public string ModifiedBy { get; set; }

    public DateTimeOffset ModifiedOn { get; set; }

    public string ModifiedByType { get; set; }

    public bool IsActive { get; set; }
}