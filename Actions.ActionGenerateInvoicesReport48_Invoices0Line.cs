namespace ssConectaProveedores;

public partial class Actions {
public class lcvGenerateInvoicesReport48_Invoices0Line : VarsBag {
public long inParami_InvoiceId;
public string inParami_RequisitionFrequency;
public string inParami_RequisitionProjectPeriod;
public string inParami_RequisitionProject;
public string inParami_RequisitionName;
public DateTime inParami_RequisitionCreatedOn;
public string inParami_RequisitionCebe;
public string inParami_RequisitionCeCo;
public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord inParami_Supplier;
public int inParami_OffsetUtc;
public string inParami_Region;
public Actions.lcoGenerateInvoicesReport48_Invoices5Files resGenerateInvoicesReport48_Invoices5Files =  new Actions.lcoGenerateInvoicesReport48_Invoices5Files();
public RL_9404dc36b913809894c7e4e44e8e1dd8 queryResGetInvoiceIVA_Retencion_outParamList = new RL_9404dc36b913809894c7e4e44e8e1dd8();
public long queryResGetInvoiceIVA_Retencion_outParamCount = 0L;

public RL_540f5613fbde7a506fffd29a691298e6 queryResGetInvoiceApprovalsByInvoiceId_outParamList = new RL_540f5613fbde7a506fffd29a691298e6();
public long queryResGetInvoiceApprovalsByInvoiceId_outParamCount = 0L;

public Actions.lcoGenerateInvoicesReport48_Invoices6Approval resGenerateInvoicesReport48_Invoices6Approval =  new Actions.lcoGenerateInvoicesReport48_Invoices6Approval();
public RL_e5b15916acd557f57fb46d28151701cd queryResGetInvoicesByInvoiceId_outParamList = new RL_e5b15916acd557f57fb46d28151701cd();
public long queryResGetInvoicesByInvoiceId_outParamCount = 0L;

public RL_9404dc36b913809894c7e4e44e8e1dd8 queryResGetInvoiceISR_Retencion_outParamList = new RL_9404dc36b913809894c7e4e44e8e1dd8();
public long queryResGetInvoiceISR_Retencion_outParamCount = 0L;

public RL_ef088826c46241557fb82e7c7f21d334 queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamList = new RL_ef088826c46241557fb82e7c7f21d334();
public long queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamCount = 0L;

public lcvGenerateInvoicesReport48_Invoices0Line(long inParami_InvoiceId, string inParami_RequisitionFrequency, string inParami_RequisitionProjectPeriod, string inParami_RequisitionProject, string inParami_RequisitionName, DateTime inParami_RequisitionCreatedOn, string inParami_RequisitionCebe, string inParami_RequisitionCeCo, EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord inParami_Supplier, int inParami_OffsetUtc, string inParami_Region) {
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_RequisitionFrequency = inParami_RequisitionFrequency;
this.inParami_RequisitionProjectPeriod = inParami_RequisitionProjectPeriod;
this.inParami_RequisitionProject = inParami_RequisitionProject;
this.inParami_RequisitionName = inParami_RequisitionName;
this.inParami_RequisitionCreatedOn = inParami_RequisitionCreatedOn;
this.inParami_RequisitionCebe = inParami_RequisitionCebe;
this.inParami_RequisitionCeCo = inParami_RequisitionCeCo;
this.inParami_Supplier = inParami_Supplier;
this.inParami_OffsetUtc = inParami_OffsetUtc;
this.inParami_Region = inParami_Region;
}
}
public class lcoGenerateInvoicesReport48_Invoices0Line : VarsBag {
public ST_c882e4a9305466afcdc9cd6a9ad70f15Structure outParamo_InvoicesReport48 = new ST_c882e4a9305466afcdc9cd6a9ad70f15Structure();

public lcoGenerateInvoicesReport48_Invoices0Line() {
}
}
/// <summary>
/// Action <code>GenerateInvoicesReport48_Invoices0Line</code> that represents the Service Studio
///  action <code>GenerateInvoicesReport48_Invoices0Line</code> <p> Description
/// : GenerateInvoiceReport48_Invoices0Line</p>
/// </summary>
public static async Task<ST_c882e4a9305466afcdc9cd6a9ad70f15Structure> ActionGenerateInvoicesReport48_Invoices0Line(IRequestContext requestContext,long inParami_InvoiceId,string inParami_RequisitionFrequency,string inParami_RequisitionProjectPeriod,string inParami_RequisitionProject,string inParami_RequisitionName,DateTime inParami_RequisitionCreatedOn,string inParami_RequisitionCebe,string inParami_RequisitionCeCo,EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord inParami_Supplier,int inParami_OffsetUtc,string inParami_Region,CancellationToken cancellationToken) {
ST_c882e4a9305466afcdc9cd6a9ad70f15Structure outParamo_InvoicesReport48 = default;
lcoGenerateInvoicesReport48_Invoices0Line result = new lcoGenerateInvoicesReport48_Invoices0Line();
lcvGenerateInvoicesReport48_Invoices0Line localVars = new lcvGenerateInvoicesReport48_Invoices0Line(inParami_InvoiceId, inParami_RequisitionFrequency, inParami_RequisitionProjectPeriod, inParami_RequisitionProject, inParami_RequisitionName, inParami_RequisitionCreatedOn, inParami_RequisitionCebe, inParami_RequisitionCeCo, inParami_Supplier, inParami_OffsetUtc, inParami_Region);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GenerateInvoicesReport48_Invoices0Line", "53f32c8c-3d5b-4e77-ab58-2175434816b4"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GenerateInvoicesReport48_Invoices0Line", "53f32c8c-3d5b-4e77-ab58-2175434816b4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoicesByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoicesByInvoiceId_maxRecords = 0;
int datasetGetInvoicesByInvoiceId_startIndex = 0;(localVars.queryResGetInvoicesByInvoiceId_outParamList,localVars.queryResGetInvoicesByInvoiceId_outParamCount) = await FuncActionGenerateInvoicesReport48_Invoices0Line.datasetGetInvoicesByInvoiceId(requestContext,datasetGetInvoicesByInvoiceId_maxRecords,datasetGetInvoicesByInvoiceId_startIndex,IterationMultiplicity.Never,localVars.inParami_InvoiceId,cancellationToken);

// 1 Supplier
// o_InvoicesReport48.Region = i_Region
result.outParamo_InvoicesReport48.ssRegion = localVars.inParami_Region;

// o_InvoicesReport48.SupplierNumber = i_Supplier.Number
result.outParamo_InvoicesReport48.ssSupplierNumber = localVars.inParami_Supplier.ssNumber;

// o_InvoicesReport48.Supplier = i_Supplier.Name
result.outParamo_InvoicesReport48.ssSupplier = localVars.inParami_Supplier.ssName;

// o_InvoicesReport48.SupplierRFC = i_Supplier.N_ident_fis_1
result.outParamo_InvoicesReport48.ssSupplierRFC = localVars.inParami_Supplier.ssN_ident_fis_1;
// 2 Requisition
// o_InvoicesReport48.RequisitonName = i_RequisitionName
result.outParamo_InvoicesReport48.ssRequisitonName = localVars.inParami_RequisitionName;

// o_InvoicesReport48.RequisitionCreatedOn = If
result.outParamo_InvoicesReport48.ssRequisitionCreatedOn = (((localVars.inParami_RequisitionCreatedOn!=BuiltInFunction.NullDate ())) ? (BuiltInFunction.FormatDateTime (BuiltInFunction.AddHours (localVars.inParami_RequisitionCreatedOn, localVars.inParami_OffsetUtc), "dd/MM/yyyy")) : (""));
// Query datasetGetInvoiceExtendedMoreChargesByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceExtendedMoreChargesByInvoiceId_maxRecords = 1;
if (datasetGetInvoiceExtendedMoreChargesByInvoiceId_maxRecords < 1) datasetGetInvoiceExtendedMoreChargesByInvoiceId_maxRecords = 1;
int datasetGetInvoiceExtendedMoreChargesByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamList,localVars.queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamCount) = await FuncActionGenerateInvoicesReport48_Invoices0Line.datasetGetInvoiceExtendedMoreChargesByInvoiceId(requestContext,datasetGetInvoiceExtendedMoreChargesByInvoiceId_maxRecords,datasetGetInvoiceExtendedMoreChargesByInvoiceId_startIndex,IterationMultiplicity.Never,localVars.inParami_InvoiceId,cancellationToken);

// Query datasetGetInvoiceIVA_Retencion
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceIVA_Retencion_maxRecords = 1;
if (datasetGetInvoiceIVA_Retencion_maxRecords < 1) datasetGetInvoiceIVA_Retencion_maxRecords = 1;
int datasetGetInvoiceIVA_Retencion_startIndex = 0;(localVars.queryResGetInvoiceIVA_Retencion_outParamList,localVars.queryResGetInvoiceIVA_Retencion_outParamCount) = await FuncActionGenerateInvoicesReport48_Invoices0Line.datasetGetInvoiceIVA_Retencion(requestContext,datasetGetInvoiceIVA_Retencion_maxRecords,datasetGetInvoiceIVA_Retencion_startIndex,IterationMultiplicity.Never,localVars.inParami_InvoiceId,cancellationToken);

// Query datasetGetInvoiceISR_Retencion
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceISR_Retencion_maxRecords = 1;
if (datasetGetInvoiceISR_Retencion_maxRecords < 1) datasetGetInvoiceISR_Retencion_maxRecords = 1;
int datasetGetInvoiceISR_Retencion_startIndex = 0;(localVars.queryResGetInvoiceISR_Retencion_outParamList,localVars.queryResGetInvoiceISR_Retencion_outParamCount) = await FuncActionGenerateInvoicesReport48_Invoices0Line.datasetGetInvoiceISR_Retencion(requestContext,datasetGetInvoiceISR_Retencion_maxRecords,datasetGetInvoiceISR_Retencion_startIndex,IterationMultiplicity.Never,localVars.inParami_InvoiceId,cancellationToken);

// 3 InvoiceExt
// o_InvoicesReport48.InvoiceNumber = GetInvoicesByInvoiceId.List.Current.InvoiceExtended.Folio
result.outParamo_InvoicesReport48.ssInvoiceNumber = localVars.queryResGetInvoicesByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtended.ssFolio;

// o_InvoicesReport48.InvoiceSerie = GetInvoicesByInvoiceId.List.Current.InvoiceExtended.Serie
result.outParamo_InvoicesReport48.ssInvoiceSerie = localVars.queryResGetInvoicesByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtended.ssSerie;

// o_InvoicesReport48.InvoiceEmissionDate = If
result.outParamo_InvoicesReport48.ssInvoiceEmissionDate = (((localVars.queryResGetInvoicesByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtended.ssFechaEmision!=BuiltInFunction.DateToText(BuiltInFunction.NullDate ()))) ? (BuiltInFunction.FormatDateTime (BuiltInFunction.AddHours (BuiltInFunction.TextToDateTime (localVars.queryResGetInvoicesByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtended.ssFechaEmision), localVars.inParami_OffsetUtc), "dd/MM/yyyy")) : (""));

// o_InvoicesReport48.Subtotal = FormatCurrency
result.outParamo_InvoicesReport48.ssSubtotal = BuiltInFunction.FormatCurrency (localVars.queryResGetInvoicesByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtended.ssSubtotal, "", 2, ".", ",");

// o_InvoicesReport48.IVA = FormatCurrency
result.outParamo_InvoicesReport48.ssIVA = BuiltInFunction.FormatCurrency (localVars.queryResGetInvoicesByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtended.ssTotalIVA, "", 2, ".", ",");

// o_InvoicesReport48.RetentionIVA = FormatCurrency
result.outParamo_InvoicesReport48.ssRetentionIVA = BuiltInFunction.FormatCurrency (localVars.queryResGetInvoiceIVA_Retencion_outParamList.CurrentRec.ssENInvoiceExtendedTax.ssImporte, "", 2, ".", ",");

// o_InvoicesReport48.TotalAmount = FormatCurrency
result.outParamo_InvoicesReport48.ssTotalAmount = BuiltInFunction.FormatCurrency (localVars.queryResGetInvoicesByInvoiceId_outParamList.CurrentRec.ssENInvoice.ssTotalAmount, "", 2, ".", ",");

// o_InvoicesReport48.ISRRetention = FormatCurrency
result.outParamo_InvoicesReport48.ssISRRetention = BuiltInFunction.FormatCurrency (localVars.queryResGetInvoiceISR_Retencion_outParamList.CurrentRec.ssENInvoiceExtendedTax.ssImporte, "", 2, ".", ",");

// o_InvoicesReport48.Expenditures = FormatCurrency
result.outParamo_InvoicesReport48.ssExpenditures = BuiltInFunction.FormatCurrency (localVars.queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedMoreCharges.ssValue, "", 2, ".", ",");

// o_InvoicesReport48.Currency = GetInvoicesByInvoiceId.List.Current.Invoice.Currency
result.outParamo_InvoicesReport48.ssCurrency = localVars.queryResGetInvoicesByInvoiceId_outParamList.CurrentRec.ssENInvoice.ssCurrency;
// Query datasetGetInvoiceApprovalsByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceApprovalsByInvoiceId_maxRecords = 1;
if (datasetGetInvoiceApprovalsByInvoiceId_maxRecords < 1) datasetGetInvoiceApprovalsByInvoiceId_maxRecords = 1;
int datasetGetInvoiceApprovalsByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceApprovalsByInvoiceId_outParamList,localVars.queryResGetInvoiceApprovalsByInvoiceId_outParamCount) = await FuncActionGenerateInvoicesReport48_Invoices0Line.datasetGetInvoiceApprovalsByInvoiceId(requestContext,datasetGetInvoiceApprovalsByInvoiceId_maxRecords,datasetGetInvoiceApprovalsByInvoiceId_startIndex,IterationMultiplicity.Never,localVars.inParami_InvoiceId,cancellationToken);

// 4 System
// o_InvoicesReport48.Status = GetInvoicesByInvoiceId.List.Current.InvoiceStatus.LabelES
result.outParamo_InvoicesReport48.ssStatus = localVars.queryResGetInvoicesByInvoiceId_outParamList.CurrentRec.ssENInvoiceStatus.ssLabelES;

// o_InvoicesReport48.AssignedUser = GetInvoiceApprovalsByInvoiceId.List.Current.User.Name
result.outParamo_InvoicesReport48.ssAssignedUser = localVars.queryResGetInvoiceApprovalsByInvoiceId_outParamList.CurrentRec.ssENUser.ssName;

// o_InvoicesReport48.InvoiceCreationDate = If
result.outParamo_InvoicesReport48.ssInvoiceCreationDate = (((localVars.queryResGetInvoicesByInvoiceId_outParamList.CurrentRec.ssENInvoice.ssCreatedOn!=BuiltInFunction.NullDate ())) ? (BuiltInFunction.FormatDateTime (BuiltInFunction.AddHours (localVars.queryResGetInvoicesByInvoiceId_outParamList.CurrentRec.ssENInvoice.ssCreatedOn, localVars.inParami_OffsetUtc), "dd/MM/yyyy")) : (""));

// o_InvoicesReport48.InvoiceExpirationDate = ""
result.outParamo_InvoicesReport48.ssInvoiceExpirationDate = "";

// o_InvoicesReport48.InvoicePaymentDate = FormatDateTime
result.outParamo_InvoicesReport48.ssInvoicePaymentDate = BuiltInFunction.FormatDateTime (BuiltInFunction.AddDays (BuiltInFunction.AddDays (BuiltInFunction.AddHours (localVars.queryResGetInvoicesByInvoiceId_outParamList.CurrentRec.ssENInvoice.ssCreatedOn, localVars.inParami_OffsetUtc), BuiltInFunction.TextToInteger (localVars.queryResGetInvoicesByInvoiceId_outParamList.CurrentRec.ssENPaymentTerms.ssCtd_dias)), (await Functions.ActionGetNextMonday(requestContext,BuiltInFunction.TextToDateTime (BuiltInFunction.DateTimeToText(BuiltInFunction.AddDays (BuiltInFunction.AddHours (localVars.queryResGetInvoicesByInvoiceId_outParamList.CurrentRec.ssENInvoice.ssCreatedOn, localVars.inParami_OffsetUtc), BuiltInFunction.TextToInteger (localVars.queryResGetInvoicesByInvoiceId_outParamList.CurrentRec.ssENPaymentTerms.ssCtd_dias)))),cancellationToken))), "dd/MM/yyyy");
// 5 InvoiceExtPlus
// o_InvoicesReport48.Description = GetInvoicesByInvoiceId.List.Current.InvoiceExtendedCartaPorte.Descripcion
result.outParamo_InvoicesReport48.ssDescription = localVars.queryResGetInvoicesByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedCartaPorte.ssDescripcion;

// o_InvoicesReport48.CentrodeAtencion = GetInvoicesByInvoiceId.List.Current.InvoiceExtendedCartaPorte.CentroAtencion
result.outParamo_InvoicesReport48.ssCentrodeAtencion = localVars.queryResGetInvoicesByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedCartaPorte.ssCentroAtencion;

// o_InvoicesReport48.Street = GetInvoicesByInvoiceId.List.Current.InvoiceExtendedCartaPorte.Calle
result.outParamo_InvoicesReport48.ssStreet = localVars.queryResGetInvoicesByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedCartaPorte.ssCalle;

// o_InvoicesReport48.DoorNumber = GetInvoicesByInvoiceId.List.Current.InvoiceExtendedCartaPorte.NumeroExterior
result.outParamo_InvoicesReport48.ssDoorNumber = localVars.queryResGetInvoicesByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedCartaPorte.ssNumeroExterior;

// o_InvoicesReport48.PostalCode = GetInvoicesByInvoiceId.List.Current.InvoiceExtendedCartaPorte.CodigoPostal
result.outParamo_InvoicesReport48.ssPostalCode = localVars.queryResGetInvoicesByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedCartaPorte.ssCodigoPostal;

// o_InvoicesReport48.ImportTraslado = FormatCurrency
result.outParamo_InvoicesReport48.ssImportTraslado = BuiltInFunction.FormatCurrency (localVars.queryResGetInvoicesByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedCartaPorte.ssValorMercancia, "", 2, ".", ",");
// GenerateInvoicesReport48_Invoices5Files
localVars.resGenerateInvoicesReport48_Invoices5Files.outParamo_InvoicesReport48_Files = await Actions.ActionGenerateInvoicesReport48_Invoices5Files(requestContext,localVars.queryResGetInvoicesByInvoiceId_outParamList.CurrentRec.ssENInvoice.ssId,cancellationToken);

// 6 Files
// o_InvoicesReport48.PdfName = GenerateInvoicesReport48_Invoices5Files.o_InvoicesReport48_Files.PdfName
result.outParamo_InvoicesReport48.ssPdfName = localVars.resGenerateInvoicesReport48_Invoices5Files.outParamo_InvoicesReport48_Files.ssPdfName;

// o_InvoicesReport48.XmlName = GenerateInvoicesReport48_Invoices5Files.o_InvoicesReport48_Files.XmlName
result.outParamo_InvoicesReport48.ssXmlName = localVars.resGenerateInvoicesReport48_Invoices5Files.outParamo_InvoicesReport48_Files.ssXmlName;

// o_InvoicesReport48.UUID = GetInvoicesByInvoiceId.List.Current.InvoiceExtended.UUID
result.outParamo_InvoicesReport48.ssUUID = localVars.queryResGetInvoicesByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtended.ssUUID;

// o_InvoicesReport48.IDCeCo = i_RequisitionCeCo
result.outParamo_InvoicesReport48.ssIDCeCo = localVars.inParami_RequisitionCeCo;

// o_InvoicesReport48.CostCenters = GenerateInvoicesReport48_Invoices5Files.o_InvoicesReport48_Files.CostCenters
result.outParamo_InvoicesReport48.ssCostCenters = localVars.resGenerateInvoicesReport48_Invoices5Files.outParamo_InvoicesReport48_Files.ssCostCenters;

// o_InvoicesReport48.IDCeBe = i_RequisitionCebe
result.outParamo_InvoicesReport48.ssIDCeBe = localVars.inParami_RequisitionCebe;
// GenerateInvoicesReport48_Invoices6Approval
localVars.resGenerateInvoicesReport48_Invoices6Approval.outParamo_InvoicesReport48_Approval = await Actions.ActionGenerateInvoicesReport48_Invoices6Approval(requestContext,localVars.inParami_InvoiceId,cancellationToken);

// 7 Approval
// o_InvoicesReport48.ApprovingUsers = GenerateInvoicesReport48_Invoices6Approval.o_InvoicesReport48_Approval.ApprovingUsers
result.outParamo_InvoicesReport48.ssApprovingUsers = localVars.resGenerateInvoicesReport48_Invoices6Approval.outParamo_InvoicesReport48_Approval.ssApprovingUsers;

// o_InvoicesReport48.InvoiceApprovalDate = If
result.outParamo_InvoicesReport48.ssInvoiceApprovalDate = (((localVars.resGenerateInvoicesReport48_Invoices6Approval.outParamo_InvoicesReport48_Approval.ssInvoiceApprovalDate!=BuiltInFunction.NullDate ())) ? (BuiltInFunction.FormatDateTime (BuiltInFunction.AddHours (localVars.resGenerateInvoicesReport48_Invoices6Approval.outParamo_InvoicesReport48_Approval.ssInvoiceApprovalDate, localVars.inParami_OffsetUtc), "dd/MM/yyyy")) : (""));
// 8 Request
// o_InvoicesReport48.ProjectPeriod = i_RequisitionProjectPeriod
result.outParamo_InvoicesReport48.ssProjectPeriod = localVars.inParami_RequisitionProjectPeriod;

// o_InvoicesReport48.Project = i_RequisitionProject
result.outParamo_InvoicesReport48.ssProject = localVars.inParami_RequisitionProject;

// o_InvoicesReport48.Frequency = i_RequisitionFrequency
result.outParamo_InvoicesReport48.ssFrequency = localVars.inParami_RequisitionFrequency;
// 9 SAP
// o_InvoicesReport48.SAPNumber = GetInvoicesByInvoiceId.List.Current.Invoice.ID_POLIZA_SAP
result.outParamo_InvoicesReport48.ssSAPNumber = localVars.queryResGetInvoicesByInvoiceId_outParamList.CurrentRec.ssENInvoice.ssID_POLIZA_SAP;

// o_InvoicesReport48.SAPRegisterDate = If
result.outParamo_InvoicesReport48.ssSAPRegisterDate = (((localVars.queryResGetInvoicesByInvoiceId_outParamList.CurrentRec.ssENInvoice.ssAccountingDateTime!=BuiltInFunction.NullDate ())) ? (BuiltInFunction.FormatDateTime (BuiltInFunction.AddHours (localVars.queryResGetInvoicesByInvoiceId_outParamList.CurrentRec.ssENInvoice.ssAccountingDateTime, localVars.inParami_OffsetUtc), "dd/MM/yyyy")) : (""));
// 10 Approval
// o_InvoicesReport48.ApprovalArea = GenerateInvoicesReport48_Invoices6Approval.o_InvoicesReport48_Approval.ApprovalArea
result.outParamo_InvoicesReport48.ssApprovalArea = localVars.resGenerateInvoicesReport48_Invoices6Approval.outParamo_InvoicesReport48_Approval.ssApprovalArea;

// o_InvoicesReport48.AccountingUser = GenerateInvoicesReport48_Invoices6Approval.o_InvoicesReport48_Approval.AccountingUser
result.outParamo_InvoicesReport48.ssAccountingUser = localVars.resGenerateInvoicesReport48_Invoices6Approval.outParamo_InvoicesReport48_Approval.ssAccountingUser;
} //close CreateActionActivity using block
} // try

finally {
outParamo_InvoicesReport48 = result.outParamo_InvoicesReport48;
} // inner-finally
RETURN_STATEMENT:
return outParamo_InvoicesReport48;
}

public static class FuncActionGenerateInvoicesReport48_Invoices0Line {

// Query Function "GetInvoiceIVA_Retencion" C_9XUK8wOkKtc9hmTjmcAA of Action "GenerateInvoicesReport48_Invoices0Line"
public static async Task<(RL_9404dc36b913809894c7e4e44e8e1dd8,long)> datasetGetInvoiceIVA_Retencion(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GenerateInvoicesReport48_Invoices0Line.GetInvoiceIVA_Retencion", "5057ff0b-30af-423a-ad73-d8664e399c00");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GenerateInvoicesReport48_Invoices0Line.GetInvoiceIVA_Retencion", "5057ff0b-30af-423a-ad73-d8664e399c00", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.jCzzU1s9d06rWCF1Q0gWtA/NodesNotShownInESpaceTree.C_9XUK8wOkKtc9hmTjmcAA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, trim_scale(\"eninvoiceextendedtax3\".\"importe\"::numeric) o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceExtendedTax} \"eninvoiceextendedtax3\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendedtax3\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendedtax3\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendedtax3\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceextendedtax3\".\"invoicetaxtypeid\" = ");
whereBuilder.Append((ENInvoiceTaxTypeEntity.GetRecordByKey(ObjectKey.Parse("j+r6kWcflkqOJAI7RtHJBQ"))).ssId);
whereBuilder.Append(") AND (\"eninvoiceextendedtax3\".\"impuesto\" = '002')");
orderByBuilder.Append(" ORDER BY \"eninvoiceextendedtax3\".\"impuesto\" ASC ");
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
RL_9404dc36b913809894c7e4e44e8e1dd8 outParamList = new RL_9404dc36b913809894c7e4e44e8e1dd8();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GenerateInvoicesReport48_Invoices0Line.GetInvoiceIVA_Retencion.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9404dc36b913809894c7e4e44e8e1dd8 _tmp = new RL_9404dc36b913809894c7e4e44e8e1dd8();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GenerateInvoicesReport48_Invoices0Line.GetInvoiceIVA_Retencion.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9404dc36b913809894c7e4e44e8e1dd8)_tmp;
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

private static async Task<RC_85f15a383e9651f9f34f899ceee2be30> datasetGetInvoiceApprovalsByInvoiceIdReadDbAsync(RC_85f15a383e9651f9f34f899ceee2be30 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceApprovalsByInvoiceId" dXuSWFlicU+oVMprdQd2aA of Action "GenerateInvoicesReport48_Invoices0Line"
public static async Task<(RL_540f5613fbde7a506fffd29a691298e6,long)> datasetGetInvoiceApprovalsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceApproval_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GenerateInvoicesReport48_Invoices0Line.GetInvoiceApprovalsByInvoiceId", "58927b75-6259-4f71-a854-ca6b75077668");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GenerateInvoicesReport48_Invoices0Line.GetInvoiceApprovalsByInvoiceId", "58927b75-6259-4f71-a854-ca6b75077668", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.jCzzU1s9d06rWCF1Q0gWtA/NodesNotShownInESpaceTree.dXuSWFlicU+oVMprdQd2aA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, \"enuser58\".\"name\" o36, NULL o37, NULL o38, NULL o39");
fromBuilder.Append(" FROM (({InvoiceApproval} \"eninvoiceapproval6\" Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel7\" ON (\"eninvoiceapproval6\".\"id\" = \"eninvoiceapprovallevel7\".\"invoiceapprovalid\"))  Left JOIN {User} \"enuser58\" ON (\"eninvoiceapprovallevel7\".\"assignedto\" = \"enuser58\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceApproval_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceapproval6\".\"invoiceid\" = @qpinInvoiceApproval_InvoiceId) AND (\"eninvoiceapproval6\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceApproval_InvoiceId", DbType.Int64, qpinInvoiceApproval_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceapproval6\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceapproval6\".\"currentlevel\" = \"eninvoiceapprovallevel7\".\"levelnumber\")");
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
RL_540f5613fbde7a506fffd29a691298e6 outParamList = new RL_540f5613fbde7a506fffd29a691298e6();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceApprovalsByInvoiceIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GenerateInvoicesReport48_Invoices0Line.GetInvoiceApprovalsByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_540f5613fbde7a506fffd29a691298e6 _tmp = new RL_540f5613fbde7a506fffd29a691298e6();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceApprovalsByInvoiceIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GenerateInvoicesReport48_Invoices0Line.GetInvoiceApprovalsByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_540f5613fbde7a506fffd29a691298e6)_tmp;
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

private static async Task<RC_04cecda152c36243971fd8bd8862f207> datasetGetInvoicesByInvoiceIdReadDbAsync(RC_04cecda152c36243971fd8bd8862f207 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccounting.Read( r, ref index);
rec.ssENInvoiceExtended.Read( r, ref index);
rec.ssENInvoiceExtendedCartaPorte.Read( r, ref index);
rec.ssENInvoiceExtendedIssuer.Read( r, ref index);
rec.ssENInvoiceExtendedReceiver.Read( r, ref index);
rec.ssENInvoiceStatus.Read( r, ref index);
rec.ssENPaymentTerms.Read( r, ref index);
return rec;
}
// Query Function "GetInvoicesByInvoiceId" f3S0ypLPFUOI2Oqkr1AtfA of Action "GenerateInvoicesReport48_Invoices0Line"
public static async Task<(RL_e5b15916acd557f57fb46d28151701cd,long)> datasetGetInvoicesByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GenerateInvoicesReport48_Invoices0Line.GetInvoicesByInvoiceId", "cab4747f-cf92-4315-88d8-eaa4af502d7c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GenerateInvoicesReport48_Invoices0Line.GetInvoicesByInvoiceId", "cab4747f-cf92-4315-88d8-eaa4af502d7c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.jCzzU1s9d06rWCF1Q0gWtA/NodesNotShownInESpaceTree.f3S0ypLPFUOI2Oqkr1AtfA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice17\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, trim_scale(\"eninvoice17\".\"totalamount\"::numeric) o6, \"eninvoice17\".\"currency\" o7, NULL o8, \"eninvoice17\".\"accountingdatetime\" o9, NULL o10, \"eninvoice17\".\"createdon\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"eninvoice17\".\"id_poliza_sap\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, \"eninvoiceextended4\".\"folio\" o47, \"eninvoiceextended4\".\"serie\" o48, \"eninvoiceextended4\".\"fechaemision\" o49, NULL o50, NULL o51, NULL o52, trim_scale(\"eninvoiceextended4\".\"subtotal\"::numeric) o53, NULL o54, trim_scale(\"eninvoiceextended4\".\"totaliva\"::numeric) o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, \"eninvoiceextended4\".\"uuid\" o63, NULL o64, \"eninvoiceextendedcartaporte\".\"descripcion\" o65, trim_scale(\"eninvoiceextendedcartaporte\".\"valormercancia\"::numeric) o66, \"eninvoiceextendedcartaporte\".\"centroatencion\" o67, \"eninvoiceextendedcartaporte\".\"calle\" o68, \"eninvoiceextendedcartaporte\".\"numeroexterior\" o69, \"eninvoiceextendedcartaporte\".\"codigopostal\" o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, \"eninvoicestatus\".\"labeles\" o87, NULL o88, NULL o89, NULL o90, NULL o91, \"enpaymentterms4\".\"ctd_dias\" o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98");
fromBuilder.Append(" FROM ((((((({Invoice} \"eninvoice17\" Left JOIN {InvoiceExtended} \"eninvoiceextended4\" ON (\"eninvoice17\".\"id\" = \"eninvoiceextended4\".\"id\"))  Left JOIN {InvoiceExtendedCartaPorte} \"eninvoiceextendedcartaporte\" ON (\"eninvoice17\".\"id\" = \"eninvoiceextendedcartaporte\".\"id\"))  Left JOIN {InvoiceExtendedIssuer} \"eninvoiceextendedissuer\" ON (\"eninvoice17\".\"id\" = \"eninvoiceextendedissuer\".\"id\"))  Left JOIN {InvoiceExtendedReceiver} \"eninvoiceextendedreceiver\" ON (\"eninvoice17\".\"id\" = \"eninvoiceextendedreceiver\".\"id\"))  Left JOIN {InvoiceStatus} \"eninvoicestatus\" ON (\"eninvoice17\".\"invoicestatusid\" = \"eninvoicestatus\".\"id\"))  Left JOIN {InvoiceAccounting} \"eninvoiceaccounting4\" ON (\"eninvoice17\".\"id\" = \"eninvoiceaccounting4\".\"invoiceid\"))  Left JOIN {PaymentTerms} \"enpaymentterms4\" ON (\"eninvoiceaccounting4\".\"paymenttermsid\" = \"enpaymentterms4\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice17\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice17\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice17\".\"id\" IS NULL)");
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
RL_e5b15916acd557f57fb46d28151701cd outParamList = new RL_e5b15916acd557f57fb46d28151701cd();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesByInvoiceIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[8];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, false, false, true, false, true, false, true, true, true, true, true, true, false, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, false});
opt[2] = new BitArray(new bool[] {true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, false, false, false, false, false});
opt[4] = new BitArray(new bool[] {true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, false, false, false, true, true, true, false, true, false, true, true, true, true, true, true, true, false});
opt[7] = new BitArray(new bool[] {true, true, true, true, false, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GenerateInvoicesReport48_Invoices0Line.GetInvoicesByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e5b15916acd557f57fb46d28151701cd _tmp = new RL_e5b15916acd557f57fb46d28151701cd();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesByInvoiceIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GenerateInvoicesReport48_Invoices0Line.GetInvoicesByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e5b15916acd557f57fb46d28151701cd)_tmp;
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

// Query Function "GetInvoiceISR_Retencion" c_Dpz2VBakGwMnQ3s_59PA of Action "GenerateInvoicesReport48_Invoices0Line"
public static async Task<(RL_9404dc36b913809894c7e4e44e8e1dd8,long)> datasetGetInvoiceISR_Retencion(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GenerateInvoicesReport48_Invoices0Line.GetInvoiceISR_Retencion", "cfe9f073-4165-416a-b032-7437b3fe7d3c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GenerateInvoicesReport48_Invoices0Line.GetInvoiceISR_Retencion", "cfe9f073-4165-416a-b032-7437b3fe7d3c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.jCzzU1s9d06rWCF1Q0gWtA/NodesNotShownInESpaceTree.c_Dpz2VBakGwMnQ3s_59PA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, trim_scale(\"eninvoiceextendedtax4\".\"importe\"::numeric) o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceExtendedTax} \"eninvoiceextendedtax4\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendedtax4\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendedtax4\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendedtax4\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceextendedtax4\".\"invoicetaxtypeid\" = ");
whereBuilder.Append((ENInvoiceTaxTypeEntity.GetRecordByKey(ObjectKey.Parse("j+r6kWcflkqOJAI7RtHJBQ"))).ssId);
whereBuilder.Append(") AND (\"eninvoiceextendedtax4\".\"impuesto\" = '001')");
orderByBuilder.Append(" ORDER BY \"eninvoiceextendedtax4\".\"impuesto\" ASC ");
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
RL_9404dc36b913809894c7e4e44e8e1dd8 outParamList = new RL_9404dc36b913809894c7e4e44e8e1dd8();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GenerateInvoicesReport48_Invoices0Line.GetInvoiceISR_Retencion.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9404dc36b913809894c7e4e44e8e1dd8 _tmp = new RL_9404dc36b913809894c7e4e44e8e1dd8();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GenerateInvoicesReport48_Invoices0Line.GetInvoiceISR_Retencion.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9404dc36b913809894c7e4e44e8e1dd8)_tmp;
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

// Query Function "GetInvoiceExtendedMoreChargesByInvoiceId" O1F+14tBPUG9rIsX7_or9Q of Action "GenerateInvoicesReport48_Invoices0Line"
public static async Task<(RL_ef088826c46241557fb82e7c7f21d334,long)> datasetGetInvoiceExtendedMoreChargesByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GenerateInvoicesReport48_Invoices0Line.GetInvoiceExtendedMoreChargesByInvoiceId", "d77e513b-418b-413d-bdac-8b17effa2bf5");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GenerateInvoicesReport48_Invoices0Line.GetInvoiceExtendedMoreChargesByInvoiceId", "d77e513b-418b-413d-bdac-8b17effa2bf5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.jCzzU1s9d06rWCF1Q0gWtA/NodesNotShownInESpaceTree.O1F+14tBPUG9rIsX7_or9Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, trim_scale(\"eninvoiceextendedmorecharges1\".\"value\"::numeric) o3");
fromBuilder.Append(" FROM {InvoiceExtendedMoreCharges} \"eninvoiceextendedmorecharges1\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendedmorecharges1\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendedmorecharges1\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendedmorecharges1\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceextendedmorecharges1\".\"nombreconcepto\" = 'EROGACIONES')");
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
RL_ef088826c46241557fb82e7c7f21d334 outParamList = new RL_ef088826c46241557fb82e7c7f21d334();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GenerateInvoicesReport48_Invoices0Line.GetInvoiceExtendedMoreChargesByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ef088826c46241557fb82e7c7f21d334 _tmp = new RL_ef088826c46241557fb82e7c7f21d334();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GenerateInvoicesReport48_Invoices0Line.GetInvoiceExtendedMoreChargesByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ef088826c46241557fb82e7c7f21d334)_tmp;
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
