public class Client {
    private string? Name { get; set; }
    private string? Email {get; set; }
    private DateTime BirthDate { get; set; }

    public Client () {

    }

    public Client (string name, string email, string birthDate) {
        Name = name;
        Email = email;
        BirthDate = DateTime.Parse(birthDate);
    }

    public override string ToString()
    {
        return $"{Name} ({BirthDate.ToString("d")}) - {Email}";
    }
}