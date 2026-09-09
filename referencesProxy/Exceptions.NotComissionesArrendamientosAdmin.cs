namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: NotComissionesArrendamientosAdmin
/// </summary>
public class Ex_NotComissionesArrendamientosAdminRoleException : NotRegisteredException {

/// <summary>
/// User Defined Exception (NotComissionesArrendamientosAdmin) constructor:
/// </summary>
public Ex_NotComissionesArrendamientosAdminRoleException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "SecurityAuth.NotComissionesArrendamientosAdmin";
}

}
