using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFinancialFileWithoutAcc_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFinancialFileWithoutAcc_ScreenModel).Namespace);

    public long inParamOrderMainId;
public long inParamOrderAccConceptsId;
public int inParamAccountingDataTypeId;
public long inParami_OrderRequestFileId;
public RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList;
public RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesListExtra;
public ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeign;
public EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcInvoice;
public bool varLcAreFilesUploaded;
public string varLcClaveProdServ;
public string varLcTipoDeComprobante;
public AggregateRecord<RL_95d1f6e611a5505299d1e9919fa0d9e6> ScreenDataSetGetOrderAccConceptById;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFinancialFileWithoutAcc_ScreenModel() {
}



    public ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFinancialFileWithoutAcc_ScreenModel(long inParamOrderMainId, long inParamOrderAccConceptsId, int inParamAccountingDataTypeId, long inParami_OrderRequestFileId, RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList, RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesListExtra, ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeign, EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcInvoice, bool varLcAreFilesUploaded, string varLcClaveProdServ, string varLcTipoDeComprobante, AggregateRecord<RL_95d1f6e611a5505299d1e9919fa0d9e6> ScreenDataSetGetOrderAccConceptById, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"OrderMainId", "OrderAccConceptsId", "AccountingDataTypeId", "i_OrderRequestFileId", "FilesList", "FilesListExtra", "InvoiceForeign", "Invoice", "AreFilesUploaded", "ClaveProdServ", "TipoDeComprobante", "GetOrderAccConceptById", "ClientVars"}, new string[] {"inParamOrderMainId", "inParamOrderAccConceptsId", "inParamAccountingDataTypeId", "inParami_OrderRequestFileId", "varLcFilesList", "varLcFilesListExtra", "varLcInvoiceForeign", "varLcInvoice", "varLcAreFilesUploaded", "varLcClaveProdServ", "varLcTipoDeComprobante", "ScreenDataSetGetOrderAccConceptById", "clientVariables"});
this.inParamOrderMainId = inParamOrderMainId;
this.inParamOrderAccConceptsId = inParamOrderAccConceptsId;
this.inParamAccountingDataTypeId = inParamAccountingDataTypeId;
this.inParami_OrderRequestFileId = inParami_OrderRequestFileId;
this.varLcFilesList = varLcFilesList;
this.varLcFilesListExtra = varLcFilesListExtra;
this.varLcInvoiceForeign = varLcInvoiceForeign;
this.varLcInvoice = varLcInvoice;
this.varLcAreFilesUploaded = varLcAreFilesUploaded;
this.varLcClaveProdServ = varLcClaveProdServ;
this.varLcTipoDeComprobante = varLcTipoDeComprobante;
this.ScreenDataSetGetOrderAccConceptById = ScreenDataSetGetOrderAccConceptById;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_ea3a117956fd50e1901759909d3fbc2f> datasetGetOrderAccConceptByIdReadDbAsync(RC_ea3a117956fd50e1901759909d3fbc2f rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENAccountingDataType.Read( r, ref index);
rec.ssENOrderAccConcepts.Read( r, ref index);
return rec;
}
// Query Function "GetOrderAccConceptById" UTMTHohUckmgejED9GBN5w of Action "Wb_UploadComplementFinancialFileWithoutAcc"
public static async Task<(RL_95d1f6e611a5505299d1e9919fa0d9e6,long)> datasetGetOrderAccConceptById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccConcepts_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_OrdersRequestFiles.Wb_UploadComplementFinancialFileWithoutAcc.GetOrderAccConceptById", "1e133351-5488-4972-a07a-3103f4604de7");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_UploadComplementFinancialFileWithoutAcc","e_OrdersRequestFiles.Wb_UploadComplementFinancialFileWithoutAcc.GetOrderAccConceptById");
// Query Iterations: Never
// Refresh Query jxEyKNyLRkaAtYIcoaGGTg Iterations: Never
// Refresh Query Km03Ccg9IEKL8oFTDwSCLA Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.QVuy0_xq1k6uAfJb8WCO0A/NodesShownInESpaceTree.aKGtAzBSqEm6Ij5Exg6zOA/ScreenDataSets.UTMTHohUckmgejED9GBN5w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18");
fromBuilder.Append(" FROM ({OrderAccConcepts} \"enorderaccconcepts33\" Left JOIN {AccountingDataType} \"enaccountingdatatype14\" ON (\"enorderaccconcepts33\".\"accountingdatatypeid\" = \"enaccountingdatatype14\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderAccConcepts_Id != 0) {
whereBuilder.Append("((\"enorderaccconcepts33\".\"id\" = @qporOrderAccConcepts_Id) AND (\"enorderaccconcepts33\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccConcepts_Id", DbType.Int64, qporOrderAccConcepts_Id);
} else {
whereBuilder.Append("(\"enorderaccconcepts33\".\"id\" IS NULL)");
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
RL_95d1f6e611a5505299d1e9919fa0d9e6 outParamList = new RL_95d1f6e611a5505299d1e9919fa0d9e6();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderAccConceptByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_OrdersRequestFiles.Wb_UploadComplementFinancialFileWithoutAcc.GetOrderAccConceptById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_95d1f6e611a5505299d1e9919fa0d9e6 _tmp = new RL_95d1f6e611a5505299d1e9919fa0d9e6();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderAccConceptByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_OrdersRequestFiles.Wb_UploadComplementFinancialFileWithoutAcc.GetOrderAccConceptById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_95d1f6e611a5505299d1e9919fa0d9e6)_tmp;
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
