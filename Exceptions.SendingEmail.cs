namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: SendingEmail
/// </summary>
public class Ex_SendingEmailUserException : UserException {

/// <summary>
/// User Defined Exception (SendingEmail) constructor:
/// </summary>
public Ex_SendingEmailUserException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "ConectaProveedores.SendingEmail";
}

}
