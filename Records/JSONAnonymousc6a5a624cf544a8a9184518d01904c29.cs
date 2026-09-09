using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioSAPDataOrderMainItemFolioFolioItemsRecord
public class JSONRC_88067cef1566b3e5511988d0eaf88bc3 : AbstractRESTStructure<RC_88067cef1566b3e5511988d0eaf88bc3> {
[JsonProperty("FolioSAPData")]
[JsonPropertyName("FolioSAPData")]
public ssConectaProveedores.RestRecords.JSONEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord AttrFolioSAPData;

[JsonProperty("OrderMainItem")]
[JsonPropertyName("OrderMainItem")]
public ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord AttrOrderMainItem;

[JsonProperty("Folio")]
[JsonPropertyName("Folio")]
public ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("FolioItems")]
[JsonPropertyName("FolioItems")]
public ssConectaProveedores.RestRecords.JSONEN_868430b5192a8eb1a739e01247fc2704EntityRecord AttrFolioItems;

public JSONRC_88067cef1566b3e5511988d0eaf88bc3() { }

public JSONRC_88067cef1566b3e5511988d0eaf88bc3 (RC_88067cef1566b3e5511988d0eaf88bc3 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioSAPData = ConvertToRestWithoutDefaults(s.ssENFolioSAPData, new EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord.FromStructure, config);
AttrOrderMainItem = ConvertToRestWithoutDefaults(s.ssENOrderMainItem, new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrFolioItems = ConvertToRestWithoutDefaults(s.ssENFolioItems, new EN_868430b5192a8eb1a739e01247fc2704EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_868430b5192a8eb1a739e01247fc2704EntityRecord.FromStructure, config);
  } else {
AttrFolioSAPData = ssConectaProveedores.RestRecords.JSONEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord.FromStructure(s.ssENFolioSAPData, config);
AttrOrderMainItem = ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure(s.ssENOrderMainItem, config);
AttrFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrFolioItems = ssConectaProveedores.RestRecords.JSONEN_868430b5192a8eb1a739e01247fc2704EntityRecord.FromStructure(s.ssENFolioItems, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_88067cef1566b3e5511988d0eaf88bc3, RC_88067cef1566b3e5511988d0eaf88bc3> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_88067cef1566b3e5511988d0eaf88bc3 s) => ToStructure(s, config);
}
public static RC_88067cef1566b3e5511988d0eaf88bc3 ToStructure(ssConectaProveedores.RestRecords.JSONRC_88067cef1566b3e5511988d0eaf88bc3 obj, IBehaviorsConfiguration config) { 
  RC_88067cef1566b3e5511988d0eaf88bc3 s = new RC_88067cef1566b3e5511988d0eaf88bc3();
  if(obj != null) {
  s.ssENFolioSAPData = ssConectaProveedores.RestRecords.JSONEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord.ToStructure(obj.AttrFolioSAPData, config);
  s.ssENOrderMainItem = ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.ToStructure(obj.AttrOrderMainItem, config);
  s.ssENFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio, config);
  s.ssENFolioItems = ssConectaProveedores.RestRecords.JSONEN_868430b5192a8eb1a739e01247fc2704EntityRecord.ToStructure(obj.AttrFolioItems, config);
  }
  return s;
}

public static Func<RC_88067cef1566b3e5511988d0eaf88bc3, ssConectaProveedores.RestRecords.JSONRC_88067cef1566b3e5511988d0eaf88bc3> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_88067cef1566b3e5511988d0eaf88bc3 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_88067cef1566b3e5511988d0eaf88bc3 FromStructure(RC_88067cef1566b3e5511988d0eaf88bc3 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_88067cef1566b3e5511988d0eaf88bc3(s, config);
}

}


