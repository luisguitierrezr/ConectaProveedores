using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceLogRecord
public class RESTRC_deaf8695933be1bd95c8a487c5df0dc4 : AbstractRESTStructure<RC_deaf8695933be1bd95c8a487c5df0dc4> {
[JsonProperty("InvoiceLog")]
public ssConectaProveedores.RestRecords.RESTEN_bf34270fdd0f7785895f41a998e724e8EntityRecord AttrInvoiceLog;

public RESTRC_deaf8695933be1bd95c8a487c5df0dc4() { }

public RESTRC_deaf8695933be1bd95c8a487c5df0dc4 (RC_deaf8695933be1bd95c8a487c5df0dc4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceLog = ConvertToRestWithoutDefaults(s.ssENInvoiceLog, new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_bf34270fdd0f7785895f41a998e724e8EntityRecord.FromStructure, config);
  } else {
AttrInvoiceLog = ssConectaProveedores.RestRecords.RESTEN_bf34270fdd0f7785895f41a998e724e8EntityRecord.FromStructure(s.ssENInvoiceLog, config);
  }
}

public static RC_deaf8695933be1bd95c8a487c5df0dc4 ToStructure(ssConectaProveedores.RestRecords.RESTRC_deaf8695933be1bd95c8a487c5df0dc4 obj) { 
  RC_deaf8695933be1bd95c8a487c5df0dc4 s = new RC_deaf8695933be1bd95c8a487c5df0dc4();
  if(obj != null) {
  s.ssENInvoiceLog = ssConectaProveedores.RestRecords.RESTEN_bf34270fdd0f7785895f41a998e724e8EntityRecord.ToStructure(obj.AttrInvoiceLog);
  }
  return s;
}

public static Func<RC_deaf8695933be1bd95c8a487c5df0dc4, ssConectaProveedores.RestRecords.RESTRC_deaf8695933be1bd95c8a487c5df0dc4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_deaf8695933be1bd95c8a487c5df0dc4 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_deaf8695933be1bd95c8a487c5df0dc4 FromStructure(RC_deaf8695933be1bd95c8a487c5df0dc4 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_deaf8695933be1bd95c8a487c5df0dc4(s, config);
}

}


