namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetDocumentsListByMinuteType : VarsBag {
public int inParamMinuteTypeId;
public lcvGetDocumentsListByMinuteType(int inParamMinuteTypeId) {
this.inParamMinuteTypeId = inParamMinuteTypeId;
}
}
public class lcoGetDocumentsListByMinuteType : VarsBag {
public RL_9fb5c5e988576f6c521a9ef779213183 outParamList = new RL_9fb5c5e988576f6c521a9ef779213183();

public lcoGetDocumentsListByMinuteType() {
}
}
/// <summary>
/// Action <code>GetDocumentsListByMinuteType</code> that represents the Service Studio action
///  <code>GetDocumentsListByMinuteType</code> <p> Description: </p>
/// </summary>
public static async Task<RL_9fb5c5e988576f6c521a9ef779213183> ActionGetDocumentsListByMinuteType(IRequestContext requestContext,int inParamMinuteTypeId,CancellationToken cancellationToken) {
RL_9fb5c5e988576f6c521a9ef779213183 outParamList = default;
lcoGetDocumentsListByMinuteType result = new lcoGetDocumentsListByMinuteType();
lcvGetDocumentsListByMinuteType localVars = new lcvGetDocumentsListByMinuteType(inParamMinuteTypeId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetDocumentsListByMinuteType", "6fbb6ce8-2d43-426e-9e4f-90d7966cef53"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetDocumentsListByMinuteType", "6fbb6ce8-2d43-426e-9e4f-90d7966cef53", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ListClear
await ExtendedActions.ListClear(requestContext,result.outParamList,cancellationToken);

if(((localVars.inParamMinuteTypeId==1))) {
// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 1, ssValue = "Acta de Entrega", ssFileName = "ACTA DE ENTREGA", ssMandatory = true },cancellationToken);

// ListAppend2
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 2, ssValue = "Remision o Prefactura", ssFileName = "REMISION O PREFACTURA", ssMandatory = true },cancellationToken);

// ListAppend3
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 3, ssValue = "Grafica de Estimaciones de Obra", ssFileName = "GRAFICA DE ESTIMACIONES DE OBRA", ssMandatory = false },cancellationToken);

// ListAppend4
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 4, ssValue = "Estimacion", ssFileName = "ESTIMACION", ssMandatory = true },cancellationToken);

// ListAppend5
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 5, ssValue = "Pedido", ssFileName = "PEDIDO", ssMandatory = true },cancellationToken);

// ListAppend6
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 6, ssValue = "Generadores", ssFileName = "GENERADORES", ssMandatory = true },cancellationToken);

// ListAppend7
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 7, ssValue = "Correo de Asignacion Compras", ssFileName = "CORREO DE ASIGNACION COMPRAS", ssMandatory = true },cancellationToken);

// ListAppend8
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 8, ssValue = "Catalogo Asignado", ssFileName = "CATALOGO ASIGNADO", ssMandatory = true },cancellationToken);

} else {
if((localVars.inParamMinuteTypeId==2)) {
// ListAppend15
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 1, ssValue = "Acta de Entrega", ssFileName = "ACTA DE ENTREGA", ssMandatory = true },cancellationToken);

// ListAppend9
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 2, ssValue = "Remision o Prefactura", ssFileName = "REMISION O PREFACTURA", ssMandatory = true },cancellationToken);

// ListAppend16
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 3, ssValue = "Grafica de Estimaciones de Obra", ssFileName = "GRAFICA DE ESTIMACIONES DE OBRA", ssMandatory = false },cancellationToken);

// ListAppend12
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 4, ssValue = "Estimacion", ssFileName = "ESTIMACION", ssMandatory = true },cancellationToken);

// ListAppend14
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 5, ssValue = "Pedido", ssFileName = "PEDIDO", ssMandatory = true },cancellationToken);

// ListAppend10
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 6, ssValue = "Generadores", ssFileName = "GENERADORES", ssMandatory = true },cancellationToken);

// ListAppend13
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 7, ssValue = "Correo de Asignacion Compras", ssFileName = "CORREO DE ASIGNACION COMPRAS", ssMandatory = true },cancellationToken);

// ListAppend11
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 8, ssValue = "Catalogo Asignado", ssFileName = "CATALOGO ASIGNADO", ssMandatory = true },cancellationToken);

// ListAppend19
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 9, ssValue = "Bitacora de Obra", ssFileName = "BITACORA DE OBRA", ssMandatory = true },cancellationToken);

// ListAppend18
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 10, ssValue = "Correo de Validacion de Finiquito", ssFileName = "CORREO DE VALIDACION DE FINIQUITO", ssMandatory = true },cancellationToken);

// ListAppend17
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 11, ssValue = "VO BO Planos As-Built", ssFileName = "VO BO PLANOS AS-BUILT", ssMandatory = false },cancellationToken);

} else {
if((localVars.inParamMinuteTypeId==3)) {
// ListAppend28
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 1, ssValue = "Acta de Entrega", ssFileName = "ACTA DE ENTREGA", ssMandatory = true },cancellationToken);

// ListAppend30
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 2, ssValue = "Remision o Prefactura", ssFileName = "REMISION O PREFACTURA", ssMandatory = true },cancellationToken);

// ListAppend24
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 3, ssValue = "Pedido", ssFileName = "PEDIDO", ssMandatory = true },cancellationToken);

// ListAppend20
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 4, ssValue = "Generadores", ssFileName = "GENERADORES", ssMandatory = false },cancellationToken);

// ListAppend26
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 5, ssValue = "Reporte Fotografico de los Trabajos Ejecutados", ssFileName = "REPORTE FOTOGRAFICO DE LOS TRABAJOS EJECUTADOS", ssMandatory = false },cancellationToken);

// ListAppend29
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 6, ssValue = "Correo de Asignacion Compras", ssFileName = "CORREO DE ASIGNACION COMPRAS", ssMandatory = true },cancellationToken);

// ListAppend21
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 7, ssValue = "Catalogo Asignado", ssFileName = "CATALOGO ASIGNADO", ssMandatory = true },cancellationToken);

// ListAppend27
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 8, ssValue = "Soporte de Entrega / Instalacion o Solicitud de Mantenimiento", ssFileName = "SOPORTE DE ENTREGA INSTALACION O SOLICITUD DE MANTENIMIENTO", ssMandatory = true },cancellationToken);

// ListAppend25
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 9, ssValue = "Bitacora de Obra", ssFileName = "BITACORA DE OBRA", ssMandatory = false },cancellationToken);

// ListAppend22
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure(){ ssKey = 10, ssValue = "VO BO Planos As-Built", ssFileName = "VO BO PLANOS AS-BUILT", ssMandatory = false },cancellationToken);

}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamList = result.outParamList;
} // inner-finally
RETURN_STATEMENT:
return outParamList;
}

public static class FuncActionGetDocumentsListByMinuteType {



}


}
