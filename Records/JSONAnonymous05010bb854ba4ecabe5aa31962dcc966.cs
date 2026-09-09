using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainItemFolioFolioItemsRecord
public class JSONRC_95110bc97f34f4c1561c8cbf2b5015b2 : AbstractRESTStructure<RC_95110bc97f34f4c1561c8cbf2b5015b2> {
[JsonProperty("OrderMainItem")]
[JsonPropertyName("OrderMainItem")]
public ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord AttrOrderMainItem;

[JsonProperty("Folio")]
[JsonPropertyName("Folio")]
public ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("FolioItems")]
[JsonPropertyName("FolioItems")]
public ssConectaProveedores.RestRecords.JSONEN_868430b5192a8eb1a739e01247fc2704EntityRecord AttrFolioItems;

public JSONRC_95110bc97f34f4c1561c8cbf2b5015b2() { }

public JSONRC_95110bc97f34f4c1561c8cbf2b5015b2 (RC_95110bc97f34f4c1561c8cbf2b5015b2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMainItem = ConvertToRestWithoutDefaults(s.ssENOrderMainItem, new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrFolioItems = ConvertToRestWithoutDefaults(s.ssENFolioItems, new EN_868430b5192a8eb1a739e01247fc2704EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_868430b5192a8eb1a739e01247fc2704EntityRecord.FromStructure, config);
  } else {
AttrOrderMainItem = ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure(s.ssENOrderMainItem, config);
AttrFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrFolioItems = ssConectaProveedores.RestRecords.JSONEN_868430b5192a8eb1a739e01247fc2704EntityRecord.FromStructure(s.ssENFolioItems, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_95110bc97f34f4c1561c8cbf2b5015b2, RC_95110bc97f34f4c1561c8cbf2b5015b2> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_95110bc97f34f4c1561c8cbf2b5015b2 s) => ToStructure(s, config);
}
public static RC_95110bc97f34f4c1561c8cbf2b5015b2 ToStructure(ssConectaProveedores.RestRecords.JSONRC_95110bc97f34f4c1561c8cbf2b5015b2 obj, IBehaviorsConfiguration config) { 
  RC_95110bc97f34f4c1561c8cbf2b5015b2 s = new RC_95110bc97f34f4c1561c8cbf2b5015b2();
  if(obj != null) {
  s.ssENOrderMainItem = ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.ToStructure(obj.AttrOrderMainItem, config);
  s.ssENFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio, config);
  s.ssENFolioItems = ssConectaProveedores.RestRecords.JSONEN_868430b5192a8eb1a739e01247fc2704EntityRecord.ToStructure(obj.AttrFolioItems, config);
  }
  return s;
}

public static Func<RC_95110bc97f34f4c1561c8cbf2b5015b2, ssConectaProveedores.RestRecords.JSONRC_95110bc97f34f4c1561c8cbf2b5015b2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_95110bc97f34f4c1561c8cbf2b5015b2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_95110bc97f34f4c1561c8cbf2b5015b2 FromStructure(RC_95110bc97f34f4c1561c8cbf2b5015b2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_95110bc97f34f4c1561c8cbf2b5015b2(s, config);
}

}


