using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_EditFolioSAE_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_EditFolioSAE_ScreenModel).Namespace);

    public long inParamFolioId;
public int varLcl_Step;
public long varLcl_OrderIdSelected;
public bool varLcIsSelected;
public RL_123aa03224ec08dab8cbe26021987012 varLcLocalSelectedLines;
public bool varLcl_IsSelectAll;
public bool varLcl_IsShowSelectAll;
public string varLcl_OrderIdNumberSelected;
public bool varLcShowPopup;
public AggregateRecord<RL_d93cbaf98e8c7bf91c01ba8ed183bc42> ScreenDataSetGetFolioById;
public AggregateRecord<RL_a968cf9f63475dc9358672149b11245a> ScreenDataSetGetFolioItemsByFolioId;
public ConectaProveedores_j_FoliosSAE_EditFolioSAE_DataActionGetOrderMainItems_Model varLcGetOrderMainItems;
public ConectaProveedores_j_FoliosSAE_EditFolioSAE_DataActionGetSettings_Model varLcGetSettings;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_EditFolioSAE_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_EditFolioSAE_ScreenModel(long inParamFolioId, int varLcl_Step, long varLcl_OrderIdSelected, bool varLcIsSelected, RL_123aa03224ec08dab8cbe26021987012 varLcLocalSelectedLines, bool varLcl_IsSelectAll, bool varLcl_IsShowSelectAll, string varLcl_OrderIdNumberSelected, bool varLcShowPopup, AggregateRecord<RL_d93cbaf98e8c7bf91c01ba8ed183bc42> ScreenDataSetGetFolioById, AggregateRecord<RL_a968cf9f63475dc9358672149b11245a> ScreenDataSetGetFolioItemsByFolioId, ConectaProveedores_j_FoliosSAE_EditFolioSAE_DataActionGetOrderMainItems_Model varLcGetOrderMainItems, ConectaProveedores_j_FoliosSAE_EditFolioSAE_DataActionGetSettings_Model varLcGetSettings, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"FolioId", "l_Step", "l_OrderIdSelected", "IsSelected", "LocalSelectedLines", "l_IsSelectAll", "l_IsShowSelectAll", "l_OrderIdNumberSelected", "ShowPopup", "GetFolioById", "GetFolioItemsByFolioId", "GetOrderMainItems", "GetSettings", "ClientVars"}, new string[] {"inParamFolioId", "varLcl_Step", "varLcl_OrderIdSelected", "varLcIsSelected", "varLcLocalSelectedLines", "varLcl_IsSelectAll", "varLcl_IsShowSelectAll", "varLcl_OrderIdNumberSelected", "varLcShowPopup", "ScreenDataSetGetFolioById", "ScreenDataSetGetFolioItemsByFolioId", "varLcGetOrderMainItems", "varLcGetSettings", "clientVariables"});
this.inParamFolioId = inParamFolioId;
this.varLcl_Step = varLcl_Step;
this.varLcl_OrderIdSelected = varLcl_OrderIdSelected;
this.varLcIsSelected = varLcIsSelected;
this.varLcLocalSelectedLines = varLcLocalSelectedLines;
this.varLcl_IsSelectAll = varLcl_IsSelectAll;
this.varLcl_IsShowSelectAll = varLcl_IsShowSelectAll;
this.varLcl_OrderIdNumberSelected = varLcl_OrderIdNumberSelected;
this.varLcShowPopup = varLcShowPopup;
this.ScreenDataSetGetFolioById = ScreenDataSetGetFolioById;
this.ScreenDataSetGetFolioItemsByFolioId = ScreenDataSetGetFolioItemsByFolioId;
this.varLcGetOrderMainItems = varLcGetOrderMainItems;
this.varLcGetSettings = varLcGetSettings;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_d80dcf5f9effb79b8ba59dd1971d484d> datasetGetFolioByIdReadDbAsync(RC_d80dcf5f9effb79b8ba59dd1971d484d rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetFolioById" UCzkUe7PwU2gm9xrAeIFkg of Action "EditFolioSAE"
public static async Task<(RL_d93cbaf98e8c7bf91c01ba8ed183bc42,long)> datasetGetFolioById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.EditFolioSAE.GetFolioById", "51e42c50-cfee-4dc1-a09b-dc6b01e20592");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("EditFolioSAE","j_FoliosSAE.EditFolioSAE.GetFolioById");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.IMXYGTodXkKdMIa8Cz5pHw/ScreenDataSets.UCzkUe7PwU2gm9xrAeIFkg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enfolio81\".\"folionumber\" o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enfolio81\".\"foliostatusid\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, \"enfolio81\".\"approvalprocesstypeid\" o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, \"enordermain124\".\"id\" o20, \"enordermain124\".\"ordernumber\" o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48");
fromBuilder.Append(" FROM ({Folio} \"enfolio81\" Left JOIN {OrderMain} \"enordermain124\" ON (\"enfolio81\".\"orderid\" = \"enordermain124\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio81\".\"id\" = @qpfoFolio_Id) AND (\"enfolio81\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio81\".\"id\" IS NULL)");
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
RL_d93cbaf98e8c7bf91c01ba8ed183bc42 outParamList = new RL_d93cbaf98e8c7bf91c01ba8ed183bc42();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, false, true, true, true, true, false, true, true, true, true, true, false, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.EditFolioSAE.GetFolioById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d93cbaf98e8c7bf91c01ba8ed183bc42 _tmp = new RL_d93cbaf98e8c7bf91c01ba8ed183bc42();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.EditFolioSAE.GetFolioById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d93cbaf98e8c7bf91c01ba8ed183bc42)_tmp;
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
// Query Function "GetFolioItemsByFolioId" HbvSlAQpXkiirjv71bjnng of Action "EditFolioSAE"
public static async Task<(RL_a968cf9f63475dc9358672149b11245a,long)> datasetGetFolioItemsByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioItems_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.EditFolioSAE.GetFolioItemsByFolioId", "94d2bb1d-2904-485e-a2ae-3bfbd5b8e79e");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("EditFolioSAE","j_FoliosSAE.EditFolioSAE.GetFolioItemsByFolioId");
// Query Iterations: Multiple
// Refresh Query LrryHRJ7dUOWaqvj1TeKwQ Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.IMXYGTodXkKdMIa8Cz5pHw/ScreenDataSets.HbvSlAQpXkiirjv71bjnng, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, \"enfolioitems12\".\"ordermainitemid\" o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88");
fromBuilder.Append(" FROM (({FolioItems} \"enfolioitems12\" Inner JOIN {OrderMainItem} \"enordermainitem27\" ON (\"enfolioitems12\".\"ordermainitemid\" = \"enordermainitem27\".\"id\"))  Left JOIN {Folio} \"enfolio82\" ON (\"enfolioitems12\".\"folioid\" = \"enfolio82\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioItems_FolioId != 0) {
whereBuilder.Append("((\"enfolioitems12\".\"folioid\" = @qpfoFolioItems_FolioId) AND (\"enfolioitems12\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioItems_FolioId", DbType.Int64, qpfoFolioItems_FolioId);
} else {
whereBuilder.Append("(\"enfolioitems12\".\"folioid\" IS NULL)");
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
RL_a968cf9f63475dc9358672149b11245a outParamList = new RL_a968cf9f63475dc9358672149b11245a();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioItemsByFolioIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.EditFolioSAE.GetFolioItemsByFolioId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.EditFolioSAE.GetFolioItemsByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a968cf9f63475dc9358672149b11245a)_tmp;
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


    public class lcvGetOrderMainItems : VarsBag {
public RL_bab3397f952f07af0f0aa229e6f2b36e queryResGetOrdersItems_outParamList = new RL_bab3397f952f07af0f0aa229e6f2b36e();
public long queryResGetOrdersItems_outParamCount = 0L;

public lcvGetOrderMainItems() {
}
}
public class lcoGetOrderMainItems : VarsBag {
public RL_4e1292c876d12cf32f3c04367498157e outParamList = new RL_4e1292c876d12cf32f3c04367498157e();

public lcoGetOrderMainItems() {
}
}
/// <summary>
/// Action <code>GetOrderMainItems</code> that represents the Service Studio action
///  <code>GetOrderMainItems</code> <p> Description: </p>
/// </summary>
public async Task<RL_4e1292c876d12cf32f3c04367498157e> DataActionGetOrderMainItems(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_4e1292c876d12cf32f3c04367498157e outParamList = default;
lcoGetOrderMainItems result = new lcoGetOrderMainItems();
lcvGetOrderMainItems localVars = new lcvGetOrderMainItems();
ConectaProveedores_j_FoliosSAE_EditFolioSAE_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetOrderMainItems", "01ae4064-6f99-4e6c-a8db-f25301335a29"))
using (activitySource.CreateScreenDataActionActivity("EditFolioSAE", "GetOrderMainItems")){
// Query QueryGetOrdersItems
cancellationToken.ThrowIfCancellationRequested();
int QueryGetOrdersItems_maxRecords = 999999999;
if (QueryGetOrdersItems_maxRecords < 1) QueryGetOrdersItems_maxRecords = 1;
int QueryGetOrdersItems_startIndex = 0;(localVars.queryResGetOrdersItems_outParamList,localVars.queryResGetOrdersItems_outParamCount) = await FuncDataActionGetOrderMainItems.QueryGetOrdersItems(requestContext,QueryGetOrdersItems_maxRecords,QueryGetOrdersItems_startIndex,IterationMultiplicity.Multiple,varLcl_OrderIdSelected,(ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId,(ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("l5OG661dZEe+gAZwnNLhSA"))).ssId,inParamFolioId,cancellationToken);

// List = GetOrdersItems.List
result.outParamList=(await RL_4e1292c876d12cf32f3c04367498157e.ConvertAsync(localVars.queryResGetOrdersItems_outParamList, new RL_4e1292c876d12cf32f3c04367498157e(), async (RC_447a4f014542f360a86edbc89025680b source, ST_1bddfac19e9b0cef65924aa7568fd106Structure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamList = result.outParamList;
} // inner-finally
RETURN_STATEMENT:
return outParamList;
}
public class lcvGetSettings : VarsBag {
public Actions.lcoGetSettingsMargins resGetSettingsMargins =  new Actions.lcoGetSettingsMargins();
public lcvGetSettings() {
}
}
public class lcoGetSettings : VarsBag {
public bool outParamIsActiveAmountValidation = false;

public bool outParamIsForceForeigner = false;

public decimal outParamo_ForeignCurrencyMargin = (((decimal)10));

public decimal outParamo_NationalCurrencyMargin = (((decimal)10));

public bool outParamo_IsActiveDEV_HU13008_Complement = false;

public bool outParamo_IsActiveDEV_HU13046 = false;

public bool outParamo_IsActiveDEV_NumeroDeFolioVisible = false;

public lcoGetSettings() {
}
}
/// <summary>
/// Action <code>GetSettings</code> that represents the Service Studio action <code>GetSettings</code>
///  <p> Description: </p>
/// </summary>
public async Task<(bool,bool,decimal,decimal,bool,bool,bool)> DataActionGetSettings(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamIsActiveAmountValidation = default;
bool outParamIsForceForeigner = default;
decimal outParamo_ForeignCurrencyMargin = default;
decimal outParamo_NationalCurrencyMargin = default;
bool outParamo_IsActiveDEV_HU13008_Complement = default;
bool outParamo_IsActiveDEV_HU13046 = default;
bool outParamo_IsActiveDEV_NumeroDeFolioVisible = default;
lcoGetSettings result = new lcoGetSettings();
lcvGetSettings localVars = new lcvGetSettings();
ConectaProveedores_j_FoliosSAE_EditFolioSAE_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSettings", "8e704df4-eeba-4dc6-a6b5-d5bf339cbb0f"))
using (activitySource.CreateScreenDataActionActivity("EditFolioSAE", "GetSettings")){
// GetSettingsMargins
(localVars.resGetSettingsMargins.outParamNationalMargin,localVars.resGetSettingsMargins.outParamForeignMargin) = await Actions.ActionGetSettingsMargins(requestContext,cancellationToken);

// IsActiveAmountValidation = IsActiveXMLValidation_Amount
result.outParamIsActiveAmountValidation=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveXMLValidation_Amount])));

// IsForceForeigner = IsActiveForceForeignerSupplier
result.outParamIsForceForeigner=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveForceForeignerSupplier])));

// o_ForeignCurrencyMargin = GetSettingsMargins.ForeignMargin
result.outParamo_ForeignCurrencyMargin=localVars.resGetSettingsMargins.outParamForeignMargin;

// o_NationalCurrencyMargin = GetSettingsMargins.NationalMargin
result.outParamo_NationalCurrencyMargin=localVars.resGetSettingsMargins.outParamNationalMargin;

// o_IsActiveDEV_HU13008_Complement = IsActiveDEV_HU13008_Complement
result.outParamo_IsActiveDEV_HU13008_Complement=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_HU13008_Complement])));

// o_IsActiveDEV_HU13046 = IsActiveDEV_HU13046
result.outParamo_IsActiveDEV_HU13046=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_HU13046])));

// o_IsActiveDEV_NumeroDeFolioVisible = IsActiveDEV_TK396
result.outParamo_IsActiveDEV_NumeroDeFolioVisible=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_TK396])));
} //close CreateActionActivity using block
} // try

finally {
outParamIsActiveAmountValidation = result.outParamIsActiveAmountValidation;
outParamIsForceForeigner = result.outParamIsForceForeigner;
outParamo_ForeignCurrencyMargin = result.outParamo_ForeignCurrencyMargin;
outParamo_NationalCurrencyMargin = result.outParamo_NationalCurrencyMargin;
outParamo_IsActiveDEV_HU13008_Complement = result.outParamo_IsActiveDEV_HU13008_Complement;
outParamo_IsActiveDEV_HU13046 = result.outParamo_IsActiveDEV_HU13046;
outParamo_IsActiveDEV_NumeroDeFolioVisible = result.outParamo_IsActiveDEV_NumeroDeFolioVisible;
} // inner-finally
RETURN_STATEMENT:
return (outParamIsActiveAmountValidation,outParamIsForceForeigner,outParamo_ForeignCurrencyMargin,outParamo_NationalCurrencyMargin,outParamo_IsActiveDEV_HU13008_Complement,outParamo_IsActiveDEV_HU13046,outParamo_IsActiveDEV_NumeroDeFolioVisible);
}


    public static class FuncDataActionGetOrderMainItems {

// Query Function "GetOrdersItems" GnATbwXO102DMvyl4JkANA of Action "GetOrderMainItems"
public static async Task<(RL_bab3397f952f07af0f0aa229e6f2b36e,long)> QueryGetOrdersItems(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporl_OrderIdSelected,int qpfoi_folioStatusIdCanceled,int qpfoi_folioStatusIdCanceledByProvider,long qpfoi_ExcludeFolioID,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("j_FoliosSAE.EditFolioSAE.GetOrderMainItems.GetOrdersItems", "6f13701a-ce05-4dd7-8332-fca5e0990034");
using var queryActivity = activitySource.CreateSqlQueryActivity("j_FoliosSAE.EditFolioSAE.GetOrderMainItems.GetOrdersItems", "6f13701a-ce05-4dd7-8332-fca5e0990034", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityOrderMainItem = AppUtils.Instance.RuntimeEntityReplace("OrderMainItem");
string entityOrderMain = AppUtils.Instance.RuntimeEntityReplace("OrderMain");
string entityFolioItems = AppUtils.Instance.RuntimeEntityReplace("FolioItems");
string entityFolio = AppUtils.Instance.RuntimeEntityReplace("Folio");
string entityOrderItemEntries = AppUtils.Instance.RuntimeEntityReplace("OrderItemEntries");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
string entityOrderMainItemStatus = AppUtils.Instance.RuntimeEntityReplace("OrderMainItemStatus");
sqlCmd.CreateParameter("@qpfoi_folioStatusIdCanceled", DbType.Int32, qpfoi_folioStatusIdCanceled);
sqlCmd.CreateParameter("@qpfoi_folioStatusIdCanceledByProvider", DbType.Int32, qpfoi_folioStatusIdCanceledByProvider);
sqlCmd.CreateParameter("@qpfoi_ExcludeFolioID", DbType.Int64, qpfoi_ExcludeFolioID);
sqlCmd.CreateParameter("@qporl_OrderIdSelected", DbType.Int64, qporl_OrderIdSelected);
string sql = "";
string advSql = "SELECT  \n    0, \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".Id") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"ordernumber\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"position\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"materialcode\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"materialdescription\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + ", \n \n    COALESCE(( \n        SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"invoiceqtt\"") + " AS DECIMAL(18,3))) \n        FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n        inner join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n        WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n        and ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceled and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceledByProvider) \n    ), 0), \n \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + " - COALESCE(( \n        SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"invoiceqtt\"") + " AS DECIMAL(18,3))) \n        FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n        inner join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n        WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n        and ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceled and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceledByProvider) \n        and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " <> @qpfoi_ExcludeFolioID \n    ), 0) - COALESCE(( \n            SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " AS DECIMAL(18,3))) \n            FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,"") + " \n            INNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,"") + " \n                ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"ordermainitemid\"") + " \n            WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " > 0 \n            OR ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"quantity_\"") + " < 0 \n                AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderItemEntries,".\"rejectfolio\"") + " = 0 \n            ) \n            ), 0), \n \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"orderunitofmeasure\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + ", \n \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"unitprice\"") + "* " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"quantity\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"label\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"class\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"deliverydate\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"unitprice\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"assigmnentcode\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"vatrate\"") + ", \n    COALESCE(( \n        SELECT SUM(CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"totalprice\"") + " AS DECIMAL(18,2))) \n        FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,"") + " \n        inner join  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " on  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"folioid\"") + " \n        WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioItems,".\"ordermainitemid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"id\"") + " \n        and ( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceled and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,".\"foliostatusid\"") + " <> @qpfoi_folioStatusIdCanceledByProvider) \n    ), 0), \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isdeleted\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isblocked\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"basequantity\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isfinaldelivery\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"pepelement\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"ismultipleimputation\"") + " \n \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,"") + " \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"ordermainid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"currencyid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,"") + " \n    ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"orderstatusid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItemStatus,".\"id\"") + " \n \nWHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,".\"id\"") + " = @qporl_OrderIdSelected \nand  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isblocked\"") + " = 0  \nand  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"isdeleted\"") + " = 0 \norder by  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMainItem,".\"position\"") + " asc";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_bab3397f952f07af0f0aa229e6f2b36e outParamList = new RL_bab3397f952f07af0f0aa229e6f2b36e();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.EditFolioSAE.GetOrderMainItems.GetOrdersItems.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_bab3397f952f07af0f0aa229e6f2b36e _tmp = new RL_bab3397f952f07af0f0aa229e6f2b36e();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.EditFolioSAE.GetOrderMainItems.GetOrdersItems.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_bab3397f952f07af0f0aa229e6f2b36e)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetOrdersItems in GetOrderMainItems in EditFolioSAE in j_FoliosSAE in ConectaProveedores (SELECT       0,      {OrderMainItem}.Id,      {OrderMain}.[OrderNumber],      {OrderMainItem}.[Position],      {OrderMainItem}.[MaterialCode],      {OrderMainItem}.[MaterialDescription],      {OrderMainItem}.[Quantity],        COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.[Id]          and ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled and {Folio}.[FolioStatusId] <> @i_folioStatusIdCanceledByProvider)      ), 0),        {OrderMainItem}.[Quantity] - COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.[Id]          and ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled and {Folio}.[FolioStatusId] <> @i_ ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrdersItems in GetOrderMainItems in EditFolioSAE in j_FoliosSAE in ConectaProveedores (SELECT       0,      {OrderMainItem}.Id,      {OrderMain}.[OrderNumber],      {OrderMainItem}.[Position],      {OrderMainItem}.[MaterialCode],      {OrderMainItem}.[MaterialDescription],      {OrderMainItem}.[Quantity],        COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.[Id]          and ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled and {Folio}.[FolioStatusId] <> @i_folioStatusIdCanceledByProvider)      ), 0),        {OrderMainItem}.[Quantity] - COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.[Id]          and ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled and {Folio}.[FolioStatusId] <> @i_ ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetOrdersItems in GetOrderMainItems in EditFolioSAE in j_FoliosSAE in ConectaProveedores (SELECT       0,      {OrderMainItem}.Id,      {OrderMain}.[OrderNumber],      {OrderMainItem}.[Position],      {OrderMainItem}.[MaterialCode],      {OrderMainItem}.[MaterialDescription],      {OrderMainItem}.[Quantity],        COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.[Id]          and ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled and {Folio}.[FolioStatusId] <> @i_folioStatusIdCanceledByProvider)      ), 0),        {OrderMainItem}.[Quantity] - COALESCE((          SELECT SUM(CAST({FolioItems}.[InvoiceQtt] AS DECIMAL(18,3)))          FROM {FolioItems}          inner join {Folio} on {Folio}.[Id] = {FolioItems}.[FolioId]          WHERE {FolioItems}.[OrderMainItemId] = {OrderMainItem}.[Id]          and ({Folio}.[FolioStatusId] <> @i_folioStatusIdCanceled and {Folio}.[FolioStatusId] <> @i_ ...): " + aqExcep.Message));
}
}
}
}
public static class FuncDataActionGetSettings {
}


}
