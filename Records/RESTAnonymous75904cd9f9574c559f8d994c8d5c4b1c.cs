using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioFolioItemsRecord
public class RESTRC_a7662588f9e72f6305013b985632ea24 : AbstractRESTStructure<RC_a7662588f9e72f6305013b985632ea24> {
[JsonProperty("Folio")]
public ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("FolioItems")]
public ssConectaProveedores.RestRecords.RESTEN_868430b5192a8eb1a739e01247fc2704EntityRecord AttrFolioItems;

public RESTRC_a7662588f9e72f6305013b985632ea24() { }

public RESTRC_a7662588f9e72f6305013b985632ea24 (RC_a7662588f9e72f6305013b985632ea24 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrFolioItems = ConvertToRestWithoutDefaults(s.ssENFolioItems, new EN_868430b5192a8eb1a739e01247fc2704EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_868430b5192a8eb1a739e01247fc2704EntityRecord.FromStructure, config);
  } else {
AttrFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrFolioItems = ssConectaProveedores.RestRecords.RESTEN_868430b5192a8eb1a739e01247fc2704EntityRecord.FromStructure(s.ssENFolioItems, config);
  }
}

public static RC_a7662588f9e72f6305013b985632ea24 ToStructure(ssConectaProveedores.RestRecords.RESTRC_a7662588f9e72f6305013b985632ea24 obj) { 
  RC_a7662588f9e72f6305013b985632ea24 s = new RC_a7662588f9e72f6305013b985632ea24();
  if(obj != null) {
  s.ssENFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio);
  s.ssENFolioItems = ssConectaProveedores.RestRecords.RESTEN_868430b5192a8eb1a739e01247fc2704EntityRecord.ToStructure(obj.AttrFolioItems);
  }
  return s;
}

public static Func<RC_a7662588f9e72f6305013b985632ea24, ssConectaProveedores.RestRecords.RESTRC_a7662588f9e72f6305013b985632ea24> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a7662588f9e72f6305013b985632ea24 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a7662588f9e72f6305013b985632ea24 FromStructure(RC_a7662588f9e72f6305013b985632ea24 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a7662588f9e72f6305013b985632ea24(s, config);
}

}


