namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: NotSAPImportOrders
/// </summary>
public class Ex_NotSAPImportOrdersRoleException : NotRegisteredException {

/// <summary>
/// User Defined Exception (NotSAPImportOrders) constructor:
/// </summary>
public Ex_NotSAPImportOrdersRoleException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "SecurityAuth.NotSAPImportOrders";
}

}
