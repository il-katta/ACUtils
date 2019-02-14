namespace ACUtils
{
    public class NotFoundException : System.Exception
    {
        public NotFoundException(string message) : base(message) { }
    }

    public class TooMuchResultsException : System.Exception
    {
        public TooMuchResultsException(string message) : base(message) { }
    }

    public class DiscartException : System.Exception { }

    public class FileExistsException : System.IO.IOException
    {
        public FileExistsException(string message) : base(message) { }
    }

}
