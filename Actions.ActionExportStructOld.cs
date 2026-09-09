namespace ssConectaProveedores;

public partial class Actions {
public class lcvExportStructOld : VarsBag {
/// <summary>
/// Variable <code>OrderDistributionImportStruc</code> that represents the Service Studio
///  OrderDistributionImportStrucList <code>OrderDistributionImportStruc</code> <p>Description: </p>
/// </summary>
public RL_e5599d6b39ff4d762401f24c2e9326ab varLcOrderDistributionImportStruc = new RL_e5599d6b39ff4d762401f24c2e9326ab();

public byte[] resRecordListToExcel1_outParamOut = new byte[] {};
public lcvExportStructOld() {
}
}
public class lcoExportStructOld : VarsBag {
public byte[] outParamStruct = new byte[] {};

public lcoExportStructOld() {
}
}
/// <summary>
/// Action <code>ExportStructOld</code> that represents the Service Studio action
///  <code>ExportStructOld</code> <p> Description: </p>
/// </summary>
public static async Task<byte[]> ActionExportStructOld(IRequestContext requestContext,CancellationToken cancellationToken) {
byte[] outParamStruct = default;
lcoExportStructOld result = new lcoExportStructOld();
lcvExportStructOld localVars = new lcvExportStructOld();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ExportStructOld", "a8b05e61-39a9-4f8a-8321-cc807bf08aa9"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ExportStructOld", "a8b05e61-39a9-4f8a-8321-cc807bf08aa9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// RecordListToExcel RLToExcelExportStructOldRecordListToExcel1
localVars.resRecordListToExcel1_outParamOut = await FuncActionExportStructOld.RLToExcelExportStructOldRecordListToExcel1(requestContext,localVars.varLcOrderDistributionImportStruc,cancellationToken);

// Struct = RecordListToExcel1
result.outParamStruct=localVars.resRecordListToExcel1_outParamOut;
} //close CreateActionActivity using block
} // try

finally {
outParamStruct = result.outParamStruct;
} // inner-finally
RETURN_STATEMENT:
return outParamStruct;
}

public static class FuncActionExportStructOld {


/// <summary>
/// RecordList To Excel: RLToExcelExportStructOldRecordListToExcel1 (KtT0M5h9zw0OSx4fagJP7mg) of Action
///  "ExportStructOld"
/// </summary>
public static async Task<byte[]> RLToExcelExportStructOldRecordListToExcel1(IRequestContext requestContext,RL_e5599d6b39ff4d762401f24c2e9326ab ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(8, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("División");
excel.CreateCell("Solicitante");
excel.CreateCell("Descripción de la solicitante");
excel.CreateCell("Dirección");
excel.CreateCell("Primer contacto");
excel.CreateCell("Segundo contacto");
excel.CreateCell("Primer aprobador");
excel.CreateCell("Segundo aprobador");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssDivision);
excel.CreateCell(ssRecordList.CurrentRec.ssApplicant);
excel.CreateCell(ssRecordList.CurrentRec.ssApplicantDescription);
excel.CreateCell(ssRecordList.CurrentRec.ssDirection);
excel.CreateCell(ssRecordList.CurrentRec.ssFirstContact);
excel.CreateCell(ssRecordList.CurrentRec.ssSecondContact);
excel.CreateCell(ssRecordList.CurrentRec.ssFirstApprover);
excel.CreateCell(ssRecordList.CurrentRec.ssSecondApprover);

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
