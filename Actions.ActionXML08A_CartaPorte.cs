namespace ssConectaProveedores;

public partial class Actions {
public class lcvXML08A_CartaPorte : VarsBag {
public object inParamXMLDocument;
/// <summary>
/// Variable <code>XMLNode</code> that represents the Service Studio Object <code>XMLNode</code>
///  <p>Description: </p>
/// </summary>
public object varLcXMLNode = null;

public string resGetNumeroExterior_outParamAttributeValue = "";

public object resSelectSingleNode_Mercancias_outParamXMLNode = null;

public object resSelectSingleNode_Ubicaciones_outParamXMLNode = null;

public string resGetCalle_outParamAttributeValue = "";

public object resSelectSingleNode_Mercancia_outParamXMLNode = null;

public object resSelectSingleNode_Domicilio_outParamXMLNode = null;

public object resSelectSingleNode_CartaPorte_outParamXMLNode = null;

public object resSelectSingleNode_Ubicacion_outParamXMLNode = null;

public string resGetCentroAtencion_outParamAttributeValue = "";

public string resGetValorMercancia_outParamAttributeValue = "";

public string resGetCodigoPostal_outParamAttributeValue = "";

public string resGetDescripcion_outParamAttributeValue = "";

public object resSelectSingleNode_Complemento_outParamXMLNode = null;

public lcvXML08A_CartaPorte(object inParamXMLDocument) {
this.inParamXMLDocument = inParamXMLDocument;
}
}
public class lcoXML08A_CartaPorte : VarsBag {
public EN_9bd576a05df3846c52ce88a606aff414EntityRecord outParamInvoiceExtendedCartaPorte = new EN_9bd576a05df3846c52ce88a606aff414EntityRecord();

public lcoXML08A_CartaPorte() {
}
}
/// <summary>
/// Action <code>XML08A_CartaPorte</code> that represents the Service Studio action
///  <code>XML08A_CartaPorte</code> <p> Description: </p>
/// </summary>
public static async Task<EN_9bd576a05df3846c52ce88a606aff414EntityRecord> ActionXML08A_CartaPorte(IRequestContext requestContext,object inParamXMLDocument,CancellationToken cancellationToken) {
EN_9bd576a05df3846c52ce88a606aff414EntityRecord outParamInvoiceExtendedCartaPorte = default;
lcoXML08A_CartaPorte result = new lcoXML08A_CartaPorte();
lcvXML08A_CartaPorte localVars = new lcvXML08A_CartaPorte(inParamXMLDocument);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("XML08A_CartaPorte", "8b9b5da3-1066-4d57-9c44-1fe2665312b3"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("XML08A_CartaPorte", "8b9b5da3-1066-4d57-9c44-1fe2665312b3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// SelectSingleNode_Complemento
localVars.resSelectSingleNode_Complemento_outParamXMLNode = await Actions.ActionXMLDocument_SelectSingleNode(requestContext,localVars.inParamXMLDocument,"//*[local-name()='Complemento']",cancellationToken);

// no object?
if((!((localVars.resSelectSingleNode_Complemento_outParamXMLNode==BuiltInFunction.NullObject ())))) {
// SelectSingleNode_CartaPorte
localVars.resSelectSingleNode_CartaPorte_outParamXMLNode = await Actions.ActionXMLElement_SelectSingleNode(requestContext,localVars.resSelectSingleNode_Complemento_outParamXMLNode,"//*[local-name()='CartaPorte']",cancellationToken);

// no object?
if((!((localVars.resSelectSingleNode_CartaPorte_outParamXMLNode==BuiltInFunction.NullObject ())))) {
// SelectSingleNode_Mercancias
localVars.resSelectSingleNode_Mercancias_outParamXMLNode = await Actions.ActionXMLElement_SelectSingleNode(requestContext,localVars.resSelectSingleNode_CartaPorte_outParamXMLNode,"//*[local-name()='Mercancias']",cancellationToken);

// no object?
if(((localVars.resSelectSingleNode_Mercancias_outParamXMLNode==BuiltInFunction.NullObject ()))) {
// bypass
} else {
// SelectSingleNode_Mercancia
localVars.resSelectSingleNode_Mercancia_outParamXMLNode = await Actions.ActionXMLElement_SelectSingleNode(requestContext,localVars.resSelectSingleNode_Mercancias_outParamXMLNode,"//*[local-name()='Mercancia']",cancellationToken);

// XMLNode = SelectSingleNode_Mercancia.XMLNode
localVars.varLcXMLNode=localVars.resSelectSingleNode_Mercancia_outParamXMLNode;
// GetDescripcion
localVars.resGetDescripcion_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.varLcXMLNode,"Descripcion",cancellationToken);

// GetValorMercancia
localVars.resGetValorMercancia_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.varLcXMLNode,"ValorMercancia",cancellationToken);

// InvoiceExtendedCartaPorte.Descripcion = GetDescripcion.AttributeValue
result.outParamInvoiceExtendedCartaPorte.ssDescripcion = localVars.resGetDescripcion_outParamAttributeValue;

// InvoiceExtendedCartaPorte.ValorMercancia = Round
result.outParamInvoiceExtendedCartaPorte.ssValorMercancia = BuiltInFunction.Round (BuiltInFunction.TextToDecimal (localVars.resGetValorMercancia_outParamAttributeValue), 2);
}

// SelectSingleNode_Ubicaciones
localVars.resSelectSingleNode_Ubicaciones_outParamXMLNode = await Actions.ActionXMLElement_SelectSingleNode(requestContext,localVars.resSelectSingleNode_CartaPorte_outParamXMLNode,"//*[local-name()='Ubicaciones']",cancellationToken);

// no object?
if((!((localVars.resSelectSingleNode_Ubicaciones_outParamXMLNode==BuiltInFunction.NullObject ())))) {
// SelectSingleNode_Ubicacion
localVars.resSelectSingleNode_Ubicacion_outParamXMLNode = await Actions.ActionXMLElement_SelectSingleNode(requestContext,localVars.resSelectSingleNode_Ubicaciones_outParamXMLNode,"//*[local-name()='Ubicacion' and @TipoUbicacion='Origen']",cancellationToken);

// no object?
if((!((localVars.resSelectSingleNode_Ubicacion_outParamXMLNode==BuiltInFunction.NullObject ())))) {
// SelectSingleNode_Domicilio
localVars.resSelectSingleNode_Domicilio_outParamXMLNode = await Actions.ActionXMLElement_SelectSingleNode(requestContext,localVars.resSelectSingleNode_Ubicacion_outParamXMLNode,"//*[local-name()='Domicilio']",cancellationToken);

// no object?
if((!((localVars.resSelectSingleNode_Ubicacion_outParamXMLNode==BuiltInFunction.NullObject ())))) {
// XMLNode = SelectSingleNode_Domicilio.XMLNode
localVars.varLcXMLNode=localVars.resSelectSingleNode_Domicilio_outParamXMLNode;
// GetCentroAtencion
localVars.resGetCentroAtencion_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.varLcXMLNode,"Referencia",cancellationToken);

// GetCalle
localVars.resGetCalle_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.varLcXMLNode,"Calle",cancellationToken);

// GetNumeroExterior
localVars.resGetNumeroExterior_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.varLcXMLNode,"NumeroExterior",cancellationToken);

// GetCodigoPostal
localVars.resGetCodigoPostal_outParamAttributeValue = await Actions.ActionXMLElement_GetAttributeValue(requestContext,localVars.varLcXMLNode,"CodigoPostal",cancellationToken);

// InvoiceExtendedCartaPorte.CentroAtencion = GetCentroAtencion.AttributeValue
result.outParamInvoiceExtendedCartaPorte.ssCentroAtencion = localVars.resGetCentroAtencion_outParamAttributeValue;

// InvoiceExtendedCartaPorte.Calle = GetCalle.AttributeValue
result.outParamInvoiceExtendedCartaPorte.ssCalle = localVars.resGetCalle_outParamAttributeValue;

// InvoiceExtendedCartaPorte.NumeroExterior = GetNumeroExterior.AttributeValue
result.outParamInvoiceExtendedCartaPorte.ssNumeroExterior = localVars.resGetNumeroExterior_outParamAttributeValue;

// InvoiceExtendedCartaPorte.CodigoPostal = GetCodigoPostal.AttributeValue
result.outParamInvoiceExtendedCartaPorte.ssCodigoPostal = localVars.resGetCodigoPostal_outParamAttributeValue;
}

}

}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamInvoiceExtendedCartaPorte = result.outParamInvoiceExtendedCartaPorte;
} // inner-finally
RETURN_STATEMENT:
return outParamInvoiceExtendedCartaPorte;
}

public static class FuncActionXML08A_CartaPorte {



}


}
