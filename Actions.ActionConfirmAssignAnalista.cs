namespace ssConectaProveedores;

public partial class Actions {
public class lcvConfirmAssignAnalista : VarsBag {
public long inParami_InvoiceId;
public long inParami_InvoiceApprovalLevelId;
public string inParami_UserId;
public string inParami_GetUserId;
/// <summary>
/// Variable <code>l_InvoiceApprovalLevel</code> that represents the Service Studio
///  InvoiceApprovalLevel <code>l_InvoiceApprovalLevel</code> <p>Description: </p>
/// </summary>
public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord varLcl_InvoiceApprovalLevel = new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord();

public Actions.lcoHasActiveSubstitution resHasActiveSubstitution =  new Actions.lcoHasActiveSubstitution();
public Actions.lcoInvoiceLogAdd resInvoiceLogAdd =  new Actions.lcoInvoiceLogAdd();
public RL_e8a2bfdbad62aa404e80d55d80faa387 queryResGetInvoiceApprovalLevel_outParamList = new RL_e8a2bfdbad62aa404e80d55d80faa387();
public long queryResGetInvoiceApprovalLevel_outParamCount = 0L;

public Actions.lcoInvoiceApprovalCreateOrUpdate resInvoiceApprovalCreateOrUpdate =  new Actions.lcoInvoiceApprovalCreateOrUpdate();
public Actions.lcoInvoiceApprovalLevelCreateOrUpdate resInvoiceApprovalLevelCreateOrUpdate =  new Actions.lcoInvoiceApprovalLevelCreateOrUpdate();
public RL_752c66ffcb633a1081093541635464e7 queryResGetUserById_outParamList = new RL_752c66ffcb633a1081093541635464e7();
public long queryResGetUserById_outParamCount = 0L;

public Actions.lcoInvoiceApprovalLevelCreateOrUpdate resInvoiceApprovalLevelCreateOrUpdate2 =  new Actions.lcoInvoiceApprovalLevelCreateOrUpdate();
public RL_137ca0bd922b82f91f39dd017e999a51 queryResGetUserApplicationRoleAreaCxP_outParamList = new RL_137ca0bd922b82f91f39dd017e999a51();
public long queryResGetUserApplicationRoleAreaCxP_outParamCount = 0L;

public lcvConfirmAssignAnalista(long inParami_InvoiceId, long inParami_InvoiceApprovalLevelId, string inParami_UserId, string inParami_GetUserId) {
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_InvoiceApprovalLevelId = inParami_InvoiceApprovalLevelId;
this.inParami_UserId = inParami_UserId;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoConfirmAssignAnalista : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoConfirmAssignAnalista() {
}
}
/// <summary>
/// Action <code>ConfirmAssignAnalista</code> that represents the Service Studio action
///  <code>ConfirmAssignAnalista</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionConfirmAssignAnalista(IRequestContext requestContext,long inParami_InvoiceId,long inParami_InvoiceApprovalLevelId,string inParami_UserId,string inParami_GetUserId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoConfirmAssignAnalista result = new lcoConfirmAssignAnalista();
lcvConfirmAssignAnalista localVars = new lcvConfirmAssignAnalista(inParami_InvoiceId, inParami_InvoiceApprovalLevelId, inParami_UserId, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ConfirmAssignAnalista", "cf2799b7-9d4c-430a-9098-e3da789126fa"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ConfirmAssignAnalista", "cf2799b7-9d4c-430a-9098-e3da789126fa", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceApprovalLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceApprovalLevel_maxRecords = 1;
if (datasetGetInvoiceApprovalLevel_maxRecords < 1) datasetGetInvoiceApprovalLevel_maxRecords = 1;
int datasetGetInvoiceApprovalLevel_startIndex = 0;(localVars.queryResGetInvoiceApprovalLevel_outParamList,localVars.queryResGetInvoiceApprovalLevel_outParamCount) = await FuncActionConfirmAssignAnalista.datasetGetInvoiceApprovalLevel(requestContext,datasetGetInvoiceApprovalLevel_maxRecords,datasetGetInvoiceApprovalLevel_startIndex,IterationMultiplicity.Never,localVars.inParami_InvoiceApprovalLevelId,cancellationToken);

if(((localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovalStatusId!=(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("BjgcXy0kFU+8e5Ko3emFig"))).ssId))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Invoice cannot be updated!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("eciKzSPK5Um1sAfO6Rg0Xg#Value.444407385.1", "Invoice cannot be updated!");
} else {
// Query datasetGetUserById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserById_maxRecords = 1;
if (datasetGetUserById_maxRecords < 1) datasetGetUserById_maxRecords = 1;
int datasetGetUserById_startIndex = 0;(localVars.queryResGetUserById_outParamList,localVars.queryResGetUserById_outParamCount) = await FuncActionConfirmAssignAnalista.datasetGetUserById(requestContext,datasetGetUserById_maxRecords,datasetGetUserById_startIndex,IterationMultiplicity.Never,localVars.inParami_UserId,cancellationToken);

// Query datasetGetUserApplicationRoleAreaCxP
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserApplicationRoleAreaCxP_maxRecords = 1;
if (datasetGetUserApplicationRoleAreaCxP_maxRecords < 1) datasetGetUserApplicationRoleAreaCxP_maxRecords = 1;
int datasetGetUserApplicationRoleAreaCxP_startIndex = 0;(localVars.queryResGetUserApplicationRoleAreaCxP_outParamList,localVars.queryResGetUserApplicationRoleAreaCxP_outParamCount) = await FuncActionConfirmAssignAnalista.datasetGetUserApplicationRoleAreaCxP(requestContext,datasetGetUserApplicationRoleAreaCxP_maxRecords,datasetGetUserApplicationRoleAreaCxP_startIndex,IterationMultiplicity.Never,localVars.inParami_UserId,cancellationToken);

// HasActiveSubstitution
(localVars.resHasActiveSubstitution.outParamo_SubstituteUserId,localVars.resHasActiveSubstitution.outParamo_IsSubstituteFor) = await Actions.ActionHasActiveSubstitution(requestContext,localVars.inParami_UserId,cancellationToken);

// CurrentApprovalLevel
// GetInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.ApprovalStatusId = Assigned
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("85A3EYx6OkWpq0CAyB7XJw"))).ssId;

// GetInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.ApprovedBy = If
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ()));

// GetInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.ApprovedOn = CurrDateTime
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovedOn = BuiltInFunction.CurrDateTime ();

// GetInvoiceApprovalLevel.List.Current.InvoiceApproval.CurrentLevel = GetInvoiceApprovalLevel.List.Current.InvoiceApproval.CurrentLevel + 1
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssCurrentLevel = (localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssCurrentLevel+1);

// GetInvoiceApprovalLevel.List.Current.InvoiceApprovalLevel.AssignedTo = If
localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssAssignedTo = (((localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssAssignedTo!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssAssignedTo) : ((((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ()))));
// l_InvoiceApprovalLevel
// l_InvoiceApprovalLevel.InvoiceApprovalId = GetInvoiceApprovalLevel.List.Current.InvoiceApproval.Id
localVars.varLcl_InvoiceApprovalLevel.ssInvoiceApprovalId = localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssId;

// l_InvoiceApprovalLevel.AssignedTo = If
localVars.varLcl_InvoiceApprovalLevel.ssAssignedTo = (((localVars.resHasActiveSubstitution.outParamo_SubstituteUserId==BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_UserId) : (localVars.resHasActiveSubstitution.outParamo_SubstituteUserId));

// l_InvoiceApprovalLevel.ApprovalStatusId = NotApproved
localVars.varLcl_InvoiceApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// l_InvoiceApprovalLevel.LevelNumber = GetInvoiceApprovalLevel.List.Current.InvoiceApproval.CurrentLevel + 1
localVars.varLcl_InvoiceApprovalLevel.ssLevelNumber = (localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval.ssCurrentLevel+1);

// l_InvoiceApprovalLevel.EntraJobTitle = GetUserById.List.Current.User_Extended_Internal.JobTitle
localVars.varLcl_InvoiceApprovalLevel.ssEntraJobTitle = localVars.queryResGetUserById_outParamList.CurrentRec.ssENUser_Extended_Internal.ssJobTitle;

// l_InvoiceApprovalLevel.EntraRoleId = GetUserById.List.Current.User_Extended_Internal.EntraRoleId
localVars.varLcl_InvoiceApprovalLevel.ssEntraRoleId = localVars.queryResGetUserById_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEntraRoleId;

// l_InvoiceApprovalLevel.IsSubstituteFor = HasActiveSubstitution.o_IsSubstituteFor
localVars.varLcl_InvoiceApprovalLevel.ssIsSubstituteFor = localVars.resHasActiveSubstitution.outParamo_IsSubstituteFor;

// l_InvoiceApprovalLevel.IsAccounting = True
localVars.varLcl_InvoiceApprovalLevel.ssIsAccounting = true;

// l_InvoiceApprovalLevel.ApplicationRoleId = GetUserApplicationRoleAreaCxP.List.Current.ApplicationRole.Id
localVars.varLcl_InvoiceApprovalLevel.ssApplicationRoleId = localVars.queryResGetUserApplicationRoleAreaCxP_outParamList.CurrentRec.ssENApplicationRole.ssId;
// InvoiceApprovalCreateOrUpdate
localVars.resInvoiceApprovalCreateOrUpdate.outParamId = await Actions.ActionInvoiceApprovalCreateOrUpdate(requestContext,localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApproval,cancellationToken);

// InvoiceApprovalLevelCreateOrUpdate
localVars.resInvoiceApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionInvoiceApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetInvoiceApprovalLevel_outParamList.CurrentRec.ssENInvoiceApprovalLevel,cancellationToken);

// InvoiceApprovalLevelCreateOrUpdate2
localVars.resInvoiceApprovalLevelCreateOrUpdate2.outParamId = await Actions.ActionInvoiceApprovalLevelCreateOrUpdate(requestContext,localVars.varLcl_InvoiceApprovalLevel,cancellationToken);

// InvoiceLogAdd
localVars.resInvoiceLogAdd.outParamId = await Actions.ActionInvoiceLogAdd(requestContext,new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceId, ssMessage = ((localVars.queryResGetUserById_outParamList.CurrentRec.ssENUser.ssName+" ")+AppUtils.GetStringResource("FaKRxHYtzUuGYaQILMIasw#Value.1035108624.1", "has been assigned as the approver.")), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())) },cancellationToken);

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

public static class FuncActionConfirmAssignAnalista {

private static async Task<RC_bc68025e789d69992aef27aed0947c65> datasetGetInvoiceApprovalLevelReadDbAsync(RC_bc68025e789d69992aef27aed0947c65 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceApprovalLevel" 2AgNonvNDEeTpVPZdoPcjA of Action "ConfirmAssignAnalista"
public static async Task<(RL_e8a2bfdbad62aa404e80d55d80faa387,long)> datasetGetInvoiceApprovalLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceApprovalLevel_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ConfirmAssignAnalista.GetInvoiceApprovalLevel", "a20d08d8-cd7b-470c-93a5-53d97683dc8c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ConfirmAssignAnalista.GetInvoiceApprovalLevel", "a20d08d8-cd7b-470c-93a5-53d97683dc8c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.t5knz0ydCkOQmOPaeJEm+g/NodesNotShownInESpaceTree.2AgNonvNDEeTpVPZdoPcjA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, \"eninvoiceapproval20\".\"id\" o24, \"eninvoiceapproval20\".\"invoiceid\" o25, \"eninvoiceapproval20\".\"aprovalprocessid\" o26, \"eninvoiceapproval20\".\"processtypecode\" o27, \"eninvoiceapproval20\".\"approvalprocessversion\" o28, \"eninvoiceapproval20\".\"currentlevel\" o29, \"eninvoiceapproval20\".\"maxlevel\" o30, \"eninvoiceapproval20\".\"startedon\" o31, \"eninvoiceapproval20\".\"finishedon\" o32, \"eninvoiceapproval20\".\"hasstartedaccounting\" o33, \"eninvoiceapprovallevel21\".\"id\" o34, \"eninvoiceapprovallevel21\".\"invoiceapprovalid\" o35, \"eninvoiceapprovallevel21\".\"levelnumber\" o36, \"eninvoiceapprovallevel21\".\"assignedto\" o37, \"eninvoiceapprovallevel21\".\"applicationroleid\" o38, \"eninvoiceapprovallevel21\".\"entrajobtitle\" o39, \"eninvoiceapprovallevel21\".\"departmentid\" o40, \"eninvoiceapprovallevel21\".\"managementid\" o41, \"eninvoiceapprovallevel21\".\"subdirectionid\" o42, \"eninvoiceapprovallevel21\".\"entraroleid\" o43, \"eninvoiceapprovallevel21\".\"approvalstatusid\" o44, \"eninvoiceapprovallevel21\".\"canbefirstapprover\" o45, \"eninvoiceapprovallevel21\".\"selectsnextapprover\" o46, \"eninvoiceapprovallevel21\".\"selectsfirstapprover\" o47, \"eninvoiceapprovallevel21\".\"isaccounting\" o48, \"eninvoiceapprovallevel21\".\"isstartaccounting\" o49, \"eninvoiceapprovallevel21\".\"approvedby\" o50, \"eninvoiceapprovallevel21\".\"approvedon\" o51, \"eninvoiceapprovallevel21\".\"requesttomodifyby\" o52, \"eninvoiceapprovallevel21\".\"requesttomodifyon\" o53, \"eninvoiceapprovallevel21\".\"canceledby\" o54, \"eninvoiceapprovallevel21\".\"canceledon\" o55, \"eninvoiceapprovallevel21\".\"needscontract_deprec\" o56, \"eninvoiceapprovallevel21\".\"isreassigned\" o57, \"eninvoiceapprovallevel21\".\"issubstitutefor\" o58");
fromBuilder.Append(" FROM (({Invoice} \"eninvoice62\" Left JOIN {InvoiceApproval} \"eninvoiceapproval20\" ON (\"eninvoice62\".\"id\" = \"eninvoiceapproval20\".\"invoiceid\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel21\" ON (\"eninvoiceapproval20\".\"id\" = \"eninvoiceapprovallevel21\".\"invoiceapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceApprovalLevel_Id != 0) {
whereBuilder.Append("((\"eninvoiceapprovallevel21\".\"id\" = @qpinInvoiceApprovalLevel_Id) AND (\"eninvoiceapprovallevel21\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceApprovalLevel_Id", DbType.Int64, qpinInvoiceApprovalLevel_Id);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel21\".\"id\" IS NULL)");
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
RL_e8a2bfdbad62aa404e80d55d80faa387 outParamList = new RL_e8a2bfdbad62aa404e80d55d80faa387();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceApprovalLevelReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ConfirmAssignAnalista.GetInvoiceApprovalLevel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e8a2bfdbad62aa404e80d55d80faa387 _tmp = new RL_e8a2bfdbad62aa404e80d55d80faa387();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceApprovalLevelReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ConfirmAssignAnalista.GetInvoiceApprovalLevel.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e8a2bfdbad62aa404e80d55d80faa387)_tmp;
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

private static async Task<RC_34272dae45b4de5e1332f46c6e8700b9> datasetGetUserByIdReadDbAsync(RC_34272dae45b4de5e1332f46c6e8700b9 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetUserById" vdaPxDK2XUaZBH_f8JKr3g of Action "ConfirmAssignAnalista"
public static async Task<(RL_752c66ffcb633a1081093541635464e7,long)> datasetGetUserById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ConfirmAssignAnalista.GetUserById", "c48fd6bd-b632-465d-9904-7fdff092abde");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ConfirmAssignAnalista.GetUserById", "c48fd6bd-b632-465d-9904-7fdff092abde", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.t5knz0ydCkOQmOPaeJEm+g/NodesNotShownInESpaceTree.vdaPxDK2XUaZBH_f8JKr3g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enuser116\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"enuser_extended_internal67\".\"jobtitle\" o14, \"enuser_extended_internal67\".\"entraroleid\" o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24");
fromBuilder.Append(" FROM ({User} \"enuser116\" Left JOIN {User_Extended_Internal} \"enuser_extended_internal67\" ON (\"enuser116\".\"id\" = \"enuser_extended_internal67\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser116\".\"id\" = @qpusUser_Id) AND (\"enuser116\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser116\".\"id\" IS NULL)");
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
RL_752c66ffcb633a1081093541635464e7 outParamList = new RL_752c66ffcb633a1081093541635464e7();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, false, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ConfirmAssignAnalista.GetUserById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_752c66ffcb633a1081093541635464e7 _tmp = new RL_752c66ffcb633a1081093541635464e7();
_tmp.AlternateReadDbMethodAsync = datasetGetUserByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ConfirmAssignAnalista.GetUserById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_752c66ffcb633a1081093541635464e7)_tmp;
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

private static async Task<RC_7b8200225d1e3acafed4d42f9fce9055> datasetGetUserApplicationRoleAreaCxPReadDbAsync(RC_7b8200225d1e3acafed4d42f9fce9055 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENEntraRole.Read( r, ref index);
rec.ssENRoleConcept.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetUserApplicationRoleAreaCxP" nnXF5iSAnUGfMaaYSH8evQ of Action "ConfirmAssignAnalista"
public static async Task<(RL_137ca0bd922b82f91f39dd017e999a51,long)> datasetGetUserApplicationRoleAreaCxP(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ConfirmAssignAnalista.GetUserApplicationRoleAreaCxP", "e6c5759e-8024-419d-9f31-a698487f1ebd");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ConfirmAssignAnalista.GetUserApplicationRoleAreaCxP", "e6c5759e-8024-419d-9f31-a698487f1ebd", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.t5knz0ydCkOQmOPaeJEm+g/NodesNotShownInESpaceTree.nnXF5iSAnUGfMaaYSH8evQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapplicationrole26\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41");
fromBuilder.Append(" FROM (((({User} \"enuser117\" Left JOIN {User_Extended_Internal} \"enuser_extended_internal68\" ON (\"enuser117\".\"id\" = \"enuser_extended_internal68\".\"id\"))  Left JOIN {EntraRole} \"enentrarole33\" ON (\"enuser_extended_internal68\".\"entraroleid\" = \"enentrarole33\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept11\" ON (\"enentrarole33\".\"id\" = \"enroleconcept11\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole26\" ON (\"enroleconcept11\".\"applicationroleid\" = \"enapplicationrole26\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser117\".\"id\" = @qpusUser_Id) AND (\"enuser117\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser117\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapplicationrole26\".\"isareacxp\" = 1)");
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
RL_137ca0bd922b82f91f39dd017e999a51 outParamList = new RL_137ca0bd922b82f91f39dd017e999a51();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserApplicationRoleAreaCxPReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true});
opt[2] = new BitArray(new bool[] {false, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ConfirmAssignAnalista.GetUserApplicationRoleAreaCxP.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_137ca0bd922b82f91f39dd017e999a51 _tmp = new RL_137ca0bd922b82f91f39dd017e999a51();
_tmp.AlternateReadDbMethodAsync = datasetGetUserApplicationRoleAreaCxPReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ConfirmAssignAnalista.GetUserApplicationRoleAreaCxP.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_137ca0bd922b82f91f39dd017e999a51)_tmp;
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
