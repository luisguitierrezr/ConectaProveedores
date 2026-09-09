namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: NotAlmacen
/// </summary>
public class Ex_NotAlmacenRoleException : NotRegisteredException {

/// <summary>
/// User Defined Exception (NotAlmacen) constructor:
/// </summary>
public Ex_NotAlmacenRoleException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "SecurityAuth.NotAlmacen";
}

}
