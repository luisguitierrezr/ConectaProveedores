namespace ssConectaProveedores;

public partial class Actions {
public class lcvGenerateLinesReport63 : VarsBag {
public RL_5c9c2f90b5c4a20f64fc5db975393a5e inParamLinesReport63List;
public bool inParamInExcel;
public byte[] resConvertExcelBinaryToCsvBinary_outParamConvertExcelBinaryToCsvBinary = new byte[] {};

public byte[] resRecordListToExcel1_outParamOut = new byte[] {};
public int resBinaryDataSize_outParamSize = 0;

public lcvGenerateLinesReport63(RL_5c9c2f90b5c4a20f64fc5db975393a5e inParamLinesReport63List, bool inParamInExcel) {
this.inParamLinesReport63List = inParamLinesReport63List;
this.inParamInExcel = inParamInExcel;
}
}
public class lcoGenerateLinesReport63 : VarsBag {
public ST_a158c76eb93396680623c04244f48b6cStructure outParamFile = new ST_a158c76eb93396680623c04244f48b6cStructure();

public lcoGenerateLinesReport63() {
}
}
/// <summary>
/// Action <code>GenerateLinesReport63</code> that represents the Service Studio action
///  <code>GenerateLinesReport63</code> <p> Description: GenerateLinesReport63</p>
/// </summary>
public static async Task<ST_a158c76eb93396680623c04244f48b6cStructure> ActionGenerateLinesReport63(IRequestContext requestContext,RL_5c9c2f90b5c4a20f64fc5db975393a5e inParamLinesReport63List,bool inParamInExcel,CancellationToken cancellationToken) {
ST_a158c76eb93396680623c04244f48b6cStructure outParamFile = default;
lcoGenerateLinesReport63 result = new lcoGenerateLinesReport63();
lcvGenerateLinesReport63 localVars = new lcvGenerateLinesReport63(inParamLinesReport63List, inParamInExcel);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GenerateLinesReport63", "7eea65f6-306b-4d1d-b9a6-ea52b8d05a8b"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GenerateLinesReport63", "7eea65f6-306b-4d1d-b9a6-ea52b8d05a8b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// RecordListToExcel RLToExcelGenerateLinesReport63RecordListToExcel1
localVars.resRecordListToExcel1_outParamOut = await FuncActionGenerateLinesReport63.RLToExcelGenerateLinesReport63RecordListToExcel1(requestContext,localVars.inParamLinesReport63List,cancellationToken);

if((localVars.inParamInExcel)) {
// File.BinaryData = RecordListToExcel1
result.outParamFile.ssBinaryData = localVars.resRecordListToExcel1_outParamOut;

// File.Name = "Pedidos provenientes de SAP" + FormatDateTime + ".xlsx"
result.outParamFile.ssName = (("Pedidos provenientes de SAP"+BuiltInFunction.FormatDateTime (BuiltInFunction.CurrDate (), "ddMMyy"))+".xlsx");
} else {
// ConvertExcelBinaryToCsvBinary
localVars.resConvertExcelBinaryToCsvBinary_outParamConvertExcelBinaryToCsvBinary = await Actions.ActionConvertExcelBinaryToCsvBinary(requestContext,localVars.resRecordListToExcel1_outParamOut,cancellationToken);

// BinaryDataSize
localVars.resBinaryDataSize_outParamSize = await Actions.ActionBinaryDataSize(requestContext,localVars.resConvertExcelBinaryToCsvBinary_outParamConvertExcelBinaryToCsvBinary,cancellationToken);

// File.BinaryData = ConvertExcelBinaryToCsvBinary.ConvertExcelBinaryToCsvBinary
result.outParamFile.ssBinaryData = localVars.resConvertExcelBinaryToCsvBinary_outParamConvertExcelBinaryToCsvBinary;

// File.Name = "Pedidos provenientes de SAP" + FormatDateTime + ".csv"
result.outParamFile.ssName = (("Pedidos provenientes de SAP"+BuiltInFunction.FormatDateTime (BuiltInFunction.CurrDate (), "ddMMyy"))+".csv");
}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// RaiseError MaxAllowedFileSize
throw new Ex_MaxAllowedFileSizeUserException (AppUtils.GetStringResource("9E6FbqZikUGeZinCDSbYcw#Message.1521086513.1", "When exporting to CSV, the file exceeds the allowed size. Try modifying the search criteria or downloading to Excel."));

} // Catch
finally {
outParamFile = result.outParamFile;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamFile;
}

public static class FuncActionGenerateLinesReport63 {


/// <summary>
/// RecordList To Excel: RLToExcelGenerateLinesReport63RecordListToExcel1 (KE0mqhHV7fkm5IgHtAo_j7w) of
///  Action "GenerateLinesReport63"
/// </summary>
public static async Task<byte[]> RLToExcelGenerateLinesReport63RecordListToExcel1(IRequestContext requestContext,RL_5c9c2f90b5c4a20f64fc5db975393a5e ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(23, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("Número de pedido");
excel.CreateCell("Liberación");
excel.CreateCell("Número de proveedor");
excel.CreateCell("Nombre de proveedor");
excel.CreateCell("Ind. de Borrado");
excel.CreateCell("Ind. de Bloqueo");
excel.CreateCell("Entrega final");
excel.CreateCell("Solicitante");
excel.CreateCell("Imputación");
excel.CreateCell("Sociedad");
excel.CreateCell("Posición");
excel.CreateCell("Código de Material");
excel.CreateCell("Descripción del material");
excel.CreateCell("Cantidad en pedido");
excel.CreateCell("Cantidad entregada");
excel.CreateCell("Cantidad disponible");
excel.CreateCell("Precio unitario");
excel.CreateCell("Moneda");
excel.CreateCell("Monto Total");
excel.CreateCell("Estatus de entrega");
excel.CreateCell("Estado");
excel.CreateCell("Usuario");
excel.CreateCell("Puesto");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssOrderNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssCreatedOn);
excel.CreateCell(ssRecordList.CurrentRec.ssSupplierNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssSupplierName);
excel.CreateCell(ssRecordList.CurrentRec.ssIsDeleted);
excel.CreateCell(ssRecordList.CurrentRec.ssIsReleased);
excel.CreateCell(ssRecordList.CurrentRec.ssisFinalDelivery);
excel.CreateCell(ssRecordList.CurrentRec.ssApplicant);
excel.CreateCell(ssRecordList.CurrentRec.ssAssignmentCode);
excel.CreateCell(ssRecordList.CurrentRec.ssSociedad);
excel.CreateCell(ssRecordList.CurrentRec.ssPosition);
excel.CreateCell(ssRecordList.CurrentRec.ssMaterialCode);
excel.CreateCell(ssRecordList.CurrentRec.ssMaterialDescription);
excel.CreateCell(ssRecordList.CurrentRec.ssQuantity);
excel.CreateCell(ssRecordList.CurrentRec.ssQuantityDelivered);
excel.CreateCell(ssRecordList.CurrentRec.ssQuantityAvailable);
excel.CreateCell(ssRecordList.CurrentRec.ssUnitPrice);
excel.CreateCell(ssRecordList.CurrentRec.ssCurrency);
excel.CreateCell(ssRecordList.CurrentRec.ssTotal);
excel.CreateCell(ssRecordList.CurrentRec.ssDeliveryStatus);
excel.CreateCell(ssRecordList.CurrentRec.ssOrderStatus);
excel.CreateCell(ssRecordList.CurrentRec.ssUser);
excel.CreateCell(ssRecordList.CurrentRec.ssUserJobTitle);

            ssRecordList.Advance(); 
		}
	} finally {
		ssRecordList.EndIteration();
	}
}

return await excel.SaveAsync(cancellationToken);
}


}


}
