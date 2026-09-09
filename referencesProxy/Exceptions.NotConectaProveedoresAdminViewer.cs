namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: NotConectaProveedoresAdminViewer
/// </summary>
public class Ex_NotConectaProveedoresAdminViewerRoleException : NotRegisteredException {

/// <summary>
/// User Defined Exception (NotConectaProveedoresAdminViewer) constructor:
/// </summary>
public Ex_NotConectaProveedoresAdminViewerRoleException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "SecurityAuth.NotConectaProveedoresAdminViewer";
}

}
