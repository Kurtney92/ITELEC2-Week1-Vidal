
class Cat
{
    public int CatId { get; }
    public string CatName { get; }
    public int Age { get; private set; }
    public string Status { get; private set; }

    public Cat(int catId, string catName, int age, string status)
    {
        CatId = catId;
        CatName = catName;
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
