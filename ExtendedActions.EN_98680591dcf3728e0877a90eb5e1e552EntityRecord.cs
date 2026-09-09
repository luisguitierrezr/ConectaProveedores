using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateRequisition
/// </summary>

public static async Task<long> CreateRequisition(IRequestContext requestContext,RC_bb81744faa58ae73e7cd8db74cb32155 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateRequisition", "7b58f8dc-88e6-42ed-b0e0-6d98a36640c6.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateRequisition", "7b58f8dc-88e6-42ed-b0e0-6d98a36640c6.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENRequisitionEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Name, "name") ?? "name") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Counter, "counter") ?? "counter") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RequisitionStatusId, "requisitionstatusid") ?? "requisitionstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RegionId, "regionid") ?? "regionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingRegionId, "accountingregionid") ?? "accountingregionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ApplicantId, "applicantid") ?? "applicantid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@MaxDateFinishCapture, "maxdatefinishcapture") ?? "maxdatefinishcapture") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectAssetServiceId, "projectassetserviceid") ?? "projectassetserviceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectAssetService, "projectassetservice") ?? "projectassetservice") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectDescription, "projectdescription") ?? "projectdescription") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsSustainability, "issustainability") ?? "issustainability") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SustainabilityId, "sustainabilityid") ?? "sustainabilityid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BusinessValueCategoryId, "businessvaluecategoryid") ?? "businessvaluecategoryid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BusinessValueSubcategoryId, "businessvaluesubcategoryid") ?? "businessvaluesubcategoryid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DistributionId, "distributionid") ?? "distributionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasContract, "hascontract") ?? "hascontract") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsContractPending, "iscontractpending") ?? "iscontractpending") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasDeposit, "hasdeposit") ?? "hasdeposit") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasInsurance, "hasinsurance") ?? "hasinsurance") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasAdvancePayment, "hasadvancepayment") ?? "hasadvancepayment") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingServiceTypeId_DEPR, "accountingservicetypeid_depr") ?? "accountingservicetypeid_depr") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ServiceDescription_DEPREC, "servicedescription_deprec") ?? "servicedescription_deprec") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@InvoiceUsageId_DEPREC, "invoiceusageid_deprec") ?? "invoiceusageid_deprec") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ServiceFormatId, "serviceformatid") ?? "serviceformatid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CompanyId, "companyid") ?? "companyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RetentionRate, "retentionrate") ?? "retentionrate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@NegotiatedExchangeRate, "negotiatedexchangerate") ?? "negotiatedexchangerate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsAutomaticAccounting, "isautomaticaccounting") ?? "isautomaticaccounting") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedByApplicationRole, "createdbyapplicationrole") ?? "createdbyapplicationrole") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DateOfCommitment, "dateofcommitment") ?? "dateofcommitment") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasContractFileUploaded, "hascontractfileuploaded") ?? "hascontractfileuploaded") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasUpdatedDateOfCommitment, "hasupdateddateofcommitment") ?? "hasupdateddateofcommitment") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SubmittedOn, "submittedon") ?? "submittedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsDonation, "isdonation") ?? "isdonation") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AdvWithoutInvoice, "advwithoutinvoice") ?? "advwithoutinvoice") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@WasAdvWithoutInvoice, "wasadvwithoutinvoice") ?? "wasadvwithoutinvoice") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsAdvanced, "isadvanced") ?? "isadvanced") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DocumentTypeId, "documenttypeid") ?? "documenttypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsCreatedByAnAssistente, "iscreatedbyanassistente") ?? "iscreatedbyanassistente") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@TelcelDirectionId, "telceldirectionid") ?? "telceldirectionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasMultiUpload, "hasmultiupload") ?? "hasmultiupload") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingDate, "accountingdate") ?? "accountingdate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentOptionsId, "paymentoptionsid") ?? "paymentoptionsid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentWaysId, "paymentwaysid") ?? "paymentwaysid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition") + "" +
" ) VALUES (" +
" @ssName" +
", @ssCounter" +
", @ssRequisitionStatusId" +
", @ssSupplierId" +
", @ssRegionId" +
", @ssAccountingRegionId" +
", @ssApplicantId" +
", @ssMaxDateFinishCapture" +
", @ssProjectAssetServiceId" +
", @ssProjectAssetService" +
", @ssProjectDescription" +
", @ssFrequencyId" +
", @ssIsSustainability" +
", @ssSustainabilityId" +
", @ssBusinessValueCategoryId" +
", @ssBusinessValueSubcategoryId" +
", @ssTotalAmount" +
", @ssCurrencyId" +
", @ssDistributionId" +
", @ssCostCenterId" +
", @ssHasContract" +
", @ssIsContractPending" +
", @ssHasDeposit" +
", @ssHasInsurance" +
", @ssHasAdvancePayment" +
", @ssAccountingServiceTypeId_DEPR" +
", @ssServiceDescription_DEPREC" +
", @ssInvoiceUsageId_DEPREC" +
", @ssServiceFormatId" +
", @ssCompanyId" +
", @ssRetentionRate" +
", @ssNegotiatedExchangeRate" +
", @ssPaymentMethodId" +
", @ssPaymentTermsId" +
", @ssIsAutomaticAccounting" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssUpdatedOn" +
", @ssUpdatedBy" +
", @ssCreatedByApplicationRole" +
", @ssDateOfCommitment" +
", @ssHasContractFileUploaded" +
", @ssHasUpdatedDateOfCommitment" +
", @ssSubmittedOn" +
", @ssIsDonation" +
", @ssAdvWithoutInvoice" +
", @ssWasAdvWithoutInvoice" +
", @ssIsAdvanced" +
", @ssDocumentTypeId" +
", @ssIsCreatedByAnAssistente" +
", @ssTelcelDirectionId" +
", @ssHasMultiUpload" +
", @ssAccountingDate" +
", @ssPaymentOptionsId" +
", @ssPaymentWaysId" +
", @ssBuyDocNumber" +
", @ssBuyDocPosition" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENRequisition.ssName);
insertSqlCmd.CreateParameter("@ssCounter", DbType.Int32, ssENRequisition.ssCounter);
if ((ssENRequisition.ssRequisitionStatusId==0)) {
insertSqlCmd.CreateParameter("@ssRequisitionStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionStatusId", DbType.Int32, ssENRequisition.ssRequisitionStatusId);

}
if ((ssENRequisition.ssSupplierId==0L)) {
insertSqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, ssENRequisition.ssSupplierId);

}
if ((ssENRequisition.ssRegionId==0L)) {
insertSqlCmd.CreateParameter("@ssRegionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRegionId", DbType.Int64, ssENRequisition.ssRegionId);

}
if ((ssENRequisition.ssAccountingRegionId==0L)) {
insertSqlCmd.CreateParameter("@ssAccountingRegionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAccountingRegionId", DbType.Int64, ssENRequisition.ssAccountingRegionId);

}
if ((ssENRequisition.ssApplicantId=="")) {
insertSqlCmd.CreateParameter("@ssApplicantId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApplicantId", DbType.String, ssENRequisition.ssApplicantId);

}
insertSqlCmd.CreateParameter("@ssMaxDateFinishCapture", DbType.DateTime, ssENRequisition.ssMaxDateFinishCapture);
if ((ssENRequisition.ssProjectAssetServiceId==0L)) {
insertSqlCmd.CreateParameter("@ssProjectAssetServiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProjectAssetServiceId", DbType.Int64, ssENRequisition.ssProjectAssetServiceId);

}
insertSqlCmd.CreateParameter("@ssProjectAssetService", DbType.String, ssENRequisition.ssProjectAssetService);
insertSqlCmd.CreateParameter("@ssProjectDescription", DbType.String, ssENRequisition.ssProjectDescription);
if ((ssENRequisition.ssFrequencyId==0)) {
insertSqlCmd.CreateParameter("@ssFrequencyId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFrequencyId", DbType.Int32, ssENRequisition.ssFrequencyId);

}
insertSqlCmd.CreateParameter("@ssIsSustainability", DbType.Boolean, ssENRequisition.ssIsSustainability);
if ((ssENRequisition.ssSustainabilityId==0L)) {
insertSqlCmd.CreateParameter("@ssSustainabilityId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssSustainabilityId", DbType.Int64, ssENRequisition.ssSustainabilityId);

}
if ((ssENRequisition.ssBusinessValueCategoryId==0L)) {
insertSqlCmd.CreateParameter("@ssBusinessValueCategoryId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssBusinessValueCategoryId", DbType.Int64, ssENRequisition.ssBusinessValueCategoryId);

}
if ((ssENRequisition.ssBusinessValueSubcategoryId==0L)) {
insertSqlCmd.CreateParameter("@ssBusinessValueSubcategoryId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssBusinessValueSubcategoryId", DbType.Int64, ssENRequisition.ssBusinessValueSubcategoryId);

}
var TotalAmountParameter = insertSqlCmd.CreateParameter("@ssTotalAmount", DbType.Decimal, ssENRequisition.ssTotalAmount);
{
    string decimalAsStr = ssENRequisition.ssTotalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENRequisition.ssCurrencyId=="")) {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENRequisition.ssCurrencyId);

}
if ((ssENRequisition.ssDistributionId==0)) {
insertSqlCmd.CreateParameter("@ssDistributionId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssDistributionId", DbType.Int32, ssENRequisition.ssDistributionId);

}
if ((ssENRequisition.ssCostCenterId==0L)) {
insertSqlCmd.CreateParameter("@ssCostCenterId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCostCenterId", DbType.Int64, ssENRequisition.ssCostCenterId);

}
insertSqlCmd.CreateParameter("@ssHasContract", DbType.Boolean, ssENRequisition.ssHasContract);
insertSqlCmd.CreateParameter("@ssIsContractPending", DbType.Boolean, ssENRequisition.ssIsContractPending);
insertSqlCmd.CreateParameter("@ssHasDeposit", DbType.Boolean, ssENRequisition.ssHasDeposit);
insertSqlCmd.CreateParameter("@ssHasInsurance", DbType.Boolean, ssENRequisition.ssHasInsurance);
insertSqlCmd.CreateParameter("@ssHasAdvancePayment", DbType.Boolean, ssENRequisition.ssHasAdvancePayment);
if ((ssENRequisition.ssAccountingServiceTypeId_DEPR==0L)) {
insertSqlCmd.CreateParameter("@ssAccountingServiceTypeId_DEPR", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAccountingServiceTypeId_DEPR", DbType.Int64, ssENRequisition.ssAccountingServiceTypeId_DEPR);

}
insertSqlCmd.CreateParameter("@ssServiceDescription_DEPREC", DbType.String, ssENRequisition.ssServiceDescription_DEPREC);
if ((ssENRequisition.ssInvoiceUsageId_DEPREC==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceUsageId_DEPREC", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceUsageId_DEPREC", DbType.Int64, ssENRequisition.ssInvoiceUsageId_DEPREC);

}
if ((ssENRequisition.ssServiceFormatId==0L)) {
insertSqlCmd.CreateParameter("@ssServiceFormatId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssServiceFormatId", DbType.Int64, ssENRequisition.ssServiceFormatId);

}
if ((ssENRequisition.ssCompanyId==0L)) {
insertSqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, ssENRequisition.ssCompanyId);

}
var RetentionRateParameter = insertSqlCmd.CreateParameter("@ssRetentionRate", DbType.Decimal, ssENRequisition.ssRetentionRate);
{
    string decimalAsStr = ssENRequisition.ssRetentionRate.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {RetentionRateParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var NegotiatedExchangeRateParameter = insertSqlCmd.CreateParameter("@ssNegotiatedExchangeRate", DbType.Decimal, ssENRequisition.ssNegotiatedExchangeRate);
{
    string decimalAsStr = ssENRequisition.ssNegotiatedExchangeRate.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {NegotiatedExchangeRateParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENRequisition.ssPaymentMethodId==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentMethodId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentMethodId", DbType.Int64, ssENRequisition.ssPaymentMethodId);

}
if ((ssENRequisition.ssPaymentTermsId==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, ssENRequisition.ssPaymentTermsId);

}
insertSqlCmd.CreateParameter("@ssIsAutomaticAccounting", DbType.Boolean, ssENRequisition.ssIsAutomaticAccounting);
if ((ssENRequisition.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENRequisition.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENRequisition.ssCreatedOn);
insertSqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENRequisition.ssUpdatedOn);
if ((ssENRequisition.ssUpdatedBy=="")) {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENRequisition.ssUpdatedBy);

}
if ((ssENRequisition.ssCreatedByApplicationRole==0L)) {
insertSqlCmd.CreateParameter("@ssCreatedByApplicationRole", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedByApplicationRole", DbType.Int64, ssENRequisition.ssCreatedByApplicationRole);

}
insertSqlCmd.CreateParameter("@ssDateOfCommitment", DbType.DateTime, ssENRequisition.ssDateOfCommitment);
insertSqlCmd.CreateParameter("@ssHasContractFileUploaded", DbType.Boolean, ssENRequisition.ssHasContractFileUploaded);
insertSqlCmd.CreateParameter("@ssHasUpdatedDateOfCommitment", DbType.Boolean, ssENRequisition.ssHasUpdatedDateOfCommitment);
insertSqlCmd.CreateParameter("@ssSubmittedOn", DbType.DateTime, ssENRequisition.ssSubmittedOn);
insertSqlCmd.CreateParameter("@ssIsDonation", DbType.Boolean, ssENRequisition.ssIsDonation);
insertSqlCmd.CreateParameter("@ssAdvWithoutInvoice", DbType.Boolean, ssENRequisition.ssAdvWithoutInvoice);
insertSqlCmd.CreateParameter("@ssWasAdvWithoutInvoice", DbType.Boolean, ssENRequisition.ssWasAdvWithoutInvoice);
insertSqlCmd.CreateParameter("@ssIsAdvanced", DbType.Boolean, ssENRequisition.ssIsAdvanced);
if ((ssENRequisition.ssDocumentTypeId==0L)) {
insertSqlCmd.CreateParameter("@ssDocumentTypeId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssDocumentTypeId", DbType.Int64, ssENRequisition.ssDocumentTypeId);

}
insertSqlCmd.CreateParameter("@ssIsCreatedByAnAssistente", DbType.Boolean, ssENRequisition.ssIsCreatedByAnAssistente);
if ((ssENRequisition.ssTelcelDirectionId==0L)) {
insertSqlCmd.CreateParameter("@ssTelcelDirectionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssTelcelDirectionId", DbType.Int64, ssENRequisition.ssTelcelDirectionId);

}
insertSqlCmd.CreateParameter("@ssHasMultiUpload", DbType.Boolean, ssENRequisition.ssHasMultiUpload);
insertSqlCmd.CreateParameter("@ssAccountingDate", DbType.DateTime, ssENRequisition.ssAccountingDate);
if ((ssENRequisition.ssPaymentOptionsId==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentOptionsId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentOptionsId", DbType.Int64, ssENRequisition.ssPaymentOptionsId);

}
if ((ssENRequisition.ssPaymentWaysId==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentWaysId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentWaysId", DbType.Int64, ssENRequisition.ssPaymentWaysId);

}
insertSqlCmd.CreateParameter("@ssBuyDocNumber", DbType.String, ssENRequisition.ssBuyDocNumber);
insertSqlCmd.CreateParameter("@ssBuyDocPosition", DbType.String, ssENRequisition.ssBuyDocPosition);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateRequisition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateRequisition
/// </summary>

public static async Task<long> CreateOrUpdateRequisition(IRequestContext requestContext,BitArray usedFields,RC_bb81744faa58ae73e7cd8db74cb32155 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateRequisition", "7b58f8dc-88e6-42ed-b0e0-6d98a36640c6.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateRequisition", "7b58f8dc-88e6-42ed-b0e0-6d98a36640c6.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(58,true);
}
string updateSet = "UPDATE " + ENRequisitionEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Name, "name") ?? "name") + " = @ssName"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Counter, "counter") ?? "counter") + " = @ssCounter"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RequisitionStatusId, "requisitionstatusid") ?? "requisitionstatusid") + " = @ssRequisitionStatusId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + " = @ssSupplierId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RegionId, "regionid") ?? "regionid") + " = @ssRegionId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingRegionId, "accountingregionid") ?? "accountingregionid") + " = @ssAccountingRegionId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ApplicantId, "applicantid") ?? "applicantid") + " = @ssApplicantId"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@MaxDateFinishCapture, "maxdatefinishcapture") ?? "maxdatefinishcapture") + " = @ssMaxDateFinishCapture"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectAssetServiceId, "projectassetserviceid") ?? "projectassetserviceid") + " = @ssProjectAssetServiceId"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectAssetService, "projectassetservice") ?? "projectassetservice") + " = @ssProjectAssetService"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectDescription, "projectdescription") ?? "projectdescription") + " = @ssProjectDescription"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + " = @ssFrequencyId"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsSustainability, "issustainability") ?? "issustainability") + " = @ssIsSustainability"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SustainabilityId, "sustainabilityid") ?? "sustainabilityid") + " = @ssSustainabilityId"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BusinessValueCategoryId, "businessvaluecategoryid") ?? "businessvaluecategoryid") + " = @ssBusinessValueCategoryId"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BusinessValueSubcategoryId, "businessvaluesubcategoryid") ?? "businessvaluesubcategoryid") + " = @ssBusinessValueSubcategoryId"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + " = @ssTotalAmount"): parameters);
parameters = (usedFields[18] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + " = @ssCurrencyId"): parameters);
parameters = (usedFields[19] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DistributionId, "distributionid") ?? "distributionid") + " = @ssDistributionId"): parameters);
parameters = (usedFields[20] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid") + " = @ssCostCenterId"): parameters);
parameters = (usedFields[21] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasContract, "hascontract") ?? "hascontract") + " = @ssHasContract"): parameters);
parameters = (usedFields[22] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsContractPending, "iscontractpending") ?? "iscontractpending") + " = @ssIsContractPending"): parameters);
parameters = (usedFields[23] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasDeposit, "hasdeposit") ?? "hasdeposit") + " = @ssHasDeposit"): parameters);
parameters = (usedFields[24] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasInsurance, "hasinsurance") ?? "hasinsurance") + " = @ssHasInsurance"): parameters);
parameters = (usedFields[25] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasAdvancePayment, "hasadvancepayment") ?? "hasadvancepayment") + " = @ssHasAdvancePayment"): parameters);
parameters = (usedFields[26] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingServiceTypeId_DEPR, "accountingservicetypeid_depr") ?? "accountingservicetypeid_depr") + " = @ssAccountingServiceTypeId_DEPR"): parameters);
parameters = (usedFields[27] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ServiceDescription_DEPREC, "servicedescription_deprec") ?? "servicedescription_deprec") + " = @ssServiceDescription_DEPREC"): parameters);
parameters = (usedFields[28] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@InvoiceUsageId_DEPREC, "invoiceusageid_deprec") ?? "invoiceusageid_deprec") + " = @ssInvoiceUsageId_DEPREC"): parameters);
parameters = (usedFields[29] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ServiceFormatId, "serviceformatid") ?? "serviceformatid") + " = @ssServiceFormatId"): parameters);
parameters = (usedFields[30] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CompanyId, "companyid") ?? "companyid") + " = @ssCompanyId"): parameters);
parameters = (usedFields[31] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RetentionRate, "retentionrate") ?? "retentionrate") + " = @ssRetentionRate"): parameters);
parameters = (usedFields[32] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@NegotiatedExchangeRate, "negotiatedexchangerate") ?? "negotiatedexchangerate") + " = @ssNegotiatedExchangeRate"): parameters);
parameters = (usedFields[33] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid") + " = @ssPaymentMethodId"): parameters);
parameters = (usedFields[34] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + " = @ssPaymentTermsId"): parameters);
parameters = (usedFields[35] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsAutomaticAccounting, "isautomaticaccounting") ?? "isautomaticaccounting") + " = @ssIsAutomaticAccounting"): parameters);
parameters = (usedFields[36] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[37] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[38] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = @ssUpdatedOn"): parameters);
parameters = (usedFields[39] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + " = @ssUpdatedBy"): parameters);
parameters = (usedFields[40] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedByApplicationRole, "createdbyapplicationrole") ?? "createdbyapplicationrole") + " = @ssCreatedByApplicationRole"): parameters);
parameters = (usedFields[41] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DateOfCommitment, "dateofcommitment") ?? "dateofcommitment") + " = @ssDateOfCommitment"): parameters);
parameters = (usedFields[42] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasContractFileUploaded, "hascontractfileuploaded") ?? "hascontractfileuploaded") + " = @ssHasContractFileUploaded"): parameters);
parameters = (usedFields[43] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasUpdatedDateOfCommitment, "hasupdateddateofcommitment") ?? "hasupdateddateofcommitment") + " = @ssHasUpdatedDateOfCommitment"): parameters);
parameters = (usedFields[44] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SubmittedOn, "submittedon") ?? "submittedon") + " = @ssSubmittedOn"): parameters);
parameters = (usedFields[45] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsDonation, "isdonation") ?? "isdonation") + " = @ssIsDonation"): parameters);
parameters = (usedFields[46] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AdvWithoutInvoice, "advwithoutinvoice") ?? "advwithoutinvoice") + " = @ssAdvWithoutInvoice"): parameters);
parameters = (usedFields[47] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@WasAdvWithoutInvoice, "wasadvwithoutinvoice") ?? "wasadvwithoutinvoice") + " = @ssWasAdvWithoutInvoice"): parameters);
parameters = (usedFields[48] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsAdvanced, "isadvanced") ?? "isadvanced") + " = @ssIsAdvanced"): parameters);
parameters = (usedFields[49] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DocumentTypeId, "documenttypeid") ?? "documenttypeid") + " = @ssDocumentTypeId"): parameters);
parameters = (usedFields[50] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsCreatedByAnAssistente, "iscreatedbyanassistente") ?? "iscreatedbyanassistente") + " = @ssIsCreatedByAnAssistente"): parameters);
parameters = (usedFields[51] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@TelcelDirectionId, "telceldirectionid") ?? "telceldirectionid") + " = @ssTelcelDirectionId"): parameters);
parameters = (usedFields[52] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasMultiUpload, "hasmultiupload") ?? "hasmultiupload") + " = @ssHasMultiUpload"): parameters);
parameters = (usedFields[53] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingDate, "accountingdate") ?? "accountingdate") + " = @ssAccountingDate"): parameters);
parameters = (usedFields[54] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentOptionsId, "paymentoptionsid") ?? "paymentoptionsid") + " = @ssPaymentOptionsId"): parameters);
parameters = (usedFields[55] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentWaysId, "paymentwaysid") ?? "paymentwaysid") + " = @ssPaymentWaysId"): parameters);
parameters = (usedFields[56] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber") + " = @ssBuyDocNumber"): parameters);
parameters = (usedFields[57] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition") + " = @ssBuyDocPosition"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENRequisition_ssId_Requisition";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsSustainability, "issustainability") ?? "issustainability") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsSustainability, "issustainability") ?? "issustainability") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENRequisition.ssName);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssCounter", DbType.Int32, ssENRequisition.ssCounter);
}
if(usedFields[3]) {
if ((ssENRequisition.ssRequisitionStatusId==0)) {
sqlCmd.CreateParameter("@ssRequisitionStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionStatusId", DbType.Int32, ssENRequisition.ssRequisitionStatusId);

}
}
if(usedFields[4]) {
if ((ssENRequisition.ssSupplierId==0L)) {
sqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, ssENRequisition.ssSupplierId);

}
}
if(usedFields[5]) {
if ((ssENRequisition.ssRegionId==0L)) {
sqlCmd.CreateParameter("@ssRegionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRegionId", DbType.Int64, ssENRequisition.ssRegionId);

}
}
if(usedFields[6]) {
if ((ssENRequisition.ssAccountingRegionId==0L)) {
sqlCmd.CreateParameter("@ssAccountingRegionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAccountingRegionId", DbType.Int64, ssENRequisition.ssAccountingRegionId);

}
}
if(usedFields[7]) {
if ((ssENRequisition.ssApplicantId=="")) {
sqlCmd.CreateParameter("@ssApplicantId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApplicantId", DbType.String, ssENRequisition.ssApplicantId);

}
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssMaxDateFinishCapture", DbType.DateTime, ssENRequisition.ssMaxDateFinishCapture);
}
if(usedFields[9]) {
if ((ssENRequisition.ssProjectAssetServiceId==0L)) {
sqlCmd.CreateParameter("@ssProjectAssetServiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProjectAssetServiceId", DbType.Int64, ssENRequisition.ssProjectAssetServiceId);

}
}
if(usedFields[10]) {
sqlCmd.CreateParameter("@ssProjectAssetService", DbType.String, ssENRequisition.ssProjectAssetService);
}
if(usedFields[11]) {
sqlCmd.CreateParameter("@ssProjectDescription", DbType.String, ssENRequisition.ssProjectDescription);
}
if(usedFields[12]) {
if ((ssENRequisition.ssFrequencyId==0)) {
sqlCmd.CreateParameter("@ssFrequencyId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFrequencyId", DbType.Int32, ssENRequisition.ssFrequencyId);

}
}
if(usedFields[13]) {
sqlCmd.CreateParameter("@ssIsSustainability", DbType.Boolean, ssENRequisition.ssIsSustainability);
}
if(usedFields[14]) {
if ((ssENRequisition.ssSustainabilityId==0L)) {
sqlCmd.CreateParameter("@ssSustainabilityId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssSustainabilityId", DbType.Int64, ssENRequisition.ssSustainabilityId);

}
}
if(usedFields[15]) {
if ((ssENRequisition.ssBusinessValueCategoryId==0L)) {
sqlCmd.CreateParameter("@ssBusinessValueCategoryId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssBusinessValueCategoryId", DbType.Int64, ssENRequisition.ssBusinessValueCategoryId);

}
}
if(usedFields[16]) {
if ((ssENRequisition.ssBusinessValueSubcategoryId==0L)) {
sqlCmd.CreateParameter("@ssBusinessValueSubcategoryId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssBusinessValueSubcategoryId", DbType.Int64, ssENRequisition.ssBusinessValueSubcategoryId);

}
}
if(usedFields[17]) {
var TotalAmountParameter = sqlCmd.CreateParameter("@ssTotalAmount", DbType.Decimal, ssENRequisition.ssTotalAmount);
{
    string decimalAsStr = ssENRequisition.ssTotalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[18]) {
if ((ssENRequisition.ssCurrencyId=="")) {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENRequisition.ssCurrencyId);

}
}
if(usedFields[19]) {
if ((ssENRequisition.ssDistributionId==0)) {
sqlCmd.CreateParameter("@ssDistributionId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssDistributionId", DbType.Int32, ssENRequisition.ssDistributionId);

}
}
if(usedFields[20]) {
if ((ssENRequisition.ssCostCenterId==0L)) {
sqlCmd.CreateParameter("@ssCostCenterId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCostCenterId", DbType.Int64, ssENRequisition.ssCostCenterId);

}
}
if(usedFields[21]) {
sqlCmd.CreateParameter("@ssHasContract", DbType.Boolean, ssENRequisition.ssHasContract);
}
if(usedFields[22]) {
sqlCmd.CreateParameter("@ssIsContractPending", DbType.Boolean, ssENRequisition.ssIsContractPending);
}
if(usedFields[23]) {
sqlCmd.CreateParameter("@ssHasDeposit", DbType.Boolean, ssENRequisition.ssHasDeposit);
}
if(usedFields[24]) {
sqlCmd.CreateParameter("@ssHasInsurance", DbType.Boolean, ssENRequisition.ssHasInsurance);
}
if(usedFields[25]) {
sqlCmd.CreateParameter("@ssHasAdvancePayment", DbType.Boolean, ssENRequisition.ssHasAdvancePayment);
}
if(usedFields[26]) {
if ((ssENRequisition.ssAccountingServiceTypeId_DEPR==0L)) {
sqlCmd.CreateParameter("@ssAccountingServiceTypeId_DEPR", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAccountingServiceTypeId_DEPR", DbType.Int64, ssENRequisition.ssAccountingServiceTypeId_DEPR);

}
}
if(usedFields[27]) {
sqlCmd.CreateParameter("@ssServiceDescription_DEPREC", DbType.String, ssENRequisition.ssServiceDescription_DEPREC);
}
if(usedFields[28]) {
if ((ssENRequisition.ssInvoiceUsageId_DEPREC==0L)) {
sqlCmd.CreateParameter("@ssInvoiceUsageId_DEPREC", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceUsageId_DEPREC", DbType.Int64, ssENRequisition.ssInvoiceUsageId_DEPREC);

}
}
if(usedFields[29]) {
if ((ssENRequisition.ssServiceFormatId==0L)) {
sqlCmd.CreateParameter("@ssServiceFormatId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssServiceFormatId", DbType.Int64, ssENRequisition.ssServiceFormatId);

}
}
if(usedFields[30]) {
if ((ssENRequisition.ssCompanyId==0L)) {
sqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, ssENRequisition.ssCompanyId);

}
}
if(usedFields[31]) {
var RetentionRateParameter = sqlCmd.CreateParameter("@ssRetentionRate", DbType.Decimal, ssENRequisition.ssRetentionRate);
{
    string decimalAsStr = ssENRequisition.ssRetentionRate.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {RetentionRateParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[32]) {
var NegotiatedExchangeRateParameter = sqlCmd.CreateParameter("@ssNegotiatedExchangeRate", DbType.Decimal, ssENRequisition.ssNegotiatedExchangeRate);
{
    string decimalAsStr = ssENRequisition.ssNegotiatedExchangeRate.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {NegotiatedExchangeRateParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[33]) {
if ((ssENRequisition.ssPaymentMethodId==0L)) {
sqlCmd.CreateParameter("@ssPaymentMethodId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentMethodId", DbType.Int64, ssENRequisition.ssPaymentMethodId);

}
}
if(usedFields[34]) {
if ((ssENRequisition.ssPaymentTermsId==0L)) {
sqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, ssENRequisition.ssPaymentTermsId);

}
}
if(usedFields[35]) {
sqlCmd.CreateParameter("@ssIsAutomaticAccounting", DbType.Boolean, ssENRequisition.ssIsAutomaticAccounting);
}
if(usedFields[36]) {
if ((ssENRequisition.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENRequisition.ssCreatedBy);

}
}
if(usedFields[37]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENRequisition.ssCreatedOn);
}
if(usedFields[38]) {
sqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENRequisition.ssUpdatedOn);
}
if(usedFields[39]) {
if ((ssENRequisition.ssUpdatedBy=="")) {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENRequisition.ssUpdatedBy);

}
}
if(usedFields[40]) {
if ((ssENRequisition.ssCreatedByApplicationRole==0L)) {
sqlCmd.CreateParameter("@ssCreatedByApplicationRole", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedByApplicationRole", DbType.Int64, ssENRequisition.ssCreatedByApplicationRole);

}
}
if(usedFields[41]) {
sqlCmd.CreateParameter("@ssDateOfCommitment", DbType.DateTime, ssENRequisition.ssDateOfCommitment);
}
if(usedFields[42]) {
sqlCmd.CreateParameter("@ssHasContractFileUploaded", DbType.Boolean, ssENRequisition.ssHasContractFileUploaded);
}
if(usedFields[43]) {
sqlCmd.CreateParameter("@ssHasUpdatedDateOfCommitment", DbType.Boolean, ssENRequisition.ssHasUpdatedDateOfCommitment);
}
if(usedFields[44]) {
sqlCmd.CreateParameter("@ssSubmittedOn", DbType.DateTime, ssENRequisition.ssSubmittedOn);
}
if(usedFields[45]) {
sqlCmd.CreateParameter("@ssIsDonation", DbType.Boolean, ssENRequisition.ssIsDonation);
}
if(usedFields[46]) {
sqlCmd.CreateParameter("@ssAdvWithoutInvoice", DbType.Boolean, ssENRequisition.ssAdvWithoutInvoice);
}
if(usedFields[47]) {
sqlCmd.CreateParameter("@ssWasAdvWithoutInvoice", DbType.Boolean, ssENRequisition.ssWasAdvWithoutInvoice);
}
if(usedFields[48]) {
sqlCmd.CreateParameter("@ssIsAdvanced", DbType.Boolean, ssENRequisition.ssIsAdvanced);
}
if(usedFields[49]) {
if ((ssENRequisition.ssDocumentTypeId==0L)) {
sqlCmd.CreateParameter("@ssDocumentTypeId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssDocumentTypeId", DbType.Int64, ssENRequisition.ssDocumentTypeId);

}
}
if(usedFields[50]) {
sqlCmd.CreateParameter("@ssIsCreatedByAnAssistente", DbType.Boolean, ssENRequisition.ssIsCreatedByAnAssistente);
}
if(usedFields[51]) {
if ((ssENRequisition.ssTelcelDirectionId==0L)) {
sqlCmd.CreateParameter("@ssTelcelDirectionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssTelcelDirectionId", DbType.Int64, ssENRequisition.ssTelcelDirectionId);

}
}
if(usedFields[52]) {
sqlCmd.CreateParameter("@ssHasMultiUpload", DbType.Boolean, ssENRequisition.ssHasMultiUpload);
}
if(usedFields[53]) {
sqlCmd.CreateParameter("@ssAccountingDate", DbType.DateTime, ssENRequisition.ssAccountingDate);
}
if(usedFields[54]) {
if ((ssENRequisition.ssPaymentOptionsId==0L)) {
sqlCmd.CreateParameter("@ssPaymentOptionsId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentOptionsId", DbType.Int64, ssENRequisition.ssPaymentOptionsId);

}
}
if(usedFields[55]) {
if ((ssENRequisition.ssPaymentWaysId==0L)) {
sqlCmd.CreateParameter("@ssPaymentWaysId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentWaysId", DbType.Int64, ssENRequisition.ssPaymentWaysId);

}
}
if(usedFields[56]) {
sqlCmd.CreateParameter("@ssBuyDocNumber", DbType.String, ssENRequisition.ssBuyDocNumber);
}
if(usedFields[57]) {
sqlCmd.CreateParameter("@ssBuyDocPosition", DbType.String, ssENRequisition.ssBuyDocPosition);
}
sqlCmd.CreateParameter("@idparam_ssENRequisition_ssId_Requisition", DbType.Int64, ssENRequisition.ssId);
int counter = 0;
if(ssENRequisition.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateRequisition (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENRequisitionEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Name, "name") ?? "name") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Counter, "counter") ?? "counter") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RequisitionStatusId, "requisitionstatusid") ?? "requisitionstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RegionId, "regionid") ?? "regionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingRegionId, "accountingregionid") ?? "accountingregionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ApplicantId, "applicantid") ?? "applicantid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@MaxDateFinishCapture, "maxdatefinishcapture") ?? "maxdatefinishcapture") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectAssetServiceId, "projectassetserviceid") ?? "projectassetserviceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectAssetService, "projectassetservice") ?? "projectassetservice") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectDescription, "projectdescription") ?? "projectdescription") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsSustainability, "issustainability") ?? "issustainability") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SustainabilityId, "sustainabilityid") ?? "sustainabilityid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BusinessValueCategoryId, "businessvaluecategoryid") ?? "businessvaluecategoryid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BusinessValueSubcategoryId, "businessvaluesubcategoryid") ?? "businessvaluesubcategoryid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DistributionId, "distributionid") ?? "distributionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasContract, "hascontract") ?? "hascontract") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsContractPending, "iscontractpending") ?? "iscontractpending") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasDeposit, "hasdeposit") ?? "hasdeposit") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasInsurance, "hasinsurance") ?? "hasinsurance") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasAdvancePayment, "hasadvancepayment") ?? "hasadvancepayment") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingServiceTypeId_DEPR, "accountingservicetypeid_depr") ?? "accountingservicetypeid_depr") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ServiceDescription_DEPREC, "servicedescription_deprec") ?? "servicedescription_deprec") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@InvoiceUsageId_DEPREC, "invoiceusageid_deprec") ?? "invoiceusageid_deprec") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ServiceFormatId, "serviceformatid") ?? "serviceformatid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CompanyId, "companyid") ?? "companyid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RetentionRate, "retentionrate") ?? "retentionrate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@NegotiatedExchangeRate, "negotiatedexchangerate") ?? "negotiatedexchangerate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsAutomaticAccounting, "isautomaticaccounting") ?? "isautomaticaccounting") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedByApplicationRole, "createdbyapplicationrole") ?? "createdbyapplicationrole") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DateOfCommitment, "dateofcommitment") ?? "dateofcommitment") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasContractFileUploaded, "hascontractfileuploaded") ?? "hascontractfileuploaded") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasUpdatedDateOfCommitment, "hasupdateddateofcommitment") ?? "hasupdateddateofcommitment") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SubmittedOn, "submittedon") ?? "submittedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsDonation, "isdonation") ?? "isdonation") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AdvWithoutInvoice, "advwithoutinvoice") ?? "advwithoutinvoice") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@WasAdvWithoutInvoice, "wasadvwithoutinvoice") ?? "wasadvwithoutinvoice") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsAdvanced, "isadvanced") ?? "isadvanced") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DocumentTypeId, "documenttypeid") ?? "documenttypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsCreatedByAnAssistente, "iscreatedbyanassistente") ?? "iscreatedbyanassistente") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@TelcelDirectionId, "telceldirectionid") ?? "telceldirectionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasMultiUpload, "hasmultiupload") ?? "hasmultiupload") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingDate, "accountingdate") ?? "accountingdate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentOptionsId, "paymentoptionsid") ?? "paymentoptionsid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentWaysId, "paymentwaysid") ?? "paymentwaysid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition") + "" +
" ) VALUES (" +
" @ssName" +
", @ssCounter" +
", @ssRequisitionStatusId" +
", @ssSupplierId" +
", @ssRegionId" +
", @ssAccountingRegionId" +
", @ssApplicantId" +
", @ssMaxDateFinishCapture" +
", @ssProjectAssetServiceId" +
", @ssProjectAssetService" +
", @ssProjectDescription" +
", @ssFrequencyId" +
", @ssIsSustainability" +
", @ssSustainabilityId" +
", @ssBusinessValueCategoryId" +
", @ssBusinessValueSubcategoryId" +
", @ssTotalAmount" +
", @ssCurrencyId" +
", @ssDistributionId" +
", @ssCostCenterId" +
", @ssHasContract" +
", @ssIsContractPending" +
", @ssHasDeposit" +
", @ssHasInsurance" +
", @ssHasAdvancePayment" +
", @ssAccountingServiceTypeId_DEPR" +
", @ssServiceDescription_DEPREC" +
", @ssInvoiceUsageId_DEPREC" +
", @ssServiceFormatId" +
", @ssCompanyId" +
", @ssRetentionRate" +
", @ssNegotiatedExchangeRate" +
", @ssPaymentMethodId" +
", @ssPaymentTermsId" +
", @ssIsAutomaticAccounting" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssUpdatedOn" +
", @ssUpdatedBy" +
", @ssCreatedByApplicationRole" +
", @ssDateOfCommitment" +
", @ssHasContractFileUploaded" +
", @ssHasUpdatedDateOfCommitment" +
", @ssSubmittedOn" +
", @ssIsDonation" +
", @ssAdvWithoutInvoice" +
", @ssWasAdvWithoutInvoice" +
", @ssIsAdvanced" +
", @ssDocumentTypeId" +
", @ssIsCreatedByAnAssistente" +
", @ssTelcelDirectionId" +
", @ssHasMultiUpload" +
", @ssAccountingDate" +
", @ssPaymentOptionsId" +
", @ssPaymentWaysId" +
", @ssBuyDocNumber" +
", @ssBuyDocPosition" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssName", DbType.String, ssENRequisition.ssName);
insertSqlCmd.CreateParameter("@ssCounter", DbType.Int32, ssENRequisition.ssCounter);
if ((ssENRequisition.ssRequisitionStatusId==0)) {
insertSqlCmd.CreateParameter("@ssRequisitionStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRequisitionStatusId", DbType.Int32, ssENRequisition.ssRequisitionStatusId);

}
if ((ssENRequisition.ssSupplierId==0L)) {
insertSqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, ssENRequisition.ssSupplierId);

}
if ((ssENRequisition.ssRegionId==0L)) {
insertSqlCmd.CreateParameter("@ssRegionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRegionId", DbType.Int64, ssENRequisition.ssRegionId);

}
if ((ssENRequisition.ssAccountingRegionId==0L)) {
insertSqlCmd.CreateParameter("@ssAccountingRegionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAccountingRegionId", DbType.Int64, ssENRequisition.ssAccountingRegionId);

}
if ((ssENRequisition.ssApplicantId=="")) {
insertSqlCmd.CreateParameter("@ssApplicantId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssApplicantId", DbType.String, ssENRequisition.ssApplicantId);

}
insertSqlCmd.CreateParameter("@ssMaxDateFinishCapture", DbType.DateTime, ssENRequisition.ssMaxDateFinishCapture);
if ((ssENRequisition.ssProjectAssetServiceId==0L)) {
insertSqlCmd.CreateParameter("@ssProjectAssetServiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProjectAssetServiceId", DbType.Int64, ssENRequisition.ssProjectAssetServiceId);

}
insertSqlCmd.CreateParameter("@ssProjectAssetService", DbType.String, ssENRequisition.ssProjectAssetService);
insertSqlCmd.CreateParameter("@ssProjectDescription", DbType.String, ssENRequisition.ssProjectDescription);
if ((ssENRequisition.ssFrequencyId==0)) {
insertSqlCmd.CreateParameter("@ssFrequencyId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFrequencyId", DbType.Int32, ssENRequisition.ssFrequencyId);

}
insertSqlCmd.CreateParameter("@ssIsSustainability", DbType.Boolean, ssENRequisition.ssIsSustainability);
if ((ssENRequisition.ssSustainabilityId==0L)) {
insertSqlCmd.CreateParameter("@ssSustainabilityId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssSustainabilityId", DbType.Int64, ssENRequisition.ssSustainabilityId);

}
if ((ssENRequisition.ssBusinessValueCategoryId==0L)) {
insertSqlCmd.CreateParameter("@ssBusinessValueCategoryId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssBusinessValueCategoryId", DbType.Int64, ssENRequisition.ssBusinessValueCategoryId);

}
if ((ssENRequisition.ssBusinessValueSubcategoryId==0L)) {
insertSqlCmd.CreateParameter("@ssBusinessValueSubcategoryId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssBusinessValueSubcategoryId", DbType.Int64, ssENRequisition.ssBusinessValueSubcategoryId);

}
var TotalAmountParameter = insertSqlCmd.CreateParameter("@ssTotalAmount", DbType.Decimal, ssENRequisition.ssTotalAmount);
{
    string decimalAsStr = ssENRequisition.ssTotalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENRequisition.ssCurrencyId=="")) {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENRequisition.ssCurrencyId);

}
if ((ssENRequisition.ssDistributionId==0)) {
insertSqlCmd.CreateParameter("@ssDistributionId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssDistributionId", DbType.Int32, ssENRequisition.ssDistributionId);

}
if ((ssENRequisition.ssCostCenterId==0L)) {
insertSqlCmd.CreateParameter("@ssCostCenterId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCostCenterId", DbType.Int64, ssENRequisition.ssCostCenterId);

}
insertSqlCmd.CreateParameter("@ssHasContract", DbType.Boolean, ssENRequisition.ssHasContract);
insertSqlCmd.CreateParameter("@ssIsContractPending", DbType.Boolean, ssENRequisition.ssIsContractPending);
insertSqlCmd.CreateParameter("@ssHasDeposit", DbType.Boolean, ssENRequisition.ssHasDeposit);
insertSqlCmd.CreateParameter("@ssHasInsurance", DbType.Boolean, ssENRequisition.ssHasInsurance);
insertSqlCmd.CreateParameter("@ssHasAdvancePayment", DbType.Boolean, ssENRequisition.ssHasAdvancePayment);
if ((ssENRequisition.ssAccountingServiceTypeId_DEPR==0L)) {
insertSqlCmd.CreateParameter("@ssAccountingServiceTypeId_DEPR", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssAccountingServiceTypeId_DEPR", DbType.Int64, ssENRequisition.ssAccountingServiceTypeId_DEPR);

}
insertSqlCmd.CreateParameter("@ssServiceDescription_DEPREC", DbType.String, ssENRequisition.ssServiceDescription_DEPREC);
if ((ssENRequisition.ssInvoiceUsageId_DEPREC==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceUsageId_DEPREC", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceUsageId_DEPREC", DbType.Int64, ssENRequisition.ssInvoiceUsageId_DEPREC);

}
if ((ssENRequisition.ssServiceFormatId==0L)) {
insertSqlCmd.CreateParameter("@ssServiceFormatId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssServiceFormatId", DbType.Int64, ssENRequisition.ssServiceFormatId);

}
if ((ssENRequisition.ssCompanyId==0L)) {
insertSqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, ssENRequisition.ssCompanyId);

}
var RetentionRateParameter = insertSqlCmd.CreateParameter("@ssRetentionRate", DbType.Decimal, ssENRequisition.ssRetentionRate);
{
    string decimalAsStr = ssENRequisition.ssRetentionRate.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {RetentionRateParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var NegotiatedExchangeRateParameter = insertSqlCmd.CreateParameter("@ssNegotiatedExchangeRate", DbType.Decimal, ssENRequisition.ssNegotiatedExchangeRate);
{
    string decimalAsStr = ssENRequisition.ssNegotiatedExchangeRate.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {NegotiatedExchangeRateParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENRequisition.ssPaymentMethodId==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentMethodId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentMethodId", DbType.Int64, ssENRequisition.ssPaymentMethodId);

}
if ((ssENRequisition.ssPaymentTermsId==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, ssENRequisition.ssPaymentTermsId);

}
insertSqlCmd.CreateParameter("@ssIsAutomaticAccounting", DbType.Boolean, ssENRequisition.ssIsAutomaticAccounting);
if ((ssENRequisition.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENRequisition.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENRequisition.ssCreatedOn);
insertSqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENRequisition.ssUpdatedOn);
if ((ssENRequisition.ssUpdatedBy=="")) {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENRequisition.ssUpdatedBy);

}
if ((ssENRequisition.ssCreatedByApplicationRole==0L)) {
insertSqlCmd.CreateParameter("@ssCreatedByApplicationRole", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedByApplicationRole", DbType.Int64, ssENRequisition.ssCreatedByApplicationRole);

}
insertSqlCmd.CreateParameter("@ssDateOfCommitment", DbType.DateTime, ssENRequisition.ssDateOfCommitment);
insertSqlCmd.CreateParameter("@ssHasContractFileUploaded", DbType.Boolean, ssENRequisition.ssHasContractFileUploaded);
insertSqlCmd.CreateParameter("@ssHasUpdatedDateOfCommitment", DbType.Boolean, ssENRequisition.ssHasUpdatedDateOfCommitment);
insertSqlCmd.CreateParameter("@ssSubmittedOn", DbType.DateTime, ssENRequisition.ssSubmittedOn);
insertSqlCmd.CreateParameter("@ssIsDonation", DbType.Boolean, ssENRequisition.ssIsDonation);
insertSqlCmd.CreateParameter("@ssAdvWithoutInvoice", DbType.Boolean, ssENRequisition.ssAdvWithoutInvoice);
insertSqlCmd.CreateParameter("@ssWasAdvWithoutInvoice", DbType.Boolean, ssENRequisition.ssWasAdvWithoutInvoice);
insertSqlCmd.CreateParameter("@ssIsAdvanced", DbType.Boolean, ssENRequisition.ssIsAdvanced);
if ((ssENRequisition.ssDocumentTypeId==0L)) {
insertSqlCmd.CreateParameter("@ssDocumentTypeId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssDocumentTypeId", DbType.Int64, ssENRequisition.ssDocumentTypeId);

}
insertSqlCmd.CreateParameter("@ssIsCreatedByAnAssistente", DbType.Boolean, ssENRequisition.ssIsCreatedByAnAssistente);
if ((ssENRequisition.ssTelcelDirectionId==0L)) {
insertSqlCmd.CreateParameter("@ssTelcelDirectionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssTelcelDirectionId", DbType.Int64, ssENRequisition.ssTelcelDirectionId);

}
insertSqlCmd.CreateParameter("@ssHasMultiUpload", DbType.Boolean, ssENRequisition.ssHasMultiUpload);
insertSqlCmd.CreateParameter("@ssAccountingDate", DbType.DateTime, ssENRequisition.ssAccountingDate);
if ((ssENRequisition.ssPaymentOptionsId==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentOptionsId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentOptionsId", DbType.Int64, ssENRequisition.ssPaymentOptionsId);

}
if ((ssENRequisition.ssPaymentWaysId==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentWaysId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentWaysId", DbType.Int64, ssENRequisition.ssPaymentWaysId);

}
insertSqlCmd.CreateParameter("@ssBuyDocNumber", DbType.String, ssENRequisition.ssBuyDocNumber);
insertSqlCmd.CreateParameter("@ssBuyDocPosition", DbType.String, ssENRequisition.ssBuyDocPosition);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateRequisition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENRequisition.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeRequisition
/// </summary>

public static async Task CreateOrUpdateSomeRequisition(IRequestContext requestContext,RL_0ad79b64673379e41188da81c3628c0f inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeRequisition", "7b58f8dc-88e6-42ed-b0e0-6d98a36640c6.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeRequisition", "7b58f8dc-88e6-42ed-b0e0-6d98a36640c6.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENRequisitionEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Name, "name") ?? "name") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Counter, "counter") ?? "counter") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RequisitionStatusId, "requisitionstatusid") ?? "requisitionstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RegionId, "regionid") ?? "regionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingRegionId, "accountingregionid") ?? "accountingregionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ApplicantId, "applicantid") ?? "applicantid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@MaxDateFinishCapture, "maxdatefinishcapture") ?? "maxdatefinishcapture") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectAssetServiceId, "projectassetserviceid") ?? "projectassetserviceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectAssetService, "projectassetservice") ?? "projectassetservice") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectDescription, "projectdescription") ?? "projectdescription") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsSustainability, "issustainability") ?? "issustainability") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SustainabilityId, "sustainabilityid") ?? "sustainabilityid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BusinessValueCategoryId, "businessvaluecategoryid") ?? "businessvaluecategoryid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BusinessValueSubcategoryId, "businessvaluesubcategoryid") ?? "businessvaluesubcategoryid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DistributionId, "distributionid") ?? "distributionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasContract, "hascontract") ?? "hascontract") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsContractPending, "iscontractpending") ?? "iscontractpending") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasDeposit, "hasdeposit") ?? "hasdeposit") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasInsurance, "hasinsurance") ?? "hasinsurance") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasAdvancePayment, "hasadvancepayment") ?? "hasadvancepayment") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingServiceTypeId_DEPR, "accountingservicetypeid_depr") ?? "accountingservicetypeid_depr") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ServiceDescription_DEPREC, "servicedescription_deprec") ?? "servicedescription_deprec") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@InvoiceUsageId_DEPREC, "invoiceusageid_deprec") ?? "invoiceusageid_deprec") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ServiceFormatId, "serviceformatid") ?? "serviceformatid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CompanyId, "companyid") ?? "companyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RetentionRate, "retentionrate") ?? "retentionrate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@NegotiatedExchangeRate, "negotiatedexchangerate") ?? "negotiatedexchangerate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsAutomaticAccounting, "isautomaticaccounting") ?? "isautomaticaccounting") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedByApplicationRole, "createdbyapplicationrole") ?? "createdbyapplicationrole") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DateOfCommitment, "dateofcommitment") ?? "dateofcommitment") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasContractFileUploaded, "hascontractfileuploaded") ?? "hascontractfileuploaded") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasUpdatedDateOfCommitment, "hasupdateddateofcommitment") ?? "hasupdateddateofcommitment") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SubmittedOn, "submittedon") ?? "submittedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsDonation, "isdonation") ?? "isdonation") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AdvWithoutInvoice, "advwithoutinvoice") ?? "advwithoutinvoice") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@WasAdvWithoutInvoice, "wasadvwithoutinvoice") ?? "wasadvwithoutinvoice") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsAdvanced, "isadvanced") ?? "isadvanced") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DocumentTypeId, "documenttypeid") ?? "documenttypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsCreatedByAnAssistente, "iscreatedbyanassistente") ?? "iscreatedbyanassistente") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@TelcelDirectionId, "telceldirectionid") ?? "telceldirectionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasMultiUpload, "hasmultiupload") ?? "hasmultiupload") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingDate, "accountingdate") ?? "accountingdate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentOptionsId, "paymentoptionsid") ?? "paymentoptionsid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentWaysId, "paymentwaysid") ?? "paymentwaysid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition") + ") VALUES ( unnest(@ssName),  unnest(@ssCounter),  unnest(@ssRequisitionStatusId),  unnest(@ssSupplierId),  unnest(@ssRegionId),  unnest(@ssAccountingRegionId),  unnest(@ssApplicantId),  unnest(@ssMaxDateFinishCapture),  unnest(@ssProjectAssetServiceId),  unnest(@ssProjectAssetService),  unnest(@ssProjectDescription),  unnest(@ssFrequencyId),  unnest(@ssIsSustainability),  unnest(@ssSustainabilityId),  unnest(@ssBusinessValueCategoryId),  unnest(@ssBusinessValueSubcategoryId),  unnest(@ssTotalAmount),  unnest(@ssCurrencyId),  unnest(@ssDistributionId),  unnest(@ssCostCenterId),  unnest(@ssHasContract),  unnest(@ssIsContractPending),  unnest(@ssHasDeposit),  unnest(@ssHasInsurance),  unnest(@ssHasAdvancePayment),  unnest(@ssAccountingServiceTypeId_DEPR),  unnest(@ssServiceDescription_DEPREC),  unnest(@ssInvoiceUsageId_DEPREC),  unnest(@ssServiceFormatId),  unnest(@ssCompanyId),  unnest(@ssRetentionRate),  unnest(@ssNegotiatedExchangeRate),  unnest(@ssPaymentMethodId),  unnest(@ssPaymentTermsId),  unnest(@ssIsAutomaticAccounting),  unnest(@ssCreatedBy),  unnest(@ssCreatedOn),  unnest(@ssUpdatedOn),  unnest(@ssUpdatedBy),  unnest(@ssCreatedByApplicationRole),  unnest(@ssDateOfCommitment),  unnest(@ssHasContractFileUploaded),  unnest(@ssHasUpdatedDateOfCommitment),  unnest(@ssSubmittedOn),  unnest(@ssIsDonation),  unnest(@ssAdvWithoutInvoice),  unnest(@ssWasAdvWithoutInvoice),  unnest(@ssIsAdvanced),  unnest(@ssDocumentTypeId),  unnest(@ssIsCreatedByAnAssistente),  unnest(@ssTelcelDirectionId),  unnest(@ssHasMultiUpload),  unnest(@ssAccountingDate),  unnest(@ssPaymentOptionsId),  unnest(@ssPaymentWaysId),  unnest(@ssBuyDocNumber),  unnest(@ssBuyDocPosition)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Name, "name") ?? "name") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Name, "name") ?? "name") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Counter, "counter") ?? "counter") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Counter, "counter") ?? "counter") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RequisitionStatusId, "requisitionstatusid") ?? "requisitionstatusid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RequisitionStatusId, "requisitionstatusid") ?? "requisitionstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RegionId, "regionid") ?? "regionid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RegionId, "regionid") ?? "regionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingRegionId, "accountingregionid") ?? "accountingregionid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingRegionId, "accountingregionid") ?? "accountingregionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ApplicantId, "applicantid") ?? "applicantid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ApplicantId, "applicantid") ?? "applicantid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@MaxDateFinishCapture, "maxdatefinishcapture") ?? "maxdatefinishcapture") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@MaxDateFinishCapture, "maxdatefinishcapture") ?? "maxdatefinishcapture") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectAssetServiceId, "projectassetserviceid") ?? "projectassetserviceid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectAssetServiceId, "projectassetserviceid") ?? "projectassetserviceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectAssetService, "projectassetservice") ?? "projectassetservice") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectAssetService, "projectassetservice") ?? "projectassetservice") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectDescription, "projectdescription") ?? "projectdescription") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectDescription, "projectdescription") ?? "projectdescription") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsSustainability, "issustainability") ?? "issustainability") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsSustainability, "issustainability") ?? "issustainability") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SustainabilityId, "sustainabilityid") ?? "sustainabilityid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SustainabilityId, "sustainabilityid") ?? "sustainabilityid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BusinessValueCategoryId, "businessvaluecategoryid") ?? "businessvaluecategoryid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BusinessValueCategoryId, "businessvaluecategoryid") ?? "businessvaluecategoryid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BusinessValueSubcategoryId, "businessvaluesubcategoryid") ?? "businessvaluesubcategoryid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BusinessValueSubcategoryId, "businessvaluesubcategoryid") ?? "businessvaluesubcategoryid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DistributionId, "distributionid") ?? "distributionid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DistributionId, "distributionid") ?? "distributionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasContract, "hascontract") ?? "hascontract") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasContract, "hascontract") ?? "hascontract") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsContractPending, "iscontractpending") ?? "iscontractpending") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsContractPending, "iscontractpending") ?? "iscontractpending") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasDeposit, "hasdeposit") ?? "hasdeposit") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasDeposit, "hasdeposit") ?? "hasdeposit") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasInsurance, "hasinsurance") ?? "hasinsurance") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasInsurance, "hasinsurance") ?? "hasinsurance") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasAdvancePayment, "hasadvancepayment") ?? "hasadvancepayment") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasAdvancePayment, "hasadvancepayment") ?? "hasadvancepayment") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingServiceTypeId_DEPR, "accountingservicetypeid_depr") ?? "accountingservicetypeid_depr") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingServiceTypeId_DEPR, "accountingservicetypeid_depr") ?? "accountingservicetypeid_depr") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ServiceDescription_DEPREC, "servicedescription_deprec") ?? "servicedescription_deprec") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ServiceDescription_DEPREC, "servicedescription_deprec") ?? "servicedescription_deprec") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@InvoiceUsageId_DEPREC, "invoiceusageid_deprec") ?? "invoiceusageid_deprec") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@InvoiceUsageId_DEPREC, "invoiceusageid_deprec") ?? "invoiceusageid_deprec") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ServiceFormatId, "serviceformatid") ?? "serviceformatid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ServiceFormatId, "serviceformatid") ?? "serviceformatid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CompanyId, "companyid") ?? "companyid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CompanyId, "companyid") ?? "companyid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RetentionRate, "retentionrate") ?? "retentionrate") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RetentionRate, "retentionrate") ?? "retentionrate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@NegotiatedExchangeRate, "negotiatedexchangerate") ?? "negotiatedexchangerate") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@NegotiatedExchangeRate, "negotiatedexchangerate") ?? "negotiatedexchangerate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsAutomaticAccounting, "isautomaticaccounting") ?? "isautomaticaccounting") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsAutomaticAccounting, "isautomaticaccounting") ?? "isautomaticaccounting") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedByApplicationRole, "createdbyapplicationrole") ?? "createdbyapplicationrole") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedByApplicationRole, "createdbyapplicationrole") ?? "createdbyapplicationrole") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DateOfCommitment, "dateofcommitment") ?? "dateofcommitment") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DateOfCommitment, "dateofcommitment") ?? "dateofcommitment") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasContractFileUploaded, "hascontractfileuploaded") ?? "hascontractfileuploaded") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasContractFileUploaded, "hascontractfileuploaded") ?? "hascontractfileuploaded") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasUpdatedDateOfCommitment, "hasupdateddateofcommitment") ?? "hasupdateddateofcommitment") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasUpdatedDateOfCommitment, "hasupdateddateofcommitment") ?? "hasupdateddateofcommitment") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SubmittedOn, "submittedon") ?? "submittedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SubmittedOn, "submittedon") ?? "submittedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsDonation, "isdonation") ?? "isdonation") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsDonation, "isdonation") ?? "isdonation") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AdvWithoutInvoice, "advwithoutinvoice") ?? "advwithoutinvoice") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AdvWithoutInvoice, "advwithoutinvoice") ?? "advwithoutinvoice") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@WasAdvWithoutInvoice, "wasadvwithoutinvoice") ?? "wasadvwithoutinvoice") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@WasAdvWithoutInvoice, "wasadvwithoutinvoice") ?? "wasadvwithoutinvoice") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsAdvanced, "isadvanced") ?? "isadvanced") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsAdvanced, "isadvanced") ?? "isadvanced") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DocumentTypeId, "documenttypeid") ?? "documenttypeid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DocumentTypeId, "documenttypeid") ?? "documenttypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsCreatedByAnAssistente, "iscreatedbyanassistente") ?? "iscreatedbyanassistente") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsCreatedByAnAssistente, "iscreatedbyanassistente") ?? "iscreatedbyanassistente") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@TelcelDirectionId, "telceldirectionid") ?? "telceldirectionid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@TelcelDirectionId, "telceldirectionid") ?? "telceldirectionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasMultiUpload, "hasmultiupload") ?? "hasmultiupload") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasMultiUpload, "hasmultiupload") ?? "hasmultiupload") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingDate, "accountingdate") ?? "accountingdate") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingDate, "accountingdate") ?? "accountingdate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentOptionsId, "paymentoptionsid") ?? "paymentoptionsid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentOptionsId, "paymentoptionsid") ?? "paymentoptionsid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentWaysId, "paymentwaysid") ?? "paymentwaysid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentWaysId, "paymentwaysid") ?? "paymentwaysid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssName) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Name, "name") ?? "name") + ",  unnest(@ssCounter) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Counter, "counter") ?? "counter") + ",  unnest(@ssRequisitionStatusId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RequisitionStatusId, "requisitionstatusid") ?? "requisitionstatusid") + ",  unnest(@ssSupplierId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + ",  unnest(@ssRegionId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RegionId, "regionid") ?? "regionid") + ",  unnest(@ssAccountingRegionId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingRegionId, "accountingregionid") ?? "accountingregionid") + ",  unnest(@ssApplicantId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ApplicantId, "applicantid") ?? "applicantid") + ",  unnest(@ssMaxDateFinishCapture) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@MaxDateFinishCapture, "maxdatefinishcapture") ?? "maxdatefinishcapture") + ",  unnest(@ssProjectAssetServiceId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectAssetServiceId, "projectassetserviceid") ?? "projectassetserviceid") + ",  unnest(@ssProjectAssetService) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectAssetService, "projectassetservice") ?? "projectassetservice") + ",  unnest(@ssProjectDescription) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectDescription, "projectdescription") ?? "projectdescription") + ",  unnest(@ssFrequencyId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + ",  unnest(@ssIsSustainability) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsSustainability, "issustainability") ?? "issustainability") + ",  unnest(@ssSustainabilityId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SustainabilityId, "sustainabilityid") ?? "sustainabilityid") + ",  unnest(@ssBusinessValueCategoryId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BusinessValueCategoryId, "businessvaluecategoryid") ?? "businessvaluecategoryid") + ",  unnest(@ssBusinessValueSubcategoryId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BusinessValueSubcategoryId, "businessvaluesubcategoryid") ?? "businessvaluesubcategoryid") + ",  unnest(@ssTotalAmount) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + ",  unnest(@ssCurrencyId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + ",  unnest(@ssDistributionId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DistributionId, "distributionid") ?? "distributionid") + ",  unnest(@ssCostCenterId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid") + ",  unnest(@ssHasContract) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasContract, "hascontract") ?? "hascontract") + ",  unnest(@ssIsContractPending) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsContractPending, "iscontractpending") ?? "iscontractpending") + ",  unnest(@ssHasDeposit) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasDeposit, "hasdeposit") ?? "hasdeposit") + ",  unnest(@ssHasInsurance) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasInsurance, "hasinsurance") ?? "hasinsurance") + ",  unnest(@ssHasAdvancePayment) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasAdvancePayment, "hasadvancepayment") ?? "hasadvancepayment") + ",  unnest(@ssAccountingServiceTypeId_DEPR) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingServiceTypeId_DEPR, "accountingservicetypeid_depr") ?? "accountingservicetypeid_depr") + ",  unnest(@ssServiceDescription_DEPREC) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ServiceDescription_DEPREC, "servicedescription_deprec") ?? "servicedescription_deprec") + ",  unnest(@ssInvoiceUsageId_DEPREC) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@InvoiceUsageId_DEPREC, "invoiceusageid_deprec") ?? "invoiceusageid_deprec") + ",  unnest(@ssServiceFormatId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ServiceFormatId, "serviceformatid") ?? "serviceformatid") + ",  unnest(@ssCompanyId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CompanyId, "companyid") ?? "companyid") + ",  unnest(@ssRetentionRate) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RetentionRate, "retentionrate") ?? "retentionrate") + ",  unnest(@ssNegotiatedExchangeRate) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@NegotiatedExchangeRate, "negotiatedexchangerate") ?? "negotiatedexchangerate") + ",  unnest(@ssPaymentMethodId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid") + ",  unnest(@ssPaymentTermsId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + ",  unnest(@ssIsAutomaticAccounting) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsAutomaticAccounting, "isautomaticaccounting") ?? "isautomaticaccounting") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ",  unnest(@ssCreatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ",  unnest(@ssUpdatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + ",  unnest(@ssUpdatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + ",  unnest(@ssCreatedByApplicationRole) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedByApplicationRole, "createdbyapplicationrole") ?? "createdbyapplicationrole") + ",  unnest(@ssDateOfCommitment) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DateOfCommitment, "dateofcommitment") ?? "dateofcommitment") + ",  unnest(@ssHasContractFileUploaded) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasContractFileUploaded, "hascontractfileuploaded") ?? "hascontractfileuploaded") + ",  unnest(@ssHasUpdatedDateOfCommitment) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasUpdatedDateOfCommitment, "hasupdateddateofcommitment") ?? "hasupdateddateofcommitment") + ",  unnest(@ssSubmittedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SubmittedOn, "submittedon") ?? "submittedon") + ",  unnest(@ssIsDonation) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsDonation, "isdonation") ?? "isdonation") + ",  unnest(@ssAdvWithoutInvoice) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AdvWithoutInvoice, "advwithoutinvoice") ?? "advwithoutinvoice") + ",  unnest(@ssWasAdvWithoutInvoice) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@WasAdvWithoutInvoice, "wasadvwithoutinvoice") ?? "wasadvwithoutinvoice") + ",  unnest(@ssIsAdvanced) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsAdvanced, "isadvanced") ?? "isadvanced") + ",  unnest(@ssDocumentTypeId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DocumentTypeId, "documenttypeid") ?? "documenttypeid") + ",  unnest(@ssIsCreatedByAnAssistente) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsCreatedByAnAssistente, "iscreatedbyanassistente") ?? "iscreatedbyanassistente") + ",  unnest(@ssTelcelDirectionId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@TelcelDirectionId, "telceldirectionid") ?? "telceldirectionid") + ",  unnest(@ssHasMultiUpload) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasMultiUpload, "hasmultiupload") ?? "hasmultiupload") + ",  unnest(@ssAccountingDate) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingDate, "accountingdate") ?? "accountingdate") + ",  unnest(@ssPaymentOptionsId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentOptionsId, "paymentoptionsid") ?? "paymentoptionsid") + ",  unnest(@ssPaymentWaysId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentWaysId, "paymentwaysid") ?? "paymentwaysid") + ",  unnest(@ssBuyDocNumber) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber") + ",  unnest(@ssBuyDocPosition) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<string> insertNameList = new List<string>();
List<int> insertCounterList = new List<int>();
List<object> insertRequisitionStatusIdList = new List<object>();
List<object> insertSupplierIdList = new List<object>();
List<object> insertRegionIdList = new List<object>();
List<object> insertAccountingRegionIdList = new List<object>();
List<object> insertApplicantIdList = new List<object>();
List<DateTime> insertMaxDateFinishCaptureList = new List<DateTime>();
List<object> insertProjectAssetServiceIdList = new List<object>();
List<string> insertProjectAssetServiceList = new List<string>();
List<string> insertProjectDescriptionList = new List<string>();
List<object> insertFrequencyIdList = new List<object>();
List<bool> insertIsSustainabilityList = new List<bool>();
List<object> insertSustainabilityIdList = new List<object>();
List<object> insertBusinessValueCategoryIdList = new List<object>();
List<object> insertBusinessValueSubcategoryIdList = new List<object>();
List<decimal> insertTotalAmountList = new List<decimal>();
List<object> insertCurrencyIdList = new List<object>();
List<object> insertDistributionIdList = new List<object>();
List<object> insertCostCenterIdList = new List<object>();
List<bool> insertHasContractList = new List<bool>();
List<bool> insertIsContractPendingList = new List<bool>();
List<bool> insertHasDepositList = new List<bool>();
List<bool> insertHasInsuranceList = new List<bool>();
List<bool> insertHasAdvancePaymentList = new List<bool>();
List<object> insertAccountingServiceTypeId_DEPRList = new List<object>();
List<string> insertServiceDescription_DEPRECList = new List<string>();
List<object> insertInvoiceUsageId_DEPRECList = new List<object>();
List<object> insertServiceFormatIdList = new List<object>();
List<object> insertCompanyIdList = new List<object>();
List<decimal> insertRetentionRateList = new List<decimal>();
List<decimal> insertNegotiatedExchangeRateList = new List<decimal>();
List<object> insertPaymentMethodIdList = new List<object>();
List<object> insertPaymentTermsIdList = new List<object>();
List<bool> insertIsAutomaticAccountingList = new List<bool>();
List<object> insertCreatedByList = new List<object>();
List<DateTime> insertCreatedOnList = new List<DateTime>();
List<DateTime> insertUpdatedOnList = new List<DateTime>();
List<object> insertUpdatedByList = new List<object>();
List<object> insertCreatedByApplicationRoleList = new List<object>();
List<DateTime> insertDateOfCommitmentList = new List<DateTime>();
List<bool> insertHasContractFileUploadedList = new List<bool>();
List<bool> insertHasUpdatedDateOfCommitmentList = new List<bool>();
List<DateTime> insertSubmittedOnList = new List<DateTime>();
List<bool> insertIsDonationList = new List<bool>();
List<bool> insertAdvWithoutInvoiceList = new List<bool>();
List<bool> insertWasAdvWithoutInvoiceList = new List<bool>();
List<bool> insertIsAdvancedList = new List<bool>();
List<object> insertDocumentTypeIdList = new List<object>();
List<bool> insertIsCreatedByAnAssistenteList = new List<bool>();
List<object> insertTelcelDirectionIdList = new List<object>();
List<bool> insertHasMultiUploadList = new List<bool>();
List<DateTime> insertAccountingDateList = new List<DateTime>();
List<object> insertPaymentOptionsIdList = new List<object>();
List<object> insertPaymentWaysIdList = new List<object>();
List<string> insertBuyDocNumberList = new List<string>();
List<string> insertBuyDocPositionList = new List<string>();

List<long> updateIdList = new List<long>();
List<string> updateNameList = new List<string>();
List<int> updateCounterList = new List<int>();
List<object> updateRequisitionStatusIdList = new List<object>();
List<object> updateSupplierIdList = new List<object>();
List<object> updateRegionIdList = new List<object>();
List<object> updateAccountingRegionIdList = new List<object>();
List<object> updateApplicantIdList = new List<object>();
List<DateTime> updateMaxDateFinishCaptureList = new List<DateTime>();
List<object> updateProjectAssetServiceIdList = new List<object>();
List<string> updateProjectAssetServiceList = new List<string>();
List<string> updateProjectDescriptionList = new List<string>();
List<object> updateFrequencyIdList = new List<object>();
List<bool> updateIsSustainabilityList = new List<bool>();
List<object> updateSustainabilityIdList = new List<object>();
List<object> updateBusinessValueCategoryIdList = new List<object>();
List<object> updateBusinessValueSubcategoryIdList = new List<object>();
List<decimal> updateTotalAmountList = new List<decimal>();
List<object> updateCurrencyIdList = new List<object>();
List<object> updateDistributionIdList = new List<object>();
List<object> updateCostCenterIdList = new List<object>();
List<bool> updateHasContractList = new List<bool>();
List<bool> updateIsContractPendingList = new List<bool>();
List<bool> updateHasDepositList = new List<bool>();
List<bool> updateHasInsuranceList = new List<bool>();
List<bool> updateHasAdvancePaymentList = new List<bool>();
List<object> updateAccountingServiceTypeId_DEPRList = new List<object>();
List<string> updateServiceDescription_DEPRECList = new List<string>();
List<object> updateInvoiceUsageId_DEPRECList = new List<object>();
List<object> updateServiceFormatIdList = new List<object>();
List<object> updateCompanyIdList = new List<object>();
List<decimal> updateRetentionRateList = new List<decimal>();
List<decimal> updateNegotiatedExchangeRateList = new List<decimal>();
List<object> updatePaymentMethodIdList = new List<object>();
List<object> updatePaymentTermsIdList = new List<object>();
List<bool> updateIsAutomaticAccountingList = new List<bool>();
List<object> updateCreatedByList = new List<object>();
List<DateTime> updateCreatedOnList = new List<DateTime>();
List<DateTime> updateUpdatedOnList = new List<DateTime>();
List<object> updateUpdatedByList = new List<object>();
List<object> updateCreatedByApplicationRoleList = new List<object>();
List<DateTime> updateDateOfCommitmentList = new List<DateTime>();
List<bool> updateHasContractFileUploadedList = new List<bool>();
List<bool> updateHasUpdatedDateOfCommitmentList = new List<bool>();
List<DateTime> updateSubmittedOnList = new List<DateTime>();
List<bool> updateIsDonationList = new List<bool>();
List<bool> updateAdvWithoutInvoiceList = new List<bool>();
List<bool> updateWasAdvWithoutInvoiceList = new List<bool>();
List<bool> updateIsAdvancedList = new List<bool>();
List<object> updateDocumentTypeIdList = new List<object>();
List<bool> updateIsCreatedByAnAssistenteList = new List<bool>();
List<object> updateTelcelDirectionIdList = new List<object>();
List<bool> updateHasMultiUploadList = new List<bool>();
List<DateTime> updateAccountingDateList = new List<DateTime>();
List<object> updatePaymentOptionsIdList = new List<object>();
List<object> updatePaymentWaysIdList = new List<object>();
List<string> updateBuyDocNumberList = new List<string>();
List<string> updateBuyDocPositionList = new List<string>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_bb81744faa58ae73e7cd8db74cb32155)inParamSourceList.Current).ssENRequisition;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
updateNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssName));
updateCounterList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssCounter));
if ((record.ssRequisitionStatusId==0)) {
updateRequisitionStatusIdList.Add(null);
} else {
updateRequisitionStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssRequisitionStatusId));
}
if ((record.ssSupplierId==0L)) {
updateSupplierIdList.Add(null);
} else {
updateSupplierIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssSupplierId));
}
if ((record.ssRegionId==0L)) {
updateRegionIdList.Add(null);
} else {
updateRegionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRegionId));
}
if ((record.ssAccountingRegionId==0L)) {
updateAccountingRegionIdList.Add(null);
} else {
updateAccountingRegionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssAccountingRegionId));
}
if ((record.ssApplicantId=="")) {
updateApplicantIdList.Add(null);
} else {
updateApplicantIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssApplicantId));
}
updateMaxDateFinishCaptureList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssMaxDateFinishCapture));
if ((record.ssProjectAssetServiceId==0L)) {
updateProjectAssetServiceIdList.Add(null);
} else {
updateProjectAssetServiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProjectAssetServiceId));
}
updateProjectAssetServiceList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssProjectAssetService));
updateProjectDescriptionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssProjectDescription));
if ((record.ssFrequencyId==0)) {
updateFrequencyIdList.Add(null);
} else {
updateFrequencyIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssFrequencyId));
}
updateIsSustainabilityList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsSustainability));
if ((record.ssSustainabilityId==0L)) {
updateSustainabilityIdList.Add(null);
} else {
updateSustainabilityIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssSustainabilityId));
}
if ((record.ssBusinessValueCategoryId==0L)) {
updateBusinessValueCategoryIdList.Add(null);
} else {
updateBusinessValueCategoryIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssBusinessValueCategoryId));
}
if ((record.ssBusinessValueSubcategoryId==0L)) {
updateBusinessValueSubcategoryIdList.Add(null);
} else {
updateBusinessValueSubcategoryIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssBusinessValueSubcategoryId));
}
updateTotalAmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssTotalAmount));
if ((record.ssCurrencyId=="")) {
updateCurrencyIdList.Add(null);
} else {
updateCurrencyIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCurrencyId));
}
if ((record.ssDistributionId==0)) {
updateDistributionIdList.Add(null);
} else {
updateDistributionIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssDistributionId));
}
if ((record.ssCostCenterId==0L)) {
updateCostCenterIdList.Add(null);
} else {
updateCostCenterIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssCostCenterId));
}
updateHasContractList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasContract));
updateIsContractPendingList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsContractPending));
updateHasDepositList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasDeposit));
updateHasInsuranceList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasInsurance));
updateHasAdvancePaymentList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasAdvancePayment));
if ((record.ssAccountingServiceTypeId_DEPR==0L)) {
updateAccountingServiceTypeId_DEPRList.Add(null);
} else {
updateAccountingServiceTypeId_DEPRList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssAccountingServiceTypeId_DEPR));
}
updateServiceDescription_DEPRECList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssServiceDescription_DEPREC));
if ((record.ssInvoiceUsageId_DEPREC==0L)) {
updateInvoiceUsageId_DEPRECList.Add(null);
} else {
updateInvoiceUsageId_DEPRECList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceUsageId_DEPREC));
}
if ((record.ssServiceFormatId==0L)) {
updateServiceFormatIdList.Add(null);
} else {
updateServiceFormatIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssServiceFormatId));
}
if ((record.ssCompanyId==0L)) {
updateCompanyIdList.Add(null);
} else {
updateCompanyIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssCompanyId));
}
updateRetentionRateList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssRetentionRate));
updateNegotiatedExchangeRateList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssNegotiatedExchangeRate));
if ((record.ssPaymentMethodId==0L)) {
updatePaymentMethodIdList.Add(null);
} else {
updatePaymentMethodIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssPaymentMethodId));
}
if ((record.ssPaymentTermsId==0L)) {
updatePaymentTermsIdList.Add(null);
} else {
updatePaymentTermsIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssPaymentTermsId));
}
updateIsAutomaticAccountingList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsAutomaticAccounting));
if ((record.ssCreatedBy=="")) {
updateCreatedByList.Add(null);
} else {
updateCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
updateCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
updateUpdatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssUpdatedOn));
if ((record.ssUpdatedBy=="")) {
updateUpdatedByList.Add(null);
} else {
updateUpdatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssUpdatedBy));
}
if ((record.ssCreatedByApplicationRole==0L)) {
updateCreatedByApplicationRoleList.Add(null);
} else {
updateCreatedByApplicationRoleList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssCreatedByApplicationRole));
}
updateDateOfCommitmentList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssDateOfCommitment));
updateHasContractFileUploadedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasContractFileUploaded));
updateHasUpdatedDateOfCommitmentList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasUpdatedDateOfCommitment));
updateSubmittedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssSubmittedOn));
updateIsDonationList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsDonation));
updateAdvWithoutInvoiceList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssAdvWithoutInvoice));
updateWasAdvWithoutInvoiceList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssWasAdvWithoutInvoice));
updateIsAdvancedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsAdvanced));
if ((record.ssDocumentTypeId==0L)) {
updateDocumentTypeIdList.Add(null);
} else {
updateDocumentTypeIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssDocumentTypeId));
}
updateIsCreatedByAnAssistenteList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsCreatedByAnAssistente));
if ((record.ssTelcelDirectionId==0L)) {
updateTelcelDirectionIdList.Add(null);
} else {
updateTelcelDirectionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssTelcelDirectionId));
}
updateHasMultiUploadList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasMultiUpload));
updateAccountingDateList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssAccountingDate));
if ((record.ssPaymentOptionsId==0L)) {
updatePaymentOptionsIdList.Add(null);
} else {
updatePaymentOptionsIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssPaymentOptionsId));
}
if ((record.ssPaymentWaysId==0L)) {
updatePaymentWaysIdList.Add(null);
} else {
updatePaymentWaysIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssPaymentWaysId));
}
updateBuyDocNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssBuyDocNumber));
updateBuyDocPositionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssBuyDocPosition));
} else {
insertNameList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssName));
insertCounterList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssCounter));
if ((record.ssRequisitionStatusId==0)) {
insertRequisitionStatusIdList.Add(null);
} else {
insertRequisitionStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssRequisitionStatusId));
}
if ((record.ssSupplierId==0L)) {
insertSupplierIdList.Add(null);
} else {
insertSupplierIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssSupplierId));
}
if ((record.ssRegionId==0L)) {
insertRegionIdList.Add(null);
} else {
insertRegionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRegionId));
}
if ((record.ssAccountingRegionId==0L)) {
insertAccountingRegionIdList.Add(null);
} else {
insertAccountingRegionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssAccountingRegionId));
}
if ((record.ssApplicantId=="")) {
insertApplicantIdList.Add(null);
} else {
insertApplicantIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssApplicantId));
}
insertMaxDateFinishCaptureList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssMaxDateFinishCapture));
if ((record.ssProjectAssetServiceId==0L)) {
insertProjectAssetServiceIdList.Add(null);
} else {
insertProjectAssetServiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProjectAssetServiceId));
}
insertProjectAssetServiceList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssProjectAssetService));
insertProjectDescriptionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssProjectDescription));
if ((record.ssFrequencyId==0)) {
insertFrequencyIdList.Add(null);
} else {
insertFrequencyIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssFrequencyId));
}
insertIsSustainabilityList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsSustainability));
if ((record.ssSustainabilityId==0L)) {
insertSustainabilityIdList.Add(null);
} else {
insertSustainabilityIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssSustainabilityId));
}
if ((record.ssBusinessValueCategoryId==0L)) {
insertBusinessValueCategoryIdList.Add(null);
} else {
insertBusinessValueCategoryIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssBusinessValueCategoryId));
}
if ((record.ssBusinessValueSubcategoryId==0L)) {
insertBusinessValueSubcategoryIdList.Add(null);
} else {
insertBusinessValueSubcategoryIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssBusinessValueSubcategoryId));
}
insertTotalAmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssTotalAmount));
if ((record.ssCurrencyId=="")) {
insertCurrencyIdList.Add(null);
} else {
insertCurrencyIdList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCurrencyId));
}
if ((record.ssDistributionId==0)) {
insertDistributionIdList.Add(null);
} else {
insertDistributionIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssDistributionId));
}
if ((record.ssCostCenterId==0L)) {
insertCostCenterIdList.Add(null);
} else {
insertCostCenterIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssCostCenterId));
}
insertHasContractList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasContract));
insertIsContractPendingList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsContractPending));
insertHasDepositList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasDeposit));
insertHasInsuranceList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasInsurance));
insertHasAdvancePaymentList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasAdvancePayment));
if ((record.ssAccountingServiceTypeId_DEPR==0L)) {
insertAccountingServiceTypeId_DEPRList.Add(null);
} else {
insertAccountingServiceTypeId_DEPRList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssAccountingServiceTypeId_DEPR));
}
insertServiceDescription_DEPRECList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssServiceDescription_DEPREC));
if ((record.ssInvoiceUsageId_DEPREC==0L)) {
insertInvoiceUsageId_DEPRECList.Add(null);
} else {
insertInvoiceUsageId_DEPRECList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceUsageId_DEPREC));
}
if ((record.ssServiceFormatId==0L)) {
insertServiceFormatIdList.Add(null);
} else {
insertServiceFormatIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssServiceFormatId));
}
if ((record.ssCompanyId==0L)) {
insertCompanyIdList.Add(null);
} else {
insertCompanyIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssCompanyId));
}
insertRetentionRateList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssRetentionRate));
insertNegotiatedExchangeRateList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssNegotiatedExchangeRate));
if ((record.ssPaymentMethodId==0L)) {
insertPaymentMethodIdList.Add(null);
} else {
insertPaymentMethodIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssPaymentMethodId));
}
if ((record.ssPaymentTermsId==0L)) {
insertPaymentTermsIdList.Add(null);
} else {
insertPaymentTermsIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssPaymentTermsId));
}
insertIsAutomaticAccountingList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsAutomaticAccounting));
if ((record.ssCreatedBy=="")) {
insertCreatedByList.Add(null);
} else {
insertCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
insertCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
insertUpdatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssUpdatedOn));
if ((record.ssUpdatedBy=="")) {
insertUpdatedByList.Add(null);
} else {
insertUpdatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssUpdatedBy));
}
if ((record.ssCreatedByApplicationRole==0L)) {
insertCreatedByApplicationRoleList.Add(null);
} else {
insertCreatedByApplicationRoleList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssCreatedByApplicationRole));
}
insertDateOfCommitmentList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssDateOfCommitment));
insertHasContractFileUploadedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasContractFileUploaded));
insertHasUpdatedDateOfCommitmentList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasUpdatedDateOfCommitment));
insertSubmittedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssSubmittedOn));
insertIsDonationList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsDonation));
insertAdvWithoutInvoiceList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssAdvWithoutInvoice));
insertWasAdvWithoutInvoiceList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssWasAdvWithoutInvoice));
insertIsAdvancedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsAdvanced));
if ((record.ssDocumentTypeId==0L)) {
insertDocumentTypeIdList.Add(null);
} else {
insertDocumentTypeIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssDocumentTypeId));
}
insertIsCreatedByAnAssistenteList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsCreatedByAnAssistente));
if ((record.ssTelcelDirectionId==0L)) {
insertTelcelDirectionIdList.Add(null);
} else {
insertTelcelDirectionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssTelcelDirectionId));
}
insertHasMultiUploadList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasMultiUpload));
insertAccountingDateList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssAccountingDate));
if ((record.ssPaymentOptionsId==0L)) {
insertPaymentOptionsIdList.Add(null);
} else {
insertPaymentOptionsIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssPaymentOptionsId));
}
if ((record.ssPaymentWaysId==0L)) {
insertPaymentWaysIdList.Add(null);
} else {
insertPaymentWaysIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssPaymentWaysId));
}
insertBuyDocNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssBuyDocNumber));
insertBuyDocPositionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssBuyDocPosition));
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertNameList.IsEmpty() || !insertCounterList.IsEmpty() || !insertRequisitionStatusIdList.IsEmpty() || !insertSupplierIdList.IsEmpty() || !insertRegionIdList.IsEmpty() || !insertAccountingRegionIdList.IsEmpty() || !insertApplicantIdList.IsEmpty() || !insertMaxDateFinishCaptureList.IsEmpty() || !insertProjectAssetServiceIdList.IsEmpty() || !insertProjectAssetServiceList.IsEmpty() || !insertProjectDescriptionList.IsEmpty() || !insertFrequencyIdList.IsEmpty() || !insertIsSustainabilityList.IsEmpty() || !insertSustainabilityIdList.IsEmpty() || !insertBusinessValueCategoryIdList.IsEmpty() || !insertBusinessValueSubcategoryIdList.IsEmpty() || !insertTotalAmountList.IsEmpty() || !insertCurrencyIdList.IsEmpty() || !insertDistributionIdList.IsEmpty() || !insertCostCenterIdList.IsEmpty() || !insertHasContractList.IsEmpty() || !insertIsContractPendingList.IsEmpty() || !insertHasDepositList.IsEmpty() || !insertHasInsuranceList.IsEmpty() || !insertHasAdvancePaymentList.IsEmpty() || !insertAccountingServiceTypeId_DEPRList.IsEmpty() || !insertServiceDescription_DEPRECList.IsEmpty() || !insertInvoiceUsageId_DEPRECList.IsEmpty() || !insertServiceFormatIdList.IsEmpty() || !insertCompanyIdList.IsEmpty() || !insertRetentionRateList.IsEmpty() || !insertNegotiatedExchangeRateList.IsEmpty() || !insertPaymentMethodIdList.IsEmpty() || !insertPaymentTermsIdList.IsEmpty() || !insertIsAutomaticAccountingList.IsEmpty() || !insertCreatedByList.IsEmpty() || !insertCreatedOnList.IsEmpty() || !insertUpdatedOnList.IsEmpty() || !insertUpdatedByList.IsEmpty() || !insertCreatedByApplicationRoleList.IsEmpty() || !insertDateOfCommitmentList.IsEmpty() || !insertHasContractFileUploadedList.IsEmpty() || !insertHasUpdatedDateOfCommitmentList.IsEmpty() || !insertSubmittedOnList.IsEmpty() || !insertIsDonationList.IsEmpty() || !insertAdvWithoutInvoiceList.IsEmpty() || !insertWasAdvWithoutInvoiceList.IsEmpty() || !insertIsAdvancedList.IsEmpty() || !insertDocumentTypeIdList.IsEmpty() || !insertIsCreatedByAnAssistenteList.IsEmpty() || !insertTelcelDirectionIdList.IsEmpty() || !insertHasMultiUploadList.IsEmpty() || !insertAccountingDateList.IsEmpty() || !insertPaymentOptionsIdList.IsEmpty() || !insertPaymentWaysIdList.IsEmpty() || !insertBuyDocNumberList.IsEmpty() || !insertBuyDocPositionList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssName",DbType.String,insertNameList);
executionService.CreateParameter(insertSqlCmd,"@ssCounter",DbType.Int32,insertCounterList);
executionService.CreateParameter(insertSqlCmd,"@ssRequisitionStatusId",DbType.Int32,insertRequisitionStatusIdList);
executionService.CreateParameter(insertSqlCmd,"@ssSupplierId",DbType.Int64,insertSupplierIdList);
executionService.CreateParameter(insertSqlCmd,"@ssRegionId",DbType.Int64,insertRegionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssAccountingRegionId",DbType.Int64,insertAccountingRegionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssApplicantId",DbType.String,insertApplicantIdList);
executionService.CreateParameter(insertSqlCmd,"@ssMaxDateFinishCapture",DbType.DateTime,insertMaxDateFinishCaptureList);
executionService.CreateParameter(insertSqlCmd,"@ssProjectAssetServiceId",DbType.Int64,insertProjectAssetServiceIdList);
executionService.CreateParameter(insertSqlCmd,"@ssProjectAssetService",DbType.String,insertProjectAssetServiceList);
executionService.CreateParameter(insertSqlCmd,"@ssProjectDescription",DbType.String,insertProjectDescriptionList);
executionService.CreateParameter(insertSqlCmd,"@ssFrequencyId",DbType.Int32,insertFrequencyIdList);
executionService.CreateParameter(insertSqlCmd,"@ssIsSustainability",DbType.Boolean,insertIsSustainabilityList);
executionService.CreateParameter(insertSqlCmd,"@ssSustainabilityId",DbType.Int64,insertSustainabilityIdList);
executionService.CreateParameter(insertSqlCmd,"@ssBusinessValueCategoryId",DbType.Int64,insertBusinessValueCategoryIdList);
executionService.CreateParameter(insertSqlCmd,"@ssBusinessValueSubcategoryId",DbType.Int64,insertBusinessValueSubcategoryIdList);
executionService.CreateParameter(insertSqlCmd,"@ssTotalAmount",DbType.Decimal,insertTotalAmountList);
executionService.CreateParameter(insertSqlCmd,"@ssCurrencyId",DbType.String,insertCurrencyIdList);
executionService.CreateParameter(insertSqlCmd,"@ssDistributionId",DbType.Int32,insertDistributionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCostCenterId",DbType.Int64,insertCostCenterIdList);
executionService.CreateParameter(insertSqlCmd,"@ssHasContract",DbType.Boolean,insertHasContractList);
executionService.CreateParameter(insertSqlCmd,"@ssIsContractPending",DbType.Boolean,insertIsContractPendingList);
executionService.CreateParameter(insertSqlCmd,"@ssHasDeposit",DbType.Boolean,insertHasDepositList);
executionService.CreateParameter(insertSqlCmd,"@ssHasInsurance",DbType.Boolean,insertHasInsuranceList);
executionService.CreateParameter(insertSqlCmd,"@ssHasAdvancePayment",DbType.Boolean,insertHasAdvancePaymentList);
executionService.CreateParameter(insertSqlCmd,"@ssAccountingServiceTypeId_DEPR",DbType.Int64,insertAccountingServiceTypeId_DEPRList);
executionService.CreateParameter(insertSqlCmd,"@ssServiceDescription_DEPREC",DbType.String,insertServiceDescription_DEPRECList);
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceUsageId_DEPREC",DbType.Int64,insertInvoiceUsageId_DEPRECList);
executionService.CreateParameter(insertSqlCmd,"@ssServiceFormatId",DbType.Int64,insertServiceFormatIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCompanyId",DbType.Int64,insertCompanyIdList);
executionService.CreateParameter(insertSqlCmd,"@ssRetentionRate",DbType.Decimal,insertRetentionRateList);
executionService.CreateParameter(insertSqlCmd,"@ssNegotiatedExchangeRate",DbType.Decimal,insertNegotiatedExchangeRateList);
executionService.CreateParameter(insertSqlCmd,"@ssPaymentMethodId",DbType.Int64,insertPaymentMethodIdList);
executionService.CreateParameter(insertSqlCmd,"@ssPaymentTermsId",DbType.Int64,insertPaymentTermsIdList);
executionService.CreateParameter(insertSqlCmd,"@ssIsAutomaticAccounting",DbType.Boolean,insertIsAutomaticAccountingList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedOn",DbType.DateTime,insertCreatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssUpdatedOn",DbType.DateTime,insertUpdatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssUpdatedBy",DbType.String,insertUpdatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedByApplicationRole",DbType.Int64,insertCreatedByApplicationRoleList);
executionService.CreateParameter(insertSqlCmd,"@ssDateOfCommitment",DbType.DateTime,insertDateOfCommitmentList);
executionService.CreateParameter(insertSqlCmd,"@ssHasContractFileUploaded",DbType.Boolean,insertHasContractFileUploadedList);
executionService.CreateParameter(insertSqlCmd,"@ssHasUpdatedDateOfCommitment",DbType.Boolean,insertHasUpdatedDateOfCommitmentList);
executionService.CreateParameter(insertSqlCmd,"@ssSubmittedOn",DbType.DateTime,insertSubmittedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssIsDonation",DbType.Boolean,insertIsDonationList);
executionService.CreateParameter(insertSqlCmd,"@ssAdvWithoutInvoice",DbType.Boolean,insertAdvWithoutInvoiceList);
executionService.CreateParameter(insertSqlCmd,"@ssWasAdvWithoutInvoice",DbType.Boolean,insertWasAdvWithoutInvoiceList);
executionService.CreateParameter(insertSqlCmd,"@ssIsAdvanced",DbType.Boolean,insertIsAdvancedList);
executionService.CreateParameter(insertSqlCmd,"@ssDocumentTypeId",DbType.Int64,insertDocumentTypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssIsCreatedByAnAssistente",DbType.Boolean,insertIsCreatedByAnAssistenteList);
executionService.CreateParameter(insertSqlCmd,"@ssTelcelDirectionId",DbType.Int64,insertTelcelDirectionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssHasMultiUpload",DbType.Boolean,insertHasMultiUploadList);
executionService.CreateParameter(insertSqlCmd,"@ssAccountingDate",DbType.DateTime,insertAccountingDateList);
executionService.CreateParameter(insertSqlCmd,"@ssPaymentOptionsId",DbType.Int64,insertPaymentOptionsIdList);
executionService.CreateParameter(insertSqlCmd,"@ssPaymentWaysId",DbType.Int64,insertPaymentWaysIdList);
executionService.CreateParameter(insertSqlCmd,"@ssBuyDocNumber",DbType.String,insertBuyDocNumberList);
executionService.CreateParameter(insertSqlCmd,"@ssBuyDocPosition",DbType.String,insertBuyDocPositionList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeRequisition (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateNameList.IsEmpty() || !updateCounterList.IsEmpty() || !updateRequisitionStatusIdList.IsEmpty() || !updateSupplierIdList.IsEmpty() || !updateRegionIdList.IsEmpty() || !updateAccountingRegionIdList.IsEmpty() || !updateApplicantIdList.IsEmpty() || !updateMaxDateFinishCaptureList.IsEmpty() || !updateProjectAssetServiceIdList.IsEmpty() || !updateProjectAssetServiceList.IsEmpty() || !updateProjectDescriptionList.IsEmpty() || !updateFrequencyIdList.IsEmpty() || !updateIsSustainabilityList.IsEmpty() || !updateSustainabilityIdList.IsEmpty() || !updateBusinessValueCategoryIdList.IsEmpty() || !updateBusinessValueSubcategoryIdList.IsEmpty() || !updateTotalAmountList.IsEmpty() || !updateCurrencyIdList.IsEmpty() || !updateDistributionIdList.IsEmpty() || !updateCostCenterIdList.IsEmpty() || !updateHasContractList.IsEmpty() || !updateIsContractPendingList.IsEmpty() || !updateHasDepositList.IsEmpty() || !updateHasInsuranceList.IsEmpty() || !updateHasAdvancePaymentList.IsEmpty() || !updateAccountingServiceTypeId_DEPRList.IsEmpty() || !updateServiceDescription_DEPRECList.IsEmpty() || !updateInvoiceUsageId_DEPRECList.IsEmpty() || !updateServiceFormatIdList.IsEmpty() || !updateCompanyIdList.IsEmpty() || !updateRetentionRateList.IsEmpty() || !updateNegotiatedExchangeRateList.IsEmpty() || !updatePaymentMethodIdList.IsEmpty() || !updatePaymentTermsIdList.IsEmpty() || !updateIsAutomaticAccountingList.IsEmpty() || !updateCreatedByList.IsEmpty() || !updateCreatedOnList.IsEmpty() || !updateUpdatedOnList.IsEmpty() || !updateUpdatedByList.IsEmpty() || !updateCreatedByApplicationRoleList.IsEmpty() || !updateDateOfCommitmentList.IsEmpty() || !updateHasContractFileUploadedList.IsEmpty() || !updateHasUpdatedDateOfCommitmentList.IsEmpty() || !updateSubmittedOnList.IsEmpty() || !updateIsDonationList.IsEmpty() || !updateAdvWithoutInvoiceList.IsEmpty() || !updateWasAdvWithoutInvoiceList.IsEmpty() || !updateIsAdvancedList.IsEmpty() || !updateDocumentTypeIdList.IsEmpty() || !updateIsCreatedByAnAssistenteList.IsEmpty() || !updateTelcelDirectionIdList.IsEmpty() || !updateHasMultiUploadList.IsEmpty() || !updateAccountingDateList.IsEmpty() || !updatePaymentOptionsIdList.IsEmpty() || !updatePaymentWaysIdList.IsEmpty() || !updateBuyDocNumberList.IsEmpty() || !updateBuyDocPositionList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssName",DbType.String,updateNameList);
executionService.CreateParameter(updateSqlCmd,"@ssCounter",DbType.Int32,updateCounterList);
executionService.CreateParameter(updateSqlCmd,"@ssRequisitionStatusId",DbType.Int32,updateRequisitionStatusIdList);
executionService.CreateParameter(updateSqlCmd,"@ssSupplierId",DbType.Int64,updateSupplierIdList);
executionService.CreateParameter(updateSqlCmd,"@ssRegionId",DbType.Int64,updateRegionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssAccountingRegionId",DbType.Int64,updateAccountingRegionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssApplicantId",DbType.String,updateApplicantIdList);
executionService.CreateParameter(updateSqlCmd,"@ssMaxDateFinishCapture",DbType.DateTime,updateMaxDateFinishCaptureList);
executionService.CreateParameter(updateSqlCmd,"@ssProjectAssetServiceId",DbType.Int64,updateProjectAssetServiceIdList);
executionService.CreateParameter(updateSqlCmd,"@ssProjectAssetService",DbType.String,updateProjectAssetServiceList);
executionService.CreateParameter(updateSqlCmd,"@ssProjectDescription",DbType.String,updateProjectDescriptionList);
executionService.CreateParameter(updateSqlCmd,"@ssFrequencyId",DbType.Int32,updateFrequencyIdList);
executionService.CreateParameter(updateSqlCmd,"@ssIsSustainability",DbType.Boolean,updateIsSustainabilityList);
executionService.CreateParameter(updateSqlCmd,"@ssSustainabilityId",DbType.Int64,updateSustainabilityIdList);
executionService.CreateParameter(updateSqlCmd,"@ssBusinessValueCategoryId",DbType.Int64,updateBusinessValueCategoryIdList);
executionService.CreateParameter(updateSqlCmd,"@ssBusinessValueSubcategoryId",DbType.Int64,updateBusinessValueSubcategoryIdList);
executionService.CreateParameter(updateSqlCmd,"@ssTotalAmount",DbType.Decimal,updateTotalAmountList);
executionService.CreateParameter(updateSqlCmd,"@ssCurrencyId",DbType.String,updateCurrencyIdList);
executionService.CreateParameter(updateSqlCmd,"@ssDistributionId",DbType.Int32,updateDistributionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCostCenterId",DbType.Int64,updateCostCenterIdList);
executionService.CreateParameter(updateSqlCmd,"@ssHasContract",DbType.Boolean,updateHasContractList);
executionService.CreateParameter(updateSqlCmd,"@ssIsContractPending",DbType.Boolean,updateIsContractPendingList);
executionService.CreateParameter(updateSqlCmd,"@ssHasDeposit",DbType.Boolean,updateHasDepositList);
executionService.CreateParameter(updateSqlCmd,"@ssHasInsurance",DbType.Boolean,updateHasInsuranceList);
executionService.CreateParameter(updateSqlCmd,"@ssHasAdvancePayment",DbType.Boolean,updateHasAdvancePaymentList);
executionService.CreateParameter(updateSqlCmd,"@ssAccountingServiceTypeId_DEPR",DbType.Int64,updateAccountingServiceTypeId_DEPRList);
executionService.CreateParameter(updateSqlCmd,"@ssServiceDescription_DEPREC",DbType.String,updateServiceDescription_DEPRECList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceUsageId_DEPREC",DbType.Int64,updateInvoiceUsageId_DEPRECList);
executionService.CreateParameter(updateSqlCmd,"@ssServiceFormatId",DbType.Int64,updateServiceFormatIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCompanyId",DbType.Int64,updateCompanyIdList);
executionService.CreateParameter(updateSqlCmd,"@ssRetentionRate",DbType.Decimal,updateRetentionRateList);
executionService.CreateParameter(updateSqlCmd,"@ssNegotiatedExchangeRate",DbType.Decimal,updateNegotiatedExchangeRateList);
executionService.CreateParameter(updateSqlCmd,"@ssPaymentMethodId",DbType.Int64,updatePaymentMethodIdList);
executionService.CreateParameter(updateSqlCmd,"@ssPaymentTermsId",DbType.Int64,updatePaymentTermsIdList);
executionService.CreateParameter(updateSqlCmd,"@ssIsAutomaticAccounting",DbType.Boolean,updateIsAutomaticAccountingList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedOn",DbType.DateTime,updateCreatedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssUpdatedOn",DbType.DateTime,updateUpdatedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssUpdatedBy",DbType.String,updateUpdatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedByApplicationRole",DbType.Int64,updateCreatedByApplicationRoleList);
executionService.CreateParameter(updateSqlCmd,"@ssDateOfCommitment",DbType.DateTime,updateDateOfCommitmentList);
executionService.CreateParameter(updateSqlCmd,"@ssHasContractFileUploaded",DbType.Boolean,updateHasContractFileUploadedList);
executionService.CreateParameter(updateSqlCmd,"@ssHasUpdatedDateOfCommitment",DbType.Boolean,updateHasUpdatedDateOfCommitmentList);
executionService.CreateParameter(updateSqlCmd,"@ssSubmittedOn",DbType.DateTime,updateSubmittedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssIsDonation",DbType.Boolean,updateIsDonationList);
executionService.CreateParameter(updateSqlCmd,"@ssAdvWithoutInvoice",DbType.Boolean,updateAdvWithoutInvoiceList);
executionService.CreateParameter(updateSqlCmd,"@ssWasAdvWithoutInvoice",DbType.Boolean,updateWasAdvWithoutInvoiceList);
executionService.CreateParameter(updateSqlCmd,"@ssIsAdvanced",DbType.Boolean,updateIsAdvancedList);
executionService.CreateParameter(updateSqlCmd,"@ssDocumentTypeId",DbType.Int64,updateDocumentTypeIdList);
executionService.CreateParameter(updateSqlCmd,"@ssIsCreatedByAnAssistente",DbType.Boolean,updateIsCreatedByAnAssistenteList);
executionService.CreateParameter(updateSqlCmd,"@ssTelcelDirectionId",DbType.Int64,updateTelcelDirectionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssHasMultiUpload",DbType.Boolean,updateHasMultiUploadList);
executionService.CreateParameter(updateSqlCmd,"@ssAccountingDate",DbType.DateTime,updateAccountingDateList);
executionService.CreateParameter(updateSqlCmd,"@ssPaymentOptionsId",DbType.Int64,updatePaymentOptionsIdList);
executionService.CreateParameter(updateSqlCmd,"@ssPaymentWaysId",DbType.Int64,updatePaymentWaysIdList);
executionService.CreateParameter(updateSqlCmd,"@ssBuyDocNumber",DbType.String,updateBuyDocNumberList);
executionService.CreateParameter(updateSqlCmd,"@ssBuyDocPosition",DbType.String,updateBuyDocPositionList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeRequisition (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteRequisition
/// </summary>

public static async Task DeleteRequisition(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteRequisition", "7b58f8dc-88e6-42ed-b0e0-6d98a36640c6.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteRequisition", "7b58f8dc-88e6-42ed-b0e0-6d98a36640c6.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENRequisitionEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteRequisition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllRequisition
/// </summary>

public static async Task DeleteAllRequisition(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllRequisition", "7b58f8dc-88e6-42ed-b0e0-6d98a36640c6.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllRequisition", "7b58f8dc-88e6-42ed-b0e0-6d98a36640c6.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENRequisitionEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteRequisition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetRequisition
/// </summary>

public static async Task<RC_bb81744faa58ae73e7cd8db74cb32155> GetRequisition(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_bb81744faa58ae73e7cd8db74cb32155 outParamRecord = default;
outParamRecord = new RC_bb81744faa58ae73e7cd8db74cb32155();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetRequisition", "7b58f8dc-88e6-42ed-b0e0-6d98a36640c6.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRequisition", "7b58f8dc-88e6-42ed-b0e0-6d98a36640c6.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Name, "name") ?? "name", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Counter, "counter") ?? "counter", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RequisitionStatusId, "requisitionstatusid") ?? "requisitionstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SupplierId, "supplierid") ?? "supplierid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RegionId, "regionid") ?? "regionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingRegionId, "accountingregionid") ?? "accountingregionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ApplicantId, "applicantid") ?? "applicantid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@MaxDateFinishCapture, "maxdatefinishcapture") ?? "maxdatefinishcapture", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectAssetServiceId, "projectassetserviceid") ?? "projectassetserviceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectAssetService, "projectassetservice") ?? "projectassetservice", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectDescription, "projectdescription") ?? "projectdescription", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsSustainability, "issustainability") ?? "issustainability", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SustainabilityId, "sustainabilityid") ?? "sustainabilityid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BusinessValueCategoryId, "businessvaluecategoryid") ?? "businessvaluecategoryid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BusinessValueSubcategoryId, "businessvaluesubcategoryid") ?? "businessvaluesubcategoryid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DistributionId, "distributionid") ?? "distributionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasContract, "hascontract") ?? "hascontract", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsContractPending, "iscontractpending") ?? "iscontractpending", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasDeposit, "hasdeposit") ?? "hasdeposit", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasInsurance, "hasinsurance") ?? "hasinsurance", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasAdvancePayment, "hasadvancepayment") ?? "hasadvancepayment", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingServiceTypeId_DEPR, "accountingservicetypeid_depr") ?? "accountingservicetypeid_depr", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ServiceDescription_DEPREC, "servicedescription_deprec") ?? "servicedescription_deprec", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@InvoiceUsageId_DEPREC, "invoiceusageid_deprec") ?? "invoiceusageid_deprec", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ServiceFormatId, "serviceformatid") ?? "serviceformatid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CompanyId, "companyid") ?? "companyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RetentionRate, "retentionrate") ?? "retentionrate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@NegotiatedExchangeRate, "negotiatedexchangerate") ?? "negotiatedexchangerate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsAutomaticAccounting, "isautomaticaccounting") ?? "isautomaticaccounting", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedByApplicationRole, "createdbyapplicationrole") ?? "createdbyapplicationrole", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DateOfCommitment, "dateofcommitment") ?? "dateofcommitment", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasContractFileUploaded, "hascontractfileuploaded") ?? "hascontractfileuploaded", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasUpdatedDateOfCommitment, "hasupdateddateofcommitment") ?? "hasupdateddateofcommitment", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SubmittedOn, "submittedon") ?? "submittedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsDonation, "isdonation") ?? "isdonation", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AdvWithoutInvoice, "advwithoutinvoice") ?? "advwithoutinvoice", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@WasAdvWithoutInvoice, "wasadvwithoutinvoice") ?? "wasadvwithoutinvoice", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsAdvanced, "isadvanced") ?? "isadvanced", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DocumentTypeId, "documenttypeid") ?? "documenttypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsCreatedByAnAssistente, "iscreatedbyanassistente") ?? "iscreatedbyanassistente", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@TelcelDirectionId, "telceldirectionid") ?? "telceldirectionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasMultiUpload, "hasmultiupload") ?? "hasmultiupload", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingDate, "accountingdate") ?? "accountingdate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentOptionsId, "paymentoptionsid") ?? "paymentoptionsid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentWaysId, "paymentwaysid") ?? "paymentwaysid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENRequisitionEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetRequisition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(58,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENRequisitionEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetRequisitionForUpdate
/// </summary>

public static async Task<RC_bb81744faa58ae73e7cd8db74cb32155> GetRequisitionForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_bb81744faa58ae73e7cd8db74cb32155 outParamRecord = default;
outParamRecord = new RC_bb81744faa58ae73e7cd8db74cb32155();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetRequisitionForUpdate", "7b58f8dc-88e6-42ed-b0e0-6d98a36640c6.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetRequisitionForUpdate", "7b58f8dc-88e6-42ed-b0e0-6d98a36640c6.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Name, "name") ?? "name", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Counter, "counter") ?? "counter", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RequisitionStatusId, "requisitionstatusid") ?? "requisitionstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SupplierId, "supplierid") ?? "supplierid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RegionId, "regionid") ?? "regionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingRegionId, "accountingregionid") ?? "accountingregionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ApplicantId, "applicantid") ?? "applicantid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@MaxDateFinishCapture, "maxdatefinishcapture") ?? "maxdatefinishcapture", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectAssetServiceId, "projectassetserviceid") ?? "projectassetserviceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectAssetService, "projectassetservice") ?? "projectassetservice", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectDescription, "projectdescription") ?? "projectdescription", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsSustainability, "issustainability") ?? "issustainability", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SustainabilityId, "sustainabilityid") ?? "sustainabilityid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BusinessValueCategoryId, "businessvaluecategoryid") ?? "businessvaluecategoryid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BusinessValueSubcategoryId, "businessvaluesubcategoryid") ?? "businessvaluesubcategoryid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DistributionId, "distributionid") ?? "distributionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasContract, "hascontract") ?? "hascontract", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsContractPending, "iscontractpending") ?? "iscontractpending", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasDeposit, "hasdeposit") ?? "hasdeposit", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasInsurance, "hasinsurance") ?? "hasinsurance", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasAdvancePayment, "hasadvancepayment") ?? "hasadvancepayment", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingServiceTypeId_DEPR, "accountingservicetypeid_depr") ?? "accountingservicetypeid_depr", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ServiceDescription_DEPREC, "servicedescription_deprec") ?? "servicedescription_deprec", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@InvoiceUsageId_DEPREC, "invoiceusageid_deprec") ?? "invoiceusageid_deprec", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ServiceFormatId, "serviceformatid") ?? "serviceformatid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CompanyId, "companyid") ?? "companyid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RetentionRate, "retentionrate") ?? "retentionrate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@NegotiatedExchangeRate, "negotiatedexchangerate") ?? "negotiatedexchangerate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsAutomaticAccounting, "isautomaticaccounting") ?? "isautomaticaccounting", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedByApplicationRole, "createdbyapplicationrole") ?? "createdbyapplicationrole", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DateOfCommitment, "dateofcommitment") ?? "dateofcommitment", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasContractFileUploaded, "hascontractfileuploaded") ?? "hascontractfileuploaded", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasUpdatedDateOfCommitment, "hasupdateddateofcommitment") ?? "hasupdateddateofcommitment", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SubmittedOn, "submittedon") ?? "submittedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsDonation, "isdonation") ?? "isdonation", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AdvWithoutInvoice, "advwithoutinvoice") ?? "advwithoutinvoice", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@WasAdvWithoutInvoice, "wasadvwithoutinvoice") ?? "wasadvwithoutinvoice", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsAdvanced, "isadvanced") ?? "isadvanced", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DocumentTypeId, "documenttypeid") ?? "documenttypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsCreatedByAnAssistente, "iscreatedbyanassistente") ?? "iscreatedbyanassistente", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@TelcelDirectionId, "telceldirectionid") ?? "telceldirectionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasMultiUpload, "hasmultiupload") ?? "hasmultiupload", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingDate, "accountingdate") ?? "accountingdate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentOptionsId, "paymentoptionsid") ?? "paymentoptionsid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentWaysId, "paymentwaysid") ?? "paymentwaysid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
" FROM " + ENRequisitionEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetRequisitionForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(58,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENRequisitionEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateRequisition
/// </summary>

public static async Task UpdateRequisition(IRequestContext requestContext,BitArray usedFields,RC_bb81744faa58ae73e7cd8db74cb32155 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateRequisition", "7b58f8dc-88e6-42ed-b0e0-6d98a36640c6.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateRequisition", "7b58f8dc-88e6-42ed-b0e0-6d98a36640c6.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(58,true);
}
string updateSet = "UPDATE " + ENRequisitionEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Name, "name") ?? "name") + " = @ssName"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Counter, "counter") ?? "counter") + " = @ssCounter"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RequisitionStatusId, "requisitionstatusid") ?? "requisitionstatusid") + " = @ssRequisitionStatusId"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SupplierId, "supplierid") ?? "supplierid") + " = @ssSupplierId"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RegionId, "regionid") ?? "regionid") + " = @ssRegionId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingRegionId, "accountingregionid") ?? "accountingregionid") + " = @ssAccountingRegionId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ApplicantId, "applicantid") ?? "applicantid") + " = @ssApplicantId"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@MaxDateFinishCapture, "maxdatefinishcapture") ?? "maxdatefinishcapture") + " = @ssMaxDateFinishCapture"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectAssetServiceId, "projectassetserviceid") ?? "projectassetserviceid") + " = @ssProjectAssetServiceId"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectAssetService, "projectassetservice") ?? "projectassetservice") + " = @ssProjectAssetService"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ProjectDescription, "projectdescription") ?? "projectdescription") + " = @ssProjectDescription"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@FrequencyId, "frequencyid") ?? "frequencyid") + " = @ssFrequencyId"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsSustainability, "issustainability") ?? "issustainability") + " = @ssIsSustainability"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SustainabilityId, "sustainabilityid") ?? "sustainabilityid") + " = @ssSustainabilityId"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BusinessValueCategoryId, "businessvaluecategoryid") ?? "businessvaluecategoryid") + " = @ssBusinessValueCategoryId"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BusinessValueSubcategoryId, "businessvaluesubcategoryid") ?? "businessvaluesubcategoryid") + " = @ssBusinessValueSubcategoryId"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@TotalAmount, "totalamount") ?? "totalamount") + " = @ssTotalAmount"): parameters);
parameters = (usedFields[18] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CurrencyId, "currencyid") ?? "currencyid") + " = @ssCurrencyId"): parameters);
parameters = (usedFields[19] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DistributionId, "distributionid") ?? "distributionid") + " = @ssDistributionId"): parameters);
parameters = (usedFields[20] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid") + " = @ssCostCenterId"): parameters);
parameters = (usedFields[21] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasContract, "hascontract") ?? "hascontract") + " = @ssHasContract"): parameters);
parameters = (usedFields[22] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsContractPending, "iscontractpending") ?? "iscontractpending") + " = @ssIsContractPending"): parameters);
parameters = (usedFields[23] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasDeposit, "hasdeposit") ?? "hasdeposit") + " = @ssHasDeposit"): parameters);
parameters = (usedFields[24] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasInsurance, "hasinsurance") ?? "hasinsurance") + " = @ssHasInsurance"): parameters);
parameters = (usedFields[25] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasAdvancePayment, "hasadvancepayment") ?? "hasadvancepayment") + " = @ssHasAdvancePayment"): parameters);
parameters = (usedFields[26] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingServiceTypeId_DEPR, "accountingservicetypeid_depr") ?? "accountingservicetypeid_depr") + " = @ssAccountingServiceTypeId_DEPR"): parameters);
parameters = (usedFields[27] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ServiceDescription_DEPREC, "servicedescription_deprec") ?? "servicedescription_deprec") + " = @ssServiceDescription_DEPREC"): parameters);
parameters = (usedFields[28] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@InvoiceUsageId_DEPREC, "invoiceusageid_deprec") ?? "invoiceusageid_deprec") + " = @ssInvoiceUsageId_DEPREC"): parameters);
parameters = (usedFields[29] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@ServiceFormatId, "serviceformatid") ?? "serviceformatid") + " = @ssServiceFormatId"): parameters);
parameters = (usedFields[30] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CompanyId, "companyid") ?? "companyid") + " = @ssCompanyId"): parameters);
parameters = (usedFields[31] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@RetentionRate, "retentionrate") ?? "retentionrate") + " = @ssRetentionRate"): parameters);
parameters = (usedFields[32] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@NegotiatedExchangeRate, "negotiatedexchangerate") ?? "negotiatedexchangerate") + " = @ssNegotiatedExchangeRate"): parameters);
parameters = (usedFields[33] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid") + " = @ssPaymentMethodId"): parameters);
parameters = (usedFields[34] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + " = @ssPaymentTermsId"): parameters);
parameters = (usedFields[35] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsAutomaticAccounting, "isautomaticaccounting") ?? "isautomaticaccounting") + " = @ssIsAutomaticAccounting"): parameters);
parameters = (usedFields[36] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[37] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[38] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = @ssUpdatedOn"): parameters);
parameters = (usedFields[39] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + " = @ssUpdatedBy"): parameters);
parameters = (usedFields[40] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@CreatedByApplicationRole, "createdbyapplicationrole") ?? "createdbyapplicationrole") + " = @ssCreatedByApplicationRole"): parameters);
parameters = (usedFields[41] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DateOfCommitment, "dateofcommitment") ?? "dateofcommitment") + " = @ssDateOfCommitment"): parameters);
parameters = (usedFields[42] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasContractFileUploaded, "hascontractfileuploaded") ?? "hascontractfileuploaded") + " = @ssHasContractFileUploaded"): parameters);
parameters = (usedFields[43] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasUpdatedDateOfCommitment, "hasupdateddateofcommitment") ?? "hasupdateddateofcommitment") + " = @ssHasUpdatedDateOfCommitment"): parameters);
parameters = (usedFields[44] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@SubmittedOn, "submittedon") ?? "submittedon") + " = @ssSubmittedOn"): parameters);
parameters = (usedFields[45] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsDonation, "isdonation") ?? "isdonation") + " = @ssIsDonation"): parameters);
parameters = (usedFields[46] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AdvWithoutInvoice, "advwithoutinvoice") ?? "advwithoutinvoice") + " = @ssAdvWithoutInvoice"): parameters);
parameters = (usedFields[47] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@WasAdvWithoutInvoice, "wasadvwithoutinvoice") ?? "wasadvwithoutinvoice") + " = @ssWasAdvWithoutInvoice"): parameters);
parameters = (usedFields[48] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsAdvanced, "isadvanced") ?? "isadvanced") + " = @ssIsAdvanced"): parameters);
parameters = (usedFields[49] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@DocumentTypeId, "documenttypeid") ?? "documenttypeid") + " = @ssDocumentTypeId"): parameters);
parameters = (usedFields[50] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsCreatedByAnAssistente, "iscreatedbyanassistente") ?? "iscreatedbyanassistente") + " = @ssIsCreatedByAnAssistente"): parameters);
parameters = (usedFields[51] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@TelcelDirectionId, "telceldirectionid") ?? "telceldirectionid") + " = @ssTelcelDirectionId"): parameters);
parameters = (usedFields[52] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@HasMultiUpload, "hasmultiupload") ?? "hasmultiupload") + " = @ssHasMultiUpload"): parameters);
parameters = (usedFields[53] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@AccountingDate, "accountingdate") ?? "accountingdate") + " = @ssAccountingDate"): parameters);
parameters = (usedFields[54] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentOptionsId, "paymentoptionsid") ?? "paymentoptionsid") + " = @ssPaymentOptionsId"): parameters);
parameters = (usedFields[55] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@PaymentWaysId, "paymentwaysid") ?? "paymentwaysid") + " = @ssPaymentWaysId"): parameters);
parameters = (usedFields[56] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BuyDocNumber, "buydocnumber") ?? "buydocnumber") + " = @ssBuyDocNumber"): parameters);
parameters = (usedFields[57] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@BuyDocPosition, "buydocposition") ?? "buydocposition") + " = @ssBuyDocPosition"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENRequisition_ssId_Requisition";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsSustainability, "issustainability") ?? "issustainability") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@Requisition, _EntityKeyConstants._ConectaProveedoresEntityKeys._RequisitionAttributeKeys.@IsSustainability, "issustainability") ?? "issustainability") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssName", DbType.String, ssENRequisition.ssName);
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssCounter", DbType.Int32, ssENRequisition.ssCounter);
}
if(usedFields[3]) {
if ((ssENRequisition.ssRequisitionStatusId==0)) {
sqlCmd.CreateParameter("@ssRequisitionStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRequisitionStatusId", DbType.Int32, ssENRequisition.ssRequisitionStatusId);

}
}
if(usedFields[4]) {
if ((ssENRequisition.ssSupplierId==0L)) {
sqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssSupplierId", DbType.Int64, ssENRequisition.ssSupplierId);

}
}
if(usedFields[5]) {
if ((ssENRequisition.ssRegionId==0L)) {
sqlCmd.CreateParameter("@ssRegionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRegionId", DbType.Int64, ssENRequisition.ssRegionId);

}
}
if(usedFields[6]) {
if ((ssENRequisition.ssAccountingRegionId==0L)) {
sqlCmd.CreateParameter("@ssAccountingRegionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAccountingRegionId", DbType.Int64, ssENRequisition.ssAccountingRegionId);

}
}
if(usedFields[7]) {
if ((ssENRequisition.ssApplicantId=="")) {
sqlCmd.CreateParameter("@ssApplicantId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssApplicantId", DbType.String, ssENRequisition.ssApplicantId);

}
}
if(usedFields[8]) {
sqlCmd.CreateParameter("@ssMaxDateFinishCapture", DbType.DateTime, ssENRequisition.ssMaxDateFinishCapture);
}
if(usedFields[9]) {
if ((ssENRequisition.ssProjectAssetServiceId==0L)) {
sqlCmd.CreateParameter("@ssProjectAssetServiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProjectAssetServiceId", DbType.Int64, ssENRequisition.ssProjectAssetServiceId);

}
}
if(usedFields[10]) {
sqlCmd.CreateParameter("@ssProjectAssetService", DbType.String, ssENRequisition.ssProjectAssetService);
}
if(usedFields[11]) {
sqlCmd.CreateParameter("@ssProjectDescription", DbType.String, ssENRequisition.ssProjectDescription);
}
if(usedFields[12]) {
if ((ssENRequisition.ssFrequencyId==0)) {
sqlCmd.CreateParameter("@ssFrequencyId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFrequencyId", DbType.Int32, ssENRequisition.ssFrequencyId);

}
}
if(usedFields[13]) {
sqlCmd.CreateParameter("@ssIsSustainability", DbType.Boolean, ssENRequisition.ssIsSustainability);
}
if(usedFields[14]) {
if ((ssENRequisition.ssSustainabilityId==0L)) {
sqlCmd.CreateParameter("@ssSustainabilityId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssSustainabilityId", DbType.Int64, ssENRequisition.ssSustainabilityId);

}
}
if(usedFields[15]) {
if ((ssENRequisition.ssBusinessValueCategoryId==0L)) {
sqlCmd.CreateParameter("@ssBusinessValueCategoryId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssBusinessValueCategoryId", DbType.Int64, ssENRequisition.ssBusinessValueCategoryId);

}
}
if(usedFields[16]) {
if ((ssENRequisition.ssBusinessValueSubcategoryId==0L)) {
sqlCmd.CreateParameter("@ssBusinessValueSubcategoryId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssBusinessValueSubcategoryId", DbType.Int64, ssENRequisition.ssBusinessValueSubcategoryId);

}
}
if(usedFields[17]) {
var TotalAmountParameter = sqlCmd.CreateParameter("@ssTotalAmount", DbType.Decimal, ssENRequisition.ssTotalAmount);
{
    string decimalAsStr = ssENRequisition.ssTotalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {TotalAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[18]) {
if ((ssENRequisition.ssCurrencyId=="")) {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCurrencyId", DbType.String, ssENRequisition.ssCurrencyId);

}
}
if(usedFields[19]) {
if ((ssENRequisition.ssDistributionId==0)) {
sqlCmd.CreateParameter("@ssDistributionId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssDistributionId", DbType.Int32, ssENRequisition.ssDistributionId);

}
}
if(usedFields[20]) {
if ((ssENRequisition.ssCostCenterId==0L)) {
sqlCmd.CreateParameter("@ssCostCenterId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCostCenterId", DbType.Int64, ssENRequisition.ssCostCenterId);

}
}
if(usedFields[21]) {
sqlCmd.CreateParameter("@ssHasContract", DbType.Boolean, ssENRequisition.ssHasContract);
}
if(usedFields[22]) {
sqlCmd.CreateParameter("@ssIsContractPending", DbType.Boolean, ssENRequisition.ssIsContractPending);
}
if(usedFields[23]) {
sqlCmd.CreateParameter("@ssHasDeposit", DbType.Boolean, ssENRequisition.ssHasDeposit);
}
if(usedFields[24]) {
sqlCmd.CreateParameter("@ssHasInsurance", DbType.Boolean, ssENRequisition.ssHasInsurance);
}
if(usedFields[25]) {
sqlCmd.CreateParameter("@ssHasAdvancePayment", DbType.Boolean, ssENRequisition.ssHasAdvancePayment);
}
if(usedFields[26]) {
if ((ssENRequisition.ssAccountingServiceTypeId_DEPR==0L)) {
sqlCmd.CreateParameter("@ssAccountingServiceTypeId_DEPR", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssAccountingServiceTypeId_DEPR", DbType.Int64, ssENRequisition.ssAccountingServiceTypeId_DEPR);

}
}
if(usedFields[27]) {
sqlCmd.CreateParameter("@ssServiceDescription_DEPREC", DbType.String, ssENRequisition.ssServiceDescription_DEPREC);
}
if(usedFields[28]) {
if ((ssENRequisition.ssInvoiceUsageId_DEPREC==0L)) {
sqlCmd.CreateParameter("@ssInvoiceUsageId_DEPREC", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceUsageId_DEPREC", DbType.Int64, ssENRequisition.ssInvoiceUsageId_DEPREC);

}
}
if(usedFields[29]) {
if ((ssENRequisition.ssServiceFormatId==0L)) {
sqlCmd.CreateParameter("@ssServiceFormatId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssServiceFormatId", DbType.Int64, ssENRequisition.ssServiceFormatId);

}
}
if(usedFields[30]) {
if ((ssENRequisition.ssCompanyId==0L)) {
sqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCompanyId", DbType.Int64, ssENRequisition.ssCompanyId);

}
}
if(usedFields[31]) {
var RetentionRateParameter = sqlCmd.CreateParameter("@ssRetentionRate", DbType.Decimal, ssENRequisition.ssRetentionRate);
{
    string decimalAsStr = ssENRequisition.ssRetentionRate.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {RetentionRateParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[32]) {
var NegotiatedExchangeRateParameter = sqlCmd.CreateParameter("@ssNegotiatedExchangeRate", DbType.Decimal, ssENRequisition.ssNegotiatedExchangeRate);
{
    string decimalAsStr = ssENRequisition.ssNegotiatedExchangeRate.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {NegotiatedExchangeRateParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[33]) {
if ((ssENRequisition.ssPaymentMethodId==0L)) {
sqlCmd.CreateParameter("@ssPaymentMethodId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentMethodId", DbType.Int64, ssENRequisition.ssPaymentMethodId);

}
}
if(usedFields[34]) {
if ((ssENRequisition.ssPaymentTermsId==0L)) {
sqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, ssENRequisition.ssPaymentTermsId);

}
}
if(usedFields[35]) {
sqlCmd.CreateParameter("@ssIsAutomaticAccounting", DbType.Boolean, ssENRequisition.ssIsAutomaticAccounting);
}
if(usedFields[36]) {
if ((ssENRequisition.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENRequisition.ssCreatedBy);

}
}
if(usedFields[37]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENRequisition.ssCreatedOn);
}
if(usedFields[38]) {
sqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENRequisition.ssUpdatedOn);
}
if(usedFields[39]) {
if ((ssENRequisition.ssUpdatedBy=="")) {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENRequisition.ssUpdatedBy);

}
}
if(usedFields[40]) {
if ((ssENRequisition.ssCreatedByApplicationRole==0L)) {
sqlCmd.CreateParameter("@ssCreatedByApplicationRole", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedByApplicationRole", DbType.Int64, ssENRequisition.ssCreatedByApplicationRole);

}
}
if(usedFields[41]) {
sqlCmd.CreateParameter("@ssDateOfCommitment", DbType.DateTime, ssENRequisition.ssDateOfCommitment);
}
if(usedFields[42]) {
sqlCmd.CreateParameter("@ssHasContractFileUploaded", DbType.Boolean, ssENRequisition.ssHasContractFileUploaded);
}
if(usedFields[43]) {
sqlCmd.CreateParameter("@ssHasUpdatedDateOfCommitment", DbType.Boolean, ssENRequisition.ssHasUpdatedDateOfCommitment);
}
if(usedFields[44]) {
sqlCmd.CreateParameter("@ssSubmittedOn", DbType.DateTime, ssENRequisition.ssSubmittedOn);
}
if(usedFields[45]) {
sqlCmd.CreateParameter("@ssIsDonation", DbType.Boolean, ssENRequisition.ssIsDonation);
}
if(usedFields[46]) {
sqlCmd.CreateParameter("@ssAdvWithoutInvoice", DbType.Boolean, ssENRequisition.ssAdvWithoutInvoice);
}
if(usedFields[47]) {
sqlCmd.CreateParameter("@ssWasAdvWithoutInvoice", DbType.Boolean, ssENRequisition.ssWasAdvWithoutInvoice);
}
if(usedFields[48]) {
sqlCmd.CreateParameter("@ssIsAdvanced", DbType.Boolean, ssENRequisition.ssIsAdvanced);
}
if(usedFields[49]) {
if ((ssENRequisition.ssDocumentTypeId==0L)) {
sqlCmd.CreateParameter("@ssDocumentTypeId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssDocumentTypeId", DbType.Int64, ssENRequisition.ssDocumentTypeId);

}
}
if(usedFields[50]) {
sqlCmd.CreateParameter("@ssIsCreatedByAnAssistente", DbType.Boolean, ssENRequisition.ssIsCreatedByAnAssistente);
}
if(usedFields[51]) {
if ((ssENRequisition.ssTelcelDirectionId==0L)) {
sqlCmd.CreateParameter("@ssTelcelDirectionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssTelcelDirectionId", DbType.Int64, ssENRequisition.ssTelcelDirectionId);

}
}
if(usedFields[52]) {
sqlCmd.CreateParameter("@ssHasMultiUpload", DbType.Boolean, ssENRequisition.ssHasMultiUpload);
}
if(usedFields[53]) {
sqlCmd.CreateParameter("@ssAccountingDate", DbType.DateTime, ssENRequisition.ssAccountingDate);
}
if(usedFields[54]) {
if ((ssENRequisition.ssPaymentOptionsId==0L)) {
sqlCmd.CreateParameter("@ssPaymentOptionsId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentOptionsId", DbType.Int64, ssENRequisition.ssPaymentOptionsId);

}
}
if(usedFields[55]) {
if ((ssENRequisition.ssPaymentWaysId==0L)) {
sqlCmd.CreateParameter("@ssPaymentWaysId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentWaysId", DbType.Int64, ssENRequisition.ssPaymentWaysId);

}
}
if(usedFields[56]) {
sqlCmd.CreateParameter("@ssBuyDocNumber", DbType.String, ssENRequisition.ssBuyDocNumber);
}
if(usedFields[57]) {
sqlCmd.CreateParameter("@ssBuyDocPosition", DbType.String, ssENRequisition.ssBuyDocPosition);
}
sqlCmd.CreateParameter("@idparam_ssENRequisition_ssId_Requisition", DbType.Int64, ssENRequisition.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateRequisition", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("Requisition", ssENRequisition.ssId.ToString()); }}
}
return;
}

}
}
