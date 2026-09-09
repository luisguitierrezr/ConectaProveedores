namespace ssConectaProveedores;

public partial class Actions {
public class lcvReqRoleIsNeeded : VarsBag {
public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord inParami_Requisition;
public long inParami_ApprovalProcessId;
public long inParami_ApplicationRoleId;
public bool inParami_IsAccounting;
public bool inParami_IsMandatory;
public RL_5d3a02aa993c7474297e33d992f39ad0 queryResGetRegionById_outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
public long queryResGetRegionById_outParamCount = 0L;

public RL_8dbe9b3349c28479d314d27fe2f03197 queryResGetApprovalProcessById_outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
public long queryResGetApprovalProcessById_outParamCount = 0L;

public RL_25486e09ba20acde3d8ef9d3e8a6e625 queryResGetProofOfForeignResidence_outParamList = new RL_25486e09ba20acde3d8ef9d3e8a6e625();
public long queryResGetProofOfForeignResidence_outParamCount = 0L;

public RL_17106260236c729f86b4f7919e212d21 queryResGetLevelWithNeededRole_outParamList = new RL_17106260236c729f86b4f7919e212d21();
public long queryResGetLevelWithNeededRole_outParamCount = 0L;

public RL_d5c1b2482ff109e80580d8b5fb920193 queryResGetSupplierById_outParamList = new RL_d5c1b2482ff109e80580d8b5fb920193();
public long queryResGetSupplierById_outParamCount = 0L;

public lcvReqRoleIsNeeded(EN_98680591dcf3728e0877a90eb5e1e552EntityRecord inParami_Requisition, long inParami_ApprovalProcessId, long inParami_ApplicationRoleId, bool inParami_IsAccounting, bool inParami_IsMandatory) {
this.inParami_Requisition = inParami_Requisition;
this.inParami_ApprovalProcessId = inParami_ApprovalProcessId;
this.inParami_ApplicationRoleId = inParami_ApplicationRoleId;
this.inParami_IsAccounting = inParami_IsAccounting;
this.inParami_IsMandatory = inParami_IsMandatory;
}
}
public class lcoReqRoleIsNeeded : VarsBag {
public bool outParamo_IsNeeded = false;

public EN_1d28318723f39133c60733b3cce8955eEntityRecord outParamo_ApprovalProcessLevel = new EN_1d28318723f39133c60733b3cce8955eEntityRecord();

public lcoReqRoleIsNeeded() {
}
}
/// <summary>
/// Action <code>ReqRoleIsNeeded</code> that represents the Service Studio action
///  <code>ReqRoleIsNeeded</code> <p> Description: </p>
/// </summary>
public static async Task<(bool,EN_1d28318723f39133c60733b3cce8955eEntityRecord)> ActionReqRoleIsNeeded(IRequestContext requestContext,EN_98680591dcf3728e0877a90eb5e1e552EntityRecord inParami_Requisition,long inParami_ApprovalProcessId,long inParami_ApplicationRoleId,bool inParami_IsAccounting,bool inParami_IsMandatory,CancellationToken cancellationToken) {
bool outParamo_IsNeeded = default;
EN_1d28318723f39133c60733b3cce8955eEntityRecord outParamo_ApprovalProcessLevel = default;
lcoReqRoleIsNeeded result = new lcoReqRoleIsNeeded();
lcvReqRoleIsNeeded localVars = new lcvReqRoleIsNeeded(inParami_Requisition, inParami_ApprovalProcessId, inParami_ApplicationRoleId, inParami_IsAccounting, inParami_IsMandatory);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ReqRoleIsNeeded", "e3f93e50-c041-4955-a379-87346af5edf8"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ReqRoleIsNeeded", "e3f93e50-c041-4955-a379-87346af5edf8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetApprovalProcessById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessById_maxRecords = 1;
if (datasetGetApprovalProcessById_maxRecords < 1) datasetGetApprovalProcessById_maxRecords = 1;
int datasetGetApprovalProcessById_startIndex = 0;(localVars.queryResGetApprovalProcessById_outParamList,localVars.queryResGetApprovalProcessById_outParamCount) = await FuncActionReqRoleIsNeeded.datasetGetApprovalProcessById(requestContext,datasetGetApprovalProcessById_maxRecords,datasetGetApprovalProcessById_startIndex,IterationMultiplicity.Never,localVars.inParami_ApplicationRoleId,localVars.inParami_ApprovalProcessId,localVars.inParami_IsAccounting,localVars.inParami_IsMandatory,cancellationToken);

// Empty?
if((localVars.queryResGetApprovalProcessById_outParamList.Empty)) {
// ALIGN
} else {
// Query datasetGetRegionById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRegionById_maxRecords = 1;
if (datasetGetRegionById_maxRecords < 1) datasetGetRegionById_maxRecords = 1;
int datasetGetRegionById_startIndex = 0;(localVars.queryResGetRegionById_outParamList,localVars.queryResGetRegionById_outParamCount) = await FuncActionReqRoleIsNeeded.datasetGetRegionById(requestContext,datasetGetRegionById_maxRecords,datasetGetRegionById_startIndex,IterationMultiplicity.Never,localVars.inParami_Requisition.ssRegionId,cancellationToken);

if((localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssIsExclude)) {
// False
// o_IsNeeded = False
result.outParamo_IsNeeded=false;
goto RETURN_STATEMENT;

} else {
if(((localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssOnlyRegion!=""))) {
if((!((BuiltInFunction.IndexSC (localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssOnlyRegion, localVars.queryResGetRegionById_outParamList.CurrentRec.ssENRegion.ssCommissionRegion, 0, false, true)!=(-1))))) {
// False
// o_IsNeeded = False
result.outParamo_IsNeeded=false;
goto RETURN_STATEMENT;

}

}

if(((((((localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount!=(((decimal)0)))||(localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMaxAmount!=(((decimal)0))))||localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssWithoutContract)||localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssNeedsProofOfForeignResidence)||localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssNeedsContract))) {
bool block1 = false;
do {
block1 = false;
do {
if((((localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount!=(((decimal)0)))&&(localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMaxAmount!=(((decimal)0)))))) {
if((((localVars.inParami_Requisition.ssTotalAmount>localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount)&&(localVars.inParami_Requisition.ssTotalAmount<localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMaxAmount)))) {
break;
}

} else {
if(((localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount!=(((decimal)0)))&&(localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMaxAmount==(((decimal)0))))) {
if(((localVars.inParami_Requisition.ssTotalAmount>localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount))) {
break;
}

} else {
if(((localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount==(((decimal)0)))&&(localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMaxAmount!=(((decimal)0))))) {
if(((localVars.inParami_Requisition.ssTotalAmount<localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMaxAmount))) {
break;
}

} else {
// ALIGN
}

}

}

if(((localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssWithoutContract&&((!localVars.inParami_Requisition.ssHasContract)||(localVars.inParami_Requisition.ssHasContract&&localVars.inParami_Requisition.ssIsContractPending))))) {
// jump to block1
block1 = true;
break;
} else {
if(((localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssNeedsContract&&((!localVars.inParami_Requisition.ssHasContract)||(localVars.inParami_Requisition.ssHasContract&&localVars.inParami_Requisition.ssIsContractPending))))) {
// jump to block1
block1 = true;
break;
} else {
if((localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel.ssNeedsProofOfForeignResidence)) {
// Query datasetGetSupplierById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSupplierById_maxRecords = 1;
if (datasetGetSupplierById_maxRecords < 1) datasetGetSupplierById_maxRecords = 1;
int datasetGetSupplierById_startIndex = 0;(localVars.queryResGetSupplierById_outParamList,localVars.queryResGetSupplierById_outParamCount) = await FuncActionReqRoleIsNeeded.datasetGetSupplierById(requestContext,datasetGetSupplierById_maxRecords,datasetGetSupplierById_startIndex,IterationMultiplicity.Never,localVars.inParami_Requisition.ssSupplierId,cancellationToken);

if(((localVars.queryResGetSupplierById_outParamList.CurrentRec.ssENSupplier.ssPais!="MX"))) {
// Query datasetGetProofOfForeignResidence
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProofOfForeignResidence_maxRecords = 1;
if (datasetGetProofOfForeignResidence_maxRecords < 1) datasetGetProofOfForeignResidence_maxRecords = 1;
int datasetGetProofOfForeignResidence_startIndex = 0;(localVars.queryResGetProofOfForeignResidence_outParamList,localVars.queryResGetProofOfForeignResidence_outParamCount) = await FuncActionReqRoleIsNeeded.datasetGetProofOfForeignResidence(requestContext,datasetGetProofOfForeignResidence_maxRecords,datasetGetProofOfForeignResidence_startIndex,IterationMultiplicity.Never,localVars.inParami_Requisition.ssId,cancellationToken);

if((localVars.queryResGetProofOfForeignResidence_outParamList.Empty)) {
// jump to block1
block1 = true;
break;
}

}

}

// False
// o_IsNeeded = False
result.outParamo_IsNeeded=false;
goto RETURN_STATEMENT;

}

}

} while(false)
;
if(block1) {
break;
}

// ALIGN
// ALIGN
// ALIGN
} while(false)
;
// o_ApprovalProcessLevel = GetApprovalProcessById.List.Current.ApprovalProcessLevel
result.outParamo_ApprovalProcessLevel=localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel;
} else {
// o_ApprovalProcessLevel
// o_ApprovalProcessLevel = GetApprovalProcessById.List.Current.ApprovalProcessLevel
result.outParamo_ApprovalProcessLevel=localVars.queryResGetApprovalProcessById_outParamList.CurrentRec.ssENApprovalProcessLevel;
}

}

}

// Query datasetGetLevelWithNeededRole
cancellationToken.ThrowIfCancellationRequested();
int datasetGetLevelWithNeededRole_maxRecords = 1;
if (datasetGetLevelWithNeededRole_maxRecords < 1) datasetGetLevelWithNeededRole_maxRecords = 1;
int datasetGetLevelWithNeededRole_startIndex = 0;(localVars.queryResGetLevelWithNeededRole_outParamList,localVars.queryResGetLevelWithNeededRole_outParamCount) = await FuncActionReqRoleIsNeeded.datasetGetLevelWithNeededRole(requestContext,datasetGetLevelWithNeededRole_maxRecords,datasetGetLevelWithNeededRole_startIndex,IterationMultiplicity.Never,localVars.inParami_ApplicationRoleId,localVars.inParami_IsAccounting,localVars.inParami_IsMandatory,localVars.inParami_Requisition.ssId,cancellationToken);

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

public static class FuncActionReqRoleIsNeeded {

// Query Function "GetRegionById" b+NDdbxzqEKNshohv0I_xw of Action "ReqRoleIsNeeded"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ReqRoleIsNeeded.GetRegionById", "7543e36f-73bc-42a8-8db2-1a21bf423fc7");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ReqRoleIsNeeded.GetRegionById", "7543e36f-73bc-42a8-8db2-1a21bf423fc7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.UD7540HAVUmjeYc0avXt+A/NodesNotShownInESpaceTree.b+NDdbxzqEKNshohv0I_xw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, \"enregion55\".\"commissionregion\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion55\"");
whereBuilder.Append(" WHERE ");
if (qpreId != 0) {
whereBuilder.Append("((\"enregion55\".\"id\" = @qpreId) AND (\"enregion55\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreId", DbType.Int64, qpreId);
} else {
whereBuilder.Append("(\"enregion55\".\"id\" IS NULL)");
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
RL_5d3a02aa993c7474297e33d992f39ad0 outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ReqRoleIsNeeded.GetRegionById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5d3a02aa993c7474297e33d992f39ad0 _tmp = new RL_5d3a02aa993c7474297e33d992f39ad0();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ReqRoleIsNeeded.GetRegionById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5d3a02aa993c7474297e33d992f39ad0)_tmp;
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

private static async Task<RC_1c307c6ba13b1609f542644719b6e56b> datasetGetApprovalProcessByIdReadDbAsync(RC_1c307c6ba13b1609f542644719b6e56b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessLevel.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcessById" 3KyilQITQ0yyeXOcGKjHQg of Action "ReqRoleIsNeeded"
public static async Task<(RL_8dbe9b3349c28479d314d27fe2f03197,long)> datasetGetApprovalProcessById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpapApprovalProcessLevel_ApplicationRoleId,long qpapApprovalProcess_Id,bool qpboApprovalProcessLevel_IsAccounting_DEPREC,bool qpboApprovalProcessLevel_IsMandatory,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ReqRoleIsNeeded.GetApprovalProcessById", "95a2acdc-1302-4c43-b279-739c18a8c742");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ReqRoleIsNeeded.GetApprovalProcessById", "95a2acdc-1302-4c43-b279-739c18a8c742", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.UD7540HAVUmjeYc0avXt+A/NodesNotShownInESpaceTree.3KyilQITQ0yyeXOcGKjHQg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, \"enapprovalprocesslevel14\".\"id\" o19, \"enapprovalprocesslevel14\".\"approvalprocessid\" o20, \"enapprovalprocesslevel14\".\"levelnumber\" o21, \"enapprovalprocesslevel14\".\"applicationroleid\" o22, \"enapprovalprocesslevel14\".\"isapplicant\" o23, \"enapprovalprocesslevel14\".\"isfirstapprover\" o24, \"enapprovalprocesslevel14\".\"jobtitle\" o25, \"enapprovalprocesslevel14\".\"entraroleid\" o26, \"enapprovalprocesslevel14\".\"departmentid\" o27, \"enapprovalprocesslevel14\".\"managementid\" o28, \"enapprovalprocesslevel14\".\"subdirectionid\" o29, trim_scale(\"enapprovalprocesslevel14\".\"minamount\"::numeric) o30, trim_scale(\"enapprovalprocesslevel14\".\"maxamount\"::numeric) o31, \"enapprovalprocesslevel14\".\"isactive\" o32, \"enapprovalprocesslevel14\".\"excluderegion_deprec\" o33, \"enapprovalprocesslevel14\".\"onlyregion\" o34, \"enapprovalprocesslevel14\".\"withoutcontract\" o35, \"enapprovalprocesslevel14\".\"needsproofofforeignresidence\" o36, \"enapprovalprocesslevel14\".\"needscontract\" o37, \"enapprovalprocesslevel14\".\"isaccounting_deprec\" o38, \"enapprovalprocesslevel14\".\"isstartaccounting\" o39, \"enapprovalprocesslevel14\".\"canbefirstapprover\" o40, \"enapprovalprocesslevel14\".\"selectsnextapprover\" o41, \"enapprovalprocesslevel14\".\"selectsfirstapprover\" o42, \"enapprovalprocesslevel14\".\"isexclude\" o43, \"enapprovalprocesslevel14\".\"ismandatory\" o44");
fromBuilder.Append(" FROM ({ApprovalProcess} \"enapprovalprocess32\" Left JOIN {ApprovalProcessLevel} \"enapprovalprocesslevel14\" ON (\"enapprovalprocess32\".\"id\" = \"enapprovalprocesslevel14\".\"approvalprocessid\")) ");
whereBuilder.Append(" WHERE ");
if (qpapApprovalProcess_Id != 0) {
whereBuilder.Append("((\"enapprovalprocess32\".\"id\" = @qpapApprovalProcess_Id) AND (\"enapprovalprocess32\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApprovalProcess_Id", DbType.Int64, qpapApprovalProcess_Id);
} else {
whereBuilder.Append("(\"enapprovalprocess32\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpapApprovalProcessLevel_ApplicationRoleId != 0) {
whereBuilder.Append("((\"enapprovalprocesslevel14\".\"applicationroleid\" = @qpapApprovalProcessLevel_ApplicationRoleId) AND (\"enapprovalprocesslevel14\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApprovalProcessLevel_ApplicationRoleId", DbType.Int64, qpapApprovalProcessLevel_ApplicationRoleId);
} else {
whereBuilder.Append("(\"enapprovalprocesslevel14\".\"applicationroleid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocesslevel14\".\"isaccounting_deprec\" = @qpboApprovalProcessLevel_IsAccounting_DEPREC) AND (\"enapprovalprocesslevel14\".\"ismandatory\" = @qpboApprovalProcessLevel_IsMandatory)");
orderByBuilder.Append(" ORDER BY \"enapprovalprocesslevel14\".\"levelnumber\" ASC ");
sqlCmd.CreateParameterWithoutReplacements("@qpboApprovalProcessLevel_IsAccounting_DEPREC", DbType.Boolean, qpboApprovalProcessLevel_IsAccounting_DEPREC);
sqlCmd.CreateParameterWithoutReplacements("@qpboApprovalProcessLevel_IsMandatory", DbType.Boolean, qpboApprovalProcessLevel_IsMandatory);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ReqRoleIsNeeded.GetApprovalProcessById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ReqRoleIsNeeded.GetApprovalProcessById.List", cancellationToken: cancellationToken);
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

// Query Function "GetProofOfForeignResidence" fQm3rw1T1UmxrDCt405BEA of Action "ReqRoleIsNeeded"
public static async Task<(RL_25486e09ba20acde3d8ef9d3e8a6e625,long)> datasetGetProofOfForeignResidence(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ReqRoleIsNeeded.GetProofOfForeignResidence", "afb7097d-530d-49d5-b1ac-30ade34e4110");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ReqRoleIsNeeded.GetProofOfForeignResidence", "afb7097d-530d-49d5-b1ac-30ade34e4110", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.UD7540HAVUmjeYc0avXt+A/NodesNotShownInESpaceTree.fQm3rw1T1UmxrDCt405BEA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8");
fromBuilder.Append(" FROM {RequisitionContractFile} \"enrequisitioncontractfile10\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionId != 0) {
whereBuilder.Append("((\"enrequisitioncontractfile10\".\"requisitionid\" = @qpreRequisitionId) AND (\"enrequisitioncontractfile10\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionId", DbType.Int64, qpreRequisitionId);
} else {
whereBuilder.Append("(\"enrequisitioncontractfile10\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitioncontractfile10\".\"contractfiletypeid\" = ");
whereBuilder.Append((ENContractFileTypeEntity.GetRecordByKey(ObjectKey.Parse("DmZNPQ718EWxmSQhfgzeiw"))).ssId);
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
RL_25486e09ba20acde3d8ef9d3e8a6e625 outParamList = new RL_25486e09ba20acde3d8ef9d3e8a6e625();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ReqRoleIsNeeded.GetProofOfForeignResidence.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_25486e09ba20acde3d8ef9d3e8a6e625 _tmp = new RL_25486e09ba20acde3d8ef9d3e8a6e625();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ReqRoleIsNeeded.GetProofOfForeignResidence.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_25486e09ba20acde3d8ef9d3e8a6e625)_tmp;
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

private static async Task<RC_7a202946b9c9ade4fc5b7dc7c07f3279> datasetGetLevelWithNeededRoleReadDbAsync(RC_7a202946b9c9ade4fc5b7dc7c07f3279 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetLevelWithNeededRole" HeqExbwVL0OpPdZpbQdE7Q of Action "ReqRoleIsNeeded"
public static async Task<(RL_17106260236c729f86b4f7919e212d21,long)> datasetGetLevelWithNeededRole(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpapRequisitionApprovalLevel_ApplicationRoleId,bool qpboRequisitionApprovalLevel_IsAccounting,bool qpboRequisitionApprovalLevel_IsMandatory,long qpreRequisitionApproval_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ReqRoleIsNeeded.GetLevelWithNeededRole", "c584ea1d-15bc-432f-a93d-d6696d0744ed");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ReqRoleIsNeeded.GetLevelWithNeededRole", "c584ea1d-15bc-432f-a93d-d6696d0744ed", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.UD7540HAVUmjeYc0avXt+A/NodesNotShownInESpaceTree.HeqExbwVL0OpPdZpbQdE7Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35");
fromBuilder.Append(" FROM ({RequisitionApproval} \"enrequisitionapproval21\" Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel19\" ON (\"enrequisitionapproval21\".\"id\" = \"enrequisitionapprovallevel19\".\"requisitionapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionApproval_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionapproval21\".\"requisitionid\" = @qpreRequisitionApproval_RequisitionId) AND (\"enrequisitionapproval21\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionApproval_RequisitionId", DbType.Int64, qpreRequisitionApproval_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionapproval21\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpapRequisitionApprovalLevel_ApplicationRoleId != 0) {
whereBuilder.Append("((\"enrequisitionapprovallevel19\".\"applicationroleid\" = @qpapRequisitionApprovalLevel_ApplicationRoleId) AND (\"enrequisitionapprovallevel19\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapRequisitionApprovalLevel_ApplicationRoleId", DbType.Int64, qpapRequisitionApprovalLevel_ApplicationRoleId);
} else {
whereBuilder.Append("(\"enrequisitionapprovallevel19\".\"applicationroleid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitionapprovallevel19\".\"ismandatory\" = @qpboRequisitionApprovalLevel_IsMandatory) AND (\"enrequisitionapprovallevel19\".\"isaccounting\" = @qpboRequisitionApprovalLevel_IsAccounting)");
sqlCmd.CreateParameterWithoutReplacements("@qpboRequisitionApprovalLevel_IsMandatory", DbType.Boolean, qpboRequisitionApprovalLevel_IsMandatory);
sqlCmd.CreateParameterWithoutReplacements("@qpboRequisitionApprovalLevel_IsAccounting", DbType.Boolean, qpboRequisitionApprovalLevel_IsAccounting);
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
RL_17106260236c729f86b4f7919e212d21 outParamList = new RL_17106260236c729f86b4f7919e212d21();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetLevelWithNeededRoleReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ReqRoleIsNeeded.GetLevelWithNeededRole.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_17106260236c729f86b4f7919e212d21 _tmp = new RL_17106260236c729f86b4f7919e212d21();
_tmp.AlternateReadDbMethodAsync = datasetGetLevelWithNeededRoleReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ReqRoleIsNeeded.GetLevelWithNeededRole.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_17106260236c729f86b4f7919e212d21)_tmp;
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

// Query Function "GetSupplierById" +F8x9kUqkEa1U22maegbgw of Action "ReqRoleIsNeeded"
public static async Task<(RL_d5c1b2482ff109e80580d8b5fb920193,long)> datasetGetSupplierById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ReqRoleIsNeeded.GetSupplierById", "f6315ff8-2a45-4690-b553-6da669e81b83");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ReqRoleIsNeeded.GetSupplierById", "f6315ff8-2a45-4690-b553-6da669e81b83", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.UD7540HAVUmjeYc0avXt+A/NodesNotShownInESpaceTree.+F8x9kUqkEa1U22maegbgw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"ensupplier47\".\"pais\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM {Supplier} \"ensupplier47\"");
whereBuilder.Append(" WHERE ");
if (qpsuId != 0) {
whereBuilder.Append("((\"ensupplier47\".\"id\" = @qpsuId) AND (\"ensupplier47\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuId", DbType.Int64, qpsuId);
} else {
whereBuilder.Append("(\"ensupplier47\".\"id\" IS NULL)");
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
RL_d5c1b2482ff109e80580d8b5fb920193 outParamList = new RL_d5c1b2482ff109e80580d8b5fb920193();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ReqRoleIsNeeded.GetSupplierById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d5c1b2482ff109e80580d8b5fb920193 _tmp = new RL_d5c1b2482ff109e80580d8b5fb920193();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ReqRoleIsNeeded.GetSupplierById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d5c1b2482ff109e80580d8b5fb920193)_tmp;
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
