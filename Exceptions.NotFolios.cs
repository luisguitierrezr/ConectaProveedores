namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: NotFolios
/// </summary>
public class Ex_NotFoliosRoleException : NotRegisteredException {

/// <summary>
/// User Defined Exception (NotFolios) constructor:
/// </summary>
public Ex_NotFoliosRoleException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "SecurityAuth.NotFolios";
}

}
