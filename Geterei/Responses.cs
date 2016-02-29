using System;

namespace spammaster
{
    public class EditContactsResponse
    {
        public int error_count { get; set; }
        public int[] error_indices { get; set; }
        public int new_count { get; set; }
        public String[] persisted_recipients { get; set; }

        public int updated_count { get; set; }

        public ErrorResponse[] errors { get; set; }
    }

    public class ErrorResponse
    {
        public string message { get; set; }

        public int[] error_indices { get; set; }
    }
}
