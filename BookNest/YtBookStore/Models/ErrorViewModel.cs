namespace YtBookStore.Models
{
    // Model class for handling errors
    public class ErrorViewModel
    {
        // Request ID associated with the error
        public string? RequestId { get; set; }

        // Indicates whether to show the request ID
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
