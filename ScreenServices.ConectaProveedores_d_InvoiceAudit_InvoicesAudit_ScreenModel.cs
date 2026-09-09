using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_d_InvoiceAudit_InvoicesAudit_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_d_InvoiceAudit_InvoicesAudit_ScreenModel).Namespace);

    public bool varLcHasSearched;
public string varLcInvoiceName;
public ConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetUserRegion_Model varLcGetUserRegion;
public ConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetInvoice_Model varLcGetInvoice;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_d_InvoiceAudit_InvoicesAudit_ScreenModel() {
}



    public ConectaProveedores_d_InvoiceAudit_InvoicesAudit_ScreenModel(bool varLcHasSearched, string varLcInvoiceName, ConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetUserRegion_Model varLcGetUserRegion, ConectaProveedores_d_InvoiceAudit_InvoicesAudit_DataActionGetInvoice_Model varLcGetInvoice, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"HasSearched", "InvoiceName", "GetUserRegion", "GetInvoice", "ClientVars"}, new string[] {"varLcHasSearched", "varLcInvoiceName", "varLcGetUserRegion", "varLcGetInvoice", "clientVariables"});
this.varLcHasSearched = varLcHasSearched;
this.varLcInvoiceName = varLcInvoiceName;
this.varLcGetUserRegion = varLcGetUserRegion;
this.varLcGetInvoice = varLcGetInvoice;
this.clientVariables = clientVariables;
}



    

    public class lcvGetUserRegion : VarsBag {
public Actions.lcoGetUserRegionId resGetUserLoggedRegion =  new Actions.lcoGetUserRegionId();
public RL_5d3a02aa993c7474297e33d992f39ad0 queryResGetRegionCorp_outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
public long queryResGetRegionCorp_outParamCount = 0L;

public lcvGetUserRegion() {
}
}
public class lcoGetUserRegion : VarsBag {
public long outParamRegionId = 0L;

public bool outParamIsCorp = false;

public lcoGetUserRegion() {
}
}
/// <summary>
/// Action <code>GetUserRegion</code> that represents the Service Studio action
///  <code>GetUserRegion</code> <p> Description: </p>
/// </summary>
public async Task<(long,bool)> DataActionGetUserRegion(IRequestContext requestContext,CancellationToken cancellationToken) {
long outParamRegionId = default;
bool outParamIsCorp = default;
lcoGetUserRegion result = new lcoGetUserRegion();
lcvGetUserRegion localVars = new lcvGetUserRegion();
ConectaProveedores_d_InvoiceAudit_InvoicesAudit_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserRegion", "65990cb4-e368-4ca9-b462-e1e8bc6f49a6"))
using (activitySource.CreateScreenDataActionActivity("InvoicesAudit", "GetUserRegion")){
// GetUserLoggedRegion
localVars.resGetUserLoggedRegion.outParamo_RegionId = await Actions.ActionGetUserRegionId(requestContext,"",cancellationToken);

// Query datasetGetRegionCorp
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRegionCorp_maxRecords = 1;
if (datasetGetRegionCorp_maxRecords < 1) datasetGetRegionCorp_maxRecords = 1;
int datasetGetRegionCorp_startIndex = 0;(localVars.queryResGetRegionCorp_outParamList,localVars.queryResGetRegionCorp_outParamCount) = await FuncDataActionGetUserRegion.datasetGetRegionCorp(requestContext,datasetGetRegionCorp_maxRecords,datasetGetRegionCorp_startIndex,IterationMultiplicity.Never,cancellationToken);

// RegionId = GetUserLoggedRegion.o_RegionId
result.outParamRegionId=localVars.resGetUserLoggedRegion.outParamo_RegionId;

// IsCorp = GetUserLoggedRegion.o_RegionId = GetRegionCorp.List.Current.Region.Id
result.outParamIsCorp=(localVars.resGetUserLoggedRegion.outParamo_RegionId==localVars.queryResGetRegionCorp_outParamList.CurrentRec.ssENRegion.ssId);
} //close CreateActionActivity using block
} // try

finally {
outParamRegionId = result.outParamRegionId;
outParamIsCorp = result.outParamIsCorp;
} // inner-finally
RETURN_STATEMENT:
return (outParamRegionId,outParamIsCorp);
}
public class lcvGetInvoice : VarsBag {
/// <summary>
/// Variable <code>EmptyRecord</code> that represents the Service Studio InvoiceInvoiceStatusRecord
///  <code>EmptyRecord</code> <p>Description: </p>
/// </summary>
public RC_cad676a01e44d775889bfdee9f2eda1f varLcEmptyRecord = new RC_cad676a01e44d775889bfdee9f2eda1f();

/// <summary>
/// Variable <code>EmptyRegion</code> that represents the Service Studio Region
///  <code>EmptyRegion</code> <p>Description: </p>
/// </summary>
public EN_31f501c551d210017fcb34b5237e3390EntityRecord varLcEmptyRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();

/// <summary>
/// Variable <code>EmptySupplier</code> that represents the Service Studio Supplier
///  <code>EmptySupplier</code> <p>Description: </p>
/// </summary>
public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord varLcEmptySupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();

public RL_a5d34dadc1b2a091bffaa2b834b2d48d queryResGetOrderMainById_outParamList = new RL_a5d34dadc1b2a091bffaa2b834b2d48d();
public long queryResGetOrderMainById_outParamCount = 0L;

public RL_06da8a08cec85e816e2153470a02256e queryResGetFolioById_outParamList = new RL_06da8a08cec85e816e2153470a02256e();
public long queryResGetFolioById_outParamCount = 0L;

public RL_fb447cbe50933c4990bdca146fda9078 queryResGetRequisitionById_outParamList = new RL_fb447cbe50933c4990bdca146fda9078();
public long queryResGetRequisitionById_outParamCount = 0L;

public RL_4c91727910427c345e342c96f50fbfbf queryResGetInvoiceByInvoiceName_outParamList = new RL_4c91727910427c345e342c96f50fbfbf();
public long queryResGetInvoiceByInvoiceName_outParamCount = 0L;

public lcvGetInvoice() {
}
}
public class lcoGetInvoice : VarsBag {
public RC_cad676a01e44d775889bfdee9f2eda1f outParamInvoiceRecord = new RC_cad676a01e44d775889bfdee9f2eda1f();

public bool outParamHasDifferentRegions = false;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord outParamRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord outParamSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();

public lcoGetInvoice() {
}
}
/// <summary>
/// Action <code>GetInvoice</code> that represents the Service Studio action <code>GetInvoice</code>
///  <p> Description: </p>
/// </summary>
public async Task<(RC_cad676a01e44d775889bfdee9f2eda1f,bool,EN_31f501c551d210017fcb34b5237e3390EntityRecord,EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)> DataActionGetInvoice(IRequestContext requestContext,CancellationToken cancellationToken) {
RC_cad676a01e44d775889bfdee9f2eda1f outParamInvoiceRecord = default;
bool outParamHasDifferentRegions = default;
EN_31f501c551d210017fcb34b5237e3390EntityRecord outParamRegion = default;
EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord outParamSupplier = default;
lcoGetInvoice result = new lcoGetInvoice();
lcvGetInvoice localVars = new lcvGetInvoice();
ConectaProveedores_d_InvoiceAudit_InvoicesAudit_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetInvoice", "eb312572-7af0-4393-9f5f-5a91406589c1"))
using (activitySource.CreateScreenDataActionActivity("InvoicesAudit", "GetInvoice")){
// Query datasetGetInvoiceByInvoiceName
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceByInvoiceName_maxRecords = 1;
if (datasetGetInvoiceByInvoiceName_maxRecords < 1) datasetGetInvoiceByInvoiceName_maxRecords = 1;
int datasetGetInvoiceByInvoiceName_startIndex = 0;(localVars.queryResGetInvoiceByInvoiceName_outParamList,localVars.queryResGetInvoiceByInvoiceName_outParamCount) = await FuncDataActionGetInvoice.datasetGetInvoiceByInvoiceName(requestContext,datasetGetInvoiceByInvoiceName_maxRecords,datasetGetInvoiceByInvoiceName_startIndex,IterationMultiplicity.Never,varLcInvoiceName,cancellationToken);

if(((localVars.queryResGetInvoiceByInvoiceName_outParamList.CurrentRec.ssENInvoice.ssRequisitionId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Query datasetGetRequisitionById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionById_maxRecords = 1;
if (datasetGetRequisitionById_maxRecords < 1) datasetGetRequisitionById_maxRecords = 1;
int datasetGetRequisitionById_startIndex = 0;(localVars.queryResGetRequisitionById_outParamList,localVars.queryResGetRequisitionById_outParamCount) = await FuncDataActionGetInvoice.datasetGetRequisitionById(requestContext,datasetGetRequisitionById_maxRecords,datasetGetRequisitionById_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceByInvoiceName_outParamList.CurrentRec.ssENInvoice.ssRequisitionId,cancellationToken);

// Region = GetRequisitionById.List.Current.Region
result.outParamRegion=localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENRegion;

// Supplier = GetRequisitionById.List.Current.Supplier
result.outParamSupplier=localVars.queryResGetRequisitionById_outParamList.CurrentRec.ssENSupplier;
} else {
if((localVars.queryResGetInvoiceByInvoiceName_outParamList.CurrentRec.ssENInvoice.ssOrderMainId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) {
// Query datasetGetOrderMainById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainById_maxRecords = 1;
if (datasetGetOrderMainById_maxRecords < 1) datasetGetOrderMainById_maxRecords = 1;
int datasetGetOrderMainById_startIndex = 0;(localVars.queryResGetOrderMainById_outParamList,localVars.queryResGetOrderMainById_outParamCount) = await FuncDataActionGetInvoice.datasetGetOrderMainById(requestContext,datasetGetOrderMainById_maxRecords,datasetGetOrderMainById_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceByInvoiceName_outParamList.CurrentRec.ssENInvoice.ssOrderMainId,cancellationToken);

// Region = GetOrderMainById.List.Current.Region
result.outParamRegion=localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENRegion;

// Supplier = GetOrderMainById.List.Current.Supplier
result.outParamSupplier=localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENSupplier;
} else {
if((localVars.queryResGetInvoiceByInvoiceName_outParamList.CurrentRec.ssENInvoice.ssFolioId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) {
// Query datasetGetFolioById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioById_maxRecords = 0;
int datasetGetFolioById_startIndex = 0;(localVars.queryResGetFolioById_outParamList,localVars.queryResGetFolioById_outParamCount) = await FuncDataActionGetInvoice.datasetGetFolioById(requestContext,datasetGetFolioById_maxRecords,datasetGetFolioById_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceByInvoiceName_outParamList.CurrentRec.ssENInvoice.ssFolioId,cancellationToken);

// Region = GetFolioById.List.Current.Region
result.outParamRegion=localVars.queryResGetFolioById_outParamList.CurrentRec.ssENRegion;

// Supplier = GetFolioById.List.Current.Supplier
result.outParamSupplier=localVars.queryResGetFolioById_outParamList.CurrentRec.ssENSupplier;
} else {
goto RETURN_STATEMENT;

}

}

}

// empty?
if(((localVars.queryResGetInvoiceByInvoiceName_outParamList.Empty||((result.outParamRegion.ssId!=varLcGetUserRegion.outParamRegionId)&&(!varLcGetUserRegion.outParamIsCorp))))) {
// InvoiceRecord = EmptyRecord
result.outParamInvoiceRecord=localVars.varLcEmptyRecord;

// HasDifferentRegions = Region.Id = GetUserRegion.RegionId
result.outParamHasDifferentRegions=(result.outParamRegion.ssId==varLcGetUserRegion.outParamRegionId);

// Region = EmptyRegion
result.outParamRegion=localVars.varLcEmptyRegion;

// Supplier = EmptySupplier
result.outParamSupplier=localVars.varLcEmptySupplier;
} else {
// InvoiceRecord = GetInvoiceByInvoiceName.List.Current
result.outParamInvoiceRecord=localVars.queryResGetInvoiceByInvoiceName_outParamList.CurrentRec;

// HasDifferentRegions = False
result.outParamHasDifferentRegions=false;
}

} //close CreateActionActivity using block
} // try

finally {
outParamInvoiceRecord = result.outParamInvoiceRecord;
outParamHasDifferentRegions = result.outParamHasDifferentRegions;
outParamRegion = result.outParamRegion;
outParamSupplier = result.outParamSupplier;
} // inner-finally
RETURN_STATEMENT:
return (outParamInvoiceRecord,outParamHasDifferentRegions,outParamRegion,outParamSupplier);
}


    public static class FuncDataActionGetUserRegion {

// Query Function "GetRegionCorp" KA1R_+yq0Uani7j_OcZ_bA of Action "GetUserRegion"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegionCorp(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_InvoiceAudit.InvoicesAudit.GetUserRegion.GetRegionCorp", "ff510d28-aaec-46d1-a78b-b8ff39c67f6c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_InvoiceAudit.InvoicesAudit.GetUserRegion.GetRegionCorp", "ff510d28-aaec-46d1-a78b-b8ff39c67f6c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.QghyiWtm3kyZz6m9v9fCNw/NodesShownInESpaceTree.8Ep9oIout0WR+I2YvcPh1g/DataActions.tAyZZWjjqUy0YuHovG9Jpg/NodesNotShownInESpaceTree.KA1R_+yq0Uani7j_OcZ_bA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enregion156\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion156\"");
whereBuilder.Append(" WHERE (\"enregion156\".\"isactive\" = 1) AND (\"enregion156\".\"centrortp\" = 'MX00')");
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
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_InvoiceAudit.InvoicesAudit.GetUserRegion.GetRegionCorp.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_InvoiceAudit.InvoicesAudit.GetUserRegion.GetRegionCorp.List", cancellationToken: cancellationToken);
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
}
public static class FuncDataActionGetInvoice {

private static async Task<RC_5ad46beda6daded312a458bcd914266d> datasetGetOrderMainByIdReadDbAsync(RC_5ad46beda6daded312a458bcd914266d rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetOrderMainById" ZkNRHd0+PkKtsMaSitmUew of Action "GetInvoice"
public static async Task<(RL_a5d34dadc1b2a091bffaa2b834b2d48d,long)> datasetGetOrderMainById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_InvoiceAudit.InvoicesAudit.GetInvoice.GetOrderMainById", "1d514366-3edd-423e-adb0-c6928ad9947b");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_InvoiceAudit.InvoicesAudit.GetInvoice.GetOrderMainById", "1d514366-3edd-423e-adb0-c6928ad9947b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.QghyiWtm3kyZz6m9v9fCNw/NodesShownInESpaceTree.8Ep9oIout0WR+I2YvcPh1g/DataActions.ciUx6_B6k0OfX1qRQGWJwQ/NodesNotShownInESpaceTree.ZkNRHd0+PkKtsMaSitmUew, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, \"enregion157\".\"id\" o29, \"enregion157\".\"code\" o30, NULL o31, \"enregion157\".\"divisionfi\" o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, \"ensupplier123\".\"name\" o44, \"ensupplier123\".\"number\" o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, \"ensupplier123\".\"n_ident_fis_1\" o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69");
fromBuilder.Append(" FROM (({OrderMain} \"enordermain115\" Inner JOIN {Supplier} \"ensupplier123\" ON (\"enordermain115\".\"supplierid\" = \"ensupplier123\".\"id\"))  Left JOIN {Region} \"enregion157\" ON (\"enordermain115\".\"regionid\" = \"enregion157\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain115\".\"id\" = @qporOrderMain_Id) AND (\"enordermain115\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain115\".\"id\" IS NULL)");
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
RL_a5d34dadc1b2a091bffaa2b834b2d48d outParamList = new RL_a5d34dadc1b2a091bffaa2b834b2d48d();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderMainByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_InvoiceAudit.InvoicesAudit.GetInvoice.GetOrderMainById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a5d34dadc1b2a091bffaa2b834b2d48d _tmp = new RL_a5d34dadc1b2a091bffaa2b834b2d48d();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderMainByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_InvoiceAudit.InvoicesAudit.GetInvoice.GetOrderMainById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a5d34dadc1b2a091bffaa2b834b2d48d)_tmp;
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

private static async Task<RC_428141695aee6b3458a97f3fa044a69e> datasetGetFolioByIdReadDbAsync(RC_428141695aee6b3458a97f3fa044a69e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" fiMpNdRHUkidHVlv6eMZqg of Action "GetInvoice"
public static async Task<(RL_06da8a08cec85e816e2153470a02256e,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_InvoiceAudit.InvoicesAudit.GetInvoice.GetFolioById", "3529237e-47d4-4852-9d1d-596fe9e319aa");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_InvoiceAudit.InvoicesAudit.GetInvoice.GetFolioById", "3529237e-47d4-4852-9d1d-596fe9e319aa", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.QghyiWtm3kyZz6m9v9fCNw/NodesShownInESpaceTree.8Ep9oIout0WR+I2YvcPh1g/DataActions.ciUx6_B6k0OfX1qRQGWJwQ/NodesNotShownInESpaceTree.fiMpNdRHUkidHVlv6eMZqg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, \"enregion158\".\"id\" o49, \"enregion158\".\"code\" o50, NULL o51, \"enregion158\".\"divisionfi\" o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, \"ensupplier124\".\"name\" o64, \"ensupplier124\".\"number\" o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, \"ensupplier124\".\"n_ident_fis_1\" o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89");
fromBuilder.Append(" FROM ((({Folio} \"enfolio75\" Left JOIN {OrderMain} \"enordermain116\" ON (\"enfolio75\".\"orderid\" = \"enordermain116\".\"id\"))  Left JOIN {Region} \"enregion158\" ON (\"enordermain116\".\"regionid\" = \"enregion158\".\"id\"))  Left JOIN {Supplier} \"ensupplier124\" ON (\"enfolio75\".\"supplierid\" = \"ensupplier124\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio75\".\"id\" = @qpfoFolio_Id) AND (\"enfolio75\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio75\".\"id\" IS NULL)");
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
RL_06da8a08cec85e816e2153470a02256e outParamList = new RL_06da8a08cec85e816e2153470a02256e();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {false, false, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_InvoiceAudit.InvoicesAudit.GetInvoice.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_06da8a08cec85e816e2153470a02256e _tmp = new RL_06da8a08cec85e816e2153470a02256e();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_InvoiceAudit.InvoicesAudit.GetInvoice.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_06da8a08cec85e816e2153470a02256e)_tmp;
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

private static async Task<RC_9b8bde366f0fe61cf64fff2adf2f6e88> datasetGetRequisitionByIdReadDbAsync(RC_9b8bde366f0fe61cf64fff2adf2f6e88 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionById" d9eXvGQdV0aPq+HqB6LDDA of Action "GetInvoice"
public static async Task<(RL_fb447cbe50933c4990bdca146fda9078,long)> datasetGetRequisitionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_InvoiceAudit.InvoicesAudit.GetInvoice.GetRequisitionById", "bc97d777-1d64-4657-8fab-e1ea07a2c30c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_InvoiceAudit.InvoicesAudit.GetInvoice.GetRequisitionById", "bc97d777-1d64-4657-8fab-e1ea07a2c30c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.QghyiWtm3kyZz6m9v9fCNw/NodesShownInESpaceTree.8Ep9oIout0WR+I2YvcPh1g/DataActions.ciUx6_B6k0OfX1qRQGWJwQ/NodesNotShownInESpaceTree.d9eXvGQdV0aPq+HqB6LDDA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enregion159\".\"id\" o0, \"enregion159\".\"code\" o1, NULL o2, \"enregion159\".\"divisionfi\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, \"ensupplier125\".\"name\" o73, \"ensupplier125\".\"number\" o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, \"ensupplier125\".\"n_ident_fis_1\" o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98");
fromBuilder.Append(" FROM (({Requisition} \"enrequisition123\" Left JOIN {Region} \"enregion159\" ON (\"enrequisition123\".\"regionid\" = \"enregion159\".\"id\"))  Left JOIN {Supplier} \"ensupplier125\" ON (\"enrequisition123\".\"supplierid\" = \"ensupplier125\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition123\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition123\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition123\".\"id\" IS NULL)");
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
RL_fb447cbe50933c4990bdca146fda9078 outParamList = new RL_fb447cbe50933c4990bdca146fda9078();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_InvoiceAudit.InvoicesAudit.GetInvoice.GetRequisitionById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_fb447cbe50933c4990bdca146fda9078 _tmp = new RL_fb447cbe50933c4990bdca146fda9078();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_InvoiceAudit.InvoicesAudit.GetInvoice.GetRequisitionById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_fb447cbe50933c4990bdca146fda9078)_tmp;
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

private static async Task<RC_cad676a01e44d775889bfdee9f2eda1f> datasetGetInvoiceByInvoiceNameReadDbAsync(RC_cad676a01e44d775889bfdee9f2eda1f rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceStatus.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceByInvoiceName" mTWm3PcBP06w20qTw70xJQ of Action "GetInvoice"
public static async Task<(RL_4c91727910427c345e342c96f50fbfbf,long)> datasetGetInvoiceByInvoiceName(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteInvoice_Name,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_InvoiceAudit.InvoicesAudit.GetInvoice.GetInvoiceByInvoiceName", "dca63599-01f7-4e3f-b0db-4a93c3bd3125");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_InvoiceAudit.InvoicesAudit.GetInvoice.GetInvoiceByInvoiceName", "dca63599-01f7-4e3f-b0db-4a93c3bd3125", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.QghyiWtm3kyZz6m9v9fCNw/NodesShownInESpaceTree.8Ep9oIout0WR+I2YvcPh1g/DataActions.ciUx6_B6k0OfX1qRQGWJwQ/NodesNotShownInESpaceTree.mTWm3PcBP06w20qTw70xJQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice140\".\"id\" o0, \"eninvoice140\".\"name\" o1, \"eninvoice140\".\"requisitionid\" o2, \"eninvoice140\".\"folioid\" o3, \"eninvoice140\".\"ordermainid\" o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, \"eninvoicestatus18\".\"label\" o25, \"eninvoicestatus18\".\"class\" o26, NULL o27, NULL o28, NULL o29, NULL o30");
fromBuilder.Append(" FROM ({Invoice} \"eninvoice140\" Left JOIN {InvoiceStatus} \"eninvoicestatus18\" ON (\"eninvoice140\".\"invoicestatusid\" = \"eninvoicestatus18\".\"id\")) ");
whereBuilder.Append(" WHERE (\"eninvoice140\".\"name\" = @qpteInvoice_Name)");
sqlCmd.CreateParameterWithoutReplacements("@qpteInvoice_Name", DbType.String, qpteInvoice_Name);
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
RL_4c91727910427c345e342c96f50fbfbf outParamList = new RL_4c91727910427c345e342c96f50fbfbf();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceByInvoiceNameReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_InvoiceAudit.InvoicesAudit.GetInvoice.GetInvoiceByInvoiceName.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4c91727910427c345e342c96f50fbfbf _tmp = new RL_4c91727910427c345e342c96f50fbfbf();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceByInvoiceNameReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_InvoiceAudit.InvoicesAudit.GetInvoice.GetInvoiceByInvoiceName.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4c91727910427c345e342c96f50fbfbf)_tmp;
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
