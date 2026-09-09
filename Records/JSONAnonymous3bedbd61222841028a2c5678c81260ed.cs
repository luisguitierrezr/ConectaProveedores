using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderItemEntriesOrderMainItemRecord
public class JSONRC_cf58ea0f756ca06745169deb0b41c0eb : AbstractRESTStructure<RC_cf58ea0f756ca06745169deb0b41c0eb> {
[JsonProperty("OrderItemEntries")]
[JsonPropertyName("OrderItemEntries")]
public ssConectaProveedores.RestRecords.JSONEN_0eb2cf39b93366f50855e537f6b98500EntityRecord AttrOrderItemEntries;

[JsonProperty("OrderMainItem")]
[JsonPropertyName("OrderMainItem")]
public ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord AttrOrderMainItem;

public JSONRC_cf58ea0f756ca06745169deb0b41c0eb() { }

public JSONRC_cf58ea0f756ca06745169deb0b41c0eb (RC_cf58ea0f756ca06745169deb0b41c0eb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderItemEntries = ConvertToRestWithoutDefaults(s.ssENOrderItemEntries, new EN_0eb2cf39b93366f50855e537f6b98500EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_0eb2cf39b93366f50855e537f6b98500EntityRecord.FromStructure, config);
AttrOrderMainItem = ConvertToRestWithoutDefaults(s.ssENOrderMainItem, new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure, config);
  } else {
AttrOrderItemEntries = ssConectaProveedores.RestRecords.JSONEN_0eb2cf39b93366f50855e537f6b98500EntityRecord.FromStructure(s.ssENOrderItemEntries, config);
AttrOrderMainItem = ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure(s.ssENOrderMainItem, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_cf58ea0f756ca06745169deb0b41c0eb, RC_cf58ea0f756ca06745169deb0b41c0eb> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_cf58ea0f756ca06745169deb0b41c0eb s) => ToStructure(s, config);
}
public static RC_cf58ea0f756ca06745169deb0b41c0eb ToStructure(ssConectaProveedores.RestRecords.JSONRC_cf58ea0f756ca06745169deb0b41c0eb obj, IBehaviorsConfiguration config) { 
  RC_cf58ea0f756ca06745169deb0b41c0eb s = new RC_cf58ea0f756ca06745169deb0b41c0eb();
  if(obj != null) {
  s.ssENOrderItemEntries = ssConectaProveedores.RestRecords.JSONEN_0eb2cf39b93366f50855e537f6b98500EntityRecord.ToStructure(obj.AttrOrderItemEntries, config);
  s.ssENOrderMainItem = ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.ToStructure(obj.AttrOrderMainItem, config);
  }
  return s;
}

public static Func<RC_cf58ea0f756ca06745169deb0b41c0eb, ssConectaProveedores.RestRecords.JSONRC_cf58ea0f756ca06745169deb0b41c0eb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cf58ea0f756ca06745169deb0b41c0eb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_cf58ea0f756ca06745169deb0b41c0eb FromStructure(RC_cf58ea0f756ca06745169deb0b41c0eb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_cf58ea0f756ca06745169deb0b41c0eb(s, config);
}

}


