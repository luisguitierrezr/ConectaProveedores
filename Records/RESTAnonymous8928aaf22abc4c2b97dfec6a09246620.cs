using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingProcessRetentionsRecord
public class RESTRC_572bb5931fdd9ca097b2d3800101c49b : AbstractRESTStructure<RC_572bb5931fdd9ca097b2d3800101c49b> {
[JsonProperty("InvoiceAccountingProcessRetentions")]
public ssConectaProveedores.RestRecords.RESTEN_b5a4fdb73161852bf014862cdc591a06EntityRecord AttrInvoiceAccountingProcessRetentions;

public RESTRC_572bb5931fdd9ca097b2d3800101c49b() { }

public RESTRC_572bb5931fdd9ca097b2d3800101c49b (RC_572bb5931fdd9ca097b2d3800101c49b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceAccountingProcessRetentions = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingProcessRetentions, new EN_b5a4fdb73161852bf014862cdc591a06EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b5a4fdb73161852bf014862cdc591a06EntityRecord.FromStructure, config);
  } else {
AttrInvoiceAccountingProcessRetentions = ssConectaProveedores.RestRecords.RESTEN_b5a4fdb73161852bf014862cdc591a06EntityRecord.FromStructure(s.ssENInvoiceAccountingProcessRetentions, config);
  }
}

public static RC_572bb5931fdd9ca097b2d3800101c49b ToStructure(ssConectaProveedores.RestRecords.RESTRC_572bb5931fdd9ca097b2d3800101c49b obj) { 
  RC_572bb5931fdd9ca097b2d3800101c49b s = new RC_572bb5931fdd9ca097b2d3800101c49b();
  if(obj != null) {
  s.ssENInvoiceAccountingProcessRetentions = ssConectaProveedores.RestRecords.RESTEN_b5a4fdb73161852bf014862cdc591a06EntityRecord.ToStructure(obj.AttrInvoiceAccountingProcessRetentions);
  }
  return s;
}

public static Func<RC_572bb5931fdd9ca097b2d3800101c49b, ssConectaProveedores.RestRecords.RESTRC_572bb5931fdd9ca097b2d3800101c49b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_572bb5931fdd9ca097b2d3800101c49b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_572bb5931fdd9ca097b2d3800101c49b FromStructure(RC_572bb5931fdd9ca097b2d3800101c49b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_572bb5931fdd9ca097b2d3800101c49b(s, config);
}

}


