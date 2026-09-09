namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: ApiKey
/// </summary>
public class Ex_ApiKeyUserException : UserException {

/// <summary>
/// User Defined Exception (ApiKey) constructor:
/// </summary>
public Ex_ApiKeyUserException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "ConectaProveedores.ApiKey";
}

}
