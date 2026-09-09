namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: InvalidLoginSuppliers
/// </summary>
public class Ex_InvalidLoginSuppliersUserException : UserException {

/// <summary>
/// User Defined Exception (InvalidLoginSuppliers) constructor:
/// </summary>
public Ex_InvalidLoginSuppliersUserException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "ConectaProveedores.InvalidLoginSuppliers";
}

}
