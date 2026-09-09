namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: InvalidSession
/// </summary>
public class Ex_InvalidSessionUserException : UserException {

/// <summary>
/// User Defined Exception (InvalidSession) constructor:
/// </summary>
public Ex_InvalidSessionUserException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "ConectaProveedores.InvalidSession";
}

}
