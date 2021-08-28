namespace hogwarts_repository.Models
{
    public class House : Base.BaseEntity
    {
        public string Name { get; set; }
        public string President { get; set; }
        public string Creator { get; set; }
        public string Badge { get; set; }
        public string Ghost { get; set; }
        public string Rhyme { get; set; }
        public string Location { get; set; }
    }
}