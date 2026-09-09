namespace ssConectaProveedores;

public partial class Actions {
public class lcvFindByDateRanges : VarsBag {
public byte[] inParamfile;
public Actions.lcoValidateDate resValidateDate4 =  new Actions.lcoValidateDate();
public RL_1d4c61caa98ecb2b0573c3d151f4f72a queryResGetInvoiceFiles2_outParamList = new RL_1d4c61caa98ecb2b0573c3d151f4f72a();
public long queryResGetInvoiceFiles2_outParamCount = 0L;

public Actions.lcoValidateDate resValidateDate3 =  new Actions.lcoValidateDate();
public RL_2b2250dae3adb3f820f24fa2783032d4 resExcelToRecordList1_outParamOut = new RL_2b2250dae3adb3f820f24fa2783032d4();
public RL_4236ffd993178ba431a66b30d7460972 resListDistinct_outParamDistinctList = new RL_4236ffd993178ba431a66b30d7460972();

public RL_1d4c61caa98ecb2b0573c3d151f4f72a queryResGetInvoiceFiles_outParamList = new RL_1d4c61caa98ecb2b0573c3d151f4f72a();
public long queryResGetInvoiceFiles_outParamCount = 0L;

public Actions.lcoValidateDate resValidateDate6 =  new Actions.lcoValidateDate();
public Actions.lcoValidateDate resValidateDate5 =  new Actions.lcoValidateDate();
public lcvFindByDateRanges(byte[] inParamfile) {
this.inParamfile = inParamfile;
}
}
public class lcoFindByDateRanges : VarsBag {
public RL_4236ffd993178ba431a66b30d7460972 outParamList = new RL_4236ffd993178ba431a66b30d7460972();

public ST_b1b6df219277397c7c2be747d587880aStructure outParamreturn = new ST_b1b6df219277397c7c2be747d587880aStructure();

public lcoFindByDateRanges() {
}
}
/// <summary>
/// Action <code>FindByDateRanges</code> that represents the Service Studio action
///  <code>FindByDateRanges</code> <p> Description: </p>
/// </summary>
public static async Task<(RL_4236ffd993178ba431a66b30d7460972,ST_b1b6df219277397c7c2be747d587880aStructure)> ActionFindByDateRanges(IRequestContext requestContext,byte[] inParamfile,CancellationToken cancellationToken) {
RL_4236ffd993178ba431a66b30d7460972 outParamList = default;
ST_b1b6df219277397c7c2be747d587880aStructure outParamreturn = default;
lcoFindByDateRanges result = new lcoFindByDateRanges();
lcvFindByDateRanges localVars = new lcvFindByDateRanges(inParamfile);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FindByDateRanges", "05f8e76d-b665-4e96-9f0e-149cbabf457c"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FindByDateRanges", "05f8e76d-b665-4e96-9f0e-149cbabf457c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ExcelToRecordList ExcelToRLFindByDateRangesExcelToRecordList1
FuncActionFindByDateRanges.ExcelToRLFindByDateRangesExcelToRecordList1(requestContext,localVars.inParamfile,"",out localVars.resExcelToRecordList1_outParamOut);
if(((localVars.resExcelToRecordList1_outParamOut.Empty||(localVars.resExcelToRecordList1_outParamOut.Length<2)))) {
// RaiseError DocumentExtration
throw new Ex_DocumentExtrationUserException (AppUtils.GetStringResource("RN1MPCl0o06kL+exGyJWbQ#Message.632941093.1", "Invalid file"));

} else {
// Foreach ExcelToRecordList1
localVars.resExcelToRecordList1_outParamOut.StartIteration();
try {localVars.resExcelToRecordList1_outParamOut.Advance(1);
while (!((localVars.resExcelToRecordList1_outParamOut.Eof))) {
if((!(((localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationDateRange.ssDesde=="")||(localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationDateRange.ssHasta==""))))) {
// ValidateDate3
localVars.resValidateDate3.outParamIsValid = await Actions.ActionValidateDate(requestContext,localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationDateRange.ssHasta,cancellationToken);

// ValidateDate4
localVars.resValidateDate4.outParamIsValid = await Actions.ActionValidateDate(requestContext,localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationDateRange.ssDesde,cancellationToken);

if(((localVars.resValidateDate3.outParamIsValid&&localVars.resValidateDate4.outParamIsValid))) {
// Query datasetGetInvoiceFiles
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceFiles_maxRecords = 999999999;
if (datasetGetInvoiceFiles_maxRecords < 1) datasetGetInvoiceFiles_maxRecords = 1;
int datasetGetInvoiceFiles_startIndex = 0;(localVars.queryResGetInvoiceFiles_outParamList,localVars.queryResGetInvoiceFiles_outParamCount) = await FuncActionFindByDateRanges.datasetGetInvoiceFiles(requestContext,datasetGetInvoiceFiles_maxRecords,datasetGetInvoiceFiles_startIndex,IterationMultiplicity.Multiple,(await Functions.ssCheckTelcelUserAuditorRole(requestContext,"",cancellationToken)),localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationDateRange.ssHasta,(await Functions.ActionGetMR00RegionId(requestContext,cancellationToken)),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),BuiltInFunction.NewDateTime (BuiltInFunction.Year (BuiltInFunction.TextToDate (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationDateRange.ssHasta)), BuiltInFunction.Month (BuiltInFunction.TextToDate (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationDateRange.ssHasta)), BuiltInFunction.Day (BuiltInFunction.TextToDate (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationDateRange.ssHasta)), 0, 0, 0),BuiltInFunction.NewDateTime (BuiltInFunction.Year (BuiltInFunction.TextToDate (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationDateRange.ssHasta)), BuiltInFunction.Month (BuiltInFunction.TextToDate (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationDateRange.ssHasta)), BuiltInFunction.Day (BuiltInFunction.TextToDate (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationDateRange.ssHasta)), 23, 59, 59),cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,result.outParamList,(await RL_4236ffd993178ba431a66b30d7460972.ConvertAsync(localVars.queryResGetInvoiceFiles_outParamList, new RL_4236ffd993178ba431a66b30d7460972(), async (RC_2948f028a510ee594d050df56aefa0c8 source, ST_37a6487c1fae199ee92f583d495139beStructure target, CancellationToken cancellationToken) => {
target.ssSupplierName = source.ssENSupplier.ssName;
target.ssInvoiceName = source.ssENInvoice.ssName;
target.ssRequisitionName = source.ssENRequisition.ssName;
target.ssTotalAmount = source.ssENInvoice.ssTotalAmount;
target.ssCurrency = source.ssENInvoice.ssCurrency;
target.ssUUId = source.ssENInvoiceExtended.ssUUID;
target.ssFilename = source.ssENInvoiceFile.ssFilename;
target.ssCreateOn = source.ssENInvoice.ssCreatedOn;
target.ssAccountDate = BuiltInFunction.DateTimeToDate(source.ssENInvoiceAccounting.ssServiceCalledOn);
target.ssStorageId = source.ssENInvoiceFile.ssStorageId;
target.ssSize = source.ssENStorage.ssSize;
return target;
}, cancellationToken)),cancellationToken);

} else {
// RaiseError InvalidDate
throw new Ex_InvalidDateUserException ((((AppUtils.GetStringResource("L8_As59eUk6kSYsKzLNIGw#Message.-724731335.1", "File with Invalide date in line")+": ")+Convert.ToString(localVars.resExcelToRecordList1_outParamOut.CurrentRowNumber))+Convert.ToString(1)));

}

}

localVars.resExcelToRecordList1_outParamOut.Advance();
}

} finally {
localVars.resExcelToRecordList1_outParamOut.EndIteration();
}

// Foreach ExcelToRecordList1
localVars.resExcelToRecordList1_outParamOut.StartIteration();
try {localVars.resExcelToRecordList1_outParamOut.Advance(1);
while (!((localVars.resExcelToRecordList1_outParamOut.Eof))) {
if((!(((localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationDateRange.ssDesde2=="")||(localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationDateRange.ssHasta2==""))))) {
// ValidateDate5
localVars.resValidateDate5.outParamIsValid = await Actions.ActionValidateDate(requestContext,localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationDateRange.ssHasta2,cancellationToken);

// ValidateDate6
localVars.resValidateDate6.outParamIsValid = await Actions.ActionValidateDate(requestContext,localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationDateRange.ssDesde2,cancellationToken);

if(((localVars.resValidateDate5.outParamIsValid&&localVars.resValidateDate6.outParamIsValid))) {
// RaiseError InvalidDate
throw new Ex_InvalidDateUserException ((((AppUtils.GetStringResource("mFF9FB5DQE2temICGzKVpA#Message.-724731335.1", "File with Invalide date in line")+": ")+Convert.ToString(localVars.resExcelToRecordList1_outParamOut.CurrentRowNumber))+Convert.ToString(1)));

} else {
// Query datasetGetInvoiceFiles2
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceFiles2_maxRecords = 999999999;
if (datasetGetInvoiceFiles2_maxRecords < 1) datasetGetInvoiceFiles2_maxRecords = 1;
int datasetGetInvoiceFiles2_startIndex = 0;(localVars.queryResGetInvoiceFiles2_outParamList,localVars.queryResGetInvoiceFiles2_outParamCount) = await FuncActionFindByDateRanges.datasetGetInvoiceFiles2(requestContext,datasetGetInvoiceFiles2_maxRecords,datasetGetInvoiceFiles2_startIndex,IterationMultiplicity.Multiple,(await Functions.ssCheckTelcelUserAuditorRole(requestContext,"",cancellationToken)),localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationDateRange.ssDesde2,localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationDateRange.ssHasta2,(await Functions.ActionGetMR00RegionId(requestContext,cancellationToken)),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),BuiltInFunction.NewDateTime (BuiltInFunction.Year (BuiltInFunction.TextToDate (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationDateRange.ssDesde2)), BuiltInFunction.Month (BuiltInFunction.TextToDate (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationDateRange.ssDesde2)), BuiltInFunction.Day (BuiltInFunction.TextToDate (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationDateRange.ssDesde2)), 0, 0, 0),BuiltInFunction.NewDateTime (BuiltInFunction.Year (BuiltInFunction.TextToDate (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationDateRange.ssHasta2)), BuiltInFunction.Month (BuiltInFunction.TextToDate (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationDateRange.ssHasta2)), BuiltInFunction.Day (BuiltInFunction.TextToDate (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationDateRange.ssHasta2)), 0, 0, 0),cancellationToken);

// ListAppendAll2
await ExtendedActions.ListAppendAll(requestContext,result.outParamList,(await RL_4236ffd993178ba431a66b30d7460972.ConvertAsync(localVars.queryResGetInvoiceFiles2_outParamList, new RL_4236ffd993178ba431a66b30d7460972(), async (RC_2948f028a510ee594d050df56aefa0c8 source, ST_37a6487c1fae199ee92f583d495139beStructure target, CancellationToken cancellationToken) => {
target.ssSupplierName = source.ssENSupplier.ssName;
target.ssInvoiceName = source.ssENInvoice.ssName;
target.ssRequisitionName = source.ssENRequisition.ssName;
target.ssTotalAmount = source.ssENInvoice.ssTotalAmount;
target.ssCurrency = source.ssENInvoice.ssCurrency;
target.ssUUId = source.ssENInvoiceExtended.ssUUID;
target.ssFilename = source.ssENInvoiceFile.ssFilename;
target.ssCreateOn = source.ssENInvoice.ssCreatedOn;
target.ssAccountDate = BuiltInFunction.DateTimeToDate(source.ssENInvoiceAccounting.ssServiceCalledOn);
target.ssStorageId = source.ssENInvoiceFile.ssStorageId;
target.ssSize = source.ssENStorage.ssSize;
return target;
}, cancellationToken)),cancellationToken);

}

}

localVars.resExcelToRecordList1_outParamOut.Advance();
}

} finally {
localVars.resExcelToRecordList1_outParamOut.EndIteration();
}

// ListSort
await ExtendedActions.ListSort(requestContext,result.outParamList,async (p, cancellationToken) => p.ssSupplierName,true,cancellationToken);

// ListDistinct
localVars.resListDistinct_outParamDistinctList = (((RL_4236ffd993178ba431a66b30d7460972) result.outParamList.Distinct()));

// List = ListDistinct.DistinctList
result.outParamList=localVars.resListDistinct_outParamDistinctList;
if((result.outParamList.Empty)) {
// return.IsSuccess = False
result.outParamreturn.ssIsSuccess = false;

// return.Message = "No records Found"
result.outParamreturn.ssMessage = AppUtils.GetStringResource("LDWsT20uD0yhbX2_DF72pA#Value.1149992965.1", "No records Found");
} else {
// return.IsSuccess = True
result.outParamreturn.ssIsSuccess = true;
}

}

} //close CreateActionActivity using block
} // try

catch (UserException ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// return.IsSuccess = False
result.outParamreturn.ssIsSuccess = false;

// return.Message = return.Message
result.outParamreturn.ssMessage = result.outParamreturn.ssMessage;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamList = result.outParamList;
outParamreturn = result.outParamreturn;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamList,outParamreturn);
}

public static class FuncActionFindByDateRanges {

private static async Task<RC_2948f028a510ee594d050df56aefa0c8> datasetGetInvoiceFiles2ReadDbAsync(RC_2948f028a510ee594d050df56aefa0c8 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccounting.Read( r, ref index);
rec.ssENInvoiceExtended.Read( r, ref index);
rec.ssENInvoiceFile.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceFiles2" y5GiO6uvCE2A1N9PuwCvrA of Action "FindByDateRanges"
public static async Task<(RL_1d4c61caa98ecb2b0573c3d151f4f72a,long)> datasetGetInvoiceFiles2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckTelcelUserAuditorRole,string qpteDesde2,string qpteHasta2,long qpreSupplier_RegionId,long qpreSupplier_RegionId1,DateTime qpdaNewDateTime,DateTime qpdaNewDateTime1,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FindByDateRanges.GetInvoiceFiles2", "3ba291cb-afab-4d08-80d4-df4fbb00afac");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FindByDateRanges.GetInvoiceFiles2", "3ba291cb-afab-4d08-80d4-df4fbb00afac", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.bef4BWW2lk6fDhScur9FfA/NodesNotShownInESpaceTree.y5GiO6uvCE2A1N9PuwCvrA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoice\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, trim_scale(\"eninvoice\".\"totalamount\"::numeric) o6, \"eninvoice\".\"currency\" o7, NULL o8, NULL o9, NULL o10, \"eninvoice\".\"createdon\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, \"eninvoiceaccounting\".\"servicecalledon\" o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, \"eninvoiceextended\".\"uuid\" o63, NULL o64, NULL o65, \"eninvoicefile\".\"filename\" o66, NULL o67, NULL o68, \"eninvoicefile\".\"storageid\" o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, \"enrequisition2\".\"name\" o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, \"enstorage\".\"size\" o161, NULL o162, NULL o163, NULL o164, \"ensupplier1\".\"name\" o165, NULL o166, NULL o167, NULL o168, NULL o169, NULL o170, NULL o171, NULL o172, NULL o173, NULL o174, NULL o175, NULL o176, NULL o177, NULL o178, NULL o179, NULL o180, NULL o181, NULL o182, NULL o183, NULL o184, NULL o185, NULL o186, NULL o187, NULL o188, NULL o189, NULL o190");
fromBuilder.Append(" FROM ((((((({InvoiceFile} \"eninvoicefile\" Inner JOIN {Invoice} \"eninvoice\" ON (\"eninvoicefile\".\"invoiceid\" = \"eninvoice\".\"id\"))  Inner JOIN {Requisition} \"enrequisition2\" ON (\"eninvoice\".\"requisitionid\" = \"enrequisition2\".\"id\"))  Inner JOIN {Supplier} \"ensupplier1\" ON (\"enrequisition2\".\"supplierid\" = \"ensupplier1\".\"id\"))  Inner JOIN {Storage} \"enstorage\" ON (\"eninvoicefile\".\"storageid\" = \"enstorage\".\"id\"))  Inner JOIN {Region} \"enregion1\" ON (\"ensupplier1\".\"regionid\" = \"enregion1\".\"id\"))  Left JOIN {InvoiceExtended} \"eninvoiceextended\" ON (\"eninvoice\".\"id\" = \"eninvoiceextended\".\"id\"))  Left JOIN {InvoiceAccounting} \"eninvoiceaccounting\" ON (\"eninvoice\".\"id\" = \"eninvoiceaccounting\".\"invoiceid\")) ");
whereBuilder.Append(" WHERE (((to_date(@qpteDesde2, 'YYYY-MM-DD')) = (date '1900-01-01')) OR (\"eninvoiceaccounting\".\"servicecalledon\" >= @qpdaNewDateTime)) AND (((to_date(@qpteHasta2, 'YYYY-MM-DD')) = (date '1900-01-01')) OR (\"eninvoiceaccounting\".\"servicecalledon\" <= @qpdaNewDateTime1)) AND (((((@qpreSupplier_RegionId = @qpreSupplier_RegionId1) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpteDesde2", DbType.String, qpteDesde2);
sqlCmd.CreateParameterWithoutReplacements("@qpdaNewDateTime", DbType.DateTime, qpdaNewDateTime);
sqlCmd.CreateParameterWithoutReplacements("@qpteHasta2", DbType.String, qpteHasta2);
sqlCmd.CreateParameterWithoutReplacements("@qpdaNewDateTime1", DbType.DateTime, qpdaNewDateTime1);
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId1);
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId);
if (qpreSupplier_RegionId != 0) {
whereBuilder.Append("((\"ensupplier1\".\"regionid\" = @qpreSupplier_RegionId1) AND (\"ensupplier1\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId);
} else {
whereBuilder.Append("(\"ensupplier1\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR ");
if (qpreSupplier_RegionId1 != 0) {
whereBuilder.Append("((\"ensupplier1\".\"regionid\" = @qpreSupplier_RegionId) AND (\"ensupplier1\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId1);
} else {
whereBuilder.Append("(\"ensupplier1\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR (\"ensupplier1\".\"regionid\" IS NULL)) OR (@qpboCheckTelcelUserAuditorRole = 1))");
orderByBuilder.Append(" ORDER BY \"eninvoicefile\".\"createdon\" ASC ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckTelcelUserAuditorRole", DbType.Boolean, qpboCheckTelcelUserAuditorRole);
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
RL_1d4c61caa98ecb2b0573c3d151f4f72a outParamList = new RL_1d4c61caa98ecb2b0573c3d151f4f72a();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceFiles2ReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[8];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, false, false, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, true, true, false, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true});
opt[6] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FindByDateRanges.GetInvoiceFiles2.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1d4c61caa98ecb2b0573c3d151f4f72a _tmp = new RL_1d4c61caa98ecb2b0573c3d151f4f72a();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceFiles2ReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FindByDateRanges.GetInvoiceFiles2.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1d4c61caa98ecb2b0573c3d151f4f72a)_tmp;
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

private static async Task<RC_2948f028a510ee594d050df56aefa0c8> datasetGetInvoiceFilesReadDbAsync(RC_2948f028a510ee594d050df56aefa0c8 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccounting.Read( r, ref index);
rec.ssENInvoiceExtended.Read( r, ref index);
rec.ssENInvoiceFile.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceFiles" 23XmoMHZu0ebNFIFKG_Jcg of Action "FindByDateRanges"
public static async Task<(RL_1d4c61caa98ecb2b0573c3d151f4f72a,long)> datasetGetInvoiceFiles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckTelcelUserAuditorRole,string qpteHasta,long qpreSupplier_RegionId,long qpreSupplier_RegionId1,DateTime qpdaNewDateTime,DateTime qpdaNewDateTime1,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FindByDateRanges.GetInvoiceFiles", "a0e675db-d9c1-47bb-9b34-5205286fc972");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FindByDateRanges.GetInvoiceFiles", "a0e675db-d9c1-47bb-9b34-5205286fc972", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.bef4BWW2lk6fDhScur9FfA/NodesNotShownInESpaceTree.23XmoMHZu0ebNFIFKG_Jcg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoice1\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, trim_scale(\"eninvoice1\".\"totalamount\"::numeric) o6, \"eninvoice1\".\"currency\" o7, NULL o8, NULL o9, NULL o10, \"eninvoice1\".\"createdon\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, \"eninvoiceaccounting1\".\"servicecalledon\" o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, \"eninvoiceextended1\".\"uuid\" o63, NULL o64, NULL o65, \"eninvoicefile1\".\"filename\" o66, NULL o67, NULL o68, \"eninvoicefile1\".\"storageid\" o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, \"enrequisition3\".\"name\" o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, \"enstorage1\".\"size\" o161, NULL o162, NULL o163, NULL o164, \"ensupplier2\".\"name\" o165, NULL o166, NULL o167, NULL o168, NULL o169, NULL o170, NULL o171, NULL o172, NULL o173, NULL o174, NULL o175, NULL o176, NULL o177, NULL o178, NULL o179, NULL o180, NULL o181, NULL o182, NULL o183, NULL o184, NULL o185, NULL o186, NULL o187, NULL o188, NULL o189, NULL o190");
fromBuilder.Append(" FROM ((((((({InvoiceFile} \"eninvoicefile1\" Inner JOIN {Invoice} \"eninvoice1\" ON (\"eninvoicefile1\".\"invoiceid\" = \"eninvoice1\".\"id\"))  Inner JOIN {Requisition} \"enrequisition3\" ON (\"eninvoice1\".\"requisitionid\" = \"enrequisition3\".\"id\"))  Inner JOIN {Supplier} \"ensupplier2\" ON (\"enrequisition3\".\"supplierid\" = \"ensupplier2\".\"id\"))  Inner JOIN {Storage} \"enstorage1\" ON (\"eninvoicefile1\".\"storageid\" = \"enstorage1\".\"id\"))  Inner JOIN {Region} \"enregion2\" ON (\"ensupplier2\".\"regionid\" = \"enregion2\".\"id\"))  Left JOIN {InvoiceExtended} \"eninvoiceextended1\" ON (\"eninvoice1\".\"id\" = \"eninvoiceextended1\".\"id\"))  Left JOIN {InvoiceAccounting} \"eninvoiceaccounting1\" ON (\"eninvoice1\".\"id\" = \"eninvoiceaccounting1\".\"invoiceid\")) ");
whereBuilder.Append(" WHERE ");
if (qpteHasta != "") {
whereBuilder.Append("(\"eninvoicefile1\".\"createdon\" >= @qpdaNewDateTime) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdaNewDateTime", DbType.DateTime, qpdaNewDateTime);
}
if (qpteHasta != "") {
whereBuilder.Append("(\"eninvoicefile1\".\"createdon\" <= @qpdaNewDateTime1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdaNewDateTime1", DbType.DateTime, qpdaNewDateTime1);
}
whereBuilder.Append("(((((@qpreSupplier_RegionId = @qpreSupplier_RegionId1) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId1);
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId);
if (qpreSupplier_RegionId != 0) {
whereBuilder.Append("((\"ensupplier2\".\"regionid\" = @qpreSupplier_RegionId1) AND (\"ensupplier2\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId);
} else {
whereBuilder.Append("(\"ensupplier2\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR ");
if (qpreSupplier_RegionId1 != 0) {
whereBuilder.Append("((\"ensupplier2\".\"regionid\" = @qpreSupplier_RegionId) AND (\"ensupplier2\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId1);
} else {
whereBuilder.Append("(\"ensupplier2\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR (\"ensupplier2\".\"regionid\" IS NULL)) OR (@qpboCheckTelcelUserAuditorRole = 1))");
orderByBuilder.Append(" ORDER BY \"eninvoicefile1\".\"createdon\" ASC ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckTelcelUserAuditorRole", DbType.Boolean, qpboCheckTelcelUserAuditorRole);
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
RL_1d4c61caa98ecb2b0573c3d151f4f72a outParamList = new RL_1d4c61caa98ecb2b0573c3d151f4f72a();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceFilesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[8];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, false, false, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, true, true, false, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true});
opt[6] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FindByDateRanges.GetInvoiceFiles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1d4c61caa98ecb2b0573c3d151f4f72a _tmp = new RL_1d4c61caa98ecb2b0573c3d151f4f72a();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceFilesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FindByDateRanges.GetInvoiceFiles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1d4c61caa98ecb2b0573c3d151f4f72a)_tmp;
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
/// Excel To RecordList: ExcelToRLFindByDateRangesExcelToRecordList1 (K_i4xeVORSUOfcP8QEErVMw) of
///  Action "FindByDateRanges"
/// </summary>
public static void ExcelToRLFindByDateRangesExcelToRecordList1(IRequestContext requestContext,byte[] excelContent,string tableName,out RL_2b2250dae3adb3f820f24fa2783032d4 outParamOut) {

if(excelContent.GetLength(0) == 0) {
    throw InvalidExcelErrorsHelper.EmptyExcelFile();
}
var service = ServiceLocator.GetService<ISpreadsheetService>();
var reader = service.GetReader(
    excelContent, 
    tableName, 
    new Type[] {
        typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string)
    },
    new string[] {
        "Desde", 
"Hasta", 
"Space", 
"Desde2", 
"Hasta2"
    },
    new string[] {
        "Desde", 
"Hasta", 
"Space", 
"Desde 2", 
"Hasta 2"
    },
    new string[] {
        "Desde", 
"Hasta", 
"Space", 
"Desde2", 
"Hasta2"
    },
    new string[] {
        "Desde", 
"Hasta", 
"Space", 
"Desde 2", 
"Hasta 2"
    });

RL_2b2250dae3adb3f820f24fa2783032d4 tmp = new();
tmp.Reader = reader;

outParamOut = (RL_2b2250dae3adb3f820f24fa2783032d4)tmp.Duplicate();
}


}


}
