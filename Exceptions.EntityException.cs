namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: EntityException
/// </summary>
public class Ex_EntityExceptionUserException : UserException {

/// <summary>
/// User Defined Exception (EntityException) constructor:
/// </summary>
public Ex_EntityExceptionUserException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "ConectaProveedores.EntityException";
}

}
