namespace ssConectaProveedores;

public partial class Actions {
public class lcvGenerateCurrentAccountCSV : VarsBag {
public ST_382afa1d8361f400b6ea03403d75e294Structure inParamResponse;
/// <summary>
/// Variable <code>AccountFAC_PAG_OutStruct</code> that represents the Service Studio
///  CurrentAccountFAC_PAG_OutStructList <code>AccountFAC_PAG_OutStruct</code> <p>Description: </p>
/// </summary>
public RL_cdf1999ec7b32c2eb5fd2f2dd542197b varLcAccountFAC_PAG_OutStruct = new RL_cdf1999ec7b32c2eb5fd2f2dd542197b();

/// <summary>
/// Variable <code>AccountFACT_PEN_PAGStruct</code> that represents the Service Studio
///  CurrentAccountFACT_PEN_PAGStructList <code>AccountFACT_PEN_PAGStruct</code> <p>Description: </p>
/// </summary>
public RL_63f162121e2362744dd9f896d80895f7 varLcAccountFACT_PEN_PAGStruct = new RL_63f162121e2362744dd9f896d80895f7();

public byte[] resRecordListToExcel1_outParamOut = new byte[] {};
public byte[] resRecordListToExcel2_outParamOut = new byte[] {};
public byte[] resGetZIPBinary_outParamZIPBinary = new byte[] {};

public byte[] resConvertExcelBinaryToCsvBinary_outParamConvertExcelBinaryToCsvBinary = new byte[] {};

public object resCreateZIP_outParamZIPHandle = null;

public byte[] resConvertExcelBinaryToCsvBinary2_outParamConvertExcelBinaryToCsvBinary = new byte[] {};

public lcvGenerateCurrentAccountCSV(ST_382afa1d8361f400b6ea03403d75e294Structure inParamResponse) {
this.inParamResponse = inParamResponse;
}
}
public class lcoGenerateCurrentAccountCSV : VarsBag {
public byte[] outParamfile = new byte[] {};

public lcoGenerateCurrentAccountCSV() {
}
}
/// <summary>
/// Action <code>GenerateCurrentAccountCSV</code> that represents the Service Studio action
///  <code>GenerateCurrentAccountCSV</code> <p> Description: </p>
/// </summary>
public static async Task<byte[]> ActionGenerateCurrentAccountCSV(IRequestContext requestContext,ST_382afa1d8361f400b6ea03403d75e294Structure inParamResponse,CancellationToken cancellationToken) {
byte[] outParamfile = default;
lcoGenerateCurrentAccountCSV result = new lcoGenerateCurrentAccountCSV();
lcvGenerateCurrentAccountCSV localVars = new lcvGenerateCurrentAccountCSV(inParamResponse);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GenerateCurrentAccountCSV", "83743934-3c90-4a86-ac84-5c788844287e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GenerateCurrentAccountCSV", "83743934-3c90-4a86-ac84-5c788844287e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcAccountFAC_PAG_OutStruct,(await RL_cdf1999ec7b32c2eb5fd2f2dd542197b.ConvertAsync(localVars.inParamResponse.ssT_FAC_PAG_Out, new RL_cdf1999ec7b32c2eb5fd2f2dd542197b(), async (ST_99acd807840db0272ca95b7e5ca3fca1Structure source, ST_89af93fec4915ac38f0ef9c0a1b729beStructure target, CancellationToken cancellationToken) => {
target.ssKURSF = source.ssKURSF;
target.ssAUGBL = source.ssAUGBL;
target.ssWRBTR = source.ssWRBTR;
target.ssLIFNR = source.ssLIFNR;
target.ssWRBT2 = source.ssWRBT2;
target.ssWRBT3 = source.ssWRBT3;
target.ssXBLNR = source.ssXBLNR;
target.ssZUONR = source.ssZUONR;
target.ssZFBDT = source.ssZFBDT;
target.ssZTERM = source.ssZTERM;
target.ssAUGDT = source.ssAUGDT;
target.ssWAERS = source.ssWAERS;
target.ssBLART = source.ssBLART;
target.ssZLSCH = source.ssZLSCH;
target.ssUSNAM = source.ssUSNAM;
target.ssUSRID_LONG = source.ssUSRID_LONG;
return target;
}, cancellationToken)),cancellationToken);

// ListAppendAll2
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcAccountFACT_PEN_PAGStruct,(await RL_63f162121e2362744dd9f896d80895f7.ConvertAsync(localVars.inParamResponse.ssT_FACT_PEN_PAG_Out, new RL_63f162121e2362744dd9f896d80895f7(), async (ST_9f44b824af1405b8fbe038a5a393bb86Structure source, ST_6e58a6c07a695cdbbb36aed76c927a26Structure target, CancellationToken cancellationToken) => {
target.ssXBLNR = source.ssXBLNR;
target.ssZUONR = source.ssZUONR;
target.ssZFBDT = source.ssZFBDT;
target.ssZTERM = source.ssZTERM;
target.ssAUGDT = source.ssAUGDT;
target.ssWRBTR = source.ssWRBTR;
target.ssWAERS = source.ssWAERS;
target.ssWRBT2 = source.ssWRBT2;
target.ssWRBT3 = source.ssWRBT3;
target.ssUMSKZ = source.ssUMSKZ;
target.ssBLART = source.ssBLART;
target.ssZLSCH = source.ssZLSCH;
target.ssKURSF = source.ssKURSF;
target.ssUSNAM = source.ssUSNAM;
target.ssUSRID_LONG = source.ssUSRID_LONG;
return target;
}, cancellationToken)),cancellationToken);

// RecordListToExcel RLToExcelGenerateCurrentAccountCSVRecordListToExcel1
localVars.resRecordListToExcel1_outParamOut = await FuncActionGenerateCurrentAccountCSV.RLToExcelGenerateCurrentAccountCSVRecordListToExcel1(requestContext,localVars.varLcAccountFACT_PEN_PAGStruct,cancellationToken);

// RecordListToExcel RLToExcelGenerateCurrentAccountCSVRecordListToExcel2
localVars.resRecordListToExcel2_outParamOut = await FuncActionGenerateCurrentAccountCSV.RLToExcelGenerateCurrentAccountCSVRecordListToExcel2(requestContext,localVars.varLcAccountFAC_PAG_OutStruct,cancellationToken);

// ConvertExcelBinaryToCsvBinary
localVars.resConvertExcelBinaryToCsvBinary_outParamConvertExcelBinaryToCsvBinary = await Actions.ActionConvertExcelBinaryToCsvBinary(requestContext,localVars.resRecordListToExcel1_outParamOut,cancellationToken);

// ConvertExcelBinaryToCsvBinary2
localVars.resConvertExcelBinaryToCsvBinary2_outParamConvertExcelBinaryToCsvBinary = await Actions.ActionConvertExcelBinaryToCsvBinary(requestContext,localVars.resRecordListToExcel2_outParamOut,cancellationToken);

// CreateZIP
localVars.resCreateZIP_outParamZIPHandle = await Actions.ActionCreateZIP(requestContext,5,cancellationToken);

// AddFile
await Actions.ActionAddFile(requestContext,localVars.resCreateZIP_outParamZIPHandle,"FaturasPendentesPagamento.csv",BuiltInFunction.CurrDateTime (),localVars.resConvertExcelBinaryToCsvBinary_outParamConvertExcelBinaryToCsvBinary,cancellationToken);

// AddFile2
await Actions.ActionAddFile(requestContext,localVars.resCreateZIP_outParamZIPHandle,"FacturasPagadasCompensadas.csv",BuiltInFunction.CurrDateTime (),localVars.resConvertExcelBinaryToCsvBinary2_outParamConvertExcelBinaryToCsvBinary,cancellationToken);

// CommitChanges
await Actions.ActionCommitChanges(requestContext,localVars.resCreateZIP_outParamZIPHandle,cancellationToken);

// GetZIPBinary
localVars.resGetZIPBinary_outParamZIPBinary = await Actions.ActionGetZIPBinary(requestContext,localVars.resCreateZIP_outParamZIPHandle,cancellationToken);

// file = GetZIPBinary.ZIPBinary
result.outParamfile=localVars.resGetZIPBinary_outParamZIPBinary;
} //close CreateActionActivity using block
} // try

finally {
outParamfile = result.outParamfile;
} // inner-finally
RETURN_STATEMENT:
return outParamfile;
}

public static class FuncActionGenerateCurrentAccountCSV {


/// <summary>
/// RecordList To Excel: RLToExcelGenerateCurrentAccountCSVRecordListToExcel1 (Kn9nnKJP80EO9oL08wxkP2Q)
///  of Action "GenerateCurrentAccountCSV"
/// </summary>
public static async Task<byte[]> RLToExcelGenerateCurrentAccountCSVRecordListToExcel1(IRequestContext requestContext,RL_63f162121e2362744dd9f896d80895f7 ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(13, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("Número de documento de referencia");
excel.CreateCell("Número de asignación");
excel.CreateCell("Fecha base para cálculo del vencimiento");
excel.CreateCell("Clave de las condiciones de pago");
excel.CreateCell("Fecha de la compensación");
excel.CreateCell("Importe en la moneda del documento");
excel.CreateCell("Clave de moneda");
excel.CreateCell("Importe total de facturas moneda nacional");
excel.CreateCell("Importe total de facturas moneda extranjera");
excel.CreateCell("Indicador de operación en cuenta de mayor especial");
excel.CreateCell("Clase de documento");
excel.CreateCell("Vía de pago");
excel.CreateCell("Tipo de cambio");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssXBLNR);
excel.CreateCell(ssRecordList.CurrentRec.ssZUONR);
excel.CreateCellDate(ssRecordList.CurrentRec.ssZFBDT);
excel.CreateCell(ssRecordList.CurrentRec.ssZTERM);
excel.CreateCellDate(ssRecordList.CurrentRec.ssAUGDT);
excel.CreateCell(ssRecordList.CurrentRec.ssWRBTR);
excel.CreateCell(ssRecordList.CurrentRec.ssWAERS);
excel.CreateCell(ssRecordList.CurrentRec.ssWRBT2);
excel.CreateCell(ssRecordList.CurrentRec.ssWRBT3);
excel.CreateCell(ssRecordList.CurrentRec.ssUMSKZ);
excel.CreateCell(ssRecordList.CurrentRec.ssBLART);
excel.CreateCell(ssRecordList.CurrentRec.ssZLSCH);
excel.CreateCell(ssRecordList.CurrentRec.ssKURSF);

            ssRecordList.Advance(); 
		}
	} finally {
		ssRecordList.EndIteration();
	}
}

return await excel.SaveAsync(cancellationToken);
}

/// <summary>
/// RecordList To Excel: RLToExcelGenerateCurrentAccountCSVRecordListToExcel2 (K0qnfb1zyWEOIHFB_KZwzjQ)
///  of Action "GenerateCurrentAccountCSV"
/// </summary>
public static async Task<byte[]> RLToExcelGenerateCurrentAccountCSVRecordListToExcel2(IRequestContext requestContext,RL_cdf1999ec7b32c2eb5fd2f2dd542197b ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(14, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("Tipo de cambio");
excel.CreateCell("Número del documento de compensación");
excel.CreateCell("Importe en la moneda del documento");
excel.CreateCell("Número de cuenta del proveedor o acreedor");
excel.CreateCell("Total de facturas Moneda Nacional");
excel.CreateCell("Total de facturas Moneda Extranjero");
excel.CreateCell("Factura");
excel.CreateCell("Número de asignación");
excel.CreateCell("Fecha base para cálculo del vencimiento");
excel.CreateCell("Clave de las condiciones de pago");
excel.CreateCell("Fecha de la compensación");
excel.CreateCell("Clave de moneda");
excel.CreateCell("Clase de documento");
excel.CreateCell("Vía de pago");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssKURSF);
excel.CreateCell(ssRecordList.CurrentRec.ssAUGBL);
excel.CreateCell(ssRecordList.CurrentRec.ssWRBTR);
excel.CreateCell(ssRecordList.CurrentRec.ssLIFNR);
excel.CreateCell(ssRecordList.CurrentRec.ssWRBT2);
excel.CreateCell(ssRecordList.CurrentRec.ssWRBT3);
excel.CreateCell(ssRecordList.CurrentRec.ssXBLNR);
excel.CreateCell(ssRecordList.CurrentRec.ssZUONR);
excel.CreateCellDate(ssRecordList.CurrentRec.ssZFBDT);
excel.CreateCell(ssRecordList.CurrentRec.ssZTERM);
excel.CreateCellDate(ssRecordList.CurrentRec.ssAUGDT);
excel.CreateCell(ssRecordList.CurrentRec.ssWAERS);
excel.CreateCell(ssRecordList.CurrentRec.ssBLART);
excel.CreateCell(ssRecordList.CurrentRec.ssZLSCH);

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
