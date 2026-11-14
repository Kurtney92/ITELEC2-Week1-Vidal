
class Dog
{
    public int DogId { get; }
    public string DogName { get; }
    public int Age { get; private set; }
    public string Status { get; private set; }

    public Dog(int dogId, string dogName, int age, string status)
    {
        DogId = dogId;
        DogName = dogName;
        Age = age;
        Status = status;
    }

    public bool Adopt()
    {
        if (Status != "Available")
        {
            return false;
        }

        Status = "Adopted";
        return true;
    }

    public bool UpdateAge(int newAge)
    {
        if (newAge < 0)
        {
            return false;
        }

        Age = newAge;
        return true;
    }
}
