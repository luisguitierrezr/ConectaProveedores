namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: DocumentExtration
/// </summary>
public class Ex_DocumentExtrationUserException : UserException {

/// <summary>
/// User Defined Exception (DocumentExtration) constructor:
/// </summary>
public Ex_DocumentExtrationUserException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "ConectaProveedores.DocumentExtration";
}

}
