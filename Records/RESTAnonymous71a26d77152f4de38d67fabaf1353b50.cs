using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// BreakColumnsRecord
public class RESTRC_261685da2c799bcc3b4873485e008694 : AbstractRESTStructure<RC_261685da2c799bcc3b4873485e008694> {
[JsonProperty("BreakColumns")]
public ssConectaProveedores.RestRecords.RESTEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord AttrBreakColumns;

public RESTRC_261685da2c799bcc3b4873485e008694() { }

public RESTRC_261685da2c799bcc3b4873485e008694 (RC_261685da2c799bcc3b4873485e008694 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBreakColumns = ConvertToRestWithoutDefaults(s.ssENBreakColumns, new EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord.FromStructure, config);
  } else {
AttrBreakColumns = ssConectaProveedores.RestRecords.RESTEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord.FromStructure(s.ssENBreakColumns, config);
  }
}

public static RC_261685da2c799bcc3b4873485e008694 ToStructure(ssConectaProveedores.RestRecords.RESTRC_261685da2c799bcc3b4873485e008694 obj) { 
  RC_261685da2c799bcc3b4873485e008694 s = new RC_261685da2c799bcc3b4873485e008694();
  if(obj != null) {
  s.ssENBreakColumns = ssConectaProveedores.RestRecords.RESTEN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord.ToStructure(obj.AttrBreakColumns);
  }
  return s;
}

public static Func<RC_261685da2c799bcc3b4873485e008694, ssConectaProveedores.RestRecords.RESTRC_261685da2c799bcc3b4873485e008694> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_261685da2c799bcc3b4873485e008694 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_261685da2c799bcc3b4873485e008694 FromStructure(RC_261685da2c799bcc3b4873485e008694 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_261685da2c799bcc3b4873485e008694(s, config);
}

}


