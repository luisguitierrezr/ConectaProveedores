namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: InvalidDate
/// </summary>
public class Ex_InvalidDateUserException : UserException {

/// <summary>
/// User Defined Exception (InvalidDate) constructor:
/// </summary>
public Ex_InvalidDateUserException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "ConectaProveedores.InvalidDate";
}

}
