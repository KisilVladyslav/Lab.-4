namespace L3.Domain {

    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsFavourite { get; set; }

        public Task(string title, string description, string category, bool isFavorite = false)
        {
            Title = title;
            Description = description;
            Category = category;
            IsFavourite = isFavorite;
        }
        public Task() { }

        public bool IsValid()
        {
            return !(string.IsNullOrWhiteSpace(Title) ||
                string.IsNullOrWhiteSpace(Description) ||
                string.IsNullOrWhiteSpace(Category));
        }
    }
}