namespace SingleResponsibiltyPrinciple.BadExample
{
    internal interface IEmployeeEntity
    {
        decimal Hours { get; }
        decimal OvertimeHours { get; }
        string Role { get; }
    }
}