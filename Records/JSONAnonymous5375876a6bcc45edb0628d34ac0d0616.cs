using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceFolioInvoiceFileOrderAccConceptsOrderMainAccountingDataTypeRecord
public class JSONRC_9ae567d0cf6d3095d7119747b95be259 : AbstractRESTStructure<RC_9ae567d0cf6d3095d7119747b95be259> {
[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("Folio")]
[JsonPropertyName("Folio")]
public ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("InvoiceFile")]
[JsonPropertyName("InvoiceFile")]
public ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord AttrInvoiceFile;

[JsonProperty("OrderAccConcepts")]
[JsonPropertyName("OrderAccConcepts")]
public ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord AttrOrderAccConcepts;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("AccountingDataType")]
[JsonPropertyName("AccountingDataType")]
public ssConectaProveedores.RestRecords.JSONEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord AttrAccountingDataType;

public JSONRC_9ae567d0cf6d3095d7119747b95be259() { }

public JSONRC_9ae567d0cf6d3095d7119747b95be259 (RC_9ae567d0cf6d3095d7119747b95be259 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrInvoiceFile = ConvertToRestWithoutDefaults(s.ssENInvoiceFile, new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure, config);
AttrOrderAccConcepts = ConvertToRestWithoutDefaults(s.ssENOrderAccConcepts, new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrAccountingDataType = ConvertToRestWithoutDefaults(s.ssENAccountingDataType, new EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrInvoiceFile = ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure(s.ssENInvoiceFile, config);
AttrOrderAccConcepts = ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure(s.ssENOrderAccConcepts, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrAccountingDataType = ssConectaProveedores.RestRecords.JSONEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.FromStructure(s.ssENAccountingDataType, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_9ae567d0cf6d3095d7119747b95be259, RC_9ae567d0cf6d3095d7119747b95be259> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_9ae567d0cf6d3095d7119747b95be259 s) => ToStructure(s, config);
}
public static RC_9ae567d0cf6d3095d7119747b95be259 ToStructure(ssConectaProveedores.RestRecords.JSONRC_9ae567d0cf6d3095d7119747b95be259 obj, IBehaviorsConfiguration config) { 
  RC_9ae567d0cf6d3095d7119747b95be259 s = new RC_9ae567d0cf6d3095d7119747b95be259();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio, config);
  s.ssENInvoiceFile = ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.ToStructure(obj.AttrInvoiceFile, config);
  s.ssENOrderAccConcepts = ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.ToStructure(obj.AttrOrderAccConcepts, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENAccountingDataType = ssConectaProveedores.RestRecords.JSONEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.ToStructure(obj.AttrAccountingDataType, config);
  }
  return s;
}

public static Func<RC_9ae567d0cf6d3095d7119747b95be259, ssConectaProveedores.RestRecords.JSONRC_9ae567d0cf6d3095d7119747b95be259> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9ae567d0cf6d3095d7119747b95be259 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_9ae567d0cf6d3095d7119747b95be259 FromStructure(RC_9ae567d0cf6d3095d7119747b95be259 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_9ae567d0cf6d3095d7119747b95be259(s, config);
}

}


