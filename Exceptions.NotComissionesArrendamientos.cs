namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: NotComissionesArrendamientos
/// </summary>
public class Ex_NotComissionesArrendamientosRoleException : NotRegisteredException {

/// <summary>
/// User Defined Exception (NotComissionesArrendamientos) constructor:
/// </summary>
public Ex_NotComissionesArrendamientosRoleException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "SecurityAuth.NotComissionesArrendamientos";
}

}
