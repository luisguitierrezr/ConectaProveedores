using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PaperSizeRecord
public class RESTRC_6748c146370600806f2500c8b8a2cb25 : AbstractRESTStructure<RC_6748c146370600806f2500c8b8a2cb25> {
[JsonProperty("PaperSize")]
public ssConectaProveedores.RestRecords.RESTEN_7f47ecde673669f1866fae1765d30761EntityRecord AttrPaperSize;

public RESTRC_6748c146370600806f2500c8b8a2cb25() { }

public RESTRC_6748c146370600806f2500c8b8a2cb25 (RC_6748c146370600806f2500c8b8a2cb25 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPaperSize = ConvertToRestWithoutDefaults(s.ssENPaperSize, new EN_7f47ecde673669f1866fae1765d30761EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7f47ecde673669f1866fae1765d30761EntityRecord.FromStructure, config);
  } else {
AttrPaperSize = ssConectaProveedores.RestRecords.RESTEN_7f47ecde673669f1866fae1765d30761EntityRecord.FromStructure(s.ssENPaperSize, config);
  }
}

public static RC_6748c146370600806f2500c8b8a2cb25 ToStructure(ssConectaProveedores.RestRecords.RESTRC_6748c146370600806f2500c8b8a2cb25 obj) { 
  RC_6748c146370600806f2500c8b8a2cb25 s = new RC_6748c146370600806f2500c8b8a2cb25();
  if(obj != null) {
  s.ssENPaperSize = ssConectaProveedores.RestRecords.RESTEN_7f47ecde673669f1866fae1765d30761EntityRecord.ToStructure(obj.AttrPaperSize);
  }
  return s;
}

public static Func<RC_6748c146370600806f2500c8b8a2cb25, ssConectaProveedores.RestRecords.RESTRC_6748c146370600806f2500c8b8a2cb25> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6748c146370600806f2500c8b8a2cb25 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_6748c146370600806f2500c8b8a2cb25 FromStructure(RC_6748c146370600806f2500c8b8a2cb25 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_6748c146370600806f2500c8b8a2cb25(s, config);
}

}


