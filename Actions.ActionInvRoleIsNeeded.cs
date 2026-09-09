namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvRoleIsNeeded : VarsBag {
public EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParami_Invoice;
public long inParami_ApprovalProcessId;
public long inParami_ApplicationRoleId;
public bool inParami_IsAccounting;
public RL_8dbe9b3349c28479d314d27fe2f03197 queryResGetApprovalProcessById_outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
public long queryResGetApprovalProcessById_outParamCount = 0L;

public RL_6dc54c806e79e3021c958eb2cb6d90be queryResGetLevelWithNeededRole_outParamList = new RL_6dc54c806e79e3021c958eb2cb6d90be();
public long queryResGetLevelWithNeededRole_outParamCount = 0L;

public RL_c851528f2bd72df8d6fa01fc1d7dda59 queryResGetRequisitionById_outParamList = new RL_c851528f2bd72df8d6fa01fc1d7dda59();
public long queryResGetRequisitionById_outParamCount = 0L;

public lcvInvRoleIsNeeded(EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParami_Invoice, long inParami_ApprovalProcessId, long inParami_ApplicationRoleId, bool inParami_IsAccounting) {
this.inParami_Invoice = inParami_Invoice;
this.inParami_ApprovalProcessId = inParami_ApprovalProcessId;
this.inParami_ApplicationRoleId = inParami_ApplicationRoleId;
this.inParami_IsAccounting = inParami_IsAccounting;
}
}
public class lcoInvRoleIsNeeded : VarsBag {
public bool outParamo_IsNeeded = false;

public EN_1d28318723f39133c60733b3cce8955eEntityRecord outParamo_ApprovalProcessLevel = new EN_1d28318723f39133c60733b3cce8955eEntityRecord();

public lcoInvRoleIsNeeded() {
}
}
/// <summary>
/// Action <code>InvRoleIsNeeded</code> that represents the Service Studio action
///  <code>InvRoleIsNeeded</code> <p> Description: </p>
/// </summary>
public static async Task<(bool,EN_1d28318723f39133c60733b3cce8955eEntityRecord)> ActionInvRoleIsNeeded(IRequestContext requestContext,EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParami_Invoice,long inParami_ApprovalProcessId,long inParami_ApplicationRoleId,bool inParami_IsAccounting,CancellationToken cancellationToken) {
bool outParamo_IsNeeded = default;
EN_1d28318723f39133c60733b3cce8955eEntityRecord outParamo_ApprovalProcessLevel = default;
lcoInvRoleIsNeeded result = new lcoInvRoleIsNeeded();
lcvInvRoleIsNeeded localVars = new lcvInvRoleIsNeeded(inParami_Invoice, inParami_ApprovalProcessId, inParami_ApplicationRoleId, inParami_IsAccounting);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvRoleIsNeeded", "63d6b365-f084-4022-bcaf-5da3bd2ca46b"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvRoleIsNeeded", "63d6b365-f084-4022-bcaf-5da3bd2ca46b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetApprovalProcessById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessById_maxRecords = 1;
if (datasetGetApprovalProcessById_maxRecords < 1) datasetGetApprovalProcessById_maxRecords = 1;
int datasetGetApprovalProcessById_startIndex = 0;(localVars.queryResGetApprovalProcessById_outParamList,localVars.queryResGetApprovalProcessById_outParamCount) = await FuncActionInvRoleIsNeeded.datasetGetApprovalProcessById(requestContext,datasetGetApprovalProcessById_maxRecords,datasetGetApprovalProcessById_startIndex,IterationMultiplicity.Never,localVars.inParami_ApplicationRoleId,localVars.inParami_ApprovalProcessId,localVars.inParami_IsAccounting,cancellationToken);

// Empty?
if((localVars.queryResGetApprovalProcessById_outParamList.Empty)) {
// ALIGN
// ALIGN
} else {
// Query datasetGetRequisitionById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionById_maxRecords = 1;
if (datasetGetRequisitionById_maxRecords < 1) datasetGetRequisitionById_maxRecords = 1;
int datasetGetRequisitionById_startIndex = 0;(localVars.queryResGetRequisitionById_outParamList,localVars.queryResGetRequisitionById_outParamCount) = await FuncActionInvRoleIsNeeded.datasetGetRequisitionById(requestContext,datasetGetRequisitionById_maxRecords,datasetGetRequisitionById_startIndex,IterationMultiplicity.Never,localVars.inParami_Invoice.ssId,cancellationToken);

if((localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssIsExclude)) {
// False
// o_IsNeeded = False
result.outParamo_IsNeeded=false;
goto RETURN_STATEMENT;

} else {
if(((localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssOnlyRegion!=""))) {
if((!((BuiltInFunction.IndexSC (localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssOnlyRegion, localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRegion.ssCommissionRegion, 0, false, true)!=(-1))))) {
// False
// o_IsNeeded = False
result.outParamo_IsNeeded=false;
goto RETURN_STATEMENT;

}

}

if(((((((localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount!=(((decimal)0)))||(localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMaxAmount!=(((decimal)0))))||localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssWithoutContract)||localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssNeedsProofOfForeignResidence)||localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssNeedsContract))) {
do {
if((((localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount!=(((decimal)0)))&&(localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMaxAmount!=(((decimal)0)))))) {
if((((localVars.inParami_Invoice.ssTotalAmount>localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount)&&(localVars.inParami_Invoice.ssTotalAmount<localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMaxAmount)))) {
break;
}

} else {
if(((localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount!=(((decimal)0)))&&(localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMaxAmount==(((decimal)0))))) {
if(((localVars.inParami_Invoice.ssTotalAmount>localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount))) {
break;
}

} else {
if(((localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount==(((decimal)0)))&&(localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMaxAmount!=(((decimal)0))))) {
if(((localVars.inParami_Invoice.ssTotalAmount<localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMaxAmount))) {
break;
}

} else {
// ALIGN
}

}

}

// False
// o_IsNeeded = False
result.outParamo_IsNeeded=false;
goto RETURN_STATEMENT;

} while(false)
;
// o_ApprovalProcessLevel = GetApprovalProcessById.List.Current.ApprovalProcessLevel
result.outParamo_ApprovalProcessLevel=localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel;
} else {
// o_ApprovalProcessLevel = GetApprovalProcessById.List.Current.ApprovalProcessLevel
result.outParamo_ApprovalProcessLevel=localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel;
}

}

}

// Query datasetGetLevelWithNeededRole
cancellationToken.ThrowIfCancellationRequested();
int datasetGetLevelWithNeededRole_maxRecords = 1;
if (datasetGetLevelWithNeededRole_maxRecords < 1) datasetGetLevelWithNeededRole_maxRecords = 1;
int datasetGetLevelWithNeededRole_startIndex = 0;(localVars.queryResGetLevelWithNeededRole_outParamList,localVars.queryResGetLevelWithNeededRole_outParamCount) = await FuncActionInvRoleIsNeeded.datasetGetLevelWithNeededRole(requestContext,datasetGetLevelWithNeededRole_maxRecords,datasetGetLevelWithNeededRole_startIndex,IterationMultiplicity.Never,localVars.inParami_ApplicationRoleId,localVars.inParami_Invoice.ssId,localVars.inParami_IsAccounting,cancellationToken);

// Empty?
if((localVars.queryResGetLevelWithNeededRole_outParamList.Empty)) {
// True
// o_IsNeeded = True
result.outParamo_IsNeeded=true;
} else {
// False
// o_IsNeeded = False
result.outParamo_IsNeeded=false;
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_IsNeeded = result.outParamo_IsNeeded;
outParamo_ApprovalProcessLevel = result.outParamo_ApprovalProcessLevel;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_IsNeeded,outParamo_ApprovalProcessLevel);
}

public static class FuncActionInvRoleIsNeeded {

private static async Task<RC_1c307c6ba13b1609f542644719b6e56b> datasetGetApprovalProcessByIdReadDbAsync(RC_1c307c6ba13b1609f542644719b6e56b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessLevel.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcessById" FpeDS8AwW0e1hj01Sgdqqw of Action "InvRoleIsNeeded"
public static async Task<(RL_8dbe9b3349c28479d314d27fe2f03197,long)> datasetGetApprovalProcessById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpapApprovalProcessLevel_ApplicationRoleId,long qpapApprovalProcess_Id,bool qpboApprovalProcessLevel_IsAccounting_DEPREC,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvRoleIsNeeded.GetApprovalProcessById", "4b839716-30c0-475b-b586-3d354a076aab");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvRoleIsNeeded.GetApprovalProcessById", "4b839716-30c0-475b-b586-3d354a076aab", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.ZbPWY4TwIkC8r12jvSykaw/NodesNotShownInESpaceTree.FpeDS8AwW0e1hj01Sgdqqw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, \"enapprovalprocesslevel1\".\"id\" o19, \"enapprovalprocesslevel1\".\"approvalprocessid\" o20, \"enapprovalprocesslevel1\".\"levelnumber\" o21, \"enapprovalprocesslevel1\".\"applicationroleid\" o22, \"enapprovalprocesslevel1\".\"isapplicant\" o23, \"enapprovalprocesslevel1\".\"isfirstapprover\" o24, \"enapprovalprocesslevel1\".\"jobtitle\" o25, \"enapprovalprocesslevel1\".\"entraroleid\" o26, \"enapprovalprocesslevel1\".\"departmentid\" o27, \"enapprovalprocesslevel1\".\"managementid\" o28, \"enapprovalprocesslevel1\".\"subdirectionid\" o29, trim_scale(\"enapprovalprocesslevel1\".\"minamount\"::numeric) o30, trim_scale(\"enapprovalprocesslevel1\".\"maxamount\"::numeric) o31, \"enapprovalprocesslevel1\".\"isactive\" o32, \"enapprovalprocesslevel1\".\"excluderegion_deprec\" o33, \"enapprovalprocesslevel1\".\"onlyregion\" o34, \"enapprovalprocesslevel1\".\"withoutcontract\" o35, \"enapprovalprocesslevel1\".\"needsproofofforeignresidence\" o36, \"enapprovalprocesslevel1\".\"needscontract\" o37, \"enapprovalprocesslevel1\".\"isaccounting_deprec\" o38, \"enapprovalprocesslevel1\".\"isstartaccounting\" o39, \"enapprovalprocesslevel1\".\"canbefirstapprover\" o40, \"enapprovalprocesslevel1\".\"selectsnextapprover\" o41, \"enapprovalprocesslevel1\".\"selectsfirstapprover\" o42, \"enapprovalprocesslevel1\".\"isexclude\" o43, \"enapprovalprocesslevel1\".\"ismandatory\" o44");
fromBuilder.Append(" FROM ({ApprovalProcess} \"enapprovalprocess6\" Left JOIN {ApprovalProcessLevel} \"enapprovalprocesslevel1\" ON (\"enapprovalprocess6\".\"id\" = \"enapprovalprocesslevel1\".\"approvalprocessid\")) ");
whereBuilder.Append(" WHERE ");
if (qpapApprovalProcess_Id != 0) {
whereBuilder.Append("((\"enapprovalprocess6\".\"id\" = @qpapApprovalProcess_Id) AND (\"enapprovalprocess6\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApprovalProcess_Id", DbType.Int64, qpapApprovalProcess_Id);
} else {
whereBuilder.Append("(\"enapprovalprocess6\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpapApprovalProcessLevel_ApplicationRoleId != 0) {
whereBuilder.Append("((\"enapprovalprocesslevel1\".\"applicationroleid\" = @qpapApprovalProcessLevel_ApplicationRoleId) AND (\"enapprovalprocesslevel1\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApprovalProcessLevel_ApplicationRoleId", DbType.Int64, qpapApprovalProcessLevel_ApplicationRoleId);
} else {
whereBuilder.Append("(\"enapprovalprocesslevel1\".\"applicationroleid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocesslevel1\".\"isaccounting_deprec\" = @qpboApprovalProcessLevel_IsAccounting_DEPREC)");
orderByBuilder.Append(" ORDER BY \"enapprovalprocesslevel1\".\"levelnumber\" ASC ");
sqlCmd.CreateParameterWithoutReplacements("@qpboApprovalProcessLevel_IsAccounting_DEPREC", DbType.Boolean, qpboApprovalProcessLevel_IsAccounting_DEPREC);
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
RL_8dbe9b3349c28479d314d27fe2f03197 outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvRoleIsNeeded.GetApprovalProcessById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8dbe9b3349c28479d314d27fe2f03197 _tmp = new RL_8dbe9b3349c28479d314d27fe2f03197();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvRoleIsNeeded.GetApprovalProcessById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8dbe9b3349c28479d314d27fe2f03197)_tmp;
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

private static async Task<RC_bdad25a559cd2f146ec69d1aec036546> datasetGetLevelWithNeededRoleReadDbAsync(RC_bdad25a559cd2f146ec69d1aec036546 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetLevelWithNeededRole" 8Cd1iT_EPEmjoxHyLZLIcQ of Action "InvRoleIsNeeded"
public static async Task<(RL_6dc54c806e79e3021c958eb2cb6d90be,long)> datasetGetLevelWithNeededRole(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpapInvoiceApprovalLevel_ApplicationRoleId,long qpinInvoiceApproval_InvoiceId,bool qpboInvoiceApprovalLevel_IsAccounting,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvRoleIsNeeded.GetLevelWithNeededRole", "897527f0-c43f-493c-a3a3-11f22d92c871");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvRoleIsNeeded.GetLevelWithNeededRole", "897527f0-c43f-493c-a3a3-11f22d92c871", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.ZbPWY4TwIkC8r12jvSykaw/NodesNotShownInESpaceTree.8Cd1iT_EPEmjoxHyLZLIcQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34");
fromBuilder.Append(" FROM ({InvoiceApproval} \"eninvoiceapproval9\" Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel10\" ON (\"eninvoiceapproval9\".\"id\" = \"eninvoiceapprovallevel10\".\"invoiceapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceApproval_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceapproval9\".\"invoiceid\" = @qpinInvoiceApproval_InvoiceId) AND (\"eninvoiceapproval9\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceApproval_InvoiceId", DbType.Int64, qpinInvoiceApproval_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceapproval9\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpapInvoiceApprovalLevel_ApplicationRoleId != 0) {
whereBuilder.Append("((\"eninvoiceapprovallevel10\".\"applicationroleid\" = @qpapInvoiceApprovalLevel_ApplicationRoleId) AND (\"eninvoiceapprovallevel10\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapInvoiceApprovalLevel_ApplicationRoleId", DbType.Int64, qpapInvoiceApprovalLevel_ApplicationRoleId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel10\".\"applicationroleid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceapprovallevel10\".\"isaccounting\" = @qpboInvoiceApprovalLevel_IsAccounting)");
sqlCmd.CreateParameterWithoutReplacements("@qpboInvoiceApprovalLevel_IsAccounting", DbType.Boolean, qpboInvoiceApprovalLevel_IsAccounting);
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
RL_6dc54c806e79e3021c958eb2cb6d90be outParamList = new RL_6dc54c806e79e3021c958eb2cb6d90be();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetLevelWithNeededRoleReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvRoleIsNeeded.GetLevelWithNeededRole.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_6dc54c806e79e3021c958eb2cb6d90be _tmp = new RL_6dc54c806e79e3021c958eb2cb6d90be();
_tmp.AlternateReadDbMethodAsync = datasetGetLevelWithNeededRoleReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvRoleIsNeeded.GetLevelWithNeededRole.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_6dc54c806e79e3021c958eb2cb6d90be)_tmp;
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

private static async Task<RC_3336d2630e2646e00d0c2f5c3e5a01ea> datasetGetRequisitionByIdReadDbAsync(RC_3336d2630e2646e00d0c2f5c3e5a01ea rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionById" jcQ93CmG0UibmGlNIjVWrA of Action "InvRoleIsNeeded"
public static async Task<(RL_c851528f2bd72df8d6fa01fc1d7dda59,long)> datasetGetRequisitionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvRoleIsNeeded.GetRequisitionById", "dc3dc48d-8629-48d1-9b98-694d223556ac");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvRoleIsNeeded.GetRequisitionById", "dc3dc48d-8629-48d1-9b98-694d223556ac", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.ZbPWY4TwIkC8r12jvSykaw/NodesNotShownInESpaceTree.jcQ93CmG0UibmGlNIjVWrA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, \"enregion23\".\"commissionregion\" o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94");
fromBuilder.Append(" FROM (({Invoice} \"eninvoice24\" Left JOIN {Requisition} \"enrequisition28\" ON (\"enrequisition28\".\"id\" = \"eninvoice24\".\"requisitionid\"))  Left JOIN {Region} \"enregion23\" ON (\"enrequisition28\".\"regionid\" = \"enregion23\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice24\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice24\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice24\".\"id\" IS NULL)");
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
RL_c851528f2bd72df8d6fa01fc1d7dda59 outParamList = new RL_c851528f2bd72df8d6fa01fc1d7dda59();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvRoleIsNeeded.GetRequisitionById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c851528f2bd72df8d6fa01fc1d7dda59 _tmp = new RL_c851528f2bd72df8d6fa01fc1d7dda59();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvRoleIsNeeded.GetRequisitionById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c851528f2bd72df8d6fa01fc1d7dda59)_tmp;
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
