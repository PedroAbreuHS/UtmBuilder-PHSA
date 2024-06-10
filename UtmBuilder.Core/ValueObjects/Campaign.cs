namespace UtmBuilder.Core.ValueObjects
{
    public class Campaign : ValueObject
    {
        public string Source { get; set; }
        public string Medium { get; set; }
        public string Name { get; set; }
        public string? Id { get; set; }
        public string? Term { get; set; }
        public string? Content { get; set; }

        public Campaign(string source, string medium, string name, string? id = null, string? term = null, string? content = null)
        {
            Source = source;
            Medium = medium;
            Name = name;
            Id = id;
            Term = term;
            Content = content;
        }
    }
}