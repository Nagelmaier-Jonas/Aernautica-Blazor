using MudBlazor;

namespace Domain.Services;

public class Logger{
    
    private static Logger Instance{ get; } = new();
    
    private Logger(){
    }
    
    public static Logger GetInstance() => Instance;
    
    private List<Tuple<string, Severity>> _log = new();

    public void Log(Severity type, string message) {
        _log.Add(new Tuple<string, Severity>(message, type));
    }

    public List<Tuple<string, Severity>> GetLog() => _log;
}