using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceInvoiceFileRequisitionInvoiceAccountingInvoiceExtendedSelectStorageSupplierRegionRecord
public class JSONRC_cfb4b5cbc9f75e782e7f32736dbeac24 : AbstractRESTStructure<RC_cfb4b5cbc9f75e782e7f32736dbeac24> {
[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceFile")]
[JsonPropertyName("InvoiceFile")]
public ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord AttrInvoiceFile;

[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("InvoiceAccounting")]
[JsonPropertyName("InvoiceAccounting")]
public ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord AttrInvoiceAccounting;

[JsonProperty("InvoiceExtended")]
[JsonPropertyName("InvoiceExtended")]
public ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord AttrInvoiceExtended;

[JsonProperty("Select")]
[JsonPropertyName("Select")]
public bool? AttrSelect;

[JsonProperty("Storage")]
[JsonPropertyName("Storage")]
public ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord AttrStorage;

[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_cfb4b5cbc9f75e782e7f32736dbeac24() { }

public JSONRC_cfb4b5cbc9f75e782e7f32736dbeac24 (RC_cfb4b5cbc9f75e782e7f32736dbeac24 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceFile = ConvertToRestWithoutDefaults(s.ssENInvoiceFile, new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrInvoiceAccounting = ConvertToRestWithoutDefaults(s.ssENInvoiceAccounting, new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord.FromStructure, config);
AttrInvoiceExtended = ConvertToRestWithoutDefaults(s.ssENInvoiceExtended, new EN_f81a3d226103fd013068b8763798067aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure, config);
AttrSelect = ConvertToRestWithoutDefaults(s.ssSelect, false);
AttrStorage = ConvertToRestWithoutDefaults(s.ssENStorage, new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceFile = ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure(s.ssENInvoiceFile, config);
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrInvoiceAccounting = ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord.FromStructure(s.ssENInvoiceAccounting, config);
AttrInvoiceExtended = ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure(s.ssENInvoiceExtended, config);
AttrSelect = (bool?) s.ssSelect;
AttrStorage = ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.FromStructure(s.ssENStorage, config);
AttrSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_cfb4b5cbc9f75e782e7f32736dbeac24, RC_cfb4b5cbc9f75e782e7f32736dbeac24> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_cfb4b5cbc9f75e782e7f32736dbeac24 s) => ToStructure(s, config);
}
public static RC_cfb4b5cbc9f75e782e7f32736dbeac24 ToStructure(ssConectaProveedores.RestRecords.JSONRC_cfb4b5cbc9f75e782e7f32736dbeac24 obj, IBehaviorsConfiguration config) { 
  RC_cfb4b5cbc9f75e782e7f32736dbeac24 s = new RC_cfb4b5cbc9f75e782e7f32736dbeac24();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENInvoiceFile = ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.ToStructure(obj.AttrInvoiceFile, config);
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENInvoiceAccounting = ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord.ToStructure(obj.AttrInvoiceAccounting, config);
  s.ssENInvoiceExtended = ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.ToStructure(obj.AttrInvoiceExtended, config);
  s.ssSelect = obj.AttrSelect == null ? false : obj.AttrSelect.Value;
  s.ssENStorage = ssConectaProveedores.RestRecords.JSONEN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord.ToStructure(obj.AttrStorage, config);
  s.ssENSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_cfb4b5cbc9f75e782e7f32736dbeac24, ssConectaProveedores.RestRecords.JSONRC_cfb4b5cbc9f75e782e7f32736dbeac24> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cfb4b5cbc9f75e782e7f32736dbeac24 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_cfb4b5cbc9f75e782e7f32736dbeac24 FromStructure(RC_cfb4b5cbc9f75e782e7f32736dbeac24 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_cfb4b5cbc9f75e782e7f32736dbeac24(s, config);
}

}


