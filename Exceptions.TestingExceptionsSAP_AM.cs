namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: TestingExceptionsSAP_AM
/// </summary>
public class Ex_TestingExceptionsSAP_AMUserException : UserException {

/// <summary>
/// User Defined Exception (TestingExceptionsSAP_AM) constructor:
/// </summary>
public Ex_TestingExceptionsSAP_AMUserException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "ConectaProveedores.TestingExceptionsSAP_AM";
}

}
