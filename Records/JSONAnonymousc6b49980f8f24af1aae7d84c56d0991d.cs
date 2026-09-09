using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Report60_FolioItemsRecord
public class JSONRC_0bfa65ee3c3879e1901eb29cd4b29a79 : AbstractRESTStructure<RC_0bfa65ee3c3879e1901eb29cd4b29a79> {
[JsonProperty("Report60_FolioItems")]
[JsonPropertyName("Report60_FolioItems")]
public ssConectaProveedores.RestRecords.JSONST_cb4c5fb278f0d4361ef865566d325f1fStructure AttrReport60_FolioItems;

public JSONRC_0bfa65ee3c3879e1901eb29cd4b29a79() { }

public JSONRC_0bfa65ee3c3879e1901eb29cd4b29a79 (RC_0bfa65ee3c3879e1901eb29cd4b29a79 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrReport60_FolioItems = ConvertToRestWithoutDefaults(s.ssSTReport60_FolioItems, new ST_cb4c5fb278f0d4361ef865566d325f1fStructure(), ssConectaProveedores.RestRecords.JSONST_cb4c5fb278f0d4361ef865566d325f1fStructure.FromStructure, config);
  } else {
AttrReport60_FolioItems = ssConectaProveedores.RestRecords.JSONST_cb4c5fb278f0d4361ef865566d325f1fStructure.FromStructure(s.ssSTReport60_FolioItems, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_0bfa65ee3c3879e1901eb29cd4b29a79, RC_0bfa65ee3c3879e1901eb29cd4b29a79> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_0bfa65ee3c3879e1901eb29cd4b29a79 s) => ToStructure(s, config);
}
public static RC_0bfa65ee3c3879e1901eb29cd4b29a79 ToStructure(ssConectaProveedores.RestRecords.JSONRC_0bfa65ee3c3879e1901eb29cd4b29a79 obj, IBehaviorsConfiguration config) { 
  RC_0bfa65ee3c3879e1901eb29cd4b29a79 s = new RC_0bfa65ee3c3879e1901eb29cd4b29a79();
  if(obj != null) {
  s.ssSTReport60_FolioItems = ssConectaProveedores.RestRecords.JSONST_cb4c5fb278f0d4361ef865566d325f1fStructure.ToStructure(obj.AttrReport60_FolioItems, config);
  }
  return s;
}

public static Func<RC_0bfa65ee3c3879e1901eb29cd4b29a79, ssConectaProveedores.RestRecords.JSONRC_0bfa65ee3c3879e1901eb29cd4b29a79> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0bfa65ee3c3879e1901eb29cd4b29a79 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_0bfa65ee3c3879e1901eb29cd4b29a79 FromStructure(RC_0bfa65ee3c3879e1901eb29cd4b29a79 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_0bfa65ee3c3879e1901eb29cd4b29a79(s, config);
}

}


