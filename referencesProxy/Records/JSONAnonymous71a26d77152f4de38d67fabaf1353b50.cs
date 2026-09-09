using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// BreakColumnsRecord
public class JSONRC_261685da2c799bcc3b4873485e008694 : AbstractRESTStructure<RC_261685da2c799bcc3b4873485e008694> {
[JsonProperty("BreakColumns")]
[JsonPropertyName("BreakColumns")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord AttrBreakColumns;

public JSONRC_261685da2c799bcc3b4873485e008694() { }

public JSONRC_261685da2c799bcc3b4873485e008694 (RC_261685da2c799bcc3b4873485e008694 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBreakColumns = ConvertToRestWithoutDefaults(s.ssENBreakColumns, new EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord.FromStructure, config);
  } else {
AttrBreakColumns = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord.FromStructure(s.ssENBreakColumns, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_261685da2c799bcc3b4873485e008694, RC_261685da2c799bcc3b4873485e008694> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_261685da2c799bcc3b4873485e008694 s) => ToStructure(s, config);
}
public static RC_261685da2c799bcc3b4873485e008694 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_261685da2c799bcc3b4873485e008694 obj, IBehaviorsConfiguration config) { 
  RC_261685da2c799bcc3b4873485e008694 s = new RC_261685da2c799bcc3b4873485e008694();
  if(obj != null) {
  s.ssENBreakColumns = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord.ToStructure(obj.AttrBreakColumns, config);
  }
  return s;
}

public static Func<RC_261685da2c799bcc3b4873485e008694, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_261685da2c799bcc3b4873485e008694> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_261685da2c799bcc3b4873485e008694 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_261685da2c799bcc3b4873485e008694 FromStructure(RC_261685da2c799bcc3b4873485e008694 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_261685da2c799bcc3b4873485e008694(s, config);
}

}


