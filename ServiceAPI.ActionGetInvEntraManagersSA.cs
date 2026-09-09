using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;
using ssConectaProveedores.RestRecords;

namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIGetInvEntraManagersSAInput {
[JsonProperty("i_EntraId")]
public string inParami_EntraId;
[JsonProperty("i_InvoiceApproval")]
public JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord inParami_InvoiceApproval;
[JsonProperty("GetLastApprover_List")]
public JSONRC_d8e0782722e3cf21d33f17c1d3072275[] inParamGetLastApprover_List;
public S4PIGetInvEntraManagersSAInput(string inParami_EntraId, JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord inParami_InvoiceApproval, JSONRC_d8e0782722e3cf21d33f17c1d3072275[] inParamGetLastApprover_List) {
this.inParami_EntraId = inParami_EntraId;
this.inParami_InvoiceApproval = inParami_InvoiceApproval;
this.inParamGetLastApprover_List = inParamGetLastApprover_List;
}

}

public class S4PIGetInvEntraManagersSAOutput {
[JsonProperty("o_ListOut")]
public JSONRC_2dabb9c9cbdbc6ba6572314572d54c39[] outParamo_ListOut;
public S4PIGetInvEntraManagersSAOutput(JSONRC_2dabb9c9cbdbc6ba6572314572d54c39[] outParamo_ListOut) {
this.outParamo_ListOut = outParamo_ListOut;
}

}

[HttpPost()]
[Route("serviceapi/getinventramanagerssa")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "GetInvEntraManagersSA", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIGetInvEntraManagersSA(CancellationToken cancellationToken) {return await EndpointAsync<S4PIGetInvEntraManagersSAInput, S4PIGetInvEntraManagersSAOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
RL_d8fd32f99db779d312575aee27a70835 outParamo_ListOut;
S4PIGetInvEntraManagersSAInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParami_EntraId == null)) {
validationErrors["i_EntraId"]=new string[] {"The i_EntraId mandatory parameter is missing in the request."};
}

if((inputs.inParami_InvoiceApproval == null)) {
validationErrors["i_InvoiceApproval"]=new string[] {"The i_InvoiceApproval mandatory parameter is missing in the request."};
}

if((inputs.inParamGetLastApprover_List == null)) {
validationErrors["GetLastApprover_List"]=new string[] {"The GetLastApprover_List mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamo_ListOut = await Flows.ActionGetInvEntraManagersSA(context,inputs.inParami_EntraId,JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.ToStructure(inputs.inParami_InvoiceApproval, behaviorsConfiguration),RL_cff357eb9416ff34aed51af5aed473de.ToList(inputs.inParamGetLastApprover_List, (str) => JSONRC_d8e0782722e3cf21d33f17c1d3072275.ToStructure(str, behaviorsConfiguration)),ctx);

return new S4PIGetInvEntraManagersSAOutput(RL_d8fd32f99db779d312575aee27a70835.ToArray(outParamo_ListOut, (str) => JSONRC_2dabb9c9cbdbc6ba6572314572d54c39.FromStructure(str, behaviorsConfiguration)));
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvGetInvEntraManagersSA : VarsBag {
public string inParami_EntraId;
public EN_c2bd0675fed3aedb585c484c59155eddEntityRecord inParami_InvoiceApproval;
public RL_cff357eb9416ff34aed51af5aed473de inParamGetLastApprover_List;
/// <summary>
/// Variable <code>AppRoleIdTempList</code> that represents the Service Studio
///  ApplicationRoleIdentifierList <code>AppRoleIdTempList</code> <p>Description: </p>
/// </summary>
public BasicTypeList<long> varLcAppRoleIdTempList = new BasicTypeList<long>();

public ST_346a76e47f982dbf41625f8a893affccStructure resServiceEntraRoleCreate_outParamo_output = new ST_346a76e47f982dbf41625f8a893affccStructure();
public bool resServiceEntraRoleCreate_outParamHasBeenCreated = false;
public long resServiceEntraRoleCreate_outParamEntraRoleId = 0L;

public Actions.lcoInvRoleIsNeeded resInvRoleIsNeeded =  new Actions.lcoInvRoleIsNeeded();
public int resListIndexOf_outParamPosition = 0;

public Actions.lcoGetAppRoleFromEntraJobTitle resGetAppRoleFromEntraJobTitle =  new Actions.lcoGetAppRoleFromEntraJobTitle();
public RL_acd66b694d90eb775616e6c6e3f83477 queryResGetApprovalProcess_outParamList = new RL_acd66b694d90eb775616e6c6e3f83477();
public long queryResGetApprovalProcess_outParamCount = 0L;

public RL_c68f8e92ccdada3f2f3589e091be34b8 resGetUserManagers_outParamResponse = new RL_c68f8e92ccdada3f2f3589e091be34b8();
public ST_38509e9fbd36a9b928c2f4e34a1342aeStructure resGetUserManagers_outParamResult = new ST_38509e9fbd36a9b928c2f4e34a1342aeStructure();

public lcvGetInvEntraManagersSA(string inParami_EntraId, EN_c2bd0675fed3aedb585c484c59155eddEntityRecord inParami_InvoiceApproval, RL_cff357eb9416ff34aed51af5aed473de inParamGetLastApprover_List) {
this.inParami_EntraId = inParami_EntraId;
this.inParami_InvoiceApproval = inParami_InvoiceApproval;
this.inParamGetLastApprover_List = inParamGetLastApprover_List;
}
}
public class lcoGetInvEntraManagersSA : VarsBag {
public RL_d8fd32f99db779d312575aee27a70835 outParamo_ListOut = new RL_d8fd32f99db779d312575aee27a70835();

public lcoGetInvEntraManagersSA() {
}
}
/// <summary>
/// Action <code>GetInvEntraManagersSA</code> that represents the Service Studio action
///  <code>GetInvEntraManagersSA</code> <p> Description: </p>
/// </summary>
public static async Task<RL_d8fd32f99db779d312575aee27a70835> ActionGetInvEntraManagersSA(IRequestContext requestContext,string inParami_EntraId,EN_c2bd0675fed3aedb585c484c59155eddEntityRecord inParami_InvoiceApproval,RL_cff357eb9416ff34aed51af5aed473de inParamGetLastApprover_List,CancellationToken cancellationToken) {
RL_d8fd32f99db779d312575aee27a70835 outParamo_ListOut = default;
lcoGetInvEntraManagersSA result = new lcoGetInvEntraManagersSA();
lcvGetInvEntraManagersSA localVars = new lcvGetInvEntraManagersSA(inParami_EntraId, inParami_InvoiceApproval, inParamGetLastApprover_List);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("GetInvEntraManagersSA", "ac9727d5-e27a-49f0-9993-9ee04d757f29"))
using (activitySource.CreateServiceActionActivity("GetInvEntraManagersSA")){
// LogMessage
await ExtendedActions.LogMessage(requestContext,((("i_InvoiceApproval: "+(localVars.inParami_InvoiceApproval.ssHasStartedAccounting ? "True" : "False"))+" | GetLastApprover_List: ")+(localVars.inParamGetLastApprover_List.CurrentRec.ssENInvoiceApproval.ssHasStartedAccounting ? "True" : "False")),"INV",cancellationToken);

// GetUserManagers
(localVars.resGetUserManagers_outParamResponse,localVars.resGetUserManagers_outParamResult) = await Actions.ActionGetUserManagers(requestContext,localVars.inParami_EntraId,false,cancellationToken);

// Query datasetGetApprovalProcess
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcess_maxRecords = 1;
if (datasetGetApprovalProcess_maxRecords < 1) datasetGetApprovalProcess_maxRecords = 1;
int datasetGetApprovalProcess_startIndex = 0;(localVars.queryResGetApprovalProcess_outParamList,localVars.queryResGetApprovalProcess_outParamCount) = await FuncActionGetInvEntraManagersSA.datasetGetApprovalProcess(requestContext,datasetGetApprovalProcess_maxRecords,datasetGetApprovalProcess_startIndex,IterationMultiplicity.Never,localVars.inParami_InvoiceApproval.ssApprovalProcessVersion,localVars.inParami_InvoiceApproval.ssProcessTypeCode,cancellationToken);

// IsSpecial and HasStartedAccounting
if((((localVars.queryResGetApprovalProcess_outParamList.CurrentRec.ssENApprovalProcess.ssIsSpecial&&localVars.inParamGetLastApprover_List.CurrentRec.ssENInvoiceApproval.ssHasStartedAccounting)||(!localVars.queryResGetApprovalProcess_outParamList.CurrentRec.ssENApprovalProcess.ssIsSpecial)))) {
// Foreach GetUserManagers.Response
localVars.resGetUserManagers_outParamResponse.StartIteration();
bool flagContinueTo_forEach = false;
try {while (!((localVars.resGetUserManagers_outParamResponse.Eof))) {
flagContinueTo_forEach = false;
do {
// GetAppRoleFromEntraJobTitle
(localVars.resGetAppRoleFromEntraJobTitle.outParamo_ApplicationRoleId,localVars.resGetAppRoleFromEntraJobTitle.outParamo_RoleName) = await Actions.ActionGetAppRoleFromEntraJobTitle(requestContext,BuiltInFunction.Trim (localVars.resGetUserManagers_outParamResponse.CurrentRec.ssJobTitle),3,(!localVars.inParami_InvoiceApproval.ssHasStartedAccounting),localVars.inParami_InvoiceApproval.ssHasStartedAccounting,cancellationToken);

// App role not mapped
if(((localVars.resGetAppRoleFromEntraJobTitle.outParamo_ApplicationRoleId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// ServiceEntraRoleCreate
(localVars.resServiceEntraRoleCreate_outParamo_output,localVars.resServiceEntraRoleCreate_outParamHasBeenCreated,localVars.resServiceEntraRoleCreate_outParamEntraRoleId) = await ServiceAPIs.ServiceAPIServiceEntraRoleCreate(requestContext,BuiltInFunction.Trim (localVars.resGetUserManagers_outParamResponse.CurrentRec.ssJobTitle),cancellationToken);

} else {
// Set Local Role Name
// GetUserManagers.Response.Current.JobTitle = GetAppRoleFromEntraJobTitle.o_RoleName
localVars.resGetUserManagers_outParamResponse.CurrentRec.ssJobTitle = localVars.resGetAppRoleFromEntraJobTitle.outParamo_RoleName;
// InvRoleIsNeeded
(localVars.resInvRoleIsNeeded.outParamo_IsNeeded,localVars.resInvRoleIsNeeded.outParamo_ApprovalProcessLevel) = await Actions.ActionInvRoleIsNeeded(requestContext,localVars.inParamGetLastApprover_List.CurrentRec.ssENInvoice,localVars.queryResGetApprovalProcess_outParamList.CurrentRec.ssENApprovalProcess.ssId,localVars.resGetAppRoleFromEntraJobTitle.outParamo_ApplicationRoleId,localVars.inParami_InvoiceApproval.ssHasStartedAccounting,cancellationToken);

// o_IsNeeded?
if((localVars.resInvRoleIsNeeded.outParamo_IsNeeded)) {
// ListIndexOf
localVars.resListIndexOf_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.varLcAppRoleIdTempList,async (p, cancellationToken) => (p==localVars.resGetAppRoleFromEntraJobTitle.outParamo_ApplicationRoleId),cancellationToken);

// Found?
if((!((localVars.resListIndexOf_outParamPosition!=(-1))))) {
// ListAppend2
await ExtendedActions.ListAppend(requestContext,localVars.varLcAppRoleIdTempList,localVars.resGetAppRoleFromEntraJobTitle.outParamo_ApplicationRoleId,cancellationToken);

break;
}

}

// ALIGN
localVars.resGetUserManagers_outParamResponse.Advance();
// continue to flagContinueTo_forEach
flagContinueTo_forEach = true;
break;
}

} while(false)
;
if(flagContinueTo_forEach) {
continue;
}

// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamo_ListOut,new RC_2dabb9c9cbdbc6ba6572314572d54c39(){ ssDisplayName = localVars.resGetUserManagers_outParamResponse.CurrentRec.ssDisplayName, ssIsNotMapped = (localVars.resGetAppRoleFromEntraJobTitle.outParamo_ApplicationRoleId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())), ssJobTitle = (((localVars.resGetAppRoleFromEntraJobTitle.outParamo_ApplicationRoleId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (BuiltInFunction.Trim (localVars.resGetUserManagers_outParamResponse.CurrentRec.ssJobTitle)) : (localVars.resGetAppRoleFromEntraJobTitle.outParamo_RoleName)) },cancellationToken);

localVars.resGetUserManagers_outParamResponse.Advance();
}

} finally {
localVars.resGetUserManagers_outParamResponse.EndIteration();
}

}

} //close CreateActionActivity using block
} // try

finally {
outParamo_ListOut = result.outParamo_ListOut;
} // inner-finally
RETURN_STATEMENT:
return outParamo_ListOut;
}

        public static class FuncActionGetInvEntraManagersSA {
            
private static async Task<RC_9c2c2f8777df5db915ea9753325ce8dd> datasetGetApprovalProcessReadDbAsync(RC_9c2c2f8777df5db915ea9753325ce8dd rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENProcessType.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcess" hGUPplplvk2ZopYZE62BSg of Action "GetInvEntraManagersSA"
public static async Task<(RL_acd66b694d90eb775616e6c6e3f83477,long)> datasetGetApprovalProcess(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteApprovalProcess_Version,string qpteProcessType_Code,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetInvEntraManagersSA.GetApprovalProcess", "a60f6584-655a-4dbe-99a2-961913ad814a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetInvEntraManagersSA.GetApprovalProcess", "a60f6584-655a-4dbe-99a2-961913ad814a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.1SeXrHri8EmZk57gTXV_KQ/NodesNotShownInESpaceTree.hGUPplplvk2ZopYZE62BSg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess40\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"enapprovalprocess40\".\"isspecial\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23");
fromBuilder.Append(" FROM ({ApprovalProcess} \"enapprovalprocess40\" Left JOIN {ProcessType} \"enprocesstype13\" ON (\"enapprovalprocess40\".\"processtypeid\" = \"enprocesstype13\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enprocesstype13\".\"code\" = @qpteProcessType_Code) AND (cast(\"enapprovalprocess40\".\"version\" as text) = @qpteApprovalProcess_Version)");
sqlCmd.CreateParameterWithoutReplacements("@qpteProcessType_Code", DbType.String, qpteProcessType_Code);
sqlCmd.CreateParameterWithoutReplacements("@qpteApprovalProcess_Version", DbType.String, qpteApprovalProcess_Version);
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
RL_acd66b694d90eb775616e6c6e3f83477 outParamList = new RL_acd66b694d90eb775616e6c6e3f83477();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetInvEntraManagersSA.GetApprovalProcess.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_acd66b694d90eb775616e6c6e3f83477 _tmp = new RL_acd66b694d90eb775616e6c6e3f83477();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetInvEntraManagersSA.GetApprovalProcess.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_acd66b694d90eb775616e6c6e3f83477)_tmp;
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
}
