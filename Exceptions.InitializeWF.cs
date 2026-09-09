namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: InitializeWF
/// </summary>
public class Ex_InitializeWFUserException : UserException {

/// <summary>
/// User Defined Exception (InitializeWF) constructor:
/// </summary>
public Ex_InitializeWFUserException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "ConectaProveedores.InitializeWF";
}

}
