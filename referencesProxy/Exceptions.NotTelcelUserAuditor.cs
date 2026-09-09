namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: NotTelcelUserAuditor
/// </summary>
public class Ex_NotTelcelUserAuditorRoleException : NotRegisteredException {

/// <summary>
/// User Defined Exception (NotTelcelUserAuditor) constructor:
/// </summary>
public Ex_NotTelcelUserAuditorRoleException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "TelCelUsersManagement.NotTelcelUserAuditor";
}

}
