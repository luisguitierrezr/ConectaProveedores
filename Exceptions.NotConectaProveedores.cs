namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: NotConectaProveedores
/// </summary>
public class Ex_NotConectaProveedoresRoleException : NotRegisteredException {

/// <summary>
/// User Defined Exception (NotConectaProveedores) constructor:
/// </summary>
public Ex_NotConectaProveedoresRoleException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "ConectaProveedores.NotConectaProveedores";
}

}
