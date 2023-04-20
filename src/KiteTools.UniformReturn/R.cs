namespace KiteTools.UniformReturn
{
    /// <summary>
    /// 统一返回格式
    /// </summary>
    public static class R
    {
        public static Result<T> Ok<T>(T data)
        {
            var r = new Result<T>
            {
                Data = data,
                Success = true,
            };
            return r;
        }

        public static Result<object> Ok()
        {
            var r = new Result<object>();
            r.Success = true;
            return r;
        }

        public static Result<object> Error()
        {
            var r = new Result<object>
            {
                Success = false
            };
            return r;
        }

        public static Result<object> Error(string errorCode)
        {
            var r = new Result<object>
            {
                Success = false,
                ErrorCode = errorCode
            };
            return r;
        }

        public static Result<object> Error(string errorCode,string errorMessage)
        {
            var r = new Result<object>
            {
                Success = false,
                ErrorCode = errorCode,
                ErrorMessage = errorMessage
            };
            return r;
        }

    }

    public class Result<T>
    {


        public bool Success { get; set; }

        public T? Data { get; set; }

        /// <summary>
        /// 数据总数，当需要展示分页数据时使用
        /// </summary>
        public long? Total { get; set; }

        public string? ErrorCode { get; set; }

        public string? ErrorMessage { get; set; }


        // error display type： 0 silent; 1 message.warn; 2 message.error; 4 notification; 9 page
        public int? ShowType { get; set; }

        public string? TraceId { get; set; }

        public string? Host { get; set; }
    }
}