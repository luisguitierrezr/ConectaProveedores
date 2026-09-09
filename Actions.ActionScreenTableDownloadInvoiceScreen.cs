namespace ssConectaProveedores;

public partial class Actions {
public class lcvScreenTableDownloadInvoiceScreen : VarsBag {
public bool inParami_IsCSV;
public bool inParami_IsPDF;
public bool inParami_IsXLS;
public RL_77750b395266828bf78fae563dd1fc3f inParami_InvoicesScreenTableStructure;
public byte[] resRecordListToExcel4_outParamOut = new byte[] {};
public byte[] resRecordListToExcel3_outParamOut = new byte[] {};
public byte[] resPrintToPDF_outParamPDF = new byte[] {};

public Actions.lcoVerifyBinaryFileSize resVerifyBinaryFileSize =  new Actions.lcoVerifyBinaryFileSize();
public byte[] resConvertExcelBinaryToCsvBinary2_outParamConvertExcelBinaryToCsvBinary = new byte[] {};

public lcvScreenTableDownloadInvoiceScreen(bool inParami_IsCSV, bool inParami_IsPDF, bool inParami_IsXLS, RL_77750b395266828bf78fae563dd1fc3f inParami_InvoicesScreenTableStructure) {
this.inParami_IsCSV = inParami_IsCSV;
this.inParami_IsPDF = inParami_IsPDF;
this.inParami_IsXLS = inParami_IsXLS;
this.inParami_InvoicesScreenTableStructure = inParami_InvoicesScreenTableStructure;
}
}
public class lcoScreenTableDownloadInvoiceScreen : VarsBag {
public ST_a158c76eb93396680623c04244f48b6cStructure outParamo_File = new ST_a158c76eb93396680623c04244f48b6cStructure();

public string outParamo_StringListIds = "";

public string outParamo_StringListLevelIds = "";

public string outParamo_ErrorMsg = "";

public lcoScreenTableDownloadInvoiceScreen() {
}
}
/// <summary>
/// Action <code>ScreenTableDownloadInvoiceScreen</code> that represents the Service Studio action
///  <code>ScreenTableDownloadInvoiceScreen</code> <p> Description
/// : ScreenTableDownloadInvoiceScreen</p>
/// </summary>
public static async Task<(ST_a158c76eb93396680623c04244f48b6cStructure,string,string,string)> ActionScreenTableDownloadInvoiceScreen(IRequestContext requestContext,bool inParami_IsCSV,bool inParami_IsPDF,bool inParami_IsXLS,RL_77750b395266828bf78fae563dd1fc3f inParami_InvoicesScreenTableStructure,CancellationToken cancellationToken) {
ST_a158c76eb93396680623c04244f48b6cStructure outParamo_File = default;
string outParamo_StringListIds = default;
string outParamo_StringListLevelIds = default;
string outParamo_ErrorMsg = default;
lcoScreenTableDownloadInvoiceScreen result = new lcoScreenTableDownloadInvoiceScreen();
lcvScreenTableDownloadInvoiceScreen localVars = new lcvScreenTableDownloadInvoiceScreen(inParami_IsCSV, inParami_IsPDF, inParami_IsXLS, inParami_InvoicesScreenTableStructure);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ScreenTableDownloadInvoiceScreen", "82af520b-7b21-4fa7-b049-fdae68dccb10"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ScreenTableDownloadInvoiceScreen", "82af520b-7b21-4fa7-b049-fdae68dccb10", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Foreach i_InvoicesScreenTableStructure
localVars.inParami_InvoicesScreenTableStructure.StartIteration();
try {while (!((localVars.inParami_InvoicesScreenTableStructure.Eof))) {
// o_StringListIds = If
result.outParamo_StringListIds=(((result.outParamo_StringListIds=="")) ? ((BuiltInFunction.LongIntegerToText(localVars.inParami_InvoicesScreenTableStructure.CurrentRec.ssInvoiceId)+",")) : (((result.outParamo_StringListIds+BuiltInFunction.LongIntegerToText(localVars.inParami_InvoicesScreenTableStructure.CurrentRec.ssInvoiceId))+",")));

// o_StringListLevelIds = If
result.outParamo_StringListLevelIds=(((result.outParamo_StringListLevelIds=="")) ? ((BuiltInFunction.LongIntegerToText(localVars.inParami_InvoicesScreenTableStructure.CurrentRec.ssInvoiceApprovalLevelId)+",")) : (((result.outParamo_StringListLevelIds+BuiltInFunction.LongIntegerToText(localVars.inParami_InvoicesScreenTableStructure.CurrentRec.ssInvoiceApprovalLevelId))+",")));
localVars.inParami_InvoicesScreenTableStructure.Advance();
}

} finally {
localVars.inParami_InvoicesScreenTableStructure.EndIteration();
}

// empty?
if((localVars.inParami_InvoicesScreenTableStructure.Empty)) {
// o_ErrorMsg = "Empty list."
result.outParamo_ErrorMsg=AppUtils.GetStringResource("ZCNS8jyoRESJAgk4UjxnUQ#Value.1383249565.1", "Empty list.");
} else {
if((localVars.inParami_IsPDF)) {
// PrintToPDF
localVars.resPrintToPDF_outParamPDF = await Actions.ActionPrintToPDF(requestContext,((((((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores/TableDownloadInvoiceScreenPDF?StringListIds=")+result.outParamo_StringListIds)+"&StringListLevelIds=")+result.outParamo_StringListLevelIds),new ST_201dce7bb255178c132fec4d547942aeStructure(){ ssBaseURL = ((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain]))) },cancellationToken);

// File
// o_File.Name = "Invoices" + " " + CurrDate + ".pdf"
result.outParamo_File.ssName = (((AppUtils.GetStringResource("Il3y5TgAEUC1zeVddv5nqA#Value.701269766.1", "Invoices")+" ")+BuiltInFunction.DateToText(BuiltInFunction.CurrDate ()))+".pdf");

// o_File.BinaryData = PrintToPDF.PDF
result.outParamo_File.ssBinaryData = localVars.resPrintToPDF_outParamPDF;
} else {
if(localVars.inParami_IsXLS) {
// RecordListToExcel RLToExcelScreenTableDownloadInvoiceScreenRecordListToExcel4
localVars.resRecordListToExcel4_outParamOut = await FuncActionScreenTableDownloadInvoiceScreen.RLToExcelScreenTableDownloadInvoiceScreenRecordListToExcel4(requestContext,localVars.inParami_InvoicesScreenTableStructure,cancellationToken);

// File
// o_File.Name = "Invoices" + " " + CurrDate + ".xlsx"
result.outParamo_File.ssName = (((AppUtils.GetStringResource("VQBzrUdlzEGn5lLBTk3kLA#Value.701269766.1", "Invoices")+" ")+BuiltInFunction.DateToText(BuiltInFunction.CurrDate ()))+".xlsx");

// o_File.BinaryData = RecordListToExcel4
result.outParamo_File.ssBinaryData = localVars.resRecordListToExcel4_outParamOut;
} else {
if(localVars.inParami_IsCSV) {
// RecordListToExcel RLToExcelScreenTableDownloadInvoiceScreenRecordListToExcel3
localVars.resRecordListToExcel3_outParamOut = await FuncActionScreenTableDownloadInvoiceScreen.RLToExcelScreenTableDownloadInvoiceScreenRecordListToExcel3(requestContext,localVars.inParami_InvoicesScreenTableStructure,cancellationToken);

// ConvertExcelBinaryToCsvBinary2
localVars.resConvertExcelBinaryToCsvBinary2_outParamConvertExcelBinaryToCsvBinary = await Actions.ActionConvertExcelBinaryToCsvBinary(requestContext,localVars.resRecordListToExcel3_outParamOut,cancellationToken);

// File
// o_File.Name = "Invoices" + " " + CurrDate + ".csv"
result.outParamo_File.ssName = (((AppUtils.GetStringResource("Pi30LJyAOEapNt08zZ1WUA#Value.701269766.1", "Invoices")+" ")+BuiltInFunction.DateToText(BuiltInFunction.CurrDate ()))+".csv");

// o_File.BinaryData = ConvertExcelBinaryToCsvBinary2.ConvertExcelBinaryToCsvBinary
result.outParamo_File.ssBinaryData = localVars.resConvertExcelBinaryToCsvBinary2_outParamConvertExcelBinaryToCsvBinary;
} else {
goto RETURN_STATEMENT;

}

}

}

// VerifyBinaryFileSize
localVars.resVerifyBinaryFileSize.outParamo_File = await Actions.ActionVerifyBinaryFileSize(requestContext,result.outParamo_File,cancellationToken);

// o_File = VerifyBinaryFileSize.o_File
result.outParamo_File=localVars.resVerifyBinaryFileSize.outParamo_File;
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_File = result.outParamo_File;
outParamo_StringListIds = result.outParamo_StringListIds;
outParamo_StringListLevelIds = result.outParamo_StringListLevelIds;
outParamo_ErrorMsg = result.outParamo_ErrorMsg;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_File,outParamo_StringListIds,outParamo_StringListLevelIds,outParamo_ErrorMsg);
}

public static class FuncActionScreenTableDownloadInvoiceScreen {


/// <summary>
/// RecordList To Excel: RLToExcelScreenTableDownloadInvoiceScreenRecordListToExcel4
///  (Kwv3GAXcJeUSCqzr8dLnaaA) of Action "ScreenTableDownloadInvoiceScreen"
/// </summary>
public static async Task<byte[]> RLToExcelScreenTableDownloadInvoiceScreenRecordListToExcel4(IRequestContext requestContext,RL_77750b395266828bf78fae563dd1fc3f ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(9, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("Nombre de la factura");
excel.CreateCell("Estado de la factura");
excel.CreateCell("Nombre de la solicitud");
excel.CreateCell("Nombre del proveedor");
excel.CreateCell("Número de proveedor");
excel.CreateCell("Monto total");
excel.CreateCell("Fecha de carga");
excel.CreateCell("Asignado a");
excel.CreateCell("Acción");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssInvoiceName);
excel.CreateCell(ssRecordList.CurrentRec.ssInvoiceStatus);
excel.CreateCell(ssRecordList.CurrentRec.ssRequisitionName);
excel.CreateCell(ssRecordList.CurrentRec.ssSupplierName);
excel.CreateCell(ssRecordList.CurrentRec.ssSupplierNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssTotalAmount);
excel.CreateCell(ssRecordList.CurrentRec.ssUploadDate);
excel.CreateCell(ssRecordList.CurrentRec.ssAssignedTo);
excel.CreateCell(ssRecordList.CurrentRec.ssAction);

            ssRecordList.Advance(); 
		}
	} finally {
		ssRecordList.EndIteration();
	}
}

return await excel.SaveAsync(cancellationToken);
}

/// <summary>
/// RecordList To Excel: RLToExcelScreenTableDownloadInvoiceScreenRecordListToExcel3
///  (KD037JOZp70mBHI_WMjAJkQ) of Action "ScreenTableDownloadInvoiceScreen"
/// </summary>
public static async Task<byte[]> RLToExcelScreenTableDownloadInvoiceScreenRecordListToExcel3(IRequestContext requestContext,RL_77750b395266828bf78fae563dd1fc3f ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(9, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("Nombre de la factura");
excel.CreateCell("Estado de la factura");
excel.CreateCell("Nombre de la solicitud");
excel.CreateCell("Nombre del proveedor");
excel.CreateCell("Número de proveedor");
excel.CreateCell("Monto total");
excel.CreateCell("Fecha de carga");
excel.CreateCell("Asignado a");
excel.CreateCell("Acción");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssInvoiceName);
excel.CreateCell(ssRecordList.CurrentRec.ssInvoiceStatus);
excel.CreateCell(ssRecordList.CurrentRec.ssRequisitionName);
excel.CreateCell(ssRecordList.CurrentRec.ssSupplierName);
excel.CreateCell(ssRecordList.CurrentRec.ssSupplierNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssTotalAmount);
excel.CreateCell(ssRecordList.CurrentRec.ssUploadDate);
excel.CreateCell(ssRecordList.CurrentRec.ssAssignedTo);
excel.CreateCell(ssRecordList.CurrentRec.ssAction);

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
