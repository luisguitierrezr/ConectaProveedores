using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainOrderDetailSupplierPaymentTermsPaymentMethodsRegionRecord
public class JSONRC_03b2a2565369f3088e5267bce38cfba9 : AbstractRESTStructure<RC_03b2a2565369f3088e5267bce38cfba9> {
[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("OrderDetail")]
[JsonPropertyName("OrderDetail")]
public ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord AttrOrderDetail;

[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

[JsonProperty("PaymentTerms")]
[JsonPropertyName("PaymentTerms")]
public ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord AttrPaymentTerms;

[JsonProperty("PaymentMethods")]
[JsonPropertyName("PaymentMethods")]
public ssConectaProveedores.RestRecords.JSONEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord AttrPaymentMethods;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_03b2a2565369f3088e5267bce38cfba9() { }

public JSONRC_03b2a2565369f3088e5267bce38cfba9 (RC_03b2a2565369f3088e5267bce38cfba9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrOrderDetail = ConvertToRestWithoutDefaults(s.ssENOrderDetail, new EN_26f696e758428762fc617e811634d15dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrPaymentTerms = ConvertToRestWithoutDefaults(s.ssENPaymentTerms, new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure, config);
AttrPaymentMethods = ConvertToRestWithoutDefaults(s.ssENPaymentMethods, new EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrOrderDetail = ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure(s.ssENOrderDetail, config);
AttrSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrPaymentTerms = ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure(s.ssENPaymentTerms, config);
AttrPaymentMethods = ssConectaProveedores.RestRecords.JSONEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord.FromStructure(s.ssENPaymentMethods, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_03b2a2565369f3088e5267bce38cfba9, RC_03b2a2565369f3088e5267bce38cfba9> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_03b2a2565369f3088e5267bce38cfba9 s) => ToStructure(s, config);
}
public static RC_03b2a2565369f3088e5267bce38cfba9 ToStructure(ssConectaProveedores.RestRecords.JSONRC_03b2a2565369f3088e5267bce38cfba9 obj, IBehaviorsConfiguration config) { 
  RC_03b2a2565369f3088e5267bce38cfba9 s = new RC_03b2a2565369f3088e5267bce38cfba9();
  if(obj != null) {
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENOrderDetail = ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord.ToStructure(obj.AttrOrderDetail, config);
  s.ssENSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier, config);
  s.ssENPaymentTerms = ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.ToStructure(obj.AttrPaymentTerms, config);
  s.ssENPaymentMethods = ssConectaProveedores.RestRecords.JSONEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord.ToStructure(obj.AttrPaymentMethods, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_03b2a2565369f3088e5267bce38cfba9, ssConectaProveedores.RestRecords.JSONRC_03b2a2565369f3088e5267bce38cfba9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_03b2a2565369f3088e5267bce38cfba9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_03b2a2565369f3088e5267bce38cfba9 FromStructure(RC_03b2a2565369f3088e5267bce38cfba9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_03b2a2565369f3088e5267bce38cfba9(s, config);
}

}


