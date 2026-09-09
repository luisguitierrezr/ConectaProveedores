using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainItemFolioItemsRecord
public class RESTRC_9e12e346359269058e01a3334f3aaf87 : AbstractRESTStructure<RC_9e12e346359269058e01a3334f3aaf87> {
[JsonProperty("OrderMainItem")]
public ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord AttrOrderMainItem;

[JsonProperty("FolioItems")]
public ssConectaProveedores.RestRecords.RESTEN_868430b5192a8eb1a739e01247fc2704EntityRecord AttrFolioItems;

public RESTRC_9e12e346359269058e01a3334f3aaf87() { }

public RESTRC_9e12e346359269058e01a3334f3aaf87 (RC_9e12e346359269058e01a3334f3aaf87 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMainItem = ConvertToRestWithoutDefaults(s.ssENOrderMainItem, new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure, config);
AttrFolioItems = ConvertToRestWithoutDefaults(s.ssENFolioItems, new EN_868430b5192a8eb1a739e01247fc2704EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_868430b5192a8eb1a739e01247fc2704EntityRecord.FromStructure, config);
  } else {
AttrOrderMainItem = ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure(s.ssENOrderMainItem, config);
AttrFolioItems = ssConectaProveedores.RestRecords.RESTEN_868430b5192a8eb1a739e01247fc2704EntityRecord.FromStructure(s.ssENFolioItems, config);
  }
}

public static RC_9e12e346359269058e01a3334f3aaf87 ToStructure(ssConectaProveedores.RestRecords.RESTRC_9e12e346359269058e01a3334f3aaf87 obj) { 
  RC_9e12e346359269058e01a3334f3aaf87 s = new RC_9e12e346359269058e01a3334f3aaf87();
  if(obj != null) {
  s.ssENOrderMainItem = ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.ToStructure(obj.AttrOrderMainItem);
  s.ssENFolioItems = ssConectaProveedores.RestRecords.RESTEN_868430b5192a8eb1a739e01247fc2704EntityRecord.ToStructure(obj.AttrFolioItems);
  }
  return s;
}

public static Func<RC_9e12e346359269058e01a3334f3aaf87, ssConectaProveedores.RestRecords.RESTRC_9e12e346359269058e01a3334f3aaf87> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9e12e346359269058e01a3334f3aaf87 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_9e12e346359269058e01a3334f3aaf87 FromStructure(RC_9e12e346359269058e01a3334f3aaf87 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_9e12e346359269058e01a3334f3aaf87(s, config);
}

}


