public class ApiResponse<T> : ApiResponse
{
    public T Result { get; private init; }

    public static ApiResponse<T> OK(T result)
        => new() { Success = true, StatusCode = StatusCodes.Status200OK, Result = result };

    public static ApiResponse<T> OK(T result, string successMessage)
        => new() {
            
            Success = true,
            StatusCode = StatusCodes.Status200OK,
            Result = result,
            SuccessMessage = successMessage
        };
}