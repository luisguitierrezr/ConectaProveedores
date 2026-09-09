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

    public class S4PIServiceGetInvoiceByIdInput {
[JsonProperty("InvoiceId")]
public long? inParamInvoiceId;
public S4PIServiceGetInvoiceByIdInput(long? inParamInvoiceId) {
this.inParamInvoiceId = inParamInvoiceId;
}

}

public class S4PIServiceGetInvoiceByIdOutput {
[JsonProperty("InvoiceData")]
public JSONRC_42a47f09e8ab03d8e9c2d1f2f5aa06af[] outParamInvoiceData;
public S4PIServiceGetInvoiceByIdOutput(JSONRC_42a47f09e8ab03d8e9c2d1f2f5aa06af[] outParamInvoiceData) {
this.outParamInvoiceData = outParamInvoiceData;
}

}

[HttpPost()]
[Route("serviceapi/servicegetinvoicebyid")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceGetInvoiceById", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceGetInvoiceById(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceGetInvoiceByIdInput, S4PIServiceGetInvoiceByIdOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
RL_e6ad6603ac07123d4d7c5f1b4a760912 outParamInvoiceData;
S4PIServiceGetInvoiceByIdInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamInvoiceId == null)) {
validationErrors["InvoiceId"]=new string[] {"The InvoiceId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
outParamInvoiceData = await Flows.ActionServiceGetInvoiceById(context,inputs.inParamInvoiceId.Value,ctx);

return new S4PIServiceGetInvoiceByIdOutput(RL_e6ad6603ac07123d4d7c5f1b4a760912.ToArray(outParamInvoiceData, (str) => JSONRC_42a47f09e8ab03d8e9c2d1f2f5aa06af.FromStructure(str, behaviorsConfiguration)));
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceGetInvoiceById : VarsBag {
public long inParamInvoiceId;
public RL_e6ad6603ac07123d4d7c5f1b4a760912 queryResGetInvoiceById_outParamList = new RL_e6ad6603ac07123d4d7c5f1b4a760912();
public long queryResGetInvoiceById_outParamCount = 0L;

public lcvServiceGetInvoiceById(long inParamInvoiceId) {
this.inParamInvoiceId = inParamInvoiceId;
}
}
public class lcoServiceGetInvoiceById : VarsBag {
public RL_e6ad6603ac07123d4d7c5f1b4a760912 outParamInvoiceData = new RL_e6ad6603ac07123d4d7c5f1b4a760912();

public lcoServiceGetInvoiceById() {
}
}
/// <summary>
/// Action <code>ServiceGetInvoiceById</code> that represents the Service Studio action
///  <code>ServiceGetInvoiceById</code> <p> Description: </p>
/// </summary>
public static async Task<RL_e6ad6603ac07123d4d7c5f1b4a760912> ActionServiceGetInvoiceById(IRequestContext requestContext,long inParamInvoiceId,CancellationToken cancellationToken) {
RL_e6ad6603ac07123d4d7c5f1b4a760912 outParamInvoiceData = default;
lcoServiceGetInvoiceById result = new lcoServiceGetInvoiceById();
lcvServiceGetInvoiceById localVars = new lcvServiceGetInvoiceById(inParamInvoiceId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceGetInvoiceById", "3d1e1518-9ddf-45db-b424-4fbc3c89c65e"))
using (activitySource.CreateServiceActionActivity("ServiceGetInvoiceById")){
// Query datasetGetInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById_maxRecords = 1;
if (datasetGetInvoiceById_maxRecords < 1) datasetGetInvoiceById_maxRecords = 1;
int datasetGetInvoiceById_startIndex = 0;(localVars.queryResGetInvoiceById_outParamList,localVars.queryResGetInvoiceById_outParamCount) = await FuncActionServiceGetInvoiceById.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Multiple,localVars.inParamInvoiceId,cancellationToken);

// InvoiceData = GetInvoiceById.List
result.outParamInvoiceData=localVars.queryResGetInvoiceById_outParamList;
} //close CreateActionActivity using block
} // try

finally {
outParamInvoiceData = result.outParamInvoiceData;
} // inner-finally
RETURN_STATEMENT:
return outParamInvoiceData;
}

        public static class FuncActionServiceGetInvoiceById {
            
private static async Task<RC_42a47f09e8ab03d8e9c2d1f2f5aa06af> datasetGetInvoiceByIdReadDbAsync(RC_42a47f09e8ab03d8e9c2d1f2f5aa06af rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceStatus.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceById" bTpzS2ubMEWcJC+U7YLbBw of Action "ServiceGetInvoiceById"
public static async Task<(RL_e6ad6603ac07123d4d7c5f1b4a760912,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ServiceGetInvoiceById.GetInvoiceById", "4b733a6d-9b6b-4530-9c24-2f94ed82db07");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ServiceGetInvoiceById.GetInvoiceById", "4b733a6d-9b6b-4530-9c24-2f94ed82db07", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.GBUePd+d20W0JE+8PInGXg/NodesNotShownInESpaceTree.bTpzS2ubMEWcJC+U7YLbBw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice82\".\"id\" o0, \"eninvoice82\".\"name\" o1, \"eninvoice82\".\"requisitionid\" o2, \"eninvoice82\".\"folioid\" o3, \"eninvoice82\".\"ordermainid\" o4, \"eninvoice82\".\"cfditypeid\" o5, trim_scale(\"eninvoice82\".\"totalamount\"::numeric) o6, \"eninvoice82\".\"currency\" o7, \"eninvoice82\".\"invoicestatusid\" o8, \"eninvoice82\".\"accountingdatetime\" o9, \"eninvoice82\".\"paymentdatetime\" o10, \"eninvoice82\".\"createdon\" o11, \"eninvoice82\".\"createdby\" o12, \"eninvoice82\".\"updatedon\" o13, \"eninvoice82\".\"updatedby\" o14, \"eninvoice82\".\"submittedon\" o15, \"eninvoice82\".\"isnewversion\" o16, \"eninvoice82\".\"id_poliza\" o17, \"eninvoice82\".\"id_poliza_sap\" o18, \"eninvoice82\".\"doc51\" o19, \"eninvoice82\".\"accountingerror\" o20, \"eninvoice82\".\"orderaccconceptsid\" o21, trim_scale(\"eninvoice82\".\"amortization\"::numeric) o22, \"eninvoice82\".\"creditnoteinvoiceid\" o23, \"eninvoicestatus3\".\"id\" o24, \"eninvoicestatus3\".\"label\" o25, \"eninvoicestatus3\".\"class\" o26, \"eninvoicestatus3\".\"order\" o27, \"eninvoicestatus3\".\"is_active\" o28, \"eninvoicestatus3\".\"isinaccounting\" o29, \"eninvoicestatus3\".\"labeles\" o30, \"enregion67\".\"id\" o31, \"enregion67\".\"code\" o32, \"enregion67\".\"name\" o33, \"enregion67\".\"divisionfi\" o34, \"enregion67\".\"centrortp\" o35, \"enregion67\".\"commissionregion\" o36, \"enregion67\".\"isactive\" o37, \"enregion67\".\"createdon\" o38, \"enregion67\".\"createdby\" o39, \"enregion67\".\"updatedon\" o40, \"enregion67\".\"updatedby\" o41, \"enregion67\".\"isfsp\" o42, \"enregion67\".\"isfcp\" o43, \"enrequisition76\".\"id\" o44, \"enrequisition76\".\"name\" o45, \"enrequisition76\".\"counter\" o46, \"enrequisition76\".\"requisitionstatusid\" o47, \"enrequisition76\".\"supplierid\" o48, \"enrequisition76\".\"regionid\" o49, \"enrequisition76\".\"accountingregionid\" o50, \"enrequisition76\".\"applicantid\" o51, \"enrequisition76\".\"maxdatefinishcapture\" o52, \"enrequisition76\".\"projectassetserviceid\" o53, \"enrequisition76\".\"projectassetservice\" o54, \"enrequisition76\".\"projectdescription\" o55, \"enrequisition76\".\"frequencyid\" o56, \"enrequisition76\".\"issustainability\" o57, \"enrequisition76\".\"sustainabilityid\" o58, \"enrequisition76\".\"businessvaluecategoryid\" o59, \"enrequisition76\".\"businessvaluesubcategoryid\" o60, trim_scale(\"enrequisition76\".\"totalamount\"::numeric) o61, \"enrequisition76\".\"currencyid\" o62, \"enrequisition76\".\"distributionid\" o63, \"enrequisition76\".\"costcenterid\" o64, \"enrequisition76\".\"hascontract\" o65, \"enrequisition76\".\"iscontractpending\" o66, \"enrequisition76\".\"hasdeposit\" o67, \"enrequisition76\".\"hasinsurance\" o68, \"enrequisition76\".\"hasadvancepayment\" o69, \"enrequisition76\".\"accountingservicetypeid_depr\" o70, \"enrequisition76\".\"servicedescription_deprec\" o71, \"enrequisition76\".\"invoiceusageid_deprec\" o72, \"enrequisition76\".\"serviceformatid\" o73, \"enrequisition76\".\"companyid\" o74, trim_scale(\"enrequisition76\".\"retentionrate\"::numeric) o75, trim_scale(\"enrequisition76\".\"negotiatedexchangerate\"::numeric) o76, \"enrequisition76\".\"paymentmethodid\" o77, \"enrequisition76\".\"paymenttermsid\" o78, \"enrequisition76\".\"isautomaticaccounting\" o79, \"enrequisition76\".\"createdby\" o80, \"enrequisition76\".\"createdon\" o81, \"enrequisition76\".\"updatedon\" o82, \"enrequisition76\".\"updatedby\" o83, \"enrequisition76\".\"createdbyapplicationrole\" o84, \"enrequisition76\".\"dateofcommitment\" o85, \"enrequisition76\".\"hascontractfileuploaded\" o86, \"enrequisition76\".\"hasupdateddateofcommitment\" o87, \"enrequisition76\".\"submittedon\" o88, \"enrequisition76\".\"isdonation\" o89, \"enrequisition76\".\"advwithoutinvoice\" o90, \"enrequisition76\".\"wasadvwithoutinvoice\" o91, \"enrequisition76\".\"isadvanced\" o92, \"enrequisition76\".\"documenttypeid\" o93, \"enrequisition76\".\"iscreatedbyanassistente\" o94, \"enrequisition76\".\"telceldirectionid\" o95, \"enrequisition76\".\"hasmultiupload\" o96, \"enrequisition76\".\"accountingdate\" o97, \"enrequisition76\".\"paymentoptionsid\" o98, \"enrequisition76\".\"paymentwaysid\" o99, \"enrequisition76\".\"buydocnumber\" o100, \"enrequisition76\".\"buydocposition\" o101, \"ensupplier51\".\"id\" o102, \"ensupplier51\".\"tratamiento\" o103, \"ensupplier51\".\"name\" o104, \"ensupplier51\".\"number\" o105, \"ensupplier51\".\"conceptobusq_1_2\" o106, \"ensupplier51\".\"calle_numero\" o107, \"ensupplier51\".\"distrito\" o108, \"ensupplier51\".\"codigopostal_pobl_\" o109, \"ensupplier51\".\"pais\" o110, \"ensupplier51\".\"region_\" o111, \"ensupplier51\".\"idioma\" o112, \"ensupplier51\".\"telefono\" o113, \"ensupplier51\".\"extension\" o114, \"ensupplier51\".\"fax\" o115, \"ensupplier51\".\"cliente\" o116, \"ensupplier51\".\"soc_glasociada\" o117, \"ensupplier51\".\"clavedegrupo\" o118, \"ensupplier51\".\"n_ident_fis_1\" o119, \"ensupplier51\".\"personafisica\" o120, \"ensupplier51\".\"ramo\" o121, \"ensupplier51\".\"grupodeporte\" o122, \"ensupplier51\".\"email\" o123, \"ensupplier51\".\"isactive\" o124, \"ensupplier51\".\"createdon\" o125, \"ensupplier51\".\"createdby\" o126, \"ensupplier51\".\"updatedon\" o127, \"ensupplier51\".\"updatedby\" o128, \"ensupplier51\".\"regionid\" o129");
fromBuilder.Append(" FROM (((({Invoice} \"eninvoice82\" Left JOIN {InvoiceStatus} \"eninvoicestatus3\" ON (\"eninvoice82\".\"invoicestatusid\" = \"eninvoicestatus3\".\"id\"))  Left JOIN {Requisition} \"enrequisition76\" ON (\"eninvoice82\".\"requisitionid\" = \"enrequisition76\".\"id\"))  Left JOIN {Supplier} \"ensupplier51\" ON (\"enrequisition76\".\"supplierid\" = \"ensupplier51\".\"id\"))  Left JOIN {Region} \"enregion67\" ON (\"enrequisition76\".\"regionid\" = \"enregion67\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice82\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice82\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice82\".\"id\" IS NULL)");
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
RL_e6ad6603ac07123d4d7c5f1b4a760912 outParamList = new RL_e6ad6603ac07123d4d7c5f1b4a760912();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[4] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ServiceGetInvoiceById.GetInvoiceById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e6ad6603ac07123d4d7c5f1b4a760912 _tmp = new RL_e6ad6603ac07123d4d7c5f1b4a760912();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ServiceGetInvoiceById.GetInvoiceById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e6ad6603ac07123d4d7c5f1b4a760912)_tmp;
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
