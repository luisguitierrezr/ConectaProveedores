namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: InvalidImport
/// </summary>
public class Ex_InvalidImportUserException : UserException {

/// <summary>
/// User Defined Exception (InvalidImport) constructor:
/// </summary>
public Ex_InvalidImportUserException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "ConectaProveedores.InvalidImport";
}

}
