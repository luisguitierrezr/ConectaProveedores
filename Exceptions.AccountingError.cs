namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: AccountingError
/// </summary>
public class Ex_AccountingErrorUserException : UserException {

/// <summary>
/// User Defined Exception (AccountingError) constructor:
/// </summary>
public Ex_AccountingErrorUserException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "ConectaProveedores.AccountingError";
}

}
