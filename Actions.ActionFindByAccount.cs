namespace ssConectaProveedores;

public partial class Actions {
public class lcvFindByAccount : VarsBag {
public byte[] inParamfile;
public RL_4236ffd993178ba431a66b30d7460972 resListDistinct_outParamDistinctList = new RL_4236ffd993178ba431a66b30d7460972();

public Actions.lcoValidateDate resValidateDate2 =  new Actions.lcoValidateDate();
public RL_a31fa8058feac162b2cfdf3fe5fa7e5b queryResGetInvoiceFiles_outParamList = new RL_a31fa8058feac162b2cfdf3fe5fa7e5b();
public long queryResGetInvoiceFiles_outParamCount = 0L;

public Actions.lcoValidateDate resValidateDate4 =  new Actions.lcoValidateDate();
public Actions.lcoValidateDate resValidateDate3 =  new Actions.lcoValidateDate();
public RL_a31fa8058feac162b2cfdf3fe5fa7e5b queryResGetInvoiceFiles2_outParamList = new RL_a31fa8058feac162b2cfdf3fe5fa7e5b();
public long queryResGetInvoiceFiles2_outParamCount = 0L;

public Actions.lcoValidateDate resValidateDate =  new Actions.lcoValidateDate();
public RL_bb525a2399c7e59c77f96d7fa443808c resExcelToRecordList1_outParamOut = new RL_bb525a2399c7e59c77f96d7fa443808c();
public lcvFindByAccount(byte[] inParamfile) {
this.inParamfile = inParamfile;
}
}
public class lcoFindByAccount : VarsBag {
public RL_4236ffd993178ba431a66b30d7460972 outParamList = new RL_4236ffd993178ba431a66b30d7460972();

public ST_b1b6df219277397c7c2be747d587880aStructure outParamreturn = new ST_b1b6df219277397c7c2be747d587880aStructure();

public lcoFindByAccount() {
}
}
/// <summary>
/// Action <code>FindByAccount</code> that represents the Service Studio action
///  <code>FindByAccount</code> <p> Description: </p>
/// </summary>
public static async Task<(RL_4236ffd993178ba431a66b30d7460972,ST_b1b6df219277397c7c2be747d587880aStructure)> ActionFindByAccount(IRequestContext requestContext,byte[] inParamfile,CancellationToken cancellationToken) {
RL_4236ffd993178ba431a66b30d7460972 outParamList = default;
ST_b1b6df219277397c7c2be747d587880aStructure outParamreturn = default;
lcoFindByAccount result = new lcoFindByAccount();
lcvFindByAccount localVars = new lcvFindByAccount(inParamfile);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FindByAccount", "b5de618a-6fe0-49de-b6f8-3d359380200b"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FindByAccount", "b5de618a-6fe0-49de-b6f8-3d359380200b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ExcelToRecordList ExcelToRLFindByAccountExcelToRecordList1
FuncActionFindByAccount.ExcelToRLFindByAccountExcelToRecordList1(requestContext,localVars.inParamfile,"",out localVars.resExcelToRecordList1_outParamOut);
if(((localVars.resExcelToRecordList1_outParamOut.Empty||(localVars.resExcelToRecordList1_outParamOut.Length<2)))) {
// RaiseError DocumentExtration
throw new Ex_DocumentExtrationUserException (AppUtils.GetStringResource("0cwDpdnJhkuXZh7rfbJs+w#Message.632941093.1", "Invalid file"));

} else {
// Foreach ExcelToRecordList1
localVars.resExcelToRecordList1_outParamOut.StartIteration();
try {localVars.resExcelToRecordList1_outParamOut.Advance(1);
while (!((localVars.resExcelToRecordList1_outParamOut.Eof))) {
if((!((localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationAccount.ssCuentadeGasto=="")))) {
// ValidateDate
localVars.resValidateDate.outParamIsValid = await Actions.ActionValidateDate(requestContext,localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationAccount.ssHasta,cancellationToken);

// ValidateDate2
localVars.resValidateDate2.outParamIsValid = await Actions.ActionValidateDate(requestContext,localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationAccount.ssDesde,cancellationToken);

if(((localVars.resValidateDate.outParamIsValid&&localVars.resValidateDate2.outParamIsValid))) {
// Query datasetGetInvoiceFiles
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceFiles_maxRecords = 999999999;
if (datasetGetInvoiceFiles_maxRecords < 1) datasetGetInvoiceFiles_maxRecords = 1;
int datasetGetInvoiceFiles_startIndex = 0;(localVars.queryResGetInvoiceFiles_outParamList,localVars.queryResGetInvoiceFiles_outParamCount) = await FuncActionFindByAccount.datasetGetInvoiceFiles(requestContext,datasetGetInvoiceFiles_maxRecords,datasetGetInvoiceFiles_startIndex,IterationMultiplicity.Multiple,(await Functions.ssCheckTelcelUserAuditorRole(requestContext,"",cancellationToken)),localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationAccount.ssCuentadeGasto,localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationAccount.ssHasta,(await Functions.ActionGetMR00RegionId(requestContext,cancellationToken)),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),BuiltInFunction.NewDateTime (BuiltInFunction.Year (BuiltInFunction.TextToDate (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationAccount.ssHasta)), BuiltInFunction.Month (BuiltInFunction.TextToDate (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationAccount.ssHasta)), BuiltInFunction.Day (BuiltInFunction.TextToDate (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationAccount.ssHasta)), 0, 0, 0),BuiltInFunction.NewDateTime (BuiltInFunction.Year (BuiltInFunction.TextToDate (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationAccount.ssHasta)), BuiltInFunction.Month (BuiltInFunction.TextToDate (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationAccount.ssHasta)), BuiltInFunction.Day (BuiltInFunction.TextToDate (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationAccount.ssHasta)), 23, 59, 59),cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,result.outParamList,(await RL_4236ffd993178ba431a66b30d7460972.ConvertAsync(localVars.queryResGetInvoiceFiles_outParamList, new RL_4236ffd993178ba431a66b30d7460972(), async (RC_990f54db71adf1daf03c1d609af44921 source, ST_37a6487c1fae199ee92f583d495139beStructure target, CancellationToken cancellationToken) => {
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
throw new Ex_InvalidDateUserException ((AppUtils.GetStringResource("FptL6ZpGb0mLfg+fJfipjQ#Message.-682109153.1", "File with Invalide date in line: ")+Convert.ToString((localVars.resExcelToRecordList1_outParamOut.CurrentRowNumber+1))));

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
if((!((localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationAccount.ssCuentadeGasto2=="")))) {
// ValidateDate3
localVars.resValidateDate3.outParamIsValid = await Actions.ActionValidateDate(requestContext,localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationAccount.ssHasta2,cancellationToken);

// ValidateDate4
localVars.resValidateDate4.outParamIsValid = await Actions.ActionValidateDate(requestContext,localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationAccount.ssDesde2,cancellationToken);

if(((localVars.resValidateDate3.outParamIsValid&&localVars.resValidateDate4.outParamIsValid))) {
// RaiseError InvalidDate
throw new Ex_InvalidDateUserException ((AppUtils.GetStringResource("deHvplAaREeOGVgnyaqUqg#Message.-682109153.1", "File with Invalide date in line: ")+Convert.ToString((localVars.resExcelToRecordList1_outParamOut.CurrentRowNumber+1))));

} else {
// Query datasetGetInvoiceFiles2
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceFiles2_maxRecords = 999999999;
if (datasetGetInvoiceFiles2_maxRecords < 1) datasetGetInvoiceFiles2_maxRecords = 1;
int datasetGetInvoiceFiles2_startIndex = 0;(localVars.queryResGetInvoiceFiles2_outParamList,localVars.queryResGetInvoiceFiles2_outParamCount) = await FuncActionFindByAccount.datasetGetInvoiceFiles2(requestContext,datasetGetInvoiceFiles2_maxRecords,datasetGetInvoiceFiles2_startIndex,IterationMultiplicity.Multiple,(await Functions.ssCheckTelcelUserAuditorRole(requestContext,"",cancellationToken)),localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationAccount.ssCuentadeGasto2,localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationAccount.ssDesde2,localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationAccount.ssHasta2,(await Functions.ActionGetMR00RegionId(requestContext,cancellationToken)),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),BuiltInFunction.NewDateTime (BuiltInFunction.Year (BuiltInFunction.TextToDate (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationAccount.ssDesde2)), BuiltInFunction.Month (BuiltInFunction.TextToDate (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationAccount.ssDesde2)), BuiltInFunction.Day (BuiltInFunction.TextToDate (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationAccount.ssDesde2)), 0, 0, 0),BuiltInFunction.NewDateTime (BuiltInFunction.Year (BuiltInFunction.TextToDate (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationAccount.ssHasta2)), BuiltInFunction.Month (BuiltInFunction.TextToDate (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationAccount.ssHasta2)), BuiltInFunction.Day (BuiltInFunction.TextToDate (localVars.resExcelToRecordList1_outParamOut.CurrentRec.ssSTDocumentExtrationAccount.ssHasta2)), 0, 0, 0),cancellationToken);

// ListAppendAll2
await ExtendedActions.ListAppendAll(requestContext,result.outParamList,(await RL_4236ffd993178ba431a66b30d7460972.ConvertAsync(localVars.queryResGetInvoiceFiles2_outParamList, new RL_4236ffd993178ba431a66b30d7460972(), async (RC_990f54db71adf1daf03c1d609af44921 source, ST_37a6487c1fae199ee92f583d495139beStructure target, CancellationToken cancellationToken) => {
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
result.outParamreturn.ssMessage = AppUtils.GetStringResource("QM0OjjNuY06WQ2nn9idhag#Value.1149992965.1", "No records Found");
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

// return.Message = UserException.ExceptionMessage
result.outParamreturn.ssMessage = ex.Message;
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

public static class FuncActionFindByAccount {

private static async Task<RC_990f54db71adf1daf03c1d609af44921> datasetGetInvoiceFilesReadDbAsync(RC_990f54db71adf1daf03c1d609af44921 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccounting.Read( r, ref index);
rec.ssENInvoiceAccountingServices.Read( r, ref index);
rec.ssENInvoiceExtended.Read( r, ref index);
rec.ssENInvoiceFile.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceFiles" QnBHkafNWEywp8ffMR1BUQ of Action "FindByAccount"
public static async Task<(RL_a31fa8058feac162b2cfdf3fe5fa7e5b,long)> datasetGetInvoiceFiles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckTelcelUserAuditorRole,string qpteInvoiceAccountingServices_Account,string qpteHasta,long qpreSupplier_RegionId,long qpreSupplier_RegionId1,DateTime qpdaNewDateTime,DateTime qpdaNewDateTime1,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FindByAccount.GetInvoiceFiles", "91477042-cda7-4c58-b0a7-c7df311d4151");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FindByAccount.GetInvoiceFiles", "91477042-cda7-4c58-b0a7-c7df311d4151", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.imHeteBv3km2+D01k4AgCw/NodesNotShownInESpaceTree.QnBHkafNWEywp8ffMR1BUQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoice50\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, trim_scale(\"eninvoice50\".\"totalamount\"::numeric) o6, \"eninvoice50\".\"currency\" o7, NULL o8, NULL o9, NULL o10, \"eninvoice50\".\"createdon\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, \"eninvoiceaccounting8\".\"servicecalledon\" o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, \"eninvoiceextended11\".\"uuid\" o77, NULL o78, NULL o79, \"eninvoicefile14\".\"filename\" o80, NULL o81, NULL o82, \"eninvoicefile14\".\"storageid\" o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, \"enrequisition47\".\"name\" o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, NULL o161, NULL o162, NULL o163, NULL o164, NULL o165, NULL o166, NULL o167, NULL o168, NULL o169, NULL o170, NULL o171, NULL o172, NULL o173, NULL o174, \"enstorage7\".\"size\" o175, NULL o176, NULL o177, NULL o178, \"ensupplier30\".\"name\" o179, NULL o180, NULL o181, NULL o182, NULL o183, NULL o184, NULL o185, NULL o186, NULL o187, NULL o188, NULL o189, NULL o190, NULL o191, NULL o192, NULL o193, NULL o194, NULL o195, NULL o196, NULL o197, NULL o198, NULL o199, NULL o200, NULL o201, NULL o202, NULL o203, NULL o204");
fromBuilder.Append(" FROM (((((((({InvoiceFile} \"eninvoicefile14\" Inner JOIN {Invoice} \"eninvoice50\" ON (\"eninvoicefile14\".\"invoiceid\" = \"eninvoice50\".\"id\"))  Inner JOIN {Requisition} \"enrequisition47\" ON (\"eninvoice50\".\"requisitionid\" = \"enrequisition47\".\"id\"))  Inner JOIN {Supplier} \"ensupplier30\" ON (\"enrequisition47\".\"supplierid\" = \"ensupplier30\".\"id\"))  Inner JOIN {Storage} \"enstorage7\" ON (\"eninvoicefile14\".\"storageid\" = \"enstorage7\".\"id\"))  Inner JOIN {Region} \"enregion41\" ON (\"ensupplier30\".\"regionid\" = \"enregion41\".\"id\"))  Left JOIN {InvoiceExtended} \"eninvoiceextended11\" ON (\"eninvoice50\".\"id\" = \"eninvoiceextended11\".\"id\"))  Left JOIN {InvoiceAccounting} \"eninvoiceaccounting8\" ON (\"eninvoice50\".\"id\" = \"eninvoiceaccounting8\".\"invoiceid\"))  Left JOIN {InvoiceAccountingServices} \"eninvoiceaccountingservices1\" ON (\"eninvoiceaccounting8\".\"id\" = \"eninvoiceaccountingservices1\".\"invoiceaccountingid\")) ");
whereBuilder.Append(" WHERE (\"eninvoiceaccountingservices1\".\"account\" = @qpteInvoiceAccountingServices_Account) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteInvoiceAccountingServices_Account", DbType.String, qpteInvoiceAccountingServices_Account);
if (qpteHasta != "") {
whereBuilder.Append("(\"eninvoicefile14\".\"createdon\" >= @qpdaNewDateTime) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdaNewDateTime", DbType.DateTime, qpdaNewDateTime);
}
if (qpteHasta != "") {
whereBuilder.Append("(\"eninvoicefile14\".\"createdon\" <= @qpdaNewDateTime1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdaNewDateTime1", DbType.DateTime, qpdaNewDateTime1);
}
whereBuilder.Append("(((((@qpreSupplier_RegionId = @qpreSupplier_RegionId1) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId1);
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId);
if (qpreSupplier_RegionId != 0) {
whereBuilder.Append("((\"ensupplier30\".\"regionid\" = @qpreSupplier_RegionId1) AND (\"ensupplier30\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId);
} else {
whereBuilder.Append("(\"ensupplier30\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR ");
if (qpreSupplier_RegionId1 != 0) {
whereBuilder.Append("((\"ensupplier30\".\"regionid\" = @qpreSupplier_RegionId) AND (\"ensupplier30\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId1);
} else {
whereBuilder.Append("(\"ensupplier30\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR (\"ensupplier30\".\"regionid\" IS NULL)) OR (@qpboCheckTelcelUserAuditorRole = 1))");
orderByBuilder.Append(" ORDER BY \"eninvoicefile14\".\"createdon\" ASC ");
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
RL_a31fa8058feac162b2cfdf3fe5fa7e5b outParamList = new RL_a31fa8058feac162b2cfdf3fe5fa7e5b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceFilesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[9];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, false, false, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, true, true, false, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true});
opt[7] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FindByAccount.GetInvoiceFiles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a31fa8058feac162b2cfdf3fe5fa7e5b _tmp = new RL_a31fa8058feac162b2cfdf3fe5fa7e5b();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceFilesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FindByAccount.GetInvoiceFiles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a31fa8058feac162b2cfdf3fe5fa7e5b)_tmp;
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

private static async Task<RC_990f54db71adf1daf03c1d609af44921> datasetGetInvoiceFiles2ReadDbAsync(RC_990f54db71adf1daf03c1d609af44921 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccounting.Read( r, ref index);
rec.ssENInvoiceAccountingServices.Read( r, ref index);
rec.ssENInvoiceExtended.Read( r, ref index);
rec.ssENInvoiceFile.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceFiles2" zKHPtEEzEEeLlNTpe5VzBg of Action "FindByAccount"
public static async Task<(RL_a31fa8058feac162b2cfdf3fe5fa7e5b,long)> datasetGetInvoiceFiles2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckTelcelUserAuditorRole,string qpteInvoiceAccountingServices_Account,string qpteDesde2,string qpteHasta2,long qpreSupplier_RegionId,long qpreSupplier_RegionId1,DateTime qpdaNewDateTime,DateTime qpdaNewDateTime1,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FindByAccount.GetInvoiceFiles2", "b4cfa1cc-3341-4710-8b94-d4e97b957306");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FindByAccount.GetInvoiceFiles2", "b4cfa1cc-3341-4710-8b94-d4e97b957306", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.imHeteBv3km2+D01k4AgCw/NodesNotShownInESpaceTree.zKHPtEEzEEeLlNTpe5VzBg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoice51\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, trim_scale(\"eninvoice51\".\"totalamount\"::numeric) o6, \"eninvoice51\".\"currency\" o7, NULL o8, NULL o9, NULL o10, \"eninvoice51\".\"createdon\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, \"eninvoiceaccounting9\".\"servicecalledon\" o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, \"eninvoiceextended12\".\"uuid\" o77, NULL o78, NULL o79, \"eninvoicefile15\".\"filename\" o80, NULL o81, NULL o82, \"eninvoicefile15\".\"storageid\" o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, \"enrequisition48\".\"name\" o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, NULL o161, NULL o162, NULL o163, NULL o164, NULL o165, NULL o166, NULL o167, NULL o168, NULL o169, NULL o170, NULL o171, NULL o172, NULL o173, NULL o174, \"enstorage8\".\"size\" o175, NULL o176, NULL o177, NULL o178, \"ensupplier31\".\"name\" o179, NULL o180, NULL o181, NULL o182, NULL o183, NULL o184, NULL o185, NULL o186, NULL o187, NULL o188, NULL o189, NULL o190, NULL o191, NULL o192, NULL o193, NULL o194, NULL o195, NULL o196, NULL o197, NULL o198, NULL o199, NULL o200, NULL o201, NULL o202, NULL o203, NULL o204");
fromBuilder.Append(" FROM (((((((({InvoiceFile} \"eninvoicefile15\" Inner JOIN {Invoice} \"eninvoice51\" ON (\"eninvoicefile15\".\"invoiceid\" = \"eninvoice51\".\"id\"))  Inner JOIN {Requisition} \"enrequisition48\" ON (\"eninvoice51\".\"requisitionid\" = \"enrequisition48\".\"id\"))  Inner JOIN {Supplier} \"ensupplier31\" ON (\"enrequisition48\".\"supplierid\" = \"ensupplier31\".\"id\"))  Inner JOIN {Storage} \"enstorage8\" ON (\"eninvoicefile15\".\"storageid\" = \"enstorage8\".\"id\"))  Inner JOIN {Region} \"enregion42\" ON (\"ensupplier31\".\"regionid\" = \"enregion42\".\"id\"))  Left JOIN {InvoiceExtended} \"eninvoiceextended12\" ON (\"eninvoice51\".\"id\" = \"eninvoiceextended12\".\"id\"))  Left JOIN {InvoiceAccounting} \"eninvoiceaccounting9\" ON (\"eninvoice51\".\"id\" = \"eninvoiceaccounting9\".\"invoiceid\"))  Left JOIN {InvoiceAccountingServices} \"eninvoiceaccountingservices2\" ON (\"eninvoiceaccounting9\".\"id\" = \"eninvoiceaccountingservices2\".\"invoiceaccountingid\")) ");
whereBuilder.Append(" WHERE (\"eninvoiceaccountingservices2\".\"account\" = @qpteInvoiceAccountingServices_Account) AND (((to_date(@qpteDesde2, 'YYYY-MM-DD')) = (date '1900-01-01')) OR (\"eninvoiceaccounting9\".\"servicecalledon\" >= @qpdaNewDateTime)) AND (((to_date(@qpteHasta2, 'YYYY-MM-DD')) = (date '1900-01-01')) OR (\"eninvoiceaccounting9\".\"servicecalledon\" <= @qpdaNewDateTime1)) AND (((((@qpreSupplier_RegionId = @qpreSupplier_RegionId1) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpteInvoiceAccountingServices_Account", DbType.String, qpteInvoiceAccountingServices_Account);
sqlCmd.CreateParameterWithoutReplacements("@qpteDesde2", DbType.String, qpteDesde2);
sqlCmd.CreateParameterWithoutReplacements("@qpdaNewDateTime", DbType.DateTime, qpdaNewDateTime);
sqlCmd.CreateParameterWithoutReplacements("@qpteHasta2", DbType.String, qpteHasta2);
sqlCmd.CreateParameterWithoutReplacements("@qpdaNewDateTime1", DbType.DateTime, qpdaNewDateTime1);
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId1);
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId);
if (qpreSupplier_RegionId != 0) {
whereBuilder.Append("((\"ensupplier31\".\"regionid\" = @qpreSupplier_RegionId1) AND (\"ensupplier31\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId);
} else {
whereBuilder.Append("(\"ensupplier31\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR ");
if (qpreSupplier_RegionId1 != 0) {
whereBuilder.Append("((\"ensupplier31\".\"regionid\" = @qpreSupplier_RegionId) AND (\"ensupplier31\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId1);
} else {
whereBuilder.Append("(\"ensupplier31\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR (\"ensupplier31\".\"regionid\" IS NULL)) OR (@qpboCheckTelcelUserAuditorRole = 1))");
orderByBuilder.Append(" ORDER BY \"eninvoicefile15\".\"createdon\" ASC ");
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
RL_a31fa8058feac162b2cfdf3fe5fa7e5b outParamList = new RL_a31fa8058feac162b2cfdf3fe5fa7e5b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceFiles2ReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[9];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, false, false, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, true, true, false, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true});
opt[7] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FindByAccount.GetInvoiceFiles2.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a31fa8058feac162b2cfdf3fe5fa7e5b _tmp = new RL_a31fa8058feac162b2cfdf3fe5fa7e5b();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceFiles2ReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FindByAccount.GetInvoiceFiles2.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a31fa8058feac162b2cfdf3fe5fa7e5b)_tmp;
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
/// Excel To RecordList: ExcelToRLFindByAccountExcelToRecordList1 (KRSJ234TkNUSl8TwJYL22Fw) of Action
///  "FindByAccount"
/// </summary>
public static void ExcelToRLFindByAccountExcelToRecordList1(IRequestContext requestContext,byte[] excelContent,string tableName,out RL_bb525a2399c7e59c77f96d7fa443808c outParamOut) {

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
typeof(string), 
typeof(string), 
typeof(string)
    },
    new string[] {
        "CuentadeGasto", 
"Desde", 
"Hasta", 
"Space", 
"CuentadeGasto2", 
"Desde2", 
"Hasta2"
    },
    new string[] {
        "Cuentade Gasto", 
"Desde", 
"Hasta", 
"Space", 
"Cuentade Gasto 2", 
"Desde 2", 
"Hasta 2"
    },
    new string[] {
        "CuentadeGasto", 
"Desde", 
"Hasta", 
"Space", 
"CuentadeGasto2", 
"Desde2", 
"Hasta2"
    },
    new string[] {
        "Cuentade Gasto", 
"Desde", 
"Hasta", 
"Space", 
"Cuentade Gasto 2", 
"Desde 2", 
"Hasta 2"
    });

RL_bb525a2399c7e59c77f96d7fa443808c tmp = new();
tmp.Reader = reader;

outParamOut = (RL_bb525a2399c7e59c77f96d7fa443808c)tmp.Duplicate();
}


}


}
