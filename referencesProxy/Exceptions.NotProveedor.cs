namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: NotProveedor
/// </summary>
public class Ex_NotProveedorRoleException : NotRegisteredException {

/// <summary>
/// User Defined Exception (NotProveedor) constructor:
/// </summary>
public Ex_NotProveedorRoleException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "SecurityAuth.NotProveedor";
}

}
