namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioCancelFromProveedor : VarsBag {
public long inParami_FolioId;
public RL_52e01c48f1745de5266c16d6fe2c0564 queryResGetFolioApprovalsByFolioId_outParamList = new RL_52e01c48f1745de5266c16d6fe2c0564();
public long queryResGetFolioApprovalsByFolioId_outParamCount = 0L;

public Actions.lcoFolioLogAdd resFolioLogAdd =  new Actions.lcoFolioLogAdd();
public Actions.lcoOrderMainCreateOrUpdate resOrderMainCreateOrUpdate =  new Actions.lcoOrderMainCreateOrUpdate();
public Actions.lcoInvoiceUpdate resInvoiceUpdate =  new Actions.lcoInvoiceUpdate();
public Actions.lcoFolioApprovalLevelCreateOrUpdate resFolioApprovalLevelCreateOrUpdate2 =  new Actions.lcoFolioApprovalLevelCreateOrUpdate();
public Actions.lcoFolioCreateOrUpdate resFolioCreateOrUpdate =  new Actions.lcoFolioCreateOrUpdate();
public RL_ecd1c5152b10fa2a937ada7598ead4ad queryResGetFolioById_outParamList = new RL_ecd1c5152b10fa2a937ada7598ead4ad();
public long queryResGetFolioById_outParamCount = 0L;

public RL_7b3475883ca90ad6eb7fc983e868c456 queryResGetInvoicesByFolioId_outParamList = new RL_7b3475883ca90ad6eb7fc983e868c456();
public long queryResGetInvoicesByFolioId_outParamCount = 0L;

public lcvFolioCancelFromProveedor(long inParami_FolioId) {
this.inParami_FolioId = inParami_FolioId;
}
}
public class lcoFolioCancelFromProveedor : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoFolioCancelFromProveedor() {
}
}
/// <summary>
/// Action <code>FolioCancelFromProveedor</code> that represents the Service Studio action
///  <code>FolioCancelFromProveedor</code> <p> Description: Action to Cancel Folio.</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionFolioCancelFromProveedor(IRequestContext requestContext,long inParami_FolioId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoFolioCancelFromProveedor result = new lcoFolioCancelFromProveedor();
lcvFolioCancelFromProveedor localVars = new lcvFolioCancelFromProveedor(inParami_FolioId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioCancelFromProveedor", "187b8207-0664-4b42-9d55-86f255a294f6"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioCancelFromProveedor", "187b8207-0664-4b42-9d55-86f255a294f6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 1;
if (datasetGetFolioById_maxRecords < 1) datasetGetFolioById_maxRecords = 1;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionFolioCancelFromProveedor.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.inParami_FolioId,cancellationToken);

// Empty?
if((localVars.queryResGetFolioById_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Folio not found!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("Ottd2OBjfU2C0xW6KFOJLg#Value.1482511939.1", "Folio not found!");
} else {
// Folio Fields
// GetFolioById.List.Current.Folio.FolioStatusId = CanceledBySupplier
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioStatusId = (ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("l5OG661dZEe+gAZwnNLhSA"))).ssId;

// GetFolioById.List.Current.Folio.CanProveedorCancel = False
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssCanProveedorCancel = false;
if(((localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApproval.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// FolioApprovalDelete
await Actions.ActionFolioApprovalDelete(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApproval.ssId,cancellationToken);

}

// OrderMainCreateOrUpdate
(localVars.resOrderMainCreateOrUpdate.outParamId,localVars.resOrderMainCreateOrUpdate.outParamHasSuccess,localVars.resOrderMainCreateOrUpdate.outParamErrorMessage,localVars.resOrderMainCreateOrUpdate.outParamSource_Out) = await Actions.ActionOrderMainCreateOrUpdate(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENOrderMain,cancellationToken);

// FolioCreateOrUpdate
localVars.resFolioCreateOrUpdate.outParamId = await Actions.ActionFolioCreateOrUpdate(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio,cancellationToken);

// FolioLogAdd
localVars.resFolioLogAdd.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_FolioId, ssMessage = (AppUtils.GetStringResource("+IPzZTCNr0C8geiM3Brw_A#Value.1354501461.1", "Form manually cancelled by supplier")+"."), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsError = true, ssIsForSupplier = true },cancellationToken);

// Query datasetGetInvoicesByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoicesByFolioId_maxRecords = 0;
int datasetGetInvoicesByFolioId_startIndex = 0;(localVars.queryResGetInvoicesByFolioId_outParamList,localVars.queryResGetInvoicesByFolioId_outParamCount) = await FuncActionFolioCancelFromProveedor.datasetGetInvoicesByFolioId(requestContext,datasetGetInvoicesByFolioId_maxRecords,datasetGetInvoicesByFolioId_startIndex,IterationMultiplicity.Single,localVars.inParami_FolioId,cancellationToken);

// Foreach GetInvoicesByFolioId.List
localVars.queryResGetInvoicesByFolioId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoicesByFolioId_outParamList.Eof))) {
// Invoice fields
// GetInvoicesByFolioId.List.Current.Invoice.InvoiceStatusId = Canceled
localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId = (ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("RteygpK6NkexqZHONe6zkg"))).ssId;
// InvoiceUpdate
localVars.resInvoiceUpdate.outParamId = await Actions.ActionInvoiceUpdate(requestContext,localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoice,cancellationToken);

localVars.queryResGetInvoicesByFolioId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoicesByFolioId_outParamList.EndIteration();
}

// Query datasetGetFolioApprovalsByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioApprovalsByFolioId_maxRecords = 0;
int datasetGetFolioApprovalsByFolioId_startIndex = 0;(localVars.queryResGetFolioApprovalsByFolioId_outParamList,localVars.queryResGetFolioApprovalsByFolioId_outParamCount) = await FuncActionFolioCancelFromProveedor.datasetGetFolioApprovalsByFolioId(requestContext,datasetGetFolioApprovalsByFolioId_maxRecords,datasetGetFolioApprovalsByFolioId_startIndex,IterationMultiplicity.Single,localVars.inParami_FolioId,cancellationToken);

// Foreach GetFolioApprovalsByFolioId.List
localVars.queryResGetFolioApprovalsByFolioId_outParamList.StartIteration();
try {while (!((localVars.queryResGetFolioApprovalsByFolioId_outParamList.Eof))) {
// GetFolioApprovalsByFolioId.List.Current.FolioApprovalLevel.ApprovalStatusId = Pending
localVars.queryResGetFolioApprovalsByFolioId_outParamList.CurrentRec.ssENFolioApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId;
// FolioApprovalLevelCreateOrUpdate2
localVars.resFolioApprovalLevelCreateOrUpdate2.outParamId = await Actions.ActionFolioApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetFolioApprovalsByFolioId_outParamList.CurrentRec.ssENFolioApprovalLevel,cancellationToken);

localVars.queryResGetFolioApprovalsByFolioId_outParamList.Advance();
}

} finally {
localVars.queryResGetFolioApprovalsByFolioId_outParamList.EndIteration();
}

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionFolioCancelFromProveedor {

private static async Task<RC_131b941598d8581e5466dbb966f5f0a8> datasetGetFolioApprovalsByFolioIdReadDbAsync(RC_131b941598d8581e5466dbb966f5f0a8 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetFolioApprovalsByFolioId" VyFSBA5HgU6CJL2EyXzggQ of Action "FolioCancelFromProveedor"
public static async Task<(RL_52e01c48f1745de5266c16d6fe2c0564,long)> datasetGetFolioApprovalsByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioApproval_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioCancelFromProveedor.GetFolioApprovalsByFolioId", "04522157-470e-4e81-8224-bd84c97ce081");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioCancelFromProveedor.GetFolioApprovalsByFolioId", "04522157-470e-4e81-8224-bd84c97ce081", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
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
selectBuilder.Append("/* /UserActions.B4J7GGQGQkudVYbyVaKU9g/NodesNotShownInESpaceTree.VyFSBA5HgU6CJL2EyXzggQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, \"enfolioapprovallevel1\".\"id\" o10, \"enfolioapprovallevel1\".\"folioapprovalid\" o11, \"enfolioapprovallevel1\".\"levelnumber\" o12, \"enfolioapprovallevel1\".\"applicationroleid\" o13, \"enfolioapprovallevel1\".\"entrajobtitle\" o14, \"enfolioapprovallevel1\".\"entraroleid\" o15, \"enfolioapprovallevel1\".\"departmentid\" o16, \"enfolioapprovallevel1\".\"assignedto\" o17, \"enfolioapprovallevel1\".\"approvalstatusid\" o18, \"enfolioapprovallevel1\".\"ismandatory\" o19, \"enfolioapprovallevel1\".\"isreassigned\" o20, \"enfolioapprovallevel1\".\"approvedby\" o21, \"enfolioapprovallevel1\".\"approvedon\" o22, \"enfolioapprovallevel1\".\"canceledby\" o23, \"enfolioapprovallevel1\".\"canceledon\" o24, \"enfolioapprovallevel1\".\"rejectedby\" o25, \"enfolioapprovallevel1\".\"rejectedon\" o26, \"enfolioapprovallevel1\".\"issubstitutefor\" o27, \"enfolioapprovallevel1\".\"rejectreason\" o28, \"enfolioapprovallevel1\".\"isinvoiceapproval\" o29");
fromBuilder.Append(" FROM ({FolioApproval} \"enfolioapproval1\" Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel1\" ON (\"enfolioapproval1\".\"id\" = \"enfolioapprovallevel1\".\"folioapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioApproval_FolioId != 0) {
whereBuilder.Append("((\"enfolioapproval1\".\"folioid\" = @qpfoFolioApproval_FolioId) AND (\"enfolioapproval1\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApproval_FolioId", DbType.Int64, qpfoFolioApproval_FolioId);
} else {
whereBuilder.Append("(\"enfolioapproval1\".\"folioid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enfolioapprovallevel1\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
whereBuilder.Append(")");
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
RL_52e01c48f1745de5266c16d6fe2c0564 outParamList = new RL_52e01c48f1745de5266c16d6fe2c0564();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioApprovalsByFolioIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioCancelFromProveedor.GetFolioApprovalsByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_52e01c48f1745de5266c16d6fe2c0564 _tmp = new RL_52e01c48f1745de5266c16d6fe2c0564();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioApprovalsByFolioIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioCancelFromProveedor.GetFolioApprovalsByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_52e01c48f1745de5266c16d6fe2c0564)_tmp;
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

private static async Task<RC_f7c91773292f225022263e13d34e21c5> datasetGetFolioByIdReadDbAsync(RC_f7c91773292f225022263e13d34e21c5 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" f331qjs5O0Oiou269fDM_Q of Action "FolioCancelFromProveedor"
public static async Task<(RL_ecd1c5152b10fa2a937ada7598ead4ad,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioCancelFromProveedor.GetFolioById", "aaf57d7f-393b-433b-a2a2-edbaf5f0ccfd");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioCancelFromProveedor.GetFolioById", "aaf57d7f-393b-433b-a2a2-edbaf5f0ccfd", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
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
selectBuilder.Append("/* /UserActions.B4J7GGQGQkudVYbyVaKU9g/NodesNotShownInESpaceTree.f331qjs5O0Oiou269fDM_Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio2\".\"id\" o0, \"enfolio2\".\"isdraft\" o1, \"enfolio2\".\"folionumber\" o2, \"enfolio2\".\"canproveedorcancel\" o3, \"enfolio2\".\"orderid\" o4, \"enfolio2\".\"supplierid\" o5, \"enfolio2\".\"companyid\" o6, \"enfolio2\".\"foliostatusid\" o7, trim_scale(\"enfolio2\".\"totalamount\"::numeric) o8, trim_scale(\"enfolio2\".\"totaliva_amount\"::numeric) o9, trim_scale(\"enfolio2\".\"partialamount\"::numeric) o10, \"enfolio2\".\"currencyid\" o11, \"enfolio2\".\"firstapproveruserid\" o12, \"enfolio2\".\"approvalprocesstypeid\" o13, \"enfolio2\".\"sapentryerror\" o14, \"enfolio2\".\"createdby\" o15, \"enfolio2\".\"createdon\" o16, \"enfolio2\".\"updatedby\" o17, \"enfolio2\".\"updatedon\" o18, \"enfolio2\".\"minuteselected\" o19, \"enfolioapproval2\".\"id\" o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, \"enordermain5\".\"id\" o30, \"enordermain5\".\"ordernumber\" o31, \"enordermain5\".\"orderdate\" o32, \"enordermain5\".\"orderstatusid\" o33, \"enordermain5\".\"previousorderstatusid\" o34, \"enordermain5\".\"assignmentcode\" o35, \"enordermain5\".\"supplierid\" o36, \"enordermain5\".\"companyid\" o37, \"enordermain5\".\"documenttypeid\" o38, \"enordermain5\".\"currencyid\" o39, \"enordermain5\".\"telceldirectionid\" o40, \"enordermain5\".\"procurementgroup\" o41, \"enordermain5\".\"creatorsapnumber\" o42, \"enordermain5\".\"creatorsapname\" o43, \"enordermain5\".\"country\" o44, \"enordermain5\".\"isdeleted\" o45, \"enordermain5\".\"isreleased\" o46, trim_scale(\"enordermain5\".\"exchangerate\"::numeric) o47, \"enordermain5\".\"sustainabilitycategory\" o48, \"enordermain5\".\"sustainabilitysubcategory\" o49, trim_scale(\"enordermain5\".\"totalamount\"::numeric) o50, \"enordermain5\".\"fromcosmoz\" o51, \"enordermain5\".\"regionid\" o52, \"enordermain5\".\"divisionid\" o53, \"enordermain5\".\"applicant\" o54, \"enordermain5\".\"createdby\" o55, \"enordermain5\".\"createdon\" o56, \"enordermain5\".\"updatedby\" o57, \"enordermain5\".\"updatedon\" o58");
fromBuilder.Append(" FROM (({Folio} \"enfolio2\" Inner JOIN {OrderMain} \"enordermain5\" ON (\"enfolio2\".\"orderid\" = \"enordermain5\".\"id\"))  Left JOIN {FolioApproval} \"enfolioapproval2\" ON (\"enfolio2\".\"id\" = \"enfolioapproval2\".\"folioid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio2\".\"id\" = @qpfoFolio_Id) AND (\"enfolio2\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio2\".\"id\" IS NULL)");
}
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
RL_ecd1c5152b10fa2a937ada7598ead4ad outParamList = new RL_ecd1c5152b10fa2a937ada7598ead4ad();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioCancelFromProveedor.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ecd1c5152b10fa2a937ada7598ead4ad _tmp = new RL_ecd1c5152b10fa2a937ada7598ead4ad();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioCancelFromProveedor.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ecd1c5152b10fa2a937ada7598ead4ad)_tmp;
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

// Query Function "GetInvoicesByFolioId" Ch4PrPnWDEGgoHgT863XGA of Action "FolioCancelFromProveedor"
public static async Task<(RL_7b3475883ca90ad6eb7fc983e868c456,long)> datasetGetInvoicesByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioCancelFromProveedor.GetInvoicesByFolioId", "ac0f1e0a-d6f9-410c-a0a0-7813f3add718");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioCancelFromProveedor.GetInvoicesByFolioId", "ac0f1e0a-d6f9-410c-a0a0-7813f3add718", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
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
selectBuilder.Append("/* /UserActions.B4J7GGQGQkudVYbyVaKU9g/NodesNotShownInESpaceTree.Ch4PrPnWDEGgoHgT863XGA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice4\".\"id\" o0, \"eninvoice4\".\"name\" o1, \"eninvoice4\".\"requisitionid\" o2, \"eninvoice4\".\"folioid\" o3, \"eninvoice4\".\"ordermainid\" o4, \"eninvoice4\".\"cfditypeid\" o5, trim_scale(\"eninvoice4\".\"totalamount\"::numeric) o6, \"eninvoice4\".\"currency\" o7, \"eninvoice4\".\"invoicestatusid\" o8, \"eninvoice4\".\"accountingdatetime\" o9, \"eninvoice4\".\"paymentdatetime\" o10, \"eninvoice4\".\"createdon\" o11, \"eninvoice4\".\"createdby\" o12, \"eninvoice4\".\"updatedon\" o13, \"eninvoice4\".\"updatedby\" o14, \"eninvoice4\".\"submittedon\" o15, \"eninvoice4\".\"isnewversion\" o16, \"eninvoice4\".\"id_poliza\" o17, \"eninvoice4\".\"id_poliza_sap\" o18, \"eninvoice4\".\"doc51\" o19, \"eninvoice4\".\"accountingerror\" o20, \"eninvoice4\".\"orderaccconceptsid\" o21, trim_scale(\"eninvoice4\".\"amortization\"::numeric) o22, \"eninvoice4\".\"creditnoteinvoiceid\" o23");
fromBuilder.Append(" FROM {Invoice} \"eninvoice4\"");
whereBuilder.Append(" WHERE ");
if (qpfoFolioId != 0) {
whereBuilder.Append("((\"eninvoice4\".\"folioid\" = @qpfoFolioId) AND (\"eninvoice4\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioId", DbType.Int64, qpfoFolioId);
} else {
whereBuilder.Append("(\"eninvoice4\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"eninvoice4\".\"name\" ASC ");
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
RL_7b3475883ca90ad6eb7fc983e868c456 outParamList = new RL_7b3475883ca90ad6eb7fc983e868c456();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioCancelFromProveedor.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_7b3475883ca90ad6eb7fc983e868c456 _tmp = new RL_7b3475883ca90ad6eb7fc983e868c456();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioCancelFromProveedor.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_7b3475883ca90ad6eb7fc983e868c456)_tmp;
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



}


}
