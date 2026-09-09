using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainItemRecord
public class JSONRC_c4cc207f9017de4e013fabcf1e8ebeaf : AbstractRESTStructure<RC_c4cc207f9017de4e013fabcf1e8ebeaf> {
[JsonProperty("OrderMainItem")]
[JsonPropertyName("OrderMainItem")]
public ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord AttrOrderMainItem;

public JSONRC_c4cc207f9017de4e013fabcf1e8ebeaf() { }

public JSONRC_c4cc207f9017de4e013fabcf1e8ebeaf (RC_c4cc207f9017de4e013fabcf1e8ebeaf s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMainItem = ConvertToRestWithoutDefaults(s.ssENOrderMainItem, new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure, config);
  } else {
AttrOrderMainItem = ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure(s.ssENOrderMainItem, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_c4cc207f9017de4e013fabcf1e8ebeaf, RC_c4cc207f9017de4e013fabcf1e8ebeaf> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_c4cc207f9017de4e013fabcf1e8ebeaf s) => ToStructure(s, config);
}
public static RC_c4cc207f9017de4e013fabcf1e8ebeaf ToStructure(ssConectaProveedores.RestRecords.JSONRC_c4cc207f9017de4e013fabcf1e8ebeaf obj, IBehaviorsConfiguration config) { 
  RC_c4cc207f9017de4e013fabcf1e8ebeaf s = new RC_c4cc207f9017de4e013fabcf1e8ebeaf();
  if(obj != null) {
  s.ssENOrderMainItem = ssConectaProveedores.RestRecords.JSONEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.ToStructure(obj.AttrOrderMainItem, config);
  }
  return s;
}

public static Func<RC_c4cc207f9017de4e013fabcf1e8ebeaf, ssConectaProveedores.RestRecords.JSONRC_c4cc207f9017de4e013fabcf1e8ebeaf> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c4cc207f9017de4e013fabcf1e8ebeaf s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_c4cc207f9017de4e013fabcf1e8ebeaf FromStructure(RC_c4cc207f9017de4e013fabcf1e8ebeaf s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_c4cc207f9017de4e013fabcf1e8ebeaf(s, config);
}

}


