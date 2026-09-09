using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioOrderCostCenterOrderAccountingOrderMainOrderDetailSupplierRegionRecord
public class JSONRC_f049d8b2272822e744e04ef94d71a8ef : AbstractRESTStructure<RC_f049d8b2272822e744e04ef94d71a8ef> {
[JsonProperty("Folio")]
[JsonPropertyName("Folio")]
public ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("OrderCostCenter")]
[JsonPropertyName("OrderCostCenter")]
public ssConectaProveedores.RestRecords.JSONEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord AttrOrderCostCenter;

[JsonProperty("OrderAccounting")]
[JsonPropertyName("OrderAccounting")]
public ssConectaProveedores.RestRecords.JSONEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord AttrOrderAccounting;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("OrderDetail")]
[JsonPropertyName("OrderDetail")]
public ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord AttrOrderDetail;

[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_f049d8b2272822e744e04ef94d71a8ef() { }

public JSONRC_f049d8b2272822e744e04ef94d71a8ef (RC_f049d8b2272822e744e04ef94d71a8ef s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrOrderCostCenter = ConvertToRestWithoutDefaults(s.ssENOrderCostCenter, new EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord.FromStructure, config);
AttrOrderAccounting = ConvertToRestWithoutDefaults(s.ssENOrderAccounting, new EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrOrderDetail = ConvertToRestWithoutDefaults(s.ssENOrderDetail, new EN_26f696e758428762fc617e811634d15dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrOrderCostCenter = ssConectaProveedores.RestRecords.JSONEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord.FromStructure(s.ssENOrderCostCenter, config);
AttrOrderAccounting = ssConectaProveedores.RestRecords.JSONEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord.FromStructure(s.ssENOrderAccounting, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrOrderDetail = ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure(s.ssENOrderDetail, config);
AttrSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_f049d8b2272822e744e04ef94d71a8ef, RC_f049d8b2272822e744e04ef94d71a8ef> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_f049d8b2272822e744e04ef94d71a8ef s) => ToStructure(s, config);
}
public static RC_f049d8b2272822e744e04ef94d71a8ef ToStructure(ssConectaProveedores.RestRecords.JSONRC_f049d8b2272822e744e04ef94d71a8ef obj, IBehaviorsConfiguration config) { 
  RC_f049d8b2272822e744e04ef94d71a8ef s = new RC_f049d8b2272822e744e04ef94d71a8ef();
  if(obj != null) {
  s.ssENFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio, config);
  s.ssENOrderCostCenter = ssConectaProveedores.RestRecords.JSONEN_07f20b06e382f3bc3dadd44791946f9dEntityRecord.ToStructure(obj.AttrOrderCostCenter, config);
  s.ssENOrderAccounting = ssConectaProveedores.RestRecords.JSONEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord.ToStructure(obj.AttrOrderAccounting, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENOrderDetail = ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord.ToStructure(obj.AttrOrderDetail, config);
  s.ssENSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_f049d8b2272822e744e04ef94d71a8ef, ssConectaProveedores.RestRecords.JSONRC_f049d8b2272822e744e04ef94d71a8ef> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f049d8b2272822e744e04ef94d71a8ef s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_f049d8b2272822e744e04ef94d71a8ef FromStructure(RC_f049d8b2272822e744e04ef94d71a8ef s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_f049d8b2272822e744e04ef94d71a8ef(s, config);
}

}


