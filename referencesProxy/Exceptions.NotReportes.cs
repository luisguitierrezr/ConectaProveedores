namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: NotReportes
/// </summary>
public class Ex_NotReportesRoleException : NotRegisteredException {

/// <summary>
/// User Defined Exception (NotReportes) constructor:
/// </summary>
public Ex_NotReportesRoleException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "SecurityAuth.NotReportes";
}

}
