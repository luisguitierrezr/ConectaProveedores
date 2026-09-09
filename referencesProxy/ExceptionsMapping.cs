using System.Collections.ObjectModel;
    
namespace ssConectaProveedores.ReferencesProxy;

public static class ExceptionsMapping {
    // The AbstractServiceApiClient maps exceptions from their SpecificName (dictionary key) to their type
    public static IDictionary<string, Func<string, Exception>> GeneratedExceptionsClientMapping { get; } = new Dictionary<string, Func<string, Exception>> {
        {"Historico.NotHistorico", (exceptionMessage) => new Ex_NotHistoricoRoleException(exceptionMessage)},
{"SecurityAuth.NotComissionesArrendamientosViewer", (exceptionMessage) => new Ex_NotComissionesArrendamientosViewerRoleException(exceptionMessage)},
{"SecurityAuth.NotConectaProveedoresAdmin", (exceptionMessage) => new Ex_NotConectaProveedoresAdminRoleException(exceptionMessage)},
{"SecurityAuth.NotComissionesArrendamientos", (exceptionMessage) => new Ex_NotComissionesArrendamientosRoleException(exceptionMessage)},
{"SecurityAuth.NotFolios", (exceptionMessage) => new Ex_NotFoliosRoleException(exceptionMessage)},
{"SecurityAuth.NotComissionesArrendamientosAdmin", (exceptionMessage) => new Ex_NotComissionesArrendamientosAdminRoleException(exceptionMessage)},
{"SecurityAuth.NotAlmacen", (exceptionMessage) => new Ex_NotAlmacenRoleException(exceptionMessage)},
{"SecurityAuth.NotReportes", (exceptionMessage) => new Ex_NotReportesRoleException(exceptionMessage)},
{"SecurityAuth.NotConectaProveedoresAdminViewer", (exceptionMessage) => new Ex_NotConectaProveedoresAdminViewerRoleException(exceptionMessage)},
{"SecurityAuth.NotPedidos", (exceptionMessage) => new Ex_NotPedidosRoleException(exceptionMessage)},
{"SecurityAuth.NotTesoreria", (exceptionMessage) => new Ex_NotTesoreriaRoleException(exceptionMessage)},
{"SecurityAuth.NotDesviaciones", (exceptionMessage) => new Ex_NotDesviacionesRoleException(exceptionMessage)},
{"SecurityAuth.NotProveedor", (exceptionMessage) => new Ex_NotProveedorRoleException(exceptionMessage)},
{"SecurityAuth.NotSAPImportOrders", (exceptionMessage) => new Ex_NotSAPImportOrdersRoleException(exceptionMessage)},
{"SecurityAuth.NotRequisiciones", (exceptionMessage) => new Ex_NotRequisicionesRoleException(exceptionMessage)},
{"TelCelUsersManagement.NotTelcelUserAuditor", (exceptionMessage) => new Ex_NotTelcelUserAuditorRoleException(exceptionMessage)},

    };
}