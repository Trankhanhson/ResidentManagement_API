namespace AuthenticationProject.Data
{
    public class DataResult
    {
        public double TotalPage { get; set; }
        public object Data { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }

        public static DataResult ResultSuccess(object data, string message,double totalPage) => new DataResult()
        {
            Data = data,
            Message = message,
            Success = true,
            TotalPage = totalPage
        };
        public static DataResult ResultSuccess(object data) => new DataResult()
        {
            Data = data,
            Success = true,
        };

        public static DataResult ResultError(string message)
        {
            return new DataResult()
            {
                Success = false,
                Message = message,
            };
        }
    }
}
