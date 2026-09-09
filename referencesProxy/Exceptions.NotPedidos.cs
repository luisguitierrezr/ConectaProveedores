namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: NotPedidos
/// </summary>
public class Ex_NotPedidosRoleException : NotRegisteredException {

/// <summary>
/// User Defined Exception (NotPedidos) constructor:
/// </summary>
public Ex_NotPedidosRoleException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "SecurityAuth.NotPedidos";
}

}
