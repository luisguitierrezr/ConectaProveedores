namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: NoFiles
/// </summary>
public class Ex_NoFilesUserException : UserException {

/// <summary>
/// User Defined Exception (NoFiles) constructor:
/// </summary>
public Ex_NoFilesUserException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "ConectaProveedores.NoFiles";
}

}
