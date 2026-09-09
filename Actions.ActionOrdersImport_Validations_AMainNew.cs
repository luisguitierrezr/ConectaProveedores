namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrdersImport_Validations_AMainNew : VarsBag {
public ST_9c87dd52bd762501ef8a064794927f08Structure inParami_Data;
public RC_06ae1f23d9c7cedfe36d2b236ac6d94c inParamResult;
public lcvOrdersImport_Validations_AMainNew(ST_9c87dd52bd762501ef8a064794927f08Structure inParami_Data, RC_06ae1f23d9c7cedfe36d2b236ac6d94c inParamResult) {
this.inParami_Data = inParami_Data;
this.inParamResult = inParamResult;
}
}
public class lcoOrdersImport_Validations_AMainNew : VarsBag {
public ST_5a17d82af8397abda9cf3915ce9c082fStructure outParamo_ValidationResult = new ST_5a17d82af8397abda9cf3915ce9c082fStructure();

public lcoOrdersImport_Validations_AMainNew() {
}
}
/// <summary>
/// Action <code>OrdersImport_Validations_AMainNew</code> that represents the Service Studio action
///  <code>OrdersImport_Validations_AMainNew</code> <p> Description: </p>
/// </summary>
public static async Task<ST_5a17d82af8397abda9cf3915ce9c082fStructure> ActionOrdersImport_Validations_AMainNew(IRequestContext requestContext,ST_9c87dd52bd762501ef8a064794927f08Structure inParami_Data,RC_06ae1f23d9c7cedfe36d2b236ac6d94c inParamResult,CancellationToken cancellationToken) {
ST_5a17d82af8397abda9cf3915ce9c082fStructure outParamo_ValidationResult = default;
lcoOrdersImport_Validations_AMainNew result = new lcoOrdersImport_Validations_AMainNew();
lcvOrdersImport_Validations_AMainNew localVars = new lcvOrdersImport_Validations_AMainNew(inParami_Data, inParamResult);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrdersImport_Validations_AMainNew", "d19a3263-39ad-486d-9713-f537f4de310e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrdersImport_Validations_AMainNew", "d19a3263-39ad-486d-9713-f537f4de310e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Order Date
if(((!(await Functions.ActionDateValidate(requestContext,localVars.inParami_Data.ssOrderDate,((((string)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportDefaultDateFormat]))),false,cancellationToken)).ssIsValid))) {
// 010
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 010 - " + "Error validating Order" + " " + i_Data.OrderNumber + " - " + "field Order Date" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((("E - 010 - "+AppUtils.GetStringResource("FUzolNq37kGIm0jE44B2eQ#Value.99423321.1", "Error validating Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("FUzolNq37kGIm0jE44B2eQ#Value.-1254539162.1", "field Order Date"))+".");
} else {
// Supplier Number
if(((localVars.inParami_Data.ssSupplierNumber==""))) {
// 011
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 011 - " + "Error validating Order" + " " + i_Data.OrderNumber + " - " + "field Supplier Number" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((("E - 011 - "+AppUtils.GetStringResource("xWFOc5HT9UewxZIPDnwkOQ#Value.99423321.1", "Error validating Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("xWFOc5HT9UewxZIPDnwkOQ#Value.-862013193.1", "field Supplier Number"))+".");
} else {
// Company Code
if((((localVars.inParami_Data.ssCompanyCode=="")||(localVars.inParamResult.ssCompanyId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))))) {
// 012
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 012 - " + "Error validating Order" + " " + i_Data.OrderNumber + " - " + "field Company Code" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((("E - 012 - "+AppUtils.GetStringResource("i7eNP6orDkiHYGmvD6XP5Q#Value.99423321.1", "Error validating Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("i7eNP6orDkiHYGmvD6XP5Q#Value.-1251506858.1", "field Company Code"))+".");
} else {
// Class Document
if((((localVars.inParami_Data.ssClassDocument!="")&&(localVars.inParamResult.ssDocumentTypeId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))))) {
// 013
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 013 - " + "Error validating Order" + " " + i_Data.OrderNumber + " - " + "field Class Document" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((("E - 013 - "+AppUtils.GetStringResource("VPPeWlcTGkS4xDvEtnb7vg#Value.99423321.1", "Error validating Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("VPPeWlcTGkS4xDvEtnb7vg#Value.-1726041367.1", "field Class Document"))+".");
} else {
// Country Code
if(((localVars.inParami_Data.ssCountryCode==""))) {
// 016
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 016 - " + "Error validating Order" + " " + i_Data.OrderNumber + " - " + "field Country Code" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((("E - 016 - "+AppUtils.GetStringResource("0jbV9Oa_TkuuI4MZJGmTTw#Value.99423321.1", "Error validating Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("0jbV9Oa_TkuuI4MZJGmTTw#Value.-1200000547.1", "field Country Code"))+".");
} else {
// Exchange Rate
if(((localVars.inParami_Data.ssExchangeRate==(((decimal)0))))) {
// 017
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 017 - " + "Error validating Order" + " " + i_Data.OrderNumber + " - " + "field Exchange Rate" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((("E - 017 - "+AppUtils.GetStringResource("HDZrYdbgQ0C7MhFgRwnbbA#Value.99423321.1", "Error validating Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("HDZrYdbgQ0C7MhFgRwnbbA#Value.1646741527.1", "field Exchange Rate"))+".");
} else {
// CurrencyCode
if((((localVars.inParami_Data.ssCurrencyCode!="")&&(localVars.inParamResult.ssCurrencyId==BuiltInFunction.NullTextIdentifier ())))) {
// 018
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 018 - " + "Error validating Order" + " " + i_Data.OrderNumber + " - " + "field Currency Code" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((("E - 018 - "+AppUtils.GetStringResource("uJPCuIUIy0+W16reRHuIpw#Value.99423321.1", "Error validating Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("uJPCuIUIy0+W16reRHuIpw#Value.1373916150.1", "field Currency Code"))+".");
} else {
// Supplier Name
if(((localVars.inParami_Data.ssSupplierName==""))) {
// 019
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 019 - " + "Error validating Order" + " " + i_Data.OrderNumber + " - " + "field Supplier Name" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((("E - 019 - "+AppUtils.GetStringResource("YsEKnimZHU2PIYVW9estVw#Value.99423321.1", "Error validating Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("YsEKnimZHU2PIYVW9estVw#Value.-1945048135.1", "field Supplier Name"))+".");
} else {
// Deleted Indicator
if((((BuiltInFunction.Trim (localVars.inParami_Data.ssDeletedIndicator)!="")&&(BuiltInFunction.ToUpper (localVars.inParami_Data.ssDeletedIndicator)!="C")))) {
// 015
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 015 - " + "Error validating Order" + " " + i_Data.OrderNumber + " - " + "field Deleted Indicator" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((("E - 015 - "+AppUtils.GetStringResource("m+v4Io4UGE2COgC0hpzUAg#Value.99423321.1", "Error validating Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("m+v4Io4UGE2COgC0hpzUAg#Value.-490848030.1", "field Deleted Indicator"))+".");
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

} //close CreateActionActivity using block
} // try

finally {
outParamo_ValidationResult = result.outParamo_ValidationResult;
} // inner-finally
RETURN_STATEMENT:
return outParamo_ValidationResult;
}

public static class FuncActionOrdersImport_Validations_AMainNew {



}


}
