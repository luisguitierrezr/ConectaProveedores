using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainItemFolioItemsRegionRecord
public class JSONRC_82af454f3893e60efc22cc7344fd4176 : AbstractRESTStructure<RC_82af454f3893e60efc22cc7344fd4176> {
[JsonProperty("OrderMainItem")]
[JsonPropertyName("OrderMainItem")]
public ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord AttrOrderMainItem;

[JsonProperty("FolioItems")]
[JsonPropertyName("FolioItems")]
public ssConectaProveedores.RestRecords.JSONEN_868430b5192a8eb1a739e01247fc2704EntityRecord AttrFolioItems;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_82af454f3893e60efc22cc7344fd4176() { }

public JSONRC_82af454f3893e60efc22cc7344fd4176 (RC_82af454f3893e60efc22cc7344fd4176 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMainItem = ConvertToRestWithoutDefaults(s.ssENOrderMainItem, new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure, config);
AttrFolioItems = ConvertToRestWithoutDefaults(s.ssENFolioItems, new EN_868430b5192a8eb1a739e01247fc2704EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_868430b5192a8eb1a739e01247fc2704EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrOrderMainItem = ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure(s.ssENOrderMainItem, config);
AttrFolioItems = ssConectaProveedores.RestRecords.JSONEN_868430b5192a8eb1a739e01247fc2704EntityRecord.FromStructure(s.ssENFolioItems, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_82af454f3893e60efc22cc7344fd4176, RC_82af454f3893e60efc22cc7344fd4176> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_82af454f3893e60efc22cc7344fd4176 s) => ToStructure(s, config);
}
public static RC_82af454f3893e60efc22cc7344fd4176 ToStructure(ssConectaProveedores.RestRecords.JSONRC_82af454f3893e60efc22cc7344fd4176 obj, IBehaviorsConfiguration config) { 
  RC_82af454f3893e60efc22cc7344fd4176 s = new RC_82af454f3893e60efc22cc7344fd4176();
  if(obj != null) {
  s.ssENOrderMainItem = ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.ToStructure(obj.AttrOrderMainItem, config);
  s.ssENFolioItems = ssConectaProveedores.RestRecords.JSONEN_868430b5192a8eb1a739e01247fc2704EntityRecord.ToStructure(obj.AttrFolioItems, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_82af454f3893e60efc22cc7344fd4176, ssConectaProveedores.RestRecords.JSONRC_82af454f3893e60efc22cc7344fd4176> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_82af454f3893e60efc22cc7344fd4176 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_82af454f3893e60efc22cc7344fd4176 FromStructure(RC_82af454f3893e60efc22cc7344fd4176 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_82af454f3893e60efc22cc7344fd4176(s, config);
}

}


