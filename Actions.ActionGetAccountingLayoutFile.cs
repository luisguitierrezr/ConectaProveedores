namespace ssConectaProveedores;

public partial class Actions {
public class lcoGetAccountingLayoutFile : VarsBag {
public ST_a158c76eb93396680623c04244f48b6cStructure outParamo_File = new ST_a158c76eb93396680623c04244f48b6cStructure();

public lcoGetAccountingLayoutFile() {
}
}
/// <summary>
/// Action <code>GetAccountingLayoutFile</code> that represents the Service Studio action
///  <code>GetAccountingLayoutFile</code> <p> Description: Get Accounting Layout File.</p>
/// </summary>
public static async Task<ST_a158c76eb93396680623c04244f48b6cStructure> ActionGetAccountingLayoutFile(IRequestContext requestContext,CancellationToken cancellationToken) {
ST_a158c76eb93396680623c04244f48b6cStructure outParamo_File = default;
lcoGetAccountingLayoutFile result = new lcoGetAccountingLayoutFile();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetAccountingLayoutFile", "2b71ebb8-111d-4b73-8fcc-6a7d3d2835ad"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetAccountingLayoutFile", "2b71ebb8-111d-4b73-8fcc-6a7d3d2835ad", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// o_File.BinaryData = Resources.AccountingLayout.xlsx.Content
result.outParamo_File.ssBinaryData = (await RuntimePlatformUtils.GetResourceBinaryAsync(System.IO.Path.Combine("wwwroot/AccountingLayout.xlsx"), System.IO.Path.Combine("hidden_resources/ConectaProveedores/AccountingLayout.xlsx"), cancellationToken));

// o_File.Name = "Layout.xlsx"
result.outParamo_File.ssName = "Layout.xlsx";
} //close CreateActionActivity using block
} // try

finally {
outParamo_File = result.outParamo_File;
} // inner-finally
RETURN_STATEMENT:
return outParamo_File;
}

public static class FuncActionGetAccountingLayoutFile {



}


}
