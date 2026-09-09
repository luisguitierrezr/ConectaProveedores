namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrdersImport_Validations_BItems : VarsBag {
public ST_9c87dd52bd762501ef8a064794927f08Structure inParami_Data;
public Actions.lcoGetItemIdentifiersAndCreateIfNotExists resGetItemIdentifiersAndCreateIfNotExists =  new Actions.lcoGetItemIdentifiersAndCreateIfNotExists();
public lcvOrdersImport_Validations_BItems(ST_9c87dd52bd762501ef8a064794927f08Structure inParami_Data) {
this.inParami_Data = inParami_Data;
}
}
public class lcoOrdersImport_Validations_BItems : VarsBag {
public ST_5a17d82af8397abda9cf3915ce9c082fStructure outParamo_ValidationResult = new ST_5a17d82af8397abda9cf3915ce9c082fStructure();

public lcoOrdersImport_Validations_BItems() {
}
}
/// <summary>
/// Action <code>OrdersImport_Validations_BItems</code> that represents the Service Studio action
///  <code>OrdersImport_Validations_BItems</code> <p> Description: </p>
/// </summary>
public static async Task<ST_5a17d82af8397abda9cf3915ce9c082fStructure> ActionOrdersImport_Validations_BItems(IRequestContext requestContext,ST_9c87dd52bd762501ef8a064794927f08Structure inParami_Data,CancellationToken cancellationToken) {
ST_5a17d82af8397abda9cf3915ce9c082fStructure outParamo_ValidationResult = default;
lcoOrdersImport_Validations_BItems result = new lcoOrdersImport_Validations_BItems();
lcvOrdersImport_Validations_BItems localVars = new lcvOrdersImport_Validations_BItems(inParami_Data);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrdersImport_Validations_BItems", "3c68a9b7-8ed5-4999-9814-c7e11fe0b7ad"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrdersImport_Validations_BItems", "3c68a9b7-8ed5-4999-9814-c7e11fe0b7ad", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// GetItemIdentifiersAndCreateIfNotExists
localVars.resGetItemIdentifiersAndCreateIfNotExists.outParamResult = await Actions.ActionGetItemIdentifiersAndCreateIfNotExists(requestContext,localVars.inParami_Data,true,cancellationToken);

// ImputationCode
if(((((((((BuiltInFunction.Trim (BuiltInFunction.ToUpper (localVars.inParami_Data.ssOrderItems.CurrentRec.ssImputationCode))!="")&&(BuiltInFunction.Trim (BuiltInFunction.ToUpper (localVars.inParami_Data.ssOrderItems.CurrentRec.ssImputationCode))!="A"))&&(BuiltInFunction.Trim (BuiltInFunction.ToUpper (localVars.inParami_Data.ssOrderItems.CurrentRec.ssImputationCode))!="Q"))&&(BuiltInFunction.Trim (BuiltInFunction.ToUpper (localVars.inParami_Data.ssOrderItems.CurrentRec.ssImputationCode))!="P"))&&(BuiltInFunction.Trim (BuiltInFunction.ToUpper (localVars.inParami_Data.ssOrderItems.CurrentRec.ssImputationCode))!="W"))&&(BuiltInFunction.Trim (BuiltInFunction.ToUpper (localVars.inParami_Data.ssOrderItems.CurrentRec.ssImputationCode))!="F"))&&(BuiltInFunction.Trim (BuiltInFunction.ToUpper (localVars.inParami_Data.ssOrderItems.CurrentRec.ssImputationCode))!="U")))) {
// 100
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 100 - " + "Error validating Order Item" + " " + i_Data.OrderItems.Current.Position + " " + "in Order" + " " + i_Data.OrderNumber + " - " + "field Imputation Code" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((((((("E - 100 - "+AppUtils.GetStringResource("Nt59itmC20qsH+xvYHWw4g#Value.1625594522.1", "Error validating Order Item"))+" ")+Convert.ToString(localVars.inParami_Data.ssOrderItems.CurrentRec.ssPosition))+" ")+AppUtils.GetStringResource("Nt59itmC20qsH+xvYHWw4g#Value.-1854764941.1", "in Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("Nt59itmC20qsH+xvYHWw4g#Value.-194043203.1", "field Imputation Code"))+".");
} else {
// Document Class
if((((BuiltInFunction.Trim (localVars.inParami_Data.ssOrderItems.CurrentRec.ssDocumentClass)!="")&&(localVars.resGetItemIdentifiersAndCreateIfNotExists.outParamResult.ssDocumentClassId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))))) {
// 101
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 101 - " + "Error validating Order Item" + " " + i_Data.OrderItems.Current.Position + " " + "in Order" + " " + i_Data.OrderNumber + " - " + "field Document Class" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((((((("E - 101 - "+AppUtils.GetStringResource("JCKRLbm+kUiBvsGtw0Kf0A#Value.1625594522.1", "Error validating Order Item"))+" ")+Convert.ToString(localVars.inParami_Data.ssOrderItems.CurrentRec.ssPosition))+" ")+AppUtils.GetStringResource("JCKRLbm+kUiBvsGtw0Kf0A#Value.-1854764941.1", "in Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("JCKRLbm+kUiBvsGtw0Kf0A#Value.1522941465.1", "field Document Class"))+".");
} else {
// Quantity
if(((localVars.inParami_Data.ssOrderItems.CurrentRec.ssQuantity==(((decimal)0))))) {
// 102
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 102 - " + "Error validating Order Item" + " " + i_Data.OrderItems.Current.Position + " " + "in Order" + " " + i_Data.OrderNumber + " - " + "field Quantity" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((((((("E - 102 - "+AppUtils.GetStringResource("cqYTSYBZfkWLzLCHK0wSdg#Value.1625594522.1", "Error validating Order Item"))+" ")+Convert.ToString(localVars.inParami_Data.ssOrderItems.CurrentRec.ssPosition))+" ")+AppUtils.GetStringResource("cqYTSYBZfkWLzLCHK0wSdg#Value.-1854764941.1", "in Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("cqYTSYBZfkWLzLCHK0wSdg#Value.1479442705.1", "field Quantity"))+".");
} else {
// Unit Price
if(((BuiltInFunction.DecimalToText(localVars.inParami_Data.ssOrderItems.CurrentRec.ssUnitPrice)==""))) {
// 103
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 103 - " + "Error validating Order Item" + " " + i_Data.OrderItems.Current.Position + " " + "in Order" + " " + i_Data.OrderNumber + " - " + "field Unit Price" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((((((("E - 103 - "+AppUtils.GetStringResource("pUQYNZkTRk6kAsxBcObxZg#Value.1625594522.1", "Error validating Order Item"))+" ")+Convert.ToString(localVars.inParami_Data.ssOrderItems.CurrentRec.ssPosition))+" ")+AppUtils.GetStringResource("pUQYNZkTRk6kAsxBcObxZg#Value.-1854764941.1", "in Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("pUQYNZkTRk6kAsxBcObxZg#Value.-1248883053.1", "field Unit Price"))+".");
} else {
// Base Quantity
if(((localVars.inParami_Data.ssOrderItems.CurrentRec.ssBaseQuantity==0))) {
// 104
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 104 - " + "Error validating Order Item" + " " + i_Data.OrderItems.Current.Position + " " + "in Order" + " " + i_Data.OrderNumber + " - " + "field Base Quantity" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((((((("E - 104 - "+AppUtils.GetStringResource("zjkEEKTLSkuxW9dy9UxCdQ#Value.1625594522.1", "Error validating Order Item"))+" ")+Convert.ToString(localVars.inParami_Data.ssOrderItems.CurrentRec.ssPosition))+" ")+AppUtils.GetStringResource("zjkEEKTLSkuxW9dy9UxCdQ#Value.-1854764941.1", "in Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("zjkEEKTLSkuxW9dy9UxCdQ#Value.-816610220.1", "field Base Quantity"))+".");
} else {
// Change Indicator
if(((((BuiltInFunction.Trim (localVars.inParami_Data.ssOrderItems.CurrentRec.ssChangeIndicator)!="")&&(BuiltInFunction.Trim (BuiltInFunction.ToUpper (localVars.inParami_Data.ssOrderItems.CurrentRec.ssChangeIndicator))!="L"))&&(BuiltInFunction.Trim (BuiltInFunction.ToUpper (localVars.inParami_Data.ssOrderItems.CurrentRec.ssChangeIndicator))!="S")))) {
// 105
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 105 - " + "Error validating Order Item" + " " + i_Data.OrderItems.Current.Position + " " + "in Order" + " " + i_Data.OrderNumber + " - " + "field Change Indicator" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((((((("E - 105 - "+AppUtils.GetStringResource("N8715hELfk+o9xFLx9Kznw#Value.1625594522.1", "Error validating Order Item"))+" ")+Convert.ToString(localVars.inParami_Data.ssOrderItems.CurrentRec.ssPosition))+" ")+AppUtils.GetStringResource("N8715hELfk+o9xFLx9Kznw#Value.-1854764941.1", "in Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("N8715hELfk+o9xFLx9Kznw#Value.293761029.1", "field Change Indicator"))+".");
} else {
// Delivery Date
if(((!(await Functions.ActionDateValidate(requestContext,localVars.inParami_Data.ssOrderItems.CurrentRec.ssDeliveryDate,((((string)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportDefaultDateFormat]))),false,cancellationToken)).ssIsValid))) {
// 106
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 106 - " + "Error validating Order Item" + " " + i_Data.OrderItems.Current.Position + " " + "in Order" + " " + i_Data.OrderNumber + " - " + "field Delivery Date" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((((((("E - 106 - "+AppUtils.GetStringResource("Xtxq47ekBkOToy0f0Kanew#Value.1625594522.1", "Error validating Order Item"))+" ")+Convert.ToString(localVars.inParami_Data.ssOrderItems.CurrentRec.ssPosition))+" ")+AppUtils.GetStringResource("Xtxq47ekBkOToy0f0Kanew#Value.-1854764941.1", "in Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("Xtxq47ekBkOToy0f0Kanew#Value.-59091020.1", "field Delivery Date"))+".");
} else {
// Final Delivery
if((((BuiltInFunction.Trim (localVars.inParami_Data.ssOrderItems.CurrentRec.ssFinalDelivery)!="")&&(BuiltInFunction.ToUpper (localVars.inParami_Data.ssOrderItems.CurrentRec.ssFinalDelivery)!="X")))) {
// 107
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 107 - " + "Error validating Order Item" + " " + i_Data.OrderItems.Current.Position + " " + "in Order" + " " + i_Data.OrderNumber + " - " + "field Final Delivery" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((((((("E - 107 - "+AppUtils.GetStringResource("xNZqVnz6fUmE_1Z2AdkJHQ#Value.1625594522.1", "Error validating Order Item"))+" ")+Convert.ToString(localVars.inParami_Data.ssOrderItems.CurrentRec.ssPosition))+" ")+AppUtils.GetStringResource("xNZqVnz6fUmE_1Z2AdkJHQ#Value.-1854764941.1", "in Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("xNZqVnz6fUmE_1Z2AdkJHQ#Value.-1361706108.1", "field Final Delivery"))+".");
} else {
// Cost Center
if(((((BuiltInFunction.Trim (localVars.inParami_Data.ssOrderItems.CurrentRec.ssCostCenter)!="")&&(BuiltInFunction.Trim (localVars.inParami_Data.ssOrderItems.CurrentRec.ssCostCenter)!="IMPUT-MULT"))&&(localVars.resGetItemIdentifiersAndCreateIfNotExists.outParamResult.ssCostCenterSAPId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))))) {
// 108
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 108 - " + "Error validating Order Item" + " " + i_Data.OrderItems.Current.Position + " " + "in Order" + " " + i_Data.OrderNumber + " - " + "field Cost Center" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((((((("E - 108 - "+AppUtils.GetStringResource("D9Lr6wTtdkG17xrDoFEwuw#Value.1625594522.1", "Error validating Order Item"))+" ")+Convert.ToString(localVars.inParami_Data.ssOrderItems.CurrentRec.ssPosition))+" ")+AppUtils.GetStringResource("D9Lr6wTtdkG17xrDoFEwuw#Value.-1854764941.1", "in Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("D9Lr6wTtdkG17xrDoFEwuw#Value.744476130.1", "field Cost Center"))+".");
} else {
// VAT Indicator
if(((localVars.inParami_Data.ssOrderItems.CurrentRec.ssVATIndicator==""))) {
// 109
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 109 - " + "Error validating Order Item" + " " + i_Data.OrderItems.Current.Position + " " + "in Order" + " " + i_Data.OrderNumber + " - " + "field VAT Indicator" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((((((("E - 109 - "+AppUtils.GetStringResource("IoKVB1QfEEmJwX_y1tV1Yg#Value.1625594522.1", "Error validating Order Item"))+" ")+Convert.ToString(localVars.inParami_Data.ssOrderItems.CurrentRec.ssPosition))+" ")+AppUtils.GetStringResource("IoKVB1QfEEmJwX_y1tV1Yg#Value.-1854764941.1", "in Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("IoKVB1QfEEmJwX_y1tV1Yg#Value.-1458606862.1", "field VAT Indicator"))+".");
} else {
// Business Area
if((((localVars.inParami_Data.ssOrderItems.CurrentRec.ssBusinessArea!="")&&(localVars.resGetItemIdentifiersAndCreateIfNotExists.outParamResult.ssDivisionId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))))) {
// 110
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 110 - " + "Error validating Order Item" + " " + i_Data.OrderItems.Current.Position + " " + "in Order" + " " + i_Data.OrderNumber + " - " + "field Business Area" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((((((("E - 110 - "+AppUtils.GetStringResource("v9qSq4cZ3E6rZ3mDm0lUxw#Value.1625594522.1", "Error validating Order Item"))+" ")+Convert.ToString(localVars.inParami_Data.ssOrderItems.CurrentRec.ssPosition))+" ")+AppUtils.GetStringResource("v9qSq4cZ3E6rZ3mDm0lUxw#Value.-1854764941.1", "in Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("v9qSq4cZ3E6rZ3mDm0lUxw#Value.894702663.1", "field Business Area"))+".");
} else {
// VAT Rate
if(((BuiltInFunction.DecimalToText(localVars.inParami_Data.ssOrderItems.CurrentRec.ssVATRate)==""))) {
// 111
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 111 - " + "Error validating Order Item" + " " + i_Data.OrderItems.Current.Position + " " + "in Order" + " " + i_Data.OrderNumber + " - " + "field VAT Rate" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((((((("E - 111 - "+AppUtils.GetStringResource("ytig2UfpTUGe2oyTiE5f2g#Value.1625594522.1", "Error validating Order Item"))+" ")+Convert.ToString(localVars.inParami_Data.ssOrderItems.CurrentRec.ssPosition))+" ")+AppUtils.GetStringResource("ytig2UfpTUGe2oyTiE5f2g#Value.-1854764941.1", "in Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("ytig2UfpTUGe2oyTiE5f2g#Value.-2042192867.1", "field VAT Rate"))+".");
} else {
// UMP
if(((localVars.inParami_Data.ssOrderItems.CurrentRec.ssUMP==""))) {
// 113
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 113 - " + "Error validating Order Item" + " " + i_Data.OrderItems.Current.Position + " " + "in Order" + " " + i_Data.OrderNumber + " - " + "field UMP" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((((((("E - 113 - "+AppUtils.GetStringResource("7_fyHcJM8kKQAcml0Kd0rA#Value.1625594522.1", "Error validating Order Item"))+" ")+Convert.ToString(localVars.inParami_Data.ssOrderItems.CurrentRec.ssPosition))+" ")+AppUtils.GetStringResource("7_fyHcJM8kKQAcml0Kd0rA#Value.-1854764941.1", "in Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+"field UMP")+".");
} else {
// Contract Start Date
if(((!(await Functions.ActionDateValidate(requestContext,localVars.inParami_Data.ssOrderItems.CurrentRec.ssContractStartDate,((((string)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportDefaultDateFormat]))),false,cancellationToken)).ssIsValid))) {
// 114
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 114 - " + "Error validating Order Item" + " " + i_Data.OrderItems.Current.Position + " " + "in Order" + " " + i_Data.OrderNumber + " - " + "field Contract Start Date" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((((((("E - 114 - "+AppUtils.GetStringResource("R3RcIpvv8UqzxF16FKDWAQ#Value.1625594522.1", "Error validating Order Item"))+" ")+Convert.ToString(localVars.inParami_Data.ssOrderItems.CurrentRec.ssPosition))+" ")+AppUtils.GetStringResource("R3RcIpvv8UqzxF16FKDWAQ#Value.-1854764941.1", "in Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("R3RcIpvv8UqzxF16FKDWAQ#Value.-540601228.1", "field Contract Start Date"))+".");
} else {
// Contract End Date
if(((!(await Functions.ActionDateValidate(requestContext,localVars.inParami_Data.ssOrderItems.CurrentRec.ssContractEndDate,((((string)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportDefaultDateFormat]))),false,cancellationToken)).ssIsValid))) {
// 115
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 115 - " + "Error validating Order Item" + " " + i_Data.OrderItems.Current.Position + " " + "in Order" + " " + i_Data.OrderNumber + " - " + "field Contract End Date" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((((((("E - 115 - "+AppUtils.GetStringResource("DLjenlGGwkWtI99KB5vu9g#Value.1625594522.1", "Error validating Order Item"))+" ")+Convert.ToString(localVars.inParami_Data.ssOrderItems.CurrentRec.ssPosition))+" ")+AppUtils.GetStringResource("DLjenlGGwkWtI99KB5vu9g#Value.-1854764941.1", "in Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("DLjenlGGwkWtI99KB5vu9g#Value.-1953038949.1", "field Contract End Date"))+".");
} else {
// Position Type
if((((((((((((((((BuiltInFunction.Trim (localVars.inParami_Data.ssOrderItems.CurrentRec.ssPositionType)!="")&&(BuiltInFunction.ToUpper (localVars.inParami_Data.ssOrderItems.CurrentRec.ssPositionType)!=Convert.ToString(0)))&&(BuiltInFunction.ToUpper (localVars.inParami_Data.ssOrderItems.CurrentRec.ssPositionType)!="P"))&&(BuiltInFunction.ToUpper (localVars.inParami_Data.ssOrderItems.CurrentRec.ssPositionType)!=Convert.ToString(1)))&&(BuiltInFunction.ToUpper (localVars.inParami_Data.ssOrderItems.CurrentRec.ssPositionType)!="C"))&&(BuiltInFunction.ToUpper (localVars.inParami_Data.ssOrderItems.CurrentRec.ssPositionType)!=Convert.ToString(2)))&&(BuiltInFunction.ToUpper (localVars.inParami_Data.ssOrderItems.CurrentRec.ssPositionType)!="L"))&&(BuiltInFunction.ToUpper (localVars.inParami_Data.ssOrderItems.CurrentRec.ssPositionType)!=Convert.ToString(3)))&&(BuiltInFunction.ToUpper (localVars.inParami_Data.ssOrderItems.CurrentRec.ssPositionType)!="I"))&&(BuiltInFunction.ToUpper (localVars.inParami_Data.ssOrderItems.CurrentRec.ssPositionType)!=Convert.ToString(5)))&&(BuiltInFunction.ToUpper (localVars.inParami_Data.ssOrderItems.CurrentRec.ssPositionType)!="T"))&&(BuiltInFunction.ToUpper (localVars.inParami_Data.ssOrderItems.CurrentRec.ssPositionType)!=Convert.ToString(6)))&&(BuiltInFunction.ToUpper (localVars.inParami_Data.ssOrderItems.CurrentRec.ssPositionType)!="F"))&&(BuiltInFunction.ToUpper (localVars.inParami_Data.ssOrderItems.CurrentRec.ssPositionType)!=Convert.ToString(9))))) {
// 116
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 116 - " + "Error validating Order Item" + " " + i_Data.OrderItems.Current.Position + " " + "in Order" + " " + i_Data.OrderNumber + " - " + "field Position Type" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((((((("E - 116 - "+AppUtils.GetStringResource("2ULE+9KIM0C_Zol0kuBmBQ#Value.1625594522.1", "Error validating Order Item"))+" ")+Convert.ToString(localVars.inParami_Data.ssOrderItems.CurrentRec.ssPosition))+" ")+AppUtils.GetStringResource("2ULE+9KIM0C_Zol0kuBmBQ#Value.-1854764941.1", "in Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("2ULE+9KIM0C_Zol0kuBmBQ#Value.1331393323.1", "field Position Type"))+".");
} else {
// Serial Number Profile
if((((BuiltInFunction.Trim (localVars.inParami_Data.ssOrderItems.CurrentRec.ssSerialNumberProfile)!="")&&(BuiltInFunction.ToUpper (localVars.inParami_Data.ssOrderItems.CurrentRec.ssSerialNumberProfile)!="Z003")))) {
// 117
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 117 - " + "Error validating Order Item" + " " + i_Data.OrderItems.Current.Position + " " + "in Order" + " " + i_Data.OrderNumber + " - " + "field Serial Number Profile" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((((((("E - 117 - "+AppUtils.GetStringResource("TWnjUk+FKEmXs_uueUtHYQ#Value.1625594522.1", "Error validating Order Item"))+" ")+Convert.ToString(localVars.inParami_Data.ssOrderItems.CurrentRec.ssPosition))+" ")+AppUtils.GetStringResource("TWnjUk+FKEmXs_uueUtHYQ#Value.-1854764941.1", "in Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("TWnjUk+FKEmXs_uueUtHYQ#Value.1304239288.1", "field Serial Number Profile"))+".");
} else {
// Batch Managed
if((((BuiltInFunction.Trim (localVars.inParami_Data.ssOrderItems.CurrentRec.ssBatchManaged)!="")&&(BuiltInFunction.ToUpper (localVars.inParami_Data.ssOrderItems.CurrentRec.ssBatchManaged)!="X")))) {
// 118
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 118 - " + "Error validating Order Item" + " " + i_Data.OrderItems.Current.Position + " " + "in Order" + " " + i_Data.OrderNumber + " - " + "field Batch Managed" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((((((("E - 118 - "+AppUtils.GetStringResource("koRpFMadDkaHpDmBsCn9kA#Value.1625594522.1", "Error validating Order Item"))+" ")+Convert.ToString(localVars.inParami_Data.ssOrderItems.CurrentRec.ssPosition))+" ")+AppUtils.GetStringResource("koRpFMadDkaHpDmBsCn9kA#Value.-1854764941.1", "in Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("koRpFMadDkaHpDmBsCn9kA#Value.147392467.1", "field Batch Managed"))+".");
} else {
// o_ValidationResult.HasSuccess = True
result.outParamo_ValidationResult.ssHasSuccess = true;
}

}

}

}

}

}

}

}

}

}

}

}

}

}

}

}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamo_ValidationResult = result.outParamo_ValidationResult;
} // inner-finally
RETURN_STATEMENT:
return outParamo_ValidationResult;
}

public static class FuncActionOrdersImport_Validations_BItems {



}


}
