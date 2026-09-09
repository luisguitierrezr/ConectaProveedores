using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainItemRecord
public class RESTRC_c4cc207f9017de4e013fabcf1e8ebeaf : AbstractRESTStructure<RC_c4cc207f9017de4e013fabcf1e8ebeaf> {
[JsonProperty("OrderMainItem")]
public ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord AttrOrderMainItem;

public RESTRC_c4cc207f9017de4e013fabcf1e8ebeaf() { }

public RESTRC_c4cc207f9017de4e013fabcf1e8ebeaf (RC_c4cc207f9017de4e013fabcf1e8ebeaf s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMainItem = ConvertToRestWithoutDefaults(s.ssENOrderMainItem, new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure, config);
  } else {
AttrOrderMainItem = ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure(s.ssENOrderMainItem, config);
  }
}

public static RC_c4cc207f9017de4e013fabcf1e8ebeaf ToStructure(ssConectaProveedores.RestRecords.RESTRC_c4cc207f9017de4e013fabcf1e8ebeaf obj) { 
  RC_c4cc207f9017de4e013fabcf1e8ebeaf s = new RC_c4cc207f9017de4e013fabcf1e8ebeaf();
  if(obj != null) {
  s.ssENOrderMainItem = ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.ToStructure(obj.AttrOrderMainItem);
  }
  return s;
}

public static Func<RC_c4cc207f9017de4e013fabcf1e8ebeaf, ssConectaProveedores.RestRecords.RESTRC_c4cc207f9017de4e013fabcf1e8ebeaf> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c4cc207f9017de4e013fabcf1e8ebeaf s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_c4cc207f9017de4e013fabcf1e8ebeaf FromStructure(RC_c4cc207f9017de4e013fabcf1e8ebeaf s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_c4cc207f9017de4e013fabcf1e8ebeaf(s, config);
}

}


