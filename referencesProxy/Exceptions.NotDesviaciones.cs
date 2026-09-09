namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: NotDesviaciones
/// </summary>
public class Ex_NotDesviacionesRoleException : NotRegisteredException {

/// <summary>
/// User Defined Exception (NotDesviaciones) constructor:
/// </summary>
public Ex_NotDesviacionesRoleException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "SecurityAuth.NotDesviaciones";
}

}
