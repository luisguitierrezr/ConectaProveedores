using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderItemEntriesOrderMainItemRecord
public class RESTRC_cf58ea0f756ca06745169deb0b41c0eb : AbstractRESTStructure<RC_cf58ea0f756ca06745169deb0b41c0eb> {
[JsonProperty("OrderItemEntries")]
public ssConectaProveedores.RestRecords.RESTEN_0eb2cf39b93366f50855e537f6b98500EntityRecord AttrOrderItemEntries;

[JsonProperty("OrderMainItem")]
public ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord AttrOrderMainItem;

public RESTRC_cf58ea0f756ca06745169deb0b41c0eb() { }

public RESTRC_cf58ea0f756ca06745169deb0b41c0eb (RC_cf58ea0f756ca06745169deb0b41c0eb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderItemEntries = ConvertToRestWithoutDefaults(s.ssENOrderItemEntries, new EN_0eb2cf39b93366f50855e537f6b98500EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_0eb2cf39b93366f50855e537f6b98500EntityRecord.FromStructure, config);
AttrOrderMainItem = ConvertToRestWithoutDefaults(s.ssENOrderMainItem, new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure, config);
  } else {
AttrOrderItemEntries = ssConectaProveedores.RestRecords.RESTEN_0eb2cf39b93366f50855e537f6b98500EntityRecord.FromStructure(s.ssENOrderItemEntries, config);
AttrOrderMainItem = ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure(s.ssENOrderMainItem, config);
  }
}

public static RC_cf58ea0f756ca06745169deb0b41c0eb ToStructure(ssConectaProveedores.RestRecords.RESTRC_cf58ea0f756ca06745169deb0b41c0eb obj) { 
  RC_cf58ea0f756ca06745169deb0b41c0eb s = new RC_cf58ea0f756ca06745169deb0b41c0eb();
  if(obj != null) {
  s.ssENOrderItemEntries = ssConectaProveedores.RestRecords.RESTEN_0eb2cf39b93366f50855e537f6b98500EntityRecord.ToStructure(obj.AttrOrderItemEntries);
  s.ssENOrderMainItem = ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.ToStructure(obj.AttrOrderMainItem);
  }
  return s;
}

public static Func<RC_cf58ea0f756ca06745169deb0b41c0eb, ssConectaProveedores.RestRecords.RESTRC_cf58ea0f756ca06745169deb0b41c0eb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cf58ea0f756ca06745169deb0b41c0eb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_cf58ea0f756ca06745169deb0b41c0eb FromStructure(RC_cf58ea0f756ca06745169deb0b41c0eb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_cf58ea0f756ca06745169deb0b41c0eb(s, config);
}

}


