namespace ssConectaProveedores;

public partial class Actions {
public class lcvScreenTableDownloadOrderScreen : VarsBag {
public bool inParami_IsCSV;
public bool inParami_IsPDF;
public bool inParami_IsXLS;
public RL_68002bbb4e227fd5533d460e5a56bbd4 inParaml_OrderScreenTableStructure;
public byte[] resRecordListToExcel1_outParamOut = new byte[] {};
public byte[] resConvertExcelBinaryToCsvBinary_outParamConvertExcelBinaryToCsvBinary = new byte[] {};

public byte[] resPrintToPDF_outParamPDF = new byte[] {};

public byte[] resRecordListToExcel2_outParamOut = new byte[] {};
public Actions.lcoVerifyBinaryFileSize resVerifyBinaryFileSize =  new Actions.lcoVerifyBinaryFileSize();
public lcvScreenTableDownloadOrderScreen(bool inParami_IsCSV, bool inParami_IsPDF, bool inParami_IsXLS, RL_68002bbb4e227fd5533d460e5a56bbd4 inParaml_OrderScreenTableStructure) {
this.inParami_IsCSV = inParami_IsCSV;
this.inParami_IsPDF = inParami_IsPDF;
this.inParami_IsXLS = inParami_IsXLS;
this.inParaml_OrderScreenTableStructure = inParaml_OrderScreenTableStructure;
}
}
public class lcoScreenTableDownloadOrderScreen : VarsBag {
public ST_a158c76eb93396680623c04244f48b6cStructure outParamo_File = new ST_a158c76eb93396680623c04244f48b6cStructure();

public string outParamo_StringListIds = "";

public string outParamo_ErrorMsg = "";

public lcoScreenTableDownloadOrderScreen() {
}
}
/// <summary>
/// Action <code>ScreenTableDownloadOrderScreen</code> that represents the Service Studio action
///  <code>ScreenTableDownloadOrderScreen</code> <p> Description: ScreenTableDownloadOrderScreen</p>
/// </summary>
public static async Task<(ST_a158c76eb93396680623c04244f48b6cStructure,string,string)> ActionScreenTableDownloadOrderScreen(IRequestContext requestContext,bool inParami_IsCSV,bool inParami_IsPDF,bool inParami_IsXLS,RL_68002bbb4e227fd5533d460e5a56bbd4 inParaml_OrderScreenTableStructure,CancellationToken cancellationToken) {
ST_a158c76eb93396680623c04244f48b6cStructure outParamo_File = default;
string outParamo_StringListIds = default;
string outParamo_ErrorMsg = default;
lcoScreenTableDownloadOrderScreen result = new lcoScreenTableDownloadOrderScreen();
lcvScreenTableDownloadOrderScreen localVars = new lcvScreenTableDownloadOrderScreen(inParami_IsCSV, inParami_IsPDF, inParami_IsXLS, inParaml_OrderScreenTableStructure);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ScreenTableDownloadOrderScreen", "8c7955cc-5a81-4e60-90d9-75aedc1adc4f"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ScreenTableDownloadOrderScreen", "8c7955cc-5a81-4e60-90d9-75aedc1adc4f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Foreach l_OrderScreenTableStructure
localVars.inParaml_OrderScreenTableStructure.StartIteration();
try {while (!((localVars.inParaml_OrderScreenTableStructure.Eof))) {
// o_StringListIds = If
result.outParamo_StringListIds=(((result.outParamo_StringListIds=="")) ? ((BuiltInFunction.LongIntegerToText(localVars.inParaml_OrderScreenTableStructure.CurrentRec.ssOrderMainId)+",")) : (((result.outParamo_StringListIds+BuiltInFunction.LongIntegerToText(localVars.inParaml_OrderScreenTableStructure.CurrentRec.ssOrderMainId))+",")));
localVars.inParaml_OrderScreenTableStructure.Advance();
}

} finally {
localVars.inParaml_OrderScreenTableStructure.EndIteration();
}

// empty?
if((localVars.inParaml_OrderScreenTableStructure.Empty)) {
// o_ErrorMsg = "Empty list."
result.outParamo_ErrorMsg=AppUtils.GetStringResource("hoRBSIhkY06ujaTpuPsYRg#Value.1383249565.1", "Empty list.");
} else {
if((localVars.inParami_IsPDF)) {
// PrintToPDF
localVars.resPrintToPDF_outParamPDF = await Actions.ActionPrintToPDF(requestContext,((((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain])))+"ConectaProveedores/TableDownloadOrderPDF?StringListIds=")+result.outParamo_StringListIds),new ST_201dce7bb255178c132fec4d547942aeStructure(){ ssBaseURL = ((((string)AppUtils.SiteProperties[SitePropertiesModel.spCurrentDomain]))) },cancellationToken);

// File
// o_File.Name = "Order" + " " + CurrDate + ".pdf"
result.outParamo_File.ssName = (((AppUtils.GetStringResource("o0thjO1y10C25UQ_503ETw#Value.76453678.1", "Order")+" ")+BuiltInFunction.DateToText(BuiltInFunction.CurrDate ()))+".pdf");

// o_File.BinaryData = PrintToPDF.PDF
result.outParamo_File.ssBinaryData = localVars.resPrintToPDF_outParamPDF;
} else {
if(localVars.inParami_IsXLS) {
// RecordListToExcel RLToExcelScreenTableDownloadOrderScreenRecordListToExcel1
localVars.resRecordListToExcel1_outParamOut = await FuncActionScreenTableDownloadOrderScreen.RLToExcelScreenTableDownloadOrderScreenRecordListToExcel1(requestContext,localVars.inParaml_OrderScreenTableStructure,cancellationToken);

// File
// o_File.Name = "Orders" + " " + CurrDate + ".xlsx"
result.outParamo_File.ssName = (((AppUtils.GetStringResource("TbC5cstuuEKBZ6+G4dn+6A#Value.-1924903163.1", "Orders")+" ")+BuiltInFunction.DateToText(BuiltInFunction.CurrDate ()))+".xlsx");

// o_File.BinaryData = RecordListToExcel1
result.outParamo_File.ssBinaryData = localVars.resRecordListToExcel1_outParamOut;
} else {
if(localVars.inParami_IsCSV) {
// RecordListToExcel RLToExcelScreenTableDownloadOrderScreenRecordListToExcel2
localVars.resRecordListToExcel2_outParamOut = await FuncActionScreenTableDownloadOrderScreen.RLToExcelScreenTableDownloadOrderScreenRecordListToExcel2(requestContext,localVars.inParaml_OrderScreenTableStructure,cancellationToken);

// ConvertExcelBinaryToCsvBinary
localVars.resConvertExcelBinaryToCsvBinary_outParamConvertExcelBinaryToCsvBinary = await Actions.ActionConvertExcelBinaryToCsvBinary(requestContext,localVars.resRecordListToExcel2_outParamOut,cancellationToken);

// File
// o_File.Name = "Folios" + " " + CurrDate + ".csv"
result.outParamo_File.ssName = (((AppUtils.GetStringResource("kG7pw4Y9ZUy_BGWr1nsvbQ#Value.2109873290.1", "Folios")+" ")+BuiltInFunction.DateToText(BuiltInFunction.CurrDate ()))+".csv");

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

public static class FuncActionScreenTableDownloadOrderScreen {


/// <summary>
/// RecordList To Excel: RLToExcelScreenTableDownloadOrderScreenRecordListToExcel1
///  (KL3j8RS_PmUGQ9JtwMIPJiQ) of Action "ScreenTableDownloadOrderScreen"
/// </summary>
public static async Task<byte[]> RLToExcelScreenTableDownloadOrderScreenRecordListToExcel1(IRequestContext requestContext,RL_68002bbb4e227fd5533d460e5a56bbd4 ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(9, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("Approval Status");
excel.CreateCell("Order Number");
excel.CreateCell("Order Status");
excel.CreateCell("Supplier");
excel.CreateCell("Buyer");
excel.CreateCell("Company");
excel.CreateCell("Region");
excel.CreateCell("Currency");
excel.CreateCell("Total Amount");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssApprovalStatus);
excel.CreateCell(ssRecordList.CurrentRec.ssOrderNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssOrderStatus);
excel.CreateCell(ssRecordList.CurrentRec.ssSupplierName_Number);
excel.CreateCell(ssRecordList.CurrentRec.ssBuyer);
excel.CreateCell(ssRecordList.CurrentRec.ssCompany);
excel.CreateCell(ssRecordList.CurrentRec.ssRegion);
excel.CreateCell(ssRecordList.CurrentRec.ssCurrency);
excel.CreateCell(ssRecordList.CurrentRec.ssTotalAmount);

            ssRecordList.Advance(); 
		}
	} finally {
		ssRecordList.EndIteration();
	}
}

return await excel.SaveAsync(cancellationToken);
}

/// <summary>
/// RecordList To Excel: RLToExcelScreenTableDownloadOrderScreenRecordListToExcel2
///  (KXh8kzN5bVEKWqMIjuslZnw) of Action "ScreenTableDownloadOrderScreen"
/// </summary>
public static async Task<byte[]> RLToExcelScreenTableDownloadOrderScreenRecordListToExcel2(IRequestContext requestContext,RL_68002bbb4e227fd5533d460e5a56bbd4 ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(9, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("Approval Status");
excel.CreateCell("Order Number");
excel.CreateCell("Order Status");
excel.CreateCell("Supplier");
excel.CreateCell("Buyer");
excel.CreateCell("Company");
excel.CreateCell("Region");
excel.CreateCell("Currency");
excel.CreateCell("Total Amount");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssApprovalStatus);
excel.CreateCell(ssRecordList.CurrentRec.ssOrderNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssOrderStatus);
excel.CreateCell(ssRecordList.CurrentRec.ssSupplierName_Number);
excel.CreateCell(ssRecordList.CurrentRec.ssBuyer);
excel.CreateCell(ssRecordList.CurrentRec.ssCompany);
excel.CreateCell(ssRecordList.CurrentRec.ssRegion);
excel.CreateCell(ssRecordList.CurrentRec.ssCurrency);
excel.CreateCell(ssRecordList.CurrentRec.ssTotalAmount);

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
