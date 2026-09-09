namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: CyACompanyNotAllowed
/// </summary>
public class Ex_CyACompanyNotAllowedUserException : UserException {

/// <summary>
/// User Defined Exception (CyACompanyNotAllowed) constructor:
/// </summary>
public Ex_CyACompanyNotAllowedUserException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "ConectaProveedores.CyACompanyNotAllowed";
}

}
