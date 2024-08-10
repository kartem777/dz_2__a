var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IGlobalStateService, GlobalStateService>();
builder.Services.AddTransient<IRequestProcessingService, RequestProcessingService>();
var app = builder.Build();


app.Run();


public interface IGlobalStateService
{
    int GetState();
    void SetState(int state);
}
public class GlobalStateService : IGlobalStateService
{
    private int _state;

    public int GetState()
    {
        return _state;
    }

    public void SetState(int state)
    {
        _state = state;
    }
}
public interface IRequestProcessingService
{
    string ProcessRequest(string data);
}
public class RequestProcessingService : IRequestProcessingService
{
    public string ProcessRequest(string data)
    {
        return $"Processed data: {data.ToUpper()}";
    }
}
