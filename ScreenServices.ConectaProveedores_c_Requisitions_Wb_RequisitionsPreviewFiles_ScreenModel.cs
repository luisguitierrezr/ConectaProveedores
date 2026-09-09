using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_ScreenModel).Namespace);

    public long inParami_RequisitionId;
public bool varLcl_IsOpenPopupOtherFiles;
public ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_DataActionGetFilesByRequisitionId_Model varLcGetFilesByRequisitionId;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_ScreenModel() {
}



    public ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_ScreenModel(long inParami_RequisitionId, bool varLcl_IsOpenPopupOtherFiles, ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_DataActionGetFilesByRequisitionId_Model varLcGetFilesByRequisitionId, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_RequisitionId", "l_IsOpenPopupOtherFiles", "GetFilesByRequisitionId", "ClientVars"}, new string[] {"inParami_RequisitionId", "varLcl_IsOpenPopupOtherFiles", "varLcGetFilesByRequisitionId", "clientVariables"});
this.inParami_RequisitionId = inParami_RequisitionId;
this.varLcl_IsOpenPopupOtherFiles = varLcl_IsOpenPopupOtherFiles;
this.varLcGetFilesByRequisitionId = varLcGetFilesByRequisitionId;
this.clientVariables = clientVariables;
}



    

    public class lcvGetFilesByRequisitionId : VarsBag {
public RL_dcf9165e080aea63f7a9b95efcf09ef4 resPDF_Filter_outParamFilteredList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();

public RL_dcf9165e080aea63f7a9b95efcf09ef4 queryResRequisitionFilesById_outParamList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
public long queryResRequisitionFilesById_outParamCount = 0L;

public RL_dcf9165e080aea63f7a9b95efcf09ef4 resOthers_Filter_outParamFilteredList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();

public RL_dcf9165e080aea63f7a9b95efcf09ef4 resXML_Filter_outParamFilteredList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();

public lcvGetFilesByRequisitionId() {
}
}
public class lcoGetFilesByRequisitionId : VarsBag {
public RL_b48e8aa5377b7b15faec0f07ad9facf2 outParamFilesPDF = new RL_b48e8aa5377b7b15faec0f07ad9facf2();

public RL_b48e8aa5377b7b15faec0f07ad9facf2 outParamFilesXML = new RL_b48e8aa5377b7b15faec0f07ad9facf2();

public RL_b48e8aa5377b7b15faec0f07ad9facf2 outParamOtherFiles = new RL_b48e8aa5377b7b15faec0f07ad9facf2();

public lcoGetFilesByRequisitionId() {
}
}
/// <summary>
/// Action <code>GetFilesByRequisitionId</code> that represents the Service Studio action
///  <code>GetFilesByRequisitionId</code> <p> Description: Query to fetch Files By Requisition Id.</p>
/// </summary>
public async Task<(RL_b48e8aa5377b7b15faec0f07ad9facf2,RL_b48e8aa5377b7b15faec0f07ad9facf2,RL_b48e8aa5377b7b15faec0f07ad9facf2)> DataActionGetFilesByRequisitionId(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_b48e8aa5377b7b15faec0f07ad9facf2 outParamFilesPDF = default;
RL_b48e8aa5377b7b15faec0f07ad9facf2 outParamFilesXML = default;
RL_b48e8aa5377b7b15faec0f07ad9facf2 outParamOtherFiles = default;
lcoGetFilesByRequisitionId result = new lcoGetFilesByRequisitionId();
lcvGetFilesByRequisitionId localVars = new lcvGetFilesByRequisitionId();
ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetFilesByRequisitionId", "0413a854-7372-4575-bf33-124126292f71"))
using (activitySource.CreateScreenDataActionActivity("Wb_RequisitionsPreviewFiles", "GetFilesByRequisitionId")){
// Query datasetRequisitionFilesById
cancellationToken.ThrowIfCancellationRequested();
int datasetRequisitionFilesById_maxRecords = 0;
int datasetRequisitionFilesById_startIndex = 0;(localVars.queryResRequisitionFilesById_outParamList,localVars.queryResRequisitionFilesById_outParamCount) = await FuncDataActionGetFilesByRequisitionId.datasetRequisitionFilesById(requestContext,datasetRequisitionFilesById_maxRecords,datasetRequisitionFilesById_startIndex,IterationMultiplicity.Multiple,inParami_RequisitionId,cancellationToken);

// PDF_Filter
localVars.resPDF_Filter_outParamFilteredList = (((RL_dcf9165e080aea63f7a9b95efcf09ef4)await  localVars.queryResRequisitionFilesById_outParamList.FilterAsync(async (p, cancellationToken) => (BuiltInFunction.IndexSC (BuiltInFunction.ToLower (p.ssENRequisitionFile2.ssFilename), ".pdf", 0, false, false)!=(-1)), cancellationToken)));

// XML_Filter
localVars.resXML_Filter_outParamFilteredList = (((RL_dcf9165e080aea63f7a9b95efcf09ef4)await  localVars.queryResRequisitionFilesById_outParamList.FilterAsync(async (p, cancellationToken) => (BuiltInFunction.IndexSC (BuiltInFunction.ToLower (p.ssENRequisitionFile2.ssFilename), ".xml", 0, false, false)!=(-1)), cancellationToken)));

// Others_Filter
localVars.resOthers_Filter_outParamFilteredList = (((RL_dcf9165e080aea63f7a9b95efcf09ef4)await  localVars.queryResRequisitionFilesById_outParamList.FilterAsync(async (p, cancellationToken) => ((!(BuiltInFunction.IndexSC (BuiltInFunction.ToLower (p.ssENRequisitionFile2.ssFilename), ".xml", 0, false, false)!=(-1)))&&(!(BuiltInFunction.IndexSC (BuiltInFunction.ToLower (p.ssENRequisitionFile2.ssFilename), ".pdf", 0, false, false)!=(-1)))), cancellationToken)));

// FilesPDF = PDF_Filter.FilteredList
result.outParamFilesPDF=(await RL_b48e8aa5377b7b15faec0f07ad9facf2.ConvertAsync(localVars.resPDF_Filter_outParamFilteredList, new RL_b48e8aa5377b7b15faec0f07ad9facf2(), async (RC_dc345357879dcb92e41eacae4ac8926c source, ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure target, CancellationToken cancellationToken) => {
target.ssStorageId = source.ssENRequisitionFile2.ssStorageId;
target.ssFilename = source.ssENRequisitionFile2.ssFilename;
return target;
}, cancellationToken));

// FilesXML = XML_Filter.FilteredList
result.outParamFilesXML=(await RL_b48e8aa5377b7b15faec0f07ad9facf2.ConvertAsync(localVars.resXML_Filter_outParamFilteredList, new RL_b48e8aa5377b7b15faec0f07ad9facf2(), async (RC_dc345357879dcb92e41eacae4ac8926c source, ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure target, CancellationToken cancellationToken) => {
target.ssStorageId = source.ssENRequisitionFile2.ssStorageId;
target.ssFilename = source.ssENRequisitionFile2.ssFilename;
return target;
}, cancellationToken));

// OtherFiles = Others_Filter.FilteredList
result.outParamOtherFiles=(await RL_b48e8aa5377b7b15faec0f07ad9facf2.ConvertAsync(localVars.resOthers_Filter_outParamFilteredList, new RL_b48e8aa5377b7b15faec0f07ad9facf2(), async (RC_dc345357879dcb92e41eacae4ac8926c source, ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure target, CancellationToken cancellationToken) => {
target.ssStorageId = source.ssENRequisitionFile2.ssStorageId;
target.ssFilename = source.ssENRequisitionFile2.ssFilename;
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamFilesPDF = result.outParamFilesPDF;
outParamFilesXML = result.outParamFilesXML;
outParamOtherFiles = result.outParamOtherFiles;
} // inner-finally
RETURN_STATEMENT:
return (outParamFilesPDF,outParamFilesXML,outParamOtherFiles);
}


    public static class FuncDataActionGetFilesByRequisitionId {

private static async Task<RC_dc345357879dcb92e41eacae4ac8926c> datasetRequisitionFilesByIdReadDbAsync(RC_dc345357879dcb92e41eacae4ac8926c rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisitionContractFile.Read( r, ref index);
rec.ssENRequisitionFile2.Read( r, ref index);
return rec;
}
// Query Function "RequisitionFilesById" oEUuK9dbxUqYeFoGvwo8bQ of Action "GetFilesByRequisitionId"
public static async Task<(RL_dcf9165e080aea63f7a9b95efcf09ef4,long)> datasetRequisitionFilesById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionContractFile_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.Wb_RequisitionsPreviewFiles.GetFilesByRequisitionId.RequisitionFilesById", "2b2e45a0-5bd7-4ac5-9878-5a06bf0a3c6d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.Wb_RequisitionsPreviewFiles.GetFilesByRequisitionId.RequisitionFilesById", "2b2e45a0-5bd7-4ac5-9878-5a06bf0a3c6d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.MsvRa3r4uUOfsiOzrx0p2A/DataActions.VKgTBHJzdUW_MxJBJikvcQ/NodesNotShownInESpaceTree.oEUuK9dbxUqYeFoGvwo8bQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, \"enrequisitionfile211\".\"filename\" o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, \"enrequisitionfile211\".\"storageid\" o16");
fromBuilder.Append(" FROM ({RequisitionContractFile} \"enrequisitioncontractfile14\" Left JOIN {RequisitionFile2} \"enrequisitionfile211\" ON (\"enrequisitioncontractfile14\".\"requisitionfileid\" = \"enrequisitionfile211\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionContractFile_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitioncontractfile14\".\"requisitionid\" = @qpreRequisitionContractFile_RequisitionId) AND (\"enrequisitioncontractfile14\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionContractFile_RequisitionId", DbType.Int64, qpreRequisitionContractFile_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitioncontractfile14\".\"requisitionid\" IS NULL)");
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
RL_dcf9165e080aea63f7a9b95efcf09ef4 outParamList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetRequisitionFilesByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionsPreviewFiles.GetFilesByRequisitionId.RequisitionFilesById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_dcf9165e080aea63f7a9b95efcf09ef4 _tmp = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
_tmp.AlternateReadDbMethodAsync = datasetRequisitionFilesByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionsPreviewFiles.GetFilesByRequisitionId.RequisitionFilesById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_dcf9165e080aea63f7a9b95efcf09ef4)_tmp;
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
