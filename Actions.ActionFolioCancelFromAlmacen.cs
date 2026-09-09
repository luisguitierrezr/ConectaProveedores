namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioCancelFromAlmacen : VarsBag {
public long inParami_FolioId;
public string inParami_CancelReason;
public Actions.lcoFolioCreateOrUpdate resFolioCreateOrUpdate =  new Actions.lcoFolioCreateOrUpdate();
public Actions.lcoFolioLogAdd resFolioLogAdd =  new Actions.lcoFolioLogAdd();
public RL_ecd1c5152b10fa2a937ada7598ead4ad queryResGetFolioById_outParamList = new RL_ecd1c5152b10fa2a937ada7598ead4ad();
public long queryResGetFolioById_outParamCount = 0L;

public lcvFolioCancelFromAlmacen(long inParami_FolioId, string inParami_CancelReason) {
this.inParami_FolioId = inParami_FolioId;
this.inParami_CancelReason = inParami_CancelReason;
}
}
public class lcoFolioCancelFromAlmacen : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoFolioCancelFromAlmacen() {
}
}
/// <summary>
/// Action <code>FolioCancelFromAlmacen</code> that represents the Service Studio action
///  <code>FolioCancelFromAlmacen</code> <p> Description: Action to Cancel Folio.</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionFolioCancelFromAlmacen(IRequestContext requestContext,long inParami_FolioId,string inParami_CancelReason,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoFolioCancelFromAlmacen result = new lcoFolioCancelFromAlmacen();
lcvFolioCancelFromAlmacen localVars = new lcvFolioCancelFromAlmacen(inParami_FolioId, inParami_CancelReason);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioCancelFromAlmacen", "fbd467ab-ef3e-46be-8174-4c72f85340ee"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioCancelFromAlmacen", "fbd467ab-ef3e-46be-8174-4c72f85340ee", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 1;
if (datasetGetFolioById_maxRecords < 1) datasetGetFolioById_maxRecords = 1;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionFolioCancelFromAlmacen.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.inParami_FolioId,cancellationToken);

// Empty?
if((localVars.queryResGetFolioById_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Folio not found!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("vBqESkQ6qkiZ6mlGxKYIpQ#Value.1482511939.1", "Folio not found!");
} else {
// Level Not Approved?
if(((localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApproval.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Folio cannot be updated!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("am1DyOvXa0Svrl3BJycKzQ#Value.1911675613.1", "Folio cannot be updated!");
} else {
// Folio Fields
// GetFolioById.List.Current.Folio.FolioStatusId = Canceled
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioStatusId = (ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId;

// GetFolioById.List.Current.Folio.CanProveedorCancel = False
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssCanProveedorCancel = false;
// FolioApprovalDelete
await Actions.ActionFolioApprovalDelete(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApproval.ssId,cancellationToken);

// FolioCreateOrUpdate
localVars.resFolioCreateOrUpdate.outParamId = await Actions.ActionFolioCreateOrUpdate(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio,cancellationToken);

// CancelInvoiceByFolioId
await Actions.ActionCancelInvoiceByFolioId(requestContext,localVars.resFolioCreateOrUpdate.outParamId,cancellationToken);

// FolioLogAdd
localVars.resFolioLogAdd.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_FolioId, ssMessage = (((((((AppUtils.GetStringResource("NuV5lDTJ0EGatq4Ccs1cMg#Value.2195684.1", "Form")+" ")+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+" ")+AppUtils.GetStringResource("NuV5lDTJ0EGatq4Ccs1cMg#Value.666913335.1", "manually cancelled with the following comment:"))+" ")+localVars.inParami_CancelReason)+"."), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsError = true, ssIsForSupplier = true },cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// SendEmailApprovers_FolioCancel
await Actions.ActionSendEmailApprovers_FolioCancel(requestContext,localVars.inParami_FolioId,localVars.inParami_CancelReason,"",cancellationToken);

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionFolioCancelFromAlmacen {

private static async Task<RC_f7c91773292f225022263e13d34e21c5> datasetGetFolioByIdReadDbAsync(RC_f7c91773292f225022263e13d34e21c5 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" Dmae51Hvmkm7Se1mJAKf+g of Action "FolioCancelFromAlmacen"
public static async Task<(RL_ecd1c5152b10fa2a937ada7598ead4ad,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioCancelFromAlmacen.GetFolioById", "e79e660e-ef51-499a-bb49-ed6624029ffa");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioCancelFromAlmacen.GetFolioById", "e79e660e-ef51-499a-bb49-ed6624029ffa", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.q2fU+z7vvkaBdExy+FNA7g/NodesNotShownInESpaceTree.Dmae51Hvmkm7Se1mJAKf+g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio58\".\"id\" o0, \"enfolio58\".\"isdraft\" o1, \"enfolio58\".\"folionumber\" o2, \"enfolio58\".\"canproveedorcancel\" o3, \"enfolio58\".\"orderid\" o4, \"enfolio58\".\"supplierid\" o5, \"enfolio58\".\"companyid\" o6, \"enfolio58\".\"foliostatusid\" o7, trim_scale(\"enfolio58\".\"totalamount\"::numeric) o8, trim_scale(\"enfolio58\".\"totaliva_amount\"::numeric) o9, trim_scale(\"enfolio58\".\"partialamount\"::numeric) o10, \"enfolio58\".\"currencyid\" o11, \"enfolio58\".\"firstapproveruserid\" o12, \"enfolio58\".\"approvalprocesstypeid\" o13, \"enfolio58\".\"sapentryerror\" o14, \"enfolio58\".\"createdby\" o15, \"enfolio58\".\"createdon\" o16, \"enfolio58\".\"updatedby\" o17, \"enfolio58\".\"updatedon\" o18, \"enfolio58\".\"minuteselected\" o19, \"enfolioapproval31\".\"id\" o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58");
fromBuilder.Append(" FROM (({Folio} \"enfolio58\" Left JOIN {FolioApproval} \"enfolioapproval31\" ON (\"enfolio58\".\"id\" = \"enfolioapproval31\".\"folioid\"))  Inner JOIN {OrderMain} \"enordermain66\" ON (\"enfolio58\".\"orderid\" = \"enordermain66\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio58\".\"id\" = @qpfoFolio_Id) AND (\"enfolio58\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio58\".\"id\" IS NULL)");
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
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioCancelFromAlmacen.GetFolioById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioCancelFromAlmacen.GetFolioById.List", cancellationToken: cancellationToken);
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



}


}
