using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceLogRecord
public class JSONRC_deaf8695933be1bd95c8a487c5df0dc4 : AbstractRESTStructure<RC_deaf8695933be1bd95c8a487c5df0dc4> {
[JsonProperty("InvoiceLog")]
[JsonPropertyName("InvoiceLog")]
public ssConectaProveedores.RestRecords.JSONEN_bf34270fdd0f7785895f41a998e724e8EntityRecord AttrInvoiceLog;

public JSONRC_deaf8695933be1bd95c8a487c5df0dc4() { }

public JSONRC_deaf8695933be1bd95c8a487c5df0dc4 (RC_deaf8695933be1bd95c8a487c5df0dc4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceLog = ConvertToRestWithoutDefaults(s.ssENInvoiceLog, new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_bf34270fdd0f7785895f41a998e724e8EntityRecord.FromStructure, config);
  } else {
AttrInvoiceLog = ssConectaProveedores.RestRecords.JSONEN_bf34270fdd0f7785895f41a998e724e8EntityRecord.FromStructure(s.ssENInvoiceLog, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_deaf8695933be1bd95c8a487c5df0dc4, RC_deaf8695933be1bd95c8a487c5df0dc4> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_deaf8695933be1bd95c8a487c5df0dc4 s) => ToStructure(s, config);
}
public static RC_deaf8695933be1bd95c8a487c5df0dc4 ToStructure(ssConectaProveedores.RestRecords.JSONRC_deaf8695933be1bd95c8a487c5df0dc4 obj, IBehaviorsConfiguration config) { 
  RC_deaf8695933be1bd95c8a487c5df0dc4 s = new RC_deaf8695933be1bd95c8a487c5df0dc4();
  if(obj != null) {
  s.ssENInvoiceLog = ssConectaProveedores.RestRecords.JSONEN_bf34270fdd0f7785895f41a998e724e8EntityRecord.ToStructure(obj.AttrInvoiceLog, config);
  }
  return s;
}

public static Func<RC_deaf8695933be1bd95c8a487c5df0dc4, ssConectaProveedores.RestRecords.JSONRC_deaf8695933be1bd95c8a487c5df0dc4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_deaf8695933be1bd95c8a487c5df0dc4 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_deaf8695933be1bd95c8a487c5df0dc4 FromStructure(RC_deaf8695933be1bd95c8a487c5df0dc4 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_deaf8695933be1bd95c8a487c5df0dc4(s, config);
}

}


