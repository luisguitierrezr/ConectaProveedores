using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Report60_FolioItemsRecord
public class RESTRC_0bfa65ee3c3879e1901eb29cd4b29a79 : AbstractRESTStructure<RC_0bfa65ee3c3879e1901eb29cd4b29a79> {
[JsonProperty("Report60_FolioItems")]
public ssConectaProveedores.RestRecords.RESTST_cb4c5fb278f0d4361ef865566d325f1fStructure AttrReport60_FolioItems;

public RESTRC_0bfa65ee3c3879e1901eb29cd4b29a79() { }

public RESTRC_0bfa65ee3c3879e1901eb29cd4b29a79 (RC_0bfa65ee3c3879e1901eb29cd4b29a79 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrReport60_FolioItems = ConvertToRestWithoutDefaults(s.ssSTReport60_FolioItems, new ST_cb4c5fb278f0d4361ef865566d325f1fStructure(), ssConectaProveedores.RestRecords.RESTST_cb4c5fb278f0d4361ef865566d325f1fStructure.FromStructure, config);
  } else {
AttrReport60_FolioItems = ssConectaProveedores.RestRecords.RESTST_cb4c5fb278f0d4361ef865566d325f1fStructure.FromStructure(s.ssSTReport60_FolioItems, config);
  }
}

public static RC_0bfa65ee3c3879e1901eb29cd4b29a79 ToStructure(ssConectaProveedores.RestRecords.RESTRC_0bfa65ee3c3879e1901eb29cd4b29a79 obj) { 
  RC_0bfa65ee3c3879e1901eb29cd4b29a79 s = new RC_0bfa65ee3c3879e1901eb29cd4b29a79();
  if(obj != null) {
  s.ssSTReport60_FolioItems = ssConectaProveedores.RestRecords.RESTST_cb4c5fb278f0d4361ef865566d325f1fStructure.ToStructure(obj.AttrReport60_FolioItems);
  }
  return s;
}

public static Func<RC_0bfa65ee3c3879e1901eb29cd4b29a79, ssConectaProveedores.RestRecords.RESTRC_0bfa65ee3c3879e1901eb29cd4b29a79> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0bfa65ee3c3879e1901eb29cd4b29a79 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_0bfa65ee3c3879e1901eb29cd4b29a79 FromStructure(RC_0bfa65ee3c3879e1901eb29cd4b29a79 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_0bfa65ee3c3879e1901eb29cd4b29a79(s, config);
}

}


