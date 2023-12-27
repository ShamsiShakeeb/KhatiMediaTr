namespace KhatiMediaTr
{
    public interface IMediaTr<TRequest, TResponse>
    {
        TResponse Send();
        TResponse Send<TRequestModel>(TRequestModel requestModel = null) where TRequestModel : class, new();
        TResponse Send(object[] prams);

    }
}
