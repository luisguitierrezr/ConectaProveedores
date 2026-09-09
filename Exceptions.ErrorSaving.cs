namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: ErrorSaving
/// </summary>
public class Ex_ErrorSavingUserException : UserException {

/// <summary>
/// User Defined Exception (ErrorSaving) constructor:
/// </summary>
public Ex_ErrorSavingUserException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "ConectaProveedores.ErrorSaving";
}

}
