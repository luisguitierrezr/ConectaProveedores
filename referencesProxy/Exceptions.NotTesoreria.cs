namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: NotTesoreria
/// </summary>
public class Ex_NotTesoreriaRoleException : NotRegisteredException {

/// <summary>
/// User Defined Exception (NotTesoreria) constructor:
/// </summary>
public Ex_NotTesoreriaRoleException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "SecurityAuth.NotTesoreria";
}

}
