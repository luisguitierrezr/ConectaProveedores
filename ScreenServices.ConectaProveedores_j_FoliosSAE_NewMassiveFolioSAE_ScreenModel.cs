using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ScreenModel).Namespace);

    public RL_f4ab0a048438c19ab1537693fa69f7c4 varLcFolioQList;
public int varLcNumberOfRecords;
public int varLcNumberWithErrors;
public RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList;
public bool varLcHelpPopup;
public long varLcl_OrderMainID;
public ST_6dc39d329f4b959722daa75bc2f62c1fStructure varLcl_FolioAccData;
public ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_DataActionGetSupplierName_Model varLcGetSupplierName;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ScreenModel(RL_f4ab0a048438c19ab1537693fa69f7c4 varLcFolioQList, int varLcNumberOfRecords, int varLcNumberWithErrors, RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList, bool varLcHelpPopup, long varLcl_OrderMainID, ST_6dc39d329f4b959722daa75bc2f62c1fStructure varLcl_FolioAccData, ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_DataActionGetSupplierName_Model varLcGetSupplierName, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"FolioQList", "NumberOfRecords", "NumberWithErrors", "FilesList", "HelpPopup", "l_OrderMainID", "l_FolioAccData", "GetSupplierName", "ClientVars"}, new string[] {"varLcFolioQList", "varLcNumberOfRecords", "varLcNumberWithErrors", "varLcFilesList", "varLcHelpPopup", "varLcl_OrderMainID", "varLcl_FolioAccData", "varLcGetSupplierName", "clientVariables"});
this.varLcFolioQList = varLcFolioQList;
this.varLcNumberOfRecords = varLcNumberOfRecords;
this.varLcNumberWithErrors = varLcNumberWithErrors;
this.varLcFilesList = varLcFilesList;
this.varLcHelpPopup = varLcHelpPopup;
this.varLcl_OrderMainID = varLcl_OrderMainID;
this.varLcl_FolioAccData = varLcl_FolioAccData;
this.varLcGetSupplierName = varLcGetSupplierName;
this.clientVariables = clientVariables;
}



    

    public class lcvGetSupplierName : VarsBag {
public RL_d5c1b2482ff109e80580d8b5fb920193 queryResGetSupplierById_outParamList = new RL_d5c1b2482ff109e80580d8b5fb920193();
public long queryResGetSupplierById_outParamCount = 0L;

public lcvGetSupplierName() {
}
}
public class lcoGetSupplierName : VarsBag {
public string outParamSupplierName = "";

public lcoGetSupplierName() {
}
}
/// <summary>
/// Action <code>GetSupplierName</code> that represents the Service Studio action
///  <code>GetSupplierName</code> <p> Description: </p>
/// </summary>
public async Task<string> DataActionGetSupplierName(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamSupplierName = default;
lcoGetSupplierName result = new lcoGetSupplierName();
lcvGetSupplierName localVars = new lcvGetSupplierName();
ConectaProveedores_j_FoliosSAE_NewMassiveFolioSAE_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSupplierName", "fe37cf69-b048-4461-b296-4fce37420027"))
using (activitySource.CreateScreenDataActionActivity("NewMassiveFolioSAE", "GetSupplierName")){
// Query datasetGetSupplierById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSupplierById_maxRecords = 0;
int datasetGetSupplierById_startIndex = 0;(localVars.queryResGetSupplierById_outParamList,localVars.queryResGetSupplierById_outParamCount) = await FuncDataActionGetSupplierName.datasetGetSupplierById(requestContext,datasetGetSupplierById_maxRecords,datasetGetSupplierById_startIndex,IterationMultiplicity.Never,(await Functions.ActionGetUserSupplier(requestContext,"",cancellationToken)),cancellationToken);

// SupplierName = GetSupplierById.List.Current.Supplier.Name
result.outParamSupplierName=localVars.queryResGetSupplierById_outParamList.CurrentRec.ssENSupplier.ssName;
} //close CreateActionActivity using block
} // try

finally {
outParamSupplierName = result.outParamSupplierName;
} // inner-finally
RETURN_STATEMENT:
return outParamSupplierName;
}


    public static class FuncDataActionGetSupplierName {

// Query Function "GetSupplierById" BcpQnSNqo0OaWVyqhazUCw of Action "GetSupplierName"
public static async Task<(RL_d5c1b2482ff109e80580d8b5fb920193,long)> datasetGetSupplierById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.NewMassiveFolioSAE.GetSupplierName.GetSupplierById", "9d50ca05-6a23-43a3-9a59-5caa85acd40b");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.NewMassiveFolioSAE.GetSupplierName.GetSupplierById", "9d50ca05-6a23-43a3-9a59-5caa85acd40b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.+ltSq3HvnE2_md9JBN4oow/DataActions.ac83_kiwYUSylk_ON0IAJw/NodesNotShownInESpaceTree.BcpQnSNqo0OaWVyqhazUCw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"ensupplier154\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM {Supplier} \"ensupplier154\"");
whereBuilder.Append(" WHERE ");
if (qpsuId != 0) {
whereBuilder.Append("((\"ensupplier154\".\"id\" = @qpsuId) AND (\"ensupplier154\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuId", DbType.Int64, qpsuId);
} else {
whereBuilder.Append("(\"ensupplier154\".\"id\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"ensupplier154\".\"tratamiento\" ASC ");
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
opt[0] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.NewMassiveFolioSAE.GetSupplierName.GetSupplierById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.NewMassiveFolioSAE.GetSupplierName.GetSupplierById.List", cancellationToken: cancellationToken);
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
