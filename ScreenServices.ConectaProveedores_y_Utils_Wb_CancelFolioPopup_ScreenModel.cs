using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_y_Utils_Wb_CancelFolioPopup_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_y_Utils_Wb_CancelFolioPopup_ScreenModel).Namespace);

    public long inParamFolioId;
public ST_e54bcdc56c6f092fdfed672ad024bfa4Structure varLcFolioReject;
public bool varLcIsExecuting;
public AggregateRecord<RL_a811b54d11345a2c46a0dc7830ffa1de> ScreenDataSetGetFolioApprovalLevels;
public AggregateRecord<RL_d94294de88e7b9437b2238f21bdccaff> ScreenDataSetGetFolioById;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_y_Utils_Wb_CancelFolioPopup_ScreenModel() {
}



    public ConectaProveedores_y_Utils_Wb_CancelFolioPopup_ScreenModel(long inParamFolioId, ST_e54bcdc56c6f092fdfed672ad024bfa4Structure varLcFolioReject, bool varLcIsExecuting, AggregateRecord<RL_a811b54d11345a2c46a0dc7830ffa1de> ScreenDataSetGetFolioApprovalLevels, AggregateRecord<RL_d94294de88e7b9437b2238f21bdccaff> ScreenDataSetGetFolioById, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"FolioId", "FolioReject", "IsExecuting", "GetFolioApprovalLevels", "GetFolioById", "ClientVars"}, new string[] {"inParamFolioId", "varLcFolioReject", "varLcIsExecuting", "ScreenDataSetGetFolioApprovalLevels", "ScreenDataSetGetFolioById", "clientVariables"});
this.inParamFolioId = inParamFolioId;
this.varLcFolioReject = varLcFolioReject;
this.varLcIsExecuting = varLcIsExecuting;
this.ScreenDataSetGetFolioApprovalLevels = ScreenDataSetGetFolioApprovalLevels;
this.ScreenDataSetGetFolioById = ScreenDataSetGetFolioById;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_e40e190961051a83f0f95a5985af6cdd> datasetGetFolioApprovalLevelsReadDbAsync(RC_e40e190961051a83f0f95a5985af6cdd rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetFolioApprovalLevels" qTAdMzC4K0+l6TUpxcyGJg of Action "Wb_CancelFolioPopup"
public static async Task<(RL_a811b54d11345a2c46a0dc7830ffa1de,long)> datasetGetFolioApprovalLevels(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("y_Utils.Wb_CancelFolioPopup.GetFolioApprovalLevels", "331d30a9-b830-4f2b-a5e9-3529c5cc8626");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_CancelFolioPopup","y_Utils.Wb_CancelFolioPopup.GetFolioApprovalLevels");
// Query Iterations: Multiple
// Refresh Query RZbwjm6kEUKXw05P5_RowA Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.JAcgewyqEkOMCfBjsT2WtQ/NodesShownInESpaceTree.lURuoH9U4k6AFdDThcizWg/ScreenDataSets.qTAdMzC4K0+l6TUpxcyGJg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, \"enuser197\".\"id\" o50, \"enuser197\".\"name\" o51, \"enuser197\".\"email\" o52, \"enuser197\".\"photourl\" o53, \"enuser197\".\"username\" o54");
fromBuilder.Append(" FROM ((({Folio} \"enfolio73\" Inner JOIN {FolioApproval} \"enfolioapproval40\" ON (\"enfolio73\".\"id\" = \"enfolioapproval40\".\"folioid\"))  Inner JOIN {FolioApprovalLevel} \"enfolioapprovallevel36\" ON (\"enfolioapproval40\".\"id\" = \"enfolioapprovallevel36\".\"folioapprovalid\"))  Inner JOIN {User} \"enuser197\" ON (\"enfolioapprovallevel36\".\"assignedto\" = \"enuser197\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio73\".\"id\" = @qpfoFolio_Id) AND (\"enfolio73\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio73\".\"id\" IS NULL)");
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
RL_a811b54d11345a2c46a0dc7830ffa1de outParamList = new RL_a811b54d11345a2c46a0dc7830ffa1de();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioApprovalLevelsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Utils.Wb_CancelFolioPopup.GetFolioApprovalLevels.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a811b54d11345a2c46a0dc7830ffa1de _tmp = new RL_a811b54d11345a2c46a0dc7830ffa1de();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioApprovalLevelsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Utils.Wb_CancelFolioPopup.GetFolioApprovalLevels.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a811b54d11345a2c46a0dc7830ffa1de)_tmp;
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

private static async Task<RC_b668eee4846e2937101a51355804499d> datasetGetFolioByIdReadDbAsync(RC_b668eee4846e2937101a51355804499d rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" y3CpeSv9x0GHGNa3ba3R7g of Action "Wb_CancelFolioPopup"
public static async Task<(RL_d94294de88e7b9437b2238f21bdccaff,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("y_Utils.Wb_CancelFolioPopup.GetFolioById", "79a970cb-fd2b-41c7-8718-d6b76dadd1ee");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_CancelFolioPopup","y_Utils.Wb_CancelFolioPopup.GetFolioById");
// Query Iterations: Never
// Refresh Query 6OlZqX51HkiT9RDXxrM3Kw Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.JAcgewyqEkOMCfBjsT2WtQ/NodesShownInESpaceTree.lURuoH9U4k6AFdDThcizWg/ScreenDataSets.y3CpeSv9x0GHGNa3ba3R7g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio74\".\"id\" o0, \"enfolio74\".\"isdraft\" o1, \"enfolio74\".\"folionumber\" o2, \"enfolio74\".\"canproveedorcancel\" o3, \"enfolio74\".\"orderid\" o4, \"enfolio74\".\"supplierid\" o5, \"enfolio74\".\"companyid\" o6, \"enfolio74\".\"foliostatusid\" o7, trim_scale(\"enfolio74\".\"totalamount\"::numeric) o8, trim_scale(\"enfolio74\".\"totaliva_amount\"::numeric) o9, trim_scale(\"enfolio74\".\"partialamount\"::numeric) o10, \"enfolio74\".\"currencyid\" o11, \"enfolio74\".\"firstapproveruserid\" o12, \"enfolio74\".\"approvalprocesstypeid\" o13, \"enfolio74\".\"sapentryerror\" o14, \"enfolio74\".\"createdby\" o15, \"enfolio74\".\"createdon\" o16, \"enfolio74\".\"updatedby\" o17, \"enfolio74\".\"updatedon\" o18, \"enfolio74\".\"minuteselected\" o19, \"eninvoice139\".\"id\" o20, \"eninvoice139\".\"name\" o21, \"eninvoice139\".\"requisitionid\" o22, \"eninvoice139\".\"folioid\" o23, \"eninvoice139\".\"ordermainid\" o24, \"eninvoice139\".\"cfditypeid\" o25, trim_scale(\"eninvoice139\".\"totalamount\"::numeric) o26, \"eninvoice139\".\"currency\" o27, \"eninvoice139\".\"invoicestatusid\" o28, \"eninvoice139\".\"accountingdatetime\" o29, \"eninvoice139\".\"paymentdatetime\" o30, \"eninvoice139\".\"createdon\" o31, \"eninvoice139\".\"createdby\" o32, \"eninvoice139\".\"updatedon\" o33, \"eninvoice139\".\"updatedby\" o34, \"eninvoice139\".\"submittedon\" o35, \"eninvoice139\".\"isnewversion\" o36, \"eninvoice139\".\"id_poliza\" o37, \"eninvoice139\".\"id_poliza_sap\" o38, \"eninvoice139\".\"doc51\" o39, \"eninvoice139\".\"accountingerror\" o40, \"eninvoice139\".\"orderaccconceptsid\" o41, trim_scale(\"eninvoice139\".\"amortization\"::numeric) o42, \"eninvoice139\".\"creditnoteinvoiceid\" o43");
fromBuilder.Append(" FROM ({Folio} \"enfolio74\" Left JOIN {Invoice} \"eninvoice139\" ON (\"enfolio74\".\"id\" = \"eninvoice139\".\"folioid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio74\".\"id\" = @qpfoFolio_Id) AND (\"enfolio74\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio74\".\"id\" IS NULL)");
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
RL_d94294de88e7b9437b2238f21bdccaff outParamList = new RL_d94294de88e7b9437b2238f21bdccaff();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Utils.Wb_CancelFolioPopup.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d94294de88e7b9437b2238f21bdccaff _tmp = new RL_d94294de88e7b9437b2238f21bdccaff();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Utils.Wb_CancelFolioPopup.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d94294de88e7b9437b2238f21bdccaff)_tmp;
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
