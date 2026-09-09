using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_ScreenModel).Namespace);

    public long inParami_OrderMainId;
public long inParami_OrderContractFile;
public long inParami_OrderRequestFileId;
public ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeign;
public bool varLcAreFilesUploaded;
public RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList;
public ST_1d6498da9105fbe815a7f766352917c0Structure varLcl_File;
public ST_1d6498da9105fbe815a7f766352917c0Structure varLcl_FileEmpty;
public AggregateRecord<RL_978260cdc25ae86bbfc7a02b4fbbd8c3> ScreenDataSetGetOrderContractFileById;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_ScreenModel() {
}



    public ConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_ScreenModel(long inParami_OrderMainId, long inParami_OrderContractFile, long inParami_OrderRequestFileId, ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeign, bool varLcAreFilesUploaded, RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList, ST_1d6498da9105fbe815a7f766352917c0Structure varLcl_File, ST_1d6498da9105fbe815a7f766352917c0Structure varLcl_FileEmpty, AggregateRecord<RL_978260cdc25ae86bbfc7a02b4fbbd8c3> ScreenDataSetGetOrderContractFileById, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_OrderMainId", "i_OrderContractFile", "i_OrderRequestFileId", "InvoiceForeign", "AreFilesUploaded", "FilesList", "l_File", "l_FileEmpty", "GetOrderContractFileById", "ClientVars"}, new string[] {"inParami_OrderMainId", "inParami_OrderContractFile", "inParami_OrderRequestFileId", "varLcInvoiceForeign", "varLcAreFilesUploaded", "varLcFilesList", "varLcl_File", "varLcl_FileEmpty", "ScreenDataSetGetOrderContractFileById", "clientVariables"});
this.inParami_OrderMainId = inParami_OrderMainId;
this.inParami_OrderContractFile = inParami_OrderContractFile;
this.inParami_OrderRequestFileId = inParami_OrderRequestFileId;
this.varLcInvoiceForeign = varLcInvoiceForeign;
this.varLcAreFilesUploaded = varLcAreFilesUploaded;
this.varLcFilesList = varLcFilesList;
this.varLcl_File = varLcl_File;
this.varLcl_FileEmpty = varLcl_FileEmpty;
this.ScreenDataSetGetOrderContractFileById = ScreenDataSetGetOrderContractFileById;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_f6cad939346a2d641ae33c13dbcb8a70> datasetGetOrderContractFileByIdReadDbAsync(RC_f6cad939346a2d641ae33c13dbcb8a70 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENContractFileType.Read( r, ref index);
rec.ssENOrderContractFile.Read( r, ref index);
rec.ssENOrderFile.Read( r, ref index);
return rec;
}
// Query Function "GetOrderContractFileById" op9KZQXWpU6OTF4eyxxpOw of Action "Wb_UploadOrderContractDocuments"
public static async Task<(RL_978260cdc25ae86bbfc7a02b4fbbd8c3,long)> datasetGetOrderContractFileById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderContractFile_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_OrdersRequestFiles.Wb_UploadOrderContractDocuments.GetOrderContractFileById", "654a9fa2-d605-4ea5-8e4c-5e1ecb1c693b");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_UploadOrderContractDocuments","e_OrdersRequestFiles.Wb_UploadOrderContractDocuments.GetOrderContractFileById");
// Query Iterations: Never
// Refresh Query XEq9FFfl4keTxFutlH2lxg Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.QVuy0_xq1k6uAfJb8WCO0A/NodesShownInESpaceTree.p4ieOnjts02rmUgwccL0hA/ScreenDataSets.op9KZQXWpU6OTF4eyxxpOw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encontractfiletype2\".\"id\" o0, \"encontractfiletype2\".\"label\" o1, \"encontractfiletype2\".\"order\" o2, \"encontractfiletype2\".\"is_active\" o3, \"enordercontractfile10\".\"id\" o4, \"enordercontractfile10\".\"orderid\" o5, \"enordercontractfile10\".\"orderfileid\" o6, \"enordercontractfile10\".\"contractfiletypeid\" o7, trim_scale(\"enordercontractfile10\".\"amount\"::numeric) o8, trim_scale(\"enordercontractfile10\".\"tarif\"::numeric) o9, \"enordercontractfile10\".\"currencyid\" o10, \"enordercontractfile10\".\"deposittypeid\" o11, \"enordercontractfile10\".\"insurancetypeid\" o12, \"enordercontractfile10\".\"advancepaymenttypeid\" o13, \"enordercontractfile10\".\"startbasedate\" o14, \"enordercontractfile10\".\"endbasedate\" o15, \"enordercontractfile10\".\"paymenttermsid\" o16, \"enordercontractfile10\".\"isforvendorupload\" o17, \"enorderfile11\".\"id\" o18, \"enorderfile11\".\"filename\" o19, \"enorderfile11\".\"vendor\" o20, \"enorderfile11\".\"doc_type\" o21, \"enorderfile11\".\"sap_object\" o22, \"enorderfile11\".\"createdby\" o23, \"enorderfile11\".\"createdon\" o24, \"enorderfile11\".\"storageid\" o25");
fromBuilder.Append(" FROM (({OrderContractFile} \"enordercontractfile10\" Left JOIN {OrderFile} \"enorderfile11\" ON (\"enordercontractfile10\".\"orderfileid\" = \"enorderfile11\".\"id\"))  Left JOIN {ContractFileType} \"encontractfiletype2\" ON (\"enordercontractfile10\".\"contractfiletypeid\" = \"encontractfiletype2\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderContractFile_Id != 0) {
whereBuilder.Append("((\"enordercontractfile10\".\"id\" = @qporOrderContractFile_Id) AND (\"enordercontractfile10\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderContractFile_Id", DbType.Int64, qporOrderContractFile_Id);
} else {
whereBuilder.Append("(\"enordercontractfile10\".\"id\" IS NULL)");
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
RL_978260cdc25ae86bbfc7a02b4fbbd8c3 outParamList = new RL_978260cdc25ae86bbfc7a02b4fbbd8c3();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderContractFileByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_OrdersRequestFiles.Wb_UploadOrderContractDocuments.GetOrderContractFileById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_978260cdc25ae86bbfc7a02b4fbbd8c3 _tmp = new RL_978260cdc25ae86bbfc7a02b4fbbd8c3();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderContractFileByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_OrdersRequestFiles.Wb_UploadOrderContractDocuments.GetOrderContractFileById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_978260cdc25ae86bbfc7a02b4fbbd8c3)_tmp;
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
