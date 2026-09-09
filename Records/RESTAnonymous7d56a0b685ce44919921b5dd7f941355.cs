using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioItemsRecord
public class RESTRC_f861f2b559524d098e0981156af9b7ab : AbstractRESTStructure<RC_f861f2b559524d098e0981156af9b7ab> {
[JsonProperty("FolioItems")]
public ssConectaProveedores.RestRecords.RESTEN_868430b5192a8eb1a739e01247fc2704EntityRecord AttrFolioItems;

public RESTRC_f861f2b559524d098e0981156af9b7ab() { }

public RESTRC_f861f2b559524d098e0981156af9b7ab (RC_f861f2b559524d098e0981156af9b7ab s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioItems = ConvertToRestWithoutDefaults(s.ssENFolioItems, new EN_868430b5192a8eb1a739e01247fc2704EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_868430b5192a8eb1a739e01247fc2704EntityRecord.FromStructure, config);
  } else {
AttrFolioItems = ssConectaProveedores.RestRecords.RESTEN_868430b5192a8eb1a739e01247fc2704EntityRecord.FromStructure(s.ssENFolioItems, config);
  }
}

public static RC_f861f2b559524d098e0981156af9b7ab ToStructure(ssConectaProveedores.RestRecords.RESTRC_f861f2b559524d098e0981156af9b7ab obj) { 
  RC_f861f2b559524d098e0981156af9b7ab s = new RC_f861f2b559524d098e0981156af9b7ab();
  if(obj != null) {
  s.ssENFolioItems = ssConectaProveedores.RestRecords.RESTEN_868430b5192a8eb1a739e01247fc2704EntityRecord.ToStructure(obj.AttrFolioItems);
  }
  return s;
}

public static Func<RC_f861f2b559524d098e0981156af9b7ab, ssConectaProveedores.RestRecords.RESTRC_f861f2b559524d098e0981156af9b7ab> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f861f2b559524d098e0981156af9b7ab s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_f861f2b559524d098e0981156af9b7ab FromStructure(RC_f861f2b559524d098e0981156af9b7ab s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_f861f2b559524d098e0981156af9b7ab(s, config);
}

}


