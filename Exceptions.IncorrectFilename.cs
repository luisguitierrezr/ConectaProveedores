namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: IncorrectFilename
/// </summary>
public class Ex_IncorrectFilenameUserException : UserException {

/// <summary>
/// User Defined Exception (IncorrectFilename) constructor:
/// </summary>
public Ex_IncorrectFilenameUserException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "ConectaProveedores.IncorrectFilename";
}

}
