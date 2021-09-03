namespace Celebrity.Web
{
    public interface IResponse
    {
        string ErrorTitle { get; }
        string ErrorDetail { get; }
        int ErrorCode { get; }
        bool HasError { get; }
        bool Success => !HasError;
    }
}
