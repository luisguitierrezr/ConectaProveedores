namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: NotConectaProveedoresAdmin
/// </summary>
public class Ex_NotConectaProveedoresAdminRoleException : NotRegisteredException {

/// <summary>
/// User Defined Exception (NotConectaProveedoresAdmin) constructor:
/// </summary>
public Ex_NotConectaProveedoresAdminRoleException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "SecurityAuth.NotConectaProveedoresAdmin";
}

}
