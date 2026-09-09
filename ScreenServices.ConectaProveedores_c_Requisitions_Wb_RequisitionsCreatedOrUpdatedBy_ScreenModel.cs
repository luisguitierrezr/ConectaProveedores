using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_c_Requisitions_Wb_RequisitionsCreatedOrUpdatedBy_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_c_Requisitions_Wb_RequisitionsCreatedOrUpdatedBy_ScreenModel).Namespace);

    public long inParamRequisitionId;
public ConectaProveedores_c_Requisitions_Wb_RequisitionsCreatedOrUpdatedBy_DataActionGetsRequisitionsData_Model varLcGetsRequisitionsData;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_c_Requisitions_Wb_RequisitionsCreatedOrUpdatedBy_ScreenModel() {
}



    public ConectaProveedores_c_Requisitions_Wb_RequisitionsCreatedOrUpdatedBy_ScreenModel(long inParamRequisitionId, ConectaProveedores_c_Requisitions_Wb_RequisitionsCreatedOrUpdatedBy_DataActionGetsRequisitionsData_Model varLcGetsRequisitionsData, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"RequisitionId", "GetsRequisitionsData", "ClientVars"}, new string[] {"inParamRequisitionId", "varLcGetsRequisitionsData", "clientVariables"});
this.inParamRequisitionId = inParamRequisitionId;
this.varLcGetsRequisitionsData = varLcGetsRequisitionsData;
this.clientVariables = clientVariables;
}



    

    public class lcvGetsRequisitionsData : VarsBag {
public RL_04a672cdadcf245af3641b3d2cc441e5 queryResGetRequisitionByIdCreatedBy_outParamList = new RL_04a672cdadcf245af3641b3d2cc441e5();
public long queryResGetRequisitionByIdCreatedBy_outParamCount = 0L;

public lcvGetsRequisitionsData() {
}
}
public class lcoGetsRequisitionsData : VarsBag {
public ST_26711e61541f079fb4510d8f9bfa1e3dStructure outParamo_RequisitionCreatedLog = new ST_26711e61541f079fb4510d8f9bfa1e3dStructure();

public lcoGetsRequisitionsData() {
}
}
/// <summary>
/// Action <code>GetsRequisitionsData</code> that represents the Service Studio action
///  <code>GetsRequisitionsData</code> <p> Description: </p>
/// </summary>
public async Task<ST_26711e61541f079fb4510d8f9bfa1e3dStructure> DataActionGetsRequisitionsData(IRequestContext requestContext,CancellationToken cancellationToken) {
ST_26711e61541f079fb4510d8f9bfa1e3dStructure outParamo_RequisitionCreatedLog = default;
lcoGetsRequisitionsData result = new lcoGetsRequisitionsData();
lcvGetsRequisitionsData localVars = new lcvGetsRequisitionsData();
ConectaProveedores_c_Requisitions_Wb_RequisitionsCreatedOrUpdatedBy_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetsRequisitionsData", "b40c5d45-b565-456d-9763-cd92b70d7566"))
using (activitySource.CreateScreenDataActionActivity("Wb_RequisitionsCreatedOrUpdatedBy", "GetsRequisitionsData")){
// Query datasetGetRequisitionByIdCreatedBy
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionByIdCreatedBy_maxRecords = 50;
if (datasetGetRequisitionByIdCreatedBy_maxRecords < 1) datasetGetRequisitionByIdCreatedBy_maxRecords = 1;
int datasetGetRequisitionByIdCreatedBy_startIndex = 0;(localVars.queryResGetRequisitionByIdCreatedBy_outParamList,localVars.queryResGetRequisitionByIdCreatedBy_outParamCount) = await FuncDataActionGetsRequisitionsData.datasetGetRequisitionByIdCreatedBy(requestContext,datasetGetRequisitionByIdCreatedBy_maxRecords,datasetGetRequisitionByIdCreatedBy_startIndex,IterationMultiplicity.Never,inParamRequisitionId,cancellationToken);

// o_RequisitionCreatedLog.CreatedBy = GetRequisitionByIdCreatedBy.List.Current.User_Created.Name
result.outParamo_RequisitionCreatedLog.ssCreatedBy = localVars.queryResGetRequisitionByIdCreatedBy_outParamList.CurrentRec.ssENUser_Created.ssName;

// o_RequisitionCreatedLog.CreatedOn = GetRequisitionByIdCreatedBy.List.Current.Requisition.CreatedOn
result.outParamo_RequisitionCreatedLog.ssCreatedOn = localVars.queryResGetRequisitionByIdCreatedBy_outParamList.CurrentRec.ssENRequisition.ssCreatedOn;

// o_RequisitionCreatedLog.UpdatedBy = GetRequisitionByIdCreatedBy.List.Current.User_Updated.Name
result.outParamo_RequisitionCreatedLog.ssUpdatedBy = localVars.queryResGetRequisitionByIdCreatedBy_outParamList.CurrentRec.ssENUser_Updated.ssName;

// o_RequisitionCreatedLog.UpdatedOn = GetRequisitionByIdCreatedBy.List.Current.Requisition.UpdatedOn
result.outParamo_RequisitionCreatedLog.ssUpdatedOn = localVars.queryResGetRequisitionByIdCreatedBy_outParamList.CurrentRec.ssENRequisition.ssUpdatedOn;
} //close CreateActionActivity using block
} // try

finally {
outParamo_RequisitionCreatedLog = result.outParamo_RequisitionCreatedLog;
} // inner-finally
RETURN_STATEMENT:
return outParamo_RequisitionCreatedLog;
}


    public static class FuncDataActionGetsRequisitionsData {

private static async Task<RC_b993edfaac62fcf2f3babee6c7847316> datasetGetRequisitionByIdCreatedByReadDbAsync(RC_b993edfaac62fcf2f3babee6c7847316 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read( r, ref index);
rec.ssENUser_Created.Read( r, ref index);
rec.ssENUser_Updated.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionByIdCreatedBy" YOehpDg5RkegbFwE4U1kzQ of Action "GetsRequisitionsData"
public static async Task<(RL_04a672cdadcf245af3641b3d2cc441e5,long)> datasetGetRequisitionByIdCreatedBy(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.Wb_RequisitionsCreatedOrUpdatedBy.GetsRequisitionsData.GetRequisitionByIdCreatedBy", "a4a1e760-3938-4746-a06c-5c04e14d64cd");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.Wb_RequisitionsCreatedOrUpdatedBy.GetsRequisitionsData.GetRequisitionByIdCreatedBy", "a4a1e760-3938-4746-a06c-5c04e14d64cd", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.23ja1su270qMOxDflSg1Kg/DataActions.RV0MtGW1bUWXY82Stw11Zg/NodesNotShownInESpaceTree.YOehpDg5RkegbFwE4U1kzQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, \"enrequisition114\".\"createdon\" o37, \"enrequisition114\".\"updatedon\" o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, \"enuser_created1\".\"name\" o59, NULL o60, NULL o61, NULL o62, NULL o63, \"enuser_updated1\".\"name\" o64, NULL o65, NULL o66, NULL o67");
fromBuilder.Append(" FROM (({Requisition} \"enrequisition114\" Left JOIN {User} \"enuser_created1\" ON (\"enrequisition114\".\"createdby\" = \"enuser_created1\".\"id\"))  Left JOIN {User} \"enuser_updated1\" ON (\"enrequisition114\".\"updatedby\" = \"enuser_updated1\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition114\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition114\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition114\".\"id\" IS NULL)");
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
RL_04a672cdadcf245af3641b3d2cc441e5 outParamList = new RL_04a672cdadcf245af3641b3d2cc441e5();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionByIdCreatedByReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsCreatedOrUpdatedBy.GetsRequisitionsData.GetRequisitionByIdCreatedBy.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_04a672cdadcf245af3641b3d2cc441e5 _tmp = new RL_04a672cdadcf245af3641b3d2cc441e5();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionByIdCreatedByReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsCreatedOrUpdatedBy.GetsRequisitionsData.GetRequisitionByIdCreatedBy.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_04a672cdadcf245af3641b3d2cc441e5)_tmp;
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
