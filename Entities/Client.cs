using System.Text;

public class Client {
    private string? Name { get; set; }
    private string? Email {get; set; }
    private DateTime BirthDate { get; set; }

    public Client (string name, string email, string birthDate) {
        Name = name;
        Email = email;
        BirthDate = DateTime.Parse(birthDate);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(Name);
        sb.Append("("+BirthDate.ToString("d")+") - ");
        sb.Append(Email);

        return sb.ToString();
    }
}