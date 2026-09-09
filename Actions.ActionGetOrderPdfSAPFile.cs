namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetOrderPdfSAPFile : VarsBag {
public string inParamOrderNumber;
public byte[] resBase64ToBinary_outParamBinary = new byte[] {};

public ST_bc70ab3695876bb4315a9088f41998b7Structure resCall_ZMXMIMMF_GENERA_PEDIDO_PDF_outParamResponse = new ST_bc70ab3695876bb4315a9088f41998b7Structure();

public lcvGetOrderPdfSAPFile(string inParamOrderNumber) {
this.inParamOrderNumber = inParamOrderNumber;
}
}
public class lcoGetOrderPdfSAPFile : VarsBag {
public byte[] outParamBinary = new byte[] {};

public lcoGetOrderPdfSAPFile() {
}
}
/// <summary>
/// Action <code>GetOrderPdfSAPFile</code> that represents the Service Studio action
///  <code>GetOrderPdfSAPFile</code> <p> Description: </p>
/// </summary>
public static async Task<byte[]> ActionGetOrderPdfSAPFile(IRequestContext requestContext,string inParamOrderNumber,CancellationToken cancellationToken) {
byte[] outParamBinary = default;
lcoGetOrderPdfSAPFile result = new lcoGetOrderPdfSAPFile();
lcvGetOrderPdfSAPFile localVars = new lcvGetOrderPdfSAPFile(inParamOrderNumber);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetOrderPdfSAPFile", "052edf30-fffc-4af5-b813-4a3885af7c2f"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetOrderPdfSAPFile", "052edf30-fffc-4af5-b813-4a3885af7c2f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Call_ZMXMIMMF_GENERA_PEDIDO_PDF
localVars.resCall_ZMXMIMMF_GENERA_PEDIDO_PDF_outParamResponse = await ServiceAPIs.ServiceAPICall_ZMXMIMMF_GENERA_PEDIDO_PDF(requestContext,new ST_7ddccdeb65a44283541a52358876da04Structure(){ ssPI_PEDIDO = localVars.inParamOrderNumber },cancellationToken);

// empty
if((!((localVars.resCall_ZMXMIMMF_GENERA_PEDIDO_PDF_outParamResponse.ssPO_PDF=="")))) {
// Base64ToBinary
localVars.resBase64ToBinary_outParamBinary = await Actions.ActionBase64ToBinary(requestContext,localVars.resCall_ZMXMIMMF_GENERA_PEDIDO_PDF_outParamResponse.ssPO_PDF,cancellationToken);

// Binary = Base64ToBinary.Binary
result.outParamBinary=localVars.resBase64ToBinary_outParamBinary;
}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

goto RETURN_STATEMENT;

} // Catch
finally {
outParamBinary = result.outParamBinary;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamBinary;
}

public static class FuncActionGetOrderPdfSAPFile {



}


}
