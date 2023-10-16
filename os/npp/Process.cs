namespace npp;

public class Process
{
    private string _processName;
    private int _arrivalTime;
    private int _CPUBurstTime;
    private int _priority;
    private int _waitingTime;
    private int _turnaroundTime;

    public Process(string processName,
                int ArrivalTime,
                int CPUBurstTime,
                int Priority,
                int waitingTime = 0,
                int turnaroundTime = 0)
    {
        this._processName = processName;
        this._arrivalTime = ArrivalTime;
        this._CPUBurstTime = CPUBurstTime;
        this._priority = Priority;
        this.WaitingTime = waitingTime;
        this.TurnaroundTime = turnaroundTime;
    }

    public string ProcessName { get => _processName; set => _processName = value; }
    public int ArrivalTime { get => _arrivalTime; set => _arrivalTime = value; }
    public int CPUBurstTime { get => _CPUBurstTime; set => _CPUBurstTime = value; }
    public int Priority { get => _priority; set => _priority = value; }
    public int WaitingTime { get => _waitingTime; set => _waitingTime = value; }
    public int TurnaroundTime { get => _turnaroundTime; set => _turnaroundTime = value; }
}
