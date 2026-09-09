using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel).Namespace);

    public long inParami_FolioId;
public DateTime varLcl_RefreshOrderEntra_Historic;
public string varLcTableSort;
public int varLcStartIndex;
public int varLcMaxRecords;
public string varLcTableSort2;
public bool varLcIsReadOnly2;
public bool varLcShowCancelFolioPopup;
public bool varLcIsExecuting;
public ST_e54bcdc56c6f092fdfed672ad024bfa4Structure varLcFolioReject;
public bool varLcI_CanReject;
public bool varLcI_CanCancelIncoice;
public AggregateRecord<RL_906cfbdbf8c03778600b870bd5d6309b> ScreenDataSetGetFolioById;
public AggregateRecord<RL_1751b6fc487a87e5015dd52d099b7396> ScreenDataSetGetOrderMains;
public AggregateRecord<RL_d5c1b2482ff109e80580d8b5fb920193> ScreenDataSetGetSuppliers;
public AggregateRecord<RL_a811b54d11345a2c46a0dc7830ffa1de> ScreenDataSetGetFolioApprovalLevels;
public AggregateRecord<RL_a968cf9f63475dc9358672149b11245a> ScreenDataSetGetFolioItemsByFolioId;
public AggregateRecord<RL_1353a59e0688582d82bbddc41b47193e> ScreenDataSetGetCurrencies;
public AggregateRecord<RL_1409548829f9518cbebb0e467312ef87> ScreenDataSetGetCompanies;
public ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_DataActionGetUserData_Model varLcGetUserData;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel(long inParami_FolioId, DateTime varLcl_RefreshOrderEntra_Historic, string varLcTableSort, int varLcStartIndex, int varLcMaxRecords, string varLcTableSort2, bool varLcIsReadOnly2, bool varLcShowCancelFolioPopup, bool varLcIsExecuting, ST_e54bcdc56c6f092fdfed672ad024bfa4Structure varLcFolioReject, bool varLcI_CanReject, bool varLcI_CanCancelIncoice, AggregateRecord<RL_906cfbdbf8c03778600b870bd5d6309b> ScreenDataSetGetFolioById, AggregateRecord<RL_1751b6fc487a87e5015dd52d099b7396> ScreenDataSetGetOrderMains, AggregateRecord<RL_d5c1b2482ff109e80580d8b5fb920193> ScreenDataSetGetSuppliers, AggregateRecord<RL_a811b54d11345a2c46a0dc7830ffa1de> ScreenDataSetGetFolioApprovalLevels, AggregateRecord<RL_a968cf9f63475dc9358672149b11245a> ScreenDataSetGetFolioItemsByFolioId, AggregateRecord<RL_1353a59e0688582d82bbddc41b47193e> ScreenDataSetGetCurrencies, AggregateRecord<RL_1409548829f9518cbebb0e467312ef87> ScreenDataSetGetCompanies, ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_DataActionGetUserData_Model varLcGetUserData, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_FolioId", "l_RefreshOrderEntra_Historic", "TableSort", "StartIndex", "MaxRecords", "TableSort2", "IsReadOnly2", "ShowCancelFolioPopup", "IsExecuting", "FolioReject", "I_CanReject", "I_CanCancelIncoice", "GetFolioById", "GetOrderMains", "GetSuppliers", "GetFolioApprovalLevels", "GetFolioItemsByFolioId", "GetCurrencies", "GetCompanies", "GetUserData", "ClientVars"}, new string[] {"inParami_FolioId", "varLcl_RefreshOrderEntra_Historic", "varLcTableSort", "varLcStartIndex", "varLcMaxRecords", "varLcTableSort2", "varLcIsReadOnly2", "varLcShowCancelFolioPopup", "varLcIsExecuting", "varLcFolioReject", "varLcI_CanReject", "varLcI_CanCancelIncoice", "ScreenDataSetGetFolioById", "ScreenDataSetGetOrderMains", "ScreenDataSetGetSuppliers", "ScreenDataSetGetFolioApprovalLevels", "ScreenDataSetGetFolioItemsByFolioId", "ScreenDataSetGetCurrencies", "ScreenDataSetGetCompanies", "varLcGetUserData", "clientVariables"});
this.inParami_FolioId = inParami_FolioId;
this.varLcl_RefreshOrderEntra_Historic = varLcl_RefreshOrderEntra_Historic;
this.varLcTableSort = varLcTableSort;
this.varLcStartIndex = varLcStartIndex;
this.varLcMaxRecords = varLcMaxRecords;
this.varLcTableSort2 = varLcTableSort2;
this.varLcIsReadOnly2 = varLcIsReadOnly2;
this.varLcShowCancelFolioPopup = varLcShowCancelFolioPopup;
this.varLcIsExecuting = varLcIsExecuting;
this.varLcFolioReject = varLcFolioReject;
this.varLcI_CanReject = varLcI_CanReject;
this.varLcI_CanCancelIncoice = varLcI_CanCancelIncoice;
this.ScreenDataSetGetFolioById = ScreenDataSetGetFolioById;
this.ScreenDataSetGetOrderMains = ScreenDataSetGetOrderMains;
this.ScreenDataSetGetSuppliers = ScreenDataSetGetSuppliers;
this.ScreenDataSetGetFolioApprovalLevels = ScreenDataSetGetFolioApprovalLevels;
this.ScreenDataSetGetFolioItemsByFolioId = ScreenDataSetGetFolioItemsByFolioId;
this.ScreenDataSetGetCurrencies = ScreenDataSetGetCurrencies;
this.ScreenDataSetGetCompanies = ScreenDataSetGetCompanies;
this.varLcGetUserData = varLcGetUserData;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_3c4405ea19e4fb66009c54078ab80e28> datasetGetFolioByIdReadDbAsync(RC_3c4405ea19e4fb66009c54078ab80e28 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
rec.ssENFolioStatus.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENUser_CreatedBy.Read( r, ref index);
rec.ssENUser_UpdatedBy.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" NTFACzlqEkKN7bN3ZYoS+w of Action "PreApprovalFolioDetail"
public static async Task<(RL_906cfbdbf8c03778600b870bd5d6309b,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.PreApprovalFolioDetail.GetFolioById", "0b403135-6a39-4212-8ded-b377658a12fb");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("PreApprovalFolioDetail","j_FoliosSAE.PreApprovalFolioDetail.GetFolioById");
// Query Iterations: Never
// Refresh Query JjG641YT+k2kqGFWqTL1fQ Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.JqjDpwEIzU+5X8OirPbAoQ/ScreenDataSets.NTFACzlqEkKN7bN3ZYoS+w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio110\".\"id\" o0, \"enfolio110\".\"isdraft\" o1, \"enfolio110\".\"folionumber\" o2, \"enfolio110\".\"canproveedorcancel\" o3, \"enfolio110\".\"orderid\" o4, \"enfolio110\".\"supplierid\" o5, \"enfolio110\".\"companyid\" o6, \"enfolio110\".\"foliostatusid\" o7, trim_scale(\"enfolio110\".\"totalamount\"::numeric) o8, trim_scale(\"enfolio110\".\"totaliva_amount\"::numeric) o9, trim_scale(\"enfolio110\".\"partialamount\"::numeric) o10, \"enfolio110\".\"currencyid\" o11, \"enfolio110\".\"firstapproveruserid\" o12, \"enfolio110\".\"approvalprocesstypeid\" o13, \"enfolio110\".\"sapentryerror\" o14, \"enfolio110\".\"createdby\" o15, \"enfolio110\".\"createdon\" o16, \"enfolio110\".\"updatedby\" o17, \"enfolio110\".\"updatedon\" o18, \"enfolio110\".\"minuteselected\" o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, \"enfoliostatus23\".\"id\" o50, \"enfoliostatus23\".\"label\" o51, \"enfoliostatus23\".\"class\" o52, NULL o53, NULL o54, NULL o55, \"eninvoice158\".\"id\" o56, \"eninvoice158\".\"name\" o57, \"eninvoice158\".\"requisitionid\" o58, \"eninvoice158\".\"folioid\" o59, \"eninvoice158\".\"ordermainid\" o60, \"eninvoice158\".\"cfditypeid\" o61, trim_scale(\"eninvoice158\".\"totalamount\"::numeric) o62, \"eninvoice158\".\"currency\" o63, \"eninvoice158\".\"invoicestatusid\" o64, \"eninvoice158\".\"accountingdatetime\" o65, \"eninvoice158\".\"paymentdatetime\" o66, \"eninvoice158\".\"createdon\" o67, \"eninvoice158\".\"createdby\" o68, \"eninvoice158\".\"updatedon\" o69, \"eninvoice158\".\"updatedby\" o70, \"eninvoice158\".\"submittedon\" o71, \"eninvoice158\".\"isnewversion\" o72, \"eninvoice158\".\"id_poliza\" o73, \"eninvoice158\".\"id_poliza_sap\" o74, \"eninvoice158\".\"doc51\" o75, \"eninvoice158\".\"accountingerror\" o76, \"eninvoice158\".\"orderaccconceptsid\" o77, trim_scale(\"eninvoice158\".\"amortization\"::numeric) o78, \"eninvoice158\".\"creditnoteinvoiceid\" o79, NULL o80, \"enuser_createdby2\".\"name\" o81, NULL o82, NULL o83, NULL o84, NULL o85, \"enuser_updatedby2\".\"name\" o86, NULL o87, NULL o88, NULL o89");
fromBuilder.Append(" FROM (((((({Folio} \"enfolio110\" Left JOIN {FolioStatus} \"enfoliostatus23\" ON (\"enfolio110\".\"foliostatusid\" = \"enfoliostatus23\".\"id\"))  Left JOIN {FolioApproval} \"enfolioapproval57\" ON (\"enfolio110\".\"id\" = \"enfolioapproval57\".\"folioid\"))  Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel53\" ON (\"enfolioapproval57\".\"id\" = \"enfolioapprovallevel53\".\"folioapprovalid\"))  Left JOIN {User} \"enuser_updatedby2\" ON (\"enfolio110\".\"createdby\" = \"enuser_updatedby2\".\"id\"))  Left JOIN {User} \"enuser_createdby2\" ON (\"enfolio110\".\"updatedby\" = \"enuser_createdby2\".\"id\"))  Left JOIN {Invoice} \"eninvoice158\" ON (\"enfolio110\".\"id\" = \"eninvoice158\".\"folioid\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio110\".\"id\" = @qpfoFolio_Id) AND (\"enfolio110\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio110\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (1 = 1)");
orderByBuilder.Append(" ORDER BY \"enfolioapprovallevel53\".\"levelnumber\" DESC ");
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
RL_906cfbdbf8c03778600b870bd5d6309b outParamList = new RL_906cfbdbf8c03778600b870bd5d6309b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[7];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, false, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[5] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.PreApprovalFolioDetail.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_906cfbdbf8c03778600b870bd5d6309b _tmp = new RL_906cfbdbf8c03778600b870bd5d6309b();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.PreApprovalFolioDetail.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_906cfbdbf8c03778600b870bd5d6309b)_tmp;
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

private static async Task<RC_8e32b78ccc2e260e65e10c5d6c59046d> datasetGetOrderMainsReadDbAsync(RC_8e32b78ccc2e260e65e10c5d6c59046d rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENDocumentType.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENOrderStatus.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRegion_2.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENTelcelDirection.Read( r, ref index);
return rec;
}
// Query Function "GetOrderMains" +Uz6TgZVMUOwr0cyN7i3Bg of Action "PreApprovalFolioDetail"
public static async Task<(RL_1751b6fc487a87e5015dd52d099b7396,long)> datasetGetOrderMains(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.PreApprovalFolioDetail.GetOrderMains", "4efa4cf9-5506-4331-b0af-473237b8b706");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("PreApprovalFolioDetail","j_FoliosSAE.PreApprovalFolioDetail.GetOrderMains");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.JqjDpwEIzU+5X8OirPbAoQ/ScreenDataSets.+Uz6TgZVMUOwr0cyN7i3Bg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"enordermain152\".\"id\" o18, \"enordermain152\".\"ordernumber\" o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113");
fromBuilder.Append(" FROM ((((((({OrderMain} \"enordermain152\" Inner JOIN {OrderStatus} \"enorderstatus18\" ON (\"enordermain152\".\"orderstatusid\" = \"enorderstatus18\".\"id\"))  Inner JOIN {Supplier} \"ensupplier150\" ON (\"enordermain152\".\"supplierid\" = \"ensupplier150\".\"id\"))  Inner JOIN {Company} \"encompany66\" ON (\"enordermain152\".\"companyid\" = \"encompany66\".\"id\"))  Left JOIN {DocumentType} \"endocumenttype4\" ON (\"enordermain152\".\"documenttypeid\" = \"endocumenttype4\".\"id\"))  Left JOIN {TelcelDirection} \"entelceldirection20\" ON (\"enordermain152\".\"telceldirectionid\" = \"entelceldirection20\".\"id\"))  Left JOIN {Region} \"enregion197\" ON (\"enordermain152\".\"regionid\" = \"enregion197\".\"id\"))  Left JOIN {Region} \"enregion_2\" ON (\"enordermain152\".\"divisionid\" = \"enregion_2\".\"id\")) ");
orderByBuilder.Append(" ORDER BY \"enordermain152\".\"ordernumber\" ASC ");
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
RL_1751b6fc487a87e5015dd52d099b7396 outParamList = new RL_1751b6fc487a87e5015dd52d099b7396();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderMainsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[8];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.PreApprovalFolioDetail.GetOrderMains.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1751b6fc487a87e5015dd52d099b7396 _tmp = new RL_1751b6fc487a87e5015dd52d099b7396();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderMainsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.PreApprovalFolioDetail.GetOrderMains.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1751b6fc487a87e5015dd52d099b7396)_tmp;
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

// Query Function "GetSuppliers" fkLIZI7X4EmliajTKMLlPA of Action "PreApprovalFolioDetail"
public static async Task<(RL_d5c1b2482ff109e80580d8b5fb920193,long)> datasetGetSuppliers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.PreApprovalFolioDetail.GetSuppliers", "64c8427e-d78e-49e0-a589-a8d328c2e53c");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("PreApprovalFolioDetail","j_FoliosSAE.PreApprovalFolioDetail.GetSuppliers");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.JqjDpwEIzU+5X8OirPbAoQ/ScreenDataSets.fkLIZI7X4EmliajTKMLlPA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"ensupplier151\".\"id\" o0, \"ensupplier151\".\"tratamiento\" o1, \"ensupplier151\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM {Supplier} \"ensupplier151\"");
orderByBuilder.Append(" ORDER BY \"ensupplier151\".\"tratamiento\" ASC ");
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
opt[0] = new BitArray(new bool[] {false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.PreApprovalFolioDetail.GetSuppliers.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.PreApprovalFolioDetail.GetSuppliers.List", cancellationToken: cancellationToken);
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

private static async Task<RC_e40e190961051a83f0f95a5985af6cdd> datasetGetFolioApprovalLevelsReadDbAsync(RC_e40e190961051a83f0f95a5985af6cdd rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetFolioApprovalLevels" NX04m5qfLkyvP9kb7_zg7Q of Action "PreApprovalFolioDetail"
public static async Task<(RL_a811b54d11345a2c46a0dc7830ffa1de,long)> datasetGetFolioApprovalLevels(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.PreApprovalFolioDetail.GetFolioApprovalLevels", "9b387d35-9f9a-4c2e-af3f-d91beffce0ed");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("PreApprovalFolioDetail","j_FoliosSAE.PreApprovalFolioDetail.GetFolioApprovalLevels");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.JqjDpwEIzU+5X8OirPbAoQ/ScreenDataSets.NX04m5qfLkyvP9kb7_zg7Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, \"enuser246\".\"id\" o50, \"enuser246\".\"name\" o51, \"enuser246\".\"email\" o52, \"enuser246\".\"photourl\" o53, \"enuser246\".\"username\" o54");
fromBuilder.Append(" FROM ((({Folio} \"enfolio111\" Inner JOIN {FolioApproval} \"enfolioapproval58\" ON (\"enfolio111\".\"id\" = \"enfolioapproval58\".\"folioid\"))  Inner JOIN {FolioApprovalLevel} \"enfolioapprovallevel54\" ON (\"enfolioapproval58\".\"id\" = \"enfolioapprovallevel54\".\"folioapprovalid\"))  Inner JOIN {User} \"enuser246\" ON (\"enfolioapprovallevel54\".\"assignedto\" = \"enuser246\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio111\".\"id\" = @qpfoFolio_Id) AND (\"enfolio111\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio111\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.PreApprovalFolioDetail.GetFolioApprovalLevels.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.PreApprovalFolioDetail.GetFolioApprovalLevels.List", cancellationToken: cancellationToken);
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

private static async Task<RC_95110bc97f34f4c1561c8cbf2b5015b2> datasetGetFolioItemsByFolioIdReadDbAsync(RC_95110bc97f34f4c1561c8cbf2b5015b2 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioItems.Read( r, ref index);
rec.ssENOrderMainItem.Read( r, ref index);
return rec;
}
// Query Function "GetFolioItemsByFolioId" Xrl9tvoCk0idorSYCfm0jQ of Action "PreApprovalFolioDetail"
public static async Task<(RL_a968cf9f63475dc9358672149b11245a,long)> datasetGetFolioItemsByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioItems_FolioId,string qpteTableSort,string qpteTableSort2,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.PreApprovalFolioDetail.GetFolioItemsByFolioId", "b67db95e-02fa-4893-9da2-b49809f9b48d");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("PreApprovalFolioDetail","j_FoliosSAE.PreApprovalFolioDetail.GetFolioItemsByFolioId");
// Query Iterations: Multiple
// Refresh Query wDqqXCuZ+UiukgwBCiDbFg Iterations: Multiple
// Refresh Query eZxe+2T3ekmflHUHgc3L3A Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
await using(var sqlCountCmd = trans.CreateCommand()){
string sql = "";
string sqlCount = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.JqjDpwEIzU+5X8OirPbAoQ/ScreenDataSets.Xrl9tvoCk0idorSYCfm0jQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, \"enfolioitems22\".\"ordernumber\" o23, \"enfolioitems22\".\"articlenumber\" o24, \"enfolioitems22\".\"description\" o25, \"enfolioitems22\".\"inputationcode\" o26, \"enfolioitems22\".\"deliverydate\" o27, trim_scale(\"enfolioitems22\".\"invoiceqtt\"::numeric) o28, trim_scale(\"enfolioitems22\".\"remainingqtt\"::numeric) o29, trim_scale(\"enfolioitems22\".\"unitprice\"::numeric) o30, trim_scale(\"enfolioitems22\".\"totalprice\"::numeric) o31, trim_scale(\"enfolioitems22\".\"quantity\"::numeric) o32, \"enfolioitems22\".\"deliveryqtt\" o33, \"enfolioitems22\".\"importdelivery\" o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88");
fromBuilder.Append(" FROM (({FolioItems} \"enfolioitems22\" Left JOIN {Folio} \"enfolio112\" ON (\"enfolioitems22\".\"folioid\" = \"enfolio112\".\"id\"))  Left JOIN {OrderMainItem} \"enordermainitem40\" ON (\"enfolioitems22\".\"ordermainitemid\" = \"enordermainitem40\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioItems_FolioId != 0) {
whereBuilder.Append("((\"enfolioitems22\".\"folioid\" = @qpfoFolioItems_FolioId) AND (\"enfolioitems22\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioItems_FolioId", DbType.Int64, qpfoFolioItems_FolioId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpfoFolioItems_FolioId", DbType.Int64, qpfoFolioItems_FolioId);
} else {
whereBuilder.Append("(\"enfolioitems22\".\"folioid\" IS NULL)");
}
if ((qpteTableSort2.Trim()!="") || (qpteTableSort.Trim()!="")) {
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort2, new string[] { "FolioItems", "OrderMainItem", "Folio" }, new string[] { "ENFolioItems22", "ENOrderMainItem40", "ENFolio112" }, new System.Collections.Generic.Dictionary<string, string>[] { ENFolioItemsEntity.AttributesToDatabaseNamesMap(), ENOrderMainItemEntity.AttributesToDatabaseNamesMap(), ENFolioEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "FolioItems", "OrderMainItem", "Folio" }, new string[] { "ENFolioItems22", "ENOrderMainItem40", "ENFolio112" }, new System.Collections.Generic.Dictionary<string, string>[] { ENFolioItemsEntity.AttributesToDatabaseNamesMap(), ENOrderMainItemEntity.AttributesToDatabaseNamesMap(), ENFolioEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
} else {
orderByBuilder.Append(" ORDER BY 1 ASC");
}
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
if (startIndex > 0) {
orderByBuilder.Append(" OFFSET ");
orderByBuilder.Append(startIndex);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCount = "SELECT COUNT(1) " + fromBuilder.ToString() + whereBuilder.ToString() + groupByBuilder.ToString() + havingBuilder.ToString();
sqlCount = AppUtils.Instance.ReplaceEntityReferences(requestContext, sqlCount);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
sqlCountCmd.CommandText = sqlCount;
try {
RL_a968cf9f63475dc9358672149b11245a outParamList = new RL_a968cf9f63475dc9358672149b11245a();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioItemsByFolioIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query j_FoliosSAE.PreApprovalFolioDetail.GetFolioItemsByFolioId.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.PreApprovalFolioDetail.GetFolioItemsByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a968cf9f63475dc9358672149b11245a _tmp = new RL_a968cf9f63475dc9358672149b11245a();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioItemsByFolioIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.PreApprovalFolioDetail.GetFolioItemsByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a968cf9f63475dc9358672149b11245a)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query j_FoliosSAE.PreApprovalFolioDetail.GetFolioItemsByFolioId.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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

// Query Function "GetCurrencies" hhzt5PSovU2vTTN9m8H7cw of Action "PreApprovalFolioDetail"
public static async Task<(RL_1353a59e0688582d82bbddc41b47193e,long)> datasetGetCurrencies(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.PreApprovalFolioDetail.GetCurrencies", "e4ed1c86-a8f4-4dbd-af4d-337d9bc1fb73");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("PreApprovalFolioDetail","j_FoliosSAE.PreApprovalFolioDetail.GetCurrencies");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.JqjDpwEIzU+5X8OirPbAoQ/ScreenDataSets.hhzt5PSovU2vTTN9m8H7cw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encurrency51\".\"code\" o0, \"encurrency51\".\"name\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {Currency} \"encurrency51\"");
whereBuilder.Append(" WHERE (\"encurrency51\".\"isactive\" = 1)");
orderByBuilder.Append(" ORDER BY \"encurrency51\".\"name\" ASC ");
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
RL_1353a59e0688582d82bbddc41b47193e outParamList = new RL_1353a59e0688582d82bbddc41b47193e();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.PreApprovalFolioDetail.GetCurrencies.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1353a59e0688582d82bbddc41b47193e _tmp = new RL_1353a59e0688582d82bbddc41b47193e();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.PreApprovalFolioDetail.GetCurrencies.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1353a59e0688582d82bbddc41b47193e)_tmp;
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

private static async Task<RC_06b38e19582fc855dd67cd4191332383> datasetGetCompaniesReadDbAsync(RC_06b38e19582fc855dd67cd4191332383 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_2.Read( r, ref index);
return rec;
}
// Query Function "GetCompanies" 9bhJ6LaFj0KcQd764dJJOQ of Action "PreApprovalFolioDetail"
public static async Task<(RL_1409548829f9518cbebb0e467312ef87,long)> datasetGetCompanies(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.PreApprovalFolioDetail.GetCompanies", "e849b8f5-85b6-428f-9c41-defae1d24939");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("PreApprovalFolioDetail","j_FoliosSAE.PreApprovalFolioDetail.GetCompanies");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.JqjDpwEIzU+5X8OirPbAoQ/ScreenDataSets.9bhJ6LaFj0KcQd764dJJOQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encompany67\".\"id\" o0, \"encompany67\".\"externalid\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20");
fromBuilder.Append(" FROM (({Company} \"encompany67\" Left JOIN {User} \"enuser247\" ON (\"encompany67\".\"createdby\" = \"enuser247\".\"id\"))  Left JOIN {User} \"enuser_2\" ON (\"encompany67\".\"updatedby\" = \"enuser_2\".\"id\")) ");
orderByBuilder.Append(" ORDER BY \"encompany67\".\"externalid\" ASC ");
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
RL_1409548829f9518cbebb0e467312ef87 outParamList = new RL_1409548829f9518cbebb0e467312ef87();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetCompaniesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.PreApprovalFolioDetail.GetCompanies.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1409548829f9518cbebb0e467312ef87 _tmp = new RL_1409548829f9518cbebb0e467312ef87();
_tmp.AlternateReadDbMethodAsync = datasetGetCompaniesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.PreApprovalFolioDetail.GetCompanies.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1409548829f9518cbebb0e467312ef87)_tmp;
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


    public class lcvGetUserData : VarsBag {
public Actions.lcoGetIsCxP_RequestErrorDistribution resGetIsCxP_RequestErrorDistribution =  new Actions.lcoGetIsCxP_RequestErrorDistribution();
public RL_39dfaa06ed57a2b72536c2b3070b1bce queryResGetUserDataById_outParamList = new RL_39dfaa06ed57a2b72536c2b3070b1bce();
public long queryResGetUserDataById_outParamCount = 0L;

public lcvGetUserData() {
}
}
public class lcoGetUserData : VarsBag {
public string outParamo_Region = "";

public bool outParamo_IsCXP = false;

public lcoGetUserData() {
}
}
/// <summary>
/// Action <code>GetUserData</code> that represents the Service Studio action <code>GetUserData</code>
///  <p> Description: Query to fetch User Data.</p>
/// </summary>
public async Task<(string,bool)> DataActionGetUserData(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamo_Region = default;
bool outParamo_IsCXP = default;
lcoGetUserData result = new lcoGetUserData();
lcvGetUserData localVars = new lcvGetUserData();
ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserData", "9ba7d0ad-d3e0-4f87-8adb-9506e8e5b7b2"))
using (activitySource.CreateScreenDataActionActivity("PreApprovalFolioDetail", "GetUserData")){
// Query datasetGetUserDataById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserDataById_maxRecords = 0;
int datasetGetUserDataById_startIndex = 0;(localVars.queryResGetUserDataById_outParamList,localVars.queryResGetUserDataById_outParamCount) = await FuncDataActionGetUserData.datasetGetUserDataById(requestContext,datasetGetUserDataById_maxRecords,datasetGetUserDataById_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

// GetIsCxP_RequestErrorDistribution
localVars.resGetIsCxP_RequestErrorDistribution.outParamo_IsAllowed = await Actions.ActionGetIsCxP_RequestErrorDistribution(requestContext,cancellationToken);

// o_Region = GetUserDataById.List.Current.Region.DivisionFI
result.outParamo_Region=localVars.queryResGetUserDataById_outParamList.CurrentRec.ssENRegion.ssDivisionFI;

// o_IsCXP = GetUserDataById.List.Current.EntraRole.IsAreaCxP
result.outParamo_IsCXP=localVars.queryResGetUserDataById_outParamList.CurrentRec.ssENEntraRole.ssIsAreaCxP;
} //close CreateActionActivity using block
} // try

finally {
outParamo_Region = result.outParamo_Region;
outParamo_IsCXP = result.outParamo_IsCXP;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Region,outParamo_IsCXP);
}


    public static class FuncDataActionGetUserData {

private static async Task<RC_a977e4ee3fe611d1f9a8a51587df5f57> datasetGetUserDataByIdReadDbAsync(RC_a977e4ee3fe611d1f9a8a51587df5f57 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetUserDataById" sIMHOzKUbk+bC_+NfUTSYA of Action "GetUserData"
public static async Task<(RL_39dfaa06ed57a2b72536c2b3070b1bce,long)> datasetGetUserDataById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Extended_Internal_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.PreApprovalFolioDetail.GetUserData.GetUserDataById", "3b0783b0-9432-4f6e-9b0b-ff8d7d44d260");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.PreApprovalFolioDetail.GetUserData.GetUserDataById", "3b0783b0-9432-4f6e-9b0b-ff8d7d44d260", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.JqjDpwEIzU+5X8OirPbAoQ/DataActions.rdCnm+DTh0+K25UG6OW3sg/NodesNotShownInESpaceTree.sIMHOzKUbk+bC_+NfUTSYA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"enentrarole89\".\"isareacxp\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38");
fromBuilder.Append(" FROM (({User_Extended_Internal} \"enuser_extended_internal144\" Inner JOIN {Region} \"enregion198\" ON (\"enuser_extended_internal144\".\"regionid\" = \"enregion198\".\"id\"))  Left JOIN {EntraRole} \"enentrarole89\" ON (\"enuser_extended_internal144\".\"entraroleid\" = \"enentrarole89\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Extended_Internal_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser_extended_internal144\".\"id\" = @qpusUser_Extended_Internal_Id) AND (\"enuser_extended_internal144\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Extended_Internal_Id", DbType.String, qpusUser_Extended_Internal_Id);
} else {
whereBuilder.Append("(\"enuser_extended_internal144\".\"id\" IS NULL)");
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
RL_39dfaa06ed57a2b72536c2b3070b1bce outParamList = new RL_39dfaa06ed57a2b72536c2b3070b1bce();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserDataByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.PreApprovalFolioDetail.GetUserData.GetUserDataById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_39dfaa06ed57a2b72536c2b3070b1bce _tmp = new RL_39dfaa06ed57a2b72536c2b3070b1bce();
_tmp.AlternateReadDbMethodAsync = datasetGetUserDataByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.PreApprovalFolioDetail.GetUserData.GetUserDataById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_39dfaa06ed57a2b72536c2b3070b1bce)_tmp;
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
