namespace Uranium.Domain.Core.Results
{
    public class SucceededResult
    {
        public bool Succeeded { get; }
        public List<string> Errors { get; }

        public static SucceededResult Success => new(true, (string?)null);
        public static SucceededResult Failure(string? error) => new(false, error);
        public static SucceededResult Failure(List<string>? errors) => new(false, errors);

        public SucceededResult(bool succeeded, List<string>? errors = null)
        {
            Succeeded = succeeded;
            Errors = errors ?? new();
        }

        public SucceededResult(bool succeeded, string? error = null)
            : this(succeeded, string.IsNullOrEmpty(error) ? null : new List<string> { error })
        {
        }
    }
}
