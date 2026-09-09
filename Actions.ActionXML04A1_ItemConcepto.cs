namespace ssConectaProveedores;

public partial class Actions {
public class lcvXML04A1_ItemConcepto : VarsBag {
public object inParamXMLNode;
public string resGetImporte_outParamAttributeValue = "";

public string resGetValorUnitario_outParamAttributeValue = "";

public string resGetCantidad_outParamAttributeValue = "";

public string resGetDescuento_outParamAttributeValue = "";

public string resGetClaveUnidad_outParamAttributeValue = "";

public string resGetNoIdentificacion_outParamAttributeValue = "";

public string resGetClaveProdServ_outParamAttributeValue = "";

public string resGetDescripcion_outParamAttributeValue = "";

public string resGetUnidad_outParamAttributeValue = "";

public lcvXML04A1_ItemConcepto(object inParamXMLNode) {
this.inParamXMLNode = inParamXMLNode;
}
}
public class lcoXML04A1_ItemConcepto : VarsBag {
public EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord outParamInvoiceExtendedItem = new EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord();

public lcoXML04A1_ItemConcepto() {
}
}
/// <summary>
/// Action <code>XML04A1_ItemConcepto</code> that represents the Service Studio action
///  <code>XML04A1_ItemConcepto</code> <p> Description: </p>
/// </summary>
public static async Task<EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord> ActionXML04A1_ItemConcepto(IRequestContext requestContext,object inParamXMLNode,CancellationToken cancellationToken) {
EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord outParamInvoiceExtendedItem = default;
lcoXML04A1_ItemConcepto result = new lcoXML04A1_ItemConcepto();
lcvXML04A1_ItemConcepto localVars = new lcvXML04A1_ItemConcepto(inParamXMLNode);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("XML04A1_ItemConcepto", "207cf9ef-1699-4210-82db-b981dd7aec88"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("XML04A1_ItemConcepto", "207cf9ef-1699-4210-82db-b981dd7aec88", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// GetClaveProdServ
localVars.resGetClaveProdServ_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.inParamXMLNode,"ClaveProdServ",cancellationToken);

// GetNoIdentificacion
localVars.resGetNoIdentificacion_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.inParamXMLNode,"NoIdentificacion",cancellationToken);

// GetCantidad
localVars.resGetCantidad_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.inParamXMLNode,"Cantidad",cancellationToken);

// GetUnidad
localVars.resGetUnidad_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.inParamXMLNode,"Unidad",cancellationToken);

// GetClaveUnidad
localVars.resGetClaveUnidad_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.inParamXMLNode,"ClaveUnidad",cancellationToken);

// GetDescripcion
localVars.resGetDescripcion_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.inParamXMLNode,"Descripcion",cancellationToken);

// GetValorUnitario
localVars.resGetValorUnitario_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.inParamXMLNode,"ValorUnitario",cancellationToken);

// GetImporte
localVars.resGetImporte_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.inParamXMLNode,"Importe",cancellationToken);

// GetDescuento
localVars.resGetDescuento_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.inParamXMLNode,"Descuento",cancellationToken);

// InvoiceExtendedItem.ProductNumber = TextToInteger
result.outParamInvoiceExtendedItem.ssProductNumber = Convert.ToString(BuiltInFunction.TextToInteger (localVars.resGetClaveProdServ_outParamAttributeValue));

// InvoiceExtendedItem.Description = GetDescripcion.AttributeValue
result.outParamInvoiceExtendedItem.ssDescription = localVars.resGetDescripcion_outParamAttributeValue;

// InvoiceExtendedItem.MaterialCode = GetClaveUnidad.AttributeValue
result.outParamInvoiceExtendedItem.ssMaterialCode = localVars.resGetClaveUnidad_outParamAttributeValue;

// InvoiceExtendedItem.Quantity = Round
result.outParamInvoiceExtendedItem.ssQuantity = (((int)BuiltInFunction.Round (BuiltInFunction.TextToDecimal (localVars.resGetCantidad_outParamAttributeValue), 0)));

// InvoiceExtendedItem.UnityPrice = TextToDecimal
result.outParamInvoiceExtendedItem.ssUnityPrice = BuiltInFunction.TextToDecimal (localVars.resGetValorUnitario_outParamAttributeValue);
} //close CreateActionActivity using block
} // try

finally {
outParamInvoiceExtendedItem = result.outParamInvoiceExtendedItem;
} // inner-finally
RETURN_STATEMENT:
return outParamInvoiceExtendedItem;
}

public static class FuncActionXML04A1_ItemConcepto {



}


}
