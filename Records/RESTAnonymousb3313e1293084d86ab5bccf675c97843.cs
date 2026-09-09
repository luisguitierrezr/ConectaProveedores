using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainOrderDetailSupplierPaymentTermsPaymentMethodsRegionRecord
public class RESTRC_03b2a2565369f3088e5267bce38cfba9 : AbstractRESTStructure<RC_03b2a2565369f3088e5267bce38cfba9> {
[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("OrderDetail")]
public ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord AttrOrderDetail;

[JsonProperty("Supplier")]
public ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

[JsonProperty("PaymentTerms")]
public ssConectaProveedores.RestRecords.RESTEN_17720044fda96c0c2d8d0760c429f48aEntityRecord AttrPaymentTerms;

[JsonProperty("PaymentMethods")]
public ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord AttrPaymentMethods;

[JsonProperty("Region")]
public ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public RESTRC_03b2a2565369f3088e5267bce38cfba9() { }

public RESTRC_03b2a2565369f3088e5267bce38cfba9 (RC_03b2a2565369f3088e5267bce38cfba9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrOrderDetail = ConvertToRestWithoutDefaults(s.ssENOrderDetail, new EN_26f696e758428762fc617e811634d15dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrPaymentTerms = ConvertToRestWithoutDefaults(s.ssENPaymentTerms, new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure, config);
AttrPaymentMethods = ConvertToRestWithoutDefaults(s.ssENPaymentMethods, new EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrOrderDetail = ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure(s.ssENOrderDetail, config);
AttrSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrPaymentTerms = ssConectaProveedores.RestRecords.RESTEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure(s.ssENPaymentTerms, config);
AttrPaymentMethods = ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord.FromStructure(s.ssENPaymentMethods, config);
AttrRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static RC_03b2a2565369f3088e5267bce38cfba9 ToStructure(ssConectaProveedores.RestRecords.RESTRC_03b2a2565369f3088e5267bce38cfba9 obj) { 
  RC_03b2a2565369f3088e5267bce38cfba9 s = new RC_03b2a2565369f3088e5267bce38cfba9();
  if(obj != null) {
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  s.ssENOrderDetail = ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord.ToStructure(obj.AttrOrderDetail);
  s.ssENSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier);
  s.ssENPaymentTerms = ssConectaProveedores.RestRecords.RESTEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.ToStructure(obj.AttrPaymentTerms);
  s.ssENPaymentMethods = ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord.ToStructure(obj.AttrPaymentMethods);
  s.ssENRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion);
  }
  return s;
}

public static Func<RC_03b2a2565369f3088e5267bce38cfba9, ssConectaProveedores.RestRecords.RESTRC_03b2a2565369f3088e5267bce38cfba9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_03b2a2565369f3088e5267bce38cfba9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_03b2a2565369f3088e5267bce38cfba9 FromStructure(RC_03b2a2565369f3088e5267bce38cfba9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_03b2a2565369f3088e5267bce38cfba9(s, config);
}

}


