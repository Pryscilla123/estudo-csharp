namespace exerciciolista1;

class Estudante {
    public string Name { get; internal set; }
    public string Email { get; internal set; }

    public Estudante (string name, string email) {
        Name = name;
        Email = email;
    }
}