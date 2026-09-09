namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: FileInvalid
/// </summary>
public class Ex_FileInvalidUserException : UserException {

/// <summary>
/// User Defined Exception (FileInvalid) constructor:
/// </summary>
public Ex_FileInvalidUserException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "ConectaProveedores.FileInvalid";
}

}
