namespace ssConectaProveedores;

/// <summary>
/// User Defined Exception class: NotComissionesArrendamientosViewer
/// </summary>
public class Ex_NotComissionesArrendamientosViewerRoleException : NotRegisteredException {

/// <summary>
/// User Defined Exception (NotComissionesArrendamientosViewer) constructor:
/// </summary>
public Ex_NotComissionesArrendamientosViewerRoleException (string message)
: base (message) {}

public override string GetUniqueName() {
    return "SecurityAuth.NotComissionesArrendamientosViewer";
}

}
