using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainItemTotalSAPRecord
public class JSONRC_ef010366b3d2f0bfd976457513e62527 : AbstractRESTStructure<RC_ef010366b3d2f0bfd976457513e62527> {
[JsonProperty("OrderMainItem")]
[JsonPropertyName("OrderMainItem")]
public ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord AttrOrderMainItem;

[JsonProperty("TotalSAP")]
[JsonPropertyName("TotalSAP")]
public decimal? AttrTotalSAP;

public JSONRC_ef010366b3d2f0bfd976457513e62527() { }

public JSONRC_ef010366b3d2f0bfd976457513e62527 (RC_ef010366b3d2f0bfd976457513e62527 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMainItem = ConvertToRestWithoutDefaults(s.ssENOrderMainItem, new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure, config);
AttrTotalSAP = ConvertToRestWithoutDefaults(s.ssTotalSAP, 0.0M);
  } else {
AttrOrderMainItem = ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure(s.ssENOrderMainItem, config);
AttrTotalSAP = (decimal?) s.ssTotalSAP;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_ef010366b3d2f0bfd976457513e62527, RC_ef010366b3d2f0bfd976457513e62527> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_ef010366b3d2f0bfd976457513e62527 s) => ToStructure(s, config);
}
public static RC_ef010366b3d2f0bfd976457513e62527 ToStructure(ssConectaProveedores.RestRecords.JSONRC_ef010366b3d2f0bfd976457513e62527 obj, IBehaviorsConfiguration config) { 
  RC_ef010366b3d2f0bfd976457513e62527 s = new RC_ef010366b3d2f0bfd976457513e62527();
  if(obj != null) {
  s.ssENOrderMainItem = ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.ToStructure(obj.AttrOrderMainItem, config);
  s.ssTotalSAP = obj.AttrTotalSAP == null ? 0.0M : obj.AttrTotalSAP.Value;
  }
  return s;
}

public static Func<RC_ef010366b3d2f0bfd976457513e62527, ssConectaProveedores.RestRecords.JSONRC_ef010366b3d2f0bfd976457513e62527> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ef010366b3d2f0bfd976457513e62527 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_ef010366b3d2f0bfd976457513e62527 FromStructure(RC_ef010366b3d2f0bfd976457513e62527 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_ef010366b3d2f0bfd976457513e62527(s, config);
}

}


