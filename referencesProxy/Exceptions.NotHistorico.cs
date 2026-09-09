namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: NotHistorico
/// </summary>
public class Ex_NotHistoricoRoleException : NotRegisteredException {

/// <summary>
/// User Defined Exception (NotHistorico) constructor:
/// </summary>
public Ex_NotHistoricoRoleException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "Historico.NotHistorico";
}

}
