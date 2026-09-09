namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: InvalidDocumentType
/// </summary>
public class Ex_InvalidDocumentTypeUserException : UserException {

/// <summary>
/// User Defined Exception (InvalidDocumentType) constructor:
/// </summary>
public Ex_InvalidDocumentTypeUserException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "ConectaProveedores.InvalidDocumentType";
}

}
