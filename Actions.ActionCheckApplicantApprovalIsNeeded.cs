namespace ssConectaProveedores;

public partial class Actions {
public class lcvCheckApplicantApprovalIsNeeded : VarsBag {
public string inParami_UserId;
public long inParami_InvoiceId;
public long inParami_ApprovalProcessId;
public int inParami_ConceptId;
public bool inParami_IsAccounting;
public RL_137ca0bd922b82f91f39dd017e999a51 queryResGetUserAppRoles_outParamList = new RL_137ca0bd922b82f91f39dd017e999a51();
public long queryResGetUserAppRoles_outParamCount = 0L;

public Actions.lcoInvRoleIsNeeded resInvRoleIsNeeded =  new Actions.lcoInvRoleIsNeeded();
public RL_7b3475883ca90ad6eb7fc983e868c456 queryResGetInvoiceById_outParamList = new RL_7b3475883ca90ad6eb7fc983e868c456();
public long queryResGetInvoiceById_outParamCount = 0L;

public lcvCheckApplicantApprovalIsNeeded(string inParami_UserId, long inParami_InvoiceId, long inParami_ApprovalProcessId, int inParami_ConceptId, bool inParami_IsAccounting) {
this.inParami_UserId = inParami_UserId;
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_ApprovalProcessId = inParami_ApprovalProcessId;
this.inParami_ConceptId = inParami_ConceptId;
this.inParami_IsAccounting = inParami_IsAccounting;
}
}
public class lcoCheckApplicantApprovalIsNeeded : VarsBag {
public EN_1d28318723f39133c60733b3cce8955eEntityRecord outParamo_ApprovalProcessLevel = new EN_1d28318723f39133c60733b3cce8955eEntityRecord();

public bool outParamo_IsNeeded = false;

public lcoCheckApplicantApprovalIsNeeded() {
}
}
/// <summary>
/// Action <code>CheckApplicantApprovalIsNeeded</code> that represents the Service Studio action
///  <code>CheckApplicantApprovalIsNeeded</code> <p> Description: </p>
/// </summary>
public static async Task<(EN_1d28318723f39133c60733b3cce8955eEntityRecord,bool)> ActionCheckApplicantApprovalIsNeeded(IRequestContext requestContext,string inParami_UserId,long inParami_InvoiceId,long inParami_ApprovalProcessId,int inParami_ConceptId,bool inParami_IsAccounting,CancellationToken cancellationToken) {
EN_1d28318723f39133c60733b3cce8955eEntityRecord outParamo_ApprovalProcessLevel = default;
bool outParamo_IsNeeded = default;
lcoCheckApplicantApprovalIsNeeded result = new lcoCheckApplicantApprovalIsNeeded();
lcvCheckApplicantApprovalIsNeeded localVars = new lcvCheckApplicantApprovalIsNeeded(inParami_UserId, inParami_InvoiceId, inParami_ApprovalProcessId, inParami_ConceptId, inParami_IsAccounting);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("CheckApplicantApprovalIsNeeded", "07ae9d0e-6c34-4d84-b060-e2286ffc1333"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("CheckApplicantApprovalIsNeeded", "07ae9d0e-6c34-4d84-b060-e2286ffc1333", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetUserAppRoles
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserAppRoles_maxRecords = 0;
int datasetGetUserAppRoles_startIndex = 0;(localVars.queryResGetUserAppRoles_outParamList,localVars.queryResGetUserAppRoles_outParamCount) = await FuncActionCheckApplicantApprovalIsNeeded.datasetGetUserAppRoles(requestContext,datasetGetUserAppRoles_maxRecords,datasetGetUserAppRoles_startIndex,IterationMultiplicity.Single,localVars.inParami_ConceptId,localVars.inParami_IsAccounting,localVars.inParami_UserId,cancellationToken);

// Query datasetGetInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById_maxRecords = 0;
int datasetGetInvoiceById_startIndex = 0;(localVars.queryResGetInvoiceById_outParamList,localVars.queryResGetInvoiceById_outParamCount) = await FuncActionCheckApplicantApprovalIsNeeded.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Never,localVars.inParami_InvoiceId,cancellationToken);

// Foreach GetUserAppRoles.List
localVars.queryResGetUserAppRoles_outParamList.StartIteration();
try {while (!((localVars.queryResGetUserAppRoles_outParamList.Eof))) {
// InvRoleIsNeeded
(localVars.resInvRoleIsNeeded.outParamo_IsNeeded,localVars.resInvRoleIsNeeded.outParamo_ApprovalProcessLevel) = await Actions.ActionInvRoleIsNeeded(requestContext,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice,localVars.inParami_ApprovalProcessId,localVars.queryResGetUserAppRoles_outParamList.CurrentRec.ssENApplicationRole.ssId,localVars.inParami_IsAccounting,cancellationToken);

if((localVars.resInvRoleIsNeeded.outParamo_IsNeeded)) {
// o_IsNeeded = True
result.outParamo_IsNeeded=true;

// o_ApprovalProcessLevel = InvRoleIsNeeded.o_ApprovalProcessLevel
result.outParamo_ApprovalProcessLevel=localVars.resInvRoleIsNeeded.outParamo_ApprovalProcessLevel;
goto RETURN_STATEMENT;

}

localVars.queryResGetUserAppRoles_outParamList.Advance();
}

} finally {
localVars.queryResGetUserAppRoles_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_ApprovalProcessLevel = result.outParamo_ApprovalProcessLevel;
outParamo_IsNeeded = result.outParamo_IsNeeded;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_ApprovalProcessLevel,outParamo_IsNeeded);
}

public static class FuncActionCheckApplicantApprovalIsNeeded {

private static async Task<RC_7b8200225d1e3acafed4d42f9fce9055> datasetGetUserAppRolesReadDbAsync(RC_7b8200225d1e3acafed4d42f9fce9055 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENEntraRole.Read( r, ref index);
rec.ssENRoleConcept.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetUserAppRoles" iUuOScx7bUCI3dht+wjxNw of Action "CheckApplicantApprovalIsNeeded"
public static async Task<(RL_137ca0bd922b82f91f39dd017e999a51,long)> datasetGetUserAppRoles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,int qpcoRoleConcept_ConceptId,bool qpboi_IsAccounting,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("CheckApplicantApprovalIsNeeded.GetUserAppRoles", "498e4b89-7bcc-406d-88dd-d86dfb08f137");
using var queryActivity = activitySource.CreateAggregateQueryActivity("CheckApplicantApprovalIsNeeded.GetUserAppRoles", "498e4b89-7bcc-406d-88dd-d86dfb08f137", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Dp2uBzRshE2wYOIob_wTMw/NodesNotShownInESpaceTree.iUuOScx7bUCI3dht+wjxNw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapplicationrole\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41");
fromBuilder.Append(" FROM (((({User} \"enuser3\" Left JOIN {User_Extended_Internal} \"enuser_extended_internal2\" ON (\"enuser3\".\"id\" = \"enuser_extended_internal2\".\"id\"))  Left JOIN {EntraRole} \"enentrarole\" ON (\"enuser_extended_internal2\".\"entraroleid\" = \"enentrarole\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept\" ON (\"enentrarole\".\"id\" = \"enroleconcept\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole\" ON (\"enroleconcept\".\"applicationroleid\" = \"enapplicationrole\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser3\".\"id\" = @qpusUser_Id) AND (\"enuser3\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser3\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpcoRoleConcept_ConceptId != 0) {
whereBuilder.Append("((\"enroleconcept\".\"conceptid\" = @qpcoRoleConcept_ConceptId) AND (\"enroleconcept\".\"conceptid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpcoRoleConcept_ConceptId", DbType.Int32, qpcoRoleConcept_ConceptId);
} else {
whereBuilder.Append("(\"enroleconcept\".\"conceptid\" IS NULL)");
}
whereBuilder.Append(" AND ((CASE WHEN (@qpboi_IsAccounting = 1) THEN (CASE WHEN ((\"enapplicationrole\".\"isareacxp\" = 1) AND (NOT (\"enapplicationrole\".\"isareausuaria\" = 1))) THEN 1 ELSE 0 END) ELSE (CASE WHEN ((\"enapplicationrole\".\"isareausuaria\" = 1) AND (NOT (\"enapplicationrole\".\"isareacxp\" = 1))) THEN 1 ELSE 0 END) END) = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpboi_IsAccounting", DbType.Boolean, qpboi_IsAccounting);
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
outParamList.AlternateReadDbMethodAsync = datasetGetUserAppRolesReadDbAsync;
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query CheckApplicantApprovalIsNeeded.GetUserAppRoles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_137ca0bd922b82f91f39dd017e999a51 _tmp = new RL_137ca0bd922b82f91f39dd017e999a51();
_tmp.AlternateReadDbMethodAsync = datasetGetUserAppRolesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query CheckApplicantApprovalIsNeeded.GetUserAppRoles.List", cancellationToken: cancellationToken);
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

// Query Function "GetInvoiceById" neb66B2zCkmB6Ai4UDMf9Q of Action "CheckApplicantApprovalIsNeeded"
public static async Task<(RL_7b3475883ca90ad6eb7fc983e868c456,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("CheckApplicantApprovalIsNeeded.GetInvoiceById", "e8fae69d-b31d-490a-81e8-08b850331ff5");
using var queryActivity = activitySource.CreateAggregateQueryActivity("CheckApplicantApprovalIsNeeded.GetInvoiceById", "e8fae69d-b31d-490a-81e8-08b850331ff5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Dp2uBzRshE2wYOIob_wTMw/NodesNotShownInESpaceTree.neb66B2zCkmB6Ai4UDMf9Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice2\".\"id\" o0, \"eninvoice2\".\"name\" o1, \"eninvoice2\".\"requisitionid\" o2, \"eninvoice2\".\"folioid\" o3, \"eninvoice2\".\"ordermainid\" o4, \"eninvoice2\".\"cfditypeid\" o5, trim_scale(\"eninvoice2\".\"totalamount\"::numeric) o6, \"eninvoice2\".\"currency\" o7, \"eninvoice2\".\"invoicestatusid\" o8, \"eninvoice2\".\"accountingdatetime\" o9, \"eninvoice2\".\"paymentdatetime\" o10, \"eninvoice2\".\"createdon\" o11, \"eninvoice2\".\"createdby\" o12, \"eninvoice2\".\"updatedon\" o13, \"eninvoice2\".\"updatedby\" o14, \"eninvoice2\".\"submittedon\" o15, \"eninvoice2\".\"isnewversion\" o16, \"eninvoice2\".\"id_poliza\" o17, \"eninvoice2\".\"id_poliza_sap\" o18, \"eninvoice2\".\"doc51\" o19, \"eninvoice2\".\"accountingerror\" o20, \"eninvoice2\".\"orderaccconceptsid\" o21, trim_scale(\"eninvoice2\".\"amortization\"::numeric) o22, \"eninvoice2\".\"creditnoteinvoiceid\" o23");
fromBuilder.Append(" FROM {Invoice} \"eninvoice2\"");
whereBuilder.Append(" WHERE ");
if (qpinId != 0) {
whereBuilder.Append("((\"eninvoice2\".\"id\" = @qpinId) AND (\"eninvoice2\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinId", DbType.Int64, qpinId);
} else {
whereBuilder.Append("(\"eninvoice2\".\"id\" IS NULL)");
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
RL_7b3475883ca90ad6eb7fc983e868c456 outParamList = new RL_7b3475883ca90ad6eb7fc983e868c456();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query CheckApplicantApprovalIsNeeded.GetInvoiceById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query CheckApplicantApprovalIsNeeded.GetInvoiceById.List", cancellationToken: cancellationToken);
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
