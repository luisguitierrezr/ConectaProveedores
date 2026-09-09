namespace ssConectaProveedores;

public partial class Actions {
public class lcvScreenTableDownloadWbRequisitionsListInternal : VarsBag {
public bool inParami_IsCSV;
public bool inParami_IsPDF;
public bool inParami_IsXLS;
public RL_622bdef78070a83f1d39501965da2144 inParami_RequisitionsListInternalTableListStructure;
public byte[] resConvertExcelBinaryToCsvBinary2_outParamConvertExcelBinaryToCsvBinary = new byte[] {};

public Actions.lcoVerifyBinaryFileSize resVerifyBinaryFileSize =  new Actions.lcoVerifyBinaryFileSize();
public byte[] resRecordListToExcel4_outParamOut = new byte[] {};
public byte[] resRecordListToExcel3_outParamOut = new byte[] {};
public byte[] resPrintToPDF_outParamPDF = new byte[] {};

public lcvScreenTableDownloadWbRequisitionsListInternal(bool inParami_IsCSV, bool inParami_IsPDF, bool inParami_IsXLS, RL_622bdef78070a83f1d39501965da2144 inParami_RequisitionsListInternalTableListStructure) {
this.inParami_IsCSV = inParami_IsCSV;
this.inParami_IsPDF = inParami_IsPDF;
this.inParami_IsXLS = inParami_IsXLS;
this.inParami_RequisitionsListInternalTableListStructure = inParami_RequisitionsListInternalTableListStructure;
}
}
public class lcoScreenTableDownloadWbRequisitionsListInternal : VarsBag {
public ST_a158c76eb93396680623c04244f48b6cStructure outParamo_File = new ST_a158c76eb93396680623c04244f48b6cStructure();

public string outParamo_StringListIds = "";

public string outParamo_StringListLevelIds = "";

public string outParamo_ErrorMsg = "";

public lcoScreenTableDownloadWbRequisitionsListInternal() {
}
}
/// <summary>
/// Action <code>ScreenTableDownloadWbRequisitionsListInternal</code> that represents the Service
///  Studio action <code>ScreenTableDownloadWbRequisitionsListInternal</code> <p> Description
/// : ScreenTableDownloadWbRequisitionsListInternal</p>
/// </summary>
public static async Task<(ST_a158c76eb93396680623c04244f48b6cStructure,string,string,string)> ActionScreenTableDownloadWbRequisitionsListInternal(IRequestContext requestContext,bool inParami_IsCSV,bool inParami_IsPDF,bool inParami_IsXLS,RL_622bdef78070a83f1d39501965da2144 inParami_RequisitionsListInternalTableListStructure,CancellationToken cancellationToken) {
ST_a158c76eb93396680623c04244f48b6cStructure outParamo_File = default;
string outParamo_StringListIds = default;
string outParamo_StringListLevelIds = default;
string outParamo_ErrorMsg = default;
lcoScreenTableDownloadWbRequisitionsListInternal result = new lcoScreenTableDownloadWbRequisitionsListInternal();
lcvScreenTableDownloadWbRequisitionsListInternal localVars = new lcvScreenTableDownloadWbRequisitionsListInternal(inParami_IsCSV, inParami_IsPDF, inParami_IsXLS, inParami_RequisitionsListInternalTableListStructure);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ScreenTableDownloadWbRequisitionsListInternal", "9e57e14b-9e97-4608-bf4f-ebc97162c93a"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ScreenTableDownloadWbRequisitionsListInternal", "9e57e14b-9e97-4608-bf4f-ebc97162c93a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Foreach i_RequisitionsListInternalTableListStructure
localVars.inParami_RequisitionsListInternalTableListStructure.StartIteration();
try {while (!((localVars.inParami_RequisitionsListInternalTableListStructure.Eof))) {
// o_StringListIds = If
result.outParamo_StringListIds=(((result.outParamo_StringListIds=="")) ? ((BuiltInFunction.LongIntegerToText(localVars.inParami_RequisitionsListInternalTableListStructure.CurrentRec.ssRequisitionId)+",")) : (((result.outParamo_StringListIds+BuiltInFunction.LongIntegerToText(localVars.inParami_RequisitionsListInternalTableListStructure.CurrentRec.ssRequisitionId))+",")));

// o_StringListLevelIds = If
result.outParamo_StringListLevelIds=(((result.outParamo_StringListLevelIds=="")) ? ((BuiltInFunction.LongIntegerToText(localVars.inParami_RequisitionsListInternalTableListStructure.CurrentRec.ssRequisitionApprovalLevelId)+",")) : (((result.outParamo_StringListLevelIds+BuiltInFunction.LongIntegerToText(localVars.inParami_RequisitionsListInternalTableListStructure.CurrentRec.ssRequisitionApprovalLevelId))+",")));
localVars.inParami_RequisitionsListInternalTableListStructure.Advance();
}

} finally {
localVars.inParami_RequisitionsListInternalTableListStructure.EndIteration();
}

// empty?
if((localVars.inParami_RequisitionsListInternalTableListStructure.Empty)) {
// o_ErrorMsg = "Empty list."
result.outParamo_ErrorMsg=AppUtils.GetStringResource("9ELs7giSqka2pTACZhZ0Hg#Value.1383249565.1", "Empty list.");
} else {
if((localVars.inParami_IsXLS)) {
// RecordListToExcel RLToExcelScreenTableDownloadWbRequisitionsListInternalRecordListToExcel3
localVars.resRecordListToExcel3_outParamOut = await FuncActionScreenTableDownloadWbRequisitionsListInternal.RLToExcelScreenTableDownloadWbRequisitionsListInternalRecordListToExcel3(requestContext,localVars.inParami_RequisitionsListInternalTableListStructure,cancellationToken);

// File
// o_File.Name = "Requisitions" + " " + FormatDateTime + ".xlsx"
result.outParamo_File.ssName = (((AppUtils.GetStringResource("AxAxH8eT8keYwM_PgE28gA#Value.-446949513.1", "Requisitions")+" ")+BuiltInFunction.FormatDateTime (BuiltInFunction.CurrDate (), "yyyy/MM/dd"))+".xlsx");

// o_File.BinaryData = RecordListToExcel3
result.outParamo_File.ssBinaryData = localVars.resRecordListToExcel3_outParamOut;
} else {
if(localVars.inParami_IsCSV) {
// RecordListToExcel RLToExcelScreenTableDownloadWbRequisitionsListInternalRecordListToExcel4
localVars.resRecordListToExcel4_outParamOut = await FuncActionScreenTableDownloadWbRequisitionsListInternal.RLToExcelScreenTableDownloadWbRequisitionsListInternalRecordListToExcel4(requestContext,localVars.inParami_RequisitionsListInternalTableListStructure,cancellationToken);

// ConvertExcelBinaryToCsvBinary2
localVars.resConvertExcelBinaryToCsvBinary2_outParamConvertExcelBinaryToCsvBinary = await Actions.ActionConvertExcelBinaryToCsvBinary(requestContext,localVars.resRecordListToExcel4_outParamOut,cancellationToken);

// File
// o_File.Name = "Requisitions" + " " + FormatDateTime + ".csv"
result.outParamo_File.ssName = (((AppUtils.GetStringResource("GIcbpjyp1kCg9qpUqGGM2w#Value.-446949513.1", "Requisitions")+" ")+BuiltInFunction.FormatDateTime (BuiltInFunction.CurrDate (), "yyyy/MM/dd"))+".csv");

// o_File.BinaryData = ConvertExcelBinaryToCsvBinary2.ConvertExcelBinaryToCsvBinary
result.outParamo_File.ssBinaryData = localVars.resConvertExcelBinaryToCsvBinary2_outParamConvertExcelBinaryToCsvBinary;
} else {
if(localVars.inParami_IsPDF) {
// PrintToPDF
localVars.resPrintToPDF_outParamPDF = await Actions.ActionPrintToPDF(requestContext,((((((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores/TableDownloadRequisitionsListInternalScreenPDF?StringListIds=")+result.outParamo_StringListIds)+"&StringListLevelIds=")+result.outParamo_StringListLevelIds),new ST_201dce7bb255178c132fec4d547942aeStructure(){ ssBaseURL = ((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain]))) },cancellationToken);

// File
// o_File.Name = "Requisitions" + " " + FormatDateTime + ".pdf"
result.outParamo_File.ssName = (((AppUtils.GetStringResource("hCwoNY3XYkSqs0pTtTCJng#Value.-446949513.1", "Requisitions")+" ")+BuiltInFunction.FormatDateTime (BuiltInFunction.CurrDate (), "yyyy/MM/dd"))+".pdf");

// o_File.BinaryData = PrintToPDF.PDF
result.outParamo_File.ssBinaryData = localVars.resPrintToPDF_outParamPDF;
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

public static class FuncActionScreenTableDownloadWbRequisitionsListInternal {


/// <summary>
/// RecordList To Excel: RLToExcelScreenTableDownloadWbRequisitionsListInternalRecordListToExcel4
///  (KvAVYl18Ph0WB5sK9j_QkuQ) of Action "ScreenTableDownloadWbRequisitionsListInternal"
/// </summary>
public static async Task<byte[]> RLToExcelScreenTableDownloadWbRequisitionsListInternalRecordListToExcel4(IRequestContext requestContext,RL_622bdef78070a83f1d39501965da2144 ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(16, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("Requisicion");
excel.CreateCell("Estado");
excel.CreateCell("Fecha de creación");
excel.CreateCell("Último cambio");
excel.CreateCell("Solicitante");
excel.CreateCell("Proyecto");
excel.CreateCell("Proveedor");
excel.CreateCell("Región");
excel.CreateCell("Monto");
excel.CreateCell("Moneda");
excel.CreateCell("Centro de costos");
excel.CreateCell("Sociedad");
excel.CreateCell("Último aprobador");
excel.CreateCell("Fecha de aprobación");
excel.CreateCell("Número de póliza y Fecha");
excel.CreateCell("Acción");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssRequisitionName);
excel.CreateCell(ssRecordList.CurrentRec.ssRequisitionStatus);
excel.CreateCell(ssRecordList.CurrentRec.ssCreationDate);
excel.CreateCell(ssRecordList.CurrentRec.ssLastChange);
excel.CreateCell(ssRecordList.CurrentRec.ssRequester);
excel.CreateCell(ssRecordList.CurrentRec.ssProject);
excel.CreateCell(ssRecordList.CurrentRec.ssSupplier);
excel.CreateCell(ssRecordList.CurrentRec.ssRegion);
excel.CreateCell(ssRecordList.CurrentRec.ssAmount);
excel.CreateCell(ssRecordList.CurrentRec.ssCurrency);
excel.CreateCell(ssRecordList.CurrentRec.ssCostCenter);
excel.CreateCell(ssRecordList.CurrentRec.ssCompany);
excel.CreateCell(ssRecordList.CurrentRec.ssLastApprover);
excel.CreateCell(ssRecordList.CurrentRec.ssLastApproverApprovedOn);
excel.CreateCell(ssRecordList.CurrentRec.ssPolizaSAP_SentWhen);
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
/// RecordList To Excel: RLToExcelScreenTableDownloadWbRequisitionsListInternalRecordListToExcel3
///  (Kho_GzQYxT0ehhiTLZFmZ3A) of Action "ScreenTableDownloadWbRequisitionsListInternal"
/// </summary>
public static async Task<byte[]> RLToExcelScreenTableDownloadWbRequisitionsListInternalRecordListToExcel3(IRequestContext requestContext,RL_622bdef78070a83f1d39501965da2144 ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(16, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("Requisicion");
excel.CreateCell("Estado");
excel.CreateCell("Fecha de creación");
excel.CreateCell("Último cambio");
excel.CreateCell("Solicitante");
excel.CreateCell("Proyecto");
excel.CreateCell("Proveedor");
excel.CreateCell("Región");
excel.CreateCell("Monto");
excel.CreateCell("Moneda");
excel.CreateCell("Centro de costos");
excel.CreateCell("Sociedad");
excel.CreateCell("Último aprobador");
excel.CreateCell("Fecha de aprobación");
excel.CreateCell("Número de póliza y Fecha");
excel.CreateCell("Acción");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssRequisitionName);
excel.CreateCell(ssRecordList.CurrentRec.ssRequisitionStatus);
excel.CreateCell(ssRecordList.CurrentRec.ssCreationDate);
excel.CreateCell(ssRecordList.CurrentRec.ssLastChange);
excel.CreateCell(ssRecordList.CurrentRec.ssRequester);
excel.CreateCell(ssRecordList.CurrentRec.ssProject);
excel.CreateCell(ssRecordList.CurrentRec.ssSupplier);
excel.CreateCell(ssRecordList.CurrentRec.ssRegion);
excel.CreateCell(ssRecordList.CurrentRec.ssAmount);
excel.CreateCell(ssRecordList.CurrentRec.ssCurrency);
excel.CreateCell(ssRecordList.CurrentRec.ssCostCenter);
excel.CreateCell(ssRecordList.CurrentRec.ssCompany);
excel.CreateCell(ssRecordList.CurrentRec.ssLastApprover);
excel.CreateCell(ssRecordList.CurrentRec.ssLastApproverApprovedOn);
excel.CreateCell(ssRecordList.CurrentRec.ssPolizaSAP_SentWhen);
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
