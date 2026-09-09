using System.Diagnostics;
namespace ssConectaProveedores {
public partial class ExtendedActions {
/// <summary>
/// Action: CreateOrderMainItem
/// </summary>

public static async Task<long> CreateOrderMainItem(IRequestContext requestContext,RC_c4cc207f9017de4e013fabcf1e8ebeaf inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrderMainItem", "176ce248-4371-426c-bbd5-10d39536ee69.#CreateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrderMainItem", "176ce248-4371-426c-bbd5-10d39536ee69.#CreateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord ssENOrderMainItem = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string insertSql =
"INSERT INTO " + ENOrderMainItemEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Position, "position") ?? "position") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialCode, "materialcode") ?? "materialcode") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialDescription, "materialdescription") ?? "materialdescription") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@AssigmnentCode, "assigmnentcode") ?? "assigmnentcode") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DocumentClassId, "documentclassid") ?? "documentclassid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DeliveryDate, "deliverydate") ?? "deliverydate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Quantity, "quantity") ?? "quantity") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UnitType, "unittype") ?? "unittype") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UnitPrice, "unitprice") ?? "unitprice") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@BaseQuantity, "basequantity") ?? "basequantity") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsBlocked, "isblocked") ?? "isblocked") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsFinalDelivery, "isfinaldelivery") ?? "isfinaldelivery") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@GLAccountId, "glaccountid") ?? "glaccountid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@FundsCenter, "fundscenter") ?? "fundscenter") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Fund, "fund") ?? "fund") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CommitmentItem, "commitmentitem") ?? "commitmentitem") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATIndicator, "vatindicator") ?? "vatindicator") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATProcedure, "vatprocedure") ?? "vatprocedure") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATRate, "vatrate") ?? "vatrate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PurchaseRequisitionNumber, "purchaserequisitionnumber") ?? "purchaserequisitionnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PurchaseRequisitionItemNr, "purchaserequisitionitemnr") ?? "purchaserequisitionitemnr") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@RegionId, "regionid") ?? "regionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Center, "center") ?? "center") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PEPElement, "pepelement") ?? "pepelement") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@QuantityDelivered, "quantitydelivered") ?? "quantitydelivered") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderUnitOfMeasure, "orderunitofmeasure") ?? "orderunitofmeasure") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Applicant, "applicant") ?? "applicant") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Direction, "direction") ?? "direction") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractNumber, "contractnumber") ?? "contractnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractPosition, "contractposition") ?? "contractposition") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractStartDate, "contractstartdate") ?? "contractstartdate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractEndDate, "contractenddate") ?? "contractenddate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractPlannedValue, "contractplannedvalue") ?? "contractplannedvalue") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PositionType, "positiontype") ?? "positiontype") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@SerialNumberProfile, "serialnumberprofile") ?? "serialnumberprofile") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@BatchManaged, "batchmanaged") ?? "batchmanaged") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialType, "materialtype") ?? "materialtype") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ItemGroup, "itemgroup") ?? "itemgroup") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderRequestCreatorSAPNumber, "orderrequestcreatorsapnumber") ?? "orderrequestcreatorsapnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsMultipleImputation, "ismultipleimputation") ?? "ismultipleimputation") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderMainItemStatusId, "ordermainitemstatusid") ?? "ordermainitemstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DivisionId, "divisionid") ?? "divisionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + "" +
" ) VALUES (" +
" @ssOrderMainId" +
", @ssPosition" +
", @ssMaterialCode" +
", @ssMaterialDescription" +
", @ssAssigmnentCode" +
", @ssDocumentClassId" +
", @ssDeliveryDate" +
", @ssQuantity" +
", @ssUnitType" +
", @ssUnitPrice" +
", @ssBaseQuantity" +
", @ssIsDeleted" +
", @ssIsBlocked" +
", @ssIsFinalDelivery" +
", @ssGLAccountId" +
", @ssCostCenterId" +
", @ssFundsCenter" +
", @ssFund" +
", @ssCommitmentItem" +
", @ssVATIndicator" +
", @ssVATProcedure" +
", @ssVATRate" +
", @ssPurchaseRequisitionNumber" +
", @ssPurchaseRequisitionItemNr" +
", @ssRegionId" +
", @ssCenter" +
", @ssPEPElement" +
", @ssQuantityDelivered" +
", @ssOrderUnitOfMeasure" +
", @ssApplicant" +
", @ssDirection" +
", @ssContractNumber" +
", @ssContractPosition" +
", @ssContractStartDate" +
", @ssContractEndDate" +
", @ssContractPlannedValue" +
", @ssPositionType" +
", @ssSerialNumberProfile" +
", @ssBatchManaged" +
", @ssMaterialType" +
", @ssItemGroup" +
", @ssOrderRequestCreatorSAPNumber" +
", @ssIsMultipleImputation" +
", @ssInvoiceUsageId" +
", @ssOrderMainItemStatusId" +
", @ssDivisionId" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssUpdatedBy" +
", @ssUpdatedOn" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderMainItem.ssOrderMainId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderMainId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderMainId", DbType.Int64, ssENOrderMainItem.ssOrderMainId);

}
insertSqlCmd.CreateParameter("@ssPosition", DbType.Int32, ssENOrderMainItem.ssPosition);
insertSqlCmd.CreateParameter("@ssMaterialCode", DbType.String, ssENOrderMainItem.ssMaterialCode);
insertSqlCmd.CreateParameter("@ssMaterialDescription", DbType.String, ssENOrderMainItem.ssMaterialDescription);
insertSqlCmd.CreateParameter("@ssAssigmnentCode", DbType.String, ssENOrderMainItem.ssAssigmnentCode);
if ((ssENOrderMainItem.ssDocumentClassId==0L)) {
insertSqlCmd.CreateParameter("@ssDocumentClassId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssDocumentClassId", DbType.Int64, ssENOrderMainItem.ssDocumentClassId);

}
insertSqlCmd.CreateParameter("@ssDeliveryDate", DbType.DateTime, ssENOrderMainItem.ssDeliveryDate);
var QuantityParameter = insertSqlCmd.CreateParameter("@ssQuantity", DbType.Decimal, ssENOrderMainItem.ssQuantity);
{
    string decimalAsStr = ssENOrderMainItem.ssQuantity.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {QuantityParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssUnitType", DbType.String, ssENOrderMainItem.ssUnitType);
var UnitPriceParameter = insertSqlCmd.CreateParameter("@ssUnitPrice", DbType.Decimal, ssENOrderMainItem.ssUnitPrice);
{
    string decimalAsStr = ssENOrderMainItem.ssUnitPrice.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {UnitPriceParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssBaseQuantity", DbType.Int32, ssENOrderMainItem.ssBaseQuantity);
insertSqlCmd.CreateParameter("@ssIsDeleted", DbType.Boolean, ssENOrderMainItem.ssIsDeleted);
insertSqlCmd.CreateParameter("@ssIsBlocked", DbType.Boolean, ssENOrderMainItem.ssIsBlocked);
insertSqlCmd.CreateParameter("@ssIsFinalDelivery", DbType.Boolean, ssENOrderMainItem.ssIsFinalDelivery);
if ((ssENOrderMainItem.ssGLAccountId==0L)) {
insertSqlCmd.CreateParameter("@ssGLAccountId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssGLAccountId", DbType.Int64, ssENOrderMainItem.ssGLAccountId);

}
if ((ssENOrderMainItem.ssCostCenterId==0L)) {
insertSqlCmd.CreateParameter("@ssCostCenterId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCostCenterId", DbType.Int64, ssENOrderMainItem.ssCostCenterId);

}
insertSqlCmd.CreateParameter("@ssFundsCenter", DbType.String, ssENOrderMainItem.ssFundsCenter);
insertSqlCmd.CreateParameter("@ssFund", DbType.String, ssENOrderMainItem.ssFund);
insertSqlCmd.CreateParameter("@ssCommitmentItem", DbType.String, ssENOrderMainItem.ssCommitmentItem);
insertSqlCmd.CreateParameter("@ssVATIndicator", DbType.String, ssENOrderMainItem.ssVATIndicator);
insertSqlCmd.CreateParameter("@ssVATProcedure", DbType.String, ssENOrderMainItem.ssVATProcedure);
var VATRateParameter = insertSqlCmd.CreateParameter("@ssVATRate", DbType.Decimal, ssENOrderMainItem.ssVATRate);
{
    string decimalAsStr = ssENOrderMainItem.ssVATRate.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {VATRateParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssPurchaseRequisitionNumber", DbType.String, ssENOrderMainItem.ssPurchaseRequisitionNumber);
insertSqlCmd.CreateParameter("@ssPurchaseRequisitionItemNr", DbType.Int32, ssENOrderMainItem.ssPurchaseRequisitionItemNr);
if ((ssENOrderMainItem.ssRegionId==0L)) {
insertSqlCmd.CreateParameter("@ssRegionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRegionId", DbType.Int64, ssENOrderMainItem.ssRegionId);

}
insertSqlCmd.CreateParameter("@ssCenter", DbType.String, ssENOrderMainItem.ssCenter);
insertSqlCmd.CreateParameter("@ssPEPElement", DbType.String, ssENOrderMainItem.ssPEPElement);
var QuantityDeliveredParameter = insertSqlCmd.CreateParameter("@ssQuantityDelivered", DbType.Decimal, ssENOrderMainItem.ssQuantityDelivered);
{
    string decimalAsStr = ssENOrderMainItem.ssQuantityDelivered.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {QuantityDeliveredParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssOrderUnitOfMeasure", DbType.String, ssENOrderMainItem.ssOrderUnitOfMeasure);
insertSqlCmd.CreateParameter("@ssApplicant", DbType.String, ssENOrderMainItem.ssApplicant);
insertSqlCmd.CreateParameter("@ssDirection", DbType.String, ssENOrderMainItem.ssDirection);
insertSqlCmd.CreateParameter("@ssContractNumber", DbType.String, ssENOrderMainItem.ssContractNumber);
insertSqlCmd.CreateParameter("@ssContractPosition", DbType.Int32, ssENOrderMainItem.ssContractPosition);
insertSqlCmd.CreateParameter("@ssContractStartDate", DbType.DateTime, ssENOrderMainItem.ssContractStartDate);
insertSqlCmd.CreateParameter("@ssContractEndDate", DbType.DateTime, ssENOrderMainItem.ssContractEndDate);
var ContractPlannedValueParameter = insertSqlCmd.CreateParameter("@ssContractPlannedValue", DbType.Decimal, ssENOrderMainItem.ssContractPlannedValue);
{
    string decimalAsStr = ssENOrderMainItem.ssContractPlannedValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ContractPlannedValueParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssPositionType", DbType.String, ssENOrderMainItem.ssPositionType);
insertSqlCmd.CreateParameter("@ssSerialNumberProfile", DbType.String, ssENOrderMainItem.ssSerialNumberProfile);
insertSqlCmd.CreateParameter("@ssBatchManaged", DbType.String, ssENOrderMainItem.ssBatchManaged);
insertSqlCmd.CreateParameter("@ssMaterialType", DbType.String, ssENOrderMainItem.ssMaterialType);
insertSqlCmd.CreateParameter("@ssItemGroup", DbType.String, ssENOrderMainItem.ssItemGroup);
insertSqlCmd.CreateParameter("@ssOrderRequestCreatorSAPNumber", DbType.String, ssENOrderMainItem.ssOrderRequestCreatorSAPNumber);
insertSqlCmd.CreateParameter("@ssIsMultipleImputation", DbType.Boolean, ssENOrderMainItem.ssIsMultipleImputation);
if ((ssENOrderMainItem.ssInvoiceUsageId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceUsageId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceUsageId", DbType.Int64, ssENOrderMainItem.ssInvoiceUsageId);

}
if ((ssENOrderMainItem.ssOrderMainItemStatusId==0)) {
insertSqlCmd.CreateParameter("@ssOrderMainItemStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderMainItemStatusId", DbType.Int32, ssENOrderMainItem.ssOrderMainItemStatusId);

}
if ((ssENOrderMainItem.ssDivisionId==0L)) {
insertSqlCmd.CreateParameter("@ssDivisionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssDivisionId", DbType.Int64, ssENOrderMainItem.ssDivisionId);

}
if ((ssENOrderMainItem.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderMainItem.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderMainItem.ssCreatedOn);
if ((ssENOrderMainItem.ssUpdatedBy=="")) {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENOrderMainItem.ssUpdatedBy);

}
insertSqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENOrderMainItem.ssUpdatedOn);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrderMainItem", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateOrderMainItem
/// </summary>

public static async Task<long> CreateOrUpdateOrderMainItem(IRequestContext requestContext,BitArray usedFields,RC_c4cc207f9017de4e013fabcf1e8ebeaf inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateOrderMainItem", "176ce248-4371-426c-bbd5-10d39536ee69.#CreateOrUpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateOrderMainItem", "176ce248-4371-426c-bbd5-10d39536ee69.#CreateOrUpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord ssENOrderMainItem = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(51,true);
}
string updateSet = "UPDATE " + ENOrderMainItemEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid") + " = @ssOrderMainId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Position, "position") ?? "position") + " = @ssPosition"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialCode, "materialcode") ?? "materialcode") + " = @ssMaterialCode"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialDescription, "materialdescription") ?? "materialdescription") + " = @ssMaterialDescription"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@AssigmnentCode, "assigmnentcode") ?? "assigmnentcode") + " = @ssAssigmnentCode"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DocumentClassId, "documentclassid") ?? "documentclassid") + " = @ssDocumentClassId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DeliveryDate, "deliverydate") ?? "deliverydate") + " = @ssDeliveryDate"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Quantity, "quantity") ?? "quantity") + " = @ssQuantity"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UnitType, "unittype") ?? "unittype") + " = @ssUnitType"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UnitPrice, "unitprice") ?? "unitprice") + " = @ssUnitPrice"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@BaseQuantity, "basequantity") ?? "basequantity") + " = @ssBaseQuantity"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted") + " = @ssIsDeleted"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsBlocked, "isblocked") ?? "isblocked") + " = @ssIsBlocked"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsFinalDelivery, "isfinaldelivery") ?? "isfinaldelivery") + " = @ssIsFinalDelivery"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@GLAccountId, "glaccountid") ?? "glaccountid") + " = @ssGLAccountId"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid") + " = @ssCostCenterId"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@FundsCenter, "fundscenter") ?? "fundscenter") + " = @ssFundsCenter"): parameters);
parameters = (usedFields[18] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Fund, "fund") ?? "fund") + " = @ssFund"): parameters);
parameters = (usedFields[19] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CommitmentItem, "commitmentitem") ?? "commitmentitem") + " = @ssCommitmentItem"): parameters);
parameters = (usedFields[20] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATIndicator, "vatindicator") ?? "vatindicator") + " = @ssVATIndicator"): parameters);
parameters = (usedFields[21] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATProcedure, "vatprocedure") ?? "vatprocedure") + " = @ssVATProcedure"): parameters);
parameters = (usedFields[22] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATRate, "vatrate") ?? "vatrate") + " = @ssVATRate"): parameters);
parameters = (usedFields[23] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PurchaseRequisitionNumber, "purchaserequisitionnumber") ?? "purchaserequisitionnumber") + " = @ssPurchaseRequisitionNumber"): parameters);
parameters = (usedFields[24] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PurchaseRequisitionItemNr, "purchaserequisitionitemnr") ?? "purchaserequisitionitemnr") + " = @ssPurchaseRequisitionItemNr"): parameters);
parameters = (usedFields[25] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@RegionId, "regionid") ?? "regionid") + " = @ssRegionId"): parameters);
parameters = (usedFields[26] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Center, "center") ?? "center") + " = @ssCenter"): parameters);
parameters = (usedFields[27] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PEPElement, "pepelement") ?? "pepelement") + " = @ssPEPElement"): parameters);
parameters = (usedFields[28] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@QuantityDelivered, "quantitydelivered") ?? "quantitydelivered") + " = @ssQuantityDelivered"): parameters);
parameters = (usedFields[29] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderUnitOfMeasure, "orderunitofmeasure") ?? "orderunitofmeasure") + " = @ssOrderUnitOfMeasure"): parameters);
parameters = (usedFields[30] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Applicant, "applicant") ?? "applicant") + " = @ssApplicant"): parameters);
parameters = (usedFields[31] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Direction, "direction") ?? "direction") + " = @ssDirection"): parameters);
parameters = (usedFields[32] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractNumber, "contractnumber") ?? "contractnumber") + " = @ssContractNumber"): parameters);
parameters = (usedFields[33] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractPosition, "contractposition") ?? "contractposition") + " = @ssContractPosition"): parameters);
parameters = (usedFields[34] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractStartDate, "contractstartdate") ?? "contractstartdate") + " = @ssContractStartDate"): parameters);
parameters = (usedFields[35] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractEndDate, "contractenddate") ?? "contractenddate") + " = @ssContractEndDate"): parameters);
parameters = (usedFields[36] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractPlannedValue, "contractplannedvalue") ?? "contractplannedvalue") + " = @ssContractPlannedValue"): parameters);
parameters = (usedFields[37] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PositionType, "positiontype") ?? "positiontype") + " = @ssPositionType"): parameters);
parameters = (usedFields[38] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@SerialNumberProfile, "serialnumberprofile") ?? "serialnumberprofile") + " = @ssSerialNumberProfile"): parameters);
parameters = (usedFields[39] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@BatchManaged, "batchmanaged") ?? "batchmanaged") + " = @ssBatchManaged"): parameters);
parameters = (usedFields[40] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialType, "materialtype") ?? "materialtype") + " = @ssMaterialType"): parameters);
parameters = (usedFields[41] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ItemGroup, "itemgroup") ?? "itemgroup") + " = @ssItemGroup"): parameters);
parameters = (usedFields[42] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderRequestCreatorSAPNumber, "orderrequestcreatorsapnumber") ?? "orderrequestcreatorsapnumber") + " = @ssOrderRequestCreatorSAPNumber"): parameters);
parameters = (usedFields[43] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsMultipleImputation, "ismultipleimputation") ?? "ismultipleimputation") + " = @ssIsMultipleImputation"): parameters);
parameters = (usedFields[44] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid") + " = @ssInvoiceUsageId"): parameters);
parameters = (usedFields[45] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderMainItemStatusId, "ordermainitemstatusid") ?? "ordermainitemstatusid") + " = @ssOrderMainItemStatusId"): parameters);
parameters = (usedFields[46] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DivisionId, "divisionid") ?? "divisionid") + " = @ssDivisionId"): parameters);
parameters = (usedFields[47] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[48] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[49] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + " = @ssUpdatedBy"): parameters);
parameters = (usedFields[50] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = @ssUpdatedOn"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderMainItem_ssId_OrderMainItem";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderMainItem.ssOrderMainId==0L)) {
sqlCmd.CreateParameter("@ssOrderMainId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderMainId", DbType.Int64, ssENOrderMainItem.ssOrderMainId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssPosition", DbType.Int32, ssENOrderMainItem.ssPosition);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssMaterialCode", DbType.String, ssENOrderMainItem.ssMaterialCode);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssMaterialDescription", DbType.String, ssENOrderMainItem.ssMaterialDescription);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssAssigmnentCode", DbType.String, ssENOrderMainItem.ssAssigmnentCode);
}
if(usedFields[6]) {
if ((ssENOrderMainItem.ssDocumentClassId==0L)) {
sqlCmd.CreateParameter("@ssDocumentClassId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssDocumentClassId", DbType.Int64, ssENOrderMainItem.ssDocumentClassId);

}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssDeliveryDate", DbType.DateTime, ssENOrderMainItem.ssDeliveryDate);
}
if(usedFields[8]) {
var QuantityParameter = sqlCmd.CreateParameter("@ssQuantity", DbType.Decimal, ssENOrderMainItem.ssQuantity);
{
    string decimalAsStr = ssENOrderMainItem.ssQuantity.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {QuantityParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssUnitType", DbType.String, ssENOrderMainItem.ssUnitType);
}
if(usedFields[10]) {
var UnitPriceParameter = sqlCmd.CreateParameter("@ssUnitPrice", DbType.Decimal, ssENOrderMainItem.ssUnitPrice);
{
    string decimalAsStr = ssENOrderMainItem.ssUnitPrice.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {UnitPriceParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[11]) {
sqlCmd.CreateParameter("@ssBaseQuantity", DbType.Int32, ssENOrderMainItem.ssBaseQuantity);
}
if(usedFields[12]) {
sqlCmd.CreateParameter("@ssIsDeleted", DbType.Boolean, ssENOrderMainItem.ssIsDeleted);
}
if(usedFields[13]) {
sqlCmd.CreateParameter("@ssIsBlocked", DbType.Boolean, ssENOrderMainItem.ssIsBlocked);
}
if(usedFields[14]) {
sqlCmd.CreateParameter("@ssIsFinalDelivery", DbType.Boolean, ssENOrderMainItem.ssIsFinalDelivery);
}
if(usedFields[15]) {
if ((ssENOrderMainItem.ssGLAccountId==0L)) {
sqlCmd.CreateParameter("@ssGLAccountId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssGLAccountId", DbType.Int64, ssENOrderMainItem.ssGLAccountId);

}
}
if(usedFields[16]) {
if ((ssENOrderMainItem.ssCostCenterId==0L)) {
sqlCmd.CreateParameter("@ssCostCenterId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCostCenterId", DbType.Int64, ssENOrderMainItem.ssCostCenterId);

}
}
if(usedFields[17]) {
sqlCmd.CreateParameter("@ssFundsCenter", DbType.String, ssENOrderMainItem.ssFundsCenter);
}
if(usedFields[18]) {
sqlCmd.CreateParameter("@ssFund", DbType.String, ssENOrderMainItem.ssFund);
}
if(usedFields[19]) {
sqlCmd.CreateParameter("@ssCommitmentItem", DbType.String, ssENOrderMainItem.ssCommitmentItem);
}
if(usedFields[20]) {
sqlCmd.CreateParameter("@ssVATIndicator", DbType.String, ssENOrderMainItem.ssVATIndicator);
}
if(usedFields[21]) {
sqlCmd.CreateParameter("@ssVATProcedure", DbType.String, ssENOrderMainItem.ssVATProcedure);
}
if(usedFields[22]) {
var VATRateParameter = sqlCmd.CreateParameter("@ssVATRate", DbType.Decimal, ssENOrderMainItem.ssVATRate);
{
    string decimalAsStr = ssENOrderMainItem.ssVATRate.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {VATRateParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[23]) {
sqlCmd.CreateParameter("@ssPurchaseRequisitionNumber", DbType.String, ssENOrderMainItem.ssPurchaseRequisitionNumber);
}
if(usedFields[24]) {
sqlCmd.CreateParameter("@ssPurchaseRequisitionItemNr", DbType.Int32, ssENOrderMainItem.ssPurchaseRequisitionItemNr);
}
if(usedFields[25]) {
if ((ssENOrderMainItem.ssRegionId==0L)) {
sqlCmd.CreateParameter("@ssRegionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRegionId", DbType.Int64, ssENOrderMainItem.ssRegionId);

}
}
if(usedFields[26]) {
sqlCmd.CreateParameter("@ssCenter", DbType.String, ssENOrderMainItem.ssCenter);
}
if(usedFields[27]) {
sqlCmd.CreateParameter("@ssPEPElement", DbType.String, ssENOrderMainItem.ssPEPElement);
}
if(usedFields[28]) {
var QuantityDeliveredParameter = sqlCmd.CreateParameter("@ssQuantityDelivered", DbType.Decimal, ssENOrderMainItem.ssQuantityDelivered);
{
    string decimalAsStr = ssENOrderMainItem.ssQuantityDelivered.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {QuantityDeliveredParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[29]) {
sqlCmd.CreateParameter("@ssOrderUnitOfMeasure", DbType.String, ssENOrderMainItem.ssOrderUnitOfMeasure);
}
if(usedFields[30]) {
sqlCmd.CreateParameter("@ssApplicant", DbType.String, ssENOrderMainItem.ssApplicant);
}
if(usedFields[31]) {
sqlCmd.CreateParameter("@ssDirection", DbType.String, ssENOrderMainItem.ssDirection);
}
if(usedFields[32]) {
sqlCmd.CreateParameter("@ssContractNumber", DbType.String, ssENOrderMainItem.ssContractNumber);
}
if(usedFields[33]) {
sqlCmd.CreateParameter("@ssContractPosition", DbType.Int32, ssENOrderMainItem.ssContractPosition);
}
if(usedFields[34]) {
sqlCmd.CreateParameter("@ssContractStartDate", DbType.DateTime, ssENOrderMainItem.ssContractStartDate);
}
if(usedFields[35]) {
sqlCmd.CreateParameter("@ssContractEndDate", DbType.DateTime, ssENOrderMainItem.ssContractEndDate);
}
if(usedFields[36]) {
var ContractPlannedValueParameter = sqlCmd.CreateParameter("@ssContractPlannedValue", DbType.Decimal, ssENOrderMainItem.ssContractPlannedValue);
{
    string decimalAsStr = ssENOrderMainItem.ssContractPlannedValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ContractPlannedValueParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[37]) {
sqlCmd.CreateParameter("@ssPositionType", DbType.String, ssENOrderMainItem.ssPositionType);
}
if(usedFields[38]) {
sqlCmd.CreateParameter("@ssSerialNumberProfile", DbType.String, ssENOrderMainItem.ssSerialNumberProfile);
}
if(usedFields[39]) {
sqlCmd.CreateParameter("@ssBatchManaged", DbType.String, ssENOrderMainItem.ssBatchManaged);
}
if(usedFields[40]) {
sqlCmd.CreateParameter("@ssMaterialType", DbType.String, ssENOrderMainItem.ssMaterialType);
}
if(usedFields[41]) {
sqlCmd.CreateParameter("@ssItemGroup", DbType.String, ssENOrderMainItem.ssItemGroup);
}
if(usedFields[42]) {
sqlCmd.CreateParameter("@ssOrderRequestCreatorSAPNumber", DbType.String, ssENOrderMainItem.ssOrderRequestCreatorSAPNumber);
}
if(usedFields[43]) {
sqlCmd.CreateParameter("@ssIsMultipleImputation", DbType.Boolean, ssENOrderMainItem.ssIsMultipleImputation);
}
if(usedFields[44]) {
if ((ssENOrderMainItem.ssInvoiceUsageId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceUsageId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceUsageId", DbType.Int64, ssENOrderMainItem.ssInvoiceUsageId);

}
}
if(usedFields[45]) {
if ((ssENOrderMainItem.ssOrderMainItemStatusId==0)) {
sqlCmd.CreateParameter("@ssOrderMainItemStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderMainItemStatusId", DbType.Int32, ssENOrderMainItem.ssOrderMainItemStatusId);

}
}
if(usedFields[46]) {
if ((ssENOrderMainItem.ssDivisionId==0L)) {
sqlCmd.CreateParameter("@ssDivisionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssDivisionId", DbType.Int64, ssENOrderMainItem.ssDivisionId);

}
}
if(usedFields[47]) {
if ((ssENOrderMainItem.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderMainItem.ssCreatedBy);

}
}
if(usedFields[48]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderMainItem.ssCreatedOn);
}
if(usedFields[49]) {
if ((ssENOrderMainItem.ssUpdatedBy=="")) {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENOrderMainItem.ssUpdatedBy);

}
}
if(usedFields[50]) {
sqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENOrderMainItem.ssUpdatedOn);
}
sqlCmd.CreateParameter("@idparam_ssENOrderMainItem_ssId_OrderMainItem", DbType.Int64, ssENOrderMainItem.ssId);
int counter = 0;
if(ssENOrderMainItem.ssId != 0L) {
counter = await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderMainItem (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
if( counter == 0) {
string insertSql =
"INSERT INTO " + ENOrderMainItemEntity.LocalViewName(null) + " (" +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Position, "position") ?? "position") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialCode, "materialcode") ?? "materialcode") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialDescription, "materialdescription") ?? "materialdescription") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@AssigmnentCode, "assigmnentcode") ?? "assigmnentcode") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DocumentClassId, "documentclassid") ?? "documentclassid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DeliveryDate, "deliverydate") ?? "deliverydate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Quantity, "quantity") ?? "quantity") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UnitType, "unittype") ?? "unittype") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UnitPrice, "unitprice") ?? "unitprice") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@BaseQuantity, "basequantity") ?? "basequantity") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsBlocked, "isblocked") ?? "isblocked") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsFinalDelivery, "isfinaldelivery") ?? "isfinaldelivery") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@GLAccountId, "glaccountid") ?? "glaccountid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@FundsCenter, "fundscenter") ?? "fundscenter") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Fund, "fund") ?? "fund") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CommitmentItem, "commitmentitem") ?? "commitmentitem") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATIndicator, "vatindicator") ?? "vatindicator") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATProcedure, "vatprocedure") ?? "vatprocedure") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATRate, "vatrate") ?? "vatrate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PurchaseRequisitionNumber, "purchaserequisitionnumber") ?? "purchaserequisitionnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PurchaseRequisitionItemNr, "purchaserequisitionitemnr") ?? "purchaserequisitionitemnr") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@RegionId, "regionid") ?? "regionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Center, "center") ?? "center") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PEPElement, "pepelement") ?? "pepelement") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@QuantityDelivered, "quantitydelivered") ?? "quantitydelivered") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderUnitOfMeasure, "orderunitofmeasure") ?? "orderunitofmeasure") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Applicant, "applicant") ?? "applicant") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Direction, "direction") ?? "direction") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractNumber, "contractnumber") ?? "contractnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractPosition, "contractposition") ?? "contractposition") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractStartDate, "contractstartdate") ?? "contractstartdate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractEndDate, "contractenddate") ?? "contractenddate") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractPlannedValue, "contractplannedvalue") ?? "contractplannedvalue") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PositionType, "positiontype") ?? "positiontype") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@SerialNumberProfile, "serialnumberprofile") ?? "serialnumberprofile") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@BatchManaged, "batchmanaged") ?? "batchmanaged") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialType, "materialtype") ?? "materialtype") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ItemGroup, "itemgroup") ?? "itemgroup") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderRequestCreatorSAPNumber, "orderrequestcreatorsapnumber") ?? "orderrequestcreatorsapnumber") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsMultipleImputation, "ismultipleimputation") ?? "ismultipleimputation") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderMainItemStatusId, "ordermainitemstatusid") ?? "ordermainitemstatusid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DivisionId, "divisionid") ?? "divisionid") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + "" +
" ) VALUES (" +
" @ssOrderMainId" +
", @ssPosition" +
", @ssMaterialCode" +
", @ssMaterialDescription" +
", @ssAssigmnentCode" +
", @ssDocumentClassId" +
", @ssDeliveryDate" +
", @ssQuantity" +
", @ssUnitType" +
", @ssUnitPrice" +
", @ssBaseQuantity" +
", @ssIsDeleted" +
", @ssIsBlocked" +
", @ssIsFinalDelivery" +
", @ssGLAccountId" +
", @ssCostCenterId" +
", @ssFundsCenter" +
", @ssFund" +
", @ssCommitmentItem" +
", @ssVATIndicator" +
", @ssVATProcedure" +
", @ssVATRate" +
", @ssPurchaseRequisitionNumber" +
", @ssPurchaseRequisitionItemNr" +
", @ssRegionId" +
", @ssCenter" +
", @ssPEPElement" +
", @ssQuantityDelivered" +
", @ssOrderUnitOfMeasure" +
", @ssApplicant" +
", @ssDirection" +
", @ssContractNumber" +
", @ssContractPosition" +
", @ssContractStartDate" +
", @ssContractEndDate" +
", @ssContractPlannedValue" +
", @ssPositionType" +
", @ssSerialNumberProfile" +
", @ssBatchManaged" +
", @ssMaterialType" +
", @ssItemGroup" +
", @ssOrderRequestCreatorSAPNumber" +
", @ssIsMultipleImputation" +
", @ssInvoiceUsageId" +
", @ssOrderMainItemStatusId" +
", @ssDivisionId" +
", @ssCreatedBy" +
", @ssCreatedOn" +
", @ssUpdatedBy" +
", @ssUpdatedOn" +
" ) RETURNING \"id\"";
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
entityActionActivity.AddSqlActivityTags(insertSqlCmd.CommandText);
if ((ssENOrderMainItem.ssOrderMainId==0L)) {
insertSqlCmd.CreateParameter("@ssOrderMainId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderMainId", DbType.Int64, ssENOrderMainItem.ssOrderMainId);

}
insertSqlCmd.CreateParameter("@ssPosition", DbType.Int32, ssENOrderMainItem.ssPosition);
insertSqlCmd.CreateParameter("@ssMaterialCode", DbType.String, ssENOrderMainItem.ssMaterialCode);
insertSqlCmd.CreateParameter("@ssMaterialDescription", DbType.String, ssENOrderMainItem.ssMaterialDescription);
insertSqlCmd.CreateParameter("@ssAssigmnentCode", DbType.String, ssENOrderMainItem.ssAssigmnentCode);
if ((ssENOrderMainItem.ssDocumentClassId==0L)) {
insertSqlCmd.CreateParameter("@ssDocumentClassId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssDocumentClassId", DbType.Int64, ssENOrderMainItem.ssDocumentClassId);

}
insertSqlCmd.CreateParameter("@ssDeliveryDate", DbType.DateTime, ssENOrderMainItem.ssDeliveryDate);
var QuantityParameter = insertSqlCmd.CreateParameter("@ssQuantity", DbType.Decimal, ssENOrderMainItem.ssQuantity);
{
    string decimalAsStr = ssENOrderMainItem.ssQuantity.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {QuantityParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssUnitType", DbType.String, ssENOrderMainItem.ssUnitType);
var UnitPriceParameter = insertSqlCmd.CreateParameter("@ssUnitPrice", DbType.Decimal, ssENOrderMainItem.ssUnitPrice);
{
    string decimalAsStr = ssENOrderMainItem.ssUnitPrice.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {UnitPriceParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssBaseQuantity", DbType.Int32, ssENOrderMainItem.ssBaseQuantity);
insertSqlCmd.CreateParameter("@ssIsDeleted", DbType.Boolean, ssENOrderMainItem.ssIsDeleted);
insertSqlCmd.CreateParameter("@ssIsBlocked", DbType.Boolean, ssENOrderMainItem.ssIsBlocked);
insertSqlCmd.CreateParameter("@ssIsFinalDelivery", DbType.Boolean, ssENOrderMainItem.ssIsFinalDelivery);
if ((ssENOrderMainItem.ssGLAccountId==0L)) {
insertSqlCmd.CreateParameter("@ssGLAccountId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssGLAccountId", DbType.Int64, ssENOrderMainItem.ssGLAccountId);

}
if ((ssENOrderMainItem.ssCostCenterId==0L)) {
insertSqlCmd.CreateParameter("@ssCostCenterId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCostCenterId", DbType.Int64, ssENOrderMainItem.ssCostCenterId);

}
insertSqlCmd.CreateParameter("@ssFundsCenter", DbType.String, ssENOrderMainItem.ssFundsCenter);
insertSqlCmd.CreateParameter("@ssFund", DbType.String, ssENOrderMainItem.ssFund);
insertSqlCmd.CreateParameter("@ssCommitmentItem", DbType.String, ssENOrderMainItem.ssCommitmentItem);
insertSqlCmd.CreateParameter("@ssVATIndicator", DbType.String, ssENOrderMainItem.ssVATIndicator);
insertSqlCmd.CreateParameter("@ssVATProcedure", DbType.String, ssENOrderMainItem.ssVATProcedure);
var VATRateParameter = insertSqlCmd.CreateParameter("@ssVATRate", DbType.Decimal, ssENOrderMainItem.ssVATRate);
{
    string decimalAsStr = ssENOrderMainItem.ssVATRate.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {VATRateParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssPurchaseRequisitionNumber", DbType.String, ssENOrderMainItem.ssPurchaseRequisitionNumber);
insertSqlCmd.CreateParameter("@ssPurchaseRequisitionItemNr", DbType.Int32, ssENOrderMainItem.ssPurchaseRequisitionItemNr);
if ((ssENOrderMainItem.ssRegionId==0L)) {
insertSqlCmd.CreateParameter("@ssRegionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssRegionId", DbType.Int64, ssENOrderMainItem.ssRegionId);

}
insertSqlCmd.CreateParameter("@ssCenter", DbType.String, ssENOrderMainItem.ssCenter);
insertSqlCmd.CreateParameter("@ssPEPElement", DbType.String, ssENOrderMainItem.ssPEPElement);
var QuantityDeliveredParameter = insertSqlCmd.CreateParameter("@ssQuantityDelivered", DbType.Decimal, ssENOrderMainItem.ssQuantityDelivered);
{
    string decimalAsStr = ssENOrderMainItem.ssQuantityDelivered.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {QuantityDeliveredParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssOrderUnitOfMeasure", DbType.String, ssENOrderMainItem.ssOrderUnitOfMeasure);
insertSqlCmd.CreateParameter("@ssApplicant", DbType.String, ssENOrderMainItem.ssApplicant);
insertSqlCmd.CreateParameter("@ssDirection", DbType.String, ssENOrderMainItem.ssDirection);
insertSqlCmd.CreateParameter("@ssContractNumber", DbType.String, ssENOrderMainItem.ssContractNumber);
insertSqlCmd.CreateParameter("@ssContractPosition", DbType.Int32, ssENOrderMainItem.ssContractPosition);
insertSqlCmd.CreateParameter("@ssContractStartDate", DbType.DateTime, ssENOrderMainItem.ssContractStartDate);
insertSqlCmd.CreateParameter("@ssContractEndDate", DbType.DateTime, ssENOrderMainItem.ssContractEndDate);
var ContractPlannedValueParameter = insertSqlCmd.CreateParameter("@ssContractPlannedValue", DbType.Decimal, ssENOrderMainItem.ssContractPlannedValue);
{
    string decimalAsStr = ssENOrderMainItem.ssContractPlannedValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ContractPlannedValueParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
insertSqlCmd.CreateParameter("@ssPositionType", DbType.String, ssENOrderMainItem.ssPositionType);
insertSqlCmd.CreateParameter("@ssSerialNumberProfile", DbType.String, ssENOrderMainItem.ssSerialNumberProfile);
insertSqlCmd.CreateParameter("@ssBatchManaged", DbType.String, ssENOrderMainItem.ssBatchManaged);
insertSqlCmd.CreateParameter("@ssMaterialType", DbType.String, ssENOrderMainItem.ssMaterialType);
insertSqlCmd.CreateParameter("@ssItemGroup", DbType.String, ssENOrderMainItem.ssItemGroup);
insertSqlCmd.CreateParameter("@ssOrderRequestCreatorSAPNumber", DbType.String, ssENOrderMainItem.ssOrderRequestCreatorSAPNumber);
insertSqlCmd.CreateParameter("@ssIsMultipleImputation", DbType.Boolean, ssENOrderMainItem.ssIsMultipleImputation);
if ((ssENOrderMainItem.ssInvoiceUsageId==0L)) {
insertSqlCmd.CreateParameter("@ssInvoiceUsageId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssInvoiceUsageId", DbType.Int64, ssENOrderMainItem.ssInvoiceUsageId);

}
if ((ssENOrderMainItem.ssOrderMainItemStatusId==0)) {
insertSqlCmd.CreateParameter("@ssOrderMainItemStatusId", DbType.Int32, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssOrderMainItemStatusId", DbType.Int32, ssENOrderMainItem.ssOrderMainItemStatusId);

}
if ((ssENOrderMainItem.ssDivisionId==0L)) {
insertSqlCmd.CreateParameter("@ssDivisionId", DbType.Int64, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssDivisionId", DbType.Int64, ssENOrderMainItem.ssDivisionId);

}
if ((ssENOrderMainItem.ssCreatedBy=="")) {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderMainItem.ssCreatedBy);

}
insertSqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderMainItem.ssCreatedOn);
if ((ssENOrderMainItem.ssUpdatedBy=="")) {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
insertSqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENOrderMainItem.ssUpdatedBy);

}
insertSqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENOrderMainItem.ssUpdatedOn);
IDbDataParameter outId = insertSqlCmd.CreateParameterWithDirection("@id", DbType.Int64, ParameterDirection.Output);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateOrderMainItem", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
outParamId = (long) Convert.ChangeType(outId.Value, typeof( long));
}
} else {
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
outParamId = ssENOrderMainItem.ssId;
}
}
}
return outParamId;
}

/// <summary>
/// Action: CreateOrUpdateSomeOrderMainItem
/// </summary>

public static async Task CreateOrUpdateSomeOrderMainItem(IRequestContext requestContext,RL_361bfb1983e170050cb9d371d001b386 inParamSourceList,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("CreateOrUpdateSomeOrderMainItem", "176ce248-4371-426c-bbd5-10d39536ee69.#CreateOrUpdateAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("CreateOrUpdateSomeOrderMainItem", "176ce248-4371-426c-bbd5-10d39536ee69.#CreateOrUpdateAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
string entityTableName = ENOrderMainItemEntity.LocalViewName(null);
string insertSql = "INSERT INTO " + entityTableName + " (" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Position, "position") ?? "position") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialCode, "materialcode") ?? "materialcode") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialDescription, "materialdescription") ?? "materialdescription") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@AssigmnentCode, "assigmnentcode") ?? "assigmnentcode") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DocumentClassId, "documentclassid") ?? "documentclassid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DeliveryDate, "deliverydate") ?? "deliverydate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Quantity, "quantity") ?? "quantity") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UnitType, "unittype") ?? "unittype") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UnitPrice, "unitprice") ?? "unitprice") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@BaseQuantity, "basequantity") ?? "basequantity") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsBlocked, "isblocked") ?? "isblocked") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsFinalDelivery, "isfinaldelivery") ?? "isfinaldelivery") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@GLAccountId, "glaccountid") ?? "glaccountid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@FundsCenter, "fundscenter") ?? "fundscenter") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Fund, "fund") ?? "fund") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CommitmentItem, "commitmentitem") ?? "commitmentitem") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATIndicator, "vatindicator") ?? "vatindicator") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATProcedure, "vatprocedure") ?? "vatprocedure") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATRate, "vatrate") ?? "vatrate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PurchaseRequisitionNumber, "purchaserequisitionnumber") ?? "purchaserequisitionnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PurchaseRequisitionItemNr, "purchaserequisitionitemnr") ?? "purchaserequisitionitemnr") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@RegionId, "regionid") ?? "regionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Center, "center") ?? "center") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PEPElement, "pepelement") ?? "pepelement") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@QuantityDelivered, "quantitydelivered") ?? "quantitydelivered") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderUnitOfMeasure, "orderunitofmeasure") ?? "orderunitofmeasure") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Applicant, "applicant") ?? "applicant") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Direction, "direction") ?? "direction") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractNumber, "contractnumber") ?? "contractnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractPosition, "contractposition") ?? "contractposition") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractStartDate, "contractstartdate") ?? "contractstartdate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractEndDate, "contractenddate") ?? "contractenddate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractPlannedValue, "contractplannedvalue") ?? "contractplannedvalue") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PositionType, "positiontype") ?? "positiontype") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@SerialNumberProfile, "serialnumberprofile") ?? "serialnumberprofile") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@BatchManaged, "batchmanaged") ?? "batchmanaged") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialType, "materialtype") ?? "materialtype") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ItemGroup, "itemgroup") ?? "itemgroup") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderRequestCreatorSAPNumber, "orderrequestcreatorsapnumber") ?? "orderrequestcreatorsapnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsMultipleImputation, "ismultipleimputation") ?? "ismultipleimputation") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderMainItemStatusId, "ordermainitemstatusid") ?? "ordermainitemstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DivisionId, "divisionid") ?? "divisionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + ") VALUES ( unnest(@ssOrderMainId),  unnest(@ssPosition),  unnest(@ssMaterialCode),  unnest(@ssMaterialDescription),  unnest(@ssAssigmnentCode),  unnest(@ssDocumentClassId),  unnest(@ssDeliveryDate),  unnest(@ssQuantity),  unnest(@ssUnitType),  unnest(@ssUnitPrice),  unnest(@ssBaseQuantity),  unnest(@ssIsDeleted),  unnest(@ssIsBlocked),  unnest(@ssIsFinalDelivery),  unnest(@ssGLAccountId),  unnest(@ssCostCenterId),  unnest(@ssFundsCenter),  unnest(@ssFund),  unnest(@ssCommitmentItem),  unnest(@ssVATIndicator),  unnest(@ssVATProcedure),  unnest(@ssVATRate),  unnest(@ssPurchaseRequisitionNumber),  unnest(@ssPurchaseRequisitionItemNr),  unnest(@ssRegionId),  unnest(@ssCenter),  unnest(@ssPEPElement),  unnest(@ssQuantityDelivered),  unnest(@ssOrderUnitOfMeasure),  unnest(@ssApplicant),  unnest(@ssDirection),  unnest(@ssContractNumber),  unnest(@ssContractPosition),  unnest(@ssContractStartDate),  unnest(@ssContractEndDate),  unnest(@ssContractPlannedValue),  unnest(@ssPositionType),  unnest(@ssSerialNumberProfile),  unnest(@ssBatchManaged),  unnest(@ssMaterialType),  unnest(@ssItemGroup),  unnest(@ssOrderRequestCreatorSAPNumber),  unnest(@ssIsMultipleImputation),  unnest(@ssInvoiceUsageId),  unnest(@ssOrderMainItemStatusId),  unnest(@ssDivisionId),  unnest(@ssCreatedBy),  unnest(@ssCreatedOn),  unnest(@ssUpdatedBy),  unnest(@ssUpdatedOn)) ";
insertSql += "";

string updateSql = "UPDATE " + entityTableName + " SET " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Position, "position") ?? "position") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Position, "position") ?? "position") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialCode, "materialcode") ?? "materialcode") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialCode, "materialcode") ?? "materialcode") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialDescription, "materialdescription") ?? "materialdescription") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialDescription, "materialdescription") ?? "materialdescription") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@AssigmnentCode, "assigmnentcode") ?? "assigmnentcode") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@AssigmnentCode, "assigmnentcode") ?? "assigmnentcode") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DocumentClassId, "documentclassid") ?? "documentclassid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DocumentClassId, "documentclassid") ?? "documentclassid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DeliveryDate, "deliverydate") ?? "deliverydate") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DeliveryDate, "deliverydate") ?? "deliverydate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Quantity, "quantity") ?? "quantity") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Quantity, "quantity") ?? "quantity") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UnitType, "unittype") ?? "unittype") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UnitType, "unittype") ?? "unittype") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UnitPrice, "unitprice") ?? "unitprice") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UnitPrice, "unitprice") ?? "unitprice") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@BaseQuantity, "basequantity") ?? "basequantity") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@BaseQuantity, "basequantity") ?? "basequantity") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsBlocked, "isblocked") ?? "isblocked") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsBlocked, "isblocked") ?? "isblocked") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsFinalDelivery, "isfinaldelivery") ?? "isfinaldelivery") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsFinalDelivery, "isfinaldelivery") ?? "isfinaldelivery") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@GLAccountId, "glaccountid") ?? "glaccountid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@GLAccountId, "glaccountid") ?? "glaccountid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@FundsCenter, "fundscenter") ?? "fundscenter") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@FundsCenter, "fundscenter") ?? "fundscenter") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Fund, "fund") ?? "fund") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Fund, "fund") ?? "fund") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CommitmentItem, "commitmentitem") ?? "commitmentitem") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CommitmentItem, "commitmentitem") ?? "commitmentitem") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATIndicator, "vatindicator") ?? "vatindicator") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATIndicator, "vatindicator") ?? "vatindicator") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATProcedure, "vatprocedure") ?? "vatprocedure") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATProcedure, "vatprocedure") ?? "vatprocedure") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATRate, "vatrate") ?? "vatrate") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATRate, "vatrate") ?? "vatrate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PurchaseRequisitionNumber, "purchaserequisitionnumber") ?? "purchaserequisitionnumber") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PurchaseRequisitionNumber, "purchaserequisitionnumber") ?? "purchaserequisitionnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PurchaseRequisitionItemNr, "purchaserequisitionitemnr") ?? "purchaserequisitionitemnr") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PurchaseRequisitionItemNr, "purchaserequisitionitemnr") ?? "purchaserequisitionitemnr") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@RegionId, "regionid") ?? "regionid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@RegionId, "regionid") ?? "regionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Center, "center") ?? "center") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Center, "center") ?? "center") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PEPElement, "pepelement") ?? "pepelement") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PEPElement, "pepelement") ?? "pepelement") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@QuantityDelivered, "quantitydelivered") ?? "quantitydelivered") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@QuantityDelivered, "quantitydelivered") ?? "quantitydelivered") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderUnitOfMeasure, "orderunitofmeasure") ?? "orderunitofmeasure") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderUnitOfMeasure, "orderunitofmeasure") ?? "orderunitofmeasure") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Applicant, "applicant") ?? "applicant") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Applicant, "applicant") ?? "applicant") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Direction, "direction") ?? "direction") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Direction, "direction") ?? "direction") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractNumber, "contractnumber") ?? "contractnumber") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractNumber, "contractnumber") ?? "contractnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractPosition, "contractposition") ?? "contractposition") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractPosition, "contractposition") ?? "contractposition") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractStartDate, "contractstartdate") ?? "contractstartdate") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractStartDate, "contractstartdate") ?? "contractstartdate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractEndDate, "contractenddate") ?? "contractenddate") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractEndDate, "contractenddate") ?? "contractenddate") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractPlannedValue, "contractplannedvalue") ?? "contractplannedvalue") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractPlannedValue, "contractplannedvalue") ?? "contractplannedvalue") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PositionType, "positiontype") ?? "positiontype") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PositionType, "positiontype") ?? "positiontype") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@SerialNumberProfile, "serialnumberprofile") ?? "serialnumberprofile") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@SerialNumberProfile, "serialnumberprofile") ?? "serialnumberprofile") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@BatchManaged, "batchmanaged") ?? "batchmanaged") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@BatchManaged, "batchmanaged") ?? "batchmanaged") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialType, "materialtype") ?? "materialtype") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialType, "materialtype") ?? "materialtype") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ItemGroup, "itemgroup") ?? "itemgroup") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ItemGroup, "itemgroup") ?? "itemgroup") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderRequestCreatorSAPNumber, "orderrequestcreatorsapnumber") ?? "orderrequestcreatorsapnumber") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderRequestCreatorSAPNumber, "orderrequestcreatorsapnumber") ?? "orderrequestcreatorsapnumber") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsMultipleImputation, "ismultipleimputation") ?? "ismultipleimputation") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsMultipleImputation, "ismultipleimputation") ?? "ismultipleimputation") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderMainItemStatusId, "ordermainitemstatusid") ?? "ordermainitemstatusid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderMainItemStatusId, "ordermainitemstatusid") ?? "ordermainitemstatusid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DivisionId, "divisionid") ?? "divisionid") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DivisionId, "divisionid") ?? "divisionid") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + ", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " from ( select  unnest(@ssId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Id, "id") ?? "id") + ",  unnest(@ssOrderMainId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid") + ",  unnest(@ssPosition) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Position, "position") ?? "position") + ",  unnest(@ssMaterialCode) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialCode, "materialcode") ?? "materialcode") + ",  unnest(@ssMaterialDescription) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialDescription, "materialdescription") ?? "materialdescription") + ",  unnest(@ssAssigmnentCode) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@AssigmnentCode, "assigmnentcode") ?? "assigmnentcode") + ",  unnest(@ssDocumentClassId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DocumentClassId, "documentclassid") ?? "documentclassid") + ",  unnest(@ssDeliveryDate) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DeliveryDate, "deliverydate") ?? "deliverydate") + ",  unnest(@ssQuantity) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Quantity, "quantity") ?? "quantity") + ",  unnest(@ssUnitType) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UnitType, "unittype") ?? "unittype") + ",  unnest(@ssUnitPrice) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UnitPrice, "unitprice") ?? "unitprice") + ",  unnest(@ssBaseQuantity) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@BaseQuantity, "basequantity") ?? "basequantity") + ",  unnest(@ssIsDeleted) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted") + ",  unnest(@ssIsBlocked) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsBlocked, "isblocked") ?? "isblocked") + ",  unnest(@ssIsFinalDelivery) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsFinalDelivery, "isfinaldelivery") ?? "isfinaldelivery") + ",  unnest(@ssGLAccountId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@GLAccountId, "glaccountid") ?? "glaccountid") + ",  unnest(@ssCostCenterId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid") + ",  unnest(@ssFundsCenter) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@FundsCenter, "fundscenter") ?? "fundscenter") + ",  unnest(@ssFund) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Fund, "fund") ?? "fund") + ",  unnest(@ssCommitmentItem) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CommitmentItem, "commitmentitem") ?? "commitmentitem") + ",  unnest(@ssVATIndicator) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATIndicator, "vatindicator") ?? "vatindicator") + ",  unnest(@ssVATProcedure) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATProcedure, "vatprocedure") ?? "vatprocedure") + ",  unnest(@ssVATRate) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATRate, "vatrate") ?? "vatrate") + ",  unnest(@ssPurchaseRequisitionNumber) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PurchaseRequisitionNumber, "purchaserequisitionnumber") ?? "purchaserequisitionnumber") + ",  unnest(@ssPurchaseRequisitionItemNr) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PurchaseRequisitionItemNr, "purchaserequisitionitemnr") ?? "purchaserequisitionitemnr") + ",  unnest(@ssRegionId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@RegionId, "regionid") ?? "regionid") + ",  unnest(@ssCenter) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Center, "center") ?? "center") + ",  unnest(@ssPEPElement) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PEPElement, "pepelement") ?? "pepelement") + ",  unnest(@ssQuantityDelivered) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@QuantityDelivered, "quantitydelivered") ?? "quantitydelivered") + ",  unnest(@ssOrderUnitOfMeasure) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderUnitOfMeasure, "orderunitofmeasure") ?? "orderunitofmeasure") + ",  unnest(@ssApplicant) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Applicant, "applicant") ?? "applicant") + ",  unnest(@ssDirection) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Direction, "direction") ?? "direction") + ",  unnest(@ssContractNumber) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractNumber, "contractnumber") ?? "contractnumber") + ",  unnest(@ssContractPosition) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractPosition, "contractposition") ?? "contractposition") + ",  unnest(@ssContractStartDate) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractStartDate, "contractstartdate") ?? "contractstartdate") + ",  unnest(@ssContractEndDate) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractEndDate, "contractenddate") ?? "contractenddate") + ",  unnest(@ssContractPlannedValue) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractPlannedValue, "contractplannedvalue") ?? "contractplannedvalue") + ",  unnest(@ssPositionType) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PositionType, "positiontype") ?? "positiontype") + ",  unnest(@ssSerialNumberProfile) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@SerialNumberProfile, "serialnumberprofile") ?? "serialnumberprofile") + ",  unnest(@ssBatchManaged) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@BatchManaged, "batchmanaged") ?? "batchmanaged") + ",  unnest(@ssMaterialType) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialType, "materialtype") ?? "materialtype") + ",  unnest(@ssItemGroup) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ItemGroup, "itemgroup") ?? "itemgroup") + ",  unnest(@ssOrderRequestCreatorSAPNumber) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderRequestCreatorSAPNumber, "orderrequestcreatorsapnumber") ?? "orderrequestcreatorsapnumber") + ",  unnest(@ssIsMultipleImputation) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsMultipleImputation, "ismultipleimputation") ?? "ismultipleimputation") + ",  unnest(@ssInvoiceUsageId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid") + ",  unnest(@ssOrderMainItemStatusId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderMainItemStatusId, "ordermainitemstatusid") ?? "ordermainitemstatusid") + ",  unnest(@ssDivisionId) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DivisionId, "divisionid") ?? "divisionid") + ",  unnest(@ssCreatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + ",  unnest(@ssCreatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + ",  unnest(@ssUpdatedBy) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + ",  unnest(@ssUpdatedOn) as " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " ) as updateTable where " + entityTableName + "." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Id, "id") ?? "id") + " = updateTable." + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Id, "id") ?? "id") + " ";
updateSql += "";

List<object> insertOrderMainIdList = new List<object>();
List<int> insertPositionList = new List<int>();
List<string> insertMaterialCodeList = new List<string>();
List<string> insertMaterialDescriptionList = new List<string>();
List<string> insertAssigmnentCodeList = new List<string>();
List<object> insertDocumentClassIdList = new List<object>();
List<DateTime> insertDeliveryDateList = new List<DateTime>();
List<decimal> insertQuantityList = new List<decimal>();
List<string> insertUnitTypeList = new List<string>();
List<decimal> insertUnitPriceList = new List<decimal>();
List<int> insertBaseQuantityList = new List<int>();
List<bool> insertIsDeletedList = new List<bool>();
List<bool> insertIsBlockedList = new List<bool>();
List<bool> insertIsFinalDeliveryList = new List<bool>();
List<object> insertGLAccountIdList = new List<object>();
List<object> insertCostCenterIdList = new List<object>();
List<string> insertFundsCenterList = new List<string>();
List<string> insertFundList = new List<string>();
List<string> insertCommitmentItemList = new List<string>();
List<string> insertVATIndicatorList = new List<string>();
List<string> insertVATProcedureList = new List<string>();
List<decimal> insertVATRateList = new List<decimal>();
List<string> insertPurchaseRequisitionNumberList = new List<string>();
List<int> insertPurchaseRequisitionItemNrList = new List<int>();
List<object> insertRegionIdList = new List<object>();
List<string> insertCenterList = new List<string>();
List<string> insertPEPElementList = new List<string>();
List<decimal> insertQuantityDeliveredList = new List<decimal>();
List<string> insertOrderUnitOfMeasureList = new List<string>();
List<string> insertApplicantList = new List<string>();
List<string> insertDirectionList = new List<string>();
List<string> insertContractNumberList = new List<string>();
List<int> insertContractPositionList = new List<int>();
List<DateTime> insertContractStartDateList = new List<DateTime>();
List<DateTime> insertContractEndDateList = new List<DateTime>();
List<decimal> insertContractPlannedValueList = new List<decimal>();
List<string> insertPositionTypeList = new List<string>();
List<string> insertSerialNumberProfileList = new List<string>();
List<string> insertBatchManagedList = new List<string>();
List<string> insertMaterialTypeList = new List<string>();
List<string> insertItemGroupList = new List<string>();
List<string> insertOrderRequestCreatorSAPNumberList = new List<string>();
List<bool> insertIsMultipleImputationList = new List<bool>();
List<object> insertInvoiceUsageIdList = new List<object>();
List<object> insertOrderMainItemStatusIdList = new List<object>();
List<object> insertDivisionIdList = new List<object>();
List<object> insertCreatedByList = new List<object>();
List<DateTime> insertCreatedOnList = new List<DateTime>();
List<object> insertUpdatedByList = new List<object>();
List<DateTime> insertUpdatedOnList = new List<DateTime>();

List<long> updateIdList = new List<long>();
List<object> updateOrderMainIdList = new List<object>();
List<int> updatePositionList = new List<int>();
List<string> updateMaterialCodeList = new List<string>();
List<string> updateMaterialDescriptionList = new List<string>();
List<string> updateAssigmnentCodeList = new List<string>();
List<object> updateDocumentClassIdList = new List<object>();
List<DateTime> updateDeliveryDateList = new List<DateTime>();
List<decimal> updateQuantityList = new List<decimal>();
List<string> updateUnitTypeList = new List<string>();
List<decimal> updateUnitPriceList = new List<decimal>();
List<int> updateBaseQuantityList = new List<int>();
List<bool> updateIsDeletedList = new List<bool>();
List<bool> updateIsBlockedList = new List<bool>();
List<bool> updateIsFinalDeliveryList = new List<bool>();
List<object> updateGLAccountIdList = new List<object>();
List<object> updateCostCenterIdList = new List<object>();
List<string> updateFundsCenterList = new List<string>();
List<string> updateFundList = new List<string>();
List<string> updateCommitmentItemList = new List<string>();
List<string> updateVATIndicatorList = new List<string>();
List<string> updateVATProcedureList = new List<string>();
List<decimal> updateVATRateList = new List<decimal>();
List<string> updatePurchaseRequisitionNumberList = new List<string>();
List<int> updatePurchaseRequisitionItemNrList = new List<int>();
List<object> updateRegionIdList = new List<object>();
List<string> updateCenterList = new List<string>();
List<string> updatePEPElementList = new List<string>();
List<decimal> updateQuantityDeliveredList = new List<decimal>();
List<string> updateOrderUnitOfMeasureList = new List<string>();
List<string> updateApplicantList = new List<string>();
List<string> updateDirectionList = new List<string>();
List<string> updateContractNumberList = new List<string>();
List<int> updateContractPositionList = new List<int>();
List<DateTime> updateContractStartDateList = new List<DateTime>();
List<DateTime> updateContractEndDateList = new List<DateTime>();
List<decimal> updateContractPlannedValueList = new List<decimal>();
List<string> updatePositionTypeList = new List<string>();
List<string> updateSerialNumberProfileList = new List<string>();
List<string> updateBatchManagedList = new List<string>();
List<string> updateMaterialTypeList = new List<string>();
List<string> updateItemGroupList = new List<string>();
List<string> updateOrderRequestCreatorSAPNumberList = new List<string>();
List<bool> updateIsMultipleImputationList = new List<bool>();
List<object> updateInvoiceUsageIdList = new List<object>();
List<object> updateOrderMainItemStatusIdList = new List<object>();
List<object> updateDivisionIdList = new List<object>();
List<object> updateCreatedByList = new List<object>();
List<DateTime> updateCreatedOnList = new List<DateTime>();
List<object> updateUpdatedByList = new List<object>();
List<DateTime> updateUpdatedOnList = new List<DateTime>();

var executionService = DatabaseAccess.ForRuntimeDatabase.DatabaseServices.ExecutionService;
inParamSourceList.StartIteration();
try {
while (!inParamSourceList.Eof) {
var record = ((RC_c4cc207f9017de4e013fabcf1e8ebeaf)inParamSourceList.Current).ssENOrderMainItem;
if (record.ssId != 0L) {
updateIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssId));
if ((record.ssOrderMainId==0L)) {
updateOrderMainIdList.Add(null);
} else {
updateOrderMainIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderMainId));
}
updatePositionList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssPosition));
updateMaterialCodeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssMaterialCode));
updateMaterialDescriptionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssMaterialDescription));
updateAssigmnentCodeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssAssigmnentCode));
if ((record.ssDocumentClassId==0L)) {
updateDocumentClassIdList.Add(null);
} else {
updateDocumentClassIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssDocumentClassId));
}
updateDeliveryDateList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssDeliveryDate));
updateQuantityList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssQuantity));
updateUnitTypeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssUnitType));
updateUnitPriceList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssUnitPrice));
updateBaseQuantityList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssBaseQuantity));
updateIsDeletedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsDeleted));
updateIsBlockedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsBlocked));
updateIsFinalDeliveryList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsFinalDelivery));
if ((record.ssGLAccountId==0L)) {
updateGLAccountIdList.Add(null);
} else {
updateGLAccountIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssGLAccountId));
}
if ((record.ssCostCenterId==0L)) {
updateCostCenterIdList.Add(null);
} else {
updateCostCenterIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssCostCenterId));
}
updateFundsCenterList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssFundsCenter));
updateFundList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssFund));
updateCommitmentItemList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCommitmentItem));
updateVATIndicatorList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssVATIndicator));
updateVATProcedureList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssVATProcedure));
updateVATRateList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssVATRate));
updatePurchaseRequisitionNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPurchaseRequisitionNumber));
updatePurchaseRequisitionItemNrList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssPurchaseRequisitionItemNr));
if ((record.ssRegionId==0L)) {
updateRegionIdList.Add(null);
} else {
updateRegionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRegionId));
}
updateCenterList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCenter));
updatePEPElementList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPEPElement));
updateQuantityDeliveredList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssQuantityDelivered));
updateOrderUnitOfMeasureList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssOrderUnitOfMeasure));
updateApplicantList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssApplicant));
updateDirectionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDirection));
updateContractNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssContractNumber));
updateContractPositionList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssContractPosition));
updateContractStartDateList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssContractStartDate));
updateContractEndDateList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssContractEndDate));
updateContractPlannedValueList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssContractPlannedValue));
updatePositionTypeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPositionType));
updateSerialNumberProfileList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssSerialNumberProfile));
updateBatchManagedList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssBatchManaged));
updateMaterialTypeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssMaterialType));
updateItemGroupList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssItemGroup));
updateOrderRequestCreatorSAPNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssOrderRequestCreatorSAPNumber));
updateIsMultipleImputationList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsMultipleImputation));
if ((record.ssInvoiceUsageId==0L)) {
updateInvoiceUsageIdList.Add(null);
} else {
updateInvoiceUsageIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceUsageId));
}
if ((record.ssOrderMainItemStatusId==0)) {
updateOrderMainItemStatusIdList.Add(null);
} else {
updateOrderMainItemStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssOrderMainItemStatusId));
}
if ((record.ssDivisionId==0L)) {
updateDivisionIdList.Add(null);
} else {
updateDivisionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssDivisionId));
}
if ((record.ssCreatedBy=="")) {
updateCreatedByList.Add(null);
} else {
updateCreatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCreatedBy));
}
updateCreatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssCreatedOn));
if ((record.ssUpdatedBy=="")) {
updateUpdatedByList.Add(null);
} else {
updateUpdatedByList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssUpdatedBy));
}
updateUpdatedOnList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssUpdatedOn));
} else {
if ((record.ssOrderMainId==0L)) {
insertOrderMainIdList.Add(null);
} else {
insertOrderMainIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssOrderMainId));
}
insertPositionList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssPosition));
insertMaterialCodeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssMaterialCode));
insertMaterialDescriptionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssMaterialDescription));
insertAssigmnentCodeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssAssigmnentCode));
if ((record.ssDocumentClassId==0L)) {
insertDocumentClassIdList.Add(null);
} else {
insertDocumentClassIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssDocumentClassId));
}
insertDeliveryDateList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssDeliveryDate));
insertQuantityList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssQuantity));
insertUnitTypeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssUnitType));
insertUnitPriceList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssUnitPrice));
insertBaseQuantityList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssBaseQuantity));
insertIsDeletedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsDeleted));
insertIsBlockedList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsBlocked));
insertIsFinalDeliveryList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsFinalDelivery));
if ((record.ssGLAccountId==0L)) {
insertGLAccountIdList.Add(null);
} else {
insertGLAccountIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssGLAccountId));
}
if ((record.ssCostCenterId==0L)) {
insertCostCenterIdList.Add(null);
} else {
insertCostCenterIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssCostCenterId));
}
insertFundsCenterList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssFundsCenter));
insertFundList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssFund));
insertCommitmentItemList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCommitmentItem));
insertVATIndicatorList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssVATIndicator));
insertVATProcedureList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssVATProcedure));
insertVATRateList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssVATRate));
insertPurchaseRequisitionNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPurchaseRequisitionNumber));
insertPurchaseRequisitionItemNrList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssPurchaseRequisitionItemNr));
if ((record.ssRegionId==0L)) {
insertRegionIdList.Add(null);
} else {
insertRegionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssRegionId));
}
insertCenterList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssCenter));
insertPEPElementList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPEPElement));
insertQuantityDeliveredList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssQuantityDelivered));
insertOrderUnitOfMeasureList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssOrderUnitOfMeasure));
insertApplicantList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssApplicant));
insertDirectionList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssDirection));
insertContractNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssContractNumber));
insertContractPositionList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssContractPosition));
insertContractStartDateList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssContractStartDate));
insertContractEndDateList.Add((DateTime)executionService.TransformRuntimeToDatabaseValue(DbType.DateTime, record.ssContractEndDate));
insertContractPlannedValueList.Add((decimal)executionService.TransformRuntimeToDatabaseValue(DbType.Decimal, record.ssContractPlannedValue));
insertPositionTypeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssPositionType));
insertSerialNumberProfileList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssSerialNumberProfile));
insertBatchManagedList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssBatchManaged));
insertMaterialTypeList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssMaterialType));
insertItemGroupList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssItemGroup));
insertOrderRequestCreatorSAPNumberList.Add((string)executionService.TransformRuntimeToDatabaseValue(DbType.String, record.ssOrderRequestCreatorSAPNumber));
insertIsMultipleImputationList.Add((bool)executionService.TransformRuntimeToDatabaseValue(DbType.Boolean, record.ssIsMultipleImputation));
if ((record.ssInvoiceUsageId==0L)) {
insertInvoiceUsageIdList.Add(null);
} else {
insertInvoiceUsageIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssInvoiceUsageId));
}
if ((record.ssOrderMainItemStatusId==0)) {
insertOrderMainItemStatusIdList.Add(null);
} else {
insertOrderMainItemStatusIdList.Add((int)executionService.TransformRuntimeToDatabaseValue(DbType.Int32, record.ssOrderMainItemStatusId));
}
if ((record.ssDivisionId==0L)) {
insertDivisionIdList.Add(null);
} else {
insertDivisionIdList.Add((long)executionService.TransformRuntimeToDatabaseValue(DbType.Int64, record.ssDivisionId));
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
}
inParamSourceList.Advance();
} } finally {
inParamSourceList.EndIteration(); }
var finalSqlBuilder = new StringBuilder();
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if (!insertOrderMainIdList.IsEmpty() || !insertPositionList.IsEmpty() || !insertMaterialCodeList.IsEmpty() || !insertMaterialDescriptionList.IsEmpty() || !insertAssigmnentCodeList.IsEmpty() || !insertDocumentClassIdList.IsEmpty() || !insertDeliveryDateList.IsEmpty() || !insertQuantityList.IsEmpty() || !insertUnitTypeList.IsEmpty() || !insertUnitPriceList.IsEmpty() || !insertBaseQuantityList.IsEmpty() || !insertIsDeletedList.IsEmpty() || !insertIsBlockedList.IsEmpty() || !insertIsFinalDeliveryList.IsEmpty() || !insertGLAccountIdList.IsEmpty() || !insertCostCenterIdList.IsEmpty() || !insertFundsCenterList.IsEmpty() || !insertFundList.IsEmpty() || !insertCommitmentItemList.IsEmpty() || !insertVATIndicatorList.IsEmpty() || !insertVATProcedureList.IsEmpty() || !insertVATRateList.IsEmpty() || !insertPurchaseRequisitionNumberList.IsEmpty() || !insertPurchaseRequisitionItemNrList.IsEmpty() || !insertRegionIdList.IsEmpty() || !insertCenterList.IsEmpty() || !insertPEPElementList.IsEmpty() || !insertQuantityDeliveredList.IsEmpty() || !insertOrderUnitOfMeasureList.IsEmpty() || !insertApplicantList.IsEmpty() || !insertDirectionList.IsEmpty() || !insertContractNumberList.IsEmpty() || !insertContractPositionList.IsEmpty() || !insertContractStartDateList.IsEmpty() || !insertContractEndDateList.IsEmpty() || !insertContractPlannedValueList.IsEmpty() || !insertPositionTypeList.IsEmpty() || !insertSerialNumberProfileList.IsEmpty() || !insertBatchManagedList.IsEmpty() || !insertMaterialTypeList.IsEmpty() || !insertItemGroupList.IsEmpty() || !insertOrderRequestCreatorSAPNumberList.IsEmpty() || !insertIsMultipleImputationList.IsEmpty() || !insertInvoiceUsageIdList.IsEmpty() || !insertOrderMainItemStatusIdList.IsEmpty() || !insertDivisionIdList.IsEmpty() || !insertCreatedByList.IsEmpty() || !insertCreatedOnList.IsEmpty() || !insertUpdatedByList.IsEmpty() || !insertUpdatedOnList.IsEmpty()){
await using(var insertSqlCmd = trans.CreateCommand(insertSql)){
executionService.CreateParameter(insertSqlCmd,"@ssOrderMainId",DbType.Int64,insertOrderMainIdList);
executionService.CreateParameter(insertSqlCmd,"@ssPosition",DbType.Int32,insertPositionList);
executionService.CreateParameter(insertSqlCmd,"@ssMaterialCode",DbType.String,insertMaterialCodeList);
executionService.CreateParameter(insertSqlCmd,"@ssMaterialDescription",DbType.String,insertMaterialDescriptionList);
executionService.CreateParameter(insertSqlCmd,"@ssAssigmnentCode",DbType.String,insertAssigmnentCodeList);
executionService.CreateParameter(insertSqlCmd,"@ssDocumentClassId",DbType.Int64,insertDocumentClassIdList);
executionService.CreateParameter(insertSqlCmd,"@ssDeliveryDate",DbType.DateTime,insertDeliveryDateList);
executionService.CreateParameter(insertSqlCmd,"@ssQuantity",DbType.Decimal,insertQuantityList);
executionService.CreateParameter(insertSqlCmd,"@ssUnitType",DbType.String,insertUnitTypeList);
executionService.CreateParameter(insertSqlCmd,"@ssUnitPrice",DbType.Decimal,insertUnitPriceList);
executionService.CreateParameter(insertSqlCmd,"@ssBaseQuantity",DbType.Int32,insertBaseQuantityList);
executionService.CreateParameter(insertSqlCmd,"@ssIsDeleted",DbType.Boolean,insertIsDeletedList);
executionService.CreateParameter(insertSqlCmd,"@ssIsBlocked",DbType.Boolean,insertIsBlockedList);
executionService.CreateParameter(insertSqlCmd,"@ssIsFinalDelivery",DbType.Boolean,insertIsFinalDeliveryList);
executionService.CreateParameter(insertSqlCmd,"@ssGLAccountId",DbType.Int64,insertGLAccountIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCostCenterId",DbType.Int64,insertCostCenterIdList);
executionService.CreateParameter(insertSqlCmd,"@ssFundsCenter",DbType.String,insertFundsCenterList);
executionService.CreateParameter(insertSqlCmd,"@ssFund",DbType.String,insertFundList);
executionService.CreateParameter(insertSqlCmd,"@ssCommitmentItem",DbType.String,insertCommitmentItemList);
executionService.CreateParameter(insertSqlCmd,"@ssVATIndicator",DbType.String,insertVATIndicatorList);
executionService.CreateParameter(insertSqlCmd,"@ssVATProcedure",DbType.String,insertVATProcedureList);
executionService.CreateParameter(insertSqlCmd,"@ssVATRate",DbType.Decimal,insertVATRateList);
executionService.CreateParameter(insertSqlCmd,"@ssPurchaseRequisitionNumber",DbType.String,insertPurchaseRequisitionNumberList);
executionService.CreateParameter(insertSqlCmd,"@ssPurchaseRequisitionItemNr",DbType.Int32,insertPurchaseRequisitionItemNrList);
executionService.CreateParameter(insertSqlCmd,"@ssRegionId",DbType.Int64,insertRegionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCenter",DbType.String,insertCenterList);
executionService.CreateParameter(insertSqlCmd,"@ssPEPElement",DbType.String,insertPEPElementList);
executionService.CreateParameter(insertSqlCmd,"@ssQuantityDelivered",DbType.Decimal,insertQuantityDeliveredList);
executionService.CreateParameter(insertSqlCmd,"@ssOrderUnitOfMeasure",DbType.String,insertOrderUnitOfMeasureList);
executionService.CreateParameter(insertSqlCmd,"@ssApplicant",DbType.String,insertApplicantList);
executionService.CreateParameter(insertSqlCmd,"@ssDirection",DbType.String,insertDirectionList);
executionService.CreateParameter(insertSqlCmd,"@ssContractNumber",DbType.String,insertContractNumberList);
executionService.CreateParameter(insertSqlCmd,"@ssContractPosition",DbType.Int32,insertContractPositionList);
executionService.CreateParameter(insertSqlCmd,"@ssContractStartDate",DbType.DateTime,insertContractStartDateList);
executionService.CreateParameter(insertSqlCmd,"@ssContractEndDate",DbType.DateTime,insertContractEndDateList);
executionService.CreateParameter(insertSqlCmd,"@ssContractPlannedValue",DbType.Decimal,insertContractPlannedValueList);
executionService.CreateParameter(insertSqlCmd,"@ssPositionType",DbType.String,insertPositionTypeList);
executionService.CreateParameter(insertSqlCmd,"@ssSerialNumberProfile",DbType.String,insertSerialNumberProfileList);
executionService.CreateParameter(insertSqlCmd,"@ssBatchManaged",DbType.String,insertBatchManagedList);
executionService.CreateParameter(insertSqlCmd,"@ssMaterialType",DbType.String,insertMaterialTypeList);
executionService.CreateParameter(insertSqlCmd,"@ssItemGroup",DbType.String,insertItemGroupList);
executionService.CreateParameter(insertSqlCmd,"@ssOrderRequestCreatorSAPNumber",DbType.String,insertOrderRequestCreatorSAPNumberList);
executionService.CreateParameter(insertSqlCmd,"@ssIsMultipleImputation",DbType.Boolean,insertIsMultipleImputationList);
executionService.CreateParameter(insertSqlCmd,"@ssInvoiceUsageId",DbType.Int64,insertInvoiceUsageIdList);
executionService.CreateParameter(insertSqlCmd,"@ssOrderMainItemStatusId",DbType.Int32,insertOrderMainItemStatusIdList);
executionService.CreateParameter(insertSqlCmd,"@ssDivisionId",DbType.Int64,insertDivisionIdList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedBy",DbType.String,insertCreatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssCreatedOn",DbType.DateTime,insertCreatedOnList);
executionService.CreateParameter(insertSqlCmd,"@ssUpdatedBy",DbType.String,insertUpdatedByList);
executionService.CreateParameter(insertSqlCmd,"@ssUpdatedOn",DbType.DateTime,insertUpdatedOnList);
await insertSqlCmd.PrepareAsync(cancellationToken);
await insertSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderMainItem (insert)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(insertSqlCmd.CommandText);
}
}
if(!updateOrderMainIdList.IsEmpty() || !updatePositionList.IsEmpty() || !updateMaterialCodeList.IsEmpty() || !updateMaterialDescriptionList.IsEmpty() || !updateAssigmnentCodeList.IsEmpty() || !updateDocumentClassIdList.IsEmpty() || !updateDeliveryDateList.IsEmpty() || !updateQuantityList.IsEmpty() || !updateUnitTypeList.IsEmpty() || !updateUnitPriceList.IsEmpty() || !updateBaseQuantityList.IsEmpty() || !updateIsDeletedList.IsEmpty() || !updateIsBlockedList.IsEmpty() || !updateIsFinalDeliveryList.IsEmpty() || !updateGLAccountIdList.IsEmpty() || !updateCostCenterIdList.IsEmpty() || !updateFundsCenterList.IsEmpty() || !updateFundList.IsEmpty() || !updateCommitmentItemList.IsEmpty() || !updateVATIndicatorList.IsEmpty() || !updateVATProcedureList.IsEmpty() || !updateVATRateList.IsEmpty() || !updatePurchaseRequisitionNumberList.IsEmpty() || !updatePurchaseRequisitionItemNrList.IsEmpty() || !updateRegionIdList.IsEmpty() || !updateCenterList.IsEmpty() || !updatePEPElementList.IsEmpty() || !updateQuantityDeliveredList.IsEmpty() || !updateOrderUnitOfMeasureList.IsEmpty() || !updateApplicantList.IsEmpty() || !updateDirectionList.IsEmpty() || !updateContractNumberList.IsEmpty() || !updateContractPositionList.IsEmpty() || !updateContractStartDateList.IsEmpty() || !updateContractEndDateList.IsEmpty() || !updateContractPlannedValueList.IsEmpty() || !updatePositionTypeList.IsEmpty() || !updateSerialNumberProfileList.IsEmpty() || !updateBatchManagedList.IsEmpty() || !updateMaterialTypeList.IsEmpty() || !updateItemGroupList.IsEmpty() || !updateOrderRequestCreatorSAPNumberList.IsEmpty() || !updateIsMultipleImputationList.IsEmpty() || !updateInvoiceUsageIdList.IsEmpty() || !updateOrderMainItemStatusIdList.IsEmpty() || !updateDivisionIdList.IsEmpty() || !updateCreatedByList.IsEmpty() || !updateCreatedOnList.IsEmpty() || !updateUpdatedByList.IsEmpty() || !updateUpdatedOnList.IsEmpty()){
await using(var updateSqlCmd = trans.CreateCommand(updateSql)){
executionService.CreateParameter(updateSqlCmd,"@ssId",DbType.Int64,updateIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderMainId",DbType.Int64,updateOrderMainIdList);
executionService.CreateParameter(updateSqlCmd,"@ssPosition",DbType.Int32,updatePositionList);
executionService.CreateParameter(updateSqlCmd,"@ssMaterialCode",DbType.String,updateMaterialCodeList);
executionService.CreateParameter(updateSqlCmd,"@ssMaterialDescription",DbType.String,updateMaterialDescriptionList);
executionService.CreateParameter(updateSqlCmd,"@ssAssigmnentCode",DbType.String,updateAssigmnentCodeList);
executionService.CreateParameter(updateSqlCmd,"@ssDocumentClassId",DbType.Int64,updateDocumentClassIdList);
executionService.CreateParameter(updateSqlCmd,"@ssDeliveryDate",DbType.DateTime,updateDeliveryDateList);
executionService.CreateParameter(updateSqlCmd,"@ssQuantity",DbType.Decimal,updateQuantityList);
executionService.CreateParameter(updateSqlCmd,"@ssUnitType",DbType.String,updateUnitTypeList);
executionService.CreateParameter(updateSqlCmd,"@ssUnitPrice",DbType.Decimal,updateUnitPriceList);
executionService.CreateParameter(updateSqlCmd,"@ssBaseQuantity",DbType.Int32,updateBaseQuantityList);
executionService.CreateParameter(updateSqlCmd,"@ssIsDeleted",DbType.Boolean,updateIsDeletedList);
executionService.CreateParameter(updateSqlCmd,"@ssIsBlocked",DbType.Boolean,updateIsBlockedList);
executionService.CreateParameter(updateSqlCmd,"@ssIsFinalDelivery",DbType.Boolean,updateIsFinalDeliveryList);
executionService.CreateParameter(updateSqlCmd,"@ssGLAccountId",DbType.Int64,updateGLAccountIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCostCenterId",DbType.Int64,updateCostCenterIdList);
executionService.CreateParameter(updateSqlCmd,"@ssFundsCenter",DbType.String,updateFundsCenterList);
executionService.CreateParameter(updateSqlCmd,"@ssFund",DbType.String,updateFundList);
executionService.CreateParameter(updateSqlCmd,"@ssCommitmentItem",DbType.String,updateCommitmentItemList);
executionService.CreateParameter(updateSqlCmd,"@ssVATIndicator",DbType.String,updateVATIndicatorList);
executionService.CreateParameter(updateSqlCmd,"@ssVATProcedure",DbType.String,updateVATProcedureList);
executionService.CreateParameter(updateSqlCmd,"@ssVATRate",DbType.Decimal,updateVATRateList);
executionService.CreateParameter(updateSqlCmd,"@ssPurchaseRequisitionNumber",DbType.String,updatePurchaseRequisitionNumberList);
executionService.CreateParameter(updateSqlCmd,"@ssPurchaseRequisitionItemNr",DbType.Int32,updatePurchaseRequisitionItemNrList);
executionService.CreateParameter(updateSqlCmd,"@ssRegionId",DbType.Int64,updateRegionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCenter",DbType.String,updateCenterList);
executionService.CreateParameter(updateSqlCmd,"@ssPEPElement",DbType.String,updatePEPElementList);
executionService.CreateParameter(updateSqlCmd,"@ssQuantityDelivered",DbType.Decimal,updateQuantityDeliveredList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderUnitOfMeasure",DbType.String,updateOrderUnitOfMeasureList);
executionService.CreateParameter(updateSqlCmd,"@ssApplicant",DbType.String,updateApplicantList);
executionService.CreateParameter(updateSqlCmd,"@ssDirection",DbType.String,updateDirectionList);
executionService.CreateParameter(updateSqlCmd,"@ssContractNumber",DbType.String,updateContractNumberList);
executionService.CreateParameter(updateSqlCmd,"@ssContractPosition",DbType.Int32,updateContractPositionList);
executionService.CreateParameter(updateSqlCmd,"@ssContractStartDate",DbType.DateTime,updateContractStartDateList);
executionService.CreateParameter(updateSqlCmd,"@ssContractEndDate",DbType.DateTime,updateContractEndDateList);
executionService.CreateParameter(updateSqlCmd,"@ssContractPlannedValue",DbType.Decimal,updateContractPlannedValueList);
executionService.CreateParameter(updateSqlCmd,"@ssPositionType",DbType.String,updatePositionTypeList);
executionService.CreateParameter(updateSqlCmd,"@ssSerialNumberProfile",DbType.String,updateSerialNumberProfileList);
executionService.CreateParameter(updateSqlCmd,"@ssBatchManaged",DbType.String,updateBatchManagedList);
executionService.CreateParameter(updateSqlCmd,"@ssMaterialType",DbType.String,updateMaterialTypeList);
executionService.CreateParameter(updateSqlCmd,"@ssItemGroup",DbType.String,updateItemGroupList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderRequestCreatorSAPNumber",DbType.String,updateOrderRequestCreatorSAPNumberList);
executionService.CreateParameter(updateSqlCmd,"@ssIsMultipleImputation",DbType.Boolean,updateIsMultipleImputationList);
executionService.CreateParameter(updateSqlCmd,"@ssInvoiceUsageId",DbType.Int64,updateInvoiceUsageIdList);
executionService.CreateParameter(updateSqlCmd,"@ssOrderMainItemStatusId",DbType.Int32,updateOrderMainItemStatusIdList);
executionService.CreateParameter(updateSqlCmd,"@ssDivisionId",DbType.Int64,updateDivisionIdList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedBy",DbType.String,updateCreatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssCreatedOn",DbType.DateTime,updateCreatedOnList);
executionService.CreateParameter(updateSqlCmd,"@ssUpdatedBy",DbType.String,updateUpdatedByList);
executionService.CreateParameter(updateSqlCmd,"@ssUpdatedOn",DbType.DateTime,updateUpdatedOnList);
await updateSqlCmd.PrepareAsync(cancellationToken);
await updateSqlCmd.ExecuteNonQueryAsync(description: "Entity Action CreateOrUpdateSomeOrderMainItem (update)", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
finalSqlBuilder.Append(updateSqlCmd.CommandText);
}
}
}
entityActionActivity.AddSqlActivityTags(finalSqlBuilder.ToString());
return;
}

/// <summary>
/// Action: DeleteOrderMainItem
/// </summary>

public static async Task DeleteOrderMainItem(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteOrderMainItem", "176ce248-4371-426c-bbd5-10d39536ee69.#DeleteEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteOrderMainItem", "176ce248-4371-426c-bbd5-10d39536ee69.#DeleteEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderMainItemEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderMainItem", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: DeleteAllOrderMainItem
/// </summary>

public static async Task DeleteAllOrderMainItem(IRequestContext requestContext,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("DeleteAllOrderMainItem", "176ce248-4371-426c-bbd5-10d39536ee69.#DeleteAllEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("DeleteAllOrderMainItem", "176ce248-4371-426c-bbd5-10d39536ee69.#DeleteAllEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"DELETE " +
"FROM " + ENOrderMainItemEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + "" +
"";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action DeleteOrderMainItem", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken);
}
}
return;
}

/// <summary>
/// Action: GetOrderMainItem
/// </summary>

public static async Task<RC_c4cc207f9017de4e013fabcf1e8ebeaf> GetOrderMainItem(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_c4cc207f9017de4e013fabcf1e8ebeaf outParamRecord = default;
outParamRecord = new RC_c4cc207f9017de4e013fabcf1e8ebeaf();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderMainItem", "176ce248-4371-426c-bbd5-10d39536ee69.#GetEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderMainItem", "176ce248-4371-426c-bbd5-10d39536ee69.#GetEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Position, "position") ?? "position", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialCode, "materialcode") ?? "materialcode", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialDescription, "materialdescription") ?? "materialdescription", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@AssigmnentCode, "assigmnentcode") ?? "assigmnentcode", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DocumentClassId, "documentclassid") ?? "documentclassid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DeliveryDate, "deliverydate") ?? "deliverydate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Quantity, "quantity") ?? "quantity", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UnitType, "unittype") ?? "unittype", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UnitPrice, "unitprice") ?? "unitprice", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@BaseQuantity, "basequantity") ?? "basequantity", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsBlocked, "isblocked") ?? "isblocked", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsFinalDelivery, "isfinaldelivery") ?? "isfinaldelivery", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@GLAccountId, "glaccountid") ?? "glaccountid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@FundsCenter, "fundscenter") ?? "fundscenter", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Fund, "fund") ?? "fund", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CommitmentItem, "commitmentitem") ?? "commitmentitem", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATIndicator, "vatindicator") ?? "vatindicator", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATProcedure, "vatprocedure") ?? "vatprocedure", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATRate, "vatrate") ?? "vatrate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PurchaseRequisitionNumber, "purchaserequisitionnumber") ?? "purchaserequisitionnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PurchaseRequisitionItemNr, "purchaserequisitionitemnr") ?? "purchaserequisitionitemnr", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@RegionId, "regionid") ?? "regionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Center, "center") ?? "center", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PEPElement, "pepelement") ?? "pepelement", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@QuantityDelivered, "quantitydelivered") ?? "quantitydelivered", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderUnitOfMeasure, "orderunitofmeasure") ?? "orderunitofmeasure", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Applicant, "applicant") ?? "applicant", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Direction, "direction") ?? "direction", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractNumber, "contractnumber") ?? "contractnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractPosition, "contractposition") ?? "contractposition", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractStartDate, "contractstartdate") ?? "contractstartdate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractEndDate, "contractenddate") ?? "contractenddate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractPlannedValue, "contractplannedvalue") ?? "contractplannedvalue", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PositionType, "positiontype") ?? "positiontype", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@SerialNumberProfile, "serialnumberprofile") ?? "serialnumberprofile", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@BatchManaged, "batchmanaged") ?? "batchmanaged", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialType, "materialtype") ?? "materialtype", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ItemGroup, "itemgroup") ?? "itemgroup", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderRequestCreatorSAPNumber, "orderrequestcreatorsapnumber") ?? "orderrequestcreatorsapnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsMultipleImputation, "ismultipleimputation") ?? "ismultipleimputation", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderMainItemStatusId, "ordermainitemstatusid") ?? "ordermainitemstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DivisionId, "divisionid") ?? "divisionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
" FROM " + ENOrderMainItemEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Id, "id") ?? "id") + " = @inParamId";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderMainItem", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(51,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderMainItemEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: GetOrderMainItemForUpdate
/// </summary>

public static async Task<RC_c4cc207f9017de4e013fabcf1e8ebeaf> GetOrderMainItemForUpdate(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_c4cc207f9017de4e013fabcf1e8ebeaf outParamRecord = default;
outParamRecord = new RC_c4cc207f9017de4e013fabcf1e8ebeaf();

using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("GetOrderMainItemForUpdate", "176ce248-4371-426c-bbd5-10d39536ee69.#GetEntityForUpdate");
using var entityActionActivity = activitySource.CreateEntityActionActivity("GetOrderMainItemForUpdate", "176ce248-4371-426c-bbd5-10d39536ee69.#GetEntityForUpdate", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
string sql =
"SELECT " +
" " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Id, "id") ?? "id", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Position, "position") ?? "position", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialCode, "materialcode") ?? "materialcode", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialDescription, "materialdescription") ?? "materialdescription", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@AssigmnentCode, "assigmnentcode") ?? "assigmnentcode", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DocumentClassId, "documentclassid") ?? "documentclassid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DeliveryDate, "deliverydate") ?? "deliverydate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Quantity, "quantity") ?? "quantity", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UnitType, "unittype") ?? "unittype", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UnitPrice, "unitprice") ?? "unitprice", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@BaseQuantity, "basequantity") ?? "basequantity", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsBlocked, "isblocked") ?? "isblocked", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsFinalDelivery, "isfinaldelivery") ?? "isfinaldelivery", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@GLAccountId, "glaccountid") ?? "glaccountid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@FundsCenter, "fundscenter") ?? "fundscenter", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Fund, "fund") ?? "fund", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CommitmentItem, "commitmentitem") ?? "commitmentitem", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATIndicator, "vatindicator") ?? "vatindicator", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATProcedure, "vatprocedure") ?? "vatprocedure", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATRate, "vatrate") ?? "vatrate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PurchaseRequisitionNumber, "purchaserequisitionnumber") ?? "purchaserequisitionnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PurchaseRequisitionItemNr, "purchaserequisitionitemnr") ?? "purchaserequisitionitemnr", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@RegionId, "regionid") ?? "regionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Center, "center") ?? "center", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PEPElement, "pepelement") ?? "pepelement", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@QuantityDelivered, "quantitydelivered") ?? "quantitydelivered", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderUnitOfMeasure, "orderunitofmeasure") ?? "orderunitofmeasure", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Applicant, "applicant") ?? "applicant", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Direction, "direction") ?? "direction", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractNumber, "contractnumber") ?? "contractnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractPosition, "contractposition") ?? "contractposition", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractStartDate, "contractstartdate") ?? "contractstartdate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractEndDate, "contractenddate") ?? "contractenddate", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractPlannedValue, "contractplannedvalue") ?? "contractplannedvalue", OutSystems.HubEdition.Extensibility.Data.DBDataType.DECIMAL) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PositionType, "positiontype") ?? "positiontype", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@SerialNumberProfile, "serialnumberprofile") ?? "serialnumberprofile", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@BatchManaged, "batchmanaged") ?? "batchmanaged", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialType, "materialtype") ?? "materialtype", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ItemGroup, "itemgroup") ?? "itemgroup", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderRequestCreatorSAPNumber, "orderrequestcreatorsapnumber") ?? "orderrequestcreatorsapnumber", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsMultipleImputation, "ismultipleimputation") ?? "ismultipleimputation", OutSystems.HubEdition.Extensibility.Data.DBDataType.BOOLEAN) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderMainItemStatusId, "ordermainitemstatusid") ?? "ordermainitemstatusid", OutSystems.HubEdition.Extensibility.Data.DBDataType.INTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DivisionId, "divisionid") ?? "divisionid", OutSystems.HubEdition.Extensibility.Data.DBDataType.LONGINTEGER) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CreatedBy, "createdby") ?? "createdby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CreatedOn, "createdon") ?? "createdon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby", OutSystems.HubEdition.Extensibility.Data.DBDataType.TEXT) + "" +
", " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Functions.ProcessAndEscapeColumnName(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon", OutSystems.HubEdition.Extensibility.Data.DBDataType.DATE_TIME) + "" +
" FROM " + ENOrderMainItemEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " " +
"WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Id, "id") ?? "id") + " = @inParamId  FOR UPDATE";
await using(var sqlCmd = trans.CreateCommand(sql)){
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
sqlCmd.CreateParameter("@inParamId", DbType.Int64, inParamId);
await using (var reader = await sqlCmd.ExecuteReaderAsync(description: "Entity Action GetOrderMainItemForUpdate", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)) {
if (await reader.ReadAsync(cancellationToken)){
outParamRecord.ReadDB(reader);
outParamRecord.AllOptimizedAttributes = new BitArray[] { new BitArray(51,false) };
} else {
throw DatabaseErrorsHelper.EntityRecordNotFound(ENOrderMainItemEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()), "inParamId");
 }
}
}
}
return outParamRecord;
}

/// <summary>
/// Action: UpdateOrderMainItem
/// </summary>

public static async Task UpdateOrderMainItem(IRequestContext requestContext,BitArray usedFields,RC_c4cc207f9017de4e013fabcf1e8ebeaf inParamSource,CancellationToken cancellationToken) {
using var appHealthMetric = AppHealthProvider.CreateServerEntityActionMetric("UpdateOrderMainItem", "176ce248-4371-426c-bbd5-10d39536ee69.#UpdateEntity");
using var entityActionActivity = activitySource.CreateEntityActionActivity("UpdateOrderMainItem", "176ce248-4371-426c-bbd5-10d39536ee69.#UpdateEntity", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord ssENOrderMainItem = inParamSource;
await using (var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken)) {
if(usedFields == null){
usedFields = new BitArray(51,true);
}
string updateSet = "UPDATE " + ENOrderMainItemEntity.LocalViewName(BuiltInFunction.GetCurrentLocale()) + " SET ";
string parameters = "";
parameters = (usedFields[1] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderMainId, "ordermainid") ?? "ordermainid") + " = @ssOrderMainId"): parameters);
parameters = (usedFields[2] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Position, "position") ?? "position") + " = @ssPosition"): parameters);
parameters = (usedFields[3] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialCode, "materialcode") ?? "materialcode") + " = @ssMaterialCode"): parameters);
parameters = (usedFields[4] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialDescription, "materialdescription") ?? "materialdescription") + " = @ssMaterialDescription"): parameters);
parameters = (usedFields[5] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@AssigmnentCode, "assigmnentcode") ?? "assigmnentcode") + " = @ssAssigmnentCode"): parameters);
parameters = (usedFields[6] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DocumentClassId, "documentclassid") ?? "documentclassid") + " = @ssDocumentClassId"): parameters);
parameters = (usedFields[7] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DeliveryDate, "deliverydate") ?? "deliverydate") + " = @ssDeliveryDate"): parameters);
parameters = (usedFields[8] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Quantity, "quantity") ?? "quantity") + " = @ssQuantity"): parameters);
parameters = (usedFields[9] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UnitType, "unittype") ?? "unittype") + " = @ssUnitType"): parameters);
parameters = (usedFields[10] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UnitPrice, "unitprice") ?? "unitprice") + " = @ssUnitPrice"): parameters);
parameters = (usedFields[11] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@BaseQuantity, "basequantity") ?? "basequantity") + " = @ssBaseQuantity"): parameters);
parameters = (usedFields[12] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted") + " = @ssIsDeleted"): parameters);
parameters = (usedFields[13] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsBlocked, "isblocked") ?? "isblocked") + " = @ssIsBlocked"): parameters);
parameters = (usedFields[14] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsFinalDelivery, "isfinaldelivery") ?? "isfinaldelivery") + " = @ssIsFinalDelivery"): parameters);
parameters = (usedFields[15] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@GLAccountId, "glaccountid") ?? "glaccountid") + " = @ssGLAccountId"): parameters);
parameters = (usedFields[16] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CostCenterId, "costcenterid") ?? "costcenterid") + " = @ssCostCenterId"): parameters);
parameters = (usedFields[17] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@FundsCenter, "fundscenter") ?? "fundscenter") + " = @ssFundsCenter"): parameters);
parameters = (usedFields[18] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Fund, "fund") ?? "fund") + " = @ssFund"): parameters);
parameters = (usedFields[19] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CommitmentItem, "commitmentitem") ?? "commitmentitem") + " = @ssCommitmentItem"): parameters);
parameters = (usedFields[20] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATIndicator, "vatindicator") ?? "vatindicator") + " = @ssVATIndicator"): parameters);
parameters = (usedFields[21] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATProcedure, "vatprocedure") ?? "vatprocedure") + " = @ssVATProcedure"): parameters);
parameters = (usedFields[22] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@VATRate, "vatrate") ?? "vatrate") + " = @ssVATRate"): parameters);
parameters = (usedFields[23] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PurchaseRequisitionNumber, "purchaserequisitionnumber") ?? "purchaserequisitionnumber") + " = @ssPurchaseRequisitionNumber"): parameters);
parameters = (usedFields[24] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PurchaseRequisitionItemNr, "purchaserequisitionitemnr") ?? "purchaserequisitionitemnr") + " = @ssPurchaseRequisitionItemNr"): parameters);
parameters = (usedFields[25] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@RegionId, "regionid") ?? "regionid") + " = @ssRegionId"): parameters);
parameters = (usedFields[26] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Center, "center") ?? "center") + " = @ssCenter"): parameters);
parameters = (usedFields[27] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PEPElement, "pepelement") ?? "pepelement") + " = @ssPEPElement"): parameters);
parameters = (usedFields[28] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@QuantityDelivered, "quantitydelivered") ?? "quantitydelivered") + " = @ssQuantityDelivered"): parameters);
parameters = (usedFields[29] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderUnitOfMeasure, "orderunitofmeasure") ?? "orderunitofmeasure") + " = @ssOrderUnitOfMeasure"): parameters);
parameters = (usedFields[30] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Applicant, "applicant") ?? "applicant") + " = @ssApplicant"): parameters);
parameters = (usedFields[31] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Direction, "direction") ?? "direction") + " = @ssDirection"): parameters);
parameters = (usedFields[32] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractNumber, "contractnumber") ?? "contractnumber") + " = @ssContractNumber"): parameters);
parameters = (usedFields[33] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractPosition, "contractposition") ?? "contractposition") + " = @ssContractPosition"): parameters);
parameters = (usedFields[34] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractStartDate, "contractstartdate") ?? "contractstartdate") + " = @ssContractStartDate"): parameters);
parameters = (usedFields[35] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractEndDate, "contractenddate") ?? "contractenddate") + " = @ssContractEndDate"): parameters);
parameters = (usedFields[36] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ContractPlannedValue, "contractplannedvalue") ?? "contractplannedvalue") + " = @ssContractPlannedValue"): parameters);
parameters = (usedFields[37] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@PositionType, "positiontype") ?? "positiontype") + " = @ssPositionType"): parameters);
parameters = (usedFields[38] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@SerialNumberProfile, "serialnumberprofile") ?? "serialnumberprofile") + " = @ssSerialNumberProfile"): parameters);
parameters = (usedFields[39] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@BatchManaged, "batchmanaged") ?? "batchmanaged") + " = @ssBatchManaged"): parameters);
parameters = (usedFields[40] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@MaterialType, "materialtype") ?? "materialtype") + " = @ssMaterialType"): parameters);
parameters = (usedFields[41] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@ItemGroup, "itemgroup") ?? "itemgroup") + " = @ssItemGroup"): parameters);
parameters = (usedFields[42] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderRequestCreatorSAPNumber, "orderrequestcreatorsapnumber") ?? "orderrequestcreatorsapnumber") + " = @ssOrderRequestCreatorSAPNumber"): parameters);
parameters = (usedFields[43] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsMultipleImputation, "ismultipleimputation") ?? "ismultipleimputation") + " = @ssIsMultipleImputation"): parameters);
parameters = (usedFields[44] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@InvoiceUsageId, "invoiceusageid") ?? "invoiceusageid") + " = @ssInvoiceUsageId"): parameters);
parameters = (usedFields[45] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@OrderMainItemStatusId, "ordermainitemstatusid") ?? "ordermainitemstatusid") + " = @ssOrderMainItemStatusId"): parameters);
parameters = (usedFields[46] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@DivisionId, "divisionid") ?? "divisionid") + " = @ssDivisionId"): parameters);
parameters = (usedFields[47] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CreatedBy, "createdby") ?? "createdby") + " = @ssCreatedBy"): parameters);
parameters = (usedFields[48] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@CreatedOn, "createdon") ?? "createdon") + " = @ssCreatedOn"): parameters);
parameters = (usedFields[49] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UpdatedBy, "updatedby") ?? "updatedby") + " = @ssUpdatedBy"): parameters);
parameters = (usedFields[50] ? (StringUtils.SuffixIfNotEmpty(parameters, ", ") + "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@UpdatedOn, "updatedon") ?? "updatedon") + " = @ssUpdatedOn"): parameters);
string whereCondition = " WHERE " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@Id, "id") ?? "id") + " = @idparam_ssENOrderMainItem_ssId_OrderMainItem";
var sql = updateSet + parameters + whereCondition;
if (string.IsNullOrEmpty(parameters)){
string dummyUpdate = "" + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted") + " = " + DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers.EscapeIdentifier(TableDetailsServiceAccessor.Instance?.GetValidatedColumnName(_EntityKeyConstants.@ConectaProveedores, _EntityKeyConstants._ConectaProveedoresEntityKeys.@OrderMainItem, _EntityKeyConstants._ConectaProveedoresEntityKeys._OrderMainItemAttributeKeys.@IsDeleted, "isdeleted") ?? "isdeleted") + "";
sql = updateSet + dummyUpdate + whereCondition;
}
await using(var sqlCmd = trans.CreateCommand(sql)){
if(usedFields[1]) {
if ((ssENOrderMainItem.ssOrderMainId==0L)) {
sqlCmd.CreateParameter("@ssOrderMainId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderMainId", DbType.Int64, ssENOrderMainItem.ssOrderMainId);

}
}
if(usedFields[2]) {
sqlCmd.CreateParameter("@ssPosition", DbType.Int32, ssENOrderMainItem.ssPosition);
}
if(usedFields[3]) {
sqlCmd.CreateParameter("@ssMaterialCode", DbType.String, ssENOrderMainItem.ssMaterialCode);
}
if(usedFields[4]) {
sqlCmd.CreateParameter("@ssMaterialDescription", DbType.String, ssENOrderMainItem.ssMaterialDescription);
}
if(usedFields[5]) {
sqlCmd.CreateParameter("@ssAssigmnentCode", DbType.String, ssENOrderMainItem.ssAssigmnentCode);
}
if(usedFields[6]) {
if ((ssENOrderMainItem.ssDocumentClassId==0L)) {
sqlCmd.CreateParameter("@ssDocumentClassId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssDocumentClassId", DbType.Int64, ssENOrderMainItem.ssDocumentClassId);

}
}
if(usedFields[7]) {
sqlCmd.CreateParameter("@ssDeliveryDate", DbType.DateTime, ssENOrderMainItem.ssDeliveryDate);
}
if(usedFields[8]) {
var QuantityParameter = sqlCmd.CreateParameter("@ssQuantity", DbType.Decimal, ssENOrderMainItem.ssQuantity);
{
    string decimalAsStr = ssENOrderMainItem.ssQuantity.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {QuantityParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[9]) {
sqlCmd.CreateParameter("@ssUnitType", DbType.String, ssENOrderMainItem.ssUnitType);
}
if(usedFields[10]) {
var UnitPriceParameter = sqlCmd.CreateParameter("@ssUnitPrice", DbType.Decimal, ssENOrderMainItem.ssUnitPrice);
{
    string decimalAsStr = ssENOrderMainItem.ssUnitPrice.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {UnitPriceParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[11]) {
sqlCmd.CreateParameter("@ssBaseQuantity", DbType.Int32, ssENOrderMainItem.ssBaseQuantity);
}
if(usedFields[12]) {
sqlCmd.CreateParameter("@ssIsDeleted", DbType.Boolean, ssENOrderMainItem.ssIsDeleted);
}
if(usedFields[13]) {
sqlCmd.CreateParameter("@ssIsBlocked", DbType.Boolean, ssENOrderMainItem.ssIsBlocked);
}
if(usedFields[14]) {
sqlCmd.CreateParameter("@ssIsFinalDelivery", DbType.Boolean, ssENOrderMainItem.ssIsFinalDelivery);
}
if(usedFields[15]) {
if ((ssENOrderMainItem.ssGLAccountId==0L)) {
sqlCmd.CreateParameter("@ssGLAccountId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssGLAccountId", DbType.Int64, ssENOrderMainItem.ssGLAccountId);

}
}
if(usedFields[16]) {
if ((ssENOrderMainItem.ssCostCenterId==0L)) {
sqlCmd.CreateParameter("@ssCostCenterId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCostCenterId", DbType.Int64, ssENOrderMainItem.ssCostCenterId);

}
}
if(usedFields[17]) {
sqlCmd.CreateParameter("@ssFundsCenter", DbType.String, ssENOrderMainItem.ssFundsCenter);
}
if(usedFields[18]) {
sqlCmd.CreateParameter("@ssFund", DbType.String, ssENOrderMainItem.ssFund);
}
if(usedFields[19]) {
sqlCmd.CreateParameter("@ssCommitmentItem", DbType.String, ssENOrderMainItem.ssCommitmentItem);
}
if(usedFields[20]) {
sqlCmd.CreateParameter("@ssVATIndicator", DbType.String, ssENOrderMainItem.ssVATIndicator);
}
if(usedFields[21]) {
sqlCmd.CreateParameter("@ssVATProcedure", DbType.String, ssENOrderMainItem.ssVATProcedure);
}
if(usedFields[22]) {
var VATRateParameter = sqlCmd.CreateParameter("@ssVATRate", DbType.Decimal, ssENOrderMainItem.ssVATRate);
{
    string decimalAsStr = ssENOrderMainItem.ssVATRate.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {VATRateParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[23]) {
sqlCmd.CreateParameter("@ssPurchaseRequisitionNumber", DbType.String, ssENOrderMainItem.ssPurchaseRequisitionNumber);
}
if(usedFields[24]) {
sqlCmd.CreateParameter("@ssPurchaseRequisitionItemNr", DbType.Int32, ssENOrderMainItem.ssPurchaseRequisitionItemNr);
}
if(usedFields[25]) {
if ((ssENOrderMainItem.ssRegionId==0L)) {
sqlCmd.CreateParameter("@ssRegionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssRegionId", DbType.Int64, ssENOrderMainItem.ssRegionId);

}
}
if(usedFields[26]) {
sqlCmd.CreateParameter("@ssCenter", DbType.String, ssENOrderMainItem.ssCenter);
}
if(usedFields[27]) {
sqlCmd.CreateParameter("@ssPEPElement", DbType.String, ssENOrderMainItem.ssPEPElement);
}
if(usedFields[28]) {
var QuantityDeliveredParameter = sqlCmd.CreateParameter("@ssQuantityDelivered", DbType.Decimal, ssENOrderMainItem.ssQuantityDelivered);
{
    string decimalAsStr = ssENOrderMainItem.ssQuantityDelivered.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {QuantityDeliveredParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[29]) {
sqlCmd.CreateParameter("@ssOrderUnitOfMeasure", DbType.String, ssENOrderMainItem.ssOrderUnitOfMeasure);
}
if(usedFields[30]) {
sqlCmd.CreateParameter("@ssApplicant", DbType.String, ssENOrderMainItem.ssApplicant);
}
if(usedFields[31]) {
sqlCmd.CreateParameter("@ssDirection", DbType.String, ssENOrderMainItem.ssDirection);
}
if(usedFields[32]) {
sqlCmd.CreateParameter("@ssContractNumber", DbType.String, ssENOrderMainItem.ssContractNumber);
}
if(usedFields[33]) {
sqlCmd.CreateParameter("@ssContractPosition", DbType.Int32, ssENOrderMainItem.ssContractPosition);
}
if(usedFields[34]) {
sqlCmd.CreateParameter("@ssContractStartDate", DbType.DateTime, ssENOrderMainItem.ssContractStartDate);
}
if(usedFields[35]) {
sqlCmd.CreateParameter("@ssContractEndDate", DbType.DateTime, ssENOrderMainItem.ssContractEndDate);
}
if(usedFields[36]) {
var ContractPlannedValueParameter = sqlCmd.CreateParameter("@ssContractPlannedValue", DbType.Decimal, ssENOrderMainItem.ssContractPlannedValue);
{
    string decimalAsStr = ssENOrderMainItem.ssContractPlannedValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
    int nrDigits = decimalAsStr.IndexOf('.') != -1 ? decimalAsStr.Length - 1 : decimalAsStr.Length;
    if (nrDigits < 37) {ContractPlannedValueParameter.Precision = Constants.DecimalTotalPrecision; 
    }
}
}
if(usedFields[37]) {
sqlCmd.CreateParameter("@ssPositionType", DbType.String, ssENOrderMainItem.ssPositionType);
}
if(usedFields[38]) {
sqlCmd.CreateParameter("@ssSerialNumberProfile", DbType.String, ssENOrderMainItem.ssSerialNumberProfile);
}
if(usedFields[39]) {
sqlCmd.CreateParameter("@ssBatchManaged", DbType.String, ssENOrderMainItem.ssBatchManaged);
}
if(usedFields[40]) {
sqlCmd.CreateParameter("@ssMaterialType", DbType.String, ssENOrderMainItem.ssMaterialType);
}
if(usedFields[41]) {
sqlCmd.CreateParameter("@ssItemGroup", DbType.String, ssENOrderMainItem.ssItemGroup);
}
if(usedFields[42]) {
sqlCmd.CreateParameter("@ssOrderRequestCreatorSAPNumber", DbType.String, ssENOrderMainItem.ssOrderRequestCreatorSAPNumber);
}
if(usedFields[43]) {
sqlCmd.CreateParameter("@ssIsMultipleImputation", DbType.Boolean, ssENOrderMainItem.ssIsMultipleImputation);
}
if(usedFields[44]) {
if ((ssENOrderMainItem.ssInvoiceUsageId==0L)) {
sqlCmd.CreateParameter("@ssInvoiceUsageId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssInvoiceUsageId", DbType.Int64, ssENOrderMainItem.ssInvoiceUsageId);

}
}
if(usedFields[45]) {
if ((ssENOrderMainItem.ssOrderMainItemStatusId==0)) {
sqlCmd.CreateParameter("@ssOrderMainItemStatusId", DbType.Int32, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssOrderMainItemStatusId", DbType.Int32, ssENOrderMainItem.ssOrderMainItemStatusId);

}
}
if(usedFields[46]) {
if ((ssENOrderMainItem.ssDivisionId==0L)) {
sqlCmd.CreateParameter("@ssDivisionId", DbType.Int64, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssDivisionId", DbType.Int64, ssENOrderMainItem.ssDivisionId);

}
}
if(usedFields[47]) {
if ((ssENOrderMainItem.ssCreatedBy=="")) {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssCreatedBy", DbType.String, ssENOrderMainItem.ssCreatedBy);

}
}
if(usedFields[48]) {
sqlCmd.CreateParameter("@ssCreatedOn", DbType.DateTime, ssENOrderMainItem.ssCreatedOn);
}
if(usedFields[49]) {
if ((ssENOrderMainItem.ssUpdatedBy=="")) {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, DBNull.Value);
} else {
sqlCmd.CreateParameter("@ssUpdatedBy", DbType.String, ssENOrderMainItem.ssUpdatedBy);

}
}
if(usedFields[50]) {
sqlCmd.CreateParameter("@ssUpdatedOn", DbType.DateTime, ssENOrderMainItem.ssUpdatedOn);
}
sqlCmd.CreateParameter("@idparam_ssENOrderMainItem_ssId_OrderMainItem", DbType.Int64, ssENOrderMainItem.ssId);
entityActionActivity.AddSqlActivityTags(sqlCmd.CommandText);
if (await sqlCmd.ExecuteNonQueryAsync(description: "Entity Action UpdateOrderMainItem", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken) <= 0) {
throw DatabaseErrorsHelper.EntityRecordNotUpdated("OrderMainItem", ssENOrderMainItem.ssId.ToString()); }}
}
return;
}

}
}
