namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: CancelDocumentBeforeOperation
/// </summary>
public class Ex_CancelDocumentBeforeOperationUserException : UserException {

/// <summary>
/// User Defined Exception (CancelDocumentBeforeOperation) constructor:
/// </summary>
public Ex_CancelDocumentBeforeOperationUserException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "ConectaProveedores.CancelDocumentBeforeOperation";
}

}
