namespace ssConectaProveedores;

public partial class Actions {
public class lcvScreenTableDownloadFoliosSAEScreen : VarsBag {
public bool inParami_IsCSV;
public bool inParami_IsPDF;
public bool inParami_IsXLS;
public RL_9046748205310553b4766e7b1bf0c997 inParami_FolioScreenTableStructure;
public byte[] resPrintToPDF_outParamPDF = new byte[] {};

public byte[] resRecordListToExcel2_outParamOut = new byte[] {};
public byte[] resRecordListToExcel1_outParamOut = new byte[] {};
public byte[] resConvertExcelBinaryToCsvBinary_outParamConvertExcelBinaryToCsvBinary = new byte[] {};

public Actions.lcoVerifyBinaryFileSize resVerifyBinaryFileSize =  new Actions.lcoVerifyBinaryFileSize();
public lcvScreenTableDownloadFoliosSAEScreen(bool inParami_IsCSV, bool inParami_IsPDF, bool inParami_IsXLS, RL_9046748205310553b4766e7b1bf0c997 inParami_FolioScreenTableStructure) {
this.inParami_IsCSV = inParami_IsCSV;
this.inParami_IsPDF = inParami_IsPDF;
this.inParami_IsXLS = inParami_IsXLS;
this.inParami_FolioScreenTableStructure = inParami_FolioScreenTableStructure;
}
}
public class lcoScreenTableDownloadFoliosSAEScreen : VarsBag {
public ST_a158c76eb93396680623c04244f48b6cStructure outParamo_File = new ST_a158c76eb93396680623c04244f48b6cStructure();

public string outParamo_StringListIds = "";

public string outParamo_ErrorMsg = "";

public lcoScreenTableDownloadFoliosSAEScreen() {
}
}
/// <summary>
/// Action <code>ScreenTableDownloadFoliosSAEScreen</code> that represents the Service Studio action
///  <code>ScreenTableDownloadFoliosSAEScreen</code> <p> Description
/// : ScreenTableDownloadFoliosSAEScreen</p>
/// </summary>
public static async Task<(ST_a158c76eb93396680623c04244f48b6cStructure,string,string)> ActionScreenTableDownloadFoliosSAEScreen(IRequestContext requestContext,bool inParami_IsCSV,bool inParami_IsPDF,bool inParami_IsXLS,RL_9046748205310553b4766e7b1bf0c997 inParami_FolioScreenTableStructure,CancellationToken cancellationToken) {
ST_a158c76eb93396680623c04244f48b6cStructure outParamo_File = default;
string outParamo_StringListIds = default;
string outParamo_ErrorMsg = default;
lcoScreenTableDownloadFoliosSAEScreen result = new lcoScreenTableDownloadFoliosSAEScreen();
lcvScreenTableDownloadFoliosSAEScreen localVars = new lcvScreenTableDownloadFoliosSAEScreen(inParami_IsCSV, inParami_IsPDF, inParami_IsXLS, inParami_FolioScreenTableStructure);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ScreenTableDownloadFoliosSAEScreen", "585ad689-66e2-435f-9d8c-558244ad5c56"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ScreenTableDownloadFoliosSAEScreen", "585ad689-66e2-435f-9d8c-558244ad5c56", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Foreach i_FolioScreenTableStructure
localVars.inParami_FolioScreenTableStructure.StartIteration();
try {while (!((localVars.inParami_FolioScreenTableStructure.Eof))) {
// o_StringListIds = If
result.outParamo_StringListIds=(((result.outParamo_StringListIds=="")) ? ((BuiltInFunction.LongIntegerToText(localVars.inParami_FolioScreenTableStructure.CurrentRec.ssFolioId)+",")) : (((result.outParamo_StringListIds+BuiltInFunction.LongIntegerToText(localVars.inParami_FolioScreenTableStructure.CurrentRec.ssFolioId))+",")));
localVars.inParami_FolioScreenTableStructure.Advance();
}

} finally {
localVars.inParami_FolioScreenTableStructure.EndIteration();
}

// empty?
if((localVars.inParami_FolioScreenTableStructure.Empty)) {
// o_ErrorMsg = "Empty list."
result.outParamo_ErrorMsg=AppUtils.GetStringResource("PgercW9iAkq9zbUFAAo+_A#Value.1383249565.1", "Empty list.");
} else {
if((localVars.inParami_IsPDF)) {
// PrintToPDF
localVars.resPrintToPDF_outParamPDF = await Actions.ActionPrintToPDF(requestContext,((((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores/TableDownloadFolioScreenPDF?StringListIds=")+result.outParamo_StringListIds),new ST_201dce7bb255178c132fec4d547942aeStructure(){ ssBaseURL = ((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain]))) },cancellationToken);

// File
// o_File.Name = "Folios" + " " + CurrDate + ".pdf"
result.outParamo_File.ssName = (((AppUtils.GetStringResource("q0pzLNM+Jk+achDnaHxnTg#Value.2109873290.1", "Folios")+" ")+BuiltInFunction.DateToText(BuiltInFunction.CurrDate ()))+".pdf");

// o_File.BinaryData = PrintToPDF.PDF
result.outParamo_File.ssBinaryData = localVars.resPrintToPDF_outParamPDF;
} else {
if(localVars.inParami_IsXLS) {
// RecordListToExcel RLToExcelScreenTableDownloadFoliosSAEScreenRecordListToExcel1
localVars.resRecordListToExcel1_outParamOut = await FuncActionScreenTableDownloadFoliosSAEScreen.RLToExcelScreenTableDownloadFoliosSAEScreenRecordListToExcel1(requestContext,localVars.inParami_FolioScreenTableStructure,cancellationToken);

// File
// o_File.Name = "Folios" + " " + CurrDate + ".xlsx"
result.outParamo_File.ssName = (((AppUtils.GetStringResource("OopvprHMKkCWIDmatRz8lg#Value.2109873290.1", "Folios")+" ")+BuiltInFunction.DateToText(BuiltInFunction.CurrDate ()))+".xlsx");

// o_File.BinaryData = RecordListToExcel1
result.outParamo_File.ssBinaryData = localVars.resRecordListToExcel1_outParamOut;
} else {
if(localVars.inParami_IsCSV) {
// RecordListToExcel RLToExcelScreenTableDownloadFoliosSAEScreenRecordListToExcel2
localVars.resRecordListToExcel2_outParamOut = await FuncActionScreenTableDownloadFoliosSAEScreen.RLToExcelScreenTableDownloadFoliosSAEScreenRecordListToExcel2(requestContext,localVars.inParami_FolioScreenTableStructure,cancellationToken);

// ConvertExcelBinaryToCsvBinary
localVars.resConvertExcelBinaryToCsvBinary_outParamConvertExcelBinaryToCsvBinary = await Actions.ActionConvertExcelBinaryToCsvBinary(requestContext,localVars.resRecordListToExcel2_outParamOut,cancellationToken);

// File
// o_File.Name = "Folios" + " " + CurrDate + ".csv"
result.outParamo_File.ssName = (((AppUtils.GetStringResource("TjdJJEsJQkaOvYZoIPPuUg#Value.2109873290.1", "Folios")+" ")+BuiltInFunction.DateToText(BuiltInFunction.CurrDate ()))+".csv");

// o_File.BinaryData = ConvertExcelBinaryToCsvBinary.ConvertExcelBinaryToCsvBinary
result.outParamo_File.ssBinaryData = localVars.resConvertExcelBinaryToCsvBinary_outParamConvertExcelBinaryToCsvBinary;
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
outParamo_ErrorMsg = result.outParamo_ErrorMsg;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_File,outParamo_StringListIds,outParamo_ErrorMsg);
}

public static class FuncActionScreenTableDownloadFoliosSAEScreen {


/// <summary>
/// RecordList To Excel: RLToExcelScreenTableDownloadFoliosSAEScreenRecordListToExcel2
///  (KxmiOJDMuokmKJQ02O7Oc2A) of Action "ScreenTableDownloadFoliosSAEScreen"
/// </summary>
public static async Task<byte[]> RLToExcelScreenTableDownloadFoliosSAEScreenRecordListToExcel2(IRequestContext requestContext,RL_9046748205310553b4766e7b1bf0c997 ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(9, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("Número de Folio");
excel.CreateCell("Número de Pedido");
excel.CreateCell("Nombre del proveedor");
excel.CreateCell("Número de proveedor");
excel.CreateCell("Region");
excel.CreateCell("Importe Total");
excel.CreateCell("Moneda");
excel.CreateCell("Fecha del Folio");
excel.CreateCell("Estatus del Folio");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssFolioNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssOrderNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssSupplierName);
excel.CreateCell(ssRecordList.CurrentRec.ssSupplierNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssRegion);
excel.CreateCell(ssRecordList.CurrentRec.ssTotalAmount);
excel.CreateCell(ssRecordList.CurrentRec.ssCurrency);
excel.CreateCell(ssRecordList.CurrentRec.ssUploadDate);
excel.CreateCell(ssRecordList.CurrentRec.ssStatus);

            ssRecordList.Advance(); 
		}
	} finally {
		ssRecordList.EndIteration();
	}
}

return await excel.SaveAsync(cancellationToken);
}

/// <summary>
/// RecordList To Excel: RLToExcelScreenTableDownloadFoliosSAEScreenRecordListToExcel1
///  (KybhdU2hEtEOcfK9Nd3bFvQ) of Action "ScreenTableDownloadFoliosSAEScreen"
/// </summary>
public static async Task<byte[]> RLToExcelScreenTableDownloadFoliosSAEScreenRecordListToExcel1(IRequestContext requestContext,RL_9046748205310553b4766e7b1bf0c997 ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(9, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("Número de Folio");
excel.CreateCell("Número de Pedido");
excel.CreateCell("Nombre del proveedor");
excel.CreateCell("Número de proveedor");
excel.CreateCell("Region");
excel.CreateCell("Importe Total");
excel.CreateCell("Moneda");
excel.CreateCell("Fecha del Folio");
excel.CreateCell("Estatus del Folio");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssFolioNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssOrderNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssSupplierName);
excel.CreateCell(ssRecordList.CurrentRec.ssSupplierNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssRegion);
excel.CreateCell(ssRecordList.CurrentRec.ssTotalAmount);
excel.CreateCell(ssRecordList.CurrentRec.ssCurrency);
excel.CreateCell(ssRecordList.CurrentRec.ssUploadDate);
excel.CreateCell(ssRecordList.CurrentRec.ssStatus);

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
