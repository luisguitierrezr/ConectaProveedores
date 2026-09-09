using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioItemsRecord
public class JSONRC_f861f2b559524d098e0981156af9b7ab : AbstractRESTStructure<RC_f861f2b559524d098e0981156af9b7ab> {
[JsonProperty("FolioItems")]
[JsonPropertyName("FolioItems")]
public ssConectaProveedores.RestRecords.JSONEN_868430b5192a8eb1a739e01247fc2704EntityRecord AttrFolioItems;

public JSONRC_f861f2b559524d098e0981156af9b7ab() { }

public JSONRC_f861f2b559524d098e0981156af9b7ab (RC_f861f2b559524d098e0981156af9b7ab s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioItems = ConvertToRestWithoutDefaults(s.ssENFolioItems, new EN_868430b5192a8eb1a739e01247fc2704EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_868430b5192a8eb1a739e01247fc2704EntityRecord.FromStructure, config);
  } else {
AttrFolioItems = ssConectaProveedores.RestRecords.JSONEN_868430b5192a8eb1a739e01247fc2704EntityRecord.FromStructure(s.ssENFolioItems, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_f861f2b559524d098e0981156af9b7ab, RC_f861f2b559524d098e0981156af9b7ab> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_f861f2b559524d098e0981156af9b7ab s) => ToStructure(s, config);
}
public static RC_f861f2b559524d098e0981156af9b7ab ToStructure(ssConectaProveedores.RestRecords.JSONRC_f861f2b559524d098e0981156af9b7ab obj, IBehaviorsConfiguration config) { 
  RC_f861f2b559524d098e0981156af9b7ab s = new RC_f861f2b559524d098e0981156af9b7ab();
  if(obj != null) {
  s.ssENFolioItems = ssConectaProveedores.RestRecords.JSONEN_868430b5192a8eb1a739e01247fc2704EntityRecord.ToStructure(obj.AttrFolioItems, config);
  }
  return s;
}

public static Func<RC_f861f2b559524d098e0981156af9b7ab, ssConectaProveedores.RestRecords.JSONRC_f861f2b559524d098e0981156af9b7ab> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f861f2b559524d098e0981156af9b7ab s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_f861f2b559524d098e0981156af9b7ab FromStructure(RC_f861f2b559524d098e0981156af9b7ab s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_f861f2b559524d098e0981156af9b7ab(s, config);
}

}


