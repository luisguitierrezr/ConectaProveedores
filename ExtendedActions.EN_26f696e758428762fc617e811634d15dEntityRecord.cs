using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateOrderDetail
/// </summary>

public static async Task<long> CreateOrderDetail(IRequestContext requestContext,RC_7f0ffeffec7d0864eb8855fe8e873743 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrderDetail", "9bca7766-b995-4768-a07f-5f4302e4e5e7.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrderDetail", "9bca7766-b995-4768-a07f-5f4302e4e5e7.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_26f696e758428762fc617e811634d15dEntityRecord ssENOrderDetail = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENOrderDetailEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrderId, "orderid") ?? "orderid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsApprovalFromUserArea, "isapprovalfromuserarea") ?? "isapprovalfromuserarea") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectAssetServiceId, "projectassetserviceid") ?? "projectassetserviceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectAssetService, "projectassetservice") ?? "projectassetservice") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectDescription, "projectdescription") ?? "projectdescription") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@BusinessValueCategoryId, "businessvaluecategoryid") ?? "businessvaluecategoryid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@BusinessValueSubcategoryId, "businessvaluesubcategoryid") ?? "businessvaluesubcategoryid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@NegotiatedExchangeRate, "negotiatedexchangerate") ?? "negotiatedexchangerate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractStatus, "contractstatus") ?? "contractstatus") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@DateOfCommitment, "dateofcommitment") ?? "dateofcommitment") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasDeposit, "hasdeposit") ?? "hasdeposit") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasInsurance, "hasinsurance") ?? "hasinsurance") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@DistributionId, "distributionid") ?? "distributionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasAdvancePayment, "hasadvancepayment") ?? "hasadvancepayment") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@RetentionRate, "retentionrate") ?? "retentionrate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasBaseDate, "hasbasedate") ?? "hasbasedate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@StartBaseDate, "startbasedate") ?? "startbasedate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@EndBaseDate, "endbasedate") ?? "endbasedate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractNumber, "contractnumber") ?? "contractnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsRetentionApplied, "isretentionapplied") ?? "isretentionapplied") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@Frequency, "frequency") ?? "frequency") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@Period, "period") ?? "period") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrderRetentionTypeId, "orderretentiontypeid") ?? "orderretentiontypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentOptionsId, "paymentoptionsid") ?? "paymentoptionsid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentWaysId, "paymentwaysid") ?? "paymentwaysid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrdersContract, "orderscontract") ?? "orderscontract") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractAmount, "contractamount") ?? "contractamount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractTarif, "contracttarif") ?? "contracttarif") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractSupplier, "contractsupplier") ?? "contractsupplier") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsDependentFromFolios, "isdependentfromfolios") ?? "isdependentfromfolios") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@SpecialApprovalId, "specialapprovalid") ?? "specialapprovalid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@AllContactFilesValidated, "allcontactfilesvalidated") ?? "allcontactfilesvalidated") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasntRequestDocuments, "hasntrequestdocuments") ?? "hasntrequestdocuments") + "" +
" ) VALUES (" +
" @ssOrderId" +
", @ssIsApprovalFromUserArea" +
", @ssProjectAssetServiceId" +
", @ssProjectAssetService" +
", @ssProjectDescription" +
", @ssBusinessValueCategoryId" +
", @ssBusinessValueSubcategoryId" +
", @ssPaymentTermsId" +
", @ssPaymentMethodId" +
", @ssNegotiatedExchangeRate" +
", @ssContractStatus" +
", @ssDateOfCommitment" +
", @ssHasDeposit" +
", @ssHasInsurance" +
", @ssDistributionId" +
", @ssHasAdvancePayment" +
", @ssRetentionRate" +
", @ssHasBaseDate" +
", @ssStartBaseDate" +
", @ssEndBaseDate" +
", @ssContractNumber" +
", @ssIsRetentionApplied" +
", @ssFrequency" +
", @ssPeriod" +
", @ssOrderRetentionTypeId" +
", @ssPaymentOptionsId" +
", @ssPaymentWaysId" +
", @ssOrdersContract" +
", @ssContractAmount" +
", @ssContractTarif" +
", @ssContractSupplier" +
", @ssIsDependentFromFolios" +
", @ssSpecialApprovalId" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssUpdatedBy" +
", @ssUpdatedOn" +
", @ssAllContactFilesValidated" +
", @ssHasntRequestDocuments" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderDetail.ssOrderId);
insertSqlCmd.CreateParameter("@ssIsApprovalFromUserArea", DbType.Boolean, ssENOrderDetail.ssIsApprovalFromUserArea);
if ((ssENOrderDetail.ssProjectAssetServiceId==0L)) {
insertSqlCmd.CreateParameter("@ssProjectAssetServiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProjectAssetServiceId", DbType.Int64, ssENOrderDetail.ssProjectAssetServiceId);

}
insertSqlCmd.CreateParameter("@ssProjectAssetService", DbType.String, ssENOrderDetail.ssProjectAssetService);
insertSqlCmd.CreateParameter("@ssProjectDescription", DbType.String, ssENOrderDetail.ssProjectDescription);
if ((ssENOrderDetail.ssBusinessValueCategoryId==0L)) {
insertSqlCmd.CreateParameter("@ssBusinessValueCategoryId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssBusinessValueCategoryId", DbType.Int64, ssENOrderDetail.ssBusinessValueCategoryId);

}
if ((ssENOrderDetail.ssBusinessValueSubcategoryId==0L)) {
insertSqlCmd.CreateParameter("@ssBusinessValueSubcategoryId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssBusinessValueSubcategoryId", DbType.Int64, ssENOrderDetail.ssBusinessValueSubcategoryId);

}
if ((ssENOrderDetail.ssPaymentTermsId==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, ssENOrderDetail.ssPaymentTermsId);

}
if ((ssENOrderDetail.ssPaymentMethodId==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentMethodId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentMethodId", DbType.Int64, ssENOrderDetail.ssPaymentMethodId);

}
var NegotiatedExchangeRateParameter = insertSqlCmd.CreateParameter("@ssNegotiatedExchangeRate", DbType.Decimal, ssENOrderDetail.ssNegotiatedExchangeRate);
{
    string decimalAsStr = ssENOrderDetail.ssNegotiatedExchangeRate.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {NegotiatedExchangeRateParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENOrderDetail.ssContractStatus==0)) {
insertSqlCmd.CreateParameter("@ssContractStatus", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssContractStatus", DbType.Int32, ssENOrderDetail.ssContractStatus);

}
insertSqlCmd.CreateParameter("@ssDateOfCommitment", DbType.DateTime, ssENOrderDetail.ssDateOfCommitment);
insertSqlCmd.CreateParameter("@ssHasDeposit", DbType.Boolean, ssENOrderDetail.ssHasDeposit);
insertSqlCmd.CreateParameter("@ssHasInsurance", DbType.Boolean, ssENOrderDetail.ssHasInsurance);
if ((ssENOrderDetail.ssDistributionId==0)) {
insertSqlCmd.CreateParameter("@ssDistributionId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssDistributionId", DbType.Int32, ssENOrderDetail.ssDistributionId);

}
insertSqlCmd.CreateParameter("@ssHasAdvancePayment", DbType.Boolean, ssENOrderDetail.ssHasAdvancePayment);
var RetentionRateParameter = insertSqlCmd.CreateParameter("@ssRetentionRate", DbType.Decimal, ssENOrderDetail.ssRetentionRate);
{
    string decimalAsStr = ssENOrderDetail.ssRetentionRate.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {RetentionRateParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssHasBaseDate", DbType.Boolean, ssENOrderDetail.ssHasBaseDate);
insertSqlCmd.CreateParameter("@ssStartBaseDate", DbType.DateTime, ssENOrderDetail.ssStartBaseDate);
insertSqlCmd.CreateParameter("@ssEndBaseDate", DbType.DateTime, ssENOrderDetail.ssEndBaseDate);
insertSqlCmd.CreateParameter("@ssContractNumber", DbType.String, ssENOrderDetail.ssContractNumber);
insertSqlCmd.CreateParameter("@ssIsRetentionApplied", DbType.Boolean, ssENOrderDetail.ssIsRetentionApplied);
if ((ssENOrderDetail.ssFrequency==0)) {
insertSqlCmd.CreateParameter("@ssFrequency", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFrequency", DbType.Int32, ssENOrderDetail.ssFrequency);

}
insertSqlCmd.CreateParameter("@ssPeriod", DbType.String, ssENOrderDetail.ssPeriod);
if ((ssENOrderDetail.ssOrderRetentionTypeId==0)) {
insertSqlCmd.CreateParameter("@ssOrderRetentionTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderRetentionTypeId", DbType.Int32, ssENOrderDetail.ssOrderRetentionTypeId);

}
if ((ssENOrderDetail.ssPaymentOptionsId==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentOptionsId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentOptionsId", DbType.Int64, ssENOrderDetail.ssPaymentOptionsId);

}
if ((ssENOrderDetail.ssPaymentWaysId==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentWaysId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentWaysId", DbType.Int64, ssENOrderDetail.ssPaymentWaysId);

}
insertSqlCmd.CreateParameter("@ssOrdersContract", DbType.String, ssENOrderDetail.ssOrdersContract);
var ContractAmountParameter = insertSqlCmd.CreateParameter("@ssContractAmount", DbType.Decimal, ssENOrderDetail.ssContractAmount);
{
    string decimalAsStr = ssENOrderDetail.ssContractAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ContractAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var ContractTarifParameter = insertSqlCmd.CreateParameter("@ssContractTarif", DbType.Decimal, ssENOrderDetail.ssContractTarif);
{
    string decimalAsStr = ssENOrderDetail.ssContractTarif.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ContractTarifParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENOrderDetail.ssContractSupplier==0L)) {
insertSqlCmd.CreateParameter("@ssContractSupplier", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssContractSupplier", DbType.Int64, ssENOrderDetail.ssContractSupplier);

}
insertSqlCmd.CreateParameter("@ssIsDependentFromFolios", DbType.Boolean, ssENOrderDetail.ssIsDependentFromFolios);
if ((ssENOrderDetail.ssSpecialApprovalId==0)) {
insertSqlCmd.CreateParameter("@ssSpecialApprovalId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssSpecialApprovalId", DbType.Int32, ssENOrderDetail.ssSpecialApprovalId);

}
if ((ssENOrderDetail.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderDetail.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderDetail.ssCreatedOn);
if ((ssENOrderDetail.ssUpdatedBy=="")) {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENOrderDetail.ssUpdatedBy);

}
insertSqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENOrderDetail.ssUpdatedOn);
insertSqlCmd.CreateParameter("@ssAllContactFilesValidated", DbType.Boolean, ssENOrderDetail.ssAllContactFilesValidated);
insertSqlCmd.CreateParameter("@ssHasntRequestDocuments", DbType.Boolean, ssENOrderDetail.ssHasntRequestDocuments);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrderDetail", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENOrderDetail.ssOrderId;
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateOrderDetail
/// </summary>

public static async Task<long> CreateOrUpdateOrderDetail(IRequestContext requestContext,BitArray usedFields,RC_7f0ffeffec7d0864eb8855fe8e873743 inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateOrderDetail", "9bca7766-b995-4768-a07f-5f4302e4e5e7.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateOrderDetail", "9bca7766-b995-4768-a07f-5f4302e4e5e7.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_26f696e758428762fc617e811634d15dEntityRecord ssENOrderDetail = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(39,true);
}
string updateSet = "UPDATE " + ENOrderDetailEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsApprovalFromUserArea, "isapprovalfromuserarea") ?? "isapprovalfromuserarea") + " = @ssIsApprovalFromUserArea"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectAssetServiceId, "projectassetserviceid") ?? "projectassetserviceid") + " = @ssProjectAssetServiceId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectAssetService, "projectassetservice") ?? "projectassetservice") + " = @ssProjectAssetService"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectDescription, "projectdescription") ?? "projectdescription") + " = @ssProjectDescription"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@BusinessValueCategoryId, "businessvaluecategoryid") ?? "businessvaluecategoryid") + " = @ssBusinessValueCategoryId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@BusinessValueSubcategoryId, "businessvaluesubcategoryid") ?? "businessvaluesubcategoryid") + " = @ssBusinessValueSubcategoryId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + " = @ssPaymentTermsId"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid") + " = @ssPaymentMethodId"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@NegotiatedExchangeRate, "negotiatedexchangerate") ?? "negotiatedexchangerate") + " = @ssNegotiatedExchangeRate"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractStatus, "contractstatus") ?? "contractstatus") + " = @ssContractStatus"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@DateOfCommitment, "dateofcommitment") ?? "dateofcommitment") + " = @ssDateOfCommitment"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasDeposit, "hasdeposit") ?? "hasdeposit") + " = @ssHasDeposit"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasInsurance, "hasinsurance") ?? "hasinsurance") + " = @ssHasInsurance"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@DistributionId, "distributionid") ?? "distributionid") + " = @ssDistributionId"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasAdvancePayment, "hasadvancepayment") ?? "hasadvancepayment") + " = @ssHasAdvancePayment"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@RetentionRate, "retentionrate") ?? "retentionrate") + " = @ssRetentionRate"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasBaseDate, "hasbasedate") ?? "hasbasedate") + " = @ssHasBaseDate"): parameters);
parameters = (usedFields[18] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@StartBaseDate, "startbasedate") ?? "startbasedate") + " = @ssStartBaseDate"): parameters);
parameters = (usedFields[19] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@EndBaseDate, "endbasedate") ?? "endbasedate") + " = @ssEndBaseDate"): parameters);
parameters = (usedFields[20] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractNumber, "contractnumber") ?? "contractnumber") + " = @ssContractNumber"): parameters);
parameters = (usedFields[21] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsRetentionApplied, "isretentionapplied") ?? "isretentionapplied") + " = @ssIsRetentionApplied"): parameters);
parameters = (usedFields[22] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@Frequency, "frequency") ?? "frequency") + " = @ssFrequency"): parameters);
parameters = (usedFields[23] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@Period, "period") ?? "period") + " = @ssPeriod"): parameters);
parameters = (usedFields[24] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrderRetentionTypeId, "orderretentiontypeid") ?? "orderretentiontypeid") + " = @ssOrderRetentionTypeId"): parameters);
parameters = (usedFields[25] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentOptionsId, "paymentoptionsid") ?? "paymentoptionsid") + " = @ssPaymentOptionsId"): parameters);
parameters = (usedFields[26] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentWaysId, "paymentwaysid") ?? "paymentwaysid") + " = @ssPaymentWaysId"): parameters);
parameters = (usedFields[27] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrdersContract, "orderscontract") ?? "orderscontract") + " = @ssOrdersContract"): parameters);
parameters = (usedFields[28] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractAmount, "contractamount") ?? "contractamount") + " = @ssContractAmount"): parameters);
parameters = (usedFields[29] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractTarif, "contracttarif") ?? "contracttarif") + " = @ssContractTarif"): parameters);
parameters = (usedFields[30] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractSupplier, "contractsupplier") ?? "contractsupplier") + " = @ssContractSupplier"): parameters);
parameters = (usedFields[31] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsDependentFromFolios, "isdependentfromfolios") ?? "isdependentfromfolios") + " = @ssIsDependentFromFolios"): parameters);
parameters = (usedFields[32] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@SpecialApprovalId, "specialapprovalid") ?? "specialapprovalid") + " = @ssSpecialApprovalId"): parameters);
parameters = (usedFields[33] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[34] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[35] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + " = @ssUpdatedBy"): parameters);
parameters = (usedFields[36] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = @ssUpdatedOn"): parameters);
parameters = (usedFields[37] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@AllContactFilesValidated, "allcontactfilesvalidated") ?? "allcontactfilesvalidated") + " = @ssAllContactFilesValidated"): parameters);
parameters = (usedFields[38] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasntRequestDocuments, "hasntrequestdocuments") ?? "hasntrequestdocuments") + " = @ssHasntRequestDocuments"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = @idparam_ssENOrderDetail_ssOrderId_OrderDetail";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsApprovalFromUserArea, "isapprovalfromuserarea") ?? "isapprovalfromuserarea") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsApprovalFromUserArea, "isapprovalfromuserarea") ?? "isapprovalfromuserarea") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssIsApprovalFromUserArea", DbType.Boolean, ssENOrderDetail.ssIsApprovalFromUserArea);
}
if(usedFields[2]) {
if ((ssENOrderDetail.ssProjectAssetServiceId==0L)) {
sqlCmd.CreateParameter("@ssProjectAssetServiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProjectAssetServiceId", DbType.Int64, ssENOrderDetail.ssProjectAssetServiceId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssProjectAssetService", DbType.String, ssENOrderDetail.ssProjectAssetService);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssProjectDescription", DbType.String, ssENOrderDetail.ssProjectDescription);
}
if(usedFields[5]) {
if ((ssENOrderDetail.ssBusinessValueCategoryId==0L)) {
sqlCmd.CreateParameter("@ssBusinessValueCategoryId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssBusinessValueCategoryId", DbType.Int64, ssENOrderDetail.ssBusinessValueCategoryId);

}
}
if(usedFields[6]) {
if ((ssENOrderDetail.ssBusinessValueSubcategoryId==0L)) {
sqlCmd.CreateParameter("@ssBusinessValueSubcategoryId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssBusinessValueSubcategoryId", DbType.Int64, ssENOrderDetail.ssBusinessValueSubcategoryId);

}
}
if(usedFields[7]) {
if ((ssENOrderDetail.ssPaymentTermsId==0L)) {
sqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, ssENOrderDetail.ssPaymentTermsId);

}
}
if(usedFields[8]) {
if ((ssENOrderDetail.ssPaymentMethodId==0L)) {
sqlCmd.CreateParameter("@ssPaymentMethodId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentMethodId", DbType.Int64, ssENOrderDetail.ssPaymentMethodId);

}
}
if(usedFields[9]) {
var NegotiatedExchangeRateParameter = sqlCmd.CreateParameter("@ssNegotiatedExchangeRate", DbType.Decimal, ssENOrderDetail.ssNegotiatedExchangeRate);
{
    string decimalAsStr = ssENOrderDetail.ssNegotiatedExchangeRate.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {NegotiatedExchangeRateParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[10]) {
if ((ssENOrderDetail.ssContractStatus==0)) {
sqlCmd.CreateParameter("@ssContractStatus", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssContractStatus", DbType.Int32, ssENOrderDetail.ssContractStatus);

}
}
if(usedFields[11]) {
sqlCmd.CreateParameter("@ssDateOfCommitment", DbType.DateTime, ssENOrderDetail.ssDateOfCommitment);
}
if(usedFields[12]) {
sqlCmd.CreateParameter("@ssHasDeposit", DbType.Boolean, ssENOrderDetail.ssHasDeposit);
}
if(usedFields[13]) {
sqlCmd.CreateParameter("@ssHasInsurance", DbType.Boolean, ssENOrderDetail.ssHasInsurance);
}
if(usedFields[14]) {
if ((ssENOrderDetail.ssDistributionId==0)) {
sqlCmd.CreateParameter("@ssDistributionId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssDistributionId", DbType.Int32, ssENOrderDetail.ssDistributionId);

}
}
if(usedFields[15]) {
sqlCmd.CreateParameter("@ssHasAdvancePayment", DbType.Boolean, ssENOrderDetail.ssHasAdvancePayment);
}
if(usedFields[16]) {
var RetentionRateParameter = sqlCmd.CreateParameter("@ssRetentionRate", DbType.Decimal, ssENOrderDetail.ssRetentionRate);
{
    string decimalAsStr = ssENOrderDetail.ssRetentionRate.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {RetentionRateParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[17]) {
sqlCmd.CreateParameter("@ssHasBaseDate", DbType.Boolean, ssENOrderDetail.ssHasBaseDate);
}
if(usedFields[18]) {
sqlCmd.CreateParameter("@ssStartBaseDate", DbType.DateTime, ssENOrderDetail.ssStartBaseDate);
}
if(usedFields[19]) {
sqlCmd.CreateParameter("@ssEndBaseDate", DbType.DateTime, ssENOrderDetail.ssEndBaseDate);
}
if(usedFields[20]) {
sqlCmd.CreateParameter("@ssContractNumber", DbType.String, ssENOrderDetail.ssContractNumber);
}
if(usedFields[21]) {
sqlCmd.CreateParameter("@ssIsRetentionApplied", DbType.Boolean, ssENOrderDetail.ssIsRetentionApplied);
}
if(usedFields[22]) {
if ((ssENOrderDetail.ssFrequency==0)) {
sqlCmd.CreateParameter("@ssFrequency", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFrequency", DbType.Int32, ssENOrderDetail.ssFrequency);

}
}
if(usedFields[23]) {
sqlCmd.CreateParameter("@ssPeriod", DbType.String, ssENOrderDetail.ssPeriod);
}
if(usedFields[24]) {
if ((ssENOrderDetail.ssOrderRetentionTypeId==0)) {
sqlCmd.CreateParameter("@ssOrderRetentionTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderRetentionTypeId", DbType.Int32, ssENOrderDetail.ssOrderRetentionTypeId);

}
}
if(usedFields[25]) {
if ((ssENOrderDetail.ssPaymentOptionsId==0L)) {
sqlCmd.CreateParameter("@ssPaymentOptionsId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentOptionsId", DbType.Int64, ssENOrderDetail.ssPaymentOptionsId);

}
}
if(usedFields[26]) {
if ((ssENOrderDetail.ssPaymentWaysId==0L)) {
sqlCmd.CreateParameter("@ssPaymentWaysId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentWaysId", DbType.Int64, ssENOrderDetail.ssPaymentWaysId);

}
}
if(usedFields[27]) {
sqlCmd.CreateParameter("@ssOrdersContract", DbType.String, ssENOrderDetail.ssOrdersContract);
}
if(usedFields[28]) {
var ContractAmountParameter = sqlCmd.CreateParameter("@ssContractAmount", DbType.Decimal, ssENOrderDetail.ssContractAmount);
{
    string decimalAsStr = ssENOrderDetail.ssContractAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ContractAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[29]) {
var ContractTarifParameter = sqlCmd.CreateParameter("@ssContractTarif", DbType.Decimal, ssENOrderDetail.ssContractTarif);
{
    string decimalAsStr = ssENOrderDetail.ssContractTarif.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ContractTarifParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[30]) {
if ((ssENOrderDetail.ssContractSupplier==0L)) {
sqlCmd.CreateParameter("@ssContractSupplier", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssContractSupplier", DbType.Int64, ssENOrderDetail.ssContractSupplier);

}
}
if(usedFields[31]) {
sqlCmd.CreateParameter("@ssIsDependentFromFolios", DbType.Boolean, ssENOrderDetail.ssIsDependentFromFolios);
}
if(usedFields[32]) {
if ((ssENOrderDetail.ssSpecialApprovalId==0)) {
sqlCmd.CreateParameter("@ssSpecialApprovalId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssSpecialApprovalId", DbType.Int32, ssENOrderDetail.ssSpecialApprovalId);

}
}
if(usedFields[33]) {
if ((ssENOrderDetail.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderDetail.ssCreatedBy);

}
}
if(usedFields[34]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderDetail.ssCreatedOn);
}
if(usedFields[35]) {
if ((ssENOrderDetail.ssUpdatedBy=="")) {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENOrderDetail.ssUpdatedBy);

}
}
if(usedFields[36]) {
sqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENOrderDetail.ssUpdatedOn);
}
if(usedFields[37]) {
sqlCmd.CreateParameter("@ssAllContactFilesValidated", DbType.Boolean, ssENOrderDetail.ssAllContactFilesValidated);
}
if(usedFields[38]) {
sqlCmd.CreateParameter("@ssHasntRequestDocuments", DbType.Boolean, ssENOrderDetail.ssHasntRequestDocuments);
}
sqlCmd.CreateParameter("@idparam_ssENOrderDetail_ssOrderId_OrderDetail", DbType.Int64, ssENOrderDetail.ssOrderId);
int counter = 0;
if(ssENOrderDetail.ssOrderId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderDetail (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENOrderDetailEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrderId, "orderid") ?? "orderid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsApprovalFromUserArea, "isapprovalfromuserarea") ?? "isapprovalfromuserarea") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectAssetServiceId, "projectassetserviceid") ?? "projectassetserviceid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectAssetService, "projectassetservice") ?? "projectassetservice") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectDescription, "projectdescription") ?? "projectdescription") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@BusinessValueCategoryId, "businessvaluecategoryid") ?? "businessvaluecategoryid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@BusinessValueSubcategoryId, "businessvaluesubcategoryid") ?? "businessvaluesubcategoryid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@NegotiatedExchangeRate, "negotiatedexchangerate") ?? "negotiatedexchangerate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractStatus, "contractstatus") ?? "contractstatus") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@DateOfCommitment, "dateofcommitment") ?? "dateofcommitment") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasDeposit, "hasdeposit") ?? "hasdeposit") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasInsurance, "hasinsurance") ?? "hasinsurance") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@DistributionId, "distributionid") ?? "distributionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasAdvancePayment, "hasadvancepayment") ?? "hasadvancepayment") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@RetentionRate, "retentionrate") ?? "retentionrate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasBaseDate, "hasbasedate") ?? "hasbasedate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@StartBaseDate, "startbasedate") ?? "startbasedate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@EndBaseDate, "endbasedate") ?? "endbasedate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractNumber, "contractnumber") ?? "contractnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsRetentionApplied, "isretentionapplied") ?? "isretentionapplied") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@Frequency, "frequency") ?? "frequency") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@Period, "period") ?? "period") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrderRetentionTypeId, "orderretentiontypeid") ?? "orderretentiontypeid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentOptionsId, "paymentoptionsid") ?? "paymentoptionsid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentWaysId, "paymentwaysid") ?? "paymentwaysid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrdersContract, "orderscontract") ?? "orderscontract") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractAmount, "contractamount") ?? "contractamount") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractTarif, "contracttarif") ?? "contracttarif") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractSupplier, "contractsupplier") ?? "contractsupplier") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsDependentFromFolios, "isdependentfromfolios") ?? "isdependentfromfolios") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@SpecialApprovalId, "specialapprovalid") ?? "specialapprovalid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@AllContactFilesValidated, "allcontactfilesvalidated") ?? "allcontactfilesvalidated") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasntRequestDocuments, "hasntrequestdocuments") ?? "hasntrequestdocuments") + "" +
" ) VALUES (" +
" @ssOrderId" +
", @ssIsApprovalFromUserArea" +
", @ssProjectAssetServiceId" +
", @ssProjectAssetService" +
", @ssProjectDescription" +
", @ssBusinessValueCategoryId" +
", @ssBusinessValueSubcategoryId" +
", @ssPaymentTermsId" +
", @ssPaymentMethodId" +
", @ssNegotiatedExchangeRate" +
", @ssContractStatus" +
", @ssDateOfCommitment" +
", @ssHasDeposit" +
", @ssHasInsurance" +
", @ssDistributionId" +
", @ssHasAdvancePayment" +
", @ssRetentionRate" +
", @ssHasBaseDate" +
", @ssStartBaseDate" +
", @ssEndBaseDate" +
", @ssContractNumber" +
", @ssIsRetentionApplied" +
", @ssFrequency" +
", @ssPeriod" +
", @ssOrderRetentionTypeId" +
", @ssPaymentOptionsId" +
", @ssPaymentWaysId" +
", @ssOrdersContract" +
", @ssContractAmount" +
", @ssContractTarif" +
", @ssContractSupplier" +
", @ssIsDependentFromFolios" +
", @ssSpecialApprovalId" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssUpdatedBy" +
", @ssUpdatedOn" +
", @ssAllContactFilesValidated" +
", @ssHasntRequestDocuments" +
" )";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
insertSqlCmd.CreateParameter("@ssOrderId", DbType.Int64, ssENOrderDetail.ssOrderId);
insertSqlCmd.CreateParameter("@ssIsApprovalFromUserArea", DbType.Boolean, ssENOrderDetail.ssIsApprovalFromUserArea);
if ((ssENOrderDetail.ssProjectAssetServiceId==0L)) {
insertSqlCmd.CreateParameter("@ssProjectAssetServiceId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssProjectAssetServiceId", DbType.Int64, ssENOrderDetail.ssProjectAssetServiceId);

}
insertSqlCmd.CreateParameter("@ssProjectAssetService", DbType.String, ssENOrderDetail.ssProjectAssetService);
insertSqlCmd.CreateParameter("@ssProjectDescription", DbType.String, ssENOrderDetail.ssProjectDescription);
if ((ssENOrderDetail.ssBusinessValueCategoryId==0L)) {
insertSqlCmd.CreateParameter("@ssBusinessValueCategoryId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssBusinessValueCategoryId", DbType.Int64, ssENOrderDetail.ssBusinessValueCategoryId);

}
if ((ssENOrderDetail.ssBusinessValueSubcategoryId==0L)) {
insertSqlCmd.CreateParameter("@ssBusinessValueSubcategoryId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssBusinessValueSubcategoryId", DbType.Int64, ssENOrderDetail.ssBusinessValueSubcategoryId);

}
if ((ssENOrderDetail.ssPaymentTermsId==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, ssENOrderDetail.ssPaymentTermsId);

}
if ((ssENOrderDetail.ssPaymentMethodId==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentMethodId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentMethodId", DbType.Int64, ssENOrderDetail.ssPaymentMethodId);

}
var NegotiatedExchangeRateParameter = insertSqlCmd.CreateParameter("@ssNegotiatedExchangeRate", DbType.Decimal, ssENOrderDetail.ssNegotiatedExchangeRate);
{
    string decimalAsStr = ssENOrderDetail.ssNegotiatedExchangeRate.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {NegotiatedExchangeRateParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENOrderDetail.ssContractStatus==0)) {
insertSqlCmd.CreateParameter("@ssContractStatus", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssContractStatus", DbType.Int32, ssENOrderDetail.ssContractStatus);

}
insertSqlCmd.CreateParameter("@ssDateOfCommitment", DbType.DateTime, ssENOrderDetail.ssDateOfCommitment);
insertSqlCmd.CreateParameter("@ssHasDeposit", DbType.Boolean, ssENOrderDetail.ssHasDeposit);
insertSqlCmd.CreateParameter("@ssHasInsurance", DbType.Boolean, ssENOrderDetail.ssHasInsurance);
if ((ssENOrderDetail.ssDistributionId==0)) {
insertSqlCmd.CreateParameter("@ssDistributionId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssDistributionId", DbType.Int32, ssENOrderDetail.ssDistributionId);

}
insertSqlCmd.CreateParameter("@ssHasAdvancePayment", DbType.Boolean, ssENOrderDetail.ssHasAdvancePayment);
var RetentionRateParameter = insertSqlCmd.CreateParameter("@ssRetentionRate", DbType.Decimal, ssENOrderDetail.ssRetentionRate);
{
    string decimalAsStr = ssENOrderDetail.ssRetentionRate.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {RetentionRateParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssHasBaseDate", DbType.Boolean, ssENOrderDetail.ssHasBaseDate);
insertSqlCmd.CreateParameter("@ssStartBaseDate", DbType.DateTime, ssENOrderDetail.ssStartBaseDate);
insertSqlCmd.CreateParameter("@ssEndBaseDate", DbType.DateTime, ssENOrderDetail.ssEndBaseDate);
insertSqlCmd.CreateParameter("@ssContractNumber", DbType.String, ssENOrderDetail.ssContractNumber);
insertSqlCmd.CreateParameter("@ssIsRetentionApplied", DbType.Boolean, ssENOrderDetail.ssIsRetentionApplied);
if ((ssENOrderDetail.ssFrequency==0)) {
insertSqlCmd.CreateParameter("@ssFrequency", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssFrequency", DbType.Int32, ssENOrderDetail.ssFrequency);

}
insertSqlCmd.CreateParameter("@ssPeriod", DbType.String, ssENOrderDetail.ssPeriod);
if ((ssENOrderDetail.ssOrderRetentionTypeId==0)) {
insertSqlCmd.CreateParameter("@ssOrderRetentionTypeId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderRetentionTypeId", DbType.Int32, ssENOrderDetail.ssOrderRetentionTypeId);

}
if ((ssENOrderDetail.ssPaymentOptionsId==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentOptionsId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentOptionsId", DbType.Int64, ssENOrderDetail.ssPaymentOptionsId);

}
if ((ssENOrderDetail.ssPaymentWaysId==0L)) {
insertSqlCmd.CreateParameter("@ssPaymentWaysId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssPaymentWaysId", DbType.Int64, ssENOrderDetail.ssPaymentWaysId);

}
insertSqlCmd.CreateParameter("@ssOrdersContract", DbType.String, ssENOrderDetail.ssOrdersContract);
var ContractAmountParameter = insertSqlCmd.CreateParameter("@ssContractAmount", DbType.Decimal, ssENOrderDetail.ssContractAmount);
{
    string decimalAsStr = ssENOrderDetail.ssContractAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ContractAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
var ContractTarifParameter = insertSqlCmd.CreateParameter("@ssContractTarif", DbType.Decimal, ssENOrderDetail.ssContractTarif);
{
    string decimalAsStr = ssENOrderDetail.ssContractTarif.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ContractTarifParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
if ((ssENOrderDetail.ssContractSupplier==0L)) {
insertSqlCmd.CreateParameter("@ssContractSupplier", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssContractSupplier", DbType.Int64, ssENOrderDetail.ssContractSupplier);

}
insertSqlCmd.CreateParameter("@ssIsDependentFromFolios", DbType.Boolean, ssENOrderDetail.ssIsDependentFromFolios);
if ((ssENOrderDetail.ssSpecialApprovalId==0)) {
insertSqlCmd.CreateParameter("@ssSpecialApprovalId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssSpecialApprovalId", DbType.Int32, ssENOrderDetail.ssSpecialApprovalId);

}
if ((ssENOrderDetail.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderDetail.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderDetail.ssCreatedOn);
if ((ssENOrderDetail.ssUpdatedBy=="")) {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENOrderDetail.ssUpdatedBy);

}
insertSqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENOrderDetail.ssUpdatedOn);
insertSqlCmd.CreateParameter("@ssAllContactFilesValidated", DbType.Boolean, ssENOrderDetail.ssAllContactFilesValidated);
insertSqlCmd.CreateParameter("@ssHasntRequestDocuments", DbType.Boolean, ssENOrderDetail.ssHasntRequestDocuments);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderDetail", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
outParamId = ssENOrderDetail.ssOrderId;
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENOrderDetail.ssOrderId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeOrderDetail
/// </summary>

public static async Task CreateOrUpdateSomeOrderDetail(IRequestContext requestContext,RL_e5767287da79a139581b76b6fbb20753 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeOrderDetail", "9bca7766-b995-4768-a07f-5f4302e4e5e7.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeOrderDetail", "9bca7766-b995-4768-a07f-5f4302e4e5e7.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENOrderDetailEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrderId, "orderid") ?? "orderid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsApprovalFromUserArea, "isapprovalfromuserarea") ?? "isapprovalfromuserarea") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectAssetServiceId, "projectassetserviceid") ?? "projectassetserviceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectAssetService, "projectassetservice") ?? "projectassetservice") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectDescription, "projectdescription") ?? "projectdescription") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@BusinessValueCategoryId, "businessvaluecategoryid") ?? "businessvaluecategoryid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@BusinessValueSubcategoryId, "businessvaluesubcategoryid") ?? "businessvaluesubcategoryid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@NegotiatedExchangeRate, "negotiatedexchangerate") ?? "negotiatedexchangerate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractStatus, "contractstatus") ?? "contractstatus") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@DateOfCommitment, "dateofcommitment") ?? "dateofcommitment") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasDeposit, "hasdeposit") ?? "hasdeposit") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasInsurance, "hasinsurance") ?? "hasinsurance") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@DistributionId, "distributionid") ?? "distributionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasAdvancePayment, "hasadvancepayment") ?? "hasadvancepayment") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@RetentionRate, "retentionrate") ?? "retentionrate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasBaseDate, "hasbasedate") ?? "hasbasedate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@StartBaseDate, "startbasedate") ?? "startbasedate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@EndBaseDate, "endbasedate") ?? "endbasedate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractNumber, "contractnumber") ?? "contractnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsRetentionApplied, "isretentionapplied") ?? "isretentionapplied") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@Frequency, "frequency") ?? "frequency") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@Period, "period") ?? "period") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrderRetentionTypeId, "orderretentiontypeid") ?? "orderretentiontypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentOptionsId, "paymentoptionsid") ?? "paymentoptionsid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentWaysId, "paymentwaysid") ?? "paymentwaysid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrdersContract, "orderscontract") ?? "orderscontract") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractAmount, "contractamount") ?? "contractamount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractTarif, "contracttarif") ?? "contracttarif") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractSupplier, "contractsupplier") ?? "contractsupplier") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsDependentFromFolios, "isdependentfromfolios") ?? "isdependentfromfolios") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@SpecialApprovalId, "specialapprovalid") ?? "specialapprovalid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@AllContactFilesValidated, "allcontactfilesvalidated") ?? "allcontactfilesvalidated") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasntRequestDocuments, "hasntrequestdocuments") ?? "hasntrequestdocuments") + ") VALUES ( unnest(@ssOrderId),  unnest(@ssIsApprovalFromUserArea),  unnest(@ssProjectAssetServiceId),  unnest(@ssProjectAssetService),  unnest(@ssProjectDescription),  unnest(@ssBusinessValueCategoryId),  unnest(@ssBusinessValueSubcategoryId),  unnest(@ssPaymentTermsId),  unnest(@ssPaymentMethodId),  unnest(@ssNegotiatedExchangeRate),  unnest(@ssContractStatus),  unnest(@ssDateOfCommitment),  unnest(@ssHasDeposit),  unnest(@ssHasInsurance),  unnest(@ssDistributionId),  unnest(@ssHasAdvancePayment),  unnest(@ssRetentionRate),  unnest(@ssHasBaseDate),  unnest(@ssStartBaseDate),  unnest(@ssEndBaseDate),  unnest(@ssContractNumber),  unnest(@ssIsRetentionApplied),  unnest(@ssFrequency),  unnest(@ssPeriod),  unnest(@ssOrderRetentionTypeId),  unnest(@ssPaymentOptionsId),  unnest(@ssPaymentWaysId),  unnest(@ssOrdersContract),  unnest(@ssContractAmount),  unnest(@ssContractTarif),  unnest(@ssContractSupplier),  unnest(@ssIsDependentFromFolios),  unnest(@ssSpecialApprovalId),  unnest(@ssCreatedBy),  unnest(@ssCreatedOn),  unnest(@ssUpdatedBy),  unnest(@ssUpdatedOn),  unnest(@ssAllContactFilesValidated),  unnest(@ssHasntRequestDocuments)) ON CONFLICT(" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrderId, "orderid") ?? "orderid") + ") do update set " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsApprovalFromUserArea, "isapprovalfromuserarea") ?? "isapprovalfromuserarea") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsApprovalFromUserArea, "isapprovalfromuserarea") ?? "isapprovalfromuserarea") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectAssetServiceId, "projectassetserviceid") ?? "projectassetserviceid") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectAssetServiceId, "projectassetserviceid") ?? "projectassetserviceid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectAssetService, "projectassetservice") ?? "projectassetservice") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectAssetService, "projectassetservice") ?? "projectassetservice") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectDescription, "projectdescription") ?? "projectdescription") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectDescription, "projectdescription") ?? "projectdescription") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@BusinessValueCategoryId, "businessvaluecategoryid") ?? "businessvaluecategoryid") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@BusinessValueCategoryId, "businessvaluecategoryid") ?? "businessvaluecategoryid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@BusinessValueSubcategoryId, "businessvaluesubcategoryid") ?? "businessvaluesubcategoryid") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@BusinessValueSubcategoryId, "businessvaluesubcategoryid") ?? "businessvaluesubcategoryid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@NegotiatedExchangeRate, "negotiatedexchangerate") ?? "negotiatedexchangerate") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@NegotiatedExchangeRate, "negotiatedexchangerate") ?? "negotiatedexchangerate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractStatus, "contractstatus") ?? "contractstatus") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractStatus, "contractstatus") ?? "contractstatus") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@DateOfCommitment, "dateofcommitment") ?? "dateofcommitment") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@DateOfCommitment, "dateofcommitment") ?? "dateofcommitment") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasDeposit, "hasdeposit") ?? "hasdeposit") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasDeposit, "hasdeposit") ?? "hasdeposit") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasInsurance, "hasinsurance") ?? "hasinsurance") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasInsurance, "hasinsurance") ?? "hasinsurance") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@DistributionId, "distributionid") ?? "distributionid") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@DistributionId, "distributionid") ?? "distributionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasAdvancePayment, "hasadvancepayment") ?? "hasadvancepayment") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasAdvancePayment, "hasadvancepayment") ?? "hasadvancepayment") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@RetentionRate, "retentionrate") ?? "retentionrate") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@RetentionRate, "retentionrate") ?? "retentionrate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasBaseDate, "hasbasedate") ?? "hasbasedate") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasBaseDate, "hasbasedate") ?? "hasbasedate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@StartBaseDate, "startbasedate") ?? "startbasedate") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@StartBaseDate, "startbasedate") ?? "startbasedate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@EndBaseDate, "endbasedate") ?? "endbasedate") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@EndBaseDate, "endbasedate") ?? "endbasedate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractNumber, "contractnumber") ?? "contractnumber") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractNumber, "contractnumber") ?? "contractnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsRetentionApplied, "isretentionapplied") ?? "isretentionapplied") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsRetentionApplied, "isretentionapplied") ?? "isretentionapplied") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@Frequency, "frequency") ?? "frequency") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@Frequency, "frequency") ?? "frequency") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@Period, "period") ?? "period") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@Period, "period") ?? "period") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrderRetentionTypeId, "orderretentiontypeid") ?? "orderretentiontypeid") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrderRetentionTypeId, "orderretentiontypeid") ?? "orderretentiontypeid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentOptionsId, "paymentoptionsid") ?? "paymentoptionsid") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentOptionsId, "paymentoptionsid") ?? "paymentoptionsid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentWaysId, "paymentwaysid") ?? "paymentwaysid") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentWaysId, "paymentwaysid") ?? "paymentwaysid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrdersContract, "orderscontract") ?? "orderscontract") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrdersContract, "orderscontract") ?? "orderscontract") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractAmount, "contractamount") ?? "contractamount") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractAmount, "contractamount") ?? "contractamount") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractTarif, "contracttarif") ?? "contracttarif") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractTarif, "contracttarif") ?? "contracttarif") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractSupplier, "contractsupplier") ?? "contractsupplier") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractSupplier, "contractsupplier") ?? "contractsupplier") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsDependentFromFolios, "isdependentfromfolios") ?? "isdependentfromfolios") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsDependentFromFolios, "isdependentfromfolios") ?? "isdependentfromfolios") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@SpecialApprovalId, "specialapprovalid") ?? "specialapprovalid") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@SpecialApprovalId, "specialapprovalid") ?? "specialapprovalid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@AllContactFilesValidated, "allcontactfilesvalidated") ?? "allcontactfilesvalidated") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@AllContactFilesValidated, "allcontactfilesvalidated") ?? "allcontactfilesvalidated") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasntRequestDocuments, "hasntrequestdocuments") ?? "hasntrequestdocuments") + " = EXCLUDED." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasntRequestDocuments, "hasntrequestdocuments") ?? "hasntrequestdocuments") + " ";
insertSql += "";


List<object> insertOrderIdList = new List<object>();
List<bool> insertIsApprovalFromUserAreaList = new List<bool>();
List<object> insertProjectAssetServiceIdList = new List<object>();
List<string> insertProjectAssetServiceList = new List<string>();
List<string> insertProjectDescriptionList = new List<string>();
List<object> insertBusinessValueCategoryIdList = new List<object>();
List<object> insertBusinessValueSubcategoryIdList = new List<object>();
List<object> insertPaymentTermsIdList = new List<object>();
List<object> insertPaymentMethodIdList = new List<object>();
List<decimal> insertNegotiatedExchangeRateList = new List<decimal>();
List<object> insertContractStatusList = new List<object>();
List<DateTime> insertDateOfCommitmentList = new List<DateTime>();
List<bool> insertHasDepositList = new List<bool>();
List<bool> insertHasInsuranceList = new List<bool>();
List<object> insertDistributionIdList = new List<object>();
List<bool> insertHasAdvancePaymentList = new List<bool>();
List<decimal> insertRetentionRateList = new List<decimal>();
List<bool> insertHasBaseDateList = new List<bool>();
List<DateTime> insertStartBaseDateList = new List<DateTime>();
List<DateTime> insertEndBaseDateList = new List<DateTime>();
List<string> insertContractNumberList = new List<string>();
List<bool> insertIsRetentionAppliedList = new List<bool>();
List<object> insertFrequencyList = new List<object>();
List<string> insertPeriodList = new List<string>();
List<object> insertOrderRetentionTypeIdList = new List<object>();
List<object> insertPaymentOptionsIdList = new List<object>();
List<object> insertPaymentWaysIdList = new List<object>();
List<string> insertOrdersContractList = new List<string>();
List<decimal> insertContractAmountList = new List<decimal>();
List<decimal> insertContractTarifList = new List<decimal>();
List<object> insertContractSupplierList = new List<object>();
List<bool> insertIsDependentFromFoliosList = new List<bool>();
List<object> insertSpecialApprovalIdList = new List<object>();
List<object> insertCreatedByList = new List<object>();
List<DateTime> insertCreatedOnList = new List<DateTime>();
List<object> insertUpdatedByList = new List<object>();
List<DateTime> insertUpdatedOnList = new List<DateTime>();
List<bool> insertAllContactFilesValidatedList = new List<bool>();
List<bool> insertHasntRequestDocumentsList = new List<bool>();


var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_7f0ffeffec7d0864eb8855fe8e873743)inParamSourceList.Current).ssENOrderDetail;
insertOrderIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderId));
insertIsApprovalFromUserAreaList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsApprovalFromUserArea));
if ((record.ssProjectAssetServiceId==0L)) {
insertProjectAssetServiceIdList.Add(null);
} else {
insertProjectAssetServiceIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssProjectAssetServiceId));
}
insertProjectAssetServiceList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssProjectAssetService));
insertProjectDescriptionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssProjectDescription));
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
if ((record.ssPaymentTermsId==0L)) {
insertPaymentTermsIdList.Add(null);
} else {
insertPaymentTermsIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssPaymentTermsId));
}
if ((record.ssPaymentMethodId==0L)) {
insertPaymentMethodIdList.Add(null);
} else {
insertPaymentMethodIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssPaymentMethodId));
}
insertNegotiatedExchangeRateList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssNegotiatedExchangeRate));
if ((record.ssContractStatus==0)) {
insertContractStatusList.Add(null);
} else {
insertContractStatusList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssContractStatus));
}
insertDateOfCommitmentList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssDateOfCommitment));
insertHasDepositList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasDeposit));
insertHasInsuranceList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasInsurance));
if ((record.ssDistributionId==0)) {
insertDistributionIdList.Add(null);
} else {
insertDistributionIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssDistributionId));
}
insertHasAdvancePaymentList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasAdvancePayment));
insertRetentionRateList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssRetentionRate));
insertHasBaseDateList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasBaseDate));
insertStartBaseDateList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssStartBaseDate));
insertEndBaseDateList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssEndBaseDate));
insertContractNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssContractNumber));
insertIsRetentionAppliedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsRetentionApplied));
if ((record.ssFrequency==0)) {
insertFrequencyList.Add(null);
} else {
insertFrequencyList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssFrequency));
}
insertPeriodList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPeriod));
if ((record.ssOrderRetentionTypeId==0)) {
insertOrderRetentionTypeIdList.Add(null);
} else {
insertOrderRetentionTypeIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssOrderRetentionTypeId));
}
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
insertOrdersContractList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssOrdersContract));
insertContractAmountList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssContractAmount));
insertContractTarifList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssContractTarif));
if ((record.ssContractSupplier==0L)) {
insertContractSupplierList.Add(null);
} else {
insertContractSupplierList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssContractSupplier));
}
insertIsDependentFromFoliosList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsDependentFromFolios));
if ((record.ssSpecialApprovalId==0)) {
insertSpecialApprovalIdList.Add(null);
} else {
insertSpecialApprovalIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssSpecialApprovalId));
}
if ((record.ssCreatedBy=="")) {
insertCreatedByList.Add(null);
} else {
insertCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
insertCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
if ((record.ssUpdatedBy=="")) {
insertUpdatedByList.Add(null);
} else {
insertUpdatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssUpdatedBy));
}
insertUpdatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssUpdatedOn));
insertAllContactFilesValidatedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssAllContactFilesValidated));
insertHasntRequestDocumentsList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssHasntRequestDocuments));
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertOrderIdList.IsEmpty() || !insertIsApprovalFromUserAreaList.IsEmpty() || !insertProjectAssetServiceIdList.IsEmpty() || !insertProjectAssetServiceList.IsEmpty() || !insertProjectDescriptionList.IsEmpty() || !insertBusinessValueCategoryIdList.IsEmpty() || !insertBusinessValueSubcategoryIdList.IsEmpty() || !insertPaymentTermsIdList.IsEmpty() || !insertPaymentMethodIdList.IsEmpty() || !insertNegotiatedExchangeRateList.IsEmpty() || !insertContractStatusList.IsEmpty() || !insertDateOfCommitmentList.IsEmpty() || !insertHasDepositList.IsEmpty() || !insertHasInsuranceList.IsEmpty() || !insertDistributionIdList.IsEmpty() || !insertHasAdvancePaymentList.IsEmpty() || !insertRetentionRateList.IsEmpty() || !insertHasBaseDateList.IsEmpty() || !insertStartBaseDateList.IsEmpty() || !insertEndBaseDateList.IsEmpty() || !insertContractNumberList.IsEmpty() || !insertIsRetentionAppliedList.IsEmpty() || !insertFrequencyList.IsEmpty() || !insertPeriodList.IsEmpty() || !insertOrderRetentionTypeIdList.IsEmpty() || !insertPaymentOptionsIdList.IsEmpty() || !insertPaymentWaysIdList.IsEmpty() || !insertOrdersContractList.IsEmpty() || !insertContractAmountList.IsEmpty() || !insertContractTarifList.IsEmpty() || !insertContractSupplierList.IsEmpty() || !insertIsDependentFromFoliosList.IsEmpty() || !insertSpecialApprovalIdList.IsEmpty() || !insertCreatedByList.IsEmpty() || !insertCreatedOnList.IsEmpty() || !insertUpdatedByList.IsEmpty() || !insertUpdatedOnList.IsEmpty() || !insertAllContactFilesValidatedList.IsEmpty() || !insertHasntRequestDocumentsList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssOrderId",DbType.Int64,insertOrderIdList);
executionService.CreateParameter(insertSqlCmd,"@ssIsApprovalFromUserArea",DbType.Boolean,insertIsApprovalFromUserAreaList);
executionService.CreateParameter(insertSqlCmd,"@ssProjectAssetServiceId",DbType.Int64,insertProjectAssetServiceIdList);
executionService.CreateParameter(insertSqlCmd,"@ssProjectAssetService",DbType.String,insertProjectAssetServiceList);
executionService.CreateParameter(insertSqlCmd,"@ssProjectDescription",DbType.String,insertProjectDescriptionList);
executionService.CreateParameter(insertSqlCmd,"@ssBusinessValueCategoryId",DbType.Int64,insertBusinessValueCategoryIdList);
executionService.CreateParameter(insertSqlCmd,"@ssBusinessValueSubcategoryId",DbType.Int64,insertBusinessValueSubcategoryIdList);
executionService.CreateParameter(insertSqlCmd,"@ssPaymentTermsId",DbType.Int64,insertPaymentTermsIdList);
executionService.CreateParameter(insertSqlCmd,"@ssPaymentMethodId",DbType.Int64,insertPaymentMethodIdList);
executionService.CreateParameter(insertSqlCmd,"@ssNegotiatedExchangeRate",DbType.Decimal,insertNegotiatedExchangeRateList);
executionService.CreateParameter(insertSqlCmd,"@ssContractStatus",DbType.Int32,insertContractStatusList);
executionService.CreateParameter(insertSqlCmd,"@ssDateOfCommitment",DbType.DateTime,insertDateOfCommitmentList);
executionService.CreateParameter(insertSqlCmd,"@ssHasDeposit",DbType.Boolean,insertHasDepositList);
executionService.CreateParameter(insertSqlCmd,"@ssHasInsurance",DbType.Boolean,insertHasInsuranceList);
executionService.CreateParameter(insertSqlCmd,"@ssDistributionId",DbType.Int32,insertDistributionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssHasAdvancePayment",DbType.Boolean,insertHasAdvancePaymentList);
executionService.CreateParameter(insertSqlCmd,"@ssRetentionRate",DbType.Decimal,insertRetentionRateList);
executionService.CreateParameter(insertSqlCmd,"@ssHasBaseDate",DbType.Boolean,insertHasBaseDateList);
executionService.CreateParameter(insertSqlCmd,"@ssStartBaseDate",DbType.DateTime,insertStartBaseDateList);
executionService.CreateParameter(insertSqlCmd,"@ssEndBaseDate",DbType.DateTime,insertEndBaseDateList);
executionService.CreateParameter(insertSqlCmd,"@ssContractNumber",DbType.String,insertContractNumberList);
executionService.CreateParameter(insertSqlCmd,"@ssIsRetentionApplied",DbType.Boolean,insertIsRetentionAppliedList);
executionService.CreateParameter(insertSqlCmd,"@ssFrequency",DbType.Int32,insertFrequencyList);
executionService.CreateParameter(insertSqlCmd,"@ssPeriod",DbType.String,insertPeriodList);
executionService.CreateParameter(insertSqlCmd,"@ssOrderRetentionTypeId",DbType.Int32,insertOrderRetentionTypeIdList);
executionService.CreateParameter(insertSqlCmd,"@ssPaymentOptionsId",DbType.Int64,insertPaymentOptionsIdList);
executionService.CreateParameter(insertSqlCmd,"@ssPaymentWaysId",DbType.Int64,insertPaymentWaysIdList);
executionService.CreateParameter(insertSqlCmd,"@ssOrdersContract",DbType.String,insertOrdersContractList);
executionService.CreateParameter(insertSqlCmd,"@ssContractAmount",DbType.Decimal,insertContractAmountList);
executionService.CreateParameter(insertSqlCmd,"@ssContractTarif",DbType.Decimal,insertContractTarifList);
executionService.CreateParameter(insertSqlCmd,"@ssContractSupplier",DbType.Int64,insertContractSupplierList);
executionService.CreateParameter(insertSqlCmd,"@ssIsDependentFromFolios",DbType.Boolean,insertIsDependentFromFoliosList);
executionService.CreateParameter(insertSqlCmd,"@ssSpecialApprovalId",DbType.Int32,insertSpecialApprovalIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedOn",DbType.DateTime,insertCreatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssUpdatedBy",DbType.String,insertUpdatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssUpdatedOn",DbType.DateTime,insertUpdatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssAllContactFilesValidated",DbType.Boolean,insertAllContactFilesValidatedList);
executionService.CreateParameter(insertSqlCmd,"@ssHasntRequestDocuments",DbType.Boolean,insertHasntRequestDocumentsList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderDetail (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteOrderDetail
/// </summary>

public static async Task DeleteOrderDetail(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteOrderDetail", "9bca7766-b995-4768-a07f-5f4302e4e5e7.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteOrderDetail", "9bca7766-b995-4768-a07f-5f4302e4e5e7.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderDetailEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderDetail", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllOrderDetail
/// </summary>

public static async Task DeleteAllOrderDetail(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllOrderDetail", "9bca7766-b995-4768-a07f-5f4302e4e5e7.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllOrderDetail", "9bca7766-b995-4768-a07f-5f4302e4e5e7.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderDetailEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderDetail", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetOrderDetail
/// </summary>

public static async Task<RC_7f0ffeffec7d0864eb8855fe8e873743> GetOrderDetail(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_7f0ffeffec7d0864eb8855fe8e873743 outParamRecord = default;
outParamRecord = new RC_7f0ffeffec7d0864eb8855fe8e873743();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderDetail", "9bca7766-b995-4768-a07f-5f4302e4e5e7.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderDetail", "9bca7766-b995-4768-a07f-5f4302e4e5e7.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrderId, "orderid") ?? "orderid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsApprovalFromUserArea, "isapprovalfromuserarea") ?? "isapprovalfromuserarea", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectAssetServiceId, "projectassetserviceid") ?? "projectassetserviceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectAssetService, "projectassetservice") ?? "projectassetservice", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectDescription, "projectdescription") ?? "projectdescription", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@BusinessValueCategoryId, "businessvaluecategoryid") ?? "businessvaluecategoryid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@BusinessValueSubcategoryId, "businessvaluesubcategoryid") ?? "businessvaluesubcategoryid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@NegotiatedExchangeRate, "negotiatedexchangerate") ?? "negotiatedexchangerate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractStatus, "contractstatus") ?? "contractstatus", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@DateOfCommitment, "dateofcommitment") ?? "dateofcommitment", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasDeposit, "hasdeposit") ?? "hasdeposit", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasInsurance, "hasinsurance") ?? "hasinsurance", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@DistributionId, "distributionid") ?? "distributionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasAdvancePayment, "hasadvancepayment") ?? "hasadvancepayment", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@RetentionRate, "retentionrate") ?? "retentionrate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasBaseDate, "hasbasedate") ?? "hasbasedate", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@StartBaseDate, "startbasedate") ?? "startbasedate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@EndBaseDate, "endbasedate") ?? "endbasedate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractNumber, "contractnumber") ?? "contractnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsRetentionApplied, "isretentionapplied") ?? "isretentionapplied", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@Frequency, "frequency") ?? "frequency", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@Period, "period") ?? "period", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrderRetentionTypeId, "orderretentiontypeid") ?? "orderretentiontypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentOptionsId, "paymentoptionsid") ?? "paymentoptionsid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentWaysId, "paymentwaysid") ?? "paymentwaysid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrdersContract, "orderscontract") ?? "orderscontract", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractAmount, "contractamount") ?? "contractamount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractTarif, "contracttarif") ?? "contracttarif", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractSupplier, "contractsupplier") ?? "contractsupplier", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsDependentFromFolios, "isdependentfromfolios") ?? "isdependentfromfolios", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@SpecialApprovalId, "specialapprovalid") ?? "specialapprovalid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@AllContactFilesValidated, "allcontactfilesvalidated") ?? "allcontactfilesvalidated", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasntRequestDocuments, "hasntrequestdocuments") ?? "hasntrequestdocuments", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENOrderDetailEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderDetail", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(39,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderDetailEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetOrderDetailForUpdate
/// </summary>

public static async Task<RC_7f0ffeffec7d0864eb8855fe8e873743> GetOrderDetailForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_7f0ffeffec7d0864eb8855fe8e873743 outParamRecord = default;
outParamRecord = new RC_7f0ffeffec7d0864eb8855fe8e873743();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderDetailForUpdate", "9bca7766-b995-4768-a07f-5f4302e4e5e7.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderDetailForUpdate", "9bca7766-b995-4768-a07f-5f4302e4e5e7.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrderId, "orderid") ?? "orderid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsApprovalFromUserArea, "isapprovalfromuserarea") ?? "isapprovalfromuserarea", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectAssetServiceId, "projectassetserviceid") ?? "projectassetserviceid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectAssetService, "projectassetservice") ?? "projectassetservice", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectDescription, "projectdescription") ?? "projectdescription", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@BusinessValueCategoryId, "businessvaluecategoryid") ?? "businessvaluecategoryid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@BusinessValueSubcategoryId, "businessvaluesubcategoryid") ?? "businessvaluesubcategoryid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@NegotiatedExchangeRate, "negotiatedexchangerate") ?? "negotiatedexchangerate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractStatus, "contractstatus") ?? "contractstatus", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@DateOfCommitment, "dateofcommitment") ?? "dateofcommitment", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasDeposit, "hasdeposit") ?? "hasdeposit", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasInsurance, "hasinsurance") ?? "hasinsurance", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@DistributionId, "distributionid") ?? "distributionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasAdvancePayment, "hasadvancepayment") ?? "hasadvancepayment", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@RetentionRate, "retentionrate") ?? "retentionrate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasBaseDate, "hasbasedate") ?? "hasbasedate", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@StartBaseDate, "startbasedate") ?? "startbasedate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@EndBaseDate, "endbasedate") ?? "endbasedate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractNumber, "contractnumber") ?? "contractnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsRetentionApplied, "isretentionapplied") ?? "isretentionapplied", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@Frequency, "frequency") ?? "frequency", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@Period, "period") ?? "period", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrderRetentionTypeId, "orderretentiontypeid") ?? "orderretentiontypeid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentOptionsId, "paymentoptionsid") ?? "paymentoptionsid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentWaysId, "paymentwaysid") ?? "paymentwaysid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrdersContract, "orderscontract") ?? "orderscontract", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractAmount, "contractamount") ?? "contractamount", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractTarif, "contracttarif") ?? "contracttarif", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractSupplier, "contractsupplier") ?? "contractsupplier", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsDependentFromFolios, "isdependentfromfolios") ?? "isdependentfromfolios", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@SpecialApprovalId, "specialapprovalid") ?? "specialapprovalid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@AllContactFilesValidated, "allcontactfilesvalidated") ?? "allcontactfilesvalidated", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasntRequestDocuments, "hasntrequestdocuments") ?? "hasntrequestdocuments", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
" FROM " + ENOrderDetailEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderDetailForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(39,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderDetailEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateOrderDetail
/// </summary>

public static async Task UpdateOrderDetail(IRequestContext requestContext,BitArray usedFields,RC_7f0ffeffec7d0864eb8855fe8e873743 inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateOrderDetail", "9bca7766-b995-4768-a07f-5f4302e4e5e7.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateOrderDetail", "9bca7766-b995-4768-a07f-5f4302e4e5e7.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_26f696e758428762fc617e811634d15dEntityRecord ssENOrderDetail = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(39,true);
}
string updateSet = "UPDATE " + ENOrderDetailEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsApprovalFromUserArea, "isapprovalfromuserarea") ?? "isapprovalfromuserarea") + " = @ssIsApprovalFromUserArea"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectAssetServiceId, "projectassetserviceid") ?? "projectassetserviceid") + " = @ssProjectAssetServiceId"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectAssetService, "projectassetservice") ?? "projectassetservice") + " = @ssProjectAssetService"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ProjectDescription, "projectdescription") ?? "projectdescription") + " = @ssProjectDescription"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@BusinessValueCategoryId, "businessvaluecategoryid") ?? "businessvaluecategoryid") + " = @ssBusinessValueCategoryId"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@BusinessValueSubcategoryId, "businessvaluesubcategoryid") ?? "businessvaluesubcategoryid") + " = @ssBusinessValueSubcategoryId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentTermsId, "paymenttermsid") ?? "paymenttermsid") + " = @ssPaymentTermsId"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentMethodId, "paymentmethodid") ?? "paymentmethodid") + " = @ssPaymentMethodId"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@NegotiatedExchangeRate, "negotiatedexchangerate") ?? "negotiatedexchangerate") + " = @ssNegotiatedExchangeRate"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractStatus, "contractstatus") ?? "contractstatus") + " = @ssContractStatus"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@DateOfCommitment, "dateofcommitment") ?? "dateofcommitment") + " = @ssDateOfCommitment"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasDeposit, "hasdeposit") ?? "hasdeposit") + " = @ssHasDeposit"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasInsurance, "hasinsurance") ?? "hasinsurance") + " = @ssHasInsurance"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@DistributionId, "distributionid") ?? "distributionid") + " = @ssDistributionId"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasAdvancePayment, "hasadvancepayment") ?? "hasadvancepayment") + " = @ssHasAdvancePayment"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@RetentionRate, "retentionrate") ?? "retentionrate") + " = @ssRetentionRate"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasBaseDate, "hasbasedate") ?? "hasbasedate") + " = @ssHasBaseDate"): parameters);
parameters = (usedFields[18] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@StartBaseDate, "startbasedate") ?? "startbasedate") + " = @ssStartBaseDate"): parameters);
parameters = (usedFields[19] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@EndBaseDate, "endbasedate") ?? "endbasedate") + " = @ssEndBaseDate"): parameters);
parameters = (usedFields[20] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractNumber, "contractnumber") ?? "contractnumber") + " = @ssContractNumber"): parameters);
parameters = (usedFields[21] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsRetentionApplied, "isretentionapplied") ?? "isretentionapplied") + " = @ssIsRetentionApplied"): parameters);
parameters = (usedFields[22] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@Frequency, "frequency") ?? "frequency") + " = @ssFrequency"): parameters);
parameters = (usedFields[23] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@Period, "period") ?? "period") + " = @ssPeriod"): parameters);
parameters = (usedFields[24] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrderRetentionTypeId, "orderretentiontypeid") ?? "orderretentiontypeid") + " = @ssOrderRetentionTypeId"): parameters);
parameters = (usedFields[25] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentOptionsId, "paymentoptionsid") ?? "paymentoptionsid") + " = @ssPaymentOptionsId"): parameters);
parameters = (usedFields[26] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@PaymentWaysId, "paymentwaysid") ?? "paymentwaysid") + " = @ssPaymentWaysId"): parameters);
parameters = (usedFields[27] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrdersContract, "orderscontract") ?? "orderscontract") + " = @ssOrdersContract"): parameters);
parameters = (usedFields[28] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractAmount, "contractamount") ?? "contractamount") + " = @ssContractAmount"): parameters);
parameters = (usedFields[29] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractTarif, "contracttarif") ?? "contracttarif") + " = @ssContractTarif"): parameters);
parameters = (usedFields[30] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@ContractSupplier, "contractsupplier") ?? "contractsupplier") + " = @ssContractSupplier"): parameters);
parameters = (usedFields[31] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsDependentFromFolios, "isdependentfromfolios") ?? "isdependentfromfolios") + " = @ssIsDependentFromFolios"): parameters);
parameters = (usedFields[32] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@SpecialApprovalId, "specialapprovalid") ?? "specialapprovalid") + " = @ssSpecialApprovalId"): parameters);
parameters = (usedFields[33] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[34] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[35] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + " = @ssUpdatedBy"): parameters);
parameters = (usedFields[36] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = @ssUpdatedOn"): parameters);
parameters = (usedFields[37] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@AllContactFilesValidated, "allcontactfilesvalidated") ?? "allcontactfilesvalidated") + " = @ssAllContactFilesValidated"): parameters);
parameters = (usedFields[38] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@HasntRequestDocuments, "hasntrequestdocuments") ?? "hasntrequestdocuments") + " = @ssHasntRequestDocuments"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@OrderId, "orderid") ?? "orderid") + " = @idparam_ssENOrderDetail_ssOrderId_OrderDetail";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsApprovalFromUserArea, "isapprovalfromuserarea") ?? "isapprovalfromuserarea") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderDetail, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderDetailAttributeKeys.@IsApprovalFromUserArea, "isapprovalfromuserarea") ?? "isapprovalfromuserarea") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
sqlCmd.CreateParameter("@ssIsApprovalFromUserArea", DbType.Boolean, ssENOrderDetail.ssIsApprovalFromUserArea);
}
if(usedFields[2]) {
if ((ssENOrderDetail.ssProjectAssetServiceId==0L)) {
sqlCmd.CreateParameter("@ssProjectAssetServiceId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssProjectAssetServiceId", DbType.Int64, ssENOrderDetail.ssProjectAssetServiceId);

}
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssProjectAssetService", DbType.String, ssENOrderDetail.ssProjectAssetService);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssProjectDescription", DbType.String, ssENOrderDetail.ssProjectDescription);
}
if(usedFields[5]) {
if ((ssENOrderDetail.ssBusinessValueCategoryId==0L)) {
sqlCmd.CreateParameter("@ssBusinessValueCategoryId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssBusinessValueCategoryId", DbType.Int64, ssENOrderDetail.ssBusinessValueCategoryId);

}
}
if(usedFields[6]) {
if ((ssENOrderDetail.ssBusinessValueSubcategoryId==0L)) {
sqlCmd.CreateParameter("@ssBusinessValueSubcategoryId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssBusinessValueSubcategoryId", DbType.Int64, ssENOrderDetail.ssBusinessValueSubcategoryId);

}
}
if(usedFields[7]) {
if ((ssENOrderDetail.ssPaymentTermsId==0L)) {
sqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentTermsId", DbType.Int64, ssENOrderDetail.ssPaymentTermsId);

}
}
if(usedFields[8]) {
if ((ssENOrderDetail.ssPaymentMethodId==0L)) {
sqlCmd.CreateParameter("@ssPaymentMethodId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentMethodId", DbType.Int64, ssENOrderDetail.ssPaymentMethodId);

}
}
if(usedFields[9]) {
var NegotiatedExchangeRateParameter = sqlCmd.CreateParameter("@ssNegotiatedExchangeRate", DbType.Decimal, ssENOrderDetail.ssNegotiatedExchangeRate);
{
    string decimalAsStr = ssENOrderDetail.ssNegotiatedExchangeRate.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {NegotiatedExchangeRateParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[10]) {
if ((ssENOrderDetail.ssContractStatus==0)) {
sqlCmd.CreateParameter("@ssContractStatus", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssContractStatus", DbType.Int32, ssENOrderDetail.ssContractStatus);

}
}
if(usedFields[11]) {
sqlCmd.CreateParameter("@ssDateOfCommitment", DbType.DateTime, ssENOrderDetail.ssDateOfCommitment);
}
if(usedFields[12]) {
sqlCmd.CreateParameter("@ssHasDeposit", DbType.Boolean, ssENOrderDetail.ssHasDeposit);
}
if(usedFields[13]) {
sqlCmd.CreateParameter("@ssHasInsurance", DbType.Boolean, ssENOrderDetail.ssHasInsurance);
}
if(usedFields[14]) {
if ((ssENOrderDetail.ssDistributionId==0)) {
sqlCmd.CreateParameter("@ssDistributionId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssDistributionId", DbType.Int32, ssENOrderDetail.ssDistributionId);

}
}
if(usedFields[15]) {
sqlCmd.CreateParameter("@ssHasAdvancePayment", DbType.Boolean, ssENOrderDetail.ssHasAdvancePayment);
}
if(usedFields[16]) {
var RetentionRateParameter = sqlCmd.CreateParameter("@ssRetentionRate", DbType.Decimal, ssENOrderDetail.ssRetentionRate);
{
    string decimalAsStr = ssENOrderDetail.ssRetentionRate.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {RetentionRateParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[17]) {
sqlCmd.CreateParameter("@ssHasBaseDate", DbType.Boolean, ssENOrderDetail.ssHasBaseDate);
}
if(usedFields[18]) {
sqlCmd.CreateParameter("@ssStartBaseDate", DbType.DateTime, ssENOrderDetail.ssStartBaseDate);
}
if(usedFields[19]) {
sqlCmd.CreateParameter("@ssEndBaseDate", DbType.DateTime, ssENOrderDetail.ssEndBaseDate);
}
if(usedFields[20]) {
sqlCmd.CreateParameter("@ssContractNumber", DbType.String, ssENOrderDetail.ssContractNumber);
}
if(usedFields[21]) {
sqlCmd.CreateParameter("@ssIsRetentionApplied", DbType.Boolean, ssENOrderDetail.ssIsRetentionApplied);
}
if(usedFields[22]) {
if ((ssENOrderDetail.ssFrequency==0)) {
sqlCmd.CreateParameter("@ssFrequency", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssFrequency", DbType.Int32, ssENOrderDetail.ssFrequency);

}
}
if(usedFields[23]) {
sqlCmd.CreateParameter("@ssPeriod", DbType.String, ssENOrderDetail.ssPeriod);
}
if(usedFields[24]) {
if ((ssENOrderDetail.ssOrderRetentionTypeId==0)) {
sqlCmd.CreateParameter("@ssOrderRetentionTypeId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderRetentionTypeId", DbType.Int32, ssENOrderDetail.ssOrderRetentionTypeId);

}
}
if(usedFields[25]) {
if ((ssENOrderDetail.ssPaymentOptionsId==0L)) {
sqlCmd.CreateParameter("@ssPaymentOptionsId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentOptionsId", DbType.Int64, ssENOrderDetail.ssPaymentOptionsId);

}
}
if(usedFields[26]) {
if ((ssENOrderDetail.ssPaymentWaysId==0L)) {
sqlCmd.CreateParameter("@ssPaymentWaysId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssPaymentWaysId", DbType.Int64, ssENOrderDetail.ssPaymentWaysId);

}
}
if(usedFields[27]) {
sqlCmd.CreateParameter("@ssOrdersContract", DbType.String, ssENOrderDetail.ssOrdersContract);
}
if(usedFields[28]) {
var ContractAmountParameter = sqlCmd.CreateParameter("@ssContractAmount", DbType.Decimal, ssENOrderDetail.ssContractAmount);
{
    string decimalAsStr = ssENOrderDetail.ssContractAmount.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ContractAmountParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[29]) {
var ContractTarifParameter = sqlCmd.CreateParameter("@ssContractTarif", DbType.Decimal, ssENOrderDetail.ssContractTarif);
{
    string decimalAsStr = ssENOrderDetail.ssContractTarif.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ContractTarifParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[30]) {
if ((ssENOrderDetail.ssContractSupplier==0L)) {
sqlCmd.CreateParameter("@ssContractSupplier", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssContractSupplier", DbType.Int64, ssENOrderDetail.ssContractSupplier);

}
}
if(usedFields[31]) {
sqlCmd.CreateParameter("@ssIsDependentFromFolios", DbType.Boolean, ssENOrderDetail.ssIsDependentFromFolios);
}
if(usedFields[32]) {
if ((ssENOrderDetail.ssSpecialApprovalId==0)) {
sqlCmd.CreateParameter("@ssSpecialApprovalId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssSpecialApprovalId", DbType.Int32, ssENOrderDetail.ssSpecialApprovalId);

}
}
if(usedFields[33]) {
if ((ssENOrderDetail.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderDetail.ssCreatedBy);

}
}
if(usedFields[34]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderDetail.ssCreatedOn);
}
if(usedFields[35]) {
if ((ssENOrderDetail.ssUpdatedBy=="")) {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENOrderDetail.ssUpdatedBy);

}
}
if(usedFields[36]) {
sqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENOrderDetail.ssUpdatedOn);
}
if(usedFields[37]) {
sqlCmd.CreateParameter("@ssAllContactFilesValidated", DbType.Boolean, ssENOrderDetail.ssAllContactFilesValidated);
}
if(usedFields[38]) {
sqlCmd.CreateParameter("@ssHasntRequestDocuments", DbType.Boolean, ssENOrderDetail.ssHasntRequestDocuments);
}
sqlCmd.CreateParameter("@idparam_ssENOrderDetail_ssOrderId_OrderDetail", DbType.Int64, ssENOrderDetail.ssOrderId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateOrderDetail", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("OrderDetail", ssENOrderDetail.ssOrderId.ToString()); }}
}
return;
}

}
}
