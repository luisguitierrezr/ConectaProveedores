using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Z01_READ_TEXTResp
public class JSONST_cc99e347274d861473c4d7d08b6332b6Structure : AbstractRESTStructure<ST_cc99e347274d861473c4d7d08b6332b6Structure> {
[JsonProperty("LINES")]
[JsonPropertyName("LINES")]
public ssConectaProveedores.RestRecords.JSONST_1ebe89bcb89e874288df8fa96ba9996fStructure[] AttrLINES;

public JSONST_cc99e347274d861473c4d7d08b6332b6Structure() { }

public JSONST_cc99e347274d861473c4d7d08b6332b6Structure (ST_cc99e347274d861473c4d7d08b6332b6Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLINES = s.ssLINES.Length == 0 ? null : s.ssLINES.ToArray<ssConectaProveedores.RestRecords.JSONST_1ebe89bcb89e874288df8fa96ba9996fStructure>(ssConectaProveedores.RestRecords.JSONST_1ebe89bcb89e874288df8fa96ba9996fStructure.FromStructureDelegate(config));
  } else {
AttrLINES = s.ssLINES.ToArray<ssConectaProveedores.RestRecords.JSONST_1ebe89bcb89e874288df8fa96ba9996fStructure>(ssConectaProveedores.RestRecords.JSONST_1ebe89bcb89e874288df8fa96ba9996fStructure.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_cc99e347274d861473c4d7d08b6332b6Structure, ST_cc99e347274d861473c4d7d08b6332b6Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_cc99e347274d861473c4d7d08b6332b6Structure s) => ToStructure(s, config);
}
public static ST_cc99e347274d861473c4d7d08b6332b6Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_cc99e347274d861473c4d7d08b6332b6Structure obj, IBehaviorsConfiguration config) { 
  ST_cc99e347274d861473c4d7d08b6332b6Structure s = new ST_cc99e347274d861473c4d7d08b6332b6Structure();
  if(obj != null) {
  s.ssLINES = RL_9f464d3e6033d129f48cd86ef45da46f.ToList(obj.AttrLINES, ssConectaProveedores.RestRecords.JSONST_1ebe89bcb89e874288df8fa96ba9996fStructure.ToStructureDelegate(config));
  }
  return s;
}

public static Func<ST_cc99e347274d861473c4d7d08b6332b6Structure, ssConectaProveedores.RestRecords.JSONST_cc99e347274d861473c4d7d08b6332b6Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_cc99e347274d861473c4d7d08b6332b6Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_cc99e347274d861473c4d7d08b6332b6Structure FromStructure(ST_cc99e347274d861473c4d7d08b6332b6Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_cc99e347274d861473c4d7d08b6332b6Structure(s, config);
}

}


