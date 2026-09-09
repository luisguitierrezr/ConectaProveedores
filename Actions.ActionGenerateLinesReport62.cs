namespace ssConectaProveedores;

public partial class Actions {
public class lcvGenerateLinesReport62 : VarsBag {
public DateTime inParami_Report62_DateFrom;
public DateTime inParami_Report62_DateTo;
public long inParami_Report62_RegionId;
public long inParami_Report62_SupplierId;
public int inParami_OffsetUtc;
/// <summary>
/// Variable <code>LinesReport62List</code> that represents the Service Studio LinesReport62List
///  <code>LinesReport62List</code> <p>Description: </p>
/// </summary>
public RL_24b2300ac02e220a1b13ce501090881d varLcLinesReport62List = new RL_24b2300ac02e220a1b13ce501090881d();

public RL_6f578d989bb546e044c5b0b47d17f46f queryResGetInvoices_outParamList = new RL_6f578d989bb546e044c5b0b47d17f46f();
public long queryResGetInvoices_outParamCount = 0L;

public byte[] resConvertExcelBinaryToCsvBinary_outParamConvertExcelBinaryToCsvBinary = new byte[] {};

public byte[] resRecordListToExcel1_outParamOut = new byte[] {};
public lcvGenerateLinesReport62(DateTime inParami_Report62_DateFrom, DateTime inParami_Report62_DateTo, long inParami_Report62_RegionId, long inParami_Report62_SupplierId, int inParami_OffsetUtc) {
this.inParami_Report62_DateFrom = inParami_Report62_DateFrom;
this.inParami_Report62_DateTo = inParami_Report62_DateTo;
this.inParami_Report62_RegionId = inParami_Report62_RegionId;
this.inParami_Report62_SupplierId = inParami_Report62_SupplierId;
this.inParami_OffsetUtc = inParami_OffsetUtc;
}
}
public class lcoGenerateLinesReport62 : VarsBag {
public ST_a158c76eb93396680623c04244f48b6cStructure outParamFile = new ST_a158c76eb93396680623c04244f48b6cStructure();

public lcoGenerateLinesReport62() {
}
}
/// <summary>
/// Action <code>GenerateLinesReport62</code> that represents the Service Studio action
///  <code>GenerateLinesReport62</code> <p> Description: GenerateLinesReport62</p>
/// </summary>
public static async Task<ST_a158c76eb93396680623c04244f48b6cStructure> ActionGenerateLinesReport62(IRequestContext requestContext,DateTime inParami_Report62_DateFrom,DateTime inParami_Report62_DateTo,long inParami_Report62_RegionId,long inParami_Report62_SupplierId,int inParami_OffsetUtc,CancellationToken cancellationToken) {
ST_a158c76eb93396680623c04244f48b6cStructure outParamFile = default;
lcoGenerateLinesReport62 result = new lcoGenerateLinesReport62();
lcvGenerateLinesReport62 localVars = new lcvGenerateLinesReport62(inParami_Report62_DateFrom, inParami_Report62_DateTo, inParami_Report62_RegionId, inParami_Report62_SupplierId, inParami_OffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GenerateLinesReport62", "8232e595-6550-4669-88e3-5d291f7cbeef"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GenerateLinesReport62", "8232e595-6550-4669-88e3-5d291f7cbeef", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoices
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoices_maxRecords = 9999999;
if (datasetGetInvoices_maxRecords < 1) datasetGetInvoices_maxRecords = 1;
int datasetGetInvoices_startIndex = 0;(localVars.queryResGetInvoices_outParamList,localVars.queryResGetInvoices_outParamCount) = await FuncActionGenerateLinesReport62.datasetGetInvoices(requestContext,datasetGetInvoices_maxRecords,datasetGetInvoices_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),localVars.inParami_Report62_DateFrom,localVars.inParami_Report62_DateTo,localVars.inParami_Report62_RegionId,localVars.inParami_Report62_SupplierId,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcLinesReport62List,(await RL_24b2300ac02e220a1b13ce501090881d.ConvertAsync(localVars.queryResGetInvoices_outParamList, new RL_24b2300ac02e220a1b13ce501090881d(), async (RC_aa8eac9e200aee33e0be6438a23c61c3 source, ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure target, CancellationToken cancellationToken) => {
target.ssInvoiceNumber = source.ssENInvoice.ssName;
target.ssTotalAmount = source.ssENInvoice.ssTotalAmount;
target.ssAccountingDate = BuiltInFunction.FormatDateTime (BuiltInFunction.AddHours (source.ssENInvoicePoliza.ssCreatedOn, localVars.inParami_OffsetUtc), "dd/MM/yyyy");
target.ssAccountingUser = source.ssENUser.ssName;
target.ssEmployedNumber = source.ssENUser_Extended_Internal.ssEmployeeNumber;
target.ssDocNumber = source.ssENInvoicePoliza.ssPolizaSAP;
target.ssSupplierNumber = source.ssENInvoiceAccounting.ssSupplierNumber;
target.ssRegion = source.ssENRegion.ssCode;
target.ssDepartment = source.ssENDepartment.ssName;
target.ssManagement = source.ssENManagement.ssName;
target.ssDirection = source.ssENUser_Extended_Internal.ssTelcelDireccion;
target.ssInvoiceCreationDate = BuiltInFunction.FormatDateTime (BuiltInFunction.AddHours (source.ssENInvoice.ssCreatedOn, localVars.inParami_OffsetUtc), "dd/MM/yyyy");
target.ssCurrency = source.ssENInvoice.ssCurrency;
target.ssSupplierName = source.ssENSupplier.ssName;
target.ssPaymentDate = BuiltInFunction.FormatDateTime (BuiltInFunction.AddDays (BuiltInFunction.AddDays (BuiltInFunction.AddHours (source.ssENInvoice.ssCreatedOn, localVars.inParami_OffsetUtc), BuiltInFunction.TextToInteger (source.ssENPaymentTerms.ssCtd_dias)), (await Functions.ActionGetNextMonday(requestContext,BuiltInFunction.TextToDateTime (BuiltInFunction.DateTimeToText(BuiltInFunction.AddDays (BuiltInFunction.AddHours (source.ssENInvoice.ssCreatedOn, localVars.inParami_OffsetUtc), BuiltInFunction.TextToInteger (source.ssENPaymentTerms.ssCtd_dias)))),cancellationToken))), "dd/MM/yyyy");
target.ssExchangeType = BuiltInFunction.DecimalToText(source.ssENInvoiceExtended.ssTipoCambio);
return target;
}, cancellationToken)),cancellationToken);

// RecordListToExcel RLToExcelGenerateLinesReport62RecordListToExcel1
localVars.resRecordListToExcel1_outParamOut = await FuncActionGenerateLinesReport62.RLToExcelGenerateLinesReport62RecordListToExcel1(requestContext,localVars.varLcLinesReport62List,cancellationToken);

// ConvertExcelBinaryToCsvBinary
localVars.resConvertExcelBinaryToCsvBinary_outParamConvertExcelBinaryToCsvBinary = await Actions.ActionConvertExcelBinaryToCsvBinary(requestContext,localVars.resRecordListToExcel1_outParamOut,cancellationToken);

// File.BinaryData = ConvertExcelBinaryToCsvBinary.ConvertExcelBinaryToCsvBinary
result.outParamFile.ssBinaryData = localVars.resConvertExcelBinaryToCsvBinary_outParamConvertExcelBinaryToCsvBinary;

// File.Name = "LinesReport-" + CurrDate + ".csv"
result.outParamFile.ssName = ((AppUtils.GetStringResource("vr9niB+CQE+klf1ggm04zQ#Value.532079002.1", "LinesReport-")+BuiltInFunction.DateToText(BuiltInFunction.CurrDate ()))+".csv");
} //close CreateActionActivity using block
} // try

finally {
outParamFile = result.outParamFile;
} // inner-finally
RETURN_STATEMENT:
return outParamFile;
}

public static class FuncActionGenerateLinesReport62 {

private static async Task<RC_aa8eac9e200aee33e0be6438a23c61c3> datasetGetInvoicesReadDbAsync(RC_aa8eac9e200aee33e0be6438a23c61c3 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCurrency.Read( r, ref index);
rec.ssENDepartment.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccounting.Read( r, ref index);
rec.ssENInvoiceExtended.Read( r, ref index);
rec.ssENInvoicePoliza.Read( r, ref index);
rec.ssENInvoiceStatus.Read( r, ref index);
rec.ssENManagement.Read( r, ref index);
rec.ssENPaymentTerms.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetInvoices" U+MFEd0p8EmnRUOcHDE3YA of Action "GenerateLinesReport62"
public static async Task<(RL_6f578d989bb546e044c5b0b47d17f46f,long)> datasetGetInvoices(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,DateTime qpdai_Report62_DateFrom,DateTime qpdai_Report62_DateTo,long qpreRequisition_RegionId,long qpsuSupplier_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GenerateLinesReport62.GetInvoices", "1105e353-29dd-49f0-a745-439c1c313760");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GenerateLinesReport62.GetInvoices", "1105e353-29dd-49f0-a745-439c1c313760", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.leUyglBlaUaI410pH3y+7w/NodesNotShownInESpaceTree.U+MFEd0p8EmnRUOcHDE3YA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, \"endepartment5\".\"name\" o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, \"eninvoice34\".\"name\" o13, NULL o14, NULL o15, NULL o16, NULL o17, trim_scale(\"eninvoice34\".\"totalamount\"::numeric) o18, \"eninvoice34\".\"currency\" o19, NULL o20, NULL o21, NULL o22, \"eninvoice34\".\"createdon\" o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, \"eninvoiceaccounting6\".\"suppliernumber\" o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, trim_scale(\"eninvoiceextended9\".\"tipocambio\"::numeric) o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, \"eninvoicepoliza1\".\"polizasap\" o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, \"eninvoicepoliza1\".\"createdon\" o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, \"enmanagement\".\"name\" o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, \"enpaymentterms7\".\"ctd_dias\" o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, \"enregion35\".\"code\" o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, NULL o161, NULL o162, NULL o163, NULL o164, NULL o165, NULL o166, NULL o167, NULL o168, NULL o169, NULL o170, NULL o171, NULL o172, NULL o173, NULL o174, NULL o175, NULL o176, NULL o177, NULL o178, NULL o179, NULL o180, NULL o181, NULL o182, \"ensupplier23\".\"name\" o183, NULL o184, NULL o185, NULL o186, NULL o187, NULL o188, NULL o189, NULL o190, NULL o191, NULL o192, NULL o193, NULL o194, NULL o195, NULL o196, NULL o197, NULL o198, NULL o199, NULL o200, NULL o201, NULL o202, NULL o203, NULL o204, NULL o205, NULL o206, NULL o207, NULL o208, NULL o209, \"enuser81\".\"name\" o210, NULL o211, NULL o212, NULL o213, NULL o214, \"enuser_extended_internal49\".\"employeenumber\" o215, NULL o216, NULL o217, NULL o218, NULL o219, NULL o220, NULL o221, NULL o222, NULL o223, NULL o224, NULL o225, NULL o226, NULL o227, NULL o228, NULL o229, NULL o230, NULL o231, NULL o232, \"enuser_extended_internal49\".\"telceldireccion\" o233");
fromBuilder.Append(" FROM ((((((((((((({Invoice} \"eninvoice34\" Inner JOIN {Requisition} \"enrequisition33\" ON (\"eninvoice34\".\"requisitionid\" = \"enrequisition33\".\"id\"))  Left JOIN {Supplier} \"ensupplier23\" ON (\"enrequisition33\".\"supplierid\" = \"ensupplier23\".\"id\"))  Left JOIN {Region} \"enregion35\" ON (\"enrequisition33\".\"regionid\" = \"enregion35\".\"id\"))  Left JOIN {InvoiceStatus} \"eninvoicestatus2\" ON (\"eninvoice34\".\"invoicestatusid\" = \"eninvoicestatus2\".\"id\"))  Left JOIN {InvoiceAccounting} \"eninvoiceaccounting6\" ON (\"eninvoice34\".\"id\" = \"eninvoiceaccounting6\".\"invoiceid\"))  Left JOIN {User} \"enuser81\" ON (\"eninvoiceaccounting6\".\"submissionby\" = \"enuser81\".\"id\"))  Left JOIN {User_Extended_Internal} \"enuser_extended_internal49\" ON (\"enuser81\".\"id\" = \"enuser_extended_internal49\".\"id\"))  Inner JOIN {Department} \"endepartment5\" ON (\"enuser_extended_internal49\".\"departmentid\" = \"endepartment5\".\"id\"))  Left JOIN {Currency} \"encurrency2\" ON (\"enrequisition33\".\"currencyid\" = \"encurrency2\".\"code\"))  Left JOIN {InvoicePoliza} \"eninvoicepoliza1\" ON (\"eninvoice34\".\"id\" = \"eninvoicepoliza1\".\"id\"))  Left JOIN {Management} \"enmanagement\" ON (\"enuser_extended_internal49\".\"managementid\" = \"enmanagement\".\"id\"))  Left JOIN {PaymentTerms} \"enpaymentterms7\" ON (\"eninvoiceaccounting6\".\"paymenttermsid\" = \"enpaymentterms7\".\"id\"))  Left JOIN {InvoiceExtended} \"eninvoiceextended9\" ON (\"eninvoice34\".\"id\" = \"eninvoiceextended9\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpreRequisition_RegionId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpreRequisition_RegionId != 0) {
whereBuilder.Append("((\"enrequisition33\".\"regionid\" = @qpreRequisition_RegionId) AND (\"enrequisition33\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId", DbType.Int64, qpreRequisition_RegionId);
} else {
whereBuilder.Append("(\"enrequisition33\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpsuSupplier_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier23\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier23\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier23\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpdai_Report62_DateFrom != BuiltInFunction.NullDate()) {
whereBuilder.Append("((cast(\"eninvoice34\".\"createdon\" as date)::timestamptz) >= @qpdai_Report62_DateFrom) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdai_Report62_DateFrom", DbType.DateTime, qpdai_Report62_DateFrom);
}
if (qpdai_Report62_DateTo != BuiltInFunction.NullDate()) {
whereBuilder.Append("((cast(\"eninvoice34\".\"createdon\" as date)::timestamptz) <= @qpdai_Report62_DateTo)");
sqlCmd.CreateParameterWithoutReplacements("@qpdai_Report62_DateTo", DbType.DateTime, qpdai_Report62_DateTo);
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
orderByBuilder.Append(" ORDER BY \"eninvoice34\".\"createdon\" DESC ");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_6f578d989bb546e044c5b0b47d17f46f outParamList = new RL_6f578d989bb546e044c5b0b47d17f46f();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[14];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, false, false, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, false});
opt[6] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true});
opt[8] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false});
opt[9] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[10] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[11] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[12] = new BitArray(new bool[] {true, true, true, true, false, true, true, true, true, true, true});
opt[13] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GenerateLinesReport62.GetInvoices.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_6f578d989bb546e044c5b0b47d17f46f _tmp = new RL_6f578d989bb546e044c5b0b47d17f46f();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GenerateLinesReport62.GetInvoices.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_6f578d989bb546e044c5b0b47d17f46f)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}


/// <summary>
/// RecordList To Excel: RLToExcelGenerateLinesReport62RecordListToExcel1 (KU4hOxfKgD0aMkV0gfCXFGg) of
///  Action "GenerateLinesReport62"
/// </summary>
public static async Task<byte[]> RLToExcelGenerateLinesReport62RecordListToExcel1(IRequestContext requestContext,RL_24b2300ac02e220a1b13ce501090881d ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(16, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("Folio de Factura");
excel.CreateCell("Monto");
excel.CreateCell("Fecha de Contabilización");
excel.CreateCell("Usuario");
excel.CreateCell("Número de Empleado");
excel.CreateCell("Póliza contable");
excel.CreateCell("Número de Acreedor");
excel.CreateCell("Región");
excel.CreateCell("Departamento");
excel.CreateCell("Gerencia");
excel.CreateCell("Dirección");
excel.CreateCell("Fecha de la Factura");
excel.CreateCell("Moneda");
excel.CreateCell("Nombre de proveedor");
excel.CreateCell("Fecha de Pago");
excel.CreateCell("Tipo de Cambio");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssInvoiceNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssTotalAmount);
excel.CreateCell(ssRecordList.CurrentRec.ssAccountingDate);
excel.CreateCell(ssRecordList.CurrentRec.ssAccountingUser);
excel.CreateCell(ssRecordList.CurrentRec.ssEmployedNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssDocNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssSupplierNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssRegion);
excel.CreateCell(ssRecordList.CurrentRec.ssDepartment);
excel.CreateCell(ssRecordList.CurrentRec.ssManagement);
excel.CreateCell(ssRecordList.CurrentRec.ssDirection);
excel.CreateCell(ssRecordList.CurrentRec.ssInvoiceCreationDate);
excel.CreateCell(ssRecordList.CurrentRec.ssCurrency);
excel.CreateCell(ssRecordList.CurrentRec.ssSupplierName);
excel.CreateCell(ssRecordList.CurrentRec.ssPaymentDate);
excel.CreateCell(ssRecordList.CurrentRec.ssExchangeType);

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
