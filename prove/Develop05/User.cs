// User.cs
class User
{
    public string Name { get; set; }
    public int UserId { get; }

    public User(string name, int userId)
    {
        Name = name;
        UserId = userId;
    }
}
