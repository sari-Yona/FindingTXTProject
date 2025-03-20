namespace DOT
{
    public abstract class Location
    {
        public string BookName { get; set; }
        public override string ToString()
        {
            return BookName;
        }
    }
}