using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIInvFCP_4CloseCFDIInput {
[JsonProperty("InvoiceAccountingProcessId")]
public long? inParamInvoiceAccountingProcessId;
public S4PIInvFCP_4CloseCFDIInput(long? inParamInvoiceAccountingProcessId) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
}

}

public class S4PIInvFCP_4CloseCFDIOutput {
public S4PIInvFCP_4CloseCFDIOutput() {
}

}

[HttpPost()]
[Route("serviceapi/invfcp_4closecfdi")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "InvFCP_4CloseCFDI", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIInvFCP_4CloseCFDI(CancellationToken cancellationToken) {return await EndpointAsync<S4PIInvFCP_4CloseCFDIInput, S4PIInvFCP_4CloseCFDIOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
S4PIInvFCP_4CloseCFDIInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamInvoiceAccountingProcessId == null)) {
validationErrors["InvoiceAccountingProcessId"]=new string[] {"The InvoiceAccountingProcessId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
await Flows.ActionInvFCP_4CloseCFDI(context,inputs.inParamInvoiceAccountingProcessId.Value,ctx);

return new S4PIInvFCP_4CloseCFDIOutput();
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvInvFCP_4CloseCFDI : VarsBag {
public long inParamInvoiceAccountingProcessId;
/// <summary>
/// Variable <code>Society</code> that represents the Service Studio Text <code>Society</code>
///  <p>Description: </p>
/// </summary>
public string varLcSociety = "";

/// <summary>
/// Variable <code>SupplierNumber</code> that represents the Service Studio Text
///  <code>SupplierNumber</code> <p>Description: </p>
/// </summary>
public string varLcSupplierNumber = "";

/// <summary>
/// Variable <code>RegionFI</code> that represents the Service Studio Text <code>RegionFI</code>
///  <p>Description: </p>
/// </summary>
public string varLcRegionFI = "";

/// <summary>
/// Variable <code>l_StartedOn</code> that represents the Service Studio DateTime
///  <code>l_StartedOn</code> <p>Description: </p>
/// </summary>
public DateTime varLcl_StartedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);

public byte[] resServiceStorageGetFile_outParamo_File = new byte[] {};
public string resServiceStorageGetFile_outParamo_filename = "";

public Actions.lcoActionTimestampsCreateOrUpdate resActionTimestampsCreateOrUpdate6 =  new Actions.lcoActionTimestampsCreateOrUpdate();
public Actions.lcoActionTimestampsCreateOrUpdate resActionTimestampsCreateOrUpdate7 =  new Actions.lcoActionTimestampsCreateOrUpdate();
public RL_834d7e522ea0bf951f9c6dd7931c9096 queryResGetProcessById_outParamList = new RL_834d7e522ea0bf951f9c6dd7931c9096();
public long queryResGetProcessById_outParamCount = 0L;

public RL_00a03f803f0d49826089181417370afb queryResGetXMLInvoiceFileById_outParamList = new RL_00a03f803f0d49826089181417370afb();
public long queryResGetXMLInvoiceFileById_outParamCount = 0L;

public Actions.lcoUploadInvoiceFiles_ValidationServices resUploadInvoiceFiles_XMLValidationsPAC2 =  new Actions.lcoUploadInvoiceFiles_ValidationServices();
public lcvInvFCP_4CloseCFDI(long inParamInvoiceAccountingProcessId) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
}
}
/// <summary>
/// Action <code>InvFCP_4CloseCFDI</code> that represents the Service Studio action
///  <code>InvFCP_4CloseCFDI</code> <p> Description: Call PAC services</p>
/// </summary>
public static async Task ActionInvFCP_4CloseCFDI(IRequestContext requestContext,long inParamInvoiceAccountingProcessId,CancellationToken cancellationToken) {
lcvInvFCP_4CloseCFDI localVars = new lcvInvFCP_4CloseCFDI(inParamInvoiceAccountingProcessId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("InvFCP_4CloseCFDI", "0ad42901-814e-4131-9044-6695a5275ae2"))
using (activitySource.CreateServiceActionActivity("InvFCP_4CloseCFDI")){
// Query datasetGetProcessById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProcessById_maxRecords = 1;
if (datasetGetProcessById_maxRecords < 1) datasetGetProcessById_maxRecords = 1;
int datasetGetProcessById_startIndex = 0;(localVars.queryResGetProcessById_outParamList,localVars.queryResGetProcessById_outParamCount) = await FuncActionInvFCP_4CloseCFDI.datasetGetProcessById(requestContext,datasetGetProcessById_maxRecords,datasetGetProcessById_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceAccountingProcessId,cancellationToken);

// Query datasetGetXMLInvoiceFileById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetXMLInvoiceFileById_maxRecords = 1;
if (datasetGetXMLInvoiceFileById_maxRecords < 1) datasetGetXMLInvoiceFileById_maxRecords = 1;
int datasetGetXMLInvoiceFileById_startIndex = 0;(localVars.queryResGetXMLInvoiceFileById_outParamList,localVars.queryResGetXMLInvoiceFileById_outParamCount) = await FuncActionInvFCP_4CloseCFDI.datasetGetXMLInvoiceFileById(requestContext,datasetGetXMLInvoiceFileById_maxRecords,datasetGetXMLInvoiceFileById_startIndex,IterationMultiplicity.Never,localVars.queryResGetProcessById_outParamList.CurrentRec.ssENInvoice.ssId,cancellationToken);

// exit
if((!(((!((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveFCPValidationCFDI]))))||localVars.queryResGetXMLInvoiceFileById_outParamList.Empty)))) {
// l_StartedOn = CurrDateTime
localVars.varLcl_StartedOn=BuiltInFunction.CurrDateTime ();

// Society = GetProcessById.List.Current.Company.ExternalId
localVars.varLcSociety=localVars.queryResGetProcessById_outParamList.CurrentRec.ssENCompany.ssExternalId;

// SupplierNumber = GetProcessById.List.Current.Supplier.Number
localVars.varLcSupplierNumber=localVars.queryResGetProcessById_outParamList.CurrentRec.ssENSupplier.ssNumber;

// RegionFI = GetProcessById.List.Current.Region.DivisionFI
localVars.varLcRegionFI=localVars.queryResGetProcessById_outParamList.CurrentRec.ssENRegion.ssDivisionFI;
// ServiceStorageGetFile
(localVars.resServiceStorageGetFile_outParamo_File,localVars.resServiceStorageGetFile_outParamo_filename) = await ServiceAPIs.ServiceAPIServiceStorageGetFile(requestContext,localVars.queryResGetXMLInvoiceFileById_outParamList.CurrentRec.ssENInvoiceFile.ssStorageId,cancellationToken);

// ActionTimestampsCreateOrUpdate6
localVars.resActionTimestampsCreateOrUpdate6.outParamId = await Actions.ActionActionTimestampsCreateOrUpdate(requestContext,new EN_b22d64c90281d09a316b6f4502a74326EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssDescription = (("FCP ProcessId: "+BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceAccountingProcessId))+" - Get xml from storage"), ssStartedOn = localVars.varLcl_StartedOn, ssFinishedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// l_StartedOn = CurrDateTime
localVars.varLcl_StartedOn=BuiltInFunction.CurrDateTime ();
// UploadInvoiceFiles_XMLValidationsPAC2
localVars.resUploadInvoiceFiles_XMLValidationsPAC2.outParamErrorMsg = await Actions.ActionUploadInvoiceFiles_ValidationServices(requestContext,true,localVars.resServiceStorageGetFile_outParamo_File,localVars.resServiceStorageGetFile_outParamo_filename,localVars.varLcSupplierNumber,localVars.varLcRegionFI,localVars.varLcSociety,cancellationToken);

// ActionTimestampsCreateOrUpdate7
localVars.resActionTimestampsCreateOrUpdate7.outParamId = await Actions.ActionActionTimestampsCreateOrUpdate(requestContext,new EN_b22d64c90281d09a316b6f4502a74326EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssDescription = (("FCP ProcessId: "+BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceAccountingProcessId))+" - PAC Validations"), ssStartedOn = localVars.varLcl_StartedOn, ssFinishedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

        public static class FuncActionInvFCP_4CloseCFDI {
            
private static async Task<RC_8e6e8689af9604d88bc9155d334336c9> datasetGetProcessByIdReadDbAsync(RC_8e6e8689af9604d88bc9155d334336c9 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccountingProcess.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetProcessById" 0kaD01J2uUOwG0_Q0l1+PQ of Action "InvFCP_4CloseCFDI"
public static async Task<(RL_834d7e522ea0bf951f9c6dd7931c9096,long)> datasetGetProcessById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceAccountingProcess_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvFCP_4CloseCFDI.GetProcessById", "d38346d2-7652-43b9-b01b-4fd0d25d7e3d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvFCP_4CloseCFDI.GetProcessById", "d38346d2-7652-43b9-b01b-4fd0d25d7e3d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.ASnUCk6BMUGQRGaVpSda4g/NodesNotShownInESpaceTree.0kaD01J2uUOwG0_Q0l1+PQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"encompany14\".\"externalid\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"eninvoice78\".\"id\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, \"enregion65\".\"divisionfi\" o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, \"ensupplier49\".\"number\" o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113");
fromBuilder.Append(" FROM ((((({InvoiceAccountingProcess} \"eninvoiceaccountingprocess10\" Left JOIN {Invoice} \"eninvoice78\" ON (\"eninvoiceaccountingprocess10\".\"invoiceid\" = \"eninvoice78\".\"id\"))  Left JOIN {OrderMain} \"enordermain69\" ON (\"eninvoice78\".\"ordermainid\" = \"enordermain69\".\"id\"))  Left JOIN {Region} \"enregion65\" ON (\"enordermain69\".\"divisionid\" = \"enregion65\".\"id\"))  Left JOIN {Supplier} \"ensupplier49\" ON (\"enordermain69\".\"supplierid\" = \"ensupplier49\".\"id\"))  Left JOIN {Company} \"encompany14\" ON (\"enordermain69\".\"companyid\" = \"encompany14\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceAccountingProcess_Id != 0) {
whereBuilder.Append("((\"eninvoiceaccountingprocess10\".\"id\" = @qpinInvoiceAccountingProcess_Id) AND (\"eninvoiceaccountingprocess10\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceAccountingProcess_Id", DbType.Int64, qpinInvoiceAccountingProcess_Id);
} else {
whereBuilder.Append("(\"eninvoiceaccountingprocess10\".\"id\" IS NULL)");
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
RL_834d7e522ea0bf951f9c6dd7931c9096 outParamList = new RL_834d7e522ea0bf951f9c6dd7931c9096();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetProcessByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvFCP_4CloseCFDI.GetProcessById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_834d7e522ea0bf951f9c6dd7931c9096 _tmp = new RL_834d7e522ea0bf951f9c6dd7931c9096();
_tmp.AlternateReadDbMethodAsync = datasetGetProcessByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvFCP_4CloseCFDI.GetProcessById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_834d7e522ea0bf951f9c6dd7931c9096)_tmp;
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

// Query Function "GetXMLInvoiceFileById" nd6J3tKHyUKZcbXrLx9Xhg of Action "InvFCP_4CloseCFDI"
public static async Task<(RL_00a03f803f0d49826089181417370afb,long)> datasetGetXMLInvoiceFileById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvFCP_4CloseCFDI.GetXMLInvoiceFileById", "de89de9d-87d2-42c9-9971-b5eb2f1f5786");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvFCP_4CloseCFDI.GetXMLInvoiceFileById", "de89de9d-87d2-42c9-9971-b5eb2f1f5786", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.ASnUCk6BMUGQRGaVpSda4g/NodesNotShownInESpaceTree.nd6J3tKHyUKZcbXrLx9Xhg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, \"eninvoicefile26\".\"storageid\" o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceFile} \"eninvoicefile26\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoicefile26\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoicefile26\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoicefile26\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND (NOT (\"eninvoicefile26\".\"isextra\" = 1)) AND (((CASE WHEN char_length(caseaccent_normalize('.xml' collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize('.xml' collate \"default\") in caseaccent_normalize((Lower(\"eninvoicefile26\".\"filename\")) collate \"default\"))-1) END)) <> (-1))");
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
RL_00a03f803f0d49826089181417370afb outParamList = new RL_00a03f803f0d49826089181417370afb();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvFCP_4CloseCFDI.GetXMLInvoiceFileById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_00a03f803f0d49826089181417370afb _tmp = new RL_00a03f803f0d49826089181417370afb();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvFCP_4CloseCFDI.GetXMLInvoiceFileById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_00a03f803f0d49826089181417370afb)_tmp;
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
