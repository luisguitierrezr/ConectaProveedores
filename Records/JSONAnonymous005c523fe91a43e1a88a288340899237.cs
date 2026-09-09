using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioStatusInvoiceFolioFolioExtendedOrderMainSupplierRegionRecord
public class JSONRC_e2b9f65e0c0c00d0e673b5a8e6e47435 : AbstractRESTStructure<RC_e2b9f65e0c0c00d0e673b5a8e6e47435> {
[JsonProperty("FolioStatus")]
[JsonPropertyName("FolioStatus")]
public ssConectaProveedores.RestRecords.JSONEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord AttrFolioStatus;

[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("Folio")]
[JsonPropertyName("Folio")]
public ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("FolioExtended")]
[JsonPropertyName("FolioExtended")]
public ssConectaProveedores.RestRecords.JSONEN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord AttrFolioExtended;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_e2b9f65e0c0c00d0e673b5a8e6e47435() { }

public JSONRC_e2b9f65e0c0c00d0e673b5a8e6e47435 (RC_e2b9f65e0c0c00d0e673b5a8e6e47435 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioStatus = ConvertToRestWithoutDefaults(s.ssENFolioStatus, new EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord.FromStructure, config);
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrFolioExtended = ConvertToRestWithoutDefaults(s.ssENFolioExtended, new EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrFolioStatus = ssConectaProveedores.RestRecords.JSONEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord.FromStructure(s.ssENFolioStatus, config);
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrFolioExtended = ssConectaProveedores.RestRecords.JSONEN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord.FromStructure(s.ssENFolioExtended, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_e2b9f65e0c0c00d0e673b5a8e6e47435, RC_e2b9f65e0c0c00d0e673b5a8e6e47435> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_e2b9f65e0c0c00d0e673b5a8e6e47435 s) => ToStructure(s, config);
}
public static RC_e2b9f65e0c0c00d0e673b5a8e6e47435 ToStructure(ssConectaProveedores.RestRecords.JSONRC_e2b9f65e0c0c00d0e673b5a8e6e47435 obj, IBehaviorsConfiguration config) { 
  RC_e2b9f65e0c0c00d0e673b5a8e6e47435 s = new RC_e2b9f65e0c0c00d0e673b5a8e6e47435();
  if(obj != null) {
  s.ssENFolioStatus = ssConectaProveedores.RestRecords.JSONEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord.ToStructure(obj.AttrFolioStatus, config);
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio, config);
  s.ssENFolioExtended = ssConectaProveedores.RestRecords.JSONEN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord.ToStructure(obj.AttrFolioExtended, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_e2b9f65e0c0c00d0e673b5a8e6e47435, ssConectaProveedores.RestRecords.JSONRC_e2b9f65e0c0c00d0e673b5a8e6e47435> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e2b9f65e0c0c00d0e673b5a8e6e47435 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_e2b9f65e0c0c00d0e673b5a8e6e47435 FromStructure(RC_e2b9f65e0c0c00d0e673b5a8e6e47435 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_e2b9f65e0c0c00d0e673b5a8e6e47435(s, config);
}

}


