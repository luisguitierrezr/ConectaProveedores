namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: MaxAllowedFileSize
/// </summary>
public class Ex_MaxAllowedFileSizeUserException : UserException {

/// <summary>
/// User Defined Exception (MaxAllowedFileSize) constructor:
/// </summary>
public Ex_MaxAllowedFileSizeUserException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "ConectaProveedores.MaxAllowedFileSize";
}

}
