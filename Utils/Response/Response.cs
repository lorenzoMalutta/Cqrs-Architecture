namespace Utils.Response
{
    public class Response
    {
        public string? Status { get; set; }

        public string? Message { get; set; }

        public object? Content { get; set; }

        public Dictionary<string, string[]>? Errors { get; set; }

    }
}
