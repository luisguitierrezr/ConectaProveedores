namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: NotRequisiciones
/// </summary>
public class Ex_NotRequisicionesRoleException : NotRegisteredException {

/// <summary>
/// User Defined Exception (NotRequisiciones) constructor:
/// </summary>
public Ex_NotRequisicionesRoleException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "SecurityAuth.NotRequisiciones";
}

}
