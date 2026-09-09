namespace ssConectaProveedores;

public partial class Actions {
public class lcvDownloadDocument : VarsBag {
public int inParami_Type;
public lcvDownloadDocument(int inParami_Type) {
this.inParami_Type = inParami_Type;
}
}
public class lcoDownloadDocument : VarsBag {
public byte[] outParamo_file = new byte[] {};

public string outParamo_filename = "";

public lcoDownloadDocument() {
}
}
/// <summary>
/// Action <code>DownloadDocument</code> that represents the Service Studio action
///  <code>DownloadDocument</code> <p> Description: </p>
/// </summary>
public static async Task<(byte[],string)> ActionDownloadDocument(IRequestContext requestContext,int inParami_Type,CancellationToken cancellationToken) {
byte[] outParamo_file = default;
string outParamo_filename = default;
lcoDownloadDocument result = new lcoDownloadDocument();
lcvDownloadDocument localVars = new lcvDownloadDocument(inParami_Type);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("DownloadDocument", "03e055e9-e1e9-40b5-83ac-0cc485ac7c0e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("DownloadDocument", "03e055e9-e1e9-40b5-83ac-0cc485ac7c0e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if(((localVars.inParami_Type==1))) {
// o_file = Resources.Proveedor.xlsx.Content
result.outParamo_file=(await RuntimePlatformUtils.GetResourceBinaryAsync(System.IO.Path.Combine("hidden_resources/ConectaProveedores/Proveedor.xlsx"), System.IO.Path.Combine("hidden_resources/ConectaProveedores/Proveedor.xlsx"), cancellationToken));

// o_filename = "Consulta por Proveedor.xlsx"
result.outParamo_filename="Consulta por Proveedor.xlsx";
} else {
if((localVars.inParami_Type==2)) {
// o_file = Resources.UUID.xlsx.Content
result.outParamo_file=(await RuntimePlatformUtils.GetResourceBinaryAsync(System.IO.Path.Combine("hidden_resources/ConectaProveedores/UUID.xlsx"), System.IO.Path.Combine("hidden_resources/ConectaProveedores/UUID.xlsx"), cancellationToken));

// o_filename = "Consulta por UUID.xlsx"
result.outParamo_filename="Consulta por UUID.xlsx";
} else {
if((localVars.inParami_Type==3)) {
// o_file = Resources.RangoDeFechas.xlsx.Content
result.outParamo_file=(await RuntimePlatformUtils.GetResourceBinaryAsync(System.IO.Path.Combine("hidden_resources/ConectaProveedores/RangoDeFechas.xlsx"), System.IO.Path.Combine("hidden_resources/ConectaProveedores/RangoDeFechas.xlsx"), cancellationToken));

// o_filename = "Consulta por Rango de Fechas.xlsx"
result.outParamo_filename="Consulta por Rango de Fechas.xlsx";
} else {
if((localVars.inParami_Type==4)) {
// o_file = Resources.Periodo.xlsx.Content
result.outParamo_file=(await RuntimePlatformUtils.GetResourceBinaryAsync(System.IO.Path.Combine("hidden_resources/ConectaProveedores/Periodo.xlsx"), System.IO.Path.Combine("hidden_resources/ConectaProveedores/Periodo.xlsx"), cancellationToken));

// o_filename = "Consulta por Periodo.xlsx"
result.outParamo_filename="Consulta por Periodo.xlsx";
} else {
if((localVars.inParami_Type==5)) {
// o_file = Resources.CuentaDeGasto.xlsx.Content
result.outParamo_file=(await RuntimePlatformUtils.GetResourceBinaryAsync(System.IO.Path.Combine("hidden_resources/ConectaProveedores/CuentaDeGasto.xlsx"), System.IO.Path.Combine("hidden_resources/ConectaProveedores/CuentaDeGasto.xlsx"), cancellationToken));

// o_filename = "Consulta por Cuenta de Gasto.xlsx"
result.outParamo_filename="Consulta por Cuenta de Gasto.xlsx";
}

}

}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamo_file = result.outParamo_file;
outParamo_filename = result.outParamo_filename;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_file,outParamo_filename);
}

public static class FuncActionDownloadDocument {



}


}
