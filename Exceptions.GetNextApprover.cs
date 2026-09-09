namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: GetNextApprover
/// </summary>
public class Ex_GetNextApproverUserException : UserException {

/// <summary>
/// User Defined Exception (GetNextApprover) constructor:
/// </summary>
public Ex_GetNextApproverUserException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "ConectaProveedores.GetNextApprover";
}

}
