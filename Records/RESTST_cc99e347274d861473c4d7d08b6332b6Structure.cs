using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Z01_READ_TEXTResp
public class RESTST_cc99e347274d861473c4d7d08b6332b6Structure : AbstractRESTStructure<ST_cc99e347274d861473c4d7d08b6332b6Structure> {
[JsonProperty("LINES")]
public RestList<ssConectaProveedores.RestRecords.RESTST_1ebe89bcb89e874288df8fa96ba9996fStructure> AttrLINES;

public RESTST_cc99e347274d861473c4d7d08b6332b6Structure() { }

public RESTST_cc99e347274d861473c4d7d08b6332b6Structure (ST_cc99e347274d861473c4d7d08b6332b6Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLINES = s.ssLINES.Length == 0 ? null : s.ssLINES.ToRestList<ssConectaProveedores.RestRecords.RESTST_1ebe89bcb89e874288df8fa96ba9996fStructure>(ssConectaProveedores.RestRecords.RESTST_1ebe89bcb89e874288df8fa96ba9996fStructure.FromStructureDelegate(config));
  } else {
AttrLINES = s.ssLINES.ToRestList<ssConectaProveedores.RestRecords.RESTST_1ebe89bcb89e874288df8fa96ba9996fStructure>(ssConectaProveedores.RestRecords.RESTST_1ebe89bcb89e874288df8fa96ba9996fStructure.FromStructureDelegate(config));
  }
}

public static ST_cc99e347274d861473c4d7d08b6332b6Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_cc99e347274d861473c4d7d08b6332b6Structure obj) { 
  ST_cc99e347274d861473c4d7d08b6332b6Structure s = new ST_cc99e347274d861473c4d7d08b6332b6Structure();
  if(obj != null) {
  s.ssLINES = RL_9f464d3e6033d129f48cd86ef45da46f.FromRestList(obj.AttrLINES, ssConectaProveedores.RestRecords.RESTST_1ebe89bcb89e874288df8fa96ba9996fStructure.ToStructure);
  }
  return s;
}

public static Func<ST_cc99e347274d861473c4d7d08b6332b6Structure, ssConectaProveedores.RestRecords.RESTST_cc99e347274d861473c4d7d08b6332b6Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_cc99e347274d861473c4d7d08b6332b6Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_cc99e347274d861473c4d7d08b6332b6Structure FromStructure(ST_cc99e347274d861473c4d7d08b6332b6Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_cc99e347274d861473c4d7d08b6332b6Structure(s, config);
}

}


