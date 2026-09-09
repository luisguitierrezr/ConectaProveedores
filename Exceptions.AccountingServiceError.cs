namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: AccountingServiceError
/// </summary>
public class Ex_AccountingServiceErrorUserException : UserException {

/// <summary>
/// User Defined Exception (AccountingServiceError) constructor:
/// </summary>
public Ex_AccountingServiceErrorUserException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "ConectaProveedores.AccountingServiceError";
}

}
