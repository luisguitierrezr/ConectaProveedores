using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_a_Common_Menu_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_a_Common_Menu_ScreenModel).Namespace);

    public int inParamActiveItem;
public int inParamActiveSubItem;
public ConectaProveedores_a_Common_Menu_DataActionGetSettings_Model varLcGetSettings;
public ConectaProveedores_a_Common_Menu_DataActionGetUserData_Model varLcGetUserData;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_a_Common_Menu_ScreenModel() {
}



    public ConectaProveedores_a_Common_Menu_ScreenModel(int inParamActiveItem, int inParamActiveSubItem, ConectaProveedores_a_Common_Menu_DataActionGetSettings_Model varLcGetSettings, ConectaProveedores_a_Common_Menu_DataActionGetUserData_Model varLcGetUserData, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"ActiveItem", "ActiveSubItem", "GetSettings", "GetUserData", "ClientVars"}, new string[] {"inParamActiveItem", "inParamActiveSubItem", "varLcGetSettings", "varLcGetUserData", "clientVariables"});
this.inParamActiveItem = inParamActiveItem;
this.inParamActiveSubItem = inParamActiveSubItem;
this.varLcGetSettings = varLcGetSettings;
this.varLcGetUserData = varLcGetUserData;
this.clientVariables = clientVariables;
}



    

    public class lcoGetSettings : VarsBag {
public bool outParamo_IsDevEnvironment = false;

public string outParamo_Environment = "";

public bool outParamo_IsActiveDEV_HU13045 = false;

public bool outParamo_IsActiveDEV_HU13046 = false;

public bool outParamo_IsActiveDEV_HU13047 = false;

public bool outParamo_IsActiveDEV_HU13048 = false;

public lcoGetSettings() {
}
}
/// <summary>
/// Action <code>GetSettings</code> that represents the Service Studio action <code>GetSettings</code>
///  <p> Description: Query to get settings.</p>
/// </summary>
public async Task<(bool,string,bool,bool,bool,bool)> DataActionGetSettings(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamo_IsDevEnvironment = default;
string outParamo_Environment = default;
bool outParamo_IsActiveDEV_HU13045 = default;
bool outParamo_IsActiveDEV_HU13046 = default;
bool outParamo_IsActiveDEV_HU13047 = default;
bool outParamo_IsActiveDEV_HU13048 = default;
lcoGetSettings result = new lcoGetSettings();
ConectaProveedores_a_Common_Menu_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSettings", "836856f5-d4cd-4708-a493-8f5f9ebab0cd"))
using (activitySource.CreateScreenDataActionActivity("Menu", "GetSettings")){
// o_IsDevEnvironment = IsDevEnvironment
result.outParamo_IsDevEnvironment=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsDevEnvironment])));

// o_IsActiveDEV_HU13045 = IsActiveDEV_HU13045
result.outParamo_IsActiveDEV_HU13045=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_HU13045])));

// o_IsActiveDEV_HU13046 = IsActiveDEV_HU13046
result.outParamo_IsActiveDEV_HU13046=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_HU13046])));

// o_IsActiveDEV_HU13047 = IsActiveDEV_HU13047
result.outParamo_IsActiveDEV_HU13047=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_HU13047])));

// o_IsActiveDEV_HU13048 = IsActiveDEV_HU13048
result.outParamo_IsActiveDEV_HU13048=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_HU13048])));
// o_Environment = Environment
result.outParamo_Environment=((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])));
} //close CreateActionActivity using block
} // try

finally {
outParamo_IsDevEnvironment = result.outParamo_IsDevEnvironment;
outParamo_Environment = result.outParamo_Environment;
outParamo_IsActiveDEV_HU13045 = result.outParamo_IsActiveDEV_HU13045;
outParamo_IsActiveDEV_HU13046 = result.outParamo_IsActiveDEV_HU13046;
outParamo_IsActiveDEV_HU13047 = result.outParamo_IsActiveDEV_HU13047;
outParamo_IsActiveDEV_HU13048 = result.outParamo_IsActiveDEV_HU13048;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_IsDevEnvironment,outParamo_Environment,outParamo_IsActiveDEV_HU13045,outParamo_IsActiveDEV_HU13046,outParamo_IsActiveDEV_HU13047,outParamo_IsActiveDEV_HU13048);
}
public class lcvGetUserData : VarsBag {
public Actions.lcoGetIsCxP_RequestErrorDistribution resGetIsCxP_RequestErrorDistribution =  new Actions.lcoGetIsCxP_RequestErrorDistribution();
public RL_39dfaa06ed57a2b72536c2b3070b1bce queryResGetUserDataById_outParamList = new RL_39dfaa06ed57a2b72536c2b3070b1bce();
public long queryResGetUserDataById_outParamCount = 0L;

public Actions.lcoGetIsUserCxP resGetIsUserCxP =  new Actions.lcoGetIsUserCxP();
public lcvGetUserData() {
}
}
public class lcoGetUserData : VarsBag {
public string outParamo_Region = "";

public bool outParamo_IsCXP = false;

public bool outParamo_CanSeeDistributionError = false;

public lcoGetUserData() {
}
}
/// <summary>
/// Action <code>GetUserData</code> that represents the Service Studio action <code>GetUserData</code>
///  <p> Description: Query to fetch User Data.</p>
/// </summary>
public async Task<(string,bool,bool)> DataActionGetUserData(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamo_Region = default;
bool outParamo_IsCXP = default;
bool outParamo_CanSeeDistributionError = default;
lcoGetUserData result = new lcoGetUserData();
lcvGetUserData localVars = new lcvGetUserData();
ConectaProveedores_a_Common_Menu_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserData", "bdfdce69-d0a5-4fb7-88e4-087f906bd715"))
using (activitySource.CreateScreenDataActionActivity("Menu", "GetUserData")){
// Query datasetGetUserDataById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserDataById_maxRecords = 0;
int datasetGetUserDataById_startIndex = 0;(localVars.queryResGetUserDataById_outParamList,localVars.queryResGetUserDataById_outParamCount) = await FuncDataActionGetUserData.datasetGetUserDataById(requestContext,datasetGetUserDataById_maxRecords,datasetGetUserDataById_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

// GetIsCxP_RequestErrorDistribution
localVars.resGetIsCxP_RequestErrorDistribution.outParamo_IsAllowed = await Actions.ActionGetIsCxP_RequestErrorDistribution(requestContext,cancellationToken);

// GetIsUserCxP
localVars.resGetIsUserCxP.outParamo_Value = await Actions.ActionGetIsUserCxP(requestContext,cancellationToken);

// o_Region = GetUserDataById.List.Current.Region.DivisionFI
result.outParamo_Region=localVars.queryResGetUserDataById_outParamList.CurrentRec.ssENRegion.ssDivisionFI;

// o_IsCXP = GetIsUserCxP.o_Value
result.outParamo_IsCXP=localVars.resGetIsUserCxP.outParamo_Value;

// o_CanSeeDistributionError = GetIsCxP_RequestErrorDistribution.o_IsAllowed
result.outParamo_CanSeeDistributionError=localVars.resGetIsCxP_RequestErrorDistribution.outParamo_IsAllowed;
} //close CreateActionActivity using block
} // try

finally {
outParamo_Region = result.outParamo_Region;
outParamo_IsCXP = result.outParamo_IsCXP;
outParamo_CanSeeDistributionError = result.outParamo_CanSeeDistributionError;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Region,outParamo_IsCXP,outParamo_CanSeeDistributionError);
}


    public static class FuncDataActionGetSettings {
}
public static class FuncDataActionGetUserData {

private static async Task<RC_a977e4ee3fe611d1f9a8a51587df5f57> datasetGetUserDataByIdReadDbAsync(RC_a977e4ee3fe611d1f9a8a51587df5f57 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetUserDataById" C82Fk6J_KEm22MOsFfd_FA of Action "GetUserData"
public static async Task<(RL_39dfaa06ed57a2b72536c2b3070b1bce,long)> datasetGetUserDataById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Extended_Internal_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("a_Common.Menu.GetUserData.GetUserDataById", "9385cd0b-7fa2-4928-b6d8-c3ac15f77f14");
using var queryActivity = activitySource.CreateAggregateQueryActivity("a_Common.Menu.GetUserData.GetUserDataById", "9385cd0b-7fa2-4928-b6d8-c3ac15f77f14", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.B4kRGvrnOEmQonA8ir4Pyg/NodesShownInESpaceTree.InqFsjigx0C1s5MMD4MpaQ/DataActions.ac79vaXQt0+I5Ah_kGvXFQ/NodesNotShownInESpaceTree.C82Fk6J_KEm22MOsFfd_FA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"enregion87\".\"divisionfi\" o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38");
fromBuilder.Append(" FROM (({User_Extended_Internal} \"enuser_extended_internal97\" Inner JOIN {Region} \"enregion87\" ON (\"enuser_extended_internal97\".\"regionid\" = \"enregion87\".\"id\"))  Left JOIN {EntraRole} \"enentrarole47\" ON (\"enuser_extended_internal97\".\"entraroleid\" = \"enentrarole47\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Extended_Internal_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser_extended_internal97\".\"id\" = @qpusUser_Extended_Internal_Id) AND (\"enuser_extended_internal97\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Extended_Internal_Id", DbType.String, qpusUser_Extended_Internal_Id);
} else {
whereBuilder.Append("(\"enuser_extended_internal97\".\"id\" IS NULL)");
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
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Common.Menu.GetUserData.GetUserDataById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Common.Menu.GetUserData.GetUserDataById.List", cancellationToken: cancellationToken);
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
