namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioEstablishFlow : VarsBag {
public long inParami_FolioId;
public long inParami_ApprovalProcessId;
public RL_5e0ca6ca9da3af4b1d8149758c39c2cf queryResGetApprovalProcessById_outParamList = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
public long queryResGetApprovalProcessById_outParamCount = 0L;

public Actions.lcoFolioLogAdd resFolioLogAdd2 =  new Actions.lcoFolioLogAdd();
public Actions.lcoFolioCreateOrUpdate resFolioCreateOrUpdate =  new Actions.lcoFolioCreateOrUpdate();
public RL_f2334acea7cfd80330b429c488fa4f97 queryResGetFolioById_outParamList = new RL_f2334acea7cfd80330b429c488fa4f97();
public long queryResGetFolioById_outParamCount = 0L;

public Actions.lcoInitFolioWF_FromApprovProcId resInitFolioWF_FromApprovProcId =  new Actions.lcoInitFolioWF_FromApprovProcId();
public Actions.lcoFolioLogAdd resFolioLogAdd =  new Actions.lcoFolioLogAdd();
public lcvFolioEstablishFlow(long inParami_FolioId, long inParami_ApprovalProcessId) {
this.inParami_FolioId = inParami_FolioId;
this.inParami_ApprovalProcessId = inParami_ApprovalProcessId;
}
}
public class lcoFolioEstablishFlow : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoFolioEstablishFlow() {
}
}
/// <summary>
/// Action <code>FolioEstablishFlow</code> that represents the Service Studio action
///  <code>FolioEstablishFlow</code> <p> Description: Action to Establish Flow Folio.</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionFolioEstablishFlow(IRequestContext requestContext,long inParami_FolioId,long inParami_ApprovalProcessId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoFolioEstablishFlow result = new lcoFolioEstablishFlow();
lcvFolioEstablishFlow localVars = new lcvFolioEstablishFlow(inParami_FolioId, inParami_ApprovalProcessId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioEstablishFlow", "b82b3457-15d6-4e03-948e-76e465e83969"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioEstablishFlow", "b82b3457-15d6-4e03-948e-76e465e83969", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 1;
if (datasetGetFolioById_maxRecords < 1) datasetGetFolioById_maxRecords = 1;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncActionFolioEstablishFlow.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.inParami_FolioId,cancellationToken);

// Empty?
if((localVars.queryResGetFolioById_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Form SAE not found!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("uHoDs4dFQkKuTi_TuO1dyQ#Value.-938072687.1", "Form SAE not found!");
} else {
// Query datasetGetApprovalProcessById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessById_maxRecords = 1;
if (datasetGetApprovalProcessById_maxRecords < 1) datasetGetApprovalProcessById_maxRecords = 1;
int datasetGetApprovalProcessById_startIndex = 0;(localVars.queryResGetApprovalProcessById_outParamList,localVars.queryResGetApprovalProcessById_outParamCount) = await FuncActionFolioEstablishFlow.datasetGetApprovalProcessById(requestContext,datasetGetApprovalProcessById_maxRecords,datasetGetApprovalProcessById_startIndex,IterationMultiplicity.Never,localVars.inParami_ApprovalProcessId,cancellationToken);

// Not found?
if((localVars.queryResGetApprovalProcessById_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Approval workflow selected not found!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("wNBqYbNbqEmQIWND9mAUoA#Value.-386675667.1", "Approval workflow selected not found!");
} else {
// Has FolioApproval?
if(((localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApproval.ssId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// FolioApprovalDelete
await Actions.ActionFolioApprovalDelete(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolioApproval.ssId,cancellationToken);

}

// InitFolioWF_FromApprovProcId
localVars.resInitFolioWF_FromApprovProcId.outParamo_Output = await Actions.ActionInitFolioWF_FromApprovProcId(requestContext,localVars.inParami_FolioId,localVars.inParami_ApprovalProcessId,BuiltInFunction.NullIdentifier (),AppUtils.GetStringResource("uEoQWbr_i0azaprhl7FCgQ#Value.363639310.1", "FolioSAE"),cancellationToken);

// IsSuccess?
if((localVars.resInitFolioWF_FromApprovProcId.outParamo_Output.ssIsSuccess)) {
// FolioLogAdd2
localVars.resFolioLogAdd2.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_FolioId, ssMessage = (((((((AppUtils.GetStringResource("j8bvzwXRs0ulQn5caAKPpg#Value.-647429749.1", "New workflow has been established")+": ")+localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcess.ssCode)+" v")+Convert.ToString(localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcess.ssVersion))+" (")+localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcess.ssDescription)+")"), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// Status
// GetFolioById.List.Current.Folio.FolioStatusId = PendingApproval
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioStatusId = (ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("OLAtbBHfEkWbS1oUJ_NMaQ"))).ssId;

// GetFolioById.List.Current.Folio.CanProveedorCancel = True
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssCanProveedorCancel = true;

// GetFolioById.List.Current.Folio.ApprovalProcessTypeId = Special
localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssApprovalProcessTypeId = 2;
// FolioCreateOrUpdate
localVars.resFolioCreateOrUpdate.outParamId = await Actions.ActionFolioCreateOrUpdate(requestContext,localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio,cancellationToken);

// FolioLogAdd
localVars.resFolioLogAdd.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_FolioId, ssMessage = (((((AppUtils.GetStringResource("f7A5QDfYbU2wHTTGg_KK+w#Value.2195684.1", "Form")+" ")+localVars.queryResGetFolioById_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+" ")+AppUtils.GetStringResource("f7A5QDfYbU2wHTTGg_KK+w#Value.471966874.1", "reinitiated approval process"))+"."), ssCreatedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// CommitTransaction
await ExtendedActions.CommitTransaction(requestContext,cancellationToken);

{
    using (AppHealthProvider.CreateGlobalEventTriggerMetric("OnSendFolioFirstApproverEmail", "04e3f56a-3556-4e71-9db9-12df3da8b83b"))
    using (activitySource.CreateTriggerEventActivity("OnSendFolioFirstApproverEmail", "04e3f56a-3556-4e71-9db9-12df3da8b83b", "25ff866d-6edc-4dc9-8233-8f1985921947", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
        var input = new EventPayloads.GlobalEventOnSendFolioFirstApproverEmailPayload() {inParami_FolioId = localVars.inParami_FolioId};

        var eventPublisher = ServiceLocator.GetService<IEventPublisher>();
        await eventPublisher.PublishEventAsync("OnSendFolioFirstApproverEmail", "25ff866d-6edc-4dc9-8233-8f1985921947", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828", input, cancellationToken);
    }
}

} else {
// RaiseError InitializeWF
throw new Ex_InitializeWFUserException (localVars.resInitFolioWF_FromApprovProcId.outParamo_Output.ssMessage);

}

}

}

} //close CreateActionActivity using block
} // try

catch (Ex_InitializeWFUserException ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = InitializeWF.ExceptionMessage
result.outParamo_Output.ssMessage = ex.Message;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamo_Output = result.outParamo_Output;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionFolioEstablishFlow {

// Query Function "GetApprovalProcessById" XiKyCW2csk6oOIE0njjoSw of Action "FolioEstablishFlow"
public static async Task<(RL_5e0ca6ca9da3af4b1d8149758c39c2cf,long)> datasetGetApprovalProcessById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpapId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioEstablishFlow.GetApprovalProcessById", "09b2225e-9c6d-4eb2-a838-81349e38e84b");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioEstablishFlow.GetApprovalProcessById", "09b2225e-9c6d-4eb2-a838-81349e38e84b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.VzQruNYVA06UjnbkZeg5aQ/NodesNotShownInESpaceTree.XiKyCW2csk6oOIE0njjoSw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enapprovalprocess27\".\"code\" o7, \"enapprovalprocess27\".\"version\" o8, \"enapprovalprocess27\".\"description\" o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18");
fromBuilder.Append(" FROM {ApprovalProcess} \"enapprovalprocess27\"");
whereBuilder.Append(" WHERE ");
if (qpapId != 0) {
whereBuilder.Append("((\"enapprovalprocess27\".\"id\" = @qpapId) AND (\"enapprovalprocess27\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapId", DbType.Int64, qpapId);
} else {
whereBuilder.Append("(\"enapprovalprocess27\".\"id\" IS NULL)");
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
RL_5e0ca6ca9da3af4b1d8149758c39c2cf outParamList = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, false, false, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioEstablishFlow.GetApprovalProcessById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5e0ca6ca9da3af4b1d8149758c39c2cf _tmp = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioEstablishFlow.GetApprovalProcessById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5e0ca6ca9da3af4b1d8149758c39c2cf)_tmp;
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

private static async Task<RC_d62ad7391a87381616a77aeae304e183> datasetGetFolioByIdReadDbAsync(RC_d62ad7391a87381616a77aeae304e183 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" y7hnsdjpcUm0Hd7dln+EUw of Action "FolioEstablishFlow"
public static async Task<(RL_f2334acea7cfd80330b429c488fa4f97,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("FolioEstablishFlow.GetFolioById", "b167b8cb-e9d8-4971-b41d-dedd967f8453");
using var queryActivity = activitySource.CreateAggregateQueryActivity("FolioEstablishFlow.GetFolioById", "b167b8cb-e9d8-4971-b41d-dedd967f8453", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.VzQruNYVA06UjnbkZeg5aQ/NodesNotShownInESpaceTree.y7hnsdjpcUm0Hd7dln+EUw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio46\".\"id\" o0, \"enfolio46\".\"isdraft\" o1, \"enfolio46\".\"folionumber\" o2, \"enfolio46\".\"canproveedorcancel\" o3, \"enfolio46\".\"orderid\" o4, \"enfolio46\".\"supplierid\" o5, \"enfolio46\".\"companyid\" o6, \"enfolio46\".\"foliostatusid\" o7, trim_scale(\"enfolio46\".\"totalamount\"::numeric) o8, trim_scale(\"enfolio46\".\"totaliva_amount\"::numeric) o9, trim_scale(\"enfolio46\".\"partialamount\"::numeric) o10, \"enfolio46\".\"currencyid\" o11, \"enfolio46\".\"firstapproveruserid\" o12, \"enfolio46\".\"approvalprocesstypeid\" o13, \"enfolio46\".\"sapentryerror\" o14, \"enfolio46\".\"createdby\" o15, \"enfolio46\".\"createdon\" o16, \"enfolio46\".\"updatedby\" o17, \"enfolio46\".\"updatedon\" o18, \"enfolio46\".\"minuteselected\" o19, \"enfolioapproval26\".\"id\" o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29");
fromBuilder.Append(" FROM ({Folio} \"enfolio46\" Left JOIN {FolioApproval} \"enfolioapproval26\" ON (\"enfolio46\".\"id\" = \"enfolioapproval26\".\"folioid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio46\".\"id\" = @qpfoFolio_Id) AND (\"enfolio46\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio46\".\"id\" IS NULL)");
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
RL_f2334acea7cfd80330b429c488fa4f97 outParamList = new RL_f2334acea7cfd80330b429c488fa4f97();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query FolioEstablishFlow.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f2334acea7cfd80330b429c488fa4f97 _tmp = new RL_f2334acea7cfd80330b429c488fa4f97();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query FolioEstablishFlow.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f2334acea7cfd80330b429c488fa4f97)_tmp;
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
